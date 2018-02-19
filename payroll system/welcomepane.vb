Public Class WelcomePane
    Private Sub WelcomePane_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SignUpButton_Click(sender As Object, e As EventArgs) Handles SignUpButton.Click
        loginpane.Show()
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
