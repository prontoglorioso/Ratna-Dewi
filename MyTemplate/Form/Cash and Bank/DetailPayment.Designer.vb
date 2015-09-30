<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailPayment
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
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.SelectHeaderPaymentDetailDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetPayment = New MyTemplate.DataSetPayment()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.PaymentDetailDataTableGridControl = New DevExpress.XtraGrid.GridControl()
        Me.PaymentDetailDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDSubAccCOA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LookUpEditSubAccCOA = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SelectSubAccCOADataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDEmployee = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LookUpEditEmployee = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SelectEmployeeDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colIDVendor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LookUpEditVendor = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SelectVendorDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colIDProject = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LookUpEditProject = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SelectProjectDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colidHeaderPayment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SelectHeaderPaymentDetailTableAdapter = New MyTemplate.DataSetPaymentTableAdapters.SelectHeaderPaymentDetailTableAdapter()
        Me.PaymentDetailTableAdapter = New MyTemplate.DataSetPaymentTableAdapters.PaymentDetailTableAdapter()
        Me.TableAdapterManager = New MyTemplate.DataSetPaymentTableAdapters.TableAdapterManager()
        Me.SelectSubAccCOATableAdapter = New MyTemplate.DataSetPaymentTableAdapters.SelectSubAccCOATableAdapter()
        Me.SelectEmployeeDataTableTableAdapter = New MyTemplate.DataSetPaymentTableAdapters.SelectEmployeeDataTableTableAdapter()
        Me.SelectProjectDataTableTableAdapter = New MyTemplate.DataSetPaymentTableAdapters.SelectProjectDataTableTableAdapter()
        Me.SelectVendorDataTableTableAdapter = New MyTemplate.DataSetPaymentTableAdapters.SelectVendorDataTableTableAdapter()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.SelectHeaderPaymentDetailDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.PaymentDetailDataTableGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentDetailDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditSubAccCOA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectSubAccCOADataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectEmployeeDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditVendor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectVendorDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditProject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectProjectDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.IDTextBox)
        Me.GroupControl2.Controls.Add(Me.LabelControl7)
        Me.GroupControl2.Controls.Add(Me.LabelControl9)
        Me.GroupControl2.Controls.Add(Me.LabelControl11)
        Me.GroupControl2.Controls.Add(Me.LabelControl12)
        Me.GroupControl2.Controls.Add(Me.LabelControl10)
        Me.GroupControl2.Controls.Add(Me.LabelControl8)
        Me.GroupControl2.Controls.Add(Me.LabelControl6)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        Me.GroupControl2.Controls.Add(Me.LabelControl4)
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Controls.Add(Me.LabelControl2)
        Me.GroupControl2.Controls.Add(Me.LabelControl1)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 2)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(633, 129)
        Me.GroupControl2.TabIndex = 5
        Me.GroupControl2.Text = "Edited Payment"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectHeaderPaymentDetailDataTableBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(533, 88)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 21)
        Me.IDTextBox.TabIndex = 22
        '
        'SelectHeaderPaymentDetailDataTableBindingSource
        '
        Me.SelectHeaderPaymentDetailDataTableBindingSource.DataMember = "SelectHeaderPaymentDetailDataTable"
        Me.SelectHeaderPaymentDetailDataTableBindingSource.DataSource = Me.DataSetPayment
        '
        'DataSetPayment
        '
        Me.DataSetPayment.DataSetName = "DataSetPayment"
        Me.DataSetPayment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectHeaderPaymentDetailDataTableBindingSource, "Memo", True))
        Me.LabelControl7.Location = New System.Drawing.Point(451, 35)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(39, 17)
        Me.LabelControl7.TabIndex = 21
        Me.LabelControl7.Text = "Memo:"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectHeaderPaymentDetailDataTableBindingSource, "Amount", True))
        Me.LabelControl9.Location = New System.Drawing.Point(451, 81)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(51, 17)
        Me.LabelControl9.TabIndex = 20
        Me.LabelControl9.Text = "Amount:"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectHeaderPaymentDetailDataTableBindingSource, "ReceivedBy", True))
        Me.LabelControl11.Location = New System.Drawing.Point(451, 58)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(75, 17)
        Me.LabelControl11.TabIndex = 19
        Me.LabelControl11.Text = "Received By:"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Location = New System.Drawing.Point(356, 34)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(39, 17)
        Me.LabelControl12.TabIndex = 18
        Me.LabelControl12.Text = "Memo:"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(356, 80)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(51, 17)
        Me.LabelControl10.TabIndex = 16
        Me.LabelControl10.Text = "Amount:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(356, 57)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(75, 17)
        Me.LabelControl8.TabIndex = 14
        Me.LabelControl8.Text = "Received By:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectHeaderPaymentDetailDataTableBindingSource, "PaymentDate", True))
        Me.LabelControl6.Location = New System.Drawing.Point(109, 81)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(86, 17)
        Me.LabelControl6.TabIndex = 13
        Me.LabelControl6.Text = "Payment Date"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectHeaderPaymentDetailDataTableBindingSource, "PaymentNo", True))
        Me.LabelControl5.Location = New System.Drawing.Point(109, 58)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(77, 17)
        Me.LabelControl5.TabIndex = 12
        Me.LabelControl5.Text = "Payment No:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectHeaderPaymentDetailDataTableBindingSource, "namaSubAccount", True))
        Me.LabelControl4.Location = New System.Drawing.Point(109, 35)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(63, 17)
        Me.LabelControl4.TabIndex = 11
        Me.LabelControl4.Text = "Paid From:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(14, 81)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(89, 17)
        Me.LabelControl3.TabIndex = 10
        Me.LabelControl3.Text = "Payment Date:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(14, 58)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(77, 17)
        Me.LabelControl2.TabIndex = 9
        Me.LabelControl2.Text = "Payment No:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(14, 35)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(63, 17)
        Me.LabelControl1.TabIndex = 8
        Me.LabelControl1.Text = "Paid From:"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(14, 23)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "Add Detail"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(14, 52)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton2.TabIndex = 1
        Me.SimpleButton2.Text = "Save"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Location = New System.Drawing.Point(14, 81)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton3.TabIndex = 2
        Me.SimpleButton3.Text = "Delete"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.SimpleButton3)
        Me.GroupControl3.Controls.Add(Me.SimpleButton2)
        Me.GroupControl3.Controls.Add(Me.SimpleButton1)
        Me.GroupControl3.Location = New System.Drawing.Point(651, 7)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(106, 112)
        Me.GroupControl3.TabIndex = 6
        Me.GroupControl3.Text = "Command Center"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.PaymentDetailDataTableGridControl)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 125)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(745, 323)
        Me.GroupControl1.TabIndex = 7
        Me.GroupControl1.Text = "List Of Detail Payment"
        '
        'PaymentDetailDataTableGridControl
        '
        Me.PaymentDetailDataTableGridControl.DataSource = Me.PaymentDetailDataTableBindingSource
        Me.PaymentDetailDataTableGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PaymentDetailDataTableGridControl.Location = New System.Drawing.Point(2, 22)
        Me.PaymentDetailDataTableGridControl.MainView = Me.GridView1
        Me.PaymentDetailDataTableGridControl.Name = "PaymentDetailDataTableGridControl"
        Me.PaymentDetailDataTableGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LookUpEditSubAccCOA, Me.LookUpEditEmployee, Me.LookUpEditVendor, Me.LookUpEditProject})
        Me.PaymentDetailDataTableGridControl.Size = New System.Drawing.Size(741, 299)
        Me.PaymentDetailDataTableGridControl.TabIndex = 0
        Me.PaymentDetailDataTableGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'PaymentDetailDataTableBindingSource
        '
        Me.PaymentDetailDataTableBindingSource.DataMember = "PaymentDetailDataTable"
        Me.PaymentDetailDataTableBindingSource.DataSource = Me.DataSetPayment
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIDSubAccCOA, Me.colAmount, Me.colIDEmployee, Me.colIDVendor, Me.colIDProject, Me.colidHeaderPayment})
        Me.GridView1.GridControl = Me.PaymentDetailDataTableGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
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
        Me.LookUpEditSubAccCOA.DataSource = Me.SelectSubAccCOADataTableBindingSource
        Me.LookUpEditSubAccCOA.DisplayMember = "namaSubAccount"
        Me.LookUpEditSubAccCOA.Name = "LookUpEditSubAccCOA"
        Me.LookUpEditSubAccCOA.ValueMember = "id"
        '
        'SelectSubAccCOADataTableBindingSource
        '
        Me.SelectSubAccCOADataTableBindingSource.DataMember = "SelectSubAccCOADataTable"
        Me.SelectSubAccCOADataTableBindingSource.DataSource = Me.DataSetPayment
        '
        'colAmount
        '
        Me.colAmount.FieldName = "Amount"
        Me.colAmount.Name = "colAmount"
        Me.colAmount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "{0:0.##}")})
        Me.colAmount.Visible = True
        Me.colAmount.VisibleIndex = 2
        '
        'colIDEmployee
        '
        Me.colIDEmployee.ColumnEdit = Me.LookUpEditEmployee
        Me.colIDEmployee.FieldName = "IDEmployee"
        Me.colIDEmployee.Name = "colIDEmployee"
        Me.colIDEmployee.Visible = True
        Me.colIDEmployee.VisibleIndex = 3
        '
        'LookUpEditEmployee
        '
        Me.LookUpEditEmployee.AutoHeight = False
        Me.LookUpEditEmployee.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditEmployee.DataSource = Me.SelectEmployeeDataTableBindingSource
        Me.LookUpEditEmployee.DisplayMember = "namaKaryawan"
        Me.LookUpEditEmployee.Name = "LookUpEditEmployee"
        Me.LookUpEditEmployee.ValueMember = "id"
        '
        'SelectEmployeeDataTableBindingSource
        '
        Me.SelectEmployeeDataTableBindingSource.DataMember = "SelectEmployeeDataTable"
        Me.SelectEmployeeDataTableBindingSource.DataSource = Me.DataSetPayment
        '
        'colIDVendor
        '
        Me.colIDVendor.ColumnEdit = Me.LookUpEditVendor
        Me.colIDVendor.FieldName = "IDVendor"
        Me.colIDVendor.Name = "colIDVendor"
        Me.colIDVendor.Visible = True
        Me.colIDVendor.VisibleIndex = 4
        '
        'LookUpEditVendor
        '
        Me.LookUpEditVendor.AutoHeight = False
        Me.LookUpEditVendor.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditVendor.DataSource = Me.SelectVendorDataTableBindingSource
        Me.LookUpEditVendor.DisplayMember = "nama"
        Me.LookUpEditVendor.Name = "LookUpEditVendor"
        Me.LookUpEditVendor.ValueMember = "id"
        '
        'SelectVendorDataTableBindingSource
        '
        Me.SelectVendorDataTableBindingSource.DataMember = "SelectVendorDataTable"
        Me.SelectVendorDataTableBindingSource.DataSource = Me.DataSetPayment
        '
        'colIDProject
        '
        Me.colIDProject.ColumnEdit = Me.LookUpEditProject
        Me.colIDProject.FieldName = "IDProject"
        Me.colIDProject.Name = "colIDProject"
        Me.colIDProject.Visible = True
        Me.colIDProject.VisibleIndex = 5
        '
        'LookUpEditProject
        '
        Me.LookUpEditProject.AutoHeight = False
        Me.LookUpEditProject.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditProject.DataSource = Me.SelectProjectDataTableBindingSource
        Me.LookUpEditProject.DisplayMember = "projectName"
        Me.LookUpEditProject.Name = "LookUpEditProject"
        Me.LookUpEditProject.ValueMember = "id"
        '
        'SelectProjectDataTableBindingSource
        '
        Me.SelectProjectDataTableBindingSource.DataMember = "SelectProjectDataTable"
        Me.SelectProjectDataTableBindingSource.DataSource = Me.DataSetPayment
        '
        'colidHeaderPayment
        '
        Me.colidHeaderPayment.FieldName = "idHeaderPayment"
        Me.colidHeaderPayment.Name = "colidHeaderPayment"
        Me.colidHeaderPayment.Visible = True
        Me.colidHeaderPayment.VisibleIndex = 6
        '
        'SelectHeaderPaymentDetailTableAdapter
        '
        Me.SelectHeaderPaymentDetailTableAdapter.ClearBeforeFill = True
        '
        'PaymentDetailTableAdapter
        '
        Me.PaymentDetailTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.HeaderPaymentTableAdapter = Nothing
        Me.TableAdapterManager.PaymentDetailTableAdapter = Me.PaymentDetailTableAdapter
        Me.TableAdapterManager.UpdateOrder = MyTemplate.DataSetPaymentTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SelectSubAccCOATableAdapter
        '
        Me.SelectSubAccCOATableAdapter.ClearBeforeFill = True
        '
        'SelectEmployeeDataTableTableAdapter
        '
        Me.SelectEmployeeDataTableTableAdapter.ClearBeforeFill = True
        '
        'SelectProjectDataTableTableAdapter
        '
        Me.SelectProjectDataTableTableAdapter.ClearBeforeFill = True
        '
        'SelectVendorDataTableTableAdapter
        '
        Me.SelectVendorDataTableTableAdapter.ClearBeforeFill = True
        '
        'DetailPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 448)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl2)
        Me.Name = "DetailPayment"
        Me.Text = "DetailPayment"
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.SelectHeaderPaymentDetailDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetPayment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.PaymentDetailDataTableGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentDetailDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditSubAccCOA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectSubAccCOADataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectEmployeeDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditVendor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectVendorDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditProject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectProjectDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SelectHeaderPaymentDetailDataTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetPayment As MyTemplate.DataSetPayment
    Friend WithEvents SelectHeaderPaymentDetailTableAdapter As MyTemplate.DataSetPaymentTableAdapters.SelectHeaderPaymentDetailTableAdapter
    Friend WithEvents PaymentDetailDataTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PaymentDetailTableAdapter As MyTemplate.DataSetPaymentTableAdapters.PaymentDetailTableAdapter
    Friend WithEvents TableAdapterManager As MyTemplate.DataSetPaymentTableAdapters.TableAdapterManager
    Friend WithEvents PaymentDetailDataTableGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDSubAccCOA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDEmployee As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDVendor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDProject As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidHeaderPayment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LookUpEditSubAccCOA As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SelectSubAccCOADataTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelectSubAccCOATableAdapter As MyTemplate.DataSetPaymentTableAdapters.SelectSubAccCOATableAdapter
    Friend WithEvents LookUpEditEmployee As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SelectEmployeeDataTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelectEmployeeDataTableTableAdapter As MyTemplate.DataSetPaymentTableAdapters.SelectEmployeeDataTableTableAdapter
    Friend WithEvents LookUpEditVendor As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LookUpEditProject As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SelectProjectDataTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelectProjectDataTableTableAdapter As MyTemplate.DataSetPaymentTableAdapters.SelectProjectDataTableTableAdapter
    Friend WithEvents SelectVendorDataTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelectVendorDataTableTableAdapter As MyTemplate.DataSetPaymentTableAdapters.SelectVendorDataTableTableAdapter
End Class
