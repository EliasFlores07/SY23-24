<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ECU_Selector
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
        Me.ECURadioButton3 = New System.Windows.Forms.RadioButton()
        Me.ECURadioButton2 = New System.Windows.Forms.RadioButton()
        Me.ECURadioButton1 = New System.Windows.Forms.RadioButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ECURadioButton3
        '
        Me.ECURadioButton3.AutoSize = True
        Me.ECURadioButton3.Location = New System.Drawing.Point(286, 11)
        Me.ECURadioButton3.Name = "ECURadioButton3"
        Me.ECURadioButton3.Size = New System.Drawing.Size(48, 20)
        Me.ECURadioButton3.TabIndex = 55
        Me.ECURadioButton3.TabStop = True
        Me.ECURadioButton3.Text = "W3"
        Me.ECURadioButton3.UseVisualStyleBackColor = True
        '
        'ECURadioButton2
        '
        Me.ECURadioButton2.AutoSize = True
        Me.ECURadioButton2.Location = New System.Drawing.Point(157, 11)
        Me.ECURadioButton2.Name = "ECURadioButton2"
        Me.ECURadioButton2.Size = New System.Drawing.Size(48, 20)
        Me.ECURadioButton2.TabIndex = 54
        Me.ECURadioButton2.TabStop = True
        Me.ECURadioButton2.Text = "W2"
        Me.ECURadioButton2.UseVisualStyleBackColor = True
        '
        'ECURadioButton1
        '
        Me.ECURadioButton1.AutoSize = True
        Me.ECURadioButton1.Location = New System.Drawing.Point(27, 11)
        Me.ECURadioButton1.Name = "ECURadioButton1"
        Me.ECURadioButton1.Size = New System.Drawing.Size(48, 20)
        Me.ECURadioButton1.TabIndex = 53
        Me.ECURadioButton1.TabStop = True
        Me.ECURadioButton1.Text = "W1"
        Me.ECURadioButton1.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(358, 63)
        Me.PictureBox2.TabIndex = 52
        Me.PictureBox2.TabStop = False
        '
        'ECU_Selector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ECURadioButton3)
        Me.Controls.Add(Me.ECURadioButton2)
        Me.Controls.Add(Me.ECURadioButton1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "ECU_Selector"
        Me.Size = New System.Drawing.Size(356, 62)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ECURadioButton3 As RadioButton
    Friend WithEvents ECURadioButton2 As RadioButton
    Friend WithEvents ECURadioButton1 As RadioButton
    Friend WithEvents PictureBox2 As PictureBox
End Class
