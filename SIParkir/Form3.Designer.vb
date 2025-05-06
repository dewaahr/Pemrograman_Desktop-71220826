<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLangganan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLangganan))
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblNoPlat = New System.Windows.Forms.Label()
        Me.lblBiaya = New System.Windows.Forms.Label()
        Me.lblExpired = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblJenis = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.iduser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomorplat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pemilik = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.biaya = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.expired = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.cmbJenis = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtNoPlat = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtBiaya = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNama.Location = New System.Drawing.Point(42, 62)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(53, 20)
        Me.lblNama.TabIndex = 0
        Me.lblNama.Text = "Nama"
        '
        'lblNoPlat
        '
        Me.lblNoPlat.AutoSize = True
        Me.lblNoPlat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoPlat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNoPlat.Location = New System.Drawing.Point(42, 27)
        Me.lblNoPlat.Name = "lblNoPlat"
        Me.lblNoPlat.Size = New System.Drawing.Size(93, 20)
        Me.lblNoPlat.TabIndex = 1
        Me.lblNoPlat.Text = "Nomor Plat"
        '
        'lblBiaya
        '
        Me.lblBiaya.AutoSize = True
        Me.lblBiaya.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBiaya.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblBiaya.Location = New System.Drawing.Point(42, 99)
        Me.lblBiaya.Name = "lblBiaya"
        Me.lblBiaya.Size = New System.Drawing.Size(130, 20)
        Me.lblBiaya.TabIndex = 2
        Me.lblBiaya.Text = "Tarif Langganan"
        '
        'lblExpired
        '
        Me.lblExpired.AutoSize = True
        Me.lblExpired.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpired.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblExpired.Location = New System.Drawing.Point(42, 142)
        Me.lblExpired.Name = "lblExpired"
        Me.lblExpired.Size = New System.Drawing.Size(124, 20)
        Me.lblExpired.TabIndex = 3
        Me.lblExpired.Text = "Berlaku Hingga"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(468, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ID Pelanggan:"
        '
        'lblJenis
        '
        Me.lblJenis.AutoSize = True
        Me.lblJenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJenis.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblJenis.Location = New System.Drawing.Point(468, 99)
        Me.lblJenis.Name = "lblJenis"
        Me.lblJenis.Size = New System.Drawing.Size(49, 20)
        Me.lblJenis.TabIndex = 5
        Me.lblJenis.Text = "Jenis"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(58, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(251, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Kendarran Terdaftar Langganan:"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.iduser, Me.nomorplat, Me.pemilik, Me.biaya, Me.jenis, Me.expired})
        Me.DataGridView1.Location = New System.Drawing.Point(62, 233)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(679, 156)
        Me.DataGridView1.TabIndex = 7
        '
        'iduser
        '
        Me.iduser.HeaderText = "Id"
        Me.iduser.MinimumWidth = 6
        Me.iduser.Name = "iduser"
        Me.iduser.ReadOnly = True
        Me.iduser.Visible = False
        Me.iduser.Width = 125
        '
        'nomorplat
        '
        Me.nomorplat.HeaderText = "No Plat"
        Me.nomorplat.MinimumWidth = 6
        Me.nomorplat.Name = "nomorplat"
        Me.nomorplat.Width = 125
        '
        'pemilik
        '
        Me.pemilik.HeaderText = "Nama Pemilik"
        Me.pemilik.MinimumWidth = 6
        Me.pemilik.Name = "pemilik"
        Me.pemilik.Width = 125
        '
        'biaya
        '
        Me.biaya.HeaderText = "Biaya"
        Me.biaya.MinimumWidth = 6
        Me.biaya.Name = "biaya"
        Me.biaya.Width = 125
        '
        'jenis
        '
        Me.jenis.HeaderText = "Jenis"
        Me.jenis.MinimumWidth = 6
        Me.jenis.Name = "jenis"
        Me.jenis.Width = 125
        '
        'expired
        '
        Me.expired.HeaderText = "Expired"
        Me.expired.MinimumWidth = 6
        Me.expired.Name = "expired"
        Me.expired.Width = 125
        '
        'BtnTutup
        '
        Me.BtnTutup.Location = New System.Drawing.Point(663, 395)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(110, 43)
        Me.BtnTutup.TabIndex = 8
        Me.BtnTutup.Text = "Tutup"
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(315, 176)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(110, 43)
        Me.btnTambah.TabIndex = 9
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(431, 176)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(110, 43)
        Me.btnEdit.TabIndex = 10
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(547, 176)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(110, 43)
        Me.btnHapus.TabIndex = 11
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'cmbJenis
        '
        Me.cmbJenis.FormattingEnabled = True
        Me.cmbJenis.Items.AddRange(New Object() {"Motor", "Mobil", "Taxi/Umum", "Truk", "Sepeda"})
        Me.cmbJenis.Location = New System.Drawing.Point(523, 99)
        Me.cmbJenis.Name = "cmbJenis"
        Me.cmbJenis.Size = New System.Drawing.Size(121, 24)
        Me.cmbJenis.TabIndex = 12
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(216, 140)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 13
        '
        'txtNoPlat
        '
        Me.txtNoPlat.Location = New System.Drawing.Point(188, 27)
        Me.txtNoPlat.Name = "txtNoPlat"
        Me.txtNoPlat.Size = New System.Drawing.Size(254, 22)
        Me.txtNoPlat.TabIndex = 14
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(188, 62)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(254, 22)
        Me.txtNama.TabIndex = 15
        '
        'txtBiaya
        '
        Me.txtBiaya.Location = New System.Drawing.Point(188, 101)
        Me.txtBiaya.Name = "txtBiaya"
        Me.txtBiaya.Size = New System.Drawing.Size(254, 22)
        Me.txtBiaya.TabIndex = 16
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.BackColor = System.Drawing.Color.White
        Me.lblId.Location = New System.Drawing.Point(379, 32)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(48, 16)
        Me.lblId.TabIndex = 17
        Me.lblId.Text = "Label8"
        Me.lblId.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(663, 176)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(110, 43)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.Text = "Batal"
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.Visible = False
        '
        'frmLangganan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.txtBiaya)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNoPlat)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.cmbJenis)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblJenis)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblExpired)
        Me.Controls.Add(Me.lblBiaya)
        Me.Controls.Add(Me.lblNoPlat)
        Me.Controls.Add(Me.lblNama)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmLangganan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SiParkir - Langganan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNama As Label
    Friend WithEvents lblNoPlat As Label
    Friend WithEvents lblBiaya As Label
    Friend WithEvents lblExpired As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblJenis As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnTutup As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents cmbJenis As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtNoPlat As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtBiaya As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents iduser As DataGridViewTextBoxColumn
    Friend WithEvents nomorplat As DataGridViewTextBoxColumn
    Friend WithEvents pemilik As DataGridViewTextBoxColumn
    Friend WithEvents biaya As DataGridViewTextBoxColumn
    Friend WithEvents jenis As DataGridViewTextBoxColumn
    Friend WithEvents expired As DataGridViewTextBoxColumn
End Class
