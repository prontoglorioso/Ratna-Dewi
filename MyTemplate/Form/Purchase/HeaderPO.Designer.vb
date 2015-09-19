<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HeaderPO
    Inherits MyForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HeaderPO))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.POHeader_SelectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetSPPK = New MyTemplate.DataSetSPPK()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDVendor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SelectVendorBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.coltglPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescriptionPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDSubAccCOA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LookUpEditSubAccCOA = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SelectSubAccCOABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAction = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ButtonDetail = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.LookUpEditVendor = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SelectVendorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DateEditPO = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.POHeader_SelectTableAdapter = New MyTemplate.DataSetSPPKTableAdapters.POHeader_SelectTableAdapter()
        Me.TableAdapterManager = New MyTemplate.DataSetSPPKTableAdapters.TableAdapterManager()
        Me.SelectVendorTableAdapter = New MyTemplate.DataSetSPPKTableAdapters.SelectVendorTableAdapter()
        Me.SelectSubAccCOATableAdapter = New MyTemplate.DataSetSPPKTableAdapters.SelectSubAccCOATableAdapter()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POHeader_SelectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetSPPK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectVendorBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditSubAccCOA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectSubAccCOABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditVendor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectVendorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditPO.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.SimpleButton3.TabIndex = 2
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
        Me.SimpleButton5.TabIndex = 3
        Me.SimpleButton5.Tag = ""
        Me.SimpleButton5.Text = "Delete"
        '
        'GridControl1
        '
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.DataSource = Me.POHeader_SelectBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(12, 34)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LookUpEditVendor, Me.LookUpEditSubAccCOA, Me.ButtonDetail, Me.DateEditPO, Me.RepositoryItemLookUpEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(881, 383)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'POHeader_SelectBindingSource
        '
        Me.POHeader_SelectBindingSource.DataMember = "POHeader_Select"
        Me.POHeader_SelectBindingSource.DataSource = Me.DataSetSPPK
        '
        'DataSetSPPK
        '
        Me.DataSetSPPK.DataSetName = "DataSetSPPK"
        Me.DataSetSPPK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIDVendor, Me.coltglPO, Me.colNoPO, Me.colDescriptionPO, Me.colIDSubAccCOA, Me.colTotal, Me.colAction})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.FindDelay = 100
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 0
        '
        'colIDVendor
        '
        Me.colIDVendor.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colIDVendor.FieldName = "IDVendor"
        Me.colIDVendor.Name = "colIDVendor"
        Me.colIDVendor.Visible = True
        Me.colIDVendor.VisibleIndex = 1
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.SelectVendorBindingSource1
        Me.RepositoryItemLookUpEdit1.DisplayMember = "nama"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "id"
        '
        'SelectVendorBindingSource1
        '
        Me.SelectVendorBindingSource1.DataMember = "SelectVendor"
        Me.SelectVendorBindingSource1.DataSource = Me.DataSetSPPK
        '
        'coltglPO
        '
        Me.coltglPO.FieldName = "tglPO"
        Me.coltglPO.Name = "coltglPO"
        Me.coltglPO.Visible = True
        Me.coltglPO.VisibleIndex = 2
        '
        'colNoPO
        '
        Me.colNoPO.FieldName = "NoPO"
        Me.colNoPO.Name = "colNoPO"
        Me.colNoPO.Visible = True
        Me.colNoPO.VisibleIndex = 3
        '
        'colDescriptionPO
        '
        Me.colDescriptionPO.FieldName = "DescriptionPO"
        Me.colDescriptionPO.Name = "colDescriptionPO"
        Me.colDescriptionPO.Visible = True
        Me.colDescriptionPO.VisibleIndex = 4
        '
        'colIDSubAccCOA
        '
        Me.colIDSubAccCOA.ColumnEdit = Me.LookUpEditSubAccCOA
        Me.colIDSubAccCOA.FieldName = "IDSubAccCOA"
        Me.colIDSubAccCOA.Name = "colIDSubAccCOA"
        Me.colIDSubAccCOA.Visible = True
        Me.colIDSubAccCOA.VisibleIndex = 5
        '
        'LookUpEditSubAccCOA
        '
        Me.LookUpEditSubAccCOA.AutoHeight = False
        Me.LookUpEditSubAccCOA.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditSubAccCOA.DataSource = Me.SelectSubAccCOABindingSource
        Me.LookUpEditSubAccCOA.DisplayMember = "namaSubAccount"
        Me.LookUpEditSubAccCOA.Name = "LookUpEditSubAccCOA"
        Me.LookUpEditSubAccCOA.ValueMember = "id"
        '
        'SelectSubAccCOABindingSource
        '
        Me.SelectSubAccCOABindingSource.DataMember = "SelectSubAccCOA"
        Me.SelectSubAccCOABindingSource.DataSource = Me.DataSetSPPK
        '
        'colTotal
        '
        Me.colTotal.DisplayFormat.FormatString = "n"
        Me.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotal.FieldName = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.Visible = True
        Me.colTotal.VisibleIndex = 6
        '
        'colAction
        '
        Me.colAction.Caption = "Action"
        Me.colAction.ColumnEdit = Me.ButtonDetail
        Me.colAction.Name = "colAction"
        Me.colAction.Visible = True
        Me.colAction.VisibleIndex = 7
        '
        'ButtonDetail
        '
        Me.ButtonDetail.AutoHeight = False
        Me.ButtonDetail.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("ButtonDetail.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.ButtonDetail.Name = "ButtonDetail"
        Me.ButtonDetail.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'LookUpEditVendor
        '
        Me.LookUpEditVendor.AutoHeight = False
        Me.LookUpEditVendor.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditVendor.DataSource = Me.SelectVendorBindingSource
        Me.LookUpEditVendor.DisplayMember = "nama"
        Me.LookUpEditVendor.Name = "LookUpEditVendor"
        Me.LookUpEditVendor.ValueMember = "id"
        '
        'SelectVendorBindingSource
        '
        Me.SelectVendorBindingSource.DataMember = "SelectVendor"
        Me.SelectVendorBindingSource.DataSource = Me.DataSetSPPK
        '
        'DateEditPO
        '
        Me.DateEditPO.AutoHeight = False
        Me.DateEditPO.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditPO.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditPO.Name = "DateEditPO"
        '
        'POHeader_SelectTableAdapter
        '
        Me.POHeader_SelectTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.POHeader_SelectTableAdapter = Me.POHeader_SelectTableAdapter
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
        'SelectVendorTableAdapter
        '
        Me.SelectVendorTableAdapter.ClearBeforeFill = True
        '
        'SelectSubAccCOATableAdapter
        '
        Me.SelectSubAccCOATableAdapter.ClearBeforeFill = True
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
        Me.SimpleButton1.Location = New System.Drawing.Point(177, 5)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(96, 23)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Tag = ""
        Me.SimpleButton1.Text = "Receive Item"
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
        Me.SimpleButton2.Location = New System.Drawing.Point(279, 5)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(110, 23)
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Tag = ""
        Me.SimpleButton2.Text = "Down Payment"
        '
        'HeaderPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 429)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Name = "HeaderPO"
        Me.Tag = "3200"
        Me.Text = "Header PO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POHeader_SelectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetSPPK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectVendorBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditSubAccCOA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectSubAccCOABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditVendor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectVendorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditPO.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditPO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DataSetSPPK As MyTemplate.DataSetSPPK
    Friend WithEvents POHeader_SelectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents POHeader_SelectTableAdapter As MyTemplate.DataSetSPPKTableAdapters.POHeader_SelectTableAdapter
    Friend WithEvents TableAdapterManager As MyTemplate.DataSetSPPKTableAdapters.TableAdapterManager
    Friend WithEvents LookUpEditVendor As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SelectVendorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelectVendorTableAdapter As MyTemplate.DataSetSPPKTableAdapters.SelectVendorTableAdapter
    Friend WithEvents LookUpEditSubAccCOA As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SelectSubAccCOABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelectSubAccCOATableAdapter As MyTemplate.DataSetSPPKTableAdapters.SelectSubAccCOATableAdapter
    Friend WithEvents ButtonDetail As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents DateEditPO As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDVendor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltglPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescriptionPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDSubAccCOA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SelectVendorBindingSource1 As System.Windows.Forms.BindingSource
End Class
