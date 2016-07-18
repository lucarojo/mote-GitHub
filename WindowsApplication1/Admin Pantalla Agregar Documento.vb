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
        Button2.Enabled = False

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
        'DocumentoIDTextBox.Clear()
        'NombreTextBox.Clear()
        'TextBox5.Clear()
        'Archivo_AdjuntoTextBox.Clear()
        ''AñoTextBox.Clear()
        'ComboBox1.Text = ""
        'ComboBox2.Text = ""
        'Try
        '    DocumentosBindingSource.RemoveCurrent()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        Form4.Show()
        Me.Close()

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
            Button2.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Form9.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        'Form5.Show()
        'Me.Close()
    End Sub

    Private Sub UsuariosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem1.Click
        AgregarUsuarios.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        AgregarAlumnos.Show()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        Form1.Show()
    End Sub

    Private Sub OpcionesAvanzadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpcionesAvanzadasToolStripMenuItem.Click
        OpcionesAvanzadas.Show()
    End Sub
End Class