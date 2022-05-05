Public Class LogIn

    Dim Attempt As Integer = 0
    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        If txtUsername.Text = "admin" And txtPassword.Text = "1234" Then
            Employee.Show()
            txtUsername.Text = ""
            txtPassword.Text = ""
            txtUsername.Select()
            Me.Hide()

        ElseIf txtUsername.Text = "andrei" And txtPassword.Text = "1234" Then
            Payroll.Show()
            txtUsername.Text = ""
            txtPassword.Text = ""
            txtUsername.Select()
            Me.Hide()

        Else
            MessageBox.Show("Your username and password is incorrect!!")
            Attempt = Attempt + 1
            txtUsername.Text = ""
            txtPassword.Text = ""
            txtUsername.Select()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
