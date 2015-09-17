<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListProject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListProject))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ListProjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetList = New MyTemplate.DataSetList()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnamaKaryawan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colprojectNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colprojectName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcontactName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ListProjectTableAdapter = New MyTemplate.DataSetListTableAdapters.ListProjectTableAdapter()
        Me.TableAdapterManager = New MyTemplate.DataSetListTableAdapters.TableAdapterManager()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListProjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.ListProjectBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(12, 55)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1018, 184)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ListProjectBindingSource
        '
        Me.ListProjectBindingSource.DataMember = "ListProject"
        Me.ListProjectBindingSource.DataSource = Me.DataSetList
        '
        'DataSetList
        '
        Me.DataSetList.DataSetName = "DataSetList"
        Me.DataSetList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnamaKaryawan, Me.colprojectNo, Me.colprojectName, Me.colcontactName, Me.colnama})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colnamaKaryawan
        '
        Me.colnamaKaryawan.FieldName = "namaKaryawan"
        Me.colnamaKaryawan.Name = "colnamaKaryawan"
        Me.colnamaKaryawan.Visible = True
        Me.colnamaKaryawan.VisibleIndex = 0
        '
        'colprojectNo
        '
        Me.colprojectNo.FieldName = "projectNo"
        Me.colprojectNo.Name = "colprojectNo"
        Me.colprojectNo.Visible = True
        Me.colprojectNo.VisibleIndex = 1
        '
        'colprojectName
        '
        Me.colprojectName.FieldName = "projectName"
        Me.colprojectName.Name = "colprojectName"
        Me.colprojectName.Visible = True
        Me.colprojectName.VisibleIndex = 2
        '
        'colcontactName
        '
        Me.colcontactName.FieldName = "contactName"
        Me.colcontactName.Name = "colcontactName"
        Me.colcontactName.Visible = True
        Me.colcontactName.VisibleIndex = 3
        '
        'colnama
        '
        Me.colnama.FieldName = "nama"
        Me.colnama.Name = "colnama"
        Me.colnama.Visible = True
        Me.colnama.VisibleIndex = 4
        '
        'ListProjectTableAdapter
        '
        Me.ListProjectTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = MyTemplate.DataSetListTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(44, 37)
        Me.SimpleButton1.TabIndex = 1
        '
        'ListProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 261)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "ListProject"
        Me.Text = "ListProject"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListProjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DataSetList As MyTemplate.DataSetList
    Friend WithEvents ListProjectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListProjectTableAdapter As MyTemplate.DataSetListTableAdapters.ListProjectTableAdapter
    Friend WithEvents TableAdapterManager As MyTemplate.DataSetListTableAdapters.TableAdapterManager
    Friend WithEvents colnamaKaryawan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colprojectNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colprojectName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcontactName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
