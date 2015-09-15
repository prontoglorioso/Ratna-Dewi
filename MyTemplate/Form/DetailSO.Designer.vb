<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailSO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetailSO))
        Me.DataSetSPPK = New MyTemplate.DataSetSPPK()
        Me.SODetail_SelectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SODetail_SelectTableAdapter = New MyTemplate.DataSetSPPKTableAdapters.SODetail_SelectTableAdapter()
        Me.TableAdapterManager = New MyTemplate.DataSetSPPKTableAdapters.TableAdapterManager()
        Me.SODetail_SelectBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.SODetail_SelectBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SODetail_SelectGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDHeader = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LookUpEditHeaderSO = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SelectHeaderSOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colIDItem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LookUpEditItem = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SelectItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDTax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LookUpEditTax = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SelectTaxBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colunitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDProject = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LookUpEditProject = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SelectProjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colClose = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SelectHeader_SOTableAdapter = New MyTemplate.DataSetSPPKTableAdapters.SelectHeader_SOTableAdapter()
        Me.SelectItemTableAdapter = New MyTemplate.DataSetSPPKTableAdapters.SelectItemTableAdapter()
        Me.SelectTaxTableAdapter = New MyTemplate.DataSetSPPKTableAdapters.SelectTaxTableAdapter()
        Me.SelectProjectTableAdapter = New MyTemplate.DataSetSPPKTableAdapters.SelectProjectTableAdapter()
        CType(Me.DataSetSPPK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SODetail_SelectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SODetail_SelectBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SODetail_SelectBindingNavigator.SuspendLayout()
        CType(Me.SODetail_SelectGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditHeaderSO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectHeaderSOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditTax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectTaxBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditProject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectProjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetSPPK
        '
        Me.DataSetSPPK.DataSetName = "DataSetSPPK"
        Me.DataSetSPPK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SODetail_SelectBindingSource
        '
        Me.SODetail_SelectBindingSource.DataMember = "SODetail_Select"
        Me.SODetail_SelectBindingSource.DataSource = Me.DataSetSPPK
        '
        'SODetail_SelectTableAdapter
        '
        Me.SODetail_SelectTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DepositDetail_SelectTableAdapter = Nothing
        Me.TableAdapterManager.DODetail_SelectTableAdapter = Nothing
        Me.TableAdapterManager.DOHeader_SelectTableAdapter = Nothing
        Me.TableAdapterManager.JVDetail_SelectTableAdapter = Nothing
        Me.TableAdapterManager.JVHeader_SelectTableAdapter = Nothing
        Me.TableAdapterManager.PaymentDetail_SelectTableAdapter = Nothing
        Me.TableAdapterManager.PIDetail_SelectTableAdapter = Nothing
        Me.TableAdapterManager.PIHeader_SelectTableAdapter = Nothing
        Me.TableAdapterManager.PODetail_SelectTableAdapter = Nothing
        Me.TableAdapterManager.POHeader_SelectTableAdapter = Nothing
        Me.TableAdapterManager.PPDetail_SelectTableAdapter = Nothing
        Me.TableAdapterManager.PPHeader_SelectTableAdapter = Nothing
        Me.TableAdapterManager.RIDetail_SelectTableAdapter = Nothing
        Me.TableAdapterManager.RIHeader_SelectTableAdapter = Nothing
        Me.TableAdapterManager.SIDetail_SelectTableAdapter = Nothing
        Me.TableAdapterManager.SIHeader_SelectTableAdapter = Nothing
        Me.TableAdapterManager.SODetail_SelectTableAdapter = Me.SODetail_SelectTableAdapter
        Me.TableAdapterManager.SOHeader_SelectTableAdapter = Nothing
        Me.TableAdapterManager.SRDetail_SelectTableAdapter = Nothing
        Me.TableAdapterManager.SRHeader_SelectTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MyTemplate.DataSetSPPKTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SODetail_SelectBindingNavigator
        '
        Me.SODetail_SelectBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SODetail_SelectBindingNavigator.BindingSource = Me.SODetail_SelectBindingSource
        Me.SODetail_SelectBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SODetail_SelectBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SODetail_SelectBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SODetail_SelectBindingNavigatorSaveItem})
        Me.SODetail_SelectBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SODetail_SelectBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SODetail_SelectBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SODetail_SelectBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SODetail_SelectBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SODetail_SelectBindingNavigator.Name = "SODetail_SelectBindingNavigator"
        Me.SODetail_SelectBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SODetail_SelectBindingNavigator.Size = New System.Drawing.Size(666, 25)
        Me.SODetail_SelectBindingNavigator.TabIndex = 0
        Me.SODetail_SelectBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
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
        'SODetail_SelectBindingNavigatorSaveItem
        '
        Me.SODetail_SelectBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SODetail_SelectBindingNavigatorSaveItem.Image = CType(resources.GetObject("SODetail_SelectBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SODetail_SelectBindingNavigatorSaveItem.Name = "SODetail_SelectBindingNavigatorSaveItem"
        Me.SODetail_SelectBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SODetail_SelectBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SODetail_SelectGridControl
        '
        Me.SODetail_SelectGridControl.Cursor = System.Windows.Forms.Cursors.Default
        Me.SODetail_SelectGridControl.DataSource = Me.SODetail_SelectBindingSource
        Me.SODetail_SelectGridControl.Location = New System.Drawing.Point(0, 28)
        Me.SODetail_SelectGridControl.MainView = Me.GridView1
        Me.SODetail_SelectGridControl.Name = "SODetail_SelectGridControl"
        Me.SODetail_SelectGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LookUpEditHeaderSO, Me.LookUpEditItem, Me.LookUpEditTax, Me.LookUpEditProject})
        Me.SODetail_SelectGridControl.Size = New System.Drawing.Size(666, 363)
        Me.SODetail_SelectGridControl.TabIndex = 1
        Me.SODetail_SelectGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIDHeader, Me.colIDItem, Me.colQty, Me.colIDTax, Me.colunitPrice, Me.colIDProject, Me.colClose})
        Me.GridView1.GridControl = Me.SODetail_SelectGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 0
        '
        'colIDHeader
        '
        Me.colIDHeader.Caption = "SO No."
        Me.colIDHeader.ColumnEdit = Me.LookUpEditHeaderSO
        Me.colIDHeader.FieldName = "IDHeader"
        Me.colIDHeader.Name = "colIDHeader"
        Me.colIDHeader.Visible = True
        Me.colIDHeader.VisibleIndex = 1
        '
        'LookUpEditHeaderSO
        '
        Me.LookUpEditHeaderSO.AutoHeight = False
        Me.LookUpEditHeaderSO.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditHeaderSO.DataSource = Me.SelectHeaderSOBindingSource
        Me.LookUpEditHeaderSO.DisplayMember = "NoSO"
        Me.LookUpEditHeaderSO.Name = "LookUpEditHeaderSO"
        Me.LookUpEditHeaderSO.ValueMember = "ID"
        '
        'SelectHeaderSOBindingSource
        '
        Me.SelectHeaderSOBindingSource.DataMember = "SelectHeader_SO"
        Me.SelectHeaderSOBindingSource.DataSource = Me.DataSetSPPK
        '
        'colIDItem
        '
        Me.colIDItem.Caption = "Item Name"
        Me.colIDItem.ColumnEdit = Me.LookUpEditItem
        Me.colIDItem.FieldName = "IDItem"
        Me.colIDItem.Name = "colIDItem"
        Me.colIDItem.Visible = True
        Me.colIDItem.VisibleIndex = 2
        '
        'LookUpEditItem
        '
        Me.LookUpEditItem.AutoHeight = False
        Me.LookUpEditItem.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditItem.DataSource = Me.SelectItemBindingSource
        Me.LookUpEditItem.DisplayMember = "namaItem"
        Me.LookUpEditItem.Name = "LookUpEditItem"
        Me.LookUpEditItem.ValueMember = "id"
        '
        'SelectItemBindingSource
        '
        Me.SelectItemBindingSource.DataMember = "SelectItem"
        Me.SelectItemBindingSource.DataSource = Me.DataSetSPPK
        '
        'colQty
        '
        Me.colQty.Caption = "Qty"
        Me.colQty.FieldName = "Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.Visible = True
        Me.colQty.VisibleIndex = 3
        '
        'colIDTax
        '
        Me.colIDTax.Caption = "Tax"
        Me.colIDTax.ColumnEdit = Me.LookUpEditTax
        Me.colIDTax.FieldName = "IDTax"
        Me.colIDTax.Name = "colIDTax"
        Me.colIDTax.Visible = True
        Me.colIDTax.VisibleIndex = 4
        '
        'LookUpEditTax
        '
        Me.LookUpEditTax.AutoHeight = False
        Me.LookUpEditTax.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditTax.DataSource = Me.SelectTaxBindingSource
        Me.LookUpEditTax.DisplayMember = "namaPajak"
        Me.LookUpEditTax.Name = "LookUpEditTax"
        Me.LookUpEditTax.ValueMember = "id"
        '
        'SelectTaxBindingSource
        '
        Me.SelectTaxBindingSource.DataMember = "SelectTax"
        Me.SelectTaxBindingSource.DataSource = Me.DataSetSPPK
        '
        'colunitPrice
        '
        Me.colunitPrice.Caption = "Unit Price"
        Me.colunitPrice.FieldName = "unitPrice"
        Me.colunitPrice.Name = "colunitPrice"
        Me.colunitPrice.Visible = True
        Me.colunitPrice.VisibleIndex = 5
        '
        'colIDProject
        '
        Me.colIDProject.Caption = "Project"
        Me.colIDProject.ColumnEdit = Me.LookUpEditProject
        Me.colIDProject.FieldName = "IDProject"
        Me.colIDProject.Name = "colIDProject"
        Me.colIDProject.Visible = True
        Me.colIDProject.VisibleIndex = 6
        '
        'LookUpEditProject
        '
        Me.LookUpEditProject.AutoHeight = False
        Me.LookUpEditProject.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditProject.DataSource = Me.SelectProjectBindingSource
        Me.LookUpEditProject.DisplayMember = "projectName"
        Me.LookUpEditProject.Name = "LookUpEditProject"
        Me.LookUpEditProject.ValueMember = "id"
        '
        'SelectProjectBindingSource
        '
        Me.SelectProjectBindingSource.DataMember = "SelectProject"
        Me.SelectProjectBindingSource.DataSource = Me.DataSetSPPK
        '
        'colClose
        '
        Me.colClose.Caption = "Close"
        Me.colClose.FieldName = "Close"
        Me.colClose.Name = "colClose"
        Me.colClose.Visible = True
        Me.colClose.VisibleIndex = 7
        '
        'SelectHeader_SOTableAdapter
        '
        Me.SelectHeader_SOTableAdapter.ClearBeforeFill = True
        '
        'SelectItemTableAdapter
        '
        Me.SelectItemTableAdapter.ClearBeforeFill = True
        '
        'SelectTaxTableAdapter
        '
        Me.SelectTaxTableAdapter.ClearBeforeFill = True
        '
        'SelectProjectTableAdapter
        '
        Me.SelectProjectTableAdapter.ClearBeforeFill = True
        '
        'DetailSO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 403)
        Me.Controls.Add(Me.SODetail_SelectGridControl)
        Me.Controls.Add(Me.SODetail_SelectBindingNavigator)
        Me.Name = "DetailSO"
        Me.Text = "DetailSO"
        CType(Me.DataSetSPPK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SODetail_SelectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SODetail_SelectBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SODetail_SelectBindingNavigator.ResumeLayout(False)
        Me.SODetail_SelectBindingNavigator.PerformLayout()
        CType(Me.SODetail_SelectGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditHeaderSO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectHeaderSOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditTax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectTaxBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditProject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectProjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSetSPPK As MyTemplate.DataSetSPPK
    Friend WithEvents SODetail_SelectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SODetail_SelectTableAdapter As MyTemplate.DataSetSPPKTableAdapters.SODetail_SelectTableAdapter
    Friend WithEvents TableAdapterManager As MyTemplate.DataSetSPPKTableAdapters.TableAdapterManager
    Friend WithEvents SODetail_SelectBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SODetail_SelectBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SODetail_SelectGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDHeader As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookUpEditHeaderSO As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colIDItem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDTax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colunitPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDProject As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClose As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SelectHeaderSOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelectHeader_SOTableAdapter As MyTemplate.DataSetSPPKTableAdapters.SelectHeader_SOTableAdapter
    Friend WithEvents LookUpEditItem As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SelectItemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelectItemTableAdapter As MyTemplate.DataSetSPPKTableAdapters.SelectItemTableAdapter
    Friend WithEvents LookUpEditTax As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SelectTaxBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelectTaxTableAdapter As MyTemplate.DataSetSPPKTableAdapters.SelectTaxTableAdapter
    Friend WithEvents LookUpEditProject As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SelectProjectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelectProjectTableAdapter As MyTemplate.DataSetSPPKTableAdapters.SelectProjectTableAdapter
End Class
