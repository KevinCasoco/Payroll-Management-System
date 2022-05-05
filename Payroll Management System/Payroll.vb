Public Class Payroll

    Private Sub Payroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReceiptDataSet.Payroll' table. You can move, or remove it, as needed.
        Me.PayrollTableAdapter.Fill(Me.ReceiptDataSet.Payroll)
        'TODO: This line of code loads data into the 'PayrollDataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.PayrollDataSet.Employee)

    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click

        txtGross.Text = txtRate.Text * txtDays.Text
        txtSSS.Text = 13 / 100 * txtGross.Text
        txtPagIbig.Text = 1 / 100 * txtGross.Text
        txtPhilhealth.Text = 2 / 100 * txtGross.Text
        txtNetpay.Text = Val(txtSSS.Text) + Val(txtPagIbig.Text) + Val(txtPhilhealth.Text)

        txtSalary.Text = Val(txtGross.Text) - Val(txtNetpay.Text)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        PayrollBindingSource.AddNew()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        On Error GoTo saveeror
        If MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            PayrollBindingSource.EndEdit()
            PayrollTableAdapter.Update(ReceiptDataset.Payroll)
            Me.PayrollTableAdapter.Fill(Me.ReceiptDataset.Payroll)
            MessageBox.Show("Saved Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

saveeror:
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Do you want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            PayrollBindingSource.RemoveCurrent()

            PayrollBindingSource.EndEdit()
            PayrollTableAdapter.Update(ReceiptDataset.Payroll)

            MessageBox.Show("Delete Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        RichTextBox1.Text = ""
        RichTextBox1.AppendText("" + vbNewLine)
        RichTextBox1.AppendText("" + vbNewLine)
        RichTextBox1.AppendText("" + vbNewLine)
        RichTextBox1.AppendText("" + vbNewLine)
        RichTextBox1.AppendText("" + vbNewLine)
        RichTextBox1.AppendText("" + vbNewLine)
        RichTextBox1.AppendText("" + vbNewLine)
        RichTextBox1.AppendText("" + vbNewLine)

        RichTextBox1.AppendText(vbTab + vbTab + vbTab + "   DBJE Industry, (Wholesalers Of Retail Grocery Items)." + vbNewLine)
        RichTextBox1.AppendText("" + vbNewLine)
        RichTextBox1.AppendText(vbTab + vbTab + vbTab + vbTab + "  25 Makabud St , Amparo Subdivision" + vbNewLine)
        RichTextBox1.AppendText("" + vbNewLine)
        RichTextBox1.AppendText(vbTab + vbTab + vbTab + "           Brgy 179 Caloocan City, 1400 Metro Manila" + vbNewLine)
        RichTextBox1.AppendText("" + vbNewLine)
        RichTextBox1.AppendText("" + vbNewLine)
        RichTextBox1.AppendText("" + vbTab + vbTab + vbTab + vbTab + vbTab & "       PAYSLIP" + vbTab)
        RichTextBox1.AppendText("" + vbNewLine)
        RichTextBox1.AppendText("" + vbNewLine)
        RichTextBox1.AppendText("__________________________________________________________________________________________" + vbNewLine)
        RichTextBox1.AppendText("" + vbNewLine)
        RichTextBox1.AppendText("" + vbNewLine)
        RichTextBox1.AppendText("Employee Name:" + vbTab + vbTab & cmbLastName.Text + vbTab & cmbFirstName.Text + vbTab + vbNewLine)
        RichTextBox1.AppendText("" + vbNewLine)
        RichTextBox1.AppendText("Date:" + vbTab + vbTab + vbTab & Today + vbNewLine)
        RichTextBox1.AppendText("" + vbNewLine)
        RichTextBox1.AppendText("Time" + vbTab + vbTab + vbTab & TimeOfDay + vbNewLine)
        RichTextBox1.AppendText("" + vbNewLine)
        RichTextBox1.AppendText("Position:" + vbTab + vbTab + vbTab & cmbPosition.Text + vbTab + vbTab + vbNewLine)
        RichTextBox1.AppendText("" + vbNewLine)
        RichTextBox1.AppendText("" + vbNewLine)

        RichTextBox1.AppendText("Rate Per Day" + vbTab + vbTab & txtRate.Text + vbNewLine)
        RichTextBox1.AppendText("No. of Working Days" + vbTab & txtDays.Text + vbNewLine)
        RichTextBox1.AppendText("Gross Pay" + vbTab + vbTab & txtGross.Text + vbNewLine)
        RichTextBox1.AppendText("" + vbNewLine)

        RichTextBox1.AppendText("" + vbNewLine)
        RichTextBox1.AppendText("Deductions" + vbNewLine)
        RichTextBox1.AppendText("" + vbNewLine)

        RichTextBox1.AppendText("SSS" + vbTab + vbTab + vbTab & txtSSS.Text + vbNewLine)
        RichTextBox1.AppendText("PAG IBIG" + vbTab + vbTab & txtPagIbig.Text + vbNewLine)
        RichTextBox1.AppendText("PHILHEALTH" + vbTab + vbTab & txtPhilhealth.Text + vbNewLine)

        RichTextBox1.AppendText("" + vbNewLine)
        RichTextBox1.AppendText("Total Deductions" + vbTab + vbTab & txtNetpay.Text + vbTab + vbTab + vbNewLine)
        RichTextBox1.AppendText("" + vbNewLine)
        RichTextBox1.AppendText("" + vbNewLine)
        RichTextBox1.AppendText("Total Salary" + vbTab + vbTab & txtSalary.Text + vbTab + vbTab + vbNewLine)
        RichTextBox1.AppendText("" + vbNewLine)
        RichTextBox1.AppendText("" + vbNewLine)
        RichTextBox1.AppendText("__________________________________________________________________________________________" + vbNewLine)

        RichTextBox1.AppendText("" + vbNewLine)
        RichTextBox1.AppendText("" + vbNewLine)
        RichTextBox1.AppendText(vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + "Receive by: " & cmbLastName.Text + vbNewLine)
        RichTextBox1.AppendText("" + vbNewLine)
        RichTextBox1.AppendText("" + vbNewLine)
        RichTextBox1.AppendText("" + vbNewLine)
        RichTextBox1.AppendText("" + vbNewLine)
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(RichTextBox1.Text, Font, Brushes.Black, 140, 140)
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub lblEmployee_Click(sender As Object, e As EventArgs) Handles lblEmployee.Click
        Employee.Show()
        Me.Hide()
    End Sub

    Private Sub lblLogOut_Click(sender As Object, e As EventArgs) Handles lblLogOut.Click
        If MessageBox.Show("Are you sure to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            LogIn.Show()
            Me.Hide()

        End If
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        PayrollBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        PayrollBindingSource.MoveNext()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Me.PayrollBindingSource.Filter = "[LAST NAME]  like '%" & txtSearch.Text & "'"
    End Sub
End Class