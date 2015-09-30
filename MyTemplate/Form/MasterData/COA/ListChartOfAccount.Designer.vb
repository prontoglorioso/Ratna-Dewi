<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListChartOfAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListChartOfAccount))
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.DataSetList = New MyTemplate.DataSetList()
        Me.SP_REPORT_BALANCEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_REPORT_BALANCETableAdapter = New MyTemplate.DataSetListTableAdapters.SP_REPORT_BALANCETableAdapter()
        Me.TableAdapterManager = New MyTemplate.DataSetListTableAdapters.TableAdapterManager()
        Me.SP_REPORT_BALANCEGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnamaSubAccount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDEBET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKREDIT = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.DataSetList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_REPORT_BALANCEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_REPORT_BALANCEGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 5)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(49, 35)
        Me.SimpleButton1.TabIndex = 1
        '
        'DataSetList
        '
        Me.DataSetList.DataSetName = "DataSetList"
        Me.DataSetList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_REPORT_BALANCEBindingSource
        '
        Me.SP_REPORT_BALANCEBindingSource.DataMember = "SP_REPORT_BALANCE"
        Me.SP_REPORT_BALANCEBindingSource.DataSource = Me.DataSetList
        '
        'SP_REPORT_BALANCETableAdapter
        '
        Me.SP_REPORT_BALANCETableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = MyTemplate.DataSetListTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SP_REPORT_BALANCEGridControl
        '
        Me.SP_REPORT_BALANCEGridControl.DataSource = Me.SP_REPORT_BALANCEBindingSource
        Me.SP_REPORT_BALANCEGridControl.Location = New System.Drawing.Point(0, 46)
        Me.SP_REPORT_BALANCEGridControl.MainView = Me.GridView1
        Me.SP_REPORT_BALANCEGridControl.Name = "SP_REPORT_BALANCEGridControl"
        Me.SP_REPORT_BALANCEGridControl.Size = New System.Drawing.Size(712, 220)
        Me.SP_REPORT_BALANCEGridControl.TabIndex = 2
        Me.SP_REPORT_BALANCEGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colnamaSubAccount, Me.colDEBET, Me.colKREDIT})
        Me.GridView1.GridControl = Me.SP_REPORT_BALANCEGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        Me.colid.Visible = True
        Me.colid.VisibleIndex = 0
        '
        'colnamaSubAccount
        '
        Me.colnamaSubAccount.FieldName = "namaSubAccount"
        Me.colnamaSubAccount.Name = "colnamaSubAccount"
        Me.colnamaSubAccount.Visible = True
        Me.colnamaSubAccount.VisibleIndex = 1
        '
        'colDEBET
        '
        Me.colDEBET.DisplayFormat.FormatString = "n"
        Me.colDEBET.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDEBET.FieldName = "DEBET"
        Me.colDEBET.Name = "colDEBET"
        Me.colDEBET.Visible = True
        Me.colDEBET.VisibleIndex = 2
        '
        'colKREDIT
        '
        Me.colKREDIT.DisplayFormat.FormatString = "n"
        Me.colKREDIT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKREDIT.FieldName = "KREDIT"
        Me.colKREDIT.Name = "colKREDIT"
        Me.colKREDIT.Visible = True
        Me.colKREDIT.VisibleIndex = 3
        '
        'ListChartOfAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 489)
        Me.Controls.Add(Me.SP_REPORT_BALANCEGridControl)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Name = "ListChartOfAccount"
        Me.Text = "List Chart Of Account"
        CType(Me.DataSetList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_REPORT_BALANCEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_REPORT_BALANCEGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataSetList As MyTemplate.DataSetList
    Friend WithEvents SP_REPORT_BALANCEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SP_REPORT_BALANCETableAdapter As MyTemplate.DataSetListTableAdapters.SP_REPORT_BALANCETableAdapter
    Friend WithEvents TableAdapterManager As MyTemplate.DataSetListTableAdapters.TableAdapterManager
    Friend WithEvents SP_REPORT_BALANCEGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnamaSubAccount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEBET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKREDIT As DevExpress.XtraGrid.Columns.GridColumn
End Class
