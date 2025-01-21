Public Class Home
    Private Sub milkDairyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles milkDairyToolStripMenuItem.Click
        MilkDairy.ShowDialog()
    End Sub

    Private Sub setFatePriceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles setFatePriceToolStripMenuItem.Click
        SetFatePrice.ShowDialog()
    End Sub

    Private Sub searchAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles searchAccountToolStripMenuItem.Click
        SearchAccount.ShowDialog()
    End Sub

    Private Sub searchMilkDairyRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles searchMilkDairyRecordToolStripMenuItem.Click
        SearchMilkDairyRecord.ShowDialog()
    End Sub

    Private Sub newAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles newAccountToolStripMenuItem.Click
        NewAccount.ShowDialog()
    End Sub

    Private Sub pictureBox1_Click(sender As Object, e As EventArgs) Handles pictureBox1.Click

    End Sub

    Private Sub exitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exitToolStripMenuItem.Click
        Application.Exit()

    End Sub
End Class