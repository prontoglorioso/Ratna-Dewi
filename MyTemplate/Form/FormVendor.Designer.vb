<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVendor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVendor))
        Me.BtnAddVendor = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnEditVendor = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnDelVendor = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnSaveVendor = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnCancelVendor = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtKodeVendor = New DevExpress.XtraEditors.TextEdit()
        Me.txtNamaVendor = New DevExpress.XtraEditors.TextEdit()
        Me.txtTelpVendor = New DevExpress.XtraEditors.TextEdit()
        Me.txtAlamatVendor = New DevExpress.XtraEditors.TextEdit()
        Me.txtEmailVendor = New DevExpress.XtraEditors.TextEdit()
        Me.txtHpVendor = New DevExpress.XtraEditors.TextEdit()
        Me.txtNpwpVendor = New DevExpress.XtraEditors.TextEdit()
        Me.txtContactVendor = New DevExpress.XtraEditors.TextEdit()
        Me.txtFaxVendor = New DevExpress.XtraEditors.TextEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RadioTax = New DevExpress.XtraEditors.RadioGroup()
        CType(Me.txtKodeVendor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNamaVendor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelpVendor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlamatVendor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmailVendor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHpVendor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNpwpVendor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContactVendor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFaxVendor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioTax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnAddVendor
        '
        Me.BtnAddVendor.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddVendor.Appearance.Options.UseFont = True
        Me.BtnAddVendor.Image = CType(resources.GetObject("BtnAddVendor.Image"), System.Drawing.Image)
        Me.BtnAddVendor.Location = New System.Drawing.Point(884, 24)
        Me.BtnAddVendor.Name = "BtnAddVendor"
        Me.BtnAddVendor.Size = New System.Drawing.Size(80, 40)
        Me.BtnAddVendor.TabIndex = 1
        Me.BtnAddVendor.Tag = "add"
        Me.BtnAddVendor.Text = "Add"
        '
        'BtnEditVendor
        '
        Me.BtnEditVendor.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditVendor.Appearance.Options.UseFont = True
        Me.BtnEditVendor.Image = CType(resources.GetObject("BtnEditVendor.Image"), System.Drawing.Image)
        Me.BtnEditVendor.Location = New System.Drawing.Point(984, 24)
        Me.BtnEditVendor.Name = "BtnEditVendor"
        Me.BtnEditVendor.Size = New System.Drawing.Size(80, 40)
        Me.BtnEditVendor.TabIndex = 2
        Me.BtnEditVendor.Tag = "edit"
        Me.BtnEditVendor.Text = "Edit"
        '
        'BtnDelVendor
        '
        Me.BtnDelVendor.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelVendor.Appearance.Options.UseFont = True
        Me.BtnDelVendor.Image = CType(resources.GetObject("BtnDelVendor.Image"), System.Drawing.Image)
        Me.BtnDelVendor.Location = New System.Drawing.Point(884, 79)
        Me.BtnDelVendor.Name = "BtnDelVendor"
        Me.BtnDelVendor.Size = New System.Drawing.Size(80, 40)
        Me.BtnDelVendor.TabIndex = 3
        Me.BtnDelVendor.Tag = "view"
        Me.BtnDelVendor.Text = "Delete"
        '
        'BtnSaveVendor
        '
        Me.BtnSaveVendor.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveVendor.Appearance.Options.UseFont = True
        Me.BtnSaveVendor.Image = CType(resources.GetObject("BtnSaveVendor.Image"), System.Drawing.Image)
        Me.BtnSaveVendor.Location = New System.Drawing.Point(984, 79)
        Me.BtnSaveVendor.Name = "BtnSaveVendor"
        Me.BtnSaveVendor.Size = New System.Drawing.Size(80, 40)
        Me.BtnSaveVendor.TabIndex = 4
        Me.BtnSaveVendor.Tag = "save"
        Me.BtnSaveVendor.Text = "Save"
        '
        'BtnCancelVendor
        '
        Me.BtnCancelVendor.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelVendor.Appearance.Options.UseFont = True
        Me.BtnCancelVendor.Image = CType(resources.GetObject("BtnCancelVendor.Image"), System.Drawing.Image)
        Me.BtnCancelVendor.Location = New System.Drawing.Point(884, 125)
        Me.BtnCancelVendor.Name = "BtnCancelVendor"
        Me.BtnCancelVendor.Size = New System.Drawing.Size(180, 40)
        Me.BtnCancelVendor.TabIndex = 5
        Me.BtnCancelVendor.Tag = "cancel"
        Me.BtnCancelVendor.Text = "Cancel"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(21, 32)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl1.TabIndex = 16
        Me.LabelControl1.Text = "Vendor Code"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(21, 148)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Fax."
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(448, 120)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl3.TabIndex = 23
        Me.LabelControl3.Text = "NPWP No."
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(448, 91)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl4.TabIndex = 22
        Me.LabelControl4.Text = "Email"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(21, 91)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl5.TabIndex = 18
        Me.LabelControl5.Text = "Address"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(448, 148)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl6.TabIndex = 24
        Me.LabelControl6.Text = "Tax Status"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(448, 62)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl7.TabIndex = 21
        Me.LabelControl7.Text = "Handphone"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(448, 32)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl8.TabIndex = 20
        Me.LabelControl8.Text = "Contact Person"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(21, 120)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl10.TabIndex = 19
        Me.LabelControl10.Text = "Telp."
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Location = New System.Drawing.Point(21, 62)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl11.TabIndex = 17
        Me.LabelControl11.Text = "Vendor Name"
        '
        'txtKodeVendor
        '
        Me.txtKodeVendor.Location = New System.Drawing.Point(117, 29)
        Me.txtKodeVendor.Name = "txtKodeVendor"
        Me.txtKodeVendor.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeVendor.Properties.Appearance.Options.UseFont = True
        Me.txtKodeVendor.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.txtKodeVendor.Properties.MaxLength = 10
        Me.txtKodeVendor.Size = New System.Drawing.Size(300, 20)
        Me.txtKodeVendor.TabIndex = 6
        Me.txtKodeVendor.Tag = "input"
        '
        'txtNamaVendor
        '
        Me.txtNamaVendor.Location = New System.Drawing.Point(117, 59)
        Me.txtNamaVendor.Name = "txtNamaVendor"
        Me.txtNamaVendor.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaVendor.Properties.Appearance.Options.UseFont = True
        Me.txtNamaVendor.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.txtNamaVendor.Properties.MaxLength = 50
        Me.txtNamaVendor.Size = New System.Drawing.Size(300, 20)
        Me.txtNamaVendor.TabIndex = 7
        Me.txtNamaVendor.Tag = "input"
        '
        'txtTelpVendor
        '
        Me.txtTelpVendor.Location = New System.Drawing.Point(117, 117)
        Me.txtTelpVendor.Name = "txtTelpVendor"
        Me.txtTelpVendor.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelpVendor.Properties.Appearance.Options.UseFont = True
        Me.txtTelpVendor.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.txtTelpVendor.Properties.MaxLength = 12
        Me.txtTelpVendor.Size = New System.Drawing.Size(300, 20)
        Me.txtTelpVendor.TabIndex = 9
        Me.txtTelpVendor.Tag = "input"
        '
        'txtAlamatVendor
        '
        Me.txtAlamatVendor.Location = New System.Drawing.Point(117, 88)
        Me.txtAlamatVendor.Name = "txtAlamatVendor"
        Me.txtAlamatVendor.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlamatVendor.Properties.Appearance.Options.UseFont = True
        Me.txtAlamatVendor.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.txtAlamatVendor.Properties.MaxLength = 50
        Me.txtAlamatVendor.Size = New System.Drawing.Size(300, 20)
        Me.txtAlamatVendor.TabIndex = 8
        Me.txtAlamatVendor.Tag = "input"
        '
        'txtEmailVendor
        '
        Me.txtEmailVendor.Location = New System.Drawing.Point(549, 81)
        Me.txtEmailVendor.Name = "txtEmailVendor"
        Me.txtEmailVendor.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailVendor.Properties.Appearance.Options.UseFont = True
        Me.txtEmailVendor.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.txtEmailVendor.Properties.MaxLength = 50
        Me.txtEmailVendor.Size = New System.Drawing.Size(300, 20)
        Me.txtEmailVendor.TabIndex = 13
        Me.txtEmailVendor.Tag = "input"
        '
        'txtHpVendor
        '
        Me.txtHpVendor.Location = New System.Drawing.Point(549, 55)
        Me.txtHpVendor.Name = "txtHpVendor"
        Me.txtHpVendor.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHpVendor.Properties.Appearance.Options.UseFont = True
        Me.txtHpVendor.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.txtHpVendor.Properties.MaxLength = 14
        Me.txtHpVendor.Size = New System.Drawing.Size(300, 20)
        Me.txtHpVendor.TabIndex = 12
        Me.txtHpVendor.Tag = "input"
        '
        'txtNpwpVendor
        '
        Me.txtNpwpVendor.Location = New System.Drawing.Point(549, 110)
        Me.txtNpwpVendor.Name = "txtNpwpVendor"
        Me.txtNpwpVendor.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNpwpVendor.Properties.Appearance.Options.UseFont = True
        Me.txtNpwpVendor.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.txtNpwpVendor.Properties.Mask.EditMask = "\d{2}\.\d{3}\.\d{3}\.\d{1}-\d{3}\.\d{3}"
        Me.txtNpwpVendor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
        Me.txtNpwpVendor.Properties.Mask.ShowPlaceHolders = False
        Me.txtNpwpVendor.Size = New System.Drawing.Size(300, 20)
        Me.txtNpwpVendor.TabIndex = 14
        Me.txtNpwpVendor.Tag = "input"
        '
        'txtContactVendor
        '
        Me.txtContactVendor.Location = New System.Drawing.Point(549, 29)
        Me.txtContactVendor.Name = "txtContactVendor"
        Me.txtContactVendor.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactVendor.Properties.Appearance.Options.UseFont = True
        Me.txtContactVendor.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.txtContactVendor.Properties.MaxLength = 50
        Me.txtContactVendor.Size = New System.Drawing.Size(300, 20)
        Me.txtContactVendor.TabIndex = 11
        Me.txtContactVendor.Tag = "input"
        '
        'txtFaxVendor
        '
        Me.txtFaxVendor.Location = New System.Drawing.Point(117, 149)
        Me.txtFaxVendor.Name = "txtFaxVendor"
        Me.txtFaxVendor.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFaxVendor.Properties.Appearance.Options.UseFont = True
        Me.txtFaxVendor.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.txtFaxVendor.Properties.MaxLength = 12
        Me.txtFaxVendor.Size = New System.Drawing.Size(300, 20)
        Me.txtFaxVendor.TabIndex = 10
        Me.txtFaxVendor.Tag = "input"
        '
        'GridControl1
        '
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridControl1.Location = New System.Drawing.Point(21, 179)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1200, 300)
        Me.GridControl1.TabIndex = 27
        Me.GridControl1.Tag = "view"
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'RadioTax
        '
        Me.RadioTax.Location = New System.Drawing.Point(549, 140)
        Me.RadioTax.Name = "RadioTax"
        Me.RadioTax.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.RadioTax.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioTax.Properties.Appearance.Options.UseBackColor = True
        Me.RadioTax.Properties.Appearance.Options.UseFont = True
        Me.RadioTax.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RadioTax.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "PKP", True, "PKP"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "NON PKP", True, "NON PKP")})
        Me.RadioTax.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.RadioTax.Size = New System.Drawing.Size(150, 20)
        Me.RadioTax.TabIndex = 28
        Me.RadioTax.Tag = "input"
        '
        'FormVendor
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.RadioTax)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.txtFaxVendor)
        Me.Controls.Add(Me.txtContactVendor)
        Me.Controls.Add(Me.txtNpwpVendor)
        Me.Controls.Add(Me.txtHpVendor)
        Me.Controls.Add(Me.txtEmailVendor)
        Me.Controls.Add(Me.txtAlamatVendor)
        Me.Controls.Add(Me.txtTelpVendor)
        Me.Controls.Add(Me.txtNamaVendor)
        Me.Controls.Add(Me.txtKodeVendor)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.BtnCancelVendor)
        Me.Controls.Add(Me.BtnSaveVendor)
        Me.Controls.Add(Me.BtnDelVendor)
        Me.Controls.Add(Me.BtnEditVendor)
        Me.Controls.Add(Me.BtnAddVendor)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormVendor"
        Me.Tag = "1100"
        Me.Text = "Vendor"
        CType(Me.txtKodeVendor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNamaVendor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelpVendor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlamatVendor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmailVendor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHpVendor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNpwpVendor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContactVendor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFaxVendor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioTax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnAddVendor As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEditVendor As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnDelVendor As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnSaveVendor As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnCancelVendor As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtKodeVendor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNamaVendor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTelpVendor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAlamatVendor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEmailVendor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtHpVendor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNpwpVendor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtContactVendor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFaxVendor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RadioTax As DevExpress.XtraEditors.RadioGroup
End Class
