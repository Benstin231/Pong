Public Class Form_Welcome
    Dim Player1 As New WMPLib.WindowsMediaPlayer
    Dim Vx As Integer = 20 'square speed
    Dim Vy As Integer = 20 'square speed
    Dim Pad_move_speed As Integer = 10 'pad move speed

    Private Sub Form_Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Left_up.Enabled = True
        Right_down.Enabled = True
        Player1.settings.volume = 25
        Player1.URL = My.Application.Info.DirectoryPath & "\TheFatRat - Unity.wav"
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Square.Left += Vx
        Square.Top += Vy
        'Border touch
        If Square.Left < 0 Then
            Vx = Math.Abs(Vx)
        ElseIf Square.Left + Square.Width > Me.Width - 18 Then
            Vx = -Math.Abs(Vx)
        ElseIf Square.Top < 0 Then
            Vy = Math.Abs(Vy)
        ElseIf Square.Top + Square.Height > Me.Height - 45 Then
            Vy = -Math.Abs(Vy)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Game_window.Show()
    End Sub

    Private Sub Left_up_Tick(sender As Object, e As EventArgs) Handles Left_up.Tick
        W_text.Visible = True
        Up_left.Visible = True
        If Pad_left.Top > 0 Then
            Pad_left.Top -= Pad_move_speed
            W_text.Top = Pad_left.Top + Pad_left.Height - W_text.Height
            Up_left.Top = Pad_left.Top + Pad_left.Height - Up_left.Height
        Else
            W_text.Visible = False
            Up_left.Visible = False
            Left_down.Enabled = True
            Left_up.Enabled = False
        End If

    End Sub

    Private Sub Left_down_Tick(sender As Object, e As EventArgs) Handles Left_down.Tick
        S_text.Visible = True
        Down_left.Visible = True
        If Pad_left.Top + Pad_left.Height < Me.Height - 45 Then
            Pad_left.Top += Pad_move_speed
            Down_left.Top = Pad_left.Top
            S_text.Top = Pad_left.Top
        Else
            S_text.Visible = False
            Down_left.Visible = False
            Left_up.Enabled = True
            Left_down.Enabled = False
        End If

    End Sub

    Private Sub Right_up_Tick(sender As Object, e As EventArgs) Handles Right_up.Tick
        upup.Visible = True
        Up_right.Visible = True
        If Pad_right.Top > 0 Then
            Pad_right.Top -= Pad_move_speed
            upup.Top = Pad_right.Top + Pad_right.Height - upup.Height + 11
            Up_right.Top = Pad_right.Top + Pad_right.Height - Up_right.Height
        Else
            upup.Visible = False
            Up_right.Visible = False
            Right_down.Enabled = True
            Right_up.Enabled = False
        End If

    End Sub

    Private Sub Right_down_Tick(sender As Object, e As EventArgs) Handles Right_down.Tick
        downdown.Visible = True
        Down_right.Visible = True
        If Pad_right.Top + Pad_right.Height < Me.Height - 45 Then
            Pad_right.Top += Pad_move_speed
            downdown.Top = Pad_right.Top - 36
            Down_right.Top = Pad_right.Top
        Else
            downdown.Visible = False
            Down_right.Visible = False
            Right_up.Enabled = True
            Right_down.Enabled = False
        End If

    End Sub


End Class