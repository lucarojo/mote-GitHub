<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agregarcarreras
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CarreraIDLabel As System.Windows.Forms.Label
        Dim CarreraLabel As System.Windows.Forms.Label
        Dim TipoGradoIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(agregarcarreras))
        Me.DataSet1 = New WindowsApplication1.DataSet1()
        Me.CarrerasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CarrerasTableAdapter = New WindowsApplication1.DataSet1TableAdapters.CarrerasTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.DataSet1TableAdapters.TableAdapterManager()
        Me.Tipo_de_DocumentoTableAdapter = New WindowsApplication1.DataSet1TableAdapters.Tipo_de_DocumentoTableAdapter()
        Me.CarrerasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
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
        Me.CarrerasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CarreraIDTextBox = New System.Windows.Forms.TextBox()
        Me.CarreraTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TipoGradoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoDeDocumentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tipo_GradoTableAdapter = New WindowsApplication1.DataSet1TableAdapters.Tipo_GradoTableAdapter()
        CarreraIDLabel = New System.Windows.Forms.Label()
        CarreraLabel = New System.Windows.Forms.Label()
        TipoGradoIDLabel = New System.Windows.Forms.Label()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarrerasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarrerasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CarrerasBindingNavigator.SuspendLayout()
        CType(Me.TipoGradoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoDeDocumentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CarreraIDLabel
        '
        CarreraIDLabel.AutoSize = True
        CarreraIDLabel.Location = New System.Drawing.Point(48, 44)
        CarreraIDLabel.Name = "CarreraIDLabel"
        CarreraIDLabel.Size = New System.Drawing.Size(58, 13)
        CarreraIDLabel.TabIndex = 1
        CarreraIDLabel.Text = "Carrera ID:"
        '
        'CarreraLabel
        '
        CarreraLabel.AutoSize = True
        CarreraLabel.Location = New System.Drawing.Point(48, 70)
        CarreraLabel.Name = "CarreraLabel"
        CarreraLabel.Size = New System.Drawing.Size(99, 13)
        CarreraLabel.TabIndex = 3
        CarreraLabel.Text = "Nombre de Carrera:"
        '
        'TipoGradoIDLabel
        '
        TipoGradoIDLabel.AutoSize = True
        TipoGradoIDLabel.Location = New System.Drawing.Point(48, 96)
        TipoGradoIDLabel.Name = "TipoGradoIDLabel"
        TipoGradoIDLabel.Size = New System.Drawing.Size(63, 13)
        TipoGradoIDLabel.TabIndex = 5
        TipoGradoIDLabel.Text = "Tipo Grado:"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CarrerasBindingSource
        '
        Me.CarrerasBindingSource.DataMember = "Carreras"
        Me.CarrerasBindingSource.DataSource = Me.DataSet1
        '
        'CarrerasTableAdapter
        '
        Me.CarrerasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AlumnosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CarrerasTableAdapter = Me.CarrerasTableAdapter
        Me.TableAdapterManager.Detalle_CarrerasTableAdapter = Nothing
        Me.TableAdapterManager.Detalle_DocumentoTableAdapter = Nothing
        Me.TableAdapterManager.DocumentosTableAdapter = Nothing
        Me.TableAdapterManager.EstadoTableAdapter = Nothing
        Me.TableAdapterManager.ServerTableAdapter = Nothing
        Me.TableAdapterManager.SolicitudesTableAdapter = Nothing
        Me.TableAdapterManager.Tipo_de_DocumentoTableAdapter = Me.Tipo_de_DocumentoTableAdapter
        Me.TableAdapterManager.Tipo_GradoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'Tipo_de_DocumentoTableAdapter
        '
        Me.Tipo_de_DocumentoTableAdapter.ClearBeforeFill = True
        '
        'CarrerasBindingNavigator
        '
        Me.CarrerasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CarrerasBindingNavigator.BindingSource = Me.CarrerasBindingSource
        Me.CarrerasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CarrerasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CarrerasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CarrerasBindingNavigatorSaveItem})
        Me.CarrerasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CarrerasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CarrerasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CarrerasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CarrerasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CarrerasBindingNavigator.Name = "CarrerasBindingNavigator"
        Me.CarrerasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CarrerasBindingNavigator.Size = New System.Drawing.Size(473, 25)
        Me.CarrerasBindingNavigator.TabIndex = 0
        Me.CarrerasBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(107, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar Nuevo"
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
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(70, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
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
        'CarrerasBindingNavigatorSaveItem
        '
        Me.CarrerasBindingNavigatorSaveItem.Image = CType(resources.GetObject("CarrerasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CarrerasBindingNavigatorSaveItem.Name = "CarrerasBindingNavigatorSaveItem"
        Me.CarrerasBindingNavigatorSaveItem.Size = New System.Drawing.Size(58, 22)
        Me.CarrerasBindingNavigatorSaveItem.Text = "Salvar"
        '
        'CarreraIDTextBox
        '
        Me.CarreraIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarrerasBindingSource, "CarreraID", True))
        Me.CarreraIDTextBox.Location = New System.Drawing.Point(131, 41)
        Me.CarreraIDTextBox.Name = "CarreraIDTextBox"
        Me.CarreraIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CarreraIDTextBox.TabIndex = 2
        '
        'CarreraTextBox
        '
        Me.CarreraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarrerasBindingSource, "Carrera", True))
        Me.CarreraTextBox.Location = New System.Drawing.Point(153, 67)
        Me.CarreraTextBox.Name = "CarreraTextBox"
        Me.CarreraTextBox.Size = New System.Drawing.Size(222, 20)
        Me.CarreraTextBox.TabIndex = 4
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CarrerasBindingSource, "TipoGradoID", True))
        Me.ComboBox1.DataSource = Me.TipoGradoBindingSource
        Me.ComboBox1.DisplayMember = "TipoGrado"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(131, 93)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 6
        Me.ComboBox1.ValueMember = "TipoGradoID"
        '
        'TipoGradoBindingSource
        '
        Me.TipoGradoBindingSource.DataMember = "Tipo Grado"
        Me.TipoGradoBindingSource.DataSource = Me.DataSet1
        '
        'TipoDeDocumentoBindingSource
        '
        Me.TipoDeDocumentoBindingSource.DataMember = "Tipo de Documento"
        Me.TipoDeDocumentoBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1BindingSource
        '
        Me.DataSet1BindingSource.DataSource = Me.DataSet1
        Me.DataSet1BindingSource.Position = 0
        '
        'Tipo_GradoTableAdapter
        '
        Me.Tipo_GradoTableAdapter.ClearBeforeFill = True
        '
        'agregarcarreras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(473, 138)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(CarreraIDLabel)
        Me.Controls.Add(Me.CarreraIDTextBox)
        Me.Controls.Add(CarreraLabel)
        Me.Controls.Add(Me.CarreraTextBox)
        Me.Controls.Add(TipoGradoIDLabel)
        Me.Controls.Add(Me.CarrerasBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "agregarcarreras"
        Me.Text = "Mantenimiento de Carreras"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarrerasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarrerasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CarrerasBindingNavigator.ResumeLayout(False)
        Me.CarrerasBindingNavigator.PerformLayout()
        CType(Me.TipoGradoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoDeDocumentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents CarrerasBindingSource As BindingSource
    Friend WithEvents CarrerasTableAdapter As DataSet1TableAdapters.CarrerasTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents CarrerasBindingNavigator As BindingNavigator
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
    Friend WithEvents CarrerasBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Tipo_de_DocumentoTableAdapter As DataSet1TableAdapters.Tipo_de_DocumentoTableAdapter
    Friend WithEvents CarreraIDTextBox As TextBox
    Friend WithEvents CarreraTextBox As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TipoDeDocumentoBindingSource As BindingSource
    Friend WithEvents DataSet1BindingSource As BindingSource
    Friend WithEvents TipoGradoBindingSource As BindingSource
    Friend WithEvents Tipo_GradoTableAdapter As DataSet1TableAdapters.Tipo_GradoTableAdapter
End Class
