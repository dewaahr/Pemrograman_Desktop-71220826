<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.buttonMinusMenit = New System.Windows.Forms.Button()
        Me.buttonPlusMenit = New System.Windows.Forms.Button()
        Me.lblMenit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.buttonPlusJam = New System.Windows.Forms.Button()
        Me.buttonMinusJam = New System.Windows.Forms.Button()
        Me.lblJam = New System.Windows.Forms.TextBox()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.ButtonPlusDetik = New System.Windows.Forms.Button()
        Me.ButtonMinusDetik = New System.Windows.Forms.Button()
        Me.labeldetk = New System.Windows.Forms.Label()
        Me.lblDetik = New System.Windows.Forms.TextBox()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnReset
        '
        Me.BtnReset.AutoSize = True
        Me.BtnReset.BackColor = System.Drawing.Color.Orange
        Me.BtnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReset.Font = New System.Drawing.Font("MUSICNET", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.BtnReset.Location = New System.Drawing.Point(386, 110)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(128, 59)
        Me.BtnReset.TabIndex = 0
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = False
        '
        'buttonMinusMenit
        '
        Me.buttonMinusMenit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonMinusMenit.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonMinusMenit.ForeColor = System.Drawing.Color.DarkOrange
        Me.buttonMinusMenit.Location = New System.Drawing.Point(195, 110)
        Me.buttonMinusMenit.Name = "buttonMinusMenit"
        Me.buttonMinusMenit.Size = New System.Drawing.Size(50, 52)
        Me.buttonMinusMenit.TabIndex = 3
        Me.buttonMinusMenit.Text = "-"
        Me.buttonMinusMenit.UseVisualStyleBackColor = True
        '
        'buttonPlusMenit
        '
        Me.buttonPlusMenit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonPlusMenit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonPlusMenit.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonPlusMenit.ForeColor = System.Drawing.Color.DarkOrange
        Me.buttonPlusMenit.Location = New System.Drawing.Point(31, 110)
        Me.buttonPlusMenit.Name = "buttonPlusMenit"
        Me.buttonPlusMenit.Size = New System.Drawing.Size(50, 52)
        Me.buttonPlusMenit.TabIndex = 4
        Me.buttonPlusMenit.Text = "+"
        Me.buttonPlusMenit.UseVisualStyleBackColor = True
        '
        'lblMenit
        '
        Me.lblMenit.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.lblMenit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblMenit.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenit.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblMenit.Location = New System.Drawing.Point(108, 110)
        Me.lblMenit.Name = "lblMenit"
        Me.lblMenit.Size = New System.Drawing.Size(50, 49)
        Me.lblMenit.TabIndex = 7
        Me.lblMenit.Text = "00"
        Me.lblMenit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MUSICNET", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(272, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 21)
        Me.Label1.TabIndex = 9
        Me.Label1.Tag = ""
        Me.Label1.Text = "Jam"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MUSICNET", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(272, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 21)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "menit"
        '
        'buttonPlusJam
        '
        Me.buttonPlusJam.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonPlusJam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonPlusJam.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonPlusJam.ForeColor = System.Drawing.Color.DarkOrange
        Me.buttonPlusJam.Location = New System.Drawing.Point(31, 31)
        Me.buttonPlusJam.Name = "buttonPlusJam"
        Me.buttonPlusJam.Size = New System.Drawing.Size(50, 52)
        Me.buttonPlusJam.TabIndex = 11
        Me.buttonPlusJam.Text = "+"
        Me.buttonPlusJam.UseVisualStyleBackColor = True
        '
        'buttonMinusJam
        '
        Me.buttonMinusJam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonMinusJam.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonMinusJam.ForeColor = System.Drawing.Color.DarkOrange
        Me.buttonMinusJam.Location = New System.Drawing.Point(195, 34)
        Me.buttonMinusJam.Name = "buttonMinusJam"
        Me.buttonMinusJam.Size = New System.Drawing.Size(50, 52)
        Me.buttonMinusJam.TabIndex = 12
        Me.buttonMinusJam.Text = "-"
        Me.buttonMinusJam.UseVisualStyleBackColor = True
        '
        'lblJam
        '
        Me.lblJam.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.lblJam.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblJam.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJam.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblJam.Location = New System.Drawing.Point(109, 31)
        Me.lblJam.Name = "lblJam"
        Me.lblJam.Size = New System.Drawing.Size(50, 49)
        Me.lblJam.TabIndex = 13
        Me.lblJam.Text = "00"
        Me.lblJam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnOk
        '
        Me.BtnOk.AutoSize = True
        Me.BtnOk.BackColor = System.Drawing.Color.Orange
        Me.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOk.Font = New System.Drawing.Font("MUSICNET", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOk.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.BtnOk.Location = New System.Drawing.Point(386, 182)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(128, 59)
        Me.BtnOk.TabIndex = 14
        Me.BtnOk.Text = "OK"
        Me.BtnOk.UseVisualStyleBackColor = False
        '
        'ButtonPlusDetik
        '
        Me.ButtonPlusDetik.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonPlusDetik.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPlusDetik.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPlusDetik.ForeColor = System.Drawing.Color.DarkOrange
        Me.ButtonPlusDetik.Location = New System.Drawing.Point(31, 192)
        Me.ButtonPlusDetik.Name = "ButtonPlusDetik"
        Me.ButtonPlusDetik.Size = New System.Drawing.Size(50, 52)
        Me.ButtonPlusDetik.TabIndex = 15
        Me.ButtonPlusDetik.Text = "+"
        Me.ButtonPlusDetik.UseVisualStyleBackColor = True
        '
        'ButtonMinusDetik
        '
        Me.ButtonMinusDetik.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMinusDetik.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMinusDetik.ForeColor = System.Drawing.Color.DarkOrange
        Me.ButtonMinusDetik.Location = New System.Drawing.Point(195, 192)
        Me.ButtonMinusDetik.Name = "ButtonMinusDetik"
        Me.ButtonMinusDetik.Size = New System.Drawing.Size(50, 52)
        Me.ButtonMinusDetik.TabIndex = 16
        Me.ButtonMinusDetik.Text = "-"
        Me.ButtonMinusDetik.UseVisualStyleBackColor = True
        '
        'labeldetk
        '
        Me.labeldetk.AutoSize = True
        Me.labeldetk.Font = New System.Drawing.Font("MUSICNET", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labeldetk.ForeColor = System.Drawing.Color.Orange
        Me.labeldetk.Location = New System.Drawing.Point(272, 205)
        Me.labeldetk.Name = "labeldetk"
        Me.labeldetk.Size = New System.Drawing.Size(75, 21)
        Me.labeldetk.TabIndex = 17
        Me.labeldetk.Text = "Detik"
        '
        'lblDetik
        '
        Me.lblDetik.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.lblDetik.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblDetik.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetik.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblDetik.Location = New System.Drawing.Point(109, 192)
        Me.lblDetik.Name = "lblDetik"
        Me.lblDetik.Size = New System.Drawing.Size(50, 49)
        Me.lblDetik.TabIndex = 18
        Me.lblDetik.Text = "00"
        Me.lblDetik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonBack
        '
        Me.ButtonBack.AutoSize = True
        Me.ButtonBack.BackColor = System.Drawing.Color.Orange
        Me.ButtonBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBack.Font = New System.Drawing.Font("MUSICNET", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBack.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.ButtonBack.Location = New System.Drawing.Point(386, 34)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(128, 59)
        Me.ButtonBack.TabIndex = 19
        Me.ButtonBack.Text = "Back"
        Me.ButtonBack.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ClientSize = New System.Drawing.Size(547, 270)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.lblDetik)
        Me.Controls.Add(Me.labeldetk)
        Me.Controls.Add(Me.ButtonMinusDetik)
        Me.Controls.Add(Me.ButtonPlusDetik)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.lblJam)
        Me.Controls.Add(Me.buttonMinusJam)
        Me.Controls.Add(Me.buttonPlusJam)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblMenit)
        Me.Controls.Add(Me.buttonPlusMenit)
        Me.Controls.Add(Me.buttonMinusMenit)
        Me.Controls.Add(Me.BtnReset)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Timer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnReset As Button
    Friend WithEvents buttonMinusMenit As Button
    Friend WithEvents buttonPlusMenit As Button
    Friend WithEvents lblMenit As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents buttonPlusJam As Button
    Friend WithEvents buttonMinusJam As Button
    Friend WithEvents lblJam As TextBox
    Friend WithEvents BtnOk As Button
    Friend WithEvents ButtonPlusDetik As Button
    Friend WithEvents ButtonMinusDetik As Button
    Friend WithEvents labeldetk As Label
    Friend WithEvents lblDetik As TextBox
    Friend WithEvents ButtonBack As Button
End Class
