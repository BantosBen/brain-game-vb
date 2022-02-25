Public Class Time
    Public Sub tim1()
        Form1.Timer1.Start()
        Form1.TextBox1.ReadOnly = True
        inactive()
        Form1.Timer1.Interval = 1000

        If Form1.Label5.Text = 3 Then
            Form1.Label5.ForeColor = Color.Red
            Form1.Label5.Text = Val(Form1.Label5.Text) - 1
        ElseIf Form1.Label5.Text = 0 Then
            Form1.Timer1.Enabled = False
            Form1.Timer2.Enabled = True
            Form1.Label5.Hide()
            Form1.Label2.Hide()
            Form1.ProgressBar1.Show()
            Form1.Label6.Show()
        Else
            Form1.Label5.Text = Val(Form1.Label5.Text) - 1
        End If
    End Sub
    Public Sub tim2()
        Form1.Timer2.Start()
        Form1.ProgressBar1.Increment(20)
        Form1.TextBox1.ReadOnly = False
        Form1.TextBox1.Focus()
        active()
        Form1.Timer2.Interval = 1000

        If Form1.Label6.Text = 4 Then
            Form1.Label6.ForeColor = Color.Red
            Form1.Label6.Text = Val(Form1.Label6.Text) - 1
        ElseIf Form1.Label6.Text = 0 Then
            Form1.Timer2.Enabled = False
            Form1.Label2.ForeColor = Color.Red
            Form1.Label2.Show()
            Form1.ProgressBar1.Hide()
            Form1.Label6.Hide()
            MessageBox.Show("Time Out", "BrainGame", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Application.Exit()
        Else
            Form1.Label6.Text = Val(Form1.Label6.Text) - 1

        End If
    End Sub
    Public Function randy(bd As Integer)
        Dim secNum As Integer
        Randomize()
        secNum = Int(bd * Rnd() + 1)
        Return secNum
    End Function
    Public Sub inactive()
        Form1.Button1.Enabled = False
        Form1.Button2.Enabled = False
        Form1.Button3.Enabled = False
        Form1.Button4.Enabled = False
        Form1.Button5.Enabled = False
        Form1.Button6.Enabled = False
        Form1.Button7.Enabled = False
        Form1.Button8.Enabled = False
        Form1.Button9.Enabled = False
        Form1.Button10.Enabled = False
        Form1.Button11.Enabled = False
    End Sub
    Public Sub active()
        Form1.Button1.Enabled = True
        Form1.Button2.Enabled = True
        Form1.Button3.Enabled = True
        Form1.Button4.Enabled = True
        Form1.Button5.Enabled = True
        Form1.Button6.Enabled = True
        Form1.Button7.Enabled = True
        Form1.Button8.Enabled = True
        Form1.Button9.Enabled = True
        Form1.Button10.Enabled = True
        Form1.Button11.Enabled = True
    End Sub
End Class
