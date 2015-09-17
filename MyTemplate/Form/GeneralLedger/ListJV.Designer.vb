<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListJV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListJV))
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DataSetList = New MyTemplate.DataSetList()
        Me.ListJVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListJVTableAdapter = New MyTemplate.DataSetListTableAdapters.ListJVTableAdapter()
        Me.TableAdapterManager = New MyTemplate.DataSetListTableAdapters.TableAdapterManager()
        Me.colJVDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJVNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescriptionJV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnamaSubAccount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDebit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCredit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colprojectName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkodeCustomer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnamaKaryawan = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListJVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(44, 37)
        Me.SimpleButton1.TabIndex = 4
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.ListJVBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(12, 55)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1011, 432)
        Me.GridControl1.TabIndex = 5
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colJVDate, Me.colJVNo, Me.colDescriptionJV, Me.colnamaSubAccount, Me.colDebit, Me.colCredit, Me.colprojectName, Me.colkodeCustomer, Me.colnama, Me.colnamaKaryawan})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'DataSetList
        '
        Me.DataSetList.DataSetName = "DataSetList"
        Me.DataSetList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListJVBindingSource
        '
        Me.ListJVBindingSource.DataMember = "ListJV"
        Me.ListJVBindingSource.DataSource = Me.DataSetList
        '
        'ListJVTableAdapter
        '
        Me.ListJVTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = MyTemplate.DataSetListTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'colJVDate
        '
        Me.colJVDate.FieldName = "JVDate"
        Me.colJVDate.Name = "colJVDate"
        Me.colJVDate.Visible = True
        Me.colJVDate.VisibleIndex = 0
        '
        'colJVNo
        '
        Me.colJVNo.FieldName = "JVNo"
        Me.colJVNo.Name = "colJVNo"
        Me.colJVNo.Visible = True
        Me.colJVNo.VisibleIndex = 1
        '
        'colDescriptionJV
        '
        Me.colDescriptionJV.FieldName = "DescriptionJV"
        Me.colDescriptionJV.Name = "colDescriptionJV"
        Me.colDescriptionJV.Visible = True
        Me.colDescriptionJV.VisibleIndex = 2
        '
        'colnamaSubAccount
        '
        Me.colnamaSubAccount.FieldName = "namaSubAccount"
        Me.colnamaSubAccount.Name = "colnamaSubAccount"
        Me.colnamaSubAccount.Visible = True
        Me.colnamaSubAccount.VisibleIndex = 3
        '
        'colDebit
        '
        Me.colDebit.FieldName = "Debit"
        Me.colDebit.Name = "colDebit"
        Me.colDebit.Visible = True
        Me.colDebit.VisibleIndex = 4
        '
        'colCredit
        '
        Me.colCredit.FieldName = "Credit"
        Me.colCredit.Name = "colCredit"
        Me.colCredit.Visible = True
        Me.colCredit.VisibleIndex = 5
        '
        'colprojectName
        '
        Me.colprojectName.FieldName = "projectName"
        Me.colprojectName.Name = "colprojectName"
        Me.colprojectName.Visible = True
        Me.colprojectName.VisibleIndex = 6
        '
        'colkodeCustomer
        '
        Me.colkodeCustomer.FieldName = "kodeCustomer"
        Me.colkodeCustomer.Name = "colkodeCustomer"
        Me.colkodeCustomer.Visible = True
        Me.colkodeCustomer.VisibleIndex = 7
        '
        'colnama
        '
        Me.colnama.FieldName = "nama"
        Me.colnama.Name = "colnama"
        Me.colnama.Visible = True
        Me.colnama.VisibleIndex = 8
        '
        'colnamaKaryawan
        '
        Me.colnamaKaryawan.FieldName = "namaKaryawan"
        Me.colnamaKaryawan.Name = "colnamaKaryawan"
        Me.colnamaKaryawan.Visible = True
        Me.colnamaKaryawan.VisibleIndex = 9
        '
        'ListJV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1035, 499)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Name = "ListJV"
        Me.Text = "ListJV"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListJVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DataSetList As MyTemplate.DataSetList
    Friend WithEvents ListJVBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListJVTableAdapter As MyTemplate.DataSetListTableAdapters.ListJVTableAdapter
    Friend WithEvents TableAdapterManager As MyTemplate.DataSetListTableAdapters.TableAdapterManager
    Friend WithEvents colJVDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJVNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescriptionJV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnamaSubAccount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDebit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCredit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colprojectName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkodeCustomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnamaKaryawan As DevExpress.XtraGrid.Columns.GridColumn
End Class
