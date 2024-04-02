<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transmission_Selector
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
        Me.TransmissionRadioButton3 = New System.Windows.Forms.RadioButton()
        Me.TransmissionRadioButton2 = New System.Windows.Forms.RadioButton()
        Me.TransmissionRadioButton1 = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TransmissionRadioButton3
        '
        Me.TransmissionRadioButton3.AutoSize = True
        Me.TransmissionRadioButton3.Location = New System.Drawing.Point(286, 11)
        Me.TransmissionRadioButton3.Name = "TransmissionRadioButton3"
        Me.TransmissionRadioButton3.Size = New System.Drawing.Size(44, 20)
        Me.TransmissionRadioButton3.TabIndex = 58
        Me.TransmissionRadioButton3.TabStop = True
        Me.TransmissionRadioButton3.Text = "T3"
        Me.TransmissionRadioButton3.UseVisualStyleBackColor = True
        '
        'TransmissionRadioButton2
        '
        Me.TransmissionRadioButton2.AutoSize = True
        Me.TransmissionRadioButton2.Location = New System.Drawing.Point(157, 11)
        Me.TransmissionRadioButton2.Name = "TransmissionRadioButton2"
        Me.TransmissionRadioButton2.Size = New System.Drawing.Size(44, 20)
        Me.TransmissionRadioButton2.TabIndex = 57
        Me.TransmissionRadioButton2.TabStop = True
        Me.TransmissionRadioButton2.Text = "T2"
        Me.TransmissionRadioButton2.UseVisualStyleBackColor = True
        '
        'TransmissionRadioButton1
        '
        Me.TransmissionRadioButton1.AutoSize = True
        Me.TransmissionRadioButton1.Location = New System.Drawing.Point(27, 11)
        Me.TransmissionRadioButton1.Name = "TransmissionRadioButton1"
        Me.TransmissionRadioButton1.Size = New System.Drawing.Size(44, 20)
        Me.TransmissionRadioButton1.TabIndex = 56
        Me.TransmissionRadioButton1.TabStop = True
        Me.TransmissionRadioButton1.Text = "T1"
        Me.TransmissionRadioButton1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(358, 63)
        Me.PictureBox1.TabIndex = 59
        Me.PictureBox1.TabStop = False
        '
        'Transmission_Selector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TransmissionRadioButton3)
        Me.Controls.Add(Me.TransmissionRadioButton2)
        Me.Controls.Add(Me.TransmissionRadioButton1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Transmission_Selector"
        Me.Size = New System.Drawing.Size(359, 63)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TransmissionRadioButton3 As RadioButton
    Friend WithEvents TransmissionRadioButton2 As RadioButton
    Friend WithEvents TransmissionRadioButton1 As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
