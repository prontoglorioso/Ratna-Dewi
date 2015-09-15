<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HeaderRI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HeaderRI))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.ButtonDetail = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.RIHeader_SelectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetSPPK = New MyTemplate.DataSetSPPK()
        Me.SelectVendorBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SelectSubAccCOABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SelectVendorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RIHeader_SelectTableAdapter = New MyTemplate.DataSetSPPKTableAdapters.RIHeader_SelectTableAdapter()
        Me.TableAdapterManager = New MyTemplate.DataSetSPPKTableAdapters.TableAdapterManager()
        Me.SelectVendorTableAdapter = New MyTemplate.DataSetSPPKTableAdapters.SelectVendorTableAdapter()
        Me.SelectSubAccCOATableAdapter = New MyTemplate.DataSetSPPKTableAdapters.SelectSubAccCOATableAdapter()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDVendor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltglRI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoRI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescriptionRI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDSubAccCOA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisDeleted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ButtonDetailRI = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        CType(Me.ButtonDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RIHeader_SelectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetSPPK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectVendorBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectSubAccCOABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectVendorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonDetailRI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonDetail
        '
        Me.ButtonDetail.AutoHeight = False
        Me.ButtonDetail.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("ButtonDetail.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.ButtonDetail.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
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
        Me.SimpleButton3.Location = New System.Drawing.Point(91, 12)
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
        Me.SimpleButton5.Location = New System.Drawing.Point(8, 12)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton5.TabIndex = 3
        Me.SimpleButton5.Tag = ""
        Me.SimpleButton5.Text = "Delete"
        '
        'RIHeader_SelectBindingSource
        '
        Me.RIHeader_SelectBindingSource.DataMember = "RIHeader_Select"
        Me.RIHeader_SelectBindingSource.DataSource = Me.DataSetSPPK
        '
        'DataSetSPPK
        '
        Me.DataSetSPPK.DataSetName = "DataSetSPPK"
        Me.DataSetSPPK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SelectVendorBindingSource1
        '
        Me.SelectVendorBindingSource1.DataMember = "SelectVendor"
        Me.SelectVendorBindingSource1.DataSource = Me.DataSetSPPK
        '
        'SelectSubAccCOABindingSource
        '
        Me.SelectSubAccCOABindingSource.DataMember = "SelectSubAccCOA"
        Me.SelectSubAccCOABindingSource.DataSource = Me.DataSetSPPK
        '
        'SelectVendorBindingSource
        '
        Me.SelectVendorBindingSource.DataMember = "SelectVendor"
        Me.SelectVendorBindingSource.DataSource = Me.DataSetSPPK
        '
        'RIHeader_SelectTableAdapter
        '
        Me.RIHeader_SelectTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.RIHeader_SelectTableAdapter = Me.RIHeader_SelectTableAdapter
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
        'GridControl1
        '
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.DataSource = Me.RIHeader_SelectBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(8, 41)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ButtonDetailRI})
        Me.GridControl1.Size = New System.Drawing.Size(570, 347)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIDVendor, Me.coltglRI, Me.colNoRI, Me.colDescriptionRI, Me.colIDSubAccCOA, Me.colisDeleted, Me.GridColumn1})
        Me.GridView1.GridControl = Me.GridControl1
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
        'colIDVendor
        '
        Me.colIDVendor.FieldName = "IDVendor"
        Me.colIDVendor.Name = "colIDVendor"
        Me.colIDVendor.Visible = True
        Me.colIDVendor.VisibleIndex = 1
        '
        'coltglRI
        '
        Me.coltglRI.FieldName = "tglRI"
        Me.coltglRI.Name = "coltglRI"
        Me.coltglRI.Visible = True
        Me.coltglRI.VisibleIndex = 2
        '
        'colNoRI
        '
        Me.colNoRI.FieldName = "NoRI"
        Me.colNoRI.Name = "colNoRI"
        Me.colNoRI.Visible = True
        Me.colNoRI.VisibleIndex = 3
        '
        'colDescriptionRI
        '
        Me.colDescriptionRI.FieldName = "DescriptionRI"
        Me.colDescriptionRI.Name = "colDescriptionRI"
        Me.colDescriptionRI.Visible = True
        Me.colDescriptionRI.VisibleIndex = 4
        '
        'colIDSubAccCOA
        '
        Me.colIDSubAccCOA.FieldName = "IDSubAccCOA"
        Me.colIDSubAccCOA.Name = "colIDSubAccCOA"
        Me.colIDSubAccCOA.Visible = True
        Me.colIDSubAccCOA.VisibleIndex = 5
        '
        'colisDeleted
        '
        Me.colisDeleted.FieldName = "isDeleted"
        Me.colisDeleted.Name = "colisDeleted"
        Me.colisDeleted.Visible = True
        Me.colisDeleted.VisibleIndex = 6
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Detail"
        Me.GridColumn1.ColumnEdit = Me.ButtonDetailRI
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 7
        '
        'ButtonDetailRI
        '
        Me.ButtonDetailRI.AutoHeight = False
        Me.ButtonDetailRI.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("ButtonDetailRI.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.ButtonDetailRI.Name = "ButtonDetailRI"
        Me.ButtonDetailRI.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'HeaderRI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 567)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Name = "HeaderRI"
        Me.Tag = "3200"
        Me.Text = "Header RI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ButtonDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RIHeader_SelectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetSPPK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectVendorBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectSubAccCOABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectVendorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonDetailRI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataSetSPPK As MyTemplate.DataSetSPPK
    Friend WithEvents RIHeader_SelectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RIHeader_SelectTableAdapter As MyTemplate.DataSetSPPKTableAdapters.RIHeader_SelectTableAdapter
    Friend WithEvents TableAdapterManager As MyTemplate.DataSetSPPKTableAdapters.TableAdapterManager
    Friend WithEvents ButtonDetail As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents SelectVendorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelectVendorTableAdapter As MyTemplate.DataSetSPPKTableAdapters.SelectVendorTableAdapter
    Friend WithEvents SelectSubAccCOABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelectSubAccCOATableAdapter As MyTemplate.DataSetSPPKTableAdapters.SelectSubAccCOATableAdapter
    Friend WithEvents SelectVendorBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDVendor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltglRI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoRI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescriptionRI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDSubAccCOA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisDeleted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ButtonDetailRI As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
End Class
