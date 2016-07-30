Public Class Form4

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Form9.Show()

    End Sub

    Private Sub Form4_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.Solicitudes' table. You can move, or remove it, as needed.
        Me.SolicitudesTableAdapter.Fill(Me.DataSet1.Solicitudes)
        'TODO: This line of code loads data into the 'DataSet1.Estado' table. You can move, or remove it, as needed.
        Me.EstadoTableAdapter.Fill(Me.DataSet1.Estado)
        Label3.Text = DateAndTime.Today.ToLongDateString
        ComboBox1.Text = "Pendiente"

        Try
            Me.ConsultaSolicitudesEstadoTableAdapter.Fill(Me.DataSet1.ConsultaSolicitudesEstado, "PEN")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        'Form4.Show()
        'Me.Close()
    End Sub

    Private Sub AgregarDocumentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarDocumentoToolStripMenuItem.Click
        Form5.Show()
        Me.Close()

    End Sub

    Private Sub BuscarDocumentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarDocumentoToolStripMenuItem.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Form1.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            Me.ConsultaSolicitudesEstadoTableAdapter.Fill(Me.DataSet1.ConsultaSolicitudesEstado, ComboBox1.SelectedValue)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.ConsultaSolicitudesEstadoTableAdapter.Fill(Me.DataSet1.ConsultaSolicitudesEstado, ComboBox1.SelectedValue)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ConsultaSolicitudesEstadoDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ConsultaSolicitudesEstadoDataGridView.CellContentClick
        Dim row As DataGridViewRow = ConsultaSolicitudesEstadoDataGridView.CurrentRow
        Jalar = CStr(row.Cells(0).Value)
        Form7.Show()

    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        AgregarAlumnos.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem1.Click
        AgregarUsuarios.Show()
    End Sub

    Private Sub CarrerasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarrerasToolStripMenuItem.Click
        agregarcarreras.Show()
    End Sub

    Private Sub OpcionesAvanzadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpcionesAvanzadasToolStripMenuItem.Click
        opcionesavanzadas.Show()
    End Sub
End Class
