<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListTax
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListTax))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.DataSetList = New MyTemplate.DataSetList()
        Me.ListTaxBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListTaxTableAdapter = New MyTemplate.DataSetListTableAdapters.ListTaxTableAdapter()
        Me.TableAdapterManager = New MyTemplate.DataSetListTableAdapters.TableAdapterManager()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkodePajak = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnamaPajak = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltarifPajak = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpenjId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpemId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisDeleted = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListTaxBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.ListTaxBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(12, 45)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1030, 429)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colkodePajak, Me.colnamaPajak, Me.coldescription, Me.coltarifPajak, Me.colpenjId, Me.colpemId, Me.colisDeleted})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 2)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(44, 37)
        Me.SimpleButton1.TabIndex = 4
        '
        'DataSetList
        '
        Me.DataSetList.DataSetName = "DataSetList"
        Me.DataSetList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListTaxBindingSource
        '
        Me.ListTaxBindingSource.DataMember = "ListTax"
        Me.ListTaxBindingSource.DataSource = Me.DataSetList
        '
        'ListTaxTableAdapter
        '
        Me.ListTaxTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = MyTemplate.DataSetListTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        Me.colid.Visible = True
        Me.colid.VisibleIndex = 0
        '
        'colkodePajak
        '
        Me.colkodePajak.FieldName = "kodePajak"
        Me.colkodePajak.Name = "colkodePajak"
        Me.colkodePajak.Visible = True
        Me.colkodePajak.VisibleIndex = 1
        '
        'colnamaPajak
        '
        Me.colnamaPajak.FieldName = "namaPajak"
        Me.colnamaPajak.Name = "colnamaPajak"
        Me.colnamaPajak.Visible = True
        Me.colnamaPajak.VisibleIndex = 2
        '
        'coldescription
        '
        Me.coldescription.FieldName = "description"
        Me.coldescription.Name = "coldescription"
        Me.coldescription.Visible = True
        Me.coldescription.VisibleIndex = 3
        '
        'coltarifPajak
        '
        Me.coltarifPajak.FieldName = "tarifPajak"
        Me.coltarifPajak.Name = "coltarifPajak"
        Me.coltarifPajak.Visible = True
        Me.coltarifPajak.VisibleIndex = 4
        '
        'colpenjId
        '
        Me.colpenjId.FieldName = "penjId"
        Me.colpenjId.Name = "colpenjId"
        Me.colpenjId.Visible = True
        Me.colpenjId.VisibleIndex = 5
        '
        'colpemId
        '
        Me.colpemId.FieldName = "pemId"
        Me.colpemId.Name = "colpemId"
        Me.colpemId.Visible = True
        Me.colpemId.VisibleIndex = 6
        '
        'colisDeleted
        '
        Me.colisDeleted.FieldName = "isDeleted"
        Me.colisDeleted.Name = "colisDeleted"
        Me.colisDeleted.Visible = True
        Me.colisDeleted.VisibleIndex = 7
        '
        'ListTax
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 486)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "ListTax"
        Me.Text = "ListTax"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListTaxBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataSetList As MyTemplate.DataSetList
    Friend WithEvents ListTaxBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListTaxTableAdapter As MyTemplate.DataSetListTableAdapters.ListTaxTableAdapter
    Friend WithEvents TableAdapterManager As MyTemplate.DataSetListTableAdapters.TableAdapterManager
    Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkodePajak As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnamaPajak As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltarifPajak As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpenjId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisDeleted As DevExpress.XtraGrid.Columns.GridColumn
End Class
