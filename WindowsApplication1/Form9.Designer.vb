<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form9))
        Me.colNombre_Solicitante = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumero_Cuenta_Solicitante = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataSet1 = New WindowsApplication1.DataSet1()
        Me.ProcedimientoReporteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProcedimientoReporteTableAdapter = New WindowsApplication1.DataSet1TableAdapters.ProcedimientoReporteTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.DataSet1TableAdapters.TableAdapterManager()
        Me.ProcedimientoReporteGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ProcedimientoReporteBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridViewReporte = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNombre_Solicitante1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumero_Cuenta_Solicitante1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha_Creacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProcedimientoReporteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProcedimientoReporteGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProcedimientoReporteBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colNombre_Solicitante
        '
        Me.colNombre_Solicitante.FieldName = "Nombre_Solicitante"
        Me.colNombre_Solicitante.Name = "colNombre_Solicitante"
        '
        'colNumero_Cuenta_Solicitante
        '
        Me.colNumero_Cuenta_Solicitante.FieldName = "Numero_Cuenta_Solicitante"
        Me.colNumero_Cuenta_Solicitante.Name = "colNumero_Cuenta_Solicitante"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProcedimientoReporteBindingSource
        '
        Me.ProcedimientoReporteBindingSource.DataMember = "ProcedimientoReporte"
        Me.ProcedimientoReporteBindingSource.DataSource = Me.DataSet1
        '
        'ProcedimientoReporteTableAdapter
        '
        Me.ProcedimientoReporteTableAdapter.ClearBeforeFill = True
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
        'ProcedimientoReporteGridControl
        '
        Me.ProcedimientoReporteGridControl.DataSource = Me.ProcedimientoReporteBindingSource1
        Me.ProcedimientoReporteGridControl.Location = New System.Drawing.Point(12, 120)
        Me.ProcedimientoReporteGridControl.MainView = Me.GridViewReporte
        Me.ProcedimientoReporteGridControl.Name = "ProcedimientoReporteGridControl"
        Me.ProcedimientoReporteGridControl.Size = New System.Drawing.Size(894, 220)
        Me.ProcedimientoReporteGridControl.TabIndex = 9
        Me.ProcedimientoReporteGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewReporte})
        '
        'ProcedimientoReporteBindingSource1
        '
        Me.ProcedimientoReporteBindingSource1.DataMember = "ProcedimientoReporte"
        Me.ProcedimientoReporteBindingSource1.DataSource = Me.DataSet1
        '
        'GridViewReporte
        '
        Me.GridViewReporte.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNombre_Solicitante1, Me.colNumero_Cuenta_Solicitante1, Me.colNombre, Me.colFecha_Creacion})
        Me.GridViewReporte.GridControl = Me.ProcedimientoReporteGridControl
        Me.GridViewReporte.Name = "GridViewReporte"
        Me.GridViewReporte.OptionsPrint.RtfPageHeader = resources.GetString("GridViewReporte.OptionsPrint.RtfPageHeader")
        '
        'colNombre_Solicitante1
        '
        Me.colNombre_Solicitante1.FieldName = "Nombre_Solicitante"
        Me.colNombre_Solicitante1.Name = "colNombre_Solicitante1"
        Me.colNombre_Solicitante1.Visible = True
        Me.colNombre_Solicitante1.VisibleIndex = 0
        '
        'colNumero_Cuenta_Solicitante1
        '
        Me.colNumero_Cuenta_Solicitante1.FieldName = "Numero_Cuenta_Solicitante"
        Me.colNumero_Cuenta_Solicitante1.Name = "colNumero_Cuenta_Solicitante1"
        Me.colNumero_Cuenta_Solicitante1.Visible = True
        Me.colNumero_Cuenta_Solicitante1.VisibleIndex = 1
        '
        'colNombre
        '
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 2
        '
        'colFecha_Creacion
        '
        Me.colFecha_Creacion.FieldName = "Fecha_Creacion"
        Me.colFecha_Creacion.Name = "colFecha_Creacion"
        Me.colFecha_Creacion.Visible = True
        Me.colFecha_Creacion.VisibleIndex = 3
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 26)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 10
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(258, 26)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(495, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(196, 37)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Generar Reporte"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Fecha Inicial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(255, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Fecha Final"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(721, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(160, 36)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Guardar Reporte"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 453)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ProcedimientoReporteGridControl)
        Me.Name = "Form9"
        Me.Text = "Generar Reporte"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProcedimientoReporteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProcedimientoReporteGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProcedimientoReporteBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewReporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents colNombre_Solicitante As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumero_Cuenta_Solicitante As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents ProcedimientoReporteBindingSource As BindingSource
    Friend WithEvents ProcedimientoReporteTableAdapter As DataSet1TableAdapters.ProcedimientoReporteTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents ProcedimientoReporteGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewReporte As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ProcedimientoReporteBindingSource1 As BindingSource
    Friend WithEvents colNombre_Solicitante1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumero_Cuenta_Solicitante1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha_Creacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
End Class
