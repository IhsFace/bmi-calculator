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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtHeight = New TextBox()
        txtWeight = New TextBox()
        btnCalculate = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Label1.Location = New Point(235, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(324, 59)
        Label1.TabIndex = 0
        Label1.Text = "BMI Calculator"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(235, 167)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 32)
        Label2.TabIndex = 1
        Label2.Text = "Height"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(231, 237)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 32)
        Label3.TabIndex = 2
        Label3.Text = "Weight"
        ' 
        ' txtHeight
        ' 
        txtHeight.Location = New Point(404, 167)
        txtHeight.Name = "txtHeight"
        txtHeight.Size = New Size(200, 39)
        txtHeight.TabIndex = 3
        ' 
        ' txtWeight
        ' 
        txtWeight.Location = New Point(404, 234)
        txtWeight.Name = "txtWeight"
        txtWeight.Size = New Size(200, 39)
        txtWeight.TabIndex = 4
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(284, 333)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(225, 46)
        btnCalculate.TabIndex = 5
        btnCalculate.Text = "Calculate BMI"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PaleTurquoise
        ClientSize = New Size(800, 450)
        Controls.Add(btnCalculate)
        Controls.Add(txtWeight)
        Controls.Add(txtHeight)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents btnCalculate As Button

End Class
