Imports System.IO
Imports System.Drawing.Imaging
Imports gma.Drawing.ImageInfo
Imports System.Net.Mime.MediaTypeNames

Public Class Form1
    ' Fungsi untuk memformat ukuran file dalam byte, Kb, Mb, atau Gb
    Private Function FormatFileSize(ByVal FileSizeBytes As Long) As String
        Dim sizeTypes() As String = {"b", "Kb", "Mb", "Gb"}
        Dim Len As Decimal = FileSizeBytes
        Dim sizeType As Integer = 0

        Do While Len > 1024
            Len = Decimal.Round(Len / 1024, 2)
            sizeType += 1
            If sizeType >= sizeTypes.Length - 1 Then Exit Do
        Loop

        Return Len.ToString() & " " & sizeTypes(sizeType)
    End Function

    ' Fungsi untuk mengambil semua file dalam folder
    Private Sub GetFiles(ByVal PathName As String)
        Dim LItem As ListViewItem

        lvImage.Items.Clear()
        lvImage.BeginUpdate()

        For Each nFile As String In Directory.GetFiles(PathName)
            Dim sExtension As String = Path.GetExtension(nFile).ToLower()
            Dim f As FileInfo = New FileInfo(nFile)

            If {".bmp", ".jpg", ".jpeg", ".gif", ".png"}.Contains(sExtension) Then
                LItem = New ListViewItem()
                Dim iconForFile As Icon = SystemIcons.WinLogo

                If Not ImageList1.Images.ContainsKey(sExtension) Then
                    iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(nFile)
                    ImageList1.Images.Add(sExtension, iconForFile)
                End If

                With LItem
                    .Text = Path.GetFileNameWithoutExtension(nFile)
                    .SubItems.AddRange({sExtension, FormatFileSize(f.Length), f.LastWriteTime.ToString(), f.LastAccessTime.ToString(), f.CreationTime.ToString(), f.Attributes.ToString()})
                    .ImageKey = sExtension
                    .Tag = Path.Combine(PathName, nFile)
                End With

                lvImage.Items.Add(LItem)
            End If
        Next

        lvImage.EndUpdate()
        lvImage.Columns(0).Width = -2
    End Sub

    ' Fungsi untuk mendapatkan folder dari direktori tertentu
    Private Sub GetFolders(ByVal PathName As TreeNode)
        Dim di As DirectoryInfo = New DirectoryInfo(PathName.Tag)
        PathName.Nodes.Clear()

        Try
            For Each nFolder In di.GetDirectories()
                Dim tNode As New TreeNode() With {
                    .ImageIndex = 1,
                    .SelectedImageIndex = 1,
                    .Tag = nFolder.FullName,
                    .Text = nFolder.Name
                }
                tNode.Nodes.Add("")

                If (New DirectoryInfo(tNode.Tag).Attributes And FileAttributes.Hidden) = False Then
                    PathName.Nodes.Add(tNode)
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub

    ' Fungsi untuk mendapatkan semua drive yang tersedia
    Private Sub GetDrives()
        For Each Drive In DriveInfo.GetDrives()
            If Drive.IsReady Then
                Dim dName As String = If(String.IsNullOrEmpty(Drive.VolumeLabel), Drive.Name, Drive.VolumeLabel)
                Dim tNode As New TreeNode() With {
                    .ImageIndex = 0,
                    .SelectedImageIndex = 0,
                    .Text = dName,
                    .Tag = Drive.Name
                }
                tNode.Nodes.Add("")
                tvDrive.Nodes.Add(tNode)
            End If
        Next
    End Sub

    ' Fungsi untuk mendapatkan format gambar
    Private Function GetRaw(ByVal imgf As ImageFormat) As String
        Select Case True
            Case imgf.Equals(ImageFormat.Bmp)
                Return "Bitmap"
            Case imgf.Equals(ImageFormat.Jpeg)
                Return "Jpeg"
            Case imgf.Equals(ImageFormat.Png)
                Return "PNG"
            Case imgf.Equals(ImageFormat.Tiff)
                Return "TIFF"
            Case imgf.Equals(ImageFormat.Gif)
                Return "GIF"
            Case imgf.Equals(ImageFormat.Icon)
                Return "ICON"
            Case Else
                Return "Unknown"
        End Select
    End Function

    ' Event saat form pertama kali dibuat
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetDrives()
        lvImage.Columns(0).Width = -2
        SplitContainerBawah2.Panel2.VerticalScroll.Visible = True
        SplitContainerBawah2.Panel2.HorizontalScroll.Visible = True
    End Sub

    ' Event saat tree view dikembangkan
    Private Sub tvDrive_BeforeExpand(sender As Object, e As TreeViewCancelEventArgs) Handles tvDrive.BeforeExpand
        GetFolders(e.Node)
    End Sub

    ' Event setelah folder dipilih pada tree view
    Private Sub tvDrive_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvDrive.AfterSelect
        GetFiles(e.Node.Tag)
    End Sub

    ' Event saat gambar dipilih di list view
    Private Sub lvImage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvImage.SelectedIndexChanged
        Dim _exif As Info
        lvExif.Items.Clear()

        If lvImage.SelectedItems.Count > 0 Then
            PictureBox1.Image = Bitmap.FromFile(lvImage.SelectedItems(0).Tag.ToString())
            ToolStripStatusReady.Text = lvImage.SelectedItems(0).Tag.ToString()
            ToolStripStatusDimension.Text = $"Dimension: {PictureBox1.Image.Size.Width} px X {PictureBox1.Image.Size.Height} px"
            ToolStripStatusBits.Text = $"Depth: {PictureBox1.Image.PixelFormat}"
            ToolStripStatusResolution.Text = $"Resolution: {PictureBox1.Image.HorizontalResolution} dpi X {PictureBox1.Image.VerticalResolution} dpi"
            ToolStripStatusRawFormat.Text = $"Compression: {GetRaw(PictureBox1.Image.RawFormat)}"

            _exif = New Info(lvImage.SelectedItems(0).Tag.ToString())
            PropertyGrid1.SelectedObject = _exif

            For Each propertyName As String In _exif.PropertyItems.Keys
                Try
                    Dim LItem As New ListViewItem() With {
                        .Text = propertyName
                    }
                    LItem.SubItems.Add(_exif.PropertyItems(propertyName).ToString())
                    lvExif.Items.Add(LItem)
                Catch ex As Exception
                End Try
            Next
        End If

        lvImage.Columns(0).Width = -2
        lvExif.Columns(0).Width = -2
    End Sub

    ' Event untuk membuka file dengan program default
    Private Sub lvImage_DoubleClick(sender As Object, e As EventArgs) Handles lvImage.DoubleClick
        Process.Start(lvImage.SelectedItems(0).Tag.ToString())
    End Sub

    ' Event untuk menampilkan gambar dalam ukuran asli
    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        Dim pb As New PictureBox With {
            .Image = Image.FromFile(ToolStripStatusReady.Text),
            .SizeMode = PictureBoxSizeMode.AutoSize
        }
        Dim pnl As New Panel With {
            .AutoScroll = True,
            .Dock = DockStyle.Fill
        }
        pnl.Controls.Add(pb)
        Dim f As New Form With {
            .WindowState = FormWindowState.Maximized
        }
        f.Controls.Add(pnl)
        f.Show()
    End Sub
End Class
