﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListCustomer))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ListCustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetList = New MyTemplate.DataSetList()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkodeCustomer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colalamat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltelp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcontactPerson = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colhandphone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colemail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNPWP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstatusPajak = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisDeleted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ListCustomerTableAdapter = New MyTemplate.DataSetListTableAdapters.ListCustomerTableAdapter()
        Me.TableAdapterManager = New MyTemplate.DataSetListTableAdapters.TableAdapterManager()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListCustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.ListCustomerBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(12, 44)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1016, 269)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ListCustomerBindingSource
        '
        Me.ListCustomerBindingSource.DataMember = "ListCustomer"
        Me.ListCustomerBindingSource.DataSource = Me.DataSetList
        '
        'DataSetList
        '
        Me.DataSetList.DataSetName = "DataSetList"
        Me.DataSetList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colkodeCustomer, Me.colnama, Me.colalamat, Me.coltelp, Me.colfax, Me.colcontactPerson, Me.colhandphone, Me.colemail, Me.colNPWP, Me.colstatusPajak, Me.colisDeleted})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        Me.colid.Visible = True
        Me.colid.VisibleIndex = 0
        '
        'colkodeCustomer
        '
        Me.colkodeCustomer.FieldName = "kodeCustomer"
        Me.colkodeCustomer.Name = "colkodeCustomer"
        Me.colkodeCustomer.Visible = True
        Me.colkodeCustomer.VisibleIndex = 1
        '
        'colnama
        '
        Me.colnama.FieldName = "nama"
        Me.colnama.Name = "colnama"
        Me.colnama.Visible = True
        Me.colnama.VisibleIndex = 2
        '
        'colalamat
        '
        Me.colalamat.FieldName = "alamat"
        Me.colalamat.Name = "colalamat"
        Me.colalamat.Visible = True
        Me.colalamat.VisibleIndex = 3
        '
        'coltelp
        '
        Me.coltelp.FieldName = "telp"
        Me.coltelp.Name = "coltelp"
        Me.coltelp.Visible = True
        Me.coltelp.VisibleIndex = 4
        '
        'colfax
        '
        Me.colfax.FieldName = "fax"
        Me.colfax.Name = "colfax"
        Me.colfax.Visible = True
        Me.colfax.VisibleIndex = 5
        '
        'colcontactPerson
        '
        Me.colcontactPerson.FieldName = "contactPerson"
        Me.colcontactPerson.Name = "colcontactPerson"
        Me.colcontactPerson.Visible = True
        Me.colcontactPerson.VisibleIndex = 6
        '
        'colhandphone
        '
        Me.colhandphone.FieldName = "handphone"
        Me.colhandphone.Name = "colhandphone"
        Me.colhandphone.Visible = True
        Me.colhandphone.VisibleIndex = 7
        '
        'colemail
        '
        Me.colemail.FieldName = "email"
        Me.colemail.Name = "colemail"
        Me.colemail.Visible = True
        Me.colemail.VisibleIndex = 8
        '
        'colNPWP
        '
        Me.colNPWP.FieldName = "NPWP"
        Me.colNPWP.Name = "colNPWP"
        Me.colNPWP.Visible = True
        Me.colNPWP.VisibleIndex = 9
        '
        'colstatusPajak
        '
        Me.colstatusPajak.FieldName = "statusPajak"
        Me.colstatusPajak.Name = "colstatusPajak"
        Me.colstatusPajak.Visible = True
        Me.colstatusPajak.VisibleIndex = 10
        '
        'colisDeleted
        '
        Me.colisDeleted.FieldName = "isDeleted"
        Me.colisDeleted.Name = "colisDeleted"
        Me.colisDeleted.Visible = True
        Me.colisDeleted.VisibleIndex = 11
        '
        'ListCustomerTableAdapter
        '
        Me.ListCustomerTableAdapter.ClearBeforeFill = True
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
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 1)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(44, 37)
        Me.SimpleButton1.TabIndex = 2
        '
        'ListCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 423)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "ListCustomer"
        Me.Text = "ListCustomer"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListCustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DataSetList As MyTemplate.DataSetList
    Friend WithEvents ListCustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListCustomerTableAdapter As MyTemplate.DataSetListTableAdapters.ListCustomerTableAdapter
    Friend WithEvents TableAdapterManager As MyTemplate.DataSetListTableAdapters.TableAdapterManager
    Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkodeCustomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colalamat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltelp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcontactPerson As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colhandphone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colemail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNPWP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstatusPajak As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisDeleted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
