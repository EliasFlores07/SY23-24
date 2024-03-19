<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm2DPlatformer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm2DPlatformer))
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.picGround = New System.Windows.Forms.PictureBox()
        Me.tmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.picAir = New System.Windows.Forms.PictureBox()
        Me.tmrUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TmrGameLogic = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGravity = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.IceCubePB = New System.Windows.Forms.PictureBox()
        Me.Mover1 = New platformerGame.Mover()
        Me.Mover2 = New platformerGame.Mover()
        Me.IceCubePB2 = New System.Windows.Forms.PictureBox()
        Me.Mover3 = New platformerGame.Mover()
        Me.IceCubePB3 = New System.Windows.Forms.PictureBox()
        Me.Mover4 = New platformerGame.Mover()
        Me.IceCubePB4 = New System.Windows.Forms.PictureBox()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IceCubePB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IceCubePB2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IceCubePB3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IceCubePB4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPlayer
        '
        Me.picPlayer.BackColor = System.Drawing.Color.Fuchsia
        Me.picPlayer.Image = CType(resources.GetObject("picPlayer.Image"), System.Drawing.Image)
        Me.picPlayer.Location = New System.Drawing.Point(44, 380)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(66, 58)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer.TabIndex = 0
        Me.picPlayer.TabStop = False
        '
        'picGround
        '
        Me.picGround.Image = CType(resources.GetObject("picGround.Image"), System.Drawing.Image)
        Me.picGround.Location = New System.Drawing.Point(-5, 413)
        Me.picGround.Name = "picGround"
        Me.picGround.Size = New System.Drawing.Size(812, 84)
        Me.picGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGround.TabIndex = 2
        Me.picGround.TabStop = False
        '
        'tmrRight
        '
        Me.tmrRight.Interval = 30
        '
        'picAir
        '
        Me.picAir.BackgroundImage = CType(resources.GetObject("picAir.BackgroundImage"), System.Drawing.Image)
        Me.picAir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picAir.Image = CType(resources.GetObject("picAir.Image"), System.Drawing.Image)
        Me.picAir.Location = New System.Drawing.Point(-5, -3)
        Me.picAir.Name = "picAir"
        Me.picAir.Size = New System.Drawing.Size(812, 421)
        Me.picAir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAir.TabIndex = 3
        Me.picAir.TabStop = False
        '
        'tmrUp
        '
        Me.tmrUp.Interval = 30
        '
        'tmrLeft
        '
        Me.tmrLeft.Interval = 30
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(452, 312)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 28)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "bound"
        '
        'TmrGameLogic
        '
        '
        'tmrGravity
        '
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(356, 147)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(346, 25)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "bound"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(69, 280)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(140, 26)
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "bound"
        '
        'IceCubePB
        '
        Me.IceCubePB.Image = CType(resources.GetObject("IceCubePB.Image"), System.Drawing.Image)
        Me.IceCubePB.Location = New System.Drawing.Point(42, 239)
        Me.IceCubePB.Name = "IceCubePB"
        Me.IceCubePB.Size = New System.Drawing.Size(53, 37)
        Me.IceCubePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IceCubePB.TabIndex = 8
        Me.IceCubePB.TabStop = False
        '
        'Mover1
        '
        Me.Mover1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Mover1.interval = 500
        Me.Mover1.Location = New System.Drawing.Point(12, 269)
        Me.Mover1.Name = "Mover1"
        Me.Mover1.Size = New System.Drawing.Size(197, 25)
        Me.Mover1.speed = 30
        Me.Mover1.sprite = Me.IceCubePB
        Me.Mover1.TabIndex = 7
        '
        'Mover2
        '
        Me.Mover2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Mover2.interval = 500
        Me.Mover2.Location = New System.Drawing.Point(356, 124)
        Me.Mover2.Name = "Mover2"
        Me.Mover2.Size = New System.Drawing.Size(346, 48)
        Me.Mover2.speed = 20
        Me.Mover2.sprite = Me.IceCubePB2
        Me.Mover2.TabIndex = 9
        '
        'IceCubePB2
        '
        Me.IceCubePB2.Image = CType(resources.GetObject("IceCubePB2.Image"), System.Drawing.Image)
        Me.IceCubePB2.Location = New System.Drawing.Point(496, 104)
        Me.IceCubePB2.Name = "IceCubePB2"
        Me.IceCubePB2.Size = New System.Drawing.Size(58, 39)
        Me.IceCubePB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IceCubePB2.TabIndex = 10
        Me.IceCubePB2.TabStop = False
        '
        'Mover3
        '
        Me.Mover3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Mover3.interval = 500
        Me.Mover3.Location = New System.Drawing.Point(452, 312)
        Me.Mover3.Name = "Mover3"
        Me.Mover3.Size = New System.Drawing.Size(264, 28)
        Me.Mover3.speed = 50
        Me.Mover3.sprite = Me.IceCubePB3
        Me.Mover3.TabIndex = 11
        '
        'IceCubePB3
        '
        Me.IceCubePB3.Image = CType(resources.GetObject("IceCubePB3.Image"), System.Drawing.Image)
        Me.IceCubePB3.Location = New System.Drawing.Point(702, 362)
        Me.IceCubePB3.Name = "IceCubePB3"
        Me.IceCubePB3.Size = New System.Drawing.Size(57, 39)
        Me.IceCubePB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IceCubePB3.TabIndex = 12
        Me.IceCubePB3.TabStop = False
        '
        'Mover4
        '
        Me.Mover4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Mover4.interval = 500
        Me.Mover4.Location = New System.Drawing.Point(280, 119)
        Me.Mover4.Name = "Mover4"
        Me.Mover4.Size = New System.Drawing.Size(10, 240)
        Me.Mover4.speed = 60
        Me.Mover4.sprite = Me.IceCubePB4
        Me.Mover4.TabIndex = 13
        '
        'IceCubePB4
        '
        Me.IceCubePB4.Image = CType(resources.GetObject("IceCubePB4.Image"), System.Drawing.Image)
        Me.IceCubePB4.Location = New System.Drawing.Point(220, 419)
        Me.IceCubePB4.Name = "IceCubePB4"
        Me.IceCubePB4.Size = New System.Drawing.Size(39, 50)
        Me.IceCubePB4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IceCubePB4.TabIndex = 14
        Me.IceCubePB4.TabStop = False
        '
        'frm2DPlatformer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 482)
        Me.Controls.Add(Me.IceCubePB4)
        Me.Controls.Add(Me.IceCubePB3)
        Me.Controls.Add(Me.IceCubePB2)
        Me.Controls.Add(Me.IceCubePB)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.picAir)
        Me.Controls.Add(Me.picGround)
        Me.Controls.Add(Me.Mover1)
        Me.Controls.Add(Me.Mover2)
        Me.Controls.Add(Me.Mover3)
        Me.Controls.Add(Me.Mover4)
        Me.Name = "frm2DPlatformer"
        Me.Text = "Form1"
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IceCubePB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IceCubePB2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IceCubePB3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IceCubePB4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picPlayer As PictureBox
    Friend WithEvents picGround As PictureBox
    Friend WithEvents tmrRight As Timer
    Friend WithEvents picAir As PictureBox
    Friend WithEvents tmrUp As Timer
    Friend WithEvents tmrLeft As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TmrGameLogic As Timer
    Friend WithEvents tmrGravity As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Mover1 As Mover
    Friend WithEvents IceCubePB As PictureBox
    Friend WithEvents Mover2 As Mover
    Friend WithEvents IceCubePB2 As PictureBox
    Friend WithEvents Mover3 As Mover
    Friend WithEvents IceCubePB3 As PictureBox
    Friend WithEvents Mover4 As Mover
    Friend WithEvents IceCubePB4 As PictureBox
End Class
