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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        LabelCelc = New Label()
        ButtonConvert = New Button()
        valCelc = New TextBox()
        LabelFahr = New Label()
        LabelReam = New Label()
        LabelKelv = New Label()
        val1 = New TextBox()
        val2 = New TextBox()
        val3 = New TextBox()
        SuspendLayout()
        ' 
        ' LabelCelc
        ' 
        resources.ApplyResources(LabelCelc, "LabelCelc")
        LabelCelc.Name = "LabelCelc"
        ' 
        ' ButtonConvert
        ' 
        resources.ApplyResources(ButtonConvert, "ButtonConvert")
        ButtonConvert.Name = "ButtonConvert"
        ButtonConvert.UseVisualStyleBackColor = True
        ' 
        ' valCelc
        ' 
        resources.ApplyResources(valCelc, "valCelc")
        valCelc.Name = "valCelc"
        ' 
        ' LabelFahr
        ' 
        resources.ApplyResources(LabelFahr, "LabelFahr")
        LabelFahr.Name = "LabelFahr"
        ' 
        ' LabelReam
        ' 
        resources.ApplyResources(LabelReam, "LabelReam")
        LabelReam.Name = "LabelReam"
        ' 
        ' LabelKelv
        ' 
        resources.ApplyResources(LabelKelv, "LabelKelv")
        LabelKelv.Name = "LabelKelv"
        ' 
        ' val1
        ' 
        resources.ApplyResources(val1, "val1")
        val1.Name = "val1"
        val1.ReadOnly = True
        ' 
        ' val2
        ' 
        resources.ApplyResources(val2, "val2")
        val2.Name = "val2"
        val2.ReadOnly = True
        ' 
        ' val3
        ' 
        resources.ApplyResources(val3, "val3")
        val3.Name = "val3"
        val3.ReadOnly = True
        ' 
        ' Form1
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(val3)
        Controls.Add(val2)
        Controls.Add(val1)
        Controls.Add(LabelKelv)
        Controls.Add(LabelReam)
        Controls.Add(LabelFahr)
        Controls.Add(valCelc)
        Controls.Add(ButtonConvert)
        Controls.Add(LabelCelc)
        Name = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelCelc As Label
    Friend WithEvents ButtonConvert As Button
    Friend WithEvents valCelc As TextBox
    Friend WithEvents LabelFahr As Label
    Friend WithEvents LabelReam As Label
    Friend WithEvents LabelKelv As Label
    Friend WithEvents val1 As TextBox
    Friend WithEvents val2 As TextBox
    Friend WithEvents val3 As TextBox

End Class
