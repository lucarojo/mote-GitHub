Public Class Form3
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

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

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        AgregarAlumnos.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem1.Click
        AgregarAlumnos.Show()
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        Form1.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        'Form3.Show()
        'Me.Close()
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Form9.Show()
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub OpcionesAvanzadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpcionesAvanzadasToolStripMenuItem.Click
        OpcionesAvanzadas.Show()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub CarrerasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarrerasToolStripMenuItem.Click
        'agregarcarreras.show()
    End Sub
End Class