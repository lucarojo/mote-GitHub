<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditarDocumento
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NombreLabel As System.Windows.Forms.Label
        Dim AñoLabel As System.Windows.Forms.Label
        Dim Archivo_AdjuntoLabel As System.Windows.Forms.Label
        Dim AlumnoIDLabel As System.Windows.Forms.Label
        Dim TipoDocIDLabel As System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataSet1 = New WindowsApplication1.DataSet1()
        Me.TableAdapterManager = New WindowsApplication1.DataSet1TableAdapters.TableAdapterManager()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ModificarDocumentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoDeDocumentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.AlumnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlumnosTableAdapter = New WindowsApplication1.DataSet1TableAdapters.AlumnosTableAdapter()
        Me.Tipo_de_DocumentoTableAdapter = New WindowsApplication1.DataSet1TableAdapters.Tipo_de_DocumentoTableAdapter()
        Me.ModificarDocumentoTableAdapter = New WindowsApplication1.DataSet1TableAdapters.modificarDocumentoTableAdapter()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.AñoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Archivo_AdjuntoTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        NombreLabel = New System.Windows.Forms.Label()
        AñoLabel = New System.Windows.Forms.Label()
        Archivo_AdjuntoLabel = New System.Windows.Forms.Label()
        AlumnoIDLabel = New System.Windows.Forms.Label()
        TipoDocIDLabel = New System.Windows.Forms.Label()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModificarDocumentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoDeDocumentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(9, 94)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(122, 13)
        NombreLabel.TabIndex = 68
        NombreLabel.Text = "Nombre del Documento:"
        '
        'AñoLabel
        '
        AñoLabel.AutoSize = True
        AñoLabel.Location = New System.Drawing.Point(9, 128)
        AñoLabel.Name = "AñoLabel"
        AñoLabel.Size = New System.Drawing.Size(100, 13)
        AñoLabel.TabIndex = 70
        AñoLabel.Text = "Fecha de Creación:"
        '
        'Archivo_AdjuntoLabel
        '
        Archivo_AdjuntoLabel.AutoSize = True
        Archivo_AdjuntoLabel.Location = New System.Drawing.Point(9, 65)
        Archivo_AdjuntoLabel.Name = "Archivo_AdjuntoLabel"
        Archivo_AdjuntoLabel.Size = New System.Drawing.Size(85, 13)
        Archivo_AdjuntoLabel.TabIndex = 72
        Archivo_AdjuntoLabel.Text = "Archivo Adjunto:"
        '
        'AlumnoIDLabel
        '
        AlumnoIDLabel.AutoSize = True
        AlumnoIDLabel.Location = New System.Drawing.Point(9, 156)
        AlumnoIDLabel.Name = "AlumnoIDLabel"
        AlumnoIDLabel.Size = New System.Drawing.Size(79, 13)
        AlumnoIDLabel.TabIndex = 74
        AlumnoIDLabel.Text = "Alumno (Autor):"
        '
        'TipoDocIDLabel
        '
        TipoDocIDLabel.AutoSize = True
        TipoDocIDLabel.Location = New System.Drawing.Point(9, 182)
        TipoDocIDLabel.Name = "TipoDocIDLabel"
        TipoDocIDLabel.Size = New System.Drawing.Size(89, 13)
        TipoDocIDLabel.TabIndex = 76
        TipoDocIDLabel.Text = "Tipo Documento:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(530, 35)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(324, 171)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 36)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Actualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(474, 171)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 36)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(313, 33)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(144, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Adjuntar Archivo"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AlumnosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CarrerasTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.Detalle_CarrerasTableAdapter = Nothing
        Me.TableAdapterManager.DocumentosTableAdapter = Nothing
        Me.TableAdapterManager.EstadoTableAdapter = Nothing
        Me.TableAdapterManager.SolicitudesTableAdapter = Nothing
        Me.TableAdapterManager.Tipo_de_DocumentoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ModificarDocumentoBindingSource, "TipoDocID", True))
        Me.ComboBox2.DataSource = Me.TipoDeDocumentoBindingSource
        Me.ComboBox2.DisplayMember = "TipoDocumento"
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(104, 180)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox2.TabIndex = 67
        Me.ComboBox2.ValueMember = "TipoDocID"
        '
        'ModificarDocumentoBindingSource
        '
        Me.ModificarDocumentoBindingSource.DataMember = "modificarDocumento"
        Me.ModificarDocumentoBindingSource.DataSource = Me.DataSet1
        '
        'TipoDeDocumentoBindingSource
        '
        Me.TipoDeDocumentoBindingSource.DataMember = "Tipo de Documento"
        Me.TipoDeDocumentoBindingSource.DataSource = Me.DataSet1
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ModificarDocumentoBindingSource, "AlumnoID", True))
        Me.ComboBox1.DataSource = Me.AlumnosBindingSource
        Me.ComboBox1.DisplayMember = "Nombre"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(104, 153)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox1.TabIndex = 66
        Me.ComboBox1.ValueMember = "AlumnoID"
        '
        'AlumnosBindingSource
        '
        Me.AlumnosBindingSource.DataMember = "Alumnos"
        Me.AlumnosBindingSource.DataSource = Me.DataSet1
        '
        'AlumnosTableAdapter
        '
        Me.AlumnosTableAdapter.ClearBeforeFill = True
        '
        'Tipo_de_DocumentoTableAdapter
        '
        Me.Tipo_de_DocumentoTableAdapter.ClearBeforeFill = True
        '
        'ModificarDocumentoTableAdapter
        '
        Me.ModificarDocumentoTableAdapter.ClearBeforeFill = True
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModificarDocumentoBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(137, 91)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(257, 20)
        Me.NombreTextBox.TabIndex = 69
        '
        'AñoDateTimePicker
        '
        Me.AñoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ModificarDocumentoBindingSource, "Año", True))
        Me.AñoDateTimePicker.Location = New System.Drawing.Point(115, 122)
        Me.AñoDateTimePicker.Name = "AñoDateTimePicker"
        Me.AñoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.AñoDateTimePicker.TabIndex = 71
        '
        'Archivo_AdjuntoTextBox
        '
        Me.Archivo_AdjuntoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModificarDocumentoBindingSource, "Archivo_Adjunto", True))
        Me.Archivo_AdjuntoTextBox.Location = New System.Drawing.Point(100, 62)
        Me.Archivo_AdjuntoTextBox.Name = "Archivo_AdjuntoTextBox"
        Me.Archivo_AdjuntoTextBox.ReadOnly = True
        Me.Archivo_AdjuntoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Archivo_AdjuntoTextBox.TabIndex = 73
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Documento"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(100, 33)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(200, 20)
        Me.TextBox5.TabIndex = 77
        '
        'EditarDocumento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 235)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(AñoLabel)
        Me.Controls.Add(Me.AñoDateTimePicker)
        Me.Controls.Add(Archivo_AdjuntoLabel)
        Me.Controls.Add(Me.Archivo_AdjuntoTextBox)
        Me.Controls.Add(AlumnoIDLabel)
        Me.Controls.Add(TipoDocIDLabel)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "EditarDocumento"
        Me.Text = "EditarDocumento"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModificarDocumentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoDeDocumentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents AlumnosBindingSource As BindingSource
    Friend WithEvents AlumnosTableAdapter As DataSet1TableAdapters.AlumnosTableAdapter
    Friend WithEvents TipoDeDocumentoBindingSource As BindingSource
    Friend WithEvents Tipo_de_DocumentoTableAdapter As DataSet1TableAdapters.Tipo_de_DocumentoTableAdapter
    Friend WithEvents ModificarDocumentoBindingSource As BindingSource
    Friend WithEvents ModificarDocumentoTableAdapter As DataSet1TableAdapters.modificarDocumentoTableAdapter
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents AñoDateTimePicker As DateTimePicker
    Friend WithEvents Archivo_AdjuntoTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
End Class
