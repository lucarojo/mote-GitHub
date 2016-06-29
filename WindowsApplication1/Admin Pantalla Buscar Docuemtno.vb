Public Class Form3
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub AgregarDocumentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarDocumentoToolStripMenuItem.Click
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub BuscarDocumentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarDocumentoToolStripMenuItem.Click
        'Form3.Show()
        'Me.Close()
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

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MantenimientoAlumnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoAlumnosToolStripMenuItem.Click
        AgregarAlumnos.Show()
    End Sub
End Class