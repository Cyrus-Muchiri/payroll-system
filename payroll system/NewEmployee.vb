Imports System.Data.OleDb

Public Class New_Employee

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Dim buttonDialogResult As DialogResult = MessageBox.Show("Are you sure you wan to quit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If buttonDialogResult = DialogResult.Yes Then
            Me.Close()

        End If
    End Sub

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click

        Dim ConnectionString = "provider=Microsoft.jet.OlEDB.4.0; Data Source=F:\vbprojects\payroll system\employee database.mdb"
        Dim connection As New OleDbConnection(ConnectionString)

        connection.Open()
        Dim strSQL As String
        strSQL = "INSERT INTO employees(EmpID,EmpName,Gender,dateOfBirth,
                    Address,City,contact,Department,dateOfJoining,remarks)
VALUES('" & IdTextBox.Text & " ' ,'" & NameTextBox.Text & "','" & genderTextBox.Text & "',
'" & DOBTextBox.Text & "','" & AddressTextBox.Text & "','" & CityTextBox.Text & "','" & contactTextBox.Text & "','" & DepartmentTextBox.Text & "',
'" & DOJTextBox.Text & "','" & remarksRichTextBox.Text & "')"
        Dim command As OleDbCommand = New OleDbCommand(strSQL, connection)



        Dim num As Integer = command.ExecuteNonQuery
        connection.Close()

        Dim reset As String = ""
        IdTextBox.Text = reset
        NameTextBox.Text = reset
        genderTextBox.Text = reset
        DOBTextBox.Text = reset
        AddressTextBox.Text = reset
        CityTextBox.Text = reset
        contactTextBox.Text = reset
        DepartmentTextBox.Text = reset
        DOJTextBox.Text = reset




        If (num <> 0) Then
            MessageBox.Show("Record succesfully udated", "Add record")

            Me.Close()

        Else
            MessageBox.Show("Record not added", "Add record error")
        End If


    End Sub




End Class