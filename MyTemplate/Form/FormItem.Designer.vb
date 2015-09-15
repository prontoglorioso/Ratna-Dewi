<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormItem))
        Me.LookUpItemType = New DevExpress.XtraEditors.LookUpEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtNamaItem = New DevExpress.XtraEditors.TextEdit()
        Me.txtAccNoItem = New DevExpress.XtraEditors.TextEdit()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.DateEditItem = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.BtnCancelItem = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnSaveItem = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnDelItem = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnEditItem = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnAddItem = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtQty = New DevExpress.XtraEditors.TextEdit()
        Me.txtUnit = New DevExpress.XtraEditors.TextEdit()
        Me.txtCost = New DevExpress.XtraEditors.TextEdit()
        CType(Me.LookUpItemType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNamaItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAccNoItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditItem.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LookUpItemType
        '
        Me.LookUpItemType.Location = New System.Drawing.Point(152, 114)
        Me.LookUpItemType.Name = "LookUpItemType"
        Me.LookUpItemType.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LookUpItemType.Properties.Appearance.Options.UseFont = True
        Me.LookUpItemType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpItemType.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.LookUpItemType.Size = New System.Drawing.Size(100, 20)
        Me.LookUpItemType.TabIndex = 8
        Me.LookUpItemType.Tag = "input"
        '
        'GridControl1
        '
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridControl1.Location = New System.Drawing.Point(40, 244)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1200, 200)
        Me.GridControl1.TabIndex = 47
        Me.GridControl1.Tag = "view"
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'txtNamaItem
        '
        Me.txtNamaItem.Location = New System.Drawing.Point(152, 83)
        Me.txtNamaItem.Name = "txtNamaItem"
        Me.txtNamaItem.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaItem.Properties.Appearance.Options.UseFont = True
        Me.txtNamaItem.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.txtNamaItem.Properties.MaxLength = 50
        Me.txtNamaItem.Size = New System.Drawing.Size(668, 20)
        Me.txtNamaItem.TabIndex = 7
        Me.txtNamaItem.Tag = "input"
        '
        'txtAccNoItem
        '
        Me.txtAccNoItem.Location = New System.Drawing.Point(151, 53)
        Me.txtAccNoItem.Name = "txtAccNoItem"
        Me.txtAccNoItem.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccNoItem.Properties.Appearance.Options.UseFont = True
        Me.txtAccNoItem.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.txtAccNoItem.Properties.MaxLength = 10
        Me.txtAccNoItem.Size = New System.Drawing.Size(669, 20)
        Me.txtAccNoItem.TabIndex = 6
        Me.txtAccNoItem.Tag = "input"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(826, 54)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Caption = "Suspended"
        Me.CheckEdit1.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.CheckEdit1.Size = New System.Drawing.Size(175, 19)
        Me.CheckEdit1.TabIndex = 43
        Me.CheckEdit1.Tag = "input"
        '
        'DateEditItem
        '
        Me.DateEditItem.EditValue = Nothing
        Me.DateEditItem.Location = New System.Drawing.Point(566, 146)
        Me.DateEditItem.Name = "DateEditItem"
        Me.DateEditItem.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateEditItem.Properties.Appearance.Options.UseFont = True
        Me.DateEditItem.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditItem.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditItem.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.DateEditItem.Size = New System.Drawing.Size(100, 20)
        Me.DateEditItem.TabIndex = 13
        Me.DateEditItem.Tag = "input"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(532, 149)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl7.TabIndex = 41
        Me.LabelControl7.Text = "As Of"
        '
        'BtnCancelItem
        '
        Me.BtnCancelItem.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelItem.Appearance.Options.UseFont = True
        Me.BtnCancelItem.Image = CType(resources.GetObject("BtnCancelItem.Image"), System.Drawing.Image)
        Me.BtnCancelItem.Location = New System.Drawing.Point(426, 184)
        Me.BtnCancelItem.Name = "BtnCancelItem"
        Me.BtnCancelItem.Size = New System.Drawing.Size(80, 40)
        Me.BtnCancelItem.TabIndex = 4
        Me.BtnCancelItem.Tag = "cancel"
        Me.BtnCancelItem.Text = "Cancel"
        '
        'BtnSaveItem
        '
        Me.BtnSaveItem.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveItem.Appearance.Options.UseFont = True
        Me.BtnSaveItem.Image = CType(resources.GetObject("BtnSaveItem.Image"), System.Drawing.Image)
        Me.BtnSaveItem.Location = New System.Drawing.Point(328, 184)
        Me.BtnSaveItem.Name = "BtnSaveItem"
        Me.BtnSaveItem.Size = New System.Drawing.Size(80, 40)
        Me.BtnSaveItem.TabIndex = 3
        Me.BtnSaveItem.Tag = "save"
        Me.BtnSaveItem.Text = "Save"
        '
        'BtnDelItem
        '
        Me.BtnDelItem.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelItem.Appearance.Options.UseFont = True
        Me.BtnDelItem.Image = CType(resources.GetObject("BtnDelItem.Image"), System.Drawing.Image)
        Me.BtnDelItem.Location = New System.Drawing.Point(232, 184)
        Me.BtnDelItem.Name = "BtnDelItem"
        Me.BtnDelItem.Size = New System.Drawing.Size(80, 40)
        Me.BtnDelItem.TabIndex = 2
        Me.BtnDelItem.Tag = "view"
        Me.BtnDelItem.Text = "Delete"
        '
        'BtnEditItem
        '
        Me.BtnEditItem.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditItem.Appearance.Options.UseFont = True
        Me.BtnEditItem.Image = CType(resources.GetObject("BtnEditItem.Image"), System.Drawing.Image)
        Me.BtnEditItem.Location = New System.Drawing.Point(136, 184)
        Me.BtnEditItem.Name = "BtnEditItem"
        Me.BtnEditItem.Size = New System.Drawing.Size(80, 40)
        Me.BtnEditItem.TabIndex = 1
        Me.BtnEditItem.Tag = "edit"
        Me.BtnEditItem.Text = "Edit"
        '
        'BtnAddItem
        '
        Me.BtnAddItem.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddItem.Appearance.Options.UseFont = True
        Me.BtnAddItem.Image = CType(resources.GetObject("BtnAddItem.Image"), System.Drawing.Image)
        Me.BtnAddItem.Location = New System.Drawing.Point(40, 184)
        Me.BtnAddItem.Name = "BtnAddItem"
        Me.BtnAddItem.Size = New System.Drawing.Size(80, 40)
        Me.BtnAddItem.TabIndex = 0
        Me.BtnAddItem.Tag = "add"
        Me.BtnAddItem.Text = "Add"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(40, 117)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl4.TabIndex = 34
        Me.LabelControl4.Text = "Sub Item Of"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(40, 86)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl3.TabIndex = 33
        Me.LabelControl3.Text = "Item Name"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(40, 56)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl2.TabIndex = 32
        Me.LabelControl2.Text = "Item No."
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(40, 30)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl1.TabIndex = 31
        Me.LabelControl1.Text = "Item Type"
        '
        'RadioGroup1
        '
        Me.RadioGroup1.Location = New System.Drawing.Point(151, 12)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Inventory", True, True), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "NonInventory", True, False)})
        Me.RadioGroup1.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.RadioGroup1.Size = New System.Drawing.Size(219, 31)
        Me.RadioGroup1.TabIndex = 5
        Me.RadioGroup1.Tag = "input"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(40, 149)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl5.TabIndex = 51
        Me.LabelControl5.Text = "Quantity"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(257, 149)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl6.TabIndex = 52
        Me.LabelControl6.Text = "Unit"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(391, 149)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl8.TabIndex = 53
        Me.LabelControl8.Text = "Cost"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(151, 146)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.txtQty.Size = New System.Drawing.Size(100, 20)
        Me.txtQty.TabIndex = 9
        Me.txtQty.Tag = "input"
        '
        'txtUnit
        '
        Me.txtUnit.Location = New System.Drawing.Point(285, 146)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.txtUnit.Properties.MaxLength = 5
        Me.txtUnit.Size = New System.Drawing.Size(100, 20)
        Me.txtUnit.TabIndex = 10
        Me.txtUnit.Tag = "input"
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(419, 146)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.txtCost.Size = New System.Drawing.Size(100, 20)
        Me.txtCost.TabIndex = 11
        Me.txtCost.Tag = "input"
        '
        'FormItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.RadioGroup1)
        Me.Controls.Add(Me.LookUpItemType)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.txtNamaItem)
        Me.Controls.Add(Me.txtAccNoItem)
        Me.Controls.Add(Me.CheckEdit1)
        Me.Controls.Add(Me.DateEditItem)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.BtnCancelItem)
        Me.Controls.Add(Me.BtnSaveItem)
        Me.Controls.Add(Me.BtnDelItem)
        Me.Controls.Add(Me.BtnEditItem)
        Me.Controls.Add(Me.BtnAddItem)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "FormItem"
        Me.Tag = "1100"
        Me.Text = "FormItem"
        CType(Me.LookUpItemType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNamaItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAccNoItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditItem.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LookUpItemType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtNamaItem As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAccNoItem As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents DateEditItem As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BtnCancelItem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnSaveItem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnDelItem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEditItem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnAddItem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUnit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCost As DevExpress.XtraEditors.TextEdit
End Class
