<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLaporan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLaporan))
        Me.ReportVie = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnLaporan = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'ReportVie
        '
        Me.ReportVie.Dock = System.Windows.Forms.DockStyle.Top
        Me.ReportVie.Location = New System.Drawing.Point(0, 0)
        Me.ReportVie.Name = "ReportVie"
        Me.ReportVie.ServerReport.BearerToken = Nothing
        Me.ReportVie.Size = New System.Drawing.Size(396, 246)
        Me.ReportVie.TabIndex = 0
        '
        'btnLaporan
        '
        Me.btnLaporan.Location = New System.Drawing.Point(37, 375)
        Me.btnLaporan.Name = "btnLaporan"
        Me.btnLaporan.Size = New System.Drawing.Size(276, 39)
        Me.btnLaporan.TabIndex = 0
        Me.btnLaporan.Text = "Laporan keseluruhan"
        Me.btnLaporan.UseVisualStyleBackColor = True
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(641, 375)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(122, 39)
        Me.btnTutup.TabIndex = 1
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(808, 332)
        Me.ReportViewer1.TabIndex = 2
        '
        'frmLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.btnLaporan)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLaporan"
        Me.Text = "Laporan Pendapatan"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportVie As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnLaporan As Button
    Friend WithEvents btnTutup As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
