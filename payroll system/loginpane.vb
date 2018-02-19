Imports System.Data.OleDb

Public Class loginpane
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        Dim userName, password As String
        Dim FirstName = firstNameTextBox.Text
        Dim LastName = lastNameTextBox.Text

        Try

            passworTextBox.PasswordChar = "*"
            userName = UsernameTextBox.Text
            password = Integer.Parse(passworTextBox.Text, Globalization.NumberStyles.Number)



            If (userName = "ADMIN" And password = "1234") Then
                payroll.Show()
                payroll.Label1.Text = "Welcome  " & FirstName & "  " & LastName
                Me.Close()
            Else
                MessageBox.Show("Incorrect username or password", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch
            If (userName = "" Or password = "") Then
                MessageBox.Show("Incorrect username or password", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Try
    End Sub

    Private Sub passworTextBox_TextChanged(sender As Object, e As EventArgs) Handles passworTextBox.TextChanged

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class