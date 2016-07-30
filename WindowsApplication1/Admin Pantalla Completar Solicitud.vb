Public Class Form7
    Dim varsolicitudid As String
    Dim varestadoid As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.UpdateEstadoEnSolicitudTableAdapter.Fill(Me.DataSet1.updateEstadoEnSolicitud, varsolicitudid, varestadoid)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Me.Close()

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = False
        TextBox2.Text = Jalar
        varsolicitudid = Jalar
        varestadoid = "COM"
        Try
            Me.DocumentosDeSolicitudTableAdapter.Fill(Me.DataSet1.DocumentosDeSolicitud, Jalar)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DocumentosDeSolicitudDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DocumentosDeSolicitudDataGridView.CellContentClick
        Dim row As DataGridViewRow = DocumentosDeSolicitudDataGridView.CurrentRow
        Jalar = CStr(row.Cells(0).Value)
        Dim tam As Integer = Len(Jalar)
        Dim pos As Integer
        Dim compares As String = "\"
        pos = InStrRev(Jalar, compares)
        Dim tmp As Integer = tam - pos
        Dim nombre As String
        nombre = Strings.Right(Jalar, tmp)
        Dim destino As String
        Dim ruta As New FolderBrowserDialog()
        ruta.RootFolder = Environment.SpecialFolder.Desktop
        ruta.SelectedPath = "C:\"
        ruta.Description = "Seleccionar ruta para descargar"
        If ruta.ShowDialog() = DialogResult.OK Then
            destino = ruta.SelectedPath
            Try
                My.Computer.FileSystem.CopyFile(Jalar, destino & "\" & nombre)
                MsgBox("Documento salvado exitosamente en " & destino, MsgBoxStyle.OkOnly, "SISTEMA")
                Button1.Enabled = True
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
        'MsgBox("Documento salvado con éxito en" & destino, MsgBoxStyle.OkOnly, "SISTEMA")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class