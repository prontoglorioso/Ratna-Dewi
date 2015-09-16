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
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.DataSetList = New MyTemplate.DataSetList()
        Me.ListSubAccountCOABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListSubAccountCOATableAdapter = New MyTemplate.DataSetListTableAdapters.ListSubAccountCOATableAdapter()
        Me.TableAdapterManager = New MyTemplate.DataSetListTableAdapters.TableAdapterManager()
        Me.colname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkodeAccount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnamaTypeAccount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkodeParentAccount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnamaParentAccount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coljenisTransaksi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkodeSubAccount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnamaSubAccount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colopeningBalanceDate = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListSubAccountCOABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.ListSubAccountCOABindingSource
        Me.GridControl1.Location = New System.Drawing.Point(-1, 46)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(897, 419)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colname, Me.colkodeAccount, Me.colnamaTypeAccount, Me.colkodeParentAccount, Me.colnamaParentAccount, Me.coljenisTransaksi, Me.colkodeSubAccount, Me.colnamaSubAccount, Me.colstatus, Me.colbalance, Me.colopeningBalanceDate})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
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
        'ListSubAccountCOABindingSource
        '
        Me.ListSubAccountCOABindingSource.DataMember = "ListSubAccountCOA"
        Me.ListSubAccountCOABindingSource.DataSource = Me.DataSetList
        '
        'ListSubAccountCOATableAdapter
        '
        Me.ListSubAccountCOATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = MyTemplate.DataSetListTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'colname
        '
        Me.colname.FieldName = "name"
        Me.colname.Name = "colname"
        Me.colname.Visible = True
        Me.colname.VisibleIndex = 0
        '
        'colkodeAccount
        '
        Me.colkodeAccount.FieldName = "kodeAccount"
        Me.colkodeAccount.Name = "colkodeAccount"
        Me.colkodeAccount.Visible = True
        Me.colkodeAccount.VisibleIndex = 1
        '
        'colnamaTypeAccount
        '
        Me.colnamaTypeAccount.FieldName = "namaTypeAccount"
        Me.colnamaTypeAccount.Name = "colnamaTypeAccount"
        Me.colnamaTypeAccount.Visible = True
        Me.colnamaTypeAccount.VisibleIndex = 2
        '
        'colkodeParentAccount
        '
        Me.colkodeParentAccount.FieldName = "kodeParentAccount"
        Me.colkodeParentAccount.Name = "colkodeParentAccount"
        Me.colkodeParentAccount.Visible = True
        Me.colkodeParentAccount.VisibleIndex = 3
        '
        'colnamaParentAccount
        '
        Me.colnamaParentAccount.FieldName = "namaParentAccount"
        Me.colnamaParentAccount.Name = "colnamaParentAccount"
        Me.colnamaParentAccount.Visible = True
        Me.colnamaParentAccount.VisibleIndex = 4
        '
        'coljenisTransaksi
        '
        Me.coljenisTransaksi.FieldName = "jenisTransaksi"
        Me.coljenisTransaksi.Name = "coljenisTransaksi"
        Me.coljenisTransaksi.Visible = True
        Me.coljenisTransaksi.VisibleIndex = 5
        '
        'colkodeSubAccount
        '
        Me.colkodeSubAccount.FieldName = "kodeSubAccount"
        Me.colkodeSubAccount.Name = "colkodeSubAccount"
        Me.colkodeSubAccount.Visible = True
        Me.colkodeSubAccount.VisibleIndex = 6
        '
        'colnamaSubAccount
        '
        Me.colnamaSubAccount.FieldName = "namaSubAccount"
        Me.colnamaSubAccount.Name = "colnamaSubAccount"
        Me.colnamaSubAccount.Visible = True
        Me.colnamaSubAccount.VisibleIndex = 7
        '
        'colstatus
        '
        Me.colstatus.FieldName = "status"
        Me.colstatus.Name = "colstatus"
        Me.colstatus.Visible = True
        Me.colstatus.VisibleIndex = 8
        '
        'colbalance
        '
        Me.colbalance.FieldName = "balance"
        Me.colbalance.Name = "colbalance"
        Me.colbalance.Visible = True
        Me.colbalance.VisibleIndex = 9
        '
        'colopeningBalanceDate
        '
        Me.colopeningBalanceDate.FieldName = "openingBalanceDate"
        Me.colopeningBalanceDate.Name = "colopeningBalanceDate"
        Me.colopeningBalanceDate.Visible = True
        Me.colopeningBalanceDate.VisibleIndex = 10
        '
        'ListChartOfAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 489)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "ListChartOfAccount"
        Me.Text = "List Chart Of Account"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListSubAccountCOABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataSetList As MyTemplate.DataSetList
    Friend WithEvents ListSubAccountCOABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListSubAccountCOATableAdapter As MyTemplate.DataSetListTableAdapters.ListSubAccountCOATableAdapter
    Friend WithEvents TableAdapterManager As MyTemplate.DataSetListTableAdapters.TableAdapterManager
    Friend WithEvents colname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkodeAccount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnamaTypeAccount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkodeParentAccount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnamaParentAccount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coljenisTransaksi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkodeSubAccount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnamaSubAccount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colopeningBalanceDate As DevExpress.XtraGrid.Columns.GridColumn
End Class
