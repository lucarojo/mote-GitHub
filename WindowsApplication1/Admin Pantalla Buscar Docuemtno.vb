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
        'TODO: This line of code loads data into the 'DataSet1.Tipo_de_Documento' table. You can move, or remove it, as needed.
        Me.Tipo_de_DocumentoTableAdapter.Fill(Me.DataSet1.Tipo_de_Documento)
        'TODO: This line of code loads data into the 'DataSet1.Carreras' table. You can move, or remove it, as needed.
        Me.CarrerasTableAdapter.Fill(Me.DataSet1.Carreras)

        Try
            Me.BuscardocumentosTableAdapter.Fill(Me.DataSet1.buscardocumentos, TextBox4.Text, TextBox1.Text, TextBox2.Text, TextBox3.Text, ComboBox2.SelectedValue)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
    End Sub

    Private Sub MantenimientoAlumnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoAlumnosToolStripMenuItem.Click
        AgregarAlumnos.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.BuscardocumentosTableAdapter.Fill(Me.DataSet1.buscardocumentos, TextBox4.Text, TextBox1.Text, TextBox2.Text, TextBox3.Text, ComboBox2.SelectedValue)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox1.Enabled = True
        Else
            TextBox1.Enabled = False
            TextBox1.Clear()
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            TextBox2.Enabled = True
        Else
            TextBox2.Enabled = False
            TextBox2.Clear()
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then
            TextBox3.Enabled = True
        Else
            TextBox3.Enabled = False
            TextBox3.Clear()
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            TextBox4.Enabled = True
        Else
            TextBox4.Enabled = False
            TextBox4.Clear()
        End If
    End Sub

    Private Sub BuscardocumentosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BuscardocumentosDataGridView.CellContentClick
        Dim row As DataGridViewRow = BuscardocumentosDataGridView.CurrentRow
        Jalar = CStr(row.Cells(0).Value)
        EditarDocumento.Show()
    End Sub
End Class