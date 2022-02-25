Public Class Form1

    Dim randi As Integer
    Dim tim As New Time
    Dim brd As Integer = 100
    Public mrk As Integer = 0
    Dim i As Integer
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, Label5.Click, Label3.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label6.Hide()
        ProgressBar1.Hide()
        Dim ready As DialogResult
        ready = MessageBox.Show("ARE YOU READY TO PLAY THE GAME", "BRAIN GAME", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If ready = Windows.Forms.DialogResult.Yes Then
            MessageBox.Show(TextBox2.Text, "BRAIN GAME", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Timer1.Start()
            randi = tim.randy(brd)
            Label2.Text = "NUMBER:" & randi
        Else
            Application.Exit()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> 0 Then
            TextBox1.Text += "1"
        Else
            TextBox1.Text = "1"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text <> 0 Then
            TextBox1.Text += "2"
        Else
            TextBox1.Text = "2"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text <> 0 Then
            TextBox1.Text += "3"
        Else
            TextBox1.Text = "3"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text <> 0 Then
            TextBox1.Text += "4"
        Else
            TextBox1.Text = "4"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text <> 0 Then
            TextBox1.Text += "5"
        Else
            TextBox1.Text = "5"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox1.Text <> 0 Then
            TextBox1.Text += "6"
        Else
            TextBox1.Text = "6"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TextBox1.Text <> 0 Then
            TextBox1.Text += "7"
        Else
            TextBox1.Text = "7"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If TextBox1.Text <> 0 Then
            TextBox1.Text += "8"
        Else
            TextBox1.Text = "8"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If TextBox1.Text <> 0 Then
            TextBox1.Text += "9"
        Else
            TextBox1.Text = "9"
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If TextBox1.Text <> 0 Then
            TextBox1.Text += "0"
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tim.tim1()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        tim.tim2()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If Label6.Text > 0 Then
            If TextBox1.Text = randi Then
                i += 1
                mrk += 100
                Label3.Text = "Score: " & mrk
                Timer2.Stop()
                Label5.Text = "3"
                Label6.Text = "5"
                ProgressBar1.Value = 0
                TextBox1.Text = "0"
                ProgressBar1.Hide()
                Label6.Hide()
                Label5.Show()
                If i Mod 3 = 0 Then
                    brd *= 10
                End If
                randi = tim.randy(brd)
                Label2.Text = "NUMBER:" & randi
                Label2.Show()
                tim.tim1()

            Else
                Timer2.Stop()
                Label2.ForeColor = Color.Red
                Label2.Show()
                MessageBox.Show("Wrong Digit", "BrainGame", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Undo()
    End Sub
End Class
