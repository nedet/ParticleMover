<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JMAParticleMover
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(JMAParticleMover))
        Me.btnStart = New System.Windows.Forms.Button()
        Me.tmrA = New System.Windows.Forms.Timer(Me.components)
        Me.Btnstop = New System.Windows.Forms.Button()
        Me.LblCount = New System.Windows.Forms.Label()
        Me.btnStep = New System.Windows.Forms.Button()
        Me.btnMake = New System.Windows.Forms.Button()
        Me.picBall = New System.Windows.Forms.PictureBox()
        Me.PicA = New System.Windows.Forms.PictureBox()
        Me.picsquare = New System.Windows.Forms.PictureBox()
        Me.picBar = New System.Windows.Forms.PictureBox()
        Me.PicBall3 = New System.Windows.Forms.PictureBox()
        CType(Me.picBall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picsquare, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBall3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(52, 20)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(56, 35)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'tmrA
        '
        Me.tmrA.Interval = 2
        '
        'Btnstop
        '
        Me.Btnstop.Location = New System.Drawing.Point(117, 20)
        Me.Btnstop.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btnstop.Name = "Btnstop"
        Me.Btnstop.Size = New System.Drawing.Size(57, 35)
        Me.Btnstop.TabIndex = 3
        Me.Btnstop.Text = "stop"
        Me.Btnstop.UseVisualStyleBackColor = True
        '
        'LblCount
        '
        Me.LblCount.AutoSize = True
        Me.LblCount.Location = New System.Drawing.Point(771, 34)
        Me.LblCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCount.Name = "LblCount"
        Me.LblCount.Size = New System.Drawing.Size(0, 20)
        Me.LblCount.TabIndex = 6
        '
        'btnStep
        '
        Me.btnStep.Location = New System.Drawing.Point(513, 20)
        Me.btnStep.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnStep.Name = "btnStep"
        Me.btnStep.Size = New System.Drawing.Size(88, 35)
        Me.btnStep.TabIndex = 8
        Me.btnStep.Text = "Step"
        Me.btnStep.UseVisualStyleBackColor = True
        '
        'btnMake
        '
        Me.btnMake.Location = New System.Drawing.Point(216, 15)
        Me.btnMake.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMake.Name = "btnMake"
        Me.btnMake.Size = New System.Drawing.Size(140, 43)
        Me.btnMake.TabIndex = 9
        Me.btnMake.Text = "Make Particle"
        Me.btnMake.UseVisualStyleBackColor = True
        '
        'picBall
        '
        Me.picBall.Image = Global.SimTest1.My.Resources.Resources.ball2
        Me.picBall.Location = New System.Drawing.Point(998, 134)
        Me.picBall.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picBall.Name = "picBall"
        Me.picBall.Size = New System.Drawing.Size(30, 31)
        Me.picBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBall.TabIndex = 7
        Me.picBall.TabStop = False
        Me.picBall.Visible = False
        '
        'PicA
        '
        Me.PicA.BackColor = System.Drawing.Color.Beige
        Me.PicA.Location = New System.Drawing.Point(30, 92)
        Me.PicA.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PicA.Name = "PicA"
        Me.PicA.Size = New System.Drawing.Size(1072, 660)
        Me.PicA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicA.TabIndex = 0
        Me.PicA.TabStop = False
        '
        'picsquare
        '
        Me.picsquare.Image = CType(resources.GetObject("picsquare.Image"), System.Drawing.Image)
        Me.picsquare.Location = New System.Drawing.Point(964, 189)
        Me.picsquare.Name = "picsquare"
        Me.picsquare.Size = New System.Drawing.Size(100, 100)
        Me.picsquare.TabIndex = 10
        Me.picsquare.TabStop = False
        '
        'picBar
        '
        Me.picBar.Image = CType(resources.GetObject("picBar.Image"), System.Drawing.Image)
        Me.picBar.Location = New System.Drawing.Point(750, 331)
        Me.picBar.Name = "picBar"
        Me.picBar.Size = New System.Drawing.Size(34, 149)
        Me.picBar.TabIndex = 11
        Me.picBar.TabStop = False
        '
        'PicBall3
        '
        Me.PicBall3.Image = CType(resources.GetObject("PicBall3.Image"), System.Drawing.Image)
        Me.PicBall3.Location = New System.Drawing.Point(1035, 134)
        Me.PicBall3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PicBall3.Name = "PicBall3"
        Me.PicBall3.Size = New System.Drawing.Size(30, 31)
        Me.PicBall3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBall3.TabIndex = 12
        Me.PicBall3.TabStop = False
        Me.PicBall3.Visible = False
        '
        'JMAParticleMover
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1125, 751)
        Me.Controls.Add(Me.PicBall3)
        Me.Controls.Add(Me.picBar)
        Me.Controls.Add(Me.picsquare)
        Me.Controls.Add(Me.btnMake)
        Me.Controls.Add(Me.btnStep)
        Me.Controls.Add(Me.picBall)
        Me.Controls.Add(Me.LblCount)
        Me.Controls.Add(Me.Btnstop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.PicA)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "JMAParticleMover"
        Me.Text = "JMAParticleMover"
        CType(Me.picBall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picsquare, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBall3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicA As PictureBox
    Friend WithEvents btnStart As Button
    Friend WithEvents tmrA As Timer
    Friend WithEvents Btnstop As Button
    Friend WithEvents LblCount As Label
    Friend WithEvents picBall As PictureBox
    Friend WithEvents btnStep As Button
    Friend WithEvents btnMake As Button
    Friend WithEvents picsquare As PictureBox
    Friend WithEvents picBar As PictureBox
    Friend WithEvents PicBall3 As PictureBox
End Class
