<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        lbl1 = New Label()
        txtPath = New TextBox()
        btnPath = New Button()
        lblExt = New Label()
        txtExt = New TextBox()
        lblOri = New Label()
        lblPreview = New Label()
        ListView1 = New ListView()
        ListView2 = New ListView()
        SuspendLayout()
        ' 
        ' lbl1
        ' 
        lbl1.AutoSize = True
        lbl1.Location = New Point(12, 24)
        lbl1.Name = "lbl1"
        lbl1.Size = New Size(40, 20)
        lbl1.TabIndex = 0
        lbl1.Text = "Path:"
        ' 
        ' txtPath
        ' 
        txtPath.Location = New Point(58, 21)
        txtPath.Name = "txtPath"
        txtPath.ReadOnly = True
        txtPath.Size = New Size(604, 27)
        txtPath.TabIndex = 2
        ' 
        ' btnPath
        ' 
        btnPath.Location = New Point(665, 21)
        btnPath.Name = "btnPath"
        btnPath.Size = New Size(56, 29)
        btnPath.TabIndex = 3
        btnPath.Text = "..."
        btnPath.UseVisualStyleBackColor = True
        ' 
        ' lblExt
        ' 
        lblExt.AutoSize = True
        lblExt.Location = New Point(826, 27)
        lblExt.Name = "lblExt"
        lblExt.Size = New Size(56, 20)
        lblExt.TabIndex = 4
        lblExt.Text = "File Ext"
        ' 
        ' txtExt
        ' 
        txtExt.Location = New Point(888, 24)
        txtExt.Name = "txtExt"
        txtExt.Size = New Size(88, 27)
        txtExt.TabIndex = 5
        txtExt.Text = "*.*"
        ' 
        ' lblOri
        ' 
        lblOri.AutoSize = True
        lblOri.Location = New Point(7, 71)
        lblOri.Name = "lblOri"
        lblOri.Size = New Size(89, 20)
        lblOri.TabIndex = 6
        lblOri.Text = "Original File"
        ' 
        ' lblPreview
        ' 
        lblPreview.AutoSize = True
        lblPreview.Location = New Point(497, 71)
        lblPreview.Name = "lblPreview"
        lblPreview.Size = New Size(87, 20)
        lblPreview.TabIndex = 7
        lblPreview.Text = "Preview File"
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(7, 94)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(482, 220)
        ListView1.TabIndex = 8
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' ListView2
        ' 
        ListView2.Location = New Point(497, 94)
        ListView2.Name = "ListView2"
        ListView2.Size = New Size(482, 220)
        ListView2.TabIndex = 9
        ListView2.UseCompatibleStateImageBehavior = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(988, 475)
        Controls.Add(ListView2)
        Controls.Add(ListView1)
        Controls.Add(lblPreview)
        Controls.Add(lblOri)
        Controls.Add(txtExt)
        Controls.Add(lblExt)
        Controls.Add(btnPath)
        Controls.Add(txtPath)
        Controls.Add(lbl1)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mass Renamer"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents lbl1 As Label
    Friend WithEvents txtPath As TextBox
    Friend WithEvents btnPath As Button
    Friend WithEvents lblExt As Label
    Friend WithEvents txtExt As TextBox
    Friend WithEvents lblOri As Label
    Friend WithEvents lblPreview As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ListView2 As ListView

End Class
