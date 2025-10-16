Public Class Game_window
    Dim square_speed As Integer = 23 'square speed
    Dim Vx As Integer = square_speed
    Dim Vy As Integer = square_speed
    Dim pad_left_speed As Integer = 25 'pad speed
    Dim pad_right_speed As Integer = 25 'pad speed
    Dim D_left As Integer 'keyboard input
    Dim D_right As Integer 'keyboard input
    Dim Score_left As Integer = 0 'score
    Dim Score_right As Integer = 0
    Dim time As Integer 'time count down
    Dim notifacation As Integer = 0 'notifacation window
    Dim round As Integer = 0 'game round

    Private Sub Pong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        round = 0
        Timer1.Enabled = True
        Form_Welcome.Hide()
    End Sub

    Sub pause()
        round += 1
        Timer1.Enabled = False
        time = 2
        Timer2.Enabled = True
        'Score detect
        If Score_left = 1 Then
            Picturebox_left.Image = number_1.Image
        ElseIf Score_left = 2 Then
            Picturebox_left.Image = number_2.Image
        ElseIf Score_left = 3 Then
            Picturebox_left.Image = number_3.Image
        ElseIf Score_left = 4 Then
            Picturebox_left.Image = number_4.Image
        ElseIf Score_left = 5 Then
            Picturebox_left.Image = number_5.Image
        End If

        If Score_right = 1 Then
            PictureBox_right.Image = number_1.Image
        ElseIf Score_right = 2 Then
            PictureBox_right.Image = number_2.Image
        ElseIf Score_right = 3 Then
            PictureBox_right.Image = number_3.Image
        ElseIf Score_right = 4 Then
            PictureBox_right.Image = number_4.Image
        ElseIf Score_right = 5 Then
            PictureBox_right.Image = number_5.Image
        End If

        'change pad size
        If round = 2 Then
            Pad_left.Height = pad_1.Height
            Pad_right.Height = pad_1.Height
        ElseIf round = 4 Then
            Pad_left.Height = pad_2.Height
            Pad_right.Height = pad_2.Height
        ElseIf round = 5 Then
            Pad_left.Height = pad_3.Height
            Pad_right.Height = pad_3.Height
        ElseIf round = 6 Then
            Pad_left.Height = pad_4.Height
            Pad_right.Height = pad_4.Height
        ElseIf round = 8 Then
            Pad_left.Height = pad_5.Height
            Pad_right.Height = pad_5.Height
        End If
    End Sub

    Sub start()
        'square location reset
        If Score_left > Score_right Then
            Vx = -Math.Abs(Vx)
            Square.Left = Pad_right.Left - 30
            Square.Top = (Me.Height) / 2
        Else
            Vx = Math.Abs(Vx)
            Square.Left = Pad_left.Left + Pad_left.Width + 30
            Square.Top = (Me.Height) / 2
        End If
        Timer1.Enabled = True
    End Sub

    Sub game_end()
        Timer2.Enabled = False
        If Score_left = 5 Then
            notifacation = MsgBox("左方 玩家獲勝! 是否重置遊戲?", 32 + 4, "GG")
        ElseIf Score_right = 5 Then
            notifacation = MsgBox("右方 玩家獲勝! 是否重置遊戲?", 32 + 4, "GG")
        End If

        If notifacation = 6 Then
            Call reset()
        Else
            Me.Close()
        End If
    End Sub

    Sub reset()
        Vx = square_speed
        Vy = square_speed
        round = 0
        Score_left = 0
        Score_right = 0
        Picturebox_left.Image = number_0.Image
        PictureBox_right.Image = number_0.Image
        Pad_left.Height = pad_0.Height
        Pad_right.Height = pad_0.Height
        Pad_left.Top = (Me.Height - 18) / 2 - Pad_left.Height / 2
        Pad_right.Top = (Me.Height - 18) / 2 - Pad_right.Height / 2
        Call start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Square.Left += Vx
        Square.Top += Vy
        'Border touch
        If Square.Left < 0 Then
            Score_right += 1
            My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\goal.wav", AudioPlayMode.Background)
            Call pause()
        ElseIf Square.Left + Square.Width > Me.Width - 18 Then
            Score_left += 1
            My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\goal.wav", AudioPlayMode.Background)
            Call pause()
        ElseIf Square.Top < 0 Then
            Vy = Math.Abs(Vy)
            My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\bounce.wav", AudioPlayMode.Background)
        ElseIf Square.Top + Square.Height > Me.Height - 45 Then
            Vy = -Math.Abs(Vy)
            My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\bounce.wav", AudioPlayMode.Background)
        End If

        'Pad touch
        If Square.Left <= Pad_left.Left + Pad_left.Width And
                Square.Left + Square.Width >= Pad_left.Left And
                Square.Top <= Pad_left.Top + Pad_left.Height And
                Square.Top + Square.Height >= Pad_left.Top Then
            Vx = Math.Abs(Vx)
            My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\bounce.wav", AudioPlayMode.Background)
        ElseIf Square.Left <= Pad_right.Left + Pad_right.Width And
                Square.Left + Square.Width >= Pad_right.Left And
                Square.Top <= Pad_right.Top + Pad_right.Height And
                Square.Top + Square.Height >= Pad_right.Top Then
            Vx = -Math.Abs(Vx)
            My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\bounce.wav", AudioPlayMode.Background)
        End If

        'Pad limit
        If Pad_left.Top <= 0 Then
            Pad_left.Top = 0
        ElseIf Pad_left.Top + Pad_left.Height >= Me.Height - 45 Then
            Pad_left.Top = Me.Height - 45 - Pad_left.Height - 1
        End If

        If Pad_right.Top <= 0 Then
            Pad_right.Top = 0
        ElseIf Pad_right.Top + Pad_right.Height >= Me.Height - 45 Then
            Pad_right.Top = Me.Height - 45 - Pad_left.Height - 1
        End If

        'Pad Speed
        If D_left = 1 Then
            Pad_left.Top -= pad_left_speed
        ElseIf D_left = 2 Then
            Pad_left.Top += pad_left_speed
        ElseIf D_left = 3 Then
            Pad_left.Top += 0
        End If

        If D_right = 1 Then
            Pad_right.Top -= pad_right_speed
        ElseIf D_right = 2 Then
            Pad_right.Top += pad_right_speed
        ElseIf D_right = 3 Then
            Pad_right.Top += 0
        End If
    End Sub


    Private Sub Pong_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.W Then
            D_left = 1
        ElseIf e.KeyCode = Keys.S Then
            D_left = 2
        ElseIf e.KeyCode = Keys.Up Then
            D_right = 1
        ElseIf e.KeyCode = Keys.Down Then
            D_right = 2
        End If
    End Sub

    Private Sub Pong_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.W Then
            D_left = 3
        ElseIf e.KeyCode = Keys.S Then
            D_left = 3
        End If

        If e.KeyCode = Keys.Up Then
            D_right = 3
        ElseIf e.KeyCode = Keys.Down Then
            D_right = 3
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Score_left < 5 And Score_right < 5 Then
            If time > 0 Then
                time -= 1
            ElseIf time = 0 Then
                Call start()
                Timer2.Enabled = False
            End If
        Else
            Call game_end()
        End If

    End Sub

    Private Sub Game_window_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Form_Welcome.Show()
    End Sub
End Class
