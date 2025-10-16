<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Welcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Welcome))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Square = New System.Windows.Forms.PictureBox()
        Me.Pad_right = New System.Windows.Forms.PictureBox()
        Me.Pad_left = New System.Windows.Forms.PictureBox()
        Me.Up_left = New System.Windows.Forms.Label()
        Me.W_text = New System.Windows.Forms.Label()
        Me.Left_up = New System.Windows.Forms.Timer(Me.components)
        Me.Left_down = New System.Windows.Forms.Timer(Me.components)
        Me.Up_right = New System.Windows.Forms.Label()
        Me.Down_left = New System.Windows.Forms.Label()
        Me.S_text = New System.Windows.Forms.Label()
        Me.Down_right = New System.Windows.Forms.Label()
        Me.upup = New System.Windows.Forms.Label()
        Me.downdown = New System.Windows.Forms.Label()
        Me.Right_up = New System.Windows.Forms.Timer(Me.components)
        Me.Right_down = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Left = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Right = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Square, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pad_right, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pad_left, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Eight Bit Dragon", 69.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(256, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 93)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PONG"
        '
        'Timer1
        '
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Pixeboy", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button1.Location = New System.Drawing.Point(323, 360)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 53)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "START"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Square
        '
        Me.Square.BackColor = System.Drawing.Color.Transparent
        Me.Square.Image = Global.Game.My.Resources.Resources.Square
        Me.Square.Location = New System.Drawing.Point(206, 83)
        Me.Square.Name = "Square"
        Me.Square.Size = New System.Drawing.Size(25, 25)
        Me.Square.TabIndex = 5
        Me.Square.TabStop = False
        '
        'Pad_right
        '
        Me.Pad_right.Image = Global.Game.My.Resources.Resources.Square
        Me.Pad_right.Location = New System.Drawing.Point(770, 148)
        Me.Pad_right.Name = "Pad_right"
        Me.Pad_right.Size = New System.Drawing.Size(18, 173)
        Me.Pad_right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pad_right.TabIndex = 4
        Me.Pad_right.TabStop = False
        '
        'Pad_left
        '
        Me.Pad_left.Image = Global.Game.My.Resources.Resources.Square
        Me.Pad_left.Location = New System.Drawing.Point(12, 148)
        Me.Pad_left.Name = "Pad_left"
        Me.Pad_left.Size = New System.Drawing.Size(18, 173)
        Me.Pad_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pad_left.TabIndex = 3
        Me.Pad_left.TabStop = False
        '
        'Up_left
        '
        Me.Up_left.AutoSize = True
        Me.Up_left.BackColor = System.Drawing.Color.Transparent
        Me.Up_left.Font = New System.Drawing.Font("Pixeboy", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Up_left.Location = New System.Drawing.Point(62, 268)
        Me.Up_left.Name = "Up_left"
        Me.Up_left.Size = New System.Drawing.Size(58, 53)
        Me.Up_left.TabIndex = 7
        Me.Up_left.Text = "⇡"
        Me.Up_left.Visible = False
        '
        'W_text
        '
        Me.W_text.AutoSize = True
        Me.W_text.BackColor = System.Drawing.Color.Transparent
        Me.W_text.Font = New System.Drawing.Font("Eight Bit Dragon", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.W_text.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.W_text.Location = New System.Drawing.Point(126, 275)
        Me.W_text.Name = "W_text"
        Me.W_text.Size = New System.Drawing.Size(59, 48)
        Me.W_text.TabIndex = 8
        Me.W_text.Text = "W"
        Me.W_text.Visible = False
        '
        'Left_up
        '
        Me.Left_up.Interval = 50
        '
        'Left_down
        '
        Me.Left_down.Interval = 50
        '
        'Up_right
        '
        Me.Up_right.AutoSize = True
        Me.Up_right.BackColor = System.Drawing.Color.Transparent
        Me.Up_right.Font = New System.Drawing.Font("Pixeboy", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Up_right.Location = New System.Drawing.Point(684, 268)
        Me.Up_right.Name = "Up_right"
        Me.Up_right.Size = New System.Drawing.Size(58, 53)
        Me.Up_right.TabIndex = 9
        Me.Up_right.Text = "⇡"
        Me.Up_right.Visible = False
        '
        'Down_left
        '
        Me.Down_left.AutoSize = True
        Me.Down_left.BackColor = System.Drawing.Color.Transparent
        Me.Down_left.Font = New System.Drawing.Font("Pixeboy", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Down_left.Location = New System.Drawing.Point(62, 148)
        Me.Down_left.Name = "Down_left"
        Me.Down_left.Size = New System.Drawing.Size(58, 53)
        Me.Down_left.TabIndex = 10
        Me.Down_left.Text = "⇣"
        Me.Down_left.Visible = False
        '
        'S_text
        '
        Me.S_text.AutoSize = True
        Me.S_text.BackColor = System.Drawing.Color.Transparent
        Me.S_text.Font = New System.Drawing.Font("Eight Bit Dragon", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S_text.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.S_text.Location = New System.Drawing.Point(126, 155)
        Me.S_text.Name = "S_text"
        Me.S_text.Size = New System.Drawing.Size(55, 48)
        Me.S_text.TabIndex = 11
        Me.S_text.Text = "S"
        Me.S_text.Visible = False
        '
        'Down_right
        '
        Me.Down_right.AutoSize = True
        Me.Down_right.BackColor = System.Drawing.Color.Transparent
        Me.Down_right.Font = New System.Drawing.Font("Pixeboy", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Down_right.Location = New System.Drawing.Point(684, 150)
        Me.Down_right.Name = "Down_right"
        Me.Down_right.Size = New System.Drawing.Size(58, 53)
        Me.Down_right.TabIndex = 12
        Me.Down_right.Text = "⇣"
        Me.Down_right.Visible = False
        '
        'upup
        '
        Me.upup.AutoSize = True
        Me.upup.BackColor = System.Drawing.Color.Transparent
        Me.upup.Font = New System.Drawing.Font("Eight Bit Dragon", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.upup.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.upup.Location = New System.Drawing.Point(622, 232)
        Me.upup.Name = "upup"
        Me.upup.Size = New System.Drawing.Size(75, 96)
        Me.upup.TabIndex = 13
        Me.upup.Text = "↑"
        Me.upup.Visible = False
        '
        'downdown
        '
        Me.downdown.AutoSize = True
        Me.downdown.BackColor = System.Drawing.Color.Transparent
        Me.downdown.Font = New System.Drawing.Font("Eight Bit Dragon", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.downdown.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.downdown.Location = New System.Drawing.Point(622, 114)
        Me.downdown.Name = "downdown"
        Me.downdown.Size = New System.Drawing.Size(75, 96)
        Me.downdown.TabIndex = 14
        Me.downdown.Text = "↓"
        Me.downdown.Visible = False
        '
        'Right_up
        '
        Me.Right_up.Interval = 50
        '
        'Right_down
        '
        Me.Right_down.Interval = 50
        '
        'Timer_Left
        '
        Me.Timer_Left.Interval = 1000
        '
        'Timer_Right
        '
        Me.Timer_Right.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'Form_Welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Square)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.downdown)
        Me.Controls.Add(Me.upup)
        Me.Controls.Add(Me.Down_right)
        Me.Controls.Add(Me.S_text)
        Me.Controls.Add(Me.Down_left)
        Me.Controls.Add(Me.Up_right)
        Me.Controls.Add(Me.W_text)
        Me.Controls.Add(Me.Up_left)
        Me.Controls.Add(Me.Pad_right)
        Me.Controls.Add(Me.Pad_left)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Welcome"
        Me.Text = "Welcome to Pong"
        CType(Me.Square, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pad_right, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pad_left, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Pad_left As PictureBox
    Friend WithEvents Pad_right As PictureBox
    Friend WithEvents Square As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Up_left As Label
    Friend WithEvents W_text As Label
    Friend WithEvents Left_up As Timer
    Friend WithEvents Left_down As Timer
    Friend WithEvents Up_right As Label
    Friend WithEvents Down_left As Label
    Friend WithEvents S_text As Label
    Friend WithEvents Down_right As Label
    Friend WithEvents upup As Label
    Friend WithEvents downdown As Label
    Friend WithEvents Right_up As Timer
    Friend WithEvents Right_down As Timer
    Friend WithEvents Timer_Left As Timer
    Friend WithEvents Timer_Right As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
End Class
