﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HeaderSR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HeaderSR))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.SRHeader_SelectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetSPPK = New MyTemplate.DataSetSPPK()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDCustomer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltglSR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoSR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescriptionSR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDSubAccCOA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisDeleted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SRHeader_SelectTableAdapter = New MyTemplate.DataSetSPPKTableAdapters.SRHeader_SelectTableAdapter()
        Me.TableAdapterManager = New MyTemplate.DataSetSPPKTableAdapters.TableAdapterManager()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ButtonDetail = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SRHeader_SelectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetSPPK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonDetail, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SimpleButton3.Location = New System.Drawing.Point(93, 12)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(76, 23)
        Me.SimpleButton3.TabIndex = 2
        Me.SimpleButton3.Tag = "save"
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
        Me.SimpleButton5.Location = New System.Drawing.Point(10, 12)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton5.TabIndex = 3
        Me.SimpleButton5.Tag = "view"
        Me.SimpleButton5.Text = "Delete"
        '
        'GridControl1
        '
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.DataSource = Me.SRHeader_SelectBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(10, 41)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ButtonDetail})
        Me.GridControl1.Size = New System.Drawing.Size(566, 387)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'SRHeader_SelectBindingSource
        '
        Me.SRHeader_SelectBindingSource.DataMember = "SRHeader_Select"
        Me.SRHeader_SelectBindingSource.DataSource = Me.DataSetSPPK
        '
        'DataSetSPPK
        '
        Me.DataSetSPPK.DataSetName = "DataSetSPPK"
        Me.DataSetSPPK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIDCustomer, Me.coltglSR, Me.colNoSR, Me.colDescriptionSR, Me.colIDSubAccCOA, Me.colAmount, Me.colisDeleted, Me.GridColumn1})
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
        'colIDCustomer
        '
        Me.colIDCustomer.FieldName = "IDCustomer"
        Me.colIDCustomer.Name = "colIDCustomer"
        Me.colIDCustomer.Visible = True
        Me.colIDCustomer.VisibleIndex = 1
        '
        'coltglSR
        '
        Me.coltglSR.FieldName = "tglSR"
        Me.coltglSR.Name = "coltglSR"
        Me.coltglSR.Visible = True
        Me.coltglSR.VisibleIndex = 2
        '
        'colNoSR
        '
        Me.colNoSR.FieldName = "NoSR"
        Me.colNoSR.Name = "colNoSR"
        Me.colNoSR.Visible = True
        Me.colNoSR.VisibleIndex = 3
        '
        'colDescriptionSR
        '
        Me.colDescriptionSR.FieldName = "DescriptionSR"
        Me.colDescriptionSR.Name = "colDescriptionSR"
        Me.colDescriptionSR.Visible = True
        Me.colDescriptionSR.VisibleIndex = 4
        '
        'colIDSubAccCOA
        '
        Me.colIDSubAccCOA.FieldName = "IDSubAccCOA"
        Me.colIDSubAccCOA.Name = "colIDSubAccCOA"
        Me.colIDSubAccCOA.Visible = True
        Me.colIDSubAccCOA.VisibleIndex = 5
        '
        'colAmount
        '
        Me.colAmount.FieldName = "Amount"
        Me.colAmount.Name = "colAmount"
        Me.colAmount.Visible = True
        Me.colAmount.VisibleIndex = 6
        '
        'colisDeleted
        '
        Me.colisDeleted.FieldName = "isDeleted"
        Me.colisDeleted.Name = "colisDeleted"
        Me.colisDeleted.Visible = True
        Me.colisDeleted.VisibleIndex = 7
        '
        'SRHeader_SelectTableAdapter
        '
        Me.SRHeader_SelectTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.RIHeader_SelectTableAdapter = Nothing
        Me.TableAdapterManager.SIDetail_SelectTableAdapter = Nothing
        Me.TableAdapterManager.SIHeader_SelectTableAdapter = Nothing
        Me.TableAdapterManager.SODetail_SelectTableAdapter = Nothing
        Me.TableAdapterManager.SOHeader_SelectTableAdapter = Nothing
        Me.TableAdapterManager.SRDetail_SelectTableAdapter = Nothing
        Me.TableAdapterManager.SRHeader_SelectTableAdapter = Me.SRHeader_SelectTableAdapter
        Me.TableAdapterManager.UpdateOrder = MyTemplate.DataSetSPPKTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Detail"
        Me.GridColumn1.ColumnEdit = Me.ButtonDetail
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 8
        '
        'ButtonDetail
        '
        Me.ButtonDetail.AutoHeight = False
        Me.ButtonDetail.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("ButtonDetail.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.ButtonDetail.Name = "ButtonDetail"
        Me.ButtonDetail.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'HeaderSR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 515)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Name = "HeaderSR"
        Me.Tag = "3200"
        Me.Text = "HeaderSR"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SRHeader_SelectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetSPPK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DataSetSPPK As MyTemplate.DataSetSPPK
    Friend WithEvents SRHeader_SelectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SRHeader_SelectTableAdapter As MyTemplate.DataSetSPPKTableAdapters.SRHeader_SelectTableAdapter
    Friend WithEvents TableAdapterManager As MyTemplate.DataSetSPPKTableAdapters.TableAdapterManager
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDCustomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltglSR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoSR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescriptionSR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDSubAccCOA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisDeleted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ButtonDetail As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
End Class
