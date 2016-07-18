Public Class OpcionesAvanzadas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ruta As New FolderBrowserDialog()
        ruta.RootFolder = Environment.SpecialFolder.Desktop
        ruta.SelectedPath = "C:\"
        ruta.Description = "Seleccionar ruta para descargar"
        If ruta.ShowDialog() = DialogResult.OK Then
            servidor = ruta.SelectedPath
            TextBox1.Text = servidor
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub OpcionesAvanzadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = servidor
    End Sub
End Class