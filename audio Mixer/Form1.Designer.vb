<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.volume = New System.Windows.Forms.TrackBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.volumeindex = New System.Windows.Forms.Label()
        Me.ComboBoxOutputDevice = New System.Windows.Forms.ComboBox()
        Me.inputdvc = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timermusic = New System.Windows.Forms.Label()
        Me.TrackBarApp1 = New System.Windows.Forms.TrackBar()
        Me.TrackBarApp2 = New System.Windows.Forms.TrackBar()
        Me.VApp = New System.Windows.Forms.Label()
        Me.VApp2 = New System.Windows.Forms.Label()
        Me.ButtonTimer = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerAppDetect = New System.Windows.Forms.Timer(Me.components)
        CType(Me.volume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarApp1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarApp2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MUSICNET", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Volume"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MUSICNET", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(12, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Output Device"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MUSICNET", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(12, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Input Device"
        '
        'volume
        '
        Me.volume.Location = New System.Drawing.Point(276, 9)
        Me.volume.Name = "volume"
        Me.volume.Size = New System.Drawing.Size(283, 56)
        Me.volume.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(253, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 40)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'volumeindex
        '
        Me.volumeindex.AutoSize = True
        Me.volumeindex.BackColor = System.Drawing.Color.Transparent
        Me.volumeindex.Font = New System.Drawing.Font("Niagara Solid", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.volumeindex.ForeColor = System.Drawing.Color.Orange
        Me.volumeindex.Location = New System.Drawing.Point(565, 9)
        Me.volumeindex.Name = "volumeindex"
        Me.volumeindex.Size = New System.Drawing.Size(47, 30)
        Me.volumeindex.TabIndex = 5
        Me.volumeindex.Text = "100%"
        '
        'ComboBoxOutputDevice
        '
        Me.ComboBoxOutputDevice.FormattingEnabled = True
        Me.ComboBoxOutputDevice.Location = New System.Drawing.Point(253, 56)
        Me.ComboBoxOutputDevice.Name = "ComboBoxOutputDevice"
        Me.ComboBoxOutputDevice.Size = New System.Drawing.Size(365, 24)
        Me.ComboBoxOutputDevice.TabIndex = 8
        '
        'inputdvc
        '
        Me.inputdvc.FormattingEnabled = True
        Me.inputdvc.Location = New System.Drawing.Point(253, 101)
        Me.inputdvc.Name = "inputdvc"
        Me.inputdvc.Size = New System.Drawing.Size(365, 24)
        Me.inputdvc.TabIndex = 9
        '
        'Timer1
        '
        '
        'timermusic
        '
        Me.timermusic.AutoSize = True
        Me.timermusic.Font = New System.Drawing.Font("Niagara Solid", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timermusic.ForeColor = System.Drawing.SystemColors.Control
        Me.timermusic.Location = New System.Drawing.Point(462, 149)
        Me.timermusic.Name = "timermusic"
        Me.timermusic.Size = New System.Drawing.Size(97, 24)
        Me.timermusic.TabIndex = 12
        Me.timermusic.Text = "Timer 00.00.00"
        '
        'TrackBarApp1
        '
        Me.TrackBarApp1.Location = New System.Drawing.Point(276, 208)
        Me.TrackBarApp1.Name = "TrackBarApp1"
        Me.TrackBarApp1.Size = New System.Drawing.Size(342, 56)
        Me.TrackBarApp1.TabIndex = 13
        Me.TrackBarApp1.Value = 10
        '
        'TrackBarApp2
        '
        Me.TrackBarApp2.Location = New System.Drawing.Point(276, 257)
        Me.TrackBarApp2.Name = "TrackBarApp2"
        Me.TrackBarApp2.Size = New System.Drawing.Size(342, 56)
        Me.TrackBarApp2.TabIndex = 14
        Me.TrackBarApp2.Value = 1
        Me.TrackBarApp2.Visible = False
        '
        'VApp
        '
        Me.VApp.AutoSize = True
        Me.VApp.Font = New System.Drawing.Font("MUSICNET", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VApp.ForeColor = System.Drawing.Color.Orange
        Me.VApp.Location = New System.Drawing.Point(38, 217)
        Me.VApp.Name = "VApp"
        Me.VApp.Size = New System.Drawing.Size(96, 21)
        Me.VApp.TabIndex = 15
        Me.VApp.Text = "Device"
        '
        'VApp2
        '
        Me.VApp2.AutoSize = True
        Me.VApp2.Font = New System.Drawing.Font("MUSICNET", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VApp2.ForeColor = System.Drawing.Color.Orange
        Me.VApp2.Location = New System.Drawing.Point(38, 257)
        Me.VApp2.Name = "VApp2"
        Me.VApp2.Size = New System.Drawing.Size(96, 21)
        Me.VApp2.TabIndex = 16
        Me.VApp2.Text = "Device"
        Me.VApp2.Visible = False
        '
        'ButtonTimer
        '
        Me.ButtonTimer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonTimer.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ButtonTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTimer.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.ButtonTimer.Image = CType(resources.GetObject("ButtonTimer.Image"), System.Drawing.Image)
        Me.ButtonTimer.Location = New System.Drawing.Point(559, 131)
        Me.ButtonTimer.Name = "ButtonTimer"
        Me.ButtonTimer.Size = New System.Drawing.Size(59, 58)
        Me.ButtonTimer.TabIndex = 17
        Me.ButtonTimer.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ClientSize = New System.Drawing.Size(641, 335)
        Me.Controls.Add(Me.ButtonTimer)
        Me.Controls.Add(Me.VApp2)
        Me.Controls.Add(Me.VApp)
        Me.Controls.Add(Me.TrackBarApp2)
        Me.Controls.Add(Me.TrackBarApp1)
        Me.Controls.Add(Me.timermusic)
        Me.Controls.Add(Me.inputdvc)
        Me.Controls.Add(Me.ComboBoxOutputDevice)
        Me.Controls.Add(Me.volumeindex)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.volume)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Audio Mixer"
        CType(Me.volume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarApp1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarApp2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents volume As TrackBar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents volumeindex As Label
    Friend WithEvents ComboBoxOutputDevice As ComboBox
    Friend WithEvents inputdvc As ComboBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents timermusic As Label
    Friend WithEvents TrackBarApp1 As TrackBar
    Friend WithEvents TrackBarApp2 As TrackBar
    Friend WithEvents VApp As Label
    Friend WithEvents VApp2 As Label
    Friend WithEvents ButtonTimer As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents TimerAppDetect As Timer
End Class
