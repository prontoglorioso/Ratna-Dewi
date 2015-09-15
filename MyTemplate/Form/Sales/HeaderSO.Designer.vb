<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HeaderSO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HeaderSO))
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.DataSetSO = New MyTemplate.DataSetSO()
        Me.SOHeaderDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SOHeaderTableAdapter = New MyTemplate.DataSetSOTableAdapters.SOHeaderTableAdapter()
        Me.TableAdapterManager = New MyTemplate.DataSetSOTableAdapters.TableAdapterManager()
        Me.SOHeaderDataTableGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDCustomer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltglSO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoSO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescriptionSO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDSubAccCOA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalOrder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisDeleted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LookUpEditCustomer = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SOHeaderDataTableBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SelectCustomerDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SelectCustomerTableAdapter = New MyTemplate.DataSetSOTableAdapters.SelectCustomerTableAdapter()
        Me.LookUpEditSubAccCOA = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SelectSubAccCOADataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SelectSubAccCOATableAdapter = New MyTemplate.DataSetSOTableAdapters.SelectSubAccCOATableAdapter()
        Me.Detail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ButtonDetail = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.DataSetSO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SOHeaderDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SOHeaderDataTableGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SOHeaderDataTableBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectCustomerDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditSubAccCOA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectSubAccCOADataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetSO
        '
        Me.DataSetSO.DataSetName = "DataSetSO"
        Me.DataSetSO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SOHeaderDataTableBindingSource
        '
        Me.SOHeaderDataTableBindingSource.DataMember = "SOHeaderDataTable"
        Me.SOHeaderDataTableBindingSource.DataSource = Me.DataSetSO
        '
        'SOHeaderTableAdapter
        '
        Me.SOHeaderTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SOHeaderTableAdapter = Me.SOHeaderTableAdapter
        Me.TableAdapterManager.UpdateOrder = MyTemplate.DataSetSOTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SOHeaderDataTableGridControl
        '
        Me.SOHeaderDataTableGridControl.DataSource = Me.SOHeaderDataTableBindingSource
        Me.SOHeaderDataTableGridControl.Location = New System.Drawing.Point(12, 34)
        Me.SOHeaderDataTableGridControl.MainView = Me.GridView1
        Me.SOHeaderDataTableGridControl.Name = "SOHeaderDataTableGridControl"
        Me.SOHeaderDataTableGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LookUpEditCustomer, Me.LookUpEditSubAccCOA, Me.ButtonDetail})
        Me.SOHeaderDataTableGridControl.Size = New System.Drawing.Size(881, 383)
        Me.SOHeaderDataTableGridControl.TabIndex = 1
        Me.SOHeaderDataTableGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIDCustomer, Me.coltglSO, Me.colNoSO, Me.colDescriptionSO, Me.colIDSubAccCOA, Me.colTotalOrder, Me.colisDeleted, Me.Detail})
        Me.GridView1.GridControl = Me.SOHeaderDataTableGridControl
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
        'colIDCustomer
        '
        Me.colIDCustomer.ColumnEdit = Me.LookUpEditCustomer
        Me.colIDCustomer.FieldName = "IDCustomer"
        Me.colIDCustomer.Name = "colIDCustomer"
        Me.colIDCustomer.Visible = True
        Me.colIDCustomer.VisibleIndex = 1
        '
        'coltglSO
        '
        Me.coltglSO.FieldName = "tglSO"
        Me.coltglSO.Name = "coltglSO"
        Me.coltglSO.Visible = True
        Me.coltglSO.VisibleIndex = 2
        '
        'colNoSO
        '
        Me.colNoSO.FieldName = "NoSO"
        Me.colNoSO.Name = "colNoSO"
        Me.colNoSO.Visible = True
        Me.colNoSO.VisibleIndex = 3
        '
        'colDescriptionSO
        '
        Me.colDescriptionSO.FieldName = "DescriptionSO"
        Me.colDescriptionSO.Name = "colDescriptionSO"
        Me.colDescriptionSO.Visible = True
        Me.colDescriptionSO.VisibleIndex = 4
        '
        'colIDSubAccCOA
        '
        Me.colIDSubAccCOA.ColumnEdit = Me.LookUpEditSubAccCOA
        Me.colIDSubAccCOA.FieldName = "IDSubAccCOA"
        Me.colIDSubAccCOA.Name = "colIDSubAccCOA"
        Me.colIDSubAccCOA.Visible = True
        Me.colIDSubAccCOA.VisibleIndex = 5
        '
        'colTotalOrder
        '
        Me.colTotalOrder.FieldName = "TotalOrder"
        Me.colTotalOrder.Name = "colTotalOrder"
        Me.colTotalOrder.Visible = True
        Me.colTotalOrder.VisibleIndex = 6
        '
        'colisDeleted
        '
        Me.colisDeleted.FieldName = "isDeleted"
        Me.colisDeleted.Name = "colisDeleted"
        Me.colisDeleted.Visible = True
        Me.colisDeleted.VisibleIndex = 7
        '
        'LookUpEditCustomer
        '
        Me.LookUpEditCustomer.AutoHeight = False
        Me.LookUpEditCustomer.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditCustomer.DataSource = Me.SelectCustomerDataTableBindingSource
        Me.LookUpEditCustomer.DisplayMember = "nama"
        Me.LookUpEditCustomer.Name = "LookUpEditCustomer"
        Me.LookUpEditCustomer.ValueMember = "id"
        '
        'SOHeaderDataTableBindingSource1
        '
        Me.SOHeaderDataTableBindingSource1.DataMember = "SOHeaderDataTable"
        Me.SOHeaderDataTableBindingSource1.DataSource = Me.DataSetSO
        '
        'SelectCustomerDataTableBindingSource
        '
        Me.SelectCustomerDataTableBindingSource.DataMember = "SelectCustomerDataTable"
        Me.SelectCustomerDataTableBindingSource.DataSource = Me.DataSetSO
        '
        'SelectCustomerTableAdapter
        '
        Me.SelectCustomerTableAdapter.ClearBeforeFill = True
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
        Me.SelectSubAccCOADataTableBindingSource.DataSource = Me.DataSetSO
        '
        'SelectSubAccCOATableAdapter
        '
        Me.SelectSubAccCOATableAdapter.ClearBeforeFill = True
        '
        'Detail
        '
        Me.Detail.Caption = "GridColumn1"
        Me.Detail.ColumnEdit = Me.ButtonDetail
        Me.Detail.Name = "Detail"
        Me.Detail.Visible = True
        Me.Detail.VisibleIndex = 8
        '
        'ButtonDetail
        '
        Me.ButtonDetail.AutoHeight = False
        Me.ButtonDetail.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("ButtonDetail.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
        Me.ButtonDetail.Name = "ButtonDetail"
        Me.ButtonDetail.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.SimpleButton2.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.SimpleButton2.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.SimpleButton2.Appearance.Options.UseBackColor = True
        Me.SimpleButton2.Appearance.Options.UseBorderColor = True
        Me.SimpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(278, 5)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(110, 23)
        Me.SimpleButton2.TabIndex = 9
        Me.SimpleButton2.Tag = ""
        Me.SimpleButton2.Text = "Down Payment"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.SimpleButton1.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.SimpleButton1.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.Appearance.Options.UseBorderColor = True
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(163, 5)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(109, 23)
        Me.SimpleButton1.TabIndex = 8
        Me.SimpleButton1.Tag = ""
        Me.SimpleButton1.Text = "Delivery Order"
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
        Me.SimpleButton3.Location = New System.Drawing.Point(81, 5)
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
        'HeaderSO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 429)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Controls.Add(Me.SOHeaderDataTableGridControl)
        Me.Name = "HeaderSO"
        Me.Text = "HeaderSO"
        CType(Me.DataSetSO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SOHeaderDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SOHeaderDataTableGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SOHeaderDataTableBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectCustomerDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditSubAccCOA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectSubAccCOADataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataSetSO As MyTemplate.DataSetSO
    Friend WithEvents SOHeaderDataTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SOHeaderTableAdapter As MyTemplate.DataSetSOTableAdapters.SOHeaderTableAdapter
    Friend WithEvents TableAdapterManager As MyTemplate.DataSetSOTableAdapters.TableAdapterManager
    Friend WithEvents SOHeaderDataTableGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDCustomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookUpEditCustomer As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SOHeaderDataTableBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents coltglSO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoSO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescriptionSO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDSubAccCOA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalOrder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisDeleted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SelectCustomerDataTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelectCustomerTableAdapter As MyTemplate.DataSetSOTableAdapters.SelectCustomerTableAdapter
    Friend WithEvents LookUpEditSubAccCOA As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SelectSubAccCOADataTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelectSubAccCOATableAdapter As MyTemplate.DataSetSOTableAdapters.SelectSubAccCOATableAdapter
    Friend WithEvents Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ButtonDetail As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
End Class
