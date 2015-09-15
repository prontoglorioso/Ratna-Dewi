<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HeaderDeposit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HeaderDeposit))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.DataSetDeposit = New MyTemplate.DataSetDeposit()
        Me.HeaderDepositDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HeaderDepositTableAdapter = New MyTemplate.DataSetDepositTableAdapters.HeaderDepositTableAdapter()
        Me.TableAdapterManager = New MyTemplate.DataSetDepositTableAdapters.TableAdapterManager()
        Me.HeaderDepositDataTableGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDSubAccCOA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepositNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepositDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMemo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LookUpEditSubAccCOA = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SelectSubAccCOADataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SelectSubAccCOADataTableTableAdapter = New MyTemplate.DataSetDepositTableAdapters.SelectSubAccCOADataTableTableAdapter()
        Me.DateEditDeposit = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ButtonDetail = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        CType(Me.DataSetDeposit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderDepositDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderDepositDataTableGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditSubAccCOA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectSubAccCOADataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditDeposit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditDeposit.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetDeposit
        '
        Me.DataSetDeposit.DataSetName = "DataSetDeposit"
        Me.DataSetDeposit.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HeaderDepositDataTableBindingSource
        '
        Me.HeaderDepositDataTableBindingSource.DataMember = "HeaderDepositDataTable"
        Me.HeaderDepositDataTableBindingSource.DataSource = Me.DataSetDeposit
        '
        'HeaderDepositTableAdapter
        '
        Me.HeaderDepositTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.HeaderDepositTableAdapter = Me.HeaderDepositTableAdapter
        Me.TableAdapterManager.UpdateOrder = MyTemplate.DataSetDepositTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'HeaderDepositDataTableGridControl
        '
        Me.HeaderDepositDataTableGridControl.DataSource = Me.HeaderDepositDataTableBindingSource
        Me.HeaderDepositDataTableGridControl.Location = New System.Drawing.Point(12, 34)
        Me.HeaderDepositDataTableGridControl.MainView = Me.GridView1
        Me.HeaderDepositDataTableGridControl.Name = "HeaderDepositDataTableGridControl"
        Me.HeaderDepositDataTableGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LookUpEditSubAccCOA, Me.DateEditDeposit, Me.ButtonDetail})
        Me.HeaderDepositDataTableGridControl.Size = New System.Drawing.Size(881, 383)
        Me.HeaderDepositDataTableGridControl.TabIndex = 1
        Me.HeaderDepositDataTableGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIDSubAccCOA, Me.colDepositNo, Me.colDepositDate, Me.colMemo, Me.colAmount, Me.GridColumn1})
        Me.GridView1.GridControl = Me.HeaderDepositDataTableGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.SimpleButton3.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.SimpleButton3.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.SimpleButton3.Appearance.Options.UseBackColor = True
        Me.SimpleButton3.Appearance.Options.UseBorderColor = True
        Me.SimpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(95, 5)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(76, 23)
        Me.SimpleButton3.TabIndex = 6
        Me.SimpleButton3.Tag = ""
        Me.SimpleButton3.Text = "Save"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.SimpleButton5.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.SimpleButton5.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.SimpleButton5.Appearance.Options.UseBackColor = True
        Me.SimpleButton5.Appearance.Options.UseBorderColor = True
        Me.SimpleButton5.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(12, 5)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton5.TabIndex = 7
        Me.SimpleButton5.Tag = ""
        Me.SimpleButton5.Text = "Delete"
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 0
        '
        'colIDSubAccCOA
        '
        Me.colIDSubAccCOA.ColumnEdit = Me.LookUpEditSubAccCOA
        Me.colIDSubAccCOA.FieldName = "IDSubAccCOA"
        Me.colIDSubAccCOA.Name = "colIDSubAccCOA"
        Me.colIDSubAccCOA.Visible = True
        Me.colIDSubAccCOA.VisibleIndex = 1
        '
        'colDepositNo
        '
        Me.colDepositNo.FieldName = "DepositNo"
        Me.colDepositNo.Name = "colDepositNo"
        Me.colDepositNo.Visible = True
        Me.colDepositNo.VisibleIndex = 2
        '
        'colDepositDate
        '
        Me.colDepositDate.ColumnEdit = Me.DateEditDeposit
        Me.colDepositDate.FieldName = "DepositDate"
        Me.colDepositDate.Name = "colDepositDate"
        Me.colDepositDate.Visible = True
        Me.colDepositDate.VisibleIndex = 3
        '
        'colMemo
        '
        Me.colMemo.FieldName = "Memo"
        Me.colMemo.Name = "colMemo"
        Me.colMemo.Visible = True
        Me.colMemo.VisibleIndex = 4
        '
        'colAmount
        '
        Me.colAmount.FieldName = "Amount"
        Me.colAmount.Name = "colAmount"
        Me.colAmount.Visible = True
        Me.colAmount.VisibleIndex = 5
        '
        'LookUpEditSubAccCOA
        '
        Me.LookUpEditSubAccCOA.AutoHeight = False
        Me.LookUpEditSubAccCOA.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditSubAccCOA.DataSource = Me.SelectSubAccCOADataTableBindingSource
        Me.LookUpEditSubAccCOA.DisplayMember = "namaSubAccount"
        Me.LookUpEditSubAccCOA.Name = "LookUpEditSubAccCOA"
        Me.LookUpEditSubAccCOA.ValueMember = "id"
        '
        'SelectSubAccCOADataTableBindingSource
        '
        Me.SelectSubAccCOADataTableBindingSource.DataMember = "SelectSubAccCOADataTable"
        Me.SelectSubAccCOADataTableBindingSource.DataSource = Me.DataSetDeposit
        '
        'SelectSubAccCOADataTableTableAdapter
        '
        Me.SelectSubAccCOADataTableTableAdapter.ClearBeforeFill = True
        '
        'DateEditDeposit
        '
        Me.DateEditDeposit.AutoHeight = False
        Me.DateEditDeposit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditDeposit.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditDeposit.Name = "DateEditDeposit"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Detail"
        Me.GridColumn1.ColumnEdit = Me.ButtonDetail
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 6
        '
        'ButtonDetail
        '
        Me.ButtonDetail.AutoHeight = False
        Me.ButtonDetail.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("ButtonDetail.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.ButtonDetail.Name = "ButtonDetail"
        Me.ButtonDetail.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'HeaderDeposit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 429)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Controls.Add(Me.HeaderDepositDataTableGridControl)
        Me.Name = "HeaderDeposit"
        Me.Text = "HeaderDeposit"
        CType(Me.DataSetDeposit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeaderDepositDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeaderDepositDataTableGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditSubAccCOA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectSubAccCOADataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditDeposit.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditDeposit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataSetDeposit As MyTemplate.DataSetDeposit
    Friend WithEvents HeaderDepositDataTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HeaderDepositTableAdapter As MyTemplate.DataSetDepositTableAdapters.HeaderDepositTableAdapter
    Friend WithEvents TableAdapterManager As MyTemplate.DataSetDepositTableAdapters.TableAdapterManager
    Friend WithEvents HeaderDepositDataTableGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDSubAccCOA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookUpEditSubAccCOA As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colDepositNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepositDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMemo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SelectSubAccCOADataTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelectSubAccCOADataTableTableAdapter As MyTemplate.DataSetDepositTableAdapters.SelectSubAccCOADataTableTableAdapter
    Friend WithEvents DateEditDeposit As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ButtonDetail As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
End Class
