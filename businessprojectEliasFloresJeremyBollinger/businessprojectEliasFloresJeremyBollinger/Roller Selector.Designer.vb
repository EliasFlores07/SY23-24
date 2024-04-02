<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Roller_Selector
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.RollerRadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RollerRadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RollerRadioButton1 = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RollerRadioButton3
        '
        Me.RollerRadioButton3.AutoSize = True
        Me.RollerRadioButton3.Location = New System.Drawing.Point(286, 11)
        Me.RollerRadioButton3.Name = "RollerRadioButton3"
        Me.RollerRadioButton3.Size = New System.Drawing.Size(45, 20)
        Me.RollerRadioButton3.TabIndex = 54
        Me.RollerRadioButton3.TabStop = True
        Me.RollerRadioButton3.Text = "R3"
        Me.RollerRadioButton3.UseVisualStyleBackColor = True
        '
        'RollerRadioButton2
        '
        Me.RollerRadioButton2.AutoSize = True
        Me.RollerRadioButton2.Location = New System.Drawing.Point(157, 11)
        Me.RollerRadioButton2.Name = "RollerRadioButton2"
        Me.RollerRadioButton2.Size = New System.Drawing.Size(45, 20)
        Me.RollerRadioButton2.TabIndex = 53
        Me.RollerRadioButton2.TabStop = True
        Me.RollerRadioButton2.Text = "R2"
        Me.RollerRadioButton2.UseVisualStyleBackColor = True
        '
        'RollerRadioButton1
        '
        Me.RollerRadioButton1.AutoSize = True
        Me.RollerRadioButton1.Location = New System.Drawing.Point(27, 11)
        Me.RollerRadioButton1.Name = "RollerRadioButton1"
        Me.RollerRadioButton1.Size = New System.Drawing.Size(45, 20)
        Me.RollerRadioButton1.TabIndex = 52
        Me.RollerRadioButton1.TabStop = True
        Me.RollerRadioButton1.Text = "R1"
        Me.RollerRadioButton1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(358, 63)
        Me.PictureBox1.TabIndex = 55
        Me.PictureBox1.TabStop = False
        '
        'Roller_Selector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RollerRadioButton3)
        Me.Controls.Add(Me.RollerRadioButton2)
        Me.Controls.Add(Me.RollerRadioButton1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Roller_Selector"
        Me.Size = New System.Drawing.Size(361, 64)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RollerRadioButton3 As RadioButton
    Friend WithEvents RollerRadioButton2 As RadioButton
    Friend WithEvents RollerRadioButton1 As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
