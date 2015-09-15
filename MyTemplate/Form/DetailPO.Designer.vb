<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailPO
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
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.PODetailDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetPO = New MyTemplate.DataSetPO()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDHeader = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDItem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lookUpEditItem = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SelectItemPODetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDTax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lookUpEditTax = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SelectTaxDataTableBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDProject = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lookUpEditProject = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SelectProjectDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colClose = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SelectTaxDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.SelectHeaderPODetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.SelectHeaderPO_DetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PODetailtableAdapter = New MyTemplate.DataSetPOTableAdapters.PODetailtableAdapter()
        Me.TableAdapterManagerPoDetail = New MyTemplate.DataSetPOTableAdapters.TableAdapterManager()
        Me.SelectHeaderPO_DetailTableAdapter = New MyTemplate.DataSetPOTableAdapters.SelectHeaderPO_DetailTableAdapter()
        Me.SelectItemPODetailTableAdapter = New MyTemplate.DataSetPOTableAdapters.SelectItemPODetailTableAdapter()
        Me.SelectTaxTableAdapter = New MyTemplate.DataSetPOTableAdapters.SelectTaxTableAdapter()
        Me.SelectProjectTableAdapter = New MyTemplate.DataSetPOTableAdapters.SelectProjectTableAdapter()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PODetailDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookUpEditItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectItemPODetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookUpEditTax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectTaxDataTableBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookUpEditProject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectProjectDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectTaxDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.SelectHeaderPODetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectHeaderPO_DetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(3, 167)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(711, 216)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "List Of Detail PO"
        '
        'GridControl1
        '
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.DataSource = Me.PODetailDataTableBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 21)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lookUpEditItem, Me.lookUpEditTax, Me.lookUpEditProject})
        Me.GridControl1.Size = New System.Drawing.Size(707, 193)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'PODetailDataTableBindingSource
        '
        Me.PODetailDataTableBindingSource.DataMember = "PODetailDataTable"
        Me.PODetailDataTableBindingSource.DataSource = Me.DataSetPO
        '
        'DataSetPO
        '
        Me.DataSetPO.DataSetName = "DataSetPO"
        Me.DataSetPO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIDHeader, Me.colIDItem, Me.colQty, Me.colIDTax, Me.colUnitPrice, Me.colIDProject, Me.colClose})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.ReadOnly = True
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 0
        '
        'colIDHeader
        '
        Me.colIDHeader.FieldName = "IDHeader"
        Me.colIDHeader.Name = "colIDHeader"
        Me.colIDHeader.Visible = True
        Me.colIDHeader.VisibleIndex = 1
        '
        'colIDItem
        '
        Me.colIDItem.ColumnEdit = Me.lookUpEditItem
        Me.colIDItem.FieldName = "IDItem"
        Me.colIDItem.Name = "colIDItem"
        Me.colIDItem.Visible = True
        Me.colIDItem.VisibleIndex = 2
        '
        'lookUpEditItem
        '
        Me.lookUpEditItem.AutoHeight = False
        Me.lookUpEditItem.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookUpEditItem.DataSource = Me.SelectItemPODetailBindingSource
        Me.lookUpEditItem.DisplayMember = "namaItem"
        Me.lookUpEditItem.Name = "lookUpEditItem"
        Me.lookUpEditItem.ValueMember = "id"
        '
        'SelectItemPODetailBindingSource
        '
        Me.SelectItemPODetailBindingSource.DataMember = "SelectItemPODetail"
        Me.SelectItemPODetailBindingSource.DataSource = Me.DataSetPO
        '
        'colQty
        '
        Me.colQty.FieldName = "Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.Visible = True
        Me.colQty.VisibleIndex = 3
        '
        'colIDTax
        '
        Me.colIDTax.ColumnEdit = Me.lookUpEditTax
        Me.colIDTax.FieldName = "IDTax"
        Me.colIDTax.Name = "colIDTax"
        Me.colIDTax.Visible = True
        Me.colIDTax.VisibleIndex = 4
        '
        'lookUpEditTax
        '
        Me.lookUpEditTax.AutoHeight = False
        Me.lookUpEditTax.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookUpEditTax.DataSource = Me.SelectTaxDataTableBindingSource1
        Me.lookUpEditTax.DisplayMember = "namaPajak"
        Me.lookUpEditTax.Name = "lookUpEditTax"
        Me.lookUpEditTax.ValueMember = "id"
        '
        'SelectTaxDataTableBindingSource1
        '
        Me.SelectTaxDataTableBindingSource1.DataMember = "SelectTaxDataTable"
        Me.SelectTaxDataTableBindingSource1.DataSource = Me.DataSetPO
        '
        'colUnitPrice
        '
        Me.colUnitPrice.FieldName = "UnitPrice"
        Me.colUnitPrice.Name = "colUnitPrice"
        Me.colUnitPrice.Visible = True
        Me.colUnitPrice.VisibleIndex = 5
        '
        'colIDProject
        '
        Me.colIDProject.ColumnEdit = Me.lookUpEditProject
        Me.colIDProject.FieldName = "IDProject"
        Me.colIDProject.Name = "colIDProject"
        Me.colIDProject.Visible = True
        Me.colIDProject.VisibleIndex = 6
        '
        'lookUpEditProject
        '
        Me.lookUpEditProject.AutoHeight = False
        Me.lookUpEditProject.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookUpEditProject.DataSource = Me.SelectProjectDataTableBindingSource
        Me.lookUpEditProject.DisplayMember = "projectName"
        Me.lookUpEditProject.Name = "lookUpEditProject"
        Me.lookUpEditProject.ValueMember = "id"
        '
        'SelectProjectDataTableBindingSource
        '
        Me.SelectProjectDataTableBindingSource.DataMember = "SelectProjectDataTable"
        Me.SelectProjectDataTableBindingSource.DataSource = Me.DataSetPO
        '
        'colClose
        '
        Me.colClose.FieldName = "Close"
        Me.colClose.Name = "colClose"
        Me.colClose.Visible = True
        Me.colClose.VisibleIndex = 7
        '
        'SelectTaxDataTableBindingSource
        '
        Me.SelectTaxDataTableBindingSource.DataMember = "SelectTaxDataTable"
        Me.SelectTaxDataTableBindingSource.DataSource = Me.DataSetPO
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.LabelControl6)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        Me.GroupControl2.Controls.Add(Me.LabelControl4)
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Controls.Add(Me.LabelControl2)
        Me.GroupControl2.Controls.Add(Me.LabelControl1)
        Me.GroupControl2.Location = New System.Drawing.Point(3, 3)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(711, 76)
        Me.GroupControl2.TabIndex = 3
        Me.GroupControl2.Text = "Edited Purchase Order"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectHeaderPODetailBindingSource, "tglPO", True))
        Me.LabelControl6.Location = New System.Drawing.Point(591, 35)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(72, 17)
        Me.LabelControl6.TabIndex = 13
        Me.LabelControl6.Text = "Issued Date:"
        '
        'SelectHeaderPODetailBindingSource
        '
        Me.SelectHeaderPODetailBindingSource.DataMember = "SelectHeaderPO_Detail"
        Me.SelectHeaderPODetailBindingSource.DataSource = Me.DataSetPO
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectHeaderPO_DetailBindingSource, "nama", True))
        Me.LabelControl5.Location = New System.Drawing.Point(313, 35)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(84, 17)
        Me.LabelControl5.TabIndex = 12
        Me.LabelControl5.Text = "Vendor Name:"
        '
        'SelectHeaderPO_DetailBindingSource
        '
        Me.SelectHeaderPO_DetailBindingSource.DataMember = "SelectHeaderPO_Detail"
        Me.SelectHeaderPO_DetailBindingSource.DataSource = Me.DataSetPO
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectHeaderPODetailBindingSource, "NoPO", True))
        Me.LabelControl4.Location = New System.Drawing.Point(93, 35)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(73, 17)
        Me.LabelControl4.TabIndex = 11
        Me.LabelControl4.Text = "PO Number:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(513, 35)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(72, 17)
        Me.LabelControl3.TabIndex = 10
        Me.LabelControl3.Text = "Issued Date:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(223, 35)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(84, 17)
        Me.LabelControl2.TabIndex = 9
        Me.LabelControl2.Text = "Vendor Name:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(14, 35)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(73, 17)
        Me.LabelControl1.TabIndex = 8
        Me.LabelControl1.Text = "PO Number:"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.SimpleButton3)
        Me.GroupControl3.Controls.Add(Me.SimpleButton2)
        Me.GroupControl3.Controls.Add(Me.SimpleButton1)
        Me.GroupControl3.Location = New System.Drawing.Point(3, 85)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(711, 76)
        Me.GroupControl3.TabIndex = 4
        Me.GroupControl3.Text = "Command Center"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Location = New System.Drawing.Point(176, 38)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton3.TabIndex = 2
        Me.SimpleButton3.Text = "Delete"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(95, 38)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton2.TabIndex = 1
        Me.SimpleButton2.Text = "Save"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(14, 38)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "Add Detail"
        '
        'PODetailtableAdapter
        '
        Me.PODetailtableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManagerPoDetail
        '
        Me.TableAdapterManagerPoDetail.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManagerPoDetail.PODetailtableAdapter = Me.PODetailtableAdapter
        Me.TableAdapterManagerPoDetail.UpdateOrder = MyTemplate.DataSetPOTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SelectHeaderPO_DetailTableAdapter
        '
        Me.SelectHeaderPO_DetailTableAdapter.ClearBeforeFill = True
        '
        'SelectItemPODetailTableAdapter
        '
        Me.SelectItemPODetailTableAdapter.ClearBeforeFill = True
        '
        'SelectTaxTableAdapter
        '
        Me.SelectTaxTableAdapter.ClearBeforeFill = True
        '
        'SelectProjectTableAdapter
        '
        Me.SelectProjectTableAdapter.ClearBeforeFill = True
        '
        'DetailPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 385)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "DetailPO"
        Me.Text = "Detail PO"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PODetailDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookUpEditItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectItemPODetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookUpEditTax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectTaxDataTableBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookUpEditProject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectProjectDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectTaxDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.SelectHeaderPODetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectHeaderPO_DetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DataSetPO As MyTemplate.DataSetPO
    Friend WithEvents PODetailDataTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PODetailtableAdapter As MyTemplate.DataSetPOTableAdapters.PODetailtableAdapter
    Friend WithEvents TableAdapterManagerPoDetail As MyTemplate.DataSetPOTableAdapters.TableAdapterManager
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDHeader As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDItem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDTax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDProject As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClose As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SelectHeaderPO_DetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelectHeaderPO_DetailTableAdapter As MyTemplate.DataSetPOTableAdapters.SelectHeaderPO_DetailTableAdapter
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SelectHeaderPODetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lookUpEditItem As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SelectItemPODetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelectItemPODetailTableAdapter As MyTemplate.DataSetPOTableAdapters.SelectItemPODetailTableAdapter
    Friend WithEvents lookUpEditTax As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SelectTaxDataTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelectTaxTableAdapter As MyTemplate.DataSetPOTableAdapters.SelectTaxTableAdapter
    Friend WithEvents SelectTaxDataTableBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents lookUpEditProject As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SelectProjectDataTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelectProjectTableAdapter As MyTemplate.DataSetPOTableAdapters.SelectProjectTableAdapter
End Class
