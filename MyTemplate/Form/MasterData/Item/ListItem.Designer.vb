<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListItem))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ListItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetList = New MyTemplate.DataSetList()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnamatype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnamaHeader = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkodeItem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnamaItem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ListItemTableAdapter = New MyTemplate.DataSetListTableAdapters.ListItemTableAdapter()
        Me.TableAdapterManager = New MyTemplate.DataSetListTableAdapters.TableAdapterManager()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.ListItemBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(-2, 48)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1032, 392)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ListItemBindingSource
        '
        Me.ListItemBindingSource.DataMember = "ListItem"
        Me.ListItemBindingSource.DataSource = Me.DataSetList
        '
        'DataSetList
        '
        Me.DataSetList.DataSetName = "DataSetList"
        Me.DataSetList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnamatype, Me.colnamaHeader, Me.colkodeItem, Me.colnamaItem, Me.colstatus, Me.colQty, Me.colUnit, Me.colCost, Me.colTotal})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.FindDelay = 100
        '
        'colnamatype
        '
        Me.colnamatype.FieldName = "namatype"
        Me.colnamatype.Name = "colnamatype"
        Me.colnamatype.Visible = True
        Me.colnamatype.VisibleIndex = 0
        '
        'colnamaHeader
        '
        Me.colnamaHeader.FieldName = "namaHeader"
        Me.colnamaHeader.Name = "colnamaHeader"
        Me.colnamaHeader.Visible = True
        Me.colnamaHeader.VisibleIndex = 1
        '
        'colkodeItem
        '
        Me.colkodeItem.FieldName = "kodeItem"
        Me.colkodeItem.Name = "colkodeItem"
        Me.colkodeItem.Visible = True
        Me.colkodeItem.VisibleIndex = 2
        '
        'colnamaItem
        '
        Me.colnamaItem.FieldName = "namaItem"
        Me.colnamaItem.Name = "colnamaItem"
        Me.colnamaItem.Visible = True
        Me.colnamaItem.VisibleIndex = 3
        '
        'colstatus
        '
        Me.colstatus.FieldName = "status"
        Me.colstatus.Name = "colstatus"
        Me.colstatus.Visible = True
        Me.colstatus.VisibleIndex = 4
        '
        'colQty
        '
        Me.colQty.FieldName = "Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.Visible = True
        Me.colQty.VisibleIndex = 5
        '
        'colUnit
        '
        Me.colUnit.FieldName = "Unit"
        Me.colUnit.Name = "colUnit"
        Me.colUnit.Visible = True
        Me.colUnit.VisibleIndex = 6
        '
        'colCost
        '
        Me.colCost.FieldName = "Cost"
        Me.colCost.Name = "colCost"
        Me.colCost.Visible = True
        Me.colCost.VisibleIndex = 7
        '
        'colTotal
        '
        Me.colTotal.FieldName = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.Visible = True
        Me.colTotal.VisibleIndex = 8
        '
        'ListItemTableAdapter
        '
        Me.ListItemTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = MyTemplate.DataSetListTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(47, 38)
        Me.SimpleButton1.TabIndex = 1
        '
        'ListItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 452)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "ListItem"
        Me.Text = "ListItem"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DataSetList As MyTemplate.DataSetList
    Friend WithEvents ListItemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListItemTableAdapter As MyTemplate.DataSetListTableAdapters.ListItemTableAdapter
    Friend WithEvents TableAdapterManager As MyTemplate.DataSetListTableAdapters.TableAdapterManager
    Friend WithEvents colnamatype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnamaHeader As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkodeItem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnamaItem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
