Public Class Form1
    Private Sub btnAdj_Click(sender As Object, e As EventArgs) Handles btnAdj.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            txtdoc.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub btnexaminar_Click(sender As Object, e As EventArgs) Handles btnexaminar.Click

        Dim file As New OpenFileDialog()
        If file.ShowDialog() = DialogResult.OK Then
            txtdoc.Text = file.FileName
        End If
    End Sub
End Class
