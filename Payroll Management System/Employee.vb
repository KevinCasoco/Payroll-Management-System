Public Class Employee

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PayrollDataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.PayrollDataSet.Employee)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        EmployeeBindingSource.AddNew()
        txtEmployeeID.Select()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        On Error GoTo saveeror
        If MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            EmployeeBindingSource.EndEdit()
            EmployeeTableAdapter.Update(PayrollDataSet.Employee)

            Me.EmployeeTableAdapter.Fill(Me.PayrollDataSet.Employee)
            txtEmployeeID.Select()
            MessageBox.Show("Saved Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

saveeror:
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Do you want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            EmployeeBindingSource.RemoveCurrent()

            EmployeeBindingSource.EndEdit()
            EmployeeTableAdapter.Update(PayrollDataSet.Employee)
            txtEmployeeID.Select()

            MessageBox.Show("Delete Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        EmployeeBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        EmployeeBindingSource.MoveNext()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim Mypicture As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
        With OpenFileDialog1
            .Filter = "jpg, jpeg Image|*.jpg, jpeg|PNG Image|*.png|BMP Image|*.bmp|" & "All Files  (*.*)|*.*"
            .Title = "Choose the Picture.."
            .FilterIndex = 1
            .Multiselect = False
            .ValidateNames = True
            .InitialDirectory = Mypicture
            .RestoreDirectory = True
            If (.ShowDialog = Windows.Forms.DialogResult.OK) Then
                PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            Else
                Return

            End If
        End With
    End Sub


    Private Sub lblPayroll_Click(sender As Object, e As EventArgs) Handles lblPayroll.Click
        Payroll.Show()
        Me.Hide()
    End Sub

    Private Sub lblLogOut_Click(sender As Object, e As EventArgs) Handles lblLogOut.Click
        If MessageBox.Show("Are you sure to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            LogIn.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Me.EmployeeBindingSource.Filter = "[LAST NAME]  like '%" & txtSearch.Text & "'"
    End Sub

End Class