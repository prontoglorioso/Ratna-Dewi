<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HeaderJV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HeaderJV))
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.DataSetJournalVoucher = New MyTemplate.DataSetJournalVoucher()
        Me.JVHeaderDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JVHeaderTableAdapter = New MyTemplate.DataSetJournalVoucherTableAdapters.JVHeaderTableAdapter()
        Me.TableAdapterManager = New MyTemplate.DataSetJournalVoucherTableAdapters.TableAdapterManager()
        Me.JVHeaderDataTableGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJVNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJVDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescriptionJV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ButtonDetail = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.DataSetJournalVoucher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JVHeaderDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JVHeaderDataTableGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetJournalVoucher
        '
        Me.DataSetJournalVoucher.DataSetName = "DataSetJournalVoucher"
        Me.DataSetJournalVoucher.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JVHeaderDataTableBindingSource
        '
        Me.JVHeaderDataTableBindingSource.DataMember = "JVHeaderDataTable"
        Me.JVHeaderDataTableBindingSource.DataSource = Me.DataSetJournalVoucher
        '
        'JVHeaderTableAdapter
        '
        Me.JVHeaderTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.JVHeaderTableAdapter = Me.JVHeaderTableAdapter
        Me.TableAdapterManager.UpdateOrder = MyTemplate.DataSetJournalVoucherTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'JVHeaderDataTableGridControl
        '
        Me.JVHeaderDataTableGridControl.DataSource = Me.JVHeaderDataTableBindingSource
        Me.JVHeaderDataTableGridControl.Location = New System.Drawing.Point(12, 34)
        Me.JVHeaderDataTableGridControl.MainView = Me.GridView1
        Me.JVHeaderDataTableGridControl.Name = "JVHeaderDataTableGridControl"
        Me.JVHeaderDataTableGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.ButtonDetail})
        Me.JVHeaderDataTableGridControl.Size = New System.Drawing.Size(820, 220)
        Me.JVHeaderDataTableGridControl.TabIndex = 1
        Me.JVHeaderDataTableGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colJVNo, Me.colJVDate, Me.colDescriptionJV, Me.GridColumn1})
        Me.GridView1.GridControl = Me.JVHeaderDataTableGridControl
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
        'colJVNo
        '
        Me.colJVNo.FieldName = "JVNo"
        Me.colJVNo.Name = "colJVNo"
        Me.colJVNo.Visible = True
        Me.colJVNo.VisibleIndex = 1
        '
        'colJVDate
        '
        Me.colJVDate.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.colJVDate.FieldName = "JVDate"
        Me.colJVDate.Name = "colJVDate"
        Me.colJVDate.Visible = True
        Me.colJVDate.VisibleIndex = 2
        '
        'colDescriptionJV
        '
        Me.colDescriptionJV.FieldName = "DescriptionJV"
        Me.colDescriptionJV.Name = "colDescriptionJV"
        Me.colDescriptionJV.Visible = True
        Me.colDescriptionJV.VisibleIndex = 3
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Detail"
        Me.GridColumn1.ColumnEdit = Me.ButtonDetail
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 4
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
        Me.SimpleButton3.TabIndex = 8
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
        Me.SimpleButton5.TabIndex = 9
        Me.SimpleButton5.Tag = ""
        Me.SimpleButton5.Text = "Delete"
        '
        'HeaderJV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 423)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Controls.Add(Me.JVHeaderDataTableGridControl)
        Me.Name = "HeaderJV"
        Me.Text = "JournalVoucher"
        CType(Me.DataSetJournalVoucher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JVHeaderDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JVHeaderDataTableGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents JVHeader_SelectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetJournalVoucher As MyTemplate.DataSetJournalVoucher
    Friend WithEvents JVHeaderDataTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JVHeaderTableAdapter As MyTemplate.DataSetJournalVoucherTableAdapters.JVHeaderTableAdapter
    Friend WithEvents TableAdapterManager As MyTemplate.DataSetJournalVoucherTableAdapters.TableAdapterManager
    Friend WithEvents JVHeaderDataTableGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJVNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJVDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents colDescriptionJV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ButtonDetail As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    'Friend WithEvents JVHeader_SelectTableAdapter As MyTemplate.DataSetJournalVoucherTableAdapters.JVHeader_SelectTableAdapter
End Class
