<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailSR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetailSR))
        Me.DataSetSPPK = New MyTemplate.DataSetSPPK()
        Me.SRDetail_SelectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SRDetail_SelectTableAdapter = New MyTemplate.DataSetSPPKTableAdapters.SRDetail_SelectTableAdapter()
        Me.TableAdapterManager = New MyTemplate.DataSetSPPKTableAdapters.TableAdapterManager()
        Me.SRDetail_SelectBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.SRDetail_SelectBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SRDetail_SelectGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDHeaderSO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDHeaderDO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDHeaderSI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDDetailSI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colclose = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LookUpEditHeaderSO = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SelectHeaderSOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SelectHeader_SOTableAdapter = New MyTemplate.DataSetSPPKTableAdapters.SelectHeader_SOTableAdapter()
        Me.LookUpEditHeaderDO = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        CType(Me.DataSetSPPK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SRDetail_SelectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SRDetail_SelectBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SRDetail_SelectBindingNavigator.SuspendLayout()
        CType(Me.SRDetail_SelectGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditHeaderSO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectHeaderSOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditHeaderDO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetSPPK
        '
        Me.DataSetSPPK.DataSetName = "DataSetSPPK"
        Me.DataSetSPPK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SRDetail_SelectBindingSource
        '
        Me.SRDetail_SelectBindingSource.DataMember = "SRDetail_Select"
        Me.SRDetail_SelectBindingSource.DataSource = Me.DataSetSPPK
        '
        'SRDetail_SelectTableAdapter
        '
        Me.SRDetail_SelectTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.SODetail_SelectTableAdapter = Nothing
        Me.TableAdapterManager.SOHeader_SelectTableAdapter = Nothing
        Me.TableAdapterManager.SRDetail_SelectTableAdapter = Me.SRDetail_SelectTableAdapter
        Me.TableAdapterManager.SRHeader_SelectTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MyTemplate.DataSetSPPKTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SRDetail_SelectBindingNavigator
        '
        Me.SRDetail_SelectBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SRDetail_SelectBindingNavigator.BindingSource = Me.SRDetail_SelectBindingSource
        Me.SRDetail_SelectBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SRDetail_SelectBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SRDetail_SelectBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SRDetail_SelectBindingNavigatorSaveItem})
        Me.SRDetail_SelectBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SRDetail_SelectBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SRDetail_SelectBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SRDetail_SelectBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SRDetail_SelectBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SRDetail_SelectBindingNavigator.Name = "SRDetail_SelectBindingNavigator"
        Me.SRDetail_SelectBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SRDetail_SelectBindingNavigator.Size = New System.Drawing.Size(504, 25)
        Me.SRDetail_SelectBindingNavigator.TabIndex = 0
        Me.SRDetail_SelectBindingNavigator.Text = "BindingNavigator1"
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
        'SRDetail_SelectBindingNavigatorSaveItem
        '
        Me.SRDetail_SelectBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SRDetail_SelectBindingNavigatorSaveItem.Image = CType(resources.GetObject("SRDetail_SelectBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SRDetail_SelectBindingNavigatorSaveItem.Name = "SRDetail_SelectBindingNavigatorSaveItem"
        Me.SRDetail_SelectBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SRDetail_SelectBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SRDetail_SelectGridControl
        '
        Me.SRDetail_SelectGridControl.Cursor = System.Windows.Forms.Cursors.Default
        Me.SRDetail_SelectGridControl.DataSource = Me.SRDetail_SelectBindingSource
        Me.SRDetail_SelectGridControl.Location = New System.Drawing.Point(0, 28)
        Me.SRDetail_SelectGridControl.MainView = Me.GridView1
        Me.SRDetail_SelectGridControl.Name = "SRDetail_SelectGridControl"
        Me.SRDetail_SelectGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LookUpEditHeaderSO, Me.LookUpEditHeaderDO})
        Me.SRDetail_SelectGridControl.Size = New System.Drawing.Size(504, 367)
        Me.SRDetail_SelectGridControl.TabIndex = 1
        Me.SRDetail_SelectGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIDHeaderSO, Me.colIDHeaderDO, Me.colIDHeaderSI, Me.colIDDetailSI, Me.colclose})
        Me.GridView1.GridControl = Me.SRDetail_SelectGridControl
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
        'colIDHeaderSO
        '
        Me.colIDHeaderSO.ColumnEdit = Me.LookUpEditHeaderSO
        Me.colIDHeaderSO.FieldName = "IDHeaderSO"
        Me.colIDHeaderSO.Name = "colIDHeaderSO"
        Me.colIDHeaderSO.Visible = True
        Me.colIDHeaderSO.VisibleIndex = 1
        '
        'colIDHeaderDO
        '
        Me.colIDHeaderDO.ColumnEdit = Me.LookUpEditHeaderDO
        Me.colIDHeaderDO.FieldName = "IDHeaderDO"
        Me.colIDHeaderDO.Name = "colIDHeaderDO"
        Me.colIDHeaderDO.Visible = True
        Me.colIDHeaderDO.VisibleIndex = 2
        '
        'colIDHeaderSI
        '
        Me.colIDHeaderSI.FieldName = "IDHeaderSI"
        Me.colIDHeaderSI.Name = "colIDHeaderSI"
        Me.colIDHeaderSI.Visible = True
        Me.colIDHeaderSI.VisibleIndex = 3
        '
        'colIDDetailSI
        '
        Me.colIDDetailSI.FieldName = "IDDetailSI"
        Me.colIDDetailSI.Name = "colIDDetailSI"
        Me.colIDDetailSI.Visible = True
        Me.colIDDetailSI.VisibleIndex = 4
        '
        'colclose
        '
        Me.colclose.FieldName = "close"
        Me.colclose.Name = "colclose"
        Me.colclose.Visible = True
        Me.colclose.VisibleIndex = 5
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
        'SelectHeader_SOTableAdapter
        '
        Me.SelectHeader_SOTableAdapter.ClearBeforeFill = True
        '
        'LookUpEditHeaderDO
        '
        Me.LookUpEditHeaderDO.AutoHeight = False
        Me.LookUpEditHeaderDO.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditHeaderDO.Name = "LookUpEditHeaderDO"
        '
        'DetailSR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 428)
        Me.Controls.Add(Me.SRDetail_SelectGridControl)
        Me.Controls.Add(Me.SRDetail_SelectBindingNavigator)
        Me.Name = "DetailSR"
        Me.Text = "DetailSR"
        CType(Me.DataSetSPPK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SRDetail_SelectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SRDetail_SelectBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SRDetail_SelectBindingNavigator.ResumeLayout(False)
        Me.SRDetail_SelectBindingNavigator.PerformLayout()
        CType(Me.SRDetail_SelectGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditHeaderSO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectHeaderSOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditHeaderDO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSetSPPK As MyTemplate.DataSetSPPK
    Friend WithEvents SRDetail_SelectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SRDetail_SelectTableAdapter As MyTemplate.DataSetSPPKTableAdapters.SRDetail_SelectTableAdapter
    Friend WithEvents TableAdapterManager As MyTemplate.DataSetSPPKTableAdapters.TableAdapterManager
    Friend WithEvents SRDetail_SelectBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents SRDetail_SelectBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SRDetail_SelectGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDHeaderSO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookUpEditHeaderSO As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colIDHeaderDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDHeaderSI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDDetailSI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colclose As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SelectHeaderSOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelectHeader_SOTableAdapter As MyTemplate.DataSetSPPKTableAdapters.SelectHeader_SOTableAdapter
    Friend WithEvents LookUpEditHeaderDO As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
