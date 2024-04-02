<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Engine_Selector
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
        Me.EngineRadioButton3 = New System.Windows.Forms.RadioButton()
        Me.EngineRadioButton2 = New System.Windows.Forms.RadioButton()
        Me.EngineRadioButton1 = New System.Windows.Forms.RadioButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EngineRadioButton3
        '
        Me.EngineRadioButton3.AutoSize = True
        Me.EngineRadioButton3.Location = New System.Drawing.Point(286, 11)
        Me.EngineRadioButton3.Name = "EngineRadioButton3"
        Me.EngineRadioButton3.Size = New System.Drawing.Size(44, 20)
        Me.EngineRadioButton3.TabIndex = 51
        Me.EngineRadioButton3.TabStop = True
        Me.EngineRadioButton3.Text = "E3"
        Me.EngineRadioButton3.UseVisualStyleBackColor = True
        '
        'EngineRadioButton2
        '
        Me.EngineRadioButton2.AutoSize = True
        Me.EngineRadioButton2.Location = New System.Drawing.Point(157, 11)
        Me.EngineRadioButton2.Name = "EngineRadioButton2"
        Me.EngineRadioButton2.Size = New System.Drawing.Size(44, 20)
        Me.EngineRadioButton2.TabIndex = 50
        Me.EngineRadioButton2.TabStop = True
        Me.EngineRadioButton2.Text = "E2"
        Me.EngineRadioButton2.UseVisualStyleBackColor = True
        '
        'EngineRadioButton1
        '
        Me.EngineRadioButton1.AutoSize = True
        Me.EngineRadioButton1.Location = New System.Drawing.Point(27, 11)
        Me.EngineRadioButton1.Name = "EngineRadioButton1"
        Me.EngineRadioButton1.Size = New System.Drawing.Size(44, 20)
        Me.EngineRadioButton1.TabIndex = 49
        Me.EngineRadioButton1.TabStop = True
        Me.EngineRadioButton1.Text = "E1"
        Me.EngineRadioButton1.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(358, 63)
        Me.PictureBox2.TabIndex = 48
        Me.PictureBox2.TabStop = False
        '
        'Engine_Selector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.EngineRadioButton3)
        Me.Controls.Add(Me.EngineRadioButton2)
        Me.Controls.Add(Me.EngineRadioButton1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "Engine_Selector"
        Me.Size = New System.Drawing.Size(358, 61)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EngineRadioButton3 As RadioButton
    Friend WithEvents EngineRadioButton2 As RadioButton
    Friend WithEvents EngineRadioButton1 As RadioButton
    Friend WithEvents PictureBox2 As PictureBox
End Class
