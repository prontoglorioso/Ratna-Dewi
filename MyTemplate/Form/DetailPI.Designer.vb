<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailPI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetailPI))
        Me.DataSetSPPK = New MyTemplate.DataSetSPPK()
        Me.PIDetail_SelectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PIDetail_SelectTableAdapter = New MyTemplate.DataSetSPPKTableAdapters.PIDetail_SelectTableAdapter()
        Me.TableAdapterManager = New MyTemplate.DataSetSPPKTableAdapters.TableAdapterManager()
        Me.PIDetail_SelectBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.PIDetail_SelectBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PIDetail_SelectGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDHeaderPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDHeaderRI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDDetailRI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDTax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LookUpEditHeaderPO = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SelectHeaderPOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SelectHeader_POTableAdapter = New MyTemplate.DataSetSPPKTableAdapters.SelectHeader_POTableAdapter()
        CType(Me.DataSetSPPK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIDetail_SelectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIDetail_SelectBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PIDetail_SelectBindingNavigator.SuspendLayout()
        CType(Me.PIDetail_SelectGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditHeaderPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectHeaderPOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetSPPK
        '
        Me.DataSetSPPK.DataSetName = "DataSetSPPK"
        Me.DataSetSPPK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PIDetail_SelectBindingSource
        '
        Me.PIDetail_SelectBindingSource.DataMember = "PIDetail_Select"
        Me.PIDetail_SelectBindingSource.DataSource = Me.DataSetSPPK
        '
        'PIDetail_SelectTableAdapter
        '
        Me.PIDetail_SelectTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.PIDetail_SelectTableAdapter = Me.PIDetail_SelectTableAdapter
        Me.TableAdapterManager.PIHeader_SelectTableAdapter = Nothing
        Me.TableAdapterManager.PODetail_SelectTableAdapter = Nothing
        Me.TableAdapterManager.POHeader_SelectTableAdapter = Nothing
        Me.TableAdapterManager.PPDetail_SelectTableAdapter = Nothing
        Me.TableAdapterManager.PPHeader_SelectTableAdapter = Nothing
        Me.TableAdapterManager.RIDetail_SelectTableAdapter = Nothing
        Me.TableAdapterManager.RIHeader_SelectTableAdapter = Nothing
        Me.TableAdapterManager.SIDetail_SelectTableAdapter = Nothing
        Me.TableAdapterManager.SIHeader_SelectTableAdapter = Nothing
        Me.TableAdapterManager.SODetail_SelectTableAdapter = Nothing
        Me.TableAdapterManager.SOHeader_SelectTableAdapter = Nothing
        Me.TableAdapterManager.SRDetail_SelectTableAdapter = Nothing
        Me.TableAdapterManager.SRHeader_SelectTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MyTemplate.DataSetSPPKTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PIDetail_SelectBindingNavigator
        '
        Me.PIDetail_SelectBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PIDetail_SelectBindingNavigator.BindingSource = Me.PIDetail_SelectBindingSource
        Me.PIDetail_SelectBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PIDetail_SelectBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PIDetail_SelectBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PIDetail_SelectBindingNavigatorSaveItem})
        Me.PIDetail_SelectBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PIDetail_SelectBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PIDetail_SelectBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PIDetail_SelectBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PIDetail_SelectBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PIDetail_SelectBindingNavigator.Name = "PIDetail_SelectBindingNavigator"
        Me.PIDetail_SelectBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PIDetail_SelectBindingNavigator.Size = New System.Drawing.Size(596, 25)
        Me.PIDetail_SelectBindingNavigator.TabIndex = 0
        Me.PIDetail_SelectBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'PIDetail_SelectBindingNavigatorSaveItem
        '
        Me.PIDetail_SelectBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PIDetail_SelectBindingNavigatorSaveItem.Image = CType(resources.GetObject("PIDetail_SelectBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PIDetail_SelectBindingNavigatorSaveItem.Name = "PIDetail_SelectBindingNavigatorSaveItem"
        Me.PIDetail_SelectBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PIDetail_SelectBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PIDetail_SelectGridControl
        '
        Me.PIDetail_SelectGridControl.Cursor = System.Windows.Forms.Cursors.Default
        Me.PIDetail_SelectGridControl.DataSource = Me.PIDetail_SelectBindingSource
        Me.PIDetail_SelectGridControl.Location = New System.Drawing.Point(0, 28)
        Me.PIDetail_SelectGridControl.MainView = Me.GridView1
        Me.PIDetail_SelectGridControl.Name = "PIDetail_SelectGridControl"
        Me.PIDetail_SelectGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LookUpEditHeaderPO})
        Me.PIDetail_SelectGridControl.Size = New System.Drawing.Size(596, 365)
        Me.PIDetail_SelectGridControl.TabIndex = 1
        Me.PIDetail_SelectGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIDHeaderPO, Me.colIDHeaderRI, Me.colIDDetailRI, Me.colIDTax})
        Me.GridView1.GridControl = Me.PIDetail_SelectGridControl
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
        'colIDHeaderPO
        '
        Me.colIDHeaderPO.ColumnEdit = Me.LookUpEditHeaderPO
        Me.colIDHeaderPO.FieldName = "IDHeaderPO"
        Me.colIDHeaderPO.Name = "colIDHeaderPO"
        Me.colIDHeaderPO.Visible = True
        Me.colIDHeaderPO.VisibleIndex = 1
        '
        'colIDHeaderRI
        '
        Me.colIDHeaderRI.FieldName = "IDHeaderRI"
        Me.colIDHeaderRI.Name = "colIDHeaderRI"
        Me.colIDHeaderRI.Visible = True
        Me.colIDHeaderRI.VisibleIndex = 2
        '
        'colIDDetailRI
        '
        Me.colIDDetailRI.FieldName = "IDDetailRI"
        Me.colIDDetailRI.Name = "colIDDetailRI"
        Me.colIDDetailRI.Visible = True
        Me.colIDDetailRI.VisibleIndex = 3
        '
        'colIDTax
        '
        Me.colIDTax.FieldName = "IDTax"
        Me.colIDTax.Name = "colIDTax"
        Me.colIDTax.Visible = True
        Me.colIDTax.VisibleIndex = 4
        '
        'LookUpEditHeaderPO
        '
        Me.LookUpEditHeaderPO.AutoHeight = False
        Me.LookUpEditHeaderPO.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditHeaderPO.DataSource = Me.SelectHeaderPOBindingSource
        Me.LookUpEditHeaderPO.DisplayMember = "NoPO"
        Me.LookUpEditHeaderPO.Name = "LookUpEditHeaderPO"
        Me.LookUpEditHeaderPO.ValueMember = "id"
        '
        'SelectHeaderPOBindingSource
        '
        Me.SelectHeaderPOBindingSource.DataMember = "SelectHeader_PO"
        Me.SelectHeaderPOBindingSource.DataSource = Me.DataSetSPPK
        '
        'SelectHeader_POTableAdapter
        '
        Me.SelectHeader_POTableAdapter.ClearBeforeFill = True
        '
        'DetailPI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 416)
        Me.Controls.Add(Me.PIDetail_SelectGridControl)
        Me.Controls.Add(Me.PIDetail_SelectBindingNavigator)
        Me.Name = "DetailPI"
        Me.Text = "DetailPI"
        CType(Me.DataSetSPPK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIDetail_SelectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIDetail_SelectBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PIDetail_SelectBindingNavigator.ResumeLayout(False)
        Me.PIDetail_SelectBindingNavigator.PerformLayout()
        CType(Me.PIDetail_SelectGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditHeaderPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectHeaderPOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSetSPPK As MyTemplate.DataSetSPPK
    Friend WithEvents PIDetail_SelectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PIDetail_SelectTableAdapter As MyTemplate.DataSetSPPKTableAdapters.PIDetail_SelectTableAdapter
    Friend WithEvents TableAdapterManager As MyTemplate.DataSetSPPKTableAdapters.TableAdapterManager
    Friend WithEvents PIDetail_SelectBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PIDetail_SelectBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PIDetail_SelectGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDHeaderPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookUpEditHeaderPO As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colIDHeaderRI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDDetailRI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDTax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SelectHeaderPOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelectHeader_POTableAdapter As MyTemplate.DataSetSPPKTableAdapters.SelectHeader_POTableAdapter
End Class
