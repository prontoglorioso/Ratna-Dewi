<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCustomer))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtFaxCustomer = New DevExpress.XtraEditors.TextEdit()
        Me.txtContactCustomer = New DevExpress.XtraEditors.TextEdit()
        Me.txtNpwpCustomer = New DevExpress.XtraEditors.TextEdit()
        Me.txtHpCustomer = New DevExpress.XtraEditors.TextEdit()
        Me.txtEmailCustomer = New DevExpress.XtraEditors.TextEdit()
        Me.txtAlamatCustomer = New DevExpress.XtraEditors.TextEdit()
        Me.txtTelpCustomer = New DevExpress.XtraEditors.TextEdit()
        Me.txtNamaCustomer = New DevExpress.XtraEditors.TextEdit()
        Me.txtKodeCustomer = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.BtnCancelCustomer = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnSaveCustomer = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnDelCustomer = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnEditCustomer = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnAddCustomer = New DevExpress.XtraEditors.SimpleButton()
        Me.RadioTax = New DevExpress.XtraEditors.RadioGroup()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFaxCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContactCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNpwpCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHpCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmailCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlamatCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelpCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNamaCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKodeCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioTax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridControl1.Location = New System.Drawing.Point(21, 179)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1200, 300)
        Me.GridControl1.TabIndex = 53
        Me.GridControl1.Tag = "view"
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'txtFaxCustomer
        '
        Me.txtFaxCustomer.Location = New System.Drawing.Point(117, 145)
        Me.txtFaxCustomer.Name = "txtFaxCustomer"
        Me.txtFaxCustomer.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFaxCustomer.Properties.Appearance.Options.UseFont = True
        Me.txtFaxCustomer.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.txtFaxCustomer.Properties.MaxLength = 12
        Me.txtFaxCustomer.Size = New System.Drawing.Size(300, 20)
        Me.txtFaxCustomer.TabIndex = 10
        Me.txtFaxCustomer.Tag = "input"
        '
        'txtContactCustomer
        '
        Me.txtContactCustomer.Location = New System.Drawing.Point(549, 29)
        Me.txtContactCustomer.Name = "txtContactCustomer"
        Me.txtContactCustomer.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactCustomer.Properties.Appearance.Options.UseFont = True
        Me.txtContactCustomer.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.txtContactCustomer.Properties.MaxLength = 50
        Me.txtContactCustomer.Size = New System.Drawing.Size(300, 20)
        Me.txtContactCustomer.TabIndex = 11
        Me.txtContactCustomer.Tag = "input"
        '
        'txtNpwpCustomer
        '
        Me.txtNpwpCustomer.Location = New System.Drawing.Point(549, 110)
        Me.txtNpwpCustomer.Name = "txtNpwpCustomer"
        Me.txtNpwpCustomer.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNpwpCustomer.Properties.Appearance.Options.UseFont = True
        Me.txtNpwpCustomer.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.txtNpwpCustomer.Properties.Mask.EditMask = "\d{2}\.\d{3}\.\d{3}\.\d{1}-\d{3}\.\d{3}"
        Me.txtNpwpCustomer.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
        Me.txtNpwpCustomer.Size = New System.Drawing.Size(300, 20)
        Me.txtNpwpCustomer.TabIndex = 14
        Me.txtNpwpCustomer.Tag = "input"
        '
        'txtHpCustomer
        '
        Me.txtHpCustomer.Location = New System.Drawing.Point(549, 55)
        Me.txtHpCustomer.Name = "txtHpCustomer"
        Me.txtHpCustomer.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHpCustomer.Properties.Appearance.Options.UseFont = True
        Me.txtHpCustomer.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.txtHpCustomer.Properties.MaxLength = 14
        Me.txtHpCustomer.Size = New System.Drawing.Size(300, 20)
        Me.txtHpCustomer.TabIndex = 12
        Me.txtHpCustomer.Tag = "input"
        '
        'txtEmailCustomer
        '
        Me.txtEmailCustomer.Location = New System.Drawing.Point(549, 81)
        Me.txtEmailCustomer.Name = "txtEmailCustomer"
        Me.txtEmailCustomer.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailCustomer.Properties.Appearance.Options.UseFont = True
        Me.txtEmailCustomer.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.txtEmailCustomer.Properties.MaxLength = 50
        Me.txtEmailCustomer.Size = New System.Drawing.Size(300, 20)
        Me.txtEmailCustomer.TabIndex = 13
        Me.txtEmailCustomer.Tag = "input"
        '
        'txtAlamatCustomer
        '
        Me.txtAlamatCustomer.Location = New System.Drawing.Point(117, 88)
        Me.txtAlamatCustomer.Name = "txtAlamatCustomer"
        Me.txtAlamatCustomer.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlamatCustomer.Properties.Appearance.Options.UseFont = True
        Me.txtAlamatCustomer.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.txtAlamatCustomer.Properties.MaxLength = 50
        Me.txtAlamatCustomer.Size = New System.Drawing.Size(300, 20)
        Me.txtAlamatCustomer.TabIndex = 7
        Me.txtAlamatCustomer.Tag = "input"
        '
        'txtTelpCustomer
        '
        Me.txtTelpCustomer.Location = New System.Drawing.Point(117, 117)
        Me.txtTelpCustomer.Name = "txtTelpCustomer"
        Me.txtTelpCustomer.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelpCustomer.Properties.Appearance.Options.UseFont = True
        Me.txtTelpCustomer.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.txtTelpCustomer.Properties.MaxLength = 12
        Me.txtTelpCustomer.Size = New System.Drawing.Size(300, 20)
        Me.txtTelpCustomer.TabIndex = 8
        Me.txtTelpCustomer.Tag = "input"
        '
        'txtNamaCustomer
        '
        Me.txtNamaCustomer.Location = New System.Drawing.Point(117, 59)
        Me.txtNamaCustomer.Name = "txtNamaCustomer"
        Me.txtNamaCustomer.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaCustomer.Properties.Appearance.Options.UseFont = True
        Me.txtNamaCustomer.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.txtNamaCustomer.Properties.MaxLength = 50
        Me.txtNamaCustomer.Size = New System.Drawing.Size(300, 20)
        Me.txtNamaCustomer.TabIndex = 6
        Me.txtNamaCustomer.Tag = "input"
        '
        'txtKodeCustomer
        '
        Me.txtKodeCustomer.Location = New System.Drawing.Point(117, 29)
        Me.txtKodeCustomer.Name = "txtKodeCustomer"
        Me.txtKodeCustomer.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeCustomer.Properties.Appearance.Options.UseFont = True
        Me.txtKodeCustomer.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.txtKodeCustomer.Properties.MaxLength = 10
        Me.txtKodeCustomer.Size = New System.Drawing.Size(300, 20)
        Me.txtKodeCustomer.TabIndex = 5
        Me.txtKodeCustomer.Tag = "input"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Location = New System.Drawing.Point(21, 62)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl11.TabIndex = 42
        Me.LabelControl11.Text = "Customer Name"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(21, 120)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl10.TabIndex = 41
        Me.LabelControl10.Text = "Telp."
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(448, 32)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl8.TabIndex = 40
        Me.LabelControl8.Text = "Contact Person"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(448, 62)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl7.TabIndex = 39
        Me.LabelControl7.Text = "Handphone"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(448, 148)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl6.TabIndex = 38
        Me.LabelControl6.Text = "Tax Status"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(21, 91)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl5.TabIndex = 37
        Me.LabelControl5.Text = "Address"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(448, 91)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl4.TabIndex = 36
        Me.LabelControl4.Text = "Email"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(448, 120)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl3.TabIndex = 35
        Me.LabelControl3.Text = "NPWP No."
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(21, 148)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl2.TabIndex = 34
        Me.LabelControl2.Text = "Fax."
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(21, 32)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl1.TabIndex = 33
        Me.LabelControl1.Text = "Customer Code"
        '
        'BtnCancelCustomer
        '
        Me.BtnCancelCustomer.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelCustomer.Appearance.Options.UseFont = True
        Me.BtnCancelCustomer.Image = CType(resources.GetObject("BtnCancelCustomer.Image"), System.Drawing.Image)
        Me.BtnCancelCustomer.Location = New System.Drawing.Point(884, 125)
        Me.BtnCancelCustomer.Name = "BtnCancelCustomer"
        Me.BtnCancelCustomer.Size = New System.Drawing.Size(180, 40)
        Me.BtnCancelCustomer.TabIndex = 4
        Me.BtnCancelCustomer.Tag = "cancel"
        Me.BtnCancelCustomer.Text = "Cancel"
        '
        'BtnSaveCustomer
        '
        Me.BtnSaveCustomer.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveCustomer.Appearance.Options.UseFont = True
        Me.BtnSaveCustomer.Image = CType(resources.GetObject("BtnSaveCustomer.Image"), System.Drawing.Image)
        Me.BtnSaveCustomer.Location = New System.Drawing.Point(984, 79)
        Me.BtnSaveCustomer.Name = "BtnSaveCustomer"
        Me.BtnSaveCustomer.Size = New System.Drawing.Size(80, 40)
        Me.BtnSaveCustomer.TabIndex = 3
        Me.BtnSaveCustomer.Tag = "save"
        Me.BtnSaveCustomer.Text = "Save"
        '
        'BtnDelCustomer
        '
        Me.BtnDelCustomer.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelCustomer.Appearance.Options.UseFont = True
        Me.BtnDelCustomer.Image = CType(resources.GetObject("BtnDelCustomer.Image"), System.Drawing.Image)
        Me.BtnDelCustomer.Location = New System.Drawing.Point(884, 79)
        Me.BtnDelCustomer.Name = "BtnDelCustomer"
        Me.BtnDelCustomer.Size = New System.Drawing.Size(80, 40)
        Me.BtnDelCustomer.TabIndex = 2
        Me.BtnDelCustomer.Tag = "view"
        Me.BtnDelCustomer.Text = "Delete"
        '
        'BtnEditCustomer
        '
        Me.BtnEditCustomer.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditCustomer.Appearance.Options.UseFont = True
        Me.BtnEditCustomer.Image = CType(resources.GetObject("BtnEditCustomer.Image"), System.Drawing.Image)
        Me.BtnEditCustomer.Location = New System.Drawing.Point(984, 24)
        Me.BtnEditCustomer.Name = "BtnEditCustomer"
        Me.BtnEditCustomer.Size = New System.Drawing.Size(80, 40)
        Me.BtnEditCustomer.TabIndex = 1
        Me.BtnEditCustomer.Tag = "edit"
        Me.BtnEditCustomer.Text = "Edit"
        '
        'BtnAddCustomer
        '
        Me.BtnAddCustomer.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddCustomer.Appearance.Options.UseFont = True
        Me.BtnAddCustomer.Image = CType(resources.GetObject("BtnAddCustomer.Image"), System.Drawing.Image)
        Me.BtnAddCustomer.Location = New System.Drawing.Point(884, 24)
        Me.BtnAddCustomer.Name = "BtnAddCustomer"
        Me.BtnAddCustomer.Size = New System.Drawing.Size(80, 40)
        Me.BtnAddCustomer.TabIndex = 0
        Me.BtnAddCustomer.Tag = "add"
        Me.BtnAddCustomer.Text = "Add"
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
        Me.RadioTax.TabIndex = 15
        Me.RadioTax.Tag = "input"
        '
        'FormCustomer
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.RadioTax)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.txtFaxCustomer)
        Me.Controls.Add(Me.txtContactCustomer)
        Me.Controls.Add(Me.txtNpwpCustomer)
        Me.Controls.Add(Me.txtHpCustomer)
        Me.Controls.Add(Me.txtEmailCustomer)
        Me.Controls.Add(Me.txtAlamatCustomer)
        Me.Controls.Add(Me.txtTelpCustomer)
        Me.Controls.Add(Me.txtNamaCustomer)
        Me.Controls.Add(Me.txtKodeCustomer)
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
        Me.Controls.Add(Me.BtnCancelCustomer)
        Me.Controls.Add(Me.BtnSaveCustomer)
        Me.Controls.Add(Me.BtnDelCustomer)
        Me.Controls.Add(Me.BtnEditCustomer)
        Me.Controls.Add(Me.BtnAddCustomer)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormCustomer"
        Me.Tag = "1100"
        Me.Text = "Customer"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFaxCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContactCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNpwpCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHpCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmailCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlamatCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelpCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNamaCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKodeCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioTax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtFaxCustomer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtContactCustomer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNpwpCustomer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtHpCustomer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEmailCustomer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAlamatCustomer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTelpCustomer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNamaCustomer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtKodeCustomer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BtnCancelCustomer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnSaveCustomer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnDelCustomer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEditCustomer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnAddCustomer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RadioTax As DevExpress.XtraEditors.RadioGroup
End Class
