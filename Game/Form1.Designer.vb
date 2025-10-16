<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Game_window
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Game_window))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Square = New System.Windows.Forms.PictureBox()
        Me.Pad_left = New System.Windows.Forms.PictureBox()
        Me.Pad_right = New System.Windows.Forms.PictureBox()
        Me.Picturebox_left = New System.Windows.Forms.PictureBox()
        Me.number_5 = New System.Windows.Forms.PictureBox()
        Me.number_4 = New System.Windows.Forms.PictureBox()
        Me.number_3 = New System.Windows.Forms.PictureBox()
        Me.number_2 = New System.Windows.Forms.PictureBox()
        Me.number_1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_right = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.number_0 = New System.Windows.Forms.PictureBox()
        Me.pad_1 = New System.Windows.Forms.PictureBox()
        Me.pad_2 = New System.Windows.Forms.PictureBox()
        Me.pad_3 = New System.Windows.Forms.PictureBox()
        Me.pad_4 = New System.Windows.Forms.PictureBox()
        Me.pad_0 = New System.Windows.Forms.PictureBox()
        Me.pad_5 = New System.Windows.Forms.PictureBox()
        CType(Me.Square, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pad_left, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pad_right, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picturebox_left, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.number_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.number_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.number_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.number_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.number_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_right, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.number_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pad_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pad_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pad_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pad_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pad_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pad_5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Square
        '
        Me.Square.BackColor = System.Drawing.Color.Transparent
        Me.Square.Image = Global.Game.My.Resources.Resources.Square
        Me.Square.Location = New System.Drawing.Point(73, 240)
        Me.Square.Name = "Square"
        Me.Square.Size = New System.Drawing.Size(25, 25)
        Me.Square.TabIndex = 1
        Me.Square.TabStop = False
        '
        'Pad_left
        '
        Me.Pad_left.Image = Global.Game.My.Resources.Resources.Square
        Me.Pad_left.Location = New System.Drawing.Point(12, 195)
        Me.Pad_left.Name = "Pad_left"
        Me.Pad_left.Size = New System.Drawing.Size(18, 173)
        Me.Pad_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pad_left.TabIndex = 2
        Me.Pad_left.TabStop = False
        '
        'Pad_right
        '
        Me.Pad_right.Image = Global.Game.My.Resources.Resources.Square
        Me.Pad_right.Location = New System.Drawing.Point(927, 195)
        Me.Pad_right.Name = "Pad_right"
        Me.Pad_right.Size = New System.Drawing.Size(18, 173)
        Me.Pad_right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pad_right.TabIndex = 3
        Me.Pad_right.TabStop = False
        '
        'Picturebox_left
        '
        Me.Picturebox_left.BackColor = System.Drawing.Color.Transparent
        Me.Picturebox_left.Image = Global.Game.My.Resources.Resources.number_0
        Me.Picturebox_left.Location = New System.Drawing.Point(373, 22)
        Me.Picturebox_left.Name = "Picturebox_left"
        Me.Picturebox_left.Size = New System.Drawing.Size(78, 107)
        Me.Picturebox_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Picturebox_left.TabIndex = 4
        Me.Picturebox_left.TabStop = False
        '
        'number_5
        '
        Me.number_5.BackColor = System.Drawing.Color.Transparent
        Me.number_5.Image = Global.Game.My.Resources.Resources.number_5
        Me.number_5.Location = New System.Drawing.Point(121, 135)
        Me.number_5.Name = "number_5"
        Me.number_5.Size = New System.Drawing.Size(78, 107)
        Me.number_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.number_5.TabIndex = 5
        Me.number_5.TabStop = False
        Me.number_5.Visible = False
        '
        'number_4
        '
        Me.number_4.BackColor = System.Drawing.Color.Transparent
        Me.number_4.Image = Global.Game.My.Resources.Resources.number_4
        Me.number_4.Location = New System.Drawing.Point(37, 22)
        Me.number_4.Name = "number_4"
        Me.number_4.Size = New System.Drawing.Size(78, 107)
        Me.number_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.number_4.TabIndex = 6
        Me.number_4.TabStop = False
        Me.number_4.Visible = False
        '
        'number_3
        '
        Me.number_3.BackColor = System.Drawing.Color.Transparent
        Me.number_3.Image = Global.Game.My.Resources.Resources.number_3
        Me.number_3.Location = New System.Drawing.Point(121, 22)
        Me.number_3.Name = "number_3"
        Me.number_3.Size = New System.Drawing.Size(78, 107)
        Me.number_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.number_3.TabIndex = 7
        Me.number_3.TabStop = False
        Me.number_3.Visible = False
        '
        'number_2
        '
        Me.number_2.BackColor = System.Drawing.Color.Transparent
        Me.number_2.Image = Global.Game.My.Resources.Resources.number_2
        Me.number_2.Location = New System.Drawing.Point(205, 22)
        Me.number_2.Name = "number_2"
        Me.number_2.Size = New System.Drawing.Size(78, 107)
        Me.number_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.number_2.TabIndex = 8
        Me.number_2.TabStop = False
        Me.number_2.Visible = False
        '
        'number_1
        '
        Me.number_1.BackColor = System.Drawing.Color.Transparent
        Me.number_1.Image = Global.Game.My.Resources.Resources.number_1
        Me.number_1.Location = New System.Drawing.Point(289, 22)
        Me.number_1.Name = "number_1"
        Me.number_1.Size = New System.Drawing.Size(78, 107)
        Me.number_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.number_1.TabIndex = 9
        Me.number_1.TabStop = False
        Me.number_1.Visible = False
        '
        'PictureBox_right
        '
        Me.PictureBox_right.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox_right.Image = Global.Game.My.Resources.Resources.number_0
        Me.PictureBox_right.Location = New System.Drawing.Point(521, 22)
        Me.PictureBox_right.Name = "PictureBox_right"
        Me.PictureBox_right.Size = New System.Drawing.Size(78, 107)
        Me.PictureBox_right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_right.TabIndex = 10
        Me.PictureBox_right.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'number_0
        '
        Me.number_0.BackColor = System.Drawing.Color.Transparent
        Me.number_0.Image = Global.Game.My.Resources.Resources.number_0
        Me.number_0.Location = New System.Drawing.Point(205, 135)
        Me.number_0.Name = "number_0"
        Me.number_0.Size = New System.Drawing.Size(78, 107)
        Me.number_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.number_0.TabIndex = 11
        Me.number_0.TabStop = False
        Me.number_0.Visible = False
        '
        'pad_1
        '
        Me.pad_1.Image = Global.Game.My.Resources.Resources.Square
        Me.pad_1.Location = New System.Drawing.Point(758, 388)
        Me.pad_1.Name = "pad_1"
        Me.pad_1.Size = New System.Drawing.Size(18, 158)
        Me.pad_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pad_1.TabIndex = 12
        Me.pad_1.TabStop = False
        Me.pad_1.Visible = False
        '
        'pad_2
        '
        Me.pad_2.Image = Global.Game.My.Resources.Resources.Square
        Me.pad_2.Location = New System.Drawing.Point(734, 416)
        Me.pad_2.Name = "pad_2"
        Me.pad_2.Size = New System.Drawing.Size(18, 130)
        Me.pad_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pad_2.TabIndex = 13
        Me.pad_2.TabStop = False
        Me.pad_2.Visible = False
        '
        'pad_3
        '
        Me.pad_3.Image = Global.Game.My.Resources.Resources.Square
        Me.pad_3.Location = New System.Drawing.Point(710, 426)
        Me.pad_3.Name = "pad_3"
        Me.pad_3.Size = New System.Drawing.Size(18, 120)
        Me.pad_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pad_3.TabIndex = 14
        Me.pad_3.TabStop = False
        Me.pad_3.Visible = False
        '
        'pad_4
        '
        Me.pad_4.Image = Global.Game.My.Resources.Resources.Square
        Me.pad_4.Location = New System.Drawing.Point(686, 466)
        Me.pad_4.Name = "pad_4"
        Me.pad_4.Size = New System.Drawing.Size(18, 80)
        Me.pad_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pad_4.TabIndex = 15
        Me.pad_4.TabStop = False
        Me.pad_4.Visible = False
        '
        'pad_0
        '
        Me.pad_0.Image = Global.Game.My.Resources.Resources.Square
        Me.pad_0.Location = New System.Drawing.Point(782, 373)
        Me.pad_0.Name = "pad_0"
        Me.pad_0.Size = New System.Drawing.Size(18, 173)
        Me.pad_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pad_0.TabIndex = 16
        Me.pad_0.TabStop = False
        Me.pad_0.Visible = False
        '
        'pad_5
        '
        Me.pad_5.Image = Global.Game.My.Resources.Resources.Square
        Me.pad_5.Location = New System.Drawing.Point(662, 486)
        Me.pad_5.Name = "pad_5"
        Me.pad_5.Size = New System.Drawing.Size(18, 60)
        Me.pad_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pad_5.TabIndex = 17
        Me.pad_5.TabStop = False
        Me.pad_5.Visible = False
        '
        'Game_window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Game.My.Resources.Resources.pong_table
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(957, 681)
        Me.Controls.Add(Me.Square)
        Me.Controls.Add(Me.pad_5)
        Me.Controls.Add(Me.pad_0)
        Me.Controls.Add(Me.pad_4)
        Me.Controls.Add(Me.pad_3)
        Me.Controls.Add(Me.pad_2)
        Me.Controls.Add(Me.pad_1)
        Me.Controls.Add(Me.number_0)
        Me.Controls.Add(Me.PictureBox_right)
        Me.Controls.Add(Me.number_1)
        Me.Controls.Add(Me.number_2)
        Me.Controls.Add(Me.number_3)
        Me.Controls.Add(Me.number_4)
        Me.Controls.Add(Me.number_5)
        Me.Controls.Add(Me.Picturebox_left)
        Me.Controls.Add(Me.Pad_right)
        Me.Controls.Add(Me.Pad_left)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Game_window"
        Me.Text = "Pong"
        CType(Me.Square, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pad_left, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pad_right, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picturebox_left, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.number_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.number_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.number_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.number_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.number_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_right, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.number_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pad_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pad_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pad_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pad_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pad_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pad_5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Square As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Pad_left As PictureBox
    Friend WithEvents Pad_right As PictureBox
    Friend WithEvents Picturebox_left As PictureBox
    Friend WithEvents number_5 As PictureBox
    Friend WithEvents number_4 As PictureBox
    Friend WithEvents number_3 As PictureBox
    Friend WithEvents number_2 As PictureBox
    Friend WithEvents number_1 As PictureBox
    Friend WithEvents PictureBox_right As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents number_0 As PictureBox
    Friend WithEvents pad_1 As PictureBox
    Friend WithEvents pad_2 As PictureBox
    Friend WithEvents pad_3 As PictureBox
    Friend WithEvents pad_4 As PictureBox
    Friend WithEvents pad_0 As PictureBox
    Friend WithEvents pad_5 As PictureBox
End Class
