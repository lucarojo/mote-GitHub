﻿Public Class Form7
    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub AgregarDocumentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarDocumentoToolStripMenuItem.Click
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub BuscarDocumentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarDocumentoToolStripMenuItem.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub MantenimientoUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoUsuariosToolStripMenuItem.Click
        AgregarUsuarios.Show()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.UpdateEstadoEnSolicitudTableAdapter.Fill(Me.DataSet1.updateEstadoEnSolicitud, SolicitudID.Text, EstadoID.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Me.Close()

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Text = Jalar
        SolicitudID.Text = Jalar
        EstadoID.Text = "COM"
        ' Try
        Me.DocumentosDeSolicitudTableAdapter.Fill(Me.DataSet1.DocumentosDeSolicitud, TextBox2.Text)
        'Catch ex As System.Exception
        'System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try
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
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
        'MsgBox("Documento salvado con éxito en" & destino, MsgBoxStyle.OkOnly, "SISTEMA")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub MantenimientoAlumnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoAlumnosToolStripMenuItem.Click
        AgregarAlumnos.Show()
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Form9.Show()
    End Sub
End Class