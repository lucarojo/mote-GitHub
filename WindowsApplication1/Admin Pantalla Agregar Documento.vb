Public Class Form5

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet11.Tipo_de_Documento' table. You can move, or remove it, as needed.
        'Me.Tipo_de_DocumentoTableAdapter.Fill(Me.DataSet11.Tipo_de_Documento)
        'TODO: This line of code loads data into the 'DataSet11.Alumnos' table. You can move, or remove it, as needed.
        'Me.AlumnosTableAdapter.Fill(Me.DataSet11.Alumnos)
        'TODO: This line of code loads data into the 'DataSet1.Tipo_de_Documento' table. You can move, or remove it, as needed.
        Me.Tipo_de_DocumentoTableAdapter.Fill(Me.DataSet1.Tipo_de_Documento)
        'TODO: This line of code loads data into the 'DataSet1.Alumnos' table. You can move, or remove it, as needed.
        Me.AlumnosTableAdapter.Fill(Me.DataSet1.Alumnos)
        'TODO: This line of code loads data into the 'DataSet1.Documentos' table. You can move, or remove it, as needed.
        'Me.DocumentosTableAdapter.Fill(Me.DataSet1.Documentos)
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        Dim rnum As Random
        Dim num As Integer
        rnum = New Random
        num = rnum.Next(1, 999999999)

        'DocumentoIDTextBox.Enabled = False
        'NombreTextBox.Enabled = False
        'AñoTextBox.Enabled = False
        'ComboBox1.Enabled = False
        'ComboBox2.Enabled = False
        DocumentosBindingSource.AddNew()
        DocumentoIDTextBox.Text = num.ToString
        'AñoTextBox.Text = Today.Date.Year
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub AgregarDocumentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarDocumentoToolStripMenuItem.Click
        'Form5.Show()
        'Me.Close()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'My.Computer.FileSystem.CopyFile(source, "C:\Documentos\" & nombre)
        DocumentoIDTextBox.Enabled = True
        NombreTextBox.Enabled = True
        'AñoTextBox.Enabled = True
        ComboBox1.Enabled = True
        ComboBox2.Enabled = True
        Dim rnum As Random
        Dim num As Integer
        rnum = New Random
        num = rnum.Next(1, 999999999)
        DocumentosBindingSource.AddNew()
        DocumentoIDTextBox.Text = num.ToString


    End Sub

    Private Sub DocumentosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DocumentosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DocumentosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)
        Try
            My.Computer.FileSystem.CopyFile(source, servidor & nombre)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DocumentoIDTextBox.Clear()
        NombreTextBox.Clear()
        TextBox5.Clear()
        Archivo_AdjuntoTextBox.Clear()
        'AñoTextBox.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        Try
            DocumentosBindingSource.RemoveCurrent()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Me.Validate()
            Me.DocumentosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DataSet1)
            My.Computer.FileSystem.CopyFile(source, servidor & nombre)
            TextBox5.Clear()
            Dim rnum As Random
            Dim num As Integer
            rnum = New Random
            num = rnum.Next(1, 999999999)
            DocumentosBindingSource.AddNew()
            DocumentoIDTextBox.Text = num.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub MantenimientoAlumnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoAlumnosToolStripMenuItem.Click
        AgregarAlumnos.Show()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Form9.Show()
    End Sub
End Class