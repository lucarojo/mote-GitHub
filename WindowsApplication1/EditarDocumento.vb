Public Class EditarDocumento
    Private Sub EditarDocumento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.Tipo_de_Documento' table. You can move, or remove it, as needed.
        Me.Tipo_de_DocumentoTableAdapter.Fill(Me.DataSet1.Tipo_de_Documento)
        'TODO: This line of code loads data into the 'DataSet1.Alumnos' table. You can move, or remove it, as needed.
        Me.AlumnosTableAdapter.Fill(Me.DataSet1.Alumnos)
        TextBox1.Text = Jalar
        TextBox5.Text = " "

        Try
            Me.ModificarDocumentoTableAdapter.Fill(Me.DataSet1.modificarDocumento, TextBox1.Text, NombreTextBox.Text, New System.Nullable(Of Date)(CType(AñoDateTimePicker.Text, Date)), Archivo_AdjuntoTextBox.Text, ComboBox2.SelectedValue, ComboBox1.SelectedValue)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.ModificarDocumentoTableAdapter.Fill(Me.DataSet1.modificarDocumento, TextBox1.Text, NombreTextBox.Text, New System.Nullable(Of Date)(CType(AñoDateTimePicker.Text, Date)), Archivo_AdjuntoTextBox.Text, ComboBox2.SelectedValue, ComboBox1.SelectedValue)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.ModificarDocumentoTableAdapter.Fill(Me.DataSet1.modificarDocumento, TextBox1.Text, NombreTextBox.Text, New System.Nullable(Of Date)(CType(AñoDateTimePicker.Text, Date)), Archivo_AdjuntoTextBox.Text, ComboBox2.SelectedValue, ComboBox1.SelectedValue)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        'Form3.Show()
        Try
            Form3.BuscardocumentosTableAdapter.Fill(Form3.DataSet1.buscardocumentos, Form3.TextBox4.Text, Form3.TextBox1.Text, Form3.TextBox2.Text, Form3.TextBox3.Text, Form3.ComboBox2.SelectedValue)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        If TextBox5.Text <> " " Then
            Try
                My.Computer.FileSystem.CopyFile(source, servidor & nombre)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim file As New OpenFileDialog()
        If file.ShowDialog() = DialogResult.OK Then
            TextBox5.Text = file.FileName
            source = file.FileName
            Dim tam As Integer = Len(source)
            Dim pos As Integer
            Dim compares As String = "\"
            pos = InStrRev(source, compares)
            Dim tmp As Integer = tam - pos
            nombre = Strings.Right(source, tmp)
            Archivo_AdjuntoTextBox.Text = servidor & nombre
            NombreTextBox.Text = nombre
            ' My.Computer.FileSystem.CopyFile(source, "C:\Documentos\" & nombre)
        End If
    End Sub
End Class