Public Class Form1
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        login.Show()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            Me.BuscardocumentosTableAdapter.Fill(Me.DataSet1.buscardocumentos, TextBox4.Text, TextBox1.Text, TextBox2.Text, TextBox3.Text, ComboBox2.SelectedValue)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = 1 Then
            TextBox1.Enabled = True
        Else
            TextBox1.Enabled = False
            TextBox1.Clear()
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.CheckState = 1 Then
            TextBox2.Enabled = True
        Else
            TextBox2.Enabled = False
            TextBox2.Clear()
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.CheckState = 1 Then
            TextBox3.Enabled = True
        Else
            TextBox3.Enabled = False
            TextBox3.Clear()
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.CheckState = 1 Then
            TextBox4.Enabled = True
        Else
            TextBox4.Enabled = False
            TextBox4.Clear()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.Tipo_de_Documento' table. You can move, or remove it, as needed.
        Me.Tipo_de_DocumentoTableAdapter.Fill(Me.DataSet1.Tipo_de_Documento)
        Try
            Me.BuscardocumentosTableAdapter.Fill(Me.DataSet1.buscardocumentos, TextBox4.Text, TextBox1.Text, TextBox2.Text, TextBox3.Text, ComboBox2.SelectedValue)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Label3.Text = DateAndTime.Today.ToLongDateString
    End Sub
End Class
