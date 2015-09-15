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
        Me.DataSetSO = New MyTemplate.DataSetSO()
        Me.SODetailDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SODetailTableAdapter = New MyTemplate.DataSetSOTableAdapters.SODetailTableAdapter()
        Me.TableAdapterManager = New MyTemplate.DataSetSOTableAdapters.TableAdapterManager()
        Me.SODetailDataTableGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDHeader = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDItem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LookUpEditItem = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SelectItemDataTableBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDTax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LookUpEditTax = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SelectTaxDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colunitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDProject = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LookUpEditProject = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SelectProjectDataTableBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.colClose = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SelectProjectDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SelectItemDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.SelectHeaderSODetailDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.TextEditIDHeaderSO = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.SelectHeaderSODetailTableAdapter = New MyTemplate.DataSetSOTableAdapters.SelectHeaderSODetailTableAdapter()
        Me.SelectItemTableAdapter = New MyTemplate.DataSetSOTableAdapters.SelectItemTableAdapter()
        Me.SelectTaxTableAdapter = New MyTemplate.DataSetSOTableAdapters.SelectTaxTableAdapter()
        Me.SelectProjectDataTableTableAdapter = New MyTemplate.DataSetSOTableAdapters.SelectProjectDataTableTableAdapter()
        CType(Me.DataSetSO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SODetailDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SODetailDataTableGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectItemDataTableBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditTax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectTaxDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditProject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectProjectDataTableBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectProjectDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectItemDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.SelectHeaderSODetailDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.TextEditIDHeaderSO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataSetSO
        '
        Me.DataSetSO.DataSetName = "DataSetSO"
        Me.DataSetSO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SODetailDataTableBindingSource
        '
        Me.SODetailDataTableBindingSource.DataMember = "SODetailDataTable"
        Me.SODetailDataTableBindingSource.DataSource = Me.DataSetSO
        '
        'SODetailTableAdapter
        '
        Me.SODetailTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SODetailTableAdapter = Me.SODetailTableAdapter
        Me.TableAdapterManager.SOHeaderTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MyTemplate.DataSetSOTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SODetailDataTableGridControl
        '
        Me.SODetailDataTableGridControl.DataSource = Me.SODetailDataTableBindingSource
        Me.SODetailDataTableGridControl.Location = New System.Drawing.Point(5, 23)
        Me.SODetailDataTableGridControl.MainView = Me.GridView1
        Me.SODetailDataTableGridControl.Name = "SODetailDataTableGridControl"
        Me.SODetailDataTableGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.LookUpEditItem, Me.LookUpEditTax, Me.LookUpEditProject})
        Me.SODetailDataTableGridControl.Size = New System.Drawing.Size(701, 189)
        Me.SODetailDataTableGridControl.TabIndex = 2
        Me.SODetailDataTableGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIDHeader, Me.colIDItem, Me.colQty, Me.colIDTax, Me.colunitPrice, Me.colIDProject, Me.colClose})
        Me.GridView1.GridControl = Me.SODetailDataTableGridControl
        Me.GridView1.Name = "GridView1"
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
        Me.colIDHeader.FieldName = "IDHeader"
        Me.colIDHeader.Name = "colIDHeader"
        Me.colIDHeader.Visible = True
        Me.colIDHeader.VisibleIndex = 1
        '
        'colIDItem
        '
        Me.colIDItem.ColumnEdit = Me.LookUpEditItem
        Me.colIDItem.FieldName = "IDItem"
        Me.colIDItem.Name = "colIDItem"
        Me.colIDItem.Visible = True
        Me.colIDItem.VisibleIndex = 2
        '
        'LookUpEditItem
        '
        Me.LookUpEditItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.LookUpEditItem.AutoHeight = False
        Me.LookUpEditItem.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditItem.DataSource = Me.SelectItemDataTableBindingSource1
        Me.LookUpEditItem.DisplayMember = "namaItem"
        Me.LookUpEditItem.Name = "LookUpEditItem"
        Me.LookUpEditItem.ValueMember = "id"
        '
        'SelectItemDataTableBindingSource1
        '
        Me.SelectItemDataTableBindingSource1.DataMember = "SelectItemDataTable"
        Me.SelectItemDataTableBindingSource1.DataSource = Me.DataSetSO
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
        Me.LookUpEditTax.DataSource = Me.SelectTaxDataTableBindingSource
        Me.LookUpEditTax.DisplayMember = "kodePajak"
        Me.LookUpEditTax.Name = "LookUpEditTax"
        Me.LookUpEditTax.ValueMember = "id"
        '
        'SelectTaxDataTableBindingSource
        '
        Me.SelectTaxDataTableBindingSource.DataMember = "SelectTaxDataTable"
        Me.SelectTaxDataTableBindingSource.DataSource = Me.DataSetSO
        '
        'colunitPrice
        '
        Me.colunitPrice.FieldName = "unitPrice"
        Me.colunitPrice.Name = "colunitPrice"
        Me.colunitPrice.Visible = True
        Me.colunitPrice.VisibleIndex = 5
        '
        'colIDProject
        '
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
        Me.LookUpEditProject.DataSource = Me.SelectProjectDataTableBindingSource1
        Me.LookUpEditProject.DisplayMember = "projectName"
        Me.LookUpEditProject.Name = "LookUpEditProject"
        Me.LookUpEditProject.ValueMember = "id"
        '
        'SelectProjectDataTableBindingSource1
        '
        Me.SelectProjectDataTableBindingSource1.DataMember = "SelectProjectDataTable"
        Me.SelectProjectDataTableBindingSource1.DataSource = Me.DataSetSO
        '
        'colClose
        '
        Me.colClose.FieldName = "Close"
        Me.colClose.Name = "colClose"
        Me.colClose.Visible = True
        Me.colClose.VisibleIndex = 7
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'SelectProjectDataTableBindingSource
        '
        Me.SelectProjectDataTableBindingSource.DataMember = "SelectProjectDataTable"
        Me.SelectProjectDataTableBindingSource.DataSource = Me.DataSetSO
        '
        'SelectItemDataTableBindingSource
        '
        Me.SelectItemDataTableBindingSource.DataMember = "SelectItemDataTable"
        Me.SelectItemDataTableBindingSource.DataSource = Me.DataSetSO
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
        Me.GroupControl2.TabIndex = 4
        Me.GroupControl2.Text = "Edited Sales Order"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectHeaderSODetailDataTableBindingSource, "tglSO", True))
        Me.LabelControl6.Location = New System.Drawing.Point(618, 35)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(72, 17)
        Me.LabelControl6.TabIndex = 13
        Me.LabelControl6.Text = "Issued Date:"
        '
        'SelectHeaderSODetailDataTableBindingSource
        '
        Me.SelectHeaderSODetailDataTableBindingSource.DataMember = "SelectHeaderSODetailDataTable"
        Me.SelectHeaderSODetailDataTableBindingSource.DataSource = Me.DataSetSO
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectHeaderSODetailDataTableBindingSource, "nama", True))
        Me.LabelControl5.Location = New System.Drawing.Point(280, 35)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(98, 17)
        Me.LabelControl5.TabIndex = 12
        Me.LabelControl5.Text = "Customer Name:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectHeaderSODetailDataTableBindingSource, "NoSO", True))
        Me.LabelControl4.Location = New System.Drawing.Point(93, 35)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(72, 17)
        Me.LabelControl4.TabIndex = 11
        Me.LabelControl4.Text = "SO Number:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(540, 35)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(72, 17)
        Me.LabelControl3.TabIndex = 10
        Me.LabelControl3.Text = "Issued Date:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(176, 35)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(98, 17)
        Me.LabelControl2.TabIndex = 9
        Me.LabelControl2.Text = "Customer Name:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(14, 35)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(72, 17)
        Me.LabelControl1.TabIndex = 8
        Me.LabelControl1.Text = "SO Number:"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.TextEditIDHeaderSO)
        Me.GroupControl3.Controls.Add(Me.SimpleButton3)
        Me.GroupControl3.Controls.Add(Me.SimpleButton2)
        Me.GroupControl3.Controls.Add(Me.SimpleButton1)
        Me.GroupControl3.Location = New System.Drawing.Point(3, 85)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(711, 76)
        Me.GroupControl3.TabIndex = 5
        Me.GroupControl3.Text = "Command Center"
        '
        'TextEditIDHeaderSO
        '
        Me.TextEditIDHeaderSO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectHeaderSODetailDataTableBindingSource, "ID", True))
        Me.TextEditIDHeaderSO.Location = New System.Drawing.Point(360, 40)
        Me.TextEditIDHeaderSO.Name = "TextEditIDHeaderSO"
        Me.TextEditIDHeaderSO.Size = New System.Drawing.Size(100, 20)
        Me.TextEditIDHeaderSO.TabIndex = 3
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
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.SODetailDataTableGridControl)
        Me.GroupControl1.Location = New System.Drawing.Point(3, 167)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(711, 217)
        Me.GroupControl1.TabIndex = 6
        Me.GroupControl1.Text = "List Of Detail Sales Order"
        '
        'SelectHeaderSODetailTableAdapter
        '
        Me.SelectHeaderSODetailTableAdapter.ClearBeforeFill = True
        '
        'SelectItemTableAdapter
        '
        Me.SelectItemTableAdapter.ClearBeforeFill = True
        '
        'SelectTaxTableAdapter
        '
        Me.SelectTaxTableAdapter.ClearBeforeFill = True
        '
        'SelectProjectDataTableTableAdapter
        '
        Me.SelectProjectDataTableTableAdapter.ClearBeforeFill = True
        '
        'DetailSO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 385)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl2)
        Me.Name = "DetailSO"
        Me.Text = "DetailSO"
        CType(Me.DataSetSO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SODetailDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SODetailDataTableGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectItemDataTableBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditTax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectTaxDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditProject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectProjectDataTableBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectProjectDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectItemDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.SelectHeaderSODetailDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.TextEditIDHeaderSO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataSetSO As MyTemplate.DataSetSO
    Friend WithEvents SODetailDataTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SODetailTableAdapter As MyTemplate.DataSetSOTableAdapters.SODetailTableAdapter
    Friend WithEvents TableAdapterManager As MyTemplate.DataSetSOTableAdapters.TableAdapterManager
    Friend WithEvents SODetailDataTableGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDHeader As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDItem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDTax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colunitPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDProject As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colClose As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SelectHeaderSODetailDataTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TextEditIDHeaderSO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SelectHeaderSODetailTableAdapter As MyTemplate.DataSetSOTableAdapters.SelectHeaderSODetailTableAdapter
    Friend WithEvents LookUpEditItem As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SelectItemDataTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelectItemTableAdapter As MyTemplate.DataSetSOTableAdapters.SelectItemTableAdapter
    Friend WithEvents LookUpEditTax As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SelectTaxDataTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelectTaxTableAdapter As MyTemplate.DataSetSOTableAdapters.SelectTaxTableAdapter
    Friend WithEvents SelectProjectDataTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelectProjectDataTableTableAdapter As MyTemplate.DataSetSOTableAdapters.SelectProjectDataTableTableAdapter
    Friend WithEvents SelectItemDataTableBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents LookUpEditProject As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SelectProjectDataTableBindingSource1 As System.Windows.Forms.BindingSource
End Class
