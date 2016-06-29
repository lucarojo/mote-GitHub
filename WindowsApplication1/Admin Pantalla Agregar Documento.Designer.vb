<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
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
        Dim DocumentoIDLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim Archivo_AdjuntoLabel As System.Windows.Forms.Label
        Dim AñoLabel As System.Windows.Forms.Label
        Dim TipoDocIDLabel As System.Windows.Forms.Label
        Dim AlumnoIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.AgregarDocumentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarDocumentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.MantenimientoUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.DocumentosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.DocumentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New WindowsApplication1.DataSet1()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DocumentosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DocumentoIDTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.Archivo_AdjuntoTextBox = New System.Windows.Forms.TextBox()
        Me.AñoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.AlumnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DocumentosTableAdapter = New WindowsApplication1.DataSet1TableAdapters.DocumentosTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.DataSet1TableAdapters.TableAdapterManager()
        Me.AlumnosTableAdapter = New WindowsApplication1.DataSet1TableAdapters.AlumnosTableAdapter()
        Me.TipoDeDocumentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tipo_de_DocumentoTableAdapter = New WindowsApplication1.DataSet1TableAdapters.Tipo_de_DocumentoTableAdapter()
        Me.DataSet11 = New WindowsApplication1.DataSet1()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        DocumentoIDLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        Archivo_AdjuntoLabel = New System.Windows.Forms.Label()
        AñoLabel = New System.Windows.Forms.Label()
        TipoDocIDLabel = New System.Windows.Forms.Label()
        AlumnoIDLabel = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DocumentosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentosBindingNavigator.SuspendLayout()
        CType(Me.DocumentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoDeDocumentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DocumentoIDLabel
        '
        DocumentoIDLabel.AutoSize = True
        DocumentoIDLabel.Location = New System.Drawing.Point(12, 36)
        DocumentoIDLabel.Name = "DocumentoIDLabel"
        DocumentoIDLabel.Size = New System.Drawing.Size(79, 13)
        DocumentoIDLabel.TabIndex = 51
        DocumentoIDLabel.Text = "Documento ID:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(12, 117)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(122, 13)
        NombreLabel.TabIndex = 53
        NombreLabel.Text = "Nombre del Documento:"
        '
        'Archivo_AdjuntoLabel
        '
        Archivo_AdjuntoLabel.AutoSize = True
        Archivo_AdjuntoLabel.Location = New System.Drawing.Point(12, 91)
        Archivo_AdjuntoLabel.Name = "Archivo_AdjuntoLabel"
        Archivo_AdjuntoLabel.Size = New System.Drawing.Size(85, 13)
        Archivo_AdjuntoLabel.TabIndex = 57
        Archivo_AdjuntoLabel.Text = "Archivo Adjunto:"
        '
        'AñoLabel
        '
        AñoLabel.AutoSize = True
        AñoLabel.Location = New System.Drawing.Point(12, 181)
        AñoLabel.Name = "AñoLabel"
        AñoLabel.Size = New System.Drawing.Size(29, 13)
        AñoLabel.TabIndex = 62
        AñoLabel.Text = "Año:"
        '
        'TipoDocIDLabel
        '
        TipoDocIDLabel.AutoSize = True
        TipoDocIDLabel.Location = New System.Drawing.Point(12, 209)
        TipoDocIDLabel.Name = "TipoDocIDLabel"
        TipoDocIDLabel.Size = New System.Drawing.Size(89, 13)
        TipoDocIDLabel.TabIndex = 61
        TipoDocIDLabel.Text = "Tipo Documento:"
        '
        'AlumnoIDLabel
        '
        AlumnoIDLabel.AutoSize = True
        AlumnoIDLabel.Location = New System.Drawing.Point(12, 183)
        AlumnoIDLabel.Name = "AlumnoIDLabel"
        AlumnoIDLabel.Size = New System.Drawing.Size(79, 13)
        AlumnoIDLabel.TabIndex = 59
        AlumnoIDLabel.Text = "Alumno (Autor):"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(574, 197)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 39)
        Me.Button3.TabIndex = 34
        Me.Button3.Text = "Cancelar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(464, 53)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(214, 77)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "Crear Nuevo"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(272, 60)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 23)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Adjuntar Archivo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Documento"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(108, 62)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(158, 20)
        Me.TextBox5.TabIndex = 24
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton5, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(699, 25)
        Me.ToolStrip1.TabIndex = 50
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(56, 22)
        Me.ToolStripButton5.Text = "Inicio"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(117, 22)
        Me.ToolStripButton3.Text = "Generar Reportes"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarDocumentoToolStripMenuItem, Me.BuscarDocumentoToolStripMenuItem})
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(118, 22)
        Me.ToolStripButton4.Text = "Mantenimiento"
        '
        'AgregarDocumentoToolStripMenuItem
        '
        Me.AgregarDocumentoToolStripMenuItem.Name = "AgregarDocumentoToolStripMenuItem"
        Me.AgregarDocumentoToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.AgregarDocumentoToolStripMenuItem.Text = "Agregar Documento"
        '
        'BuscarDocumentoToolStripMenuItem
        '
        Me.BuscarDocumentoToolStripMenuItem.Name = "BuscarDocumentoToolStripMenuItem"
        Me.BuscarDocumentoToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.BuscarDocumentoToolStripMenuItem.Text = "Buscar Documento"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoUsuariosToolStripMenuItem, Me.CerrarSesiónToolStripMenuItem})
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(81, 22)
        Me.ToolStripButton1.Text = "Usuarios"
        '
        'MantenimientoUsuariosToolStripMenuItem
        '
        Me.MantenimientoUsuariosToolStripMenuItem.Name = "MantenimientoUsuariosToolStripMenuItem"
        Me.MantenimientoUsuariosToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.MantenimientoUsuariosToolStripMenuItem.Text = "Mantenimiento Usuarios"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripButton2.Text = "Pantalla De Usuarios"
        '
        'DocumentosBindingNavigator
        '
        Me.DocumentosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DocumentosBindingNavigator.BindingSource = Me.DocumentosBindingSource
        Me.DocumentosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DocumentosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DocumentosBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DocumentosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.DocumentosBindingNavigatorSaveItem, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.DocumentosBindingNavigator.Location = New System.Drawing.Point(0, 249)
        Me.DocumentosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DocumentosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DocumentosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DocumentosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DocumentosBindingNavigator.Name = "DocumentosBindingNavigator"
        Me.DocumentosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DocumentosBindingNavigator.Size = New System.Drawing.Size(699, 25)
        Me.DocumentosBindingNavigator.TabIndex = 51
        Me.DocumentosBindingNavigator.Text = "BindingNavigator1"
        Me.DocumentosBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        Me.BindingNavigatorAddNewItem.Visible = False
        '
        'DocumentosBindingSource
        '
        Me.DocumentosBindingSource.DataMember = "Documentos"
        Me.DocumentosBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        Me.BindingNavigatorDeleteItem.Visible = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'DocumentosBindingNavigatorSaveItem
        '
        Me.DocumentosBindingNavigatorSaveItem.Image = CType(resources.GetObject("DocumentosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DocumentosBindingNavigatorSaveItem.Name = "DocumentosBindingNavigatorSaveItem"
        Me.DocumentosBindingNavigatorSaveItem.Size = New System.Drawing.Size(58, 22)
        Me.DocumentosBindingNavigatorSaveItem.Text = "Salvar"
        '
        'DocumentoIDTextBox
        '
        Me.DocumentoIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentosBindingSource, "DocumentoID", True))
        Me.DocumentoIDTextBox.Location = New System.Drawing.Point(108, 33)
        Me.DocumentoIDTextBox.Name = "DocumentoIDTextBox"
        Me.DocumentoIDTextBox.ReadOnly = True
        Me.DocumentoIDTextBox.Size = New System.Drawing.Size(69, 20)
        Me.DocumentoIDTextBox.TabIndex = 52
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentosBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(140, 114)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(272, 20)
        Me.NombreTextBox.TabIndex = 54
        '
        'Archivo_AdjuntoTextBox
        '
        Me.Archivo_AdjuntoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentosBindingSource, "Archivo_Adjunto", True))
        Me.Archivo_AdjuntoTextBox.Location = New System.Drawing.Point(108, 88)
        Me.Archivo_AdjuntoTextBox.Name = "Archivo_AdjuntoTextBox"
        Me.Archivo_AdjuntoTextBox.ReadOnly = True
        Me.Archivo_AdjuntoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Archivo_AdjuntoTextBox.TabIndex = 58
        '
        'AñoMaskedTextBox
        '
        Me.AñoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentosBindingSource, "Año", True))
        Me.AñoMaskedTextBox.Location = New System.Drawing.Point(108, 151)
        Me.AñoMaskedTextBox.Mask = "00/00/0000"
        Me.AñoMaskedTextBox.Name = "AñoMaskedTextBox"
        Me.AñoMaskedTextBox.Size = New System.Drawing.Size(79, 20)
        Me.AñoMaskedTextBox.TabIndex = 63
        Me.AñoMaskedTextBox.ValidatingType = GetType(Date)
        '
        'AlumnosBindingSource
        '
        Me.AlumnosBindingSource.DataMember = "Alumnos"
        Me.AlumnosBindingSource.DataSource = Me.DataSet1
        '
        'DocumentosTableAdapter
        '
        Me.DocumentosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AlumnosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DocumentosTableAdapter = Me.DocumentosTableAdapter
        Me.TableAdapterManager.EstadoTableAdapter = Nothing
        Me.TableAdapterManager.SolicitudesTableAdapter = Nothing
        Me.TableAdapterManager.Tipo_de_DocumentoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'AlumnosTableAdapter
        '
        Me.AlumnosTableAdapter.ClearBeforeFill = True
        '
        'TipoDeDocumentoBindingSource
        '
        Me.TipoDeDocumentoBindingSource.DataMember = "Tipo de Documento"
        Me.TipoDeDocumentoBindingSource.DataSource = Me.DataSet1
        '
        'Tipo_de_DocumentoTableAdapter
        '
        Me.Tipo_de_DocumentoTableAdapter.ClearBeforeFill = True
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DocumentosBindingSource, "AlumnoID", True))
        Me.ComboBox1.DataSource = Me.AlumnosBindingSource
        Me.ComboBox1.DisplayMember = "Nombre"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(108, 180)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox1.TabIndex = 64
        Me.ComboBox1.ValueMember = "AlumnoID"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DocumentosBindingSource, "TipoDocID", True))
        Me.ComboBox2.DataSource = Me.TipoDeDocumentoBindingSource
        Me.ComboBox2.DisplayMember = "TipoDocumento"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(108, 207)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox2.TabIndex = 65
        Me.ComboBox2.ValueMember = "TipoDocID"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(455, 197)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(113, 39)
        Me.Button4.TabIndex = 66
        Me.Button4.Text = "Salvar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 261)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(AñoLabel)
        Me.Controls.Add(Me.AñoMaskedTextBox)
        Me.Controls.Add(DocumentoIDLabel)
        Me.Controls.Add(Me.DocumentoIDTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Archivo_AdjuntoLabel)
        Me.Controls.Add(Me.Archivo_AdjuntoTextBox)
        Me.Controls.Add(AlumnoIDLabel)
        Me.Controls.Add(TipoDocIDLabel)
        Me.Controls.Add(Me.DocumentosBindingNavigator)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox5)
        Me.Name = "Form5"
        Me.Text = "Agregar Documento"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DocumentosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentosBindingNavigator.ResumeLayout(False)
        Me.DocumentosBindingNavigator.PerformLayout()
        CType(Me.DocumentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoDeDocumentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripDropDownButton
    Friend WithEvents AgregarDocumentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarDocumentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As ToolStripDropDownButton
    Friend WithEvents MantenimientoUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents DocumentosBindingSource As BindingSource
    Friend WithEvents DocumentosTableAdapter As DataSet1TableAdapters.DocumentosTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents DocumentosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents DocumentosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DocumentoIDTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents Archivo_AdjuntoTextBox As TextBox
    Friend WithEvents AñoMaskedTextBox As MaskedTextBox
    Friend WithEvents AlumnosBindingSource As BindingSource
    Friend WithEvents AlumnosTableAdapter As DataSet1TableAdapters.AlumnosTableAdapter
    Friend WithEvents TipoDeDocumentoBindingSource As BindingSource
    Friend WithEvents Tipo_de_DocumentoTableAdapter As DataSet1TableAdapters.Tipo_de_DocumentoTableAdapter
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
