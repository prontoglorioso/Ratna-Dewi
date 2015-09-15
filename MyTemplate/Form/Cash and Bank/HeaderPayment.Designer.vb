<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HeaderPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HeaderPayment))
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.DataSetPayment = New MyTemplate.DataSetPayment()
        Me.HeaderPaymentDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HeaderPaymentTableAdapter = New MyTemplate.DataSetPaymentTableAdapters.HeaderPaymentTableAdapter()
        Me.TableAdapterManager = New MyTemplate.DataSetPaymentTableAdapters.TableAdapterManager()
        Me.HeaderPaymentDataTableGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDSubAccCOA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LookUpEditSubAccCOA = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SelectSubAccCOADataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colPaymentNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPaymentDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DateEditPayment = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colMemo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceivedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ButtonDetail = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SelectSubAccCOADataTableBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SelectSubAccCOATableAdapter = New MyTemplate.DataSetPaymentTableAdapters.SelectSubAccCOATableAdapter()
        CType(Me.DataSetPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderPaymentDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderPaymentDataTableGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditSubAccCOA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectSubAccCOADataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditPayment.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectSubAccCOADataTableBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetPayment
        '
        Me.DataSetPayment.DataSetName = "DataSetPayment"
        Me.DataSetPayment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HeaderPaymentDataTableBindingSource
        '
        Me.HeaderPaymentDataTableBindingSource.DataMember = "HeaderPaymentDataTable"
        Me.HeaderPaymentDataTableBindingSource.DataSource = Me.DataSetPayment
        '
        'HeaderPaymentTableAdapter
        '
        Me.HeaderPaymentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.HeaderPaymentTableAdapter = Me.HeaderPaymentTableAdapter
        Me.TableAdapterManager.PaymentDetailTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MyTemplate.DataSetPaymentTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'HeaderPaymentDataTableGridControl
        '
        Me.HeaderPaymentDataTableGridControl.DataSource = Me.HeaderPaymentDataTableBindingSource
        Me.HeaderPaymentDataTableGridControl.Location = New System.Drawing.Point(12, 34)
        Me.HeaderPaymentDataTableGridControl.MainView = Me.GridView1
        Me.HeaderPaymentDataTableGridControl.Name = "HeaderPaymentDataTableGridControl"
        Me.HeaderPaymentDataTableGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LookUpEditSubAccCOA, Me.DateEditPayment, Me.ButtonDetail})
        Me.HeaderPaymentDataTableGridControl.Size = New System.Drawing.Size(881, 383)
        Me.HeaderPaymentDataTableGridControl.TabIndex = 1
        Me.HeaderPaymentDataTableGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIDSubAccCOA, Me.colPaymentNo, Me.colPaymentDate, Me.colMemo, Me.colReceivedBy, Me.colAmount, Me.GridColumn1})
        Me.GridView1.GridControl = Me.HeaderPaymentDataTableGridControl
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
        'colIDSubAccCOA
        '
        Me.colIDSubAccCOA.ColumnEdit = Me.LookUpEditSubAccCOA
        Me.colIDSubAccCOA.FieldName = "IDSubAccCOA"
        Me.colIDSubAccCOA.Name = "colIDSubAccCOA"
        Me.colIDSubAccCOA.Visible = True
        Me.colIDSubAccCOA.VisibleIndex = 1
        '
        'LookUpEditSubAccCOA
        '
        Me.LookUpEditSubAccCOA.AutoHeight = False
        Me.LookUpEditSubAccCOA.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditSubAccCOA.DataSource = Me.SelectSubAccCOADataTableBindingSource1
        Me.LookUpEditSubAccCOA.DisplayMember = "namaSubAccount"
        Me.LookUpEditSubAccCOA.Name = "LookUpEditSubAccCOA"
        Me.LookUpEditSubAccCOA.ValueMember = "id"
        '
        'SelectSubAccCOADataTableBindingSource
        '
        Me.SelectSubAccCOADataTableBindingSource.DataMember = "SelectSubAccCOADataTable"
        Me.SelectSubAccCOADataTableBindingSource.DataSource = Me.DataSetPayment
        '
        'colPaymentNo
        '
        Me.colPaymentNo.FieldName = "PaymentNo"
        Me.colPaymentNo.Name = "colPaymentNo"
        Me.colPaymentNo.Visible = True
        Me.colPaymentNo.VisibleIndex = 2
        '
        'colPaymentDate
        '
        Me.colPaymentDate.ColumnEdit = Me.DateEditPayment
        Me.colPaymentDate.FieldName = "PaymentDate"
        Me.colPaymentDate.Name = "colPaymentDate"
        Me.colPaymentDate.Visible = True
        Me.colPaymentDate.VisibleIndex = 3
        '
        'DateEditPayment
        '
        Me.DateEditPayment.AutoHeight = False
        Me.DateEditPayment.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditPayment.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditPayment.Name = "DateEditPayment"
        '
        'colMemo
        '
        Me.colMemo.FieldName = "Memo"
        Me.colMemo.Name = "colMemo"
        Me.colMemo.Visible = True
        Me.colMemo.VisibleIndex = 4
        '
        'colReceivedBy
        '
        Me.colReceivedBy.FieldName = "ReceivedBy"
        Me.colReceivedBy.Name = "colReceivedBy"
        Me.colReceivedBy.Visible = True
        Me.colReceivedBy.VisibleIndex = 5
        '
        'colAmount
        '
        Me.colAmount.FieldName = "Amount"
        Me.colAmount.Name = "colAmount"
        Me.colAmount.Visible = True
        Me.colAmount.VisibleIndex = 6
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Detail"
        Me.GridColumn1.ColumnEdit = Me.ButtonDetail
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 7
        '
        'ButtonDetail
        '
        Me.ButtonDetail.AutoHeight = False
        Me.ButtonDetail.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("ButtonDetail.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
        Me.ButtonDetail.Name = "ButtonDetail"
        Me.ButtonDetail.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
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
        Me.SimpleButton3.TabIndex = 4
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
        Me.SimpleButton5.TabIndex = 5
        Me.SimpleButton5.Tag = ""
        Me.SimpleButton5.Text = "Delete"
        '
        'SelectSubAccCOADataTableBindingSource1
        '
        Me.SelectSubAccCOADataTableBindingSource1.DataMember = "SelectSubAccCOADataTable"
        Me.SelectSubAccCOADataTableBindingSource1.DataSource = Me.DataSetPayment
        '
        'SelectSubAccCOATableAdapter
        '
        Me.SelectSubAccCOATableAdapter.ClearBeforeFill = True
        '
        'HeaderPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 429)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Controls.Add(Me.HeaderPaymentDataTableGridControl)
        Me.Name = "HeaderPayment"
        Me.Text = "HeaderPayment"
        CType(Me.DataSetPayment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeaderPaymentDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeaderPaymentDataTableGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditSubAccCOA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectSubAccCOADataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditPayment.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditPayment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectSubAccCOADataTableBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataSetPayment As MyTemplate.DataSetPayment
    Friend WithEvents HeaderPaymentDataTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HeaderPaymentTableAdapter As MyTemplate.DataSetPaymentTableAdapters.HeaderPaymentTableAdapter
    Friend WithEvents TableAdapterManager As MyTemplate.DataSetPaymentTableAdapters.TableAdapterManager
    Friend WithEvents HeaderPaymentDataTableGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDSubAccCOA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookUpEditSubAccCOA As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colPaymentNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPaymentDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMemo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceivedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SelectSubAccCOADataTableBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents SelectSubAccCOADataTableTableAdapter As MyTemplate.DataSetPaymentTableAdapters.SelectSubAccCOADataTableTableAdapter
    Friend WithEvents DateEditPayment As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ButtonDetail As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents SelectSubAccCOADataTableBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents SelectSubAccCOATableAdapter As MyTemplate.DataSetPaymentTableAdapters.SelectSubAccCOATableAdapter
End Class
