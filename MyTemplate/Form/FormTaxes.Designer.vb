<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTaxes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTaxes))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BtnCancelTax = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnSaveTax = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnDelTax = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnEditTax = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnAddTax = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNamaPajak = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNilaiPajak = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDesPajak = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtKodePajak = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LookUpEditSalesTax = New DevExpress.XtraEditors.LookUpEdit()
        Me.LookUpEditPurchaseTax = New DevExpress.XtraEditors.LookUpEdit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNamaPajak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNilaiPajak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesPajak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKodePajak.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditSalesTax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditPurchaseTax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.Location = New System.Drawing.Point(379, 32)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(793, 211)
        Me.GridControl1.TabIndex = 36
        Me.GridControl1.Tag = "view"
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'BtnCancelTax
        '
        Me.BtnCancelTax.Image = CType(resources.GetObject("BtnCancelTax.Image"), System.Drawing.Image)
        Me.BtnCancelTax.Location = New System.Drawing.Point(15, 336)
        Me.BtnCancelTax.Name = "BtnCancelTax"
        Me.BtnCancelTax.Size = New System.Drawing.Size(339, 40)
        Me.BtnCancelTax.TabIndex = 34
        Me.BtnCancelTax.Tag = "cancel"
        Me.BtnCancelTax.Text = "Cancel"
        '
        'BtnSaveTax
        '
        Me.BtnSaveTax.Image = CType(resources.GetObject("BtnSaveTax.Image"), System.Drawing.Image)
        Me.BtnSaveTax.Location = New System.Drawing.Point(274, 258)
        Me.BtnSaveTax.Name = "BtnSaveTax"
        Me.BtnSaveTax.Size = New System.Drawing.Size(80, 40)
        Me.BtnSaveTax.TabIndex = 33
        Me.BtnSaveTax.Tag = "save"
        Me.BtnSaveTax.Text = "Save"
        '
        'BtnDelTax
        '
        Me.BtnDelTax.Image = CType(resources.GetObject("BtnDelTax.Image"), System.Drawing.Image)
        Me.BtnDelTax.Location = New System.Drawing.Point(190, 258)
        Me.BtnDelTax.Name = "BtnDelTax"
        Me.BtnDelTax.Size = New System.Drawing.Size(80, 40)
        Me.BtnDelTax.TabIndex = 32
        Me.BtnDelTax.Tag = "view"
        Me.BtnDelTax.Text = "Delete"
        '
        'BtnEditTax
        '
        Me.BtnEditTax.Image = CType(resources.GetObject("BtnEditTax.Image"), System.Drawing.Image)
        Me.BtnEditTax.Location = New System.Drawing.Point(104, 258)
        Me.BtnEditTax.Name = "BtnEditTax"
        Me.BtnEditTax.Size = New System.Drawing.Size(80, 40)
        Me.BtnEditTax.TabIndex = 30
        Me.BtnEditTax.Tag = "edit"
        Me.BtnEditTax.Text = "Edit"
        '
        'BtnAddTax
        '
        Me.BtnAddTax.Image = CType(resources.GetObject("BtnAddTax.Image"), System.Drawing.Image)
        Me.BtnAddTax.Location = New System.Drawing.Point(15, 258)
        Me.BtnAddTax.Name = "BtnAddTax"
        Me.BtnAddTax.Size = New System.Drawing.Size(80, 40)
        Me.BtnAddTax.TabIndex = 29
        Me.BtnAddTax.Tag = "add"
        Me.BtnAddTax.Text = "Add"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(18, 36)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl1.TabIndex = 31
        Me.LabelControl1.Text = "Name"
        '
        'txtNamaPajak
        '
        Me.txtNamaPajak.Location = New System.Drawing.Point(144, 29)
        Me.txtNamaPajak.Name = "txtNamaPajak"
        Me.txtNamaPajak.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.txtNamaPajak.Properties.MaxLength = 10
        Me.txtNamaPajak.Size = New System.Drawing.Size(220, 20)
        Me.txtNamaPajak.TabIndex = 35
        Me.txtNamaPajak.Tag = "input"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(18, 71)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl2.TabIndex = 37
        Me.LabelControl2.Text = "Rate %"
        '
        'txtNilaiPajak
        '
        Me.txtNilaiPajak.Location = New System.Drawing.Point(144, 64)
        Me.txtNilaiPajak.Name = "txtNilaiPajak"
        Me.txtNilaiPajak.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.txtNilaiPajak.Properties.MaxLength = 2
        Me.txtNilaiPajak.Size = New System.Drawing.Size(220, 20)
        Me.txtNilaiPajak.TabIndex = 38
        Me.txtNilaiPajak.Tag = "input"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(18, 143)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl3.TabIndex = 41
        Me.LabelControl3.Text = "Description"
        '
        'txtDesPajak
        '
        Me.txtDesPajak.Location = New System.Drawing.Point(144, 136)
        Me.txtDesPajak.Name = "txtDesPajak"
        Me.txtDesPajak.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.txtDesPajak.Properties.MaxLength = 50
        Me.txtDesPajak.Size = New System.Drawing.Size(220, 20)
        Me.txtDesPajak.TabIndex = 42
        Me.txtDesPajak.Tag = "input"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(18, 108)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl4.TabIndex = 39
        Me.LabelControl4.Text = "Code"
        '
        'txtKodePajak
        '
        Me.txtKodePajak.Location = New System.Drawing.Point(144, 101)
        Me.txtKodePajak.Name = "txtKodePajak"
        Me.txtKodePajak.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.txtKodePajak.Properties.MaxLength = 1
        Me.txtKodePajak.Size = New System.Drawing.Size(220, 20)
        Me.txtKodePajak.TabIndex = 40
        Me.txtKodePajak.Tag = "input"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(18, 214)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(85, 13)
        Me.LabelControl5.TabIndex = 45
        Me.LabelControl5.Text = "Purchase Tax Acc"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(18, 179)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl6.TabIndex = 43
        Me.LabelControl6.Text = "Sales Tax Code"
        '
        'LookUpEditSalesTax
        '
        Me.LookUpEditSalesTax.Location = New System.Drawing.Point(144, 172)
        Me.LookUpEditSalesTax.Name = "LookUpEditSalesTax"
        Me.LookUpEditSalesTax.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditSalesTax.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.LookUpEditSalesTax.Size = New System.Drawing.Size(220, 20)
        Me.LookUpEditSalesTax.TabIndex = 46
        Me.LookUpEditSalesTax.Tag = "input"
        '
        'LookUpEditPurchaseTax
        '
        Me.LookUpEditPurchaseTax.Location = New System.Drawing.Point(144, 207)
        Me.LookUpEditPurchaseTax.Name = "LookUpEditPurchaseTax"
        Me.LookUpEditPurchaseTax.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditPurchaseTax.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.LookUpEditPurchaseTax.Size = New System.Drawing.Size(220, 20)
        Me.LookUpEditPurchaseTax.TabIndex = 47
        Me.LookUpEditPurchaseTax.Tag = "input"
        '
        'FormTaxes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.LookUpEditPurchaseTax)
        Me.Controls.Add(Me.LookUpEditSalesTax)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtDesPajak)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtKodePajak)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtNilaiPajak)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.BtnCancelTax)
        Me.Controls.Add(Me.BtnSaveTax)
        Me.Controls.Add(Me.BtnDelTax)
        Me.Controls.Add(Me.BtnEditTax)
        Me.Controls.Add(Me.BtnAddTax)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtNamaPajak)
        Me.Name = "FormTaxes"
        Me.Tag = "1100"
        Me.Text = "FormTaxes"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNamaPajak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNilaiPajak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesPajak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKodePajak.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditSalesTax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditPurchaseTax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BtnCancelTax As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnSaveTax As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnDelTax As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEditTax As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnAddTax As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNamaPajak As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNilaiPajak As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDesPajak As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtKodePajak As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LookUpEditSalesTax As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LookUpEditPurchaseTax As DevExpress.XtraEditors.LookUpEdit
End Class
