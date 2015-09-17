<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListEmployee))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.DataSetList = New MyTemplate.DataSetList()
        Me.ListEmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListEmployeeTableAdapter = New MyTemplate.DataSetListTableAdapters.ListEmployeeTableAdapter()
        Me.TableAdapterManager = New MyTemplate.DataSetListTableAdapters.TableAdapterManager()
        Me.colnamaJabatan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnamaKaryawan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltglBergabung = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colgajiPokok = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListEmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.ListEmployeeBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(12, 46)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1022, 340)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnamaJabatan, Me.colnamaKaryawan, Me.coltglBergabung, Me.colgajiPokok})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 3)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(44, 37)
        Me.SimpleButton1.TabIndex = 3
        '
        'DataSetList
        '
        Me.DataSetList.DataSetName = "DataSetList"
        Me.DataSetList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListEmployeeBindingSource
        '
        Me.ListEmployeeBindingSource.DataMember = "ListEmployee"
        Me.ListEmployeeBindingSource.DataSource = Me.DataSetList
        '
        'ListEmployeeTableAdapter
        '
        Me.ListEmployeeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = MyTemplate.DataSetListTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'colnamaJabatan
        '
        Me.colnamaJabatan.FieldName = "namaJabatan"
        Me.colnamaJabatan.Name = "colnamaJabatan"
        Me.colnamaJabatan.Visible = True
        Me.colnamaJabatan.VisibleIndex = 0
        '
        'colnamaKaryawan
        '
        Me.colnamaKaryawan.FieldName = "namaKaryawan"
        Me.colnamaKaryawan.Name = "colnamaKaryawan"
        Me.colnamaKaryawan.Visible = True
        Me.colnamaKaryawan.VisibleIndex = 1
        '
        'coltglBergabung
        '
        Me.coltglBergabung.FieldName = "tglBergabung"
        Me.coltglBergabung.Name = "coltglBergabung"
        Me.coltglBergabung.Visible = True
        Me.coltglBergabung.VisibleIndex = 2
        '
        'colgajiPokok
        '
        Me.colgajiPokok.FieldName = "gajiPokok"
        Me.colgajiPokok.Name = "colgajiPokok"
        Me.colgajiPokok.Visible = True
        Me.colgajiPokok.VisibleIndex = 3
        '
        'ListEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 398)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "ListEmployee"
        Me.Text = "ListEmployee"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListEmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataSetList As MyTemplate.DataSetList
    Friend WithEvents ListEmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListEmployeeTableAdapter As MyTemplate.DataSetListTableAdapters.ListEmployeeTableAdapter
    Friend WithEvents TableAdapterManager As MyTemplate.DataSetListTableAdapters.TableAdapterManager
    Friend WithEvents colnamaJabatan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnamaKaryawan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltglBergabung As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colgajiPokok As DevExpress.XtraGrid.Columns.GridColumn
End Class
