Public Class payroll
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles deleteToolStripMenuItem.Click
        deleteEmployee.Show()
    End Sub

    Private Sub NewOrganzationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        New_Employee.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles updateToolStripMenuItem.Click
        updateEmployee.Show()
    End Sub

    Private Sub searchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles searchToolStripMenuItem.Click
        searchEmployee.Show()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        payrollcalc.Show()
    End Sub
End Class