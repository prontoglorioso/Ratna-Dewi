<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHeaderItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHeaderItem))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNamaHeaderItem = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BtnCancelHeaderItem = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnSaveHeaderItem = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnDelHeaderItem = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnEditHeaderItem = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnAddHeaderItem = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtNamaHeaderItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(48, 50)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Nama Header Item"
        '
        'txtNamaHeaderItem
        '
        Me.txtNamaHeaderItem.EditValue = ""
        Me.txtNamaHeaderItem.Location = New System.Drawing.Point(166, 47)
        Me.txtNamaHeaderItem.Name = "txtNamaHeaderItem"
        Me.txtNamaHeaderItem.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.txtNamaHeaderItem.Size = New System.Drawing.Size(100, 20)
        Me.txtNamaHeaderItem.TabIndex = 1
        Me.txtNamaHeaderItem.Tag = "input"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(48, 101)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Type Item"
        '
        'RadioGroup1
        '
        Me.RadioGroup1.Location = New System.Drawing.Point(166, 101)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Inventory", True, True), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "NonInventory", True, False)})
        Me.RadioGroup1.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.RadioGroup1.Size = New System.Drawing.Size(201, 34)
        Me.RadioGroup1.TabIndex = 3
        Me.RadioGroup1.Tag = "input"
        '
        'GridControl1
        '
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridControl1.Location = New System.Drawing.Point(48, 228)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1200, 200)
        Me.GridControl1.TabIndex = 53
        Me.GridControl1.Tag = "view"
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'BtnCancelHeaderItem
        '
        Me.BtnCancelHeaderItem.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelHeaderItem.Appearance.Options.UseFont = True
        Me.BtnCancelHeaderItem.Image = CType(resources.GetObject("BtnCancelHeaderItem.Image"), System.Drawing.Image)
        Me.BtnCancelHeaderItem.Location = New System.Drawing.Point(434, 168)
        Me.BtnCancelHeaderItem.Name = "BtnCancelHeaderItem"
        Me.BtnCancelHeaderItem.Size = New System.Drawing.Size(80, 40)
        Me.BtnCancelHeaderItem.TabIndex = 52
        Me.BtnCancelHeaderItem.Tag = "cancel"
        Me.BtnCancelHeaderItem.Text = "Cancel"
        '
        'BtnSaveHeaderItem
        '
        Me.BtnSaveHeaderItem.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveHeaderItem.Appearance.Options.UseFont = True
        Me.BtnSaveHeaderItem.Image = CType(resources.GetObject("BtnSaveHeaderItem.Image"), System.Drawing.Image)
        Me.BtnSaveHeaderItem.Location = New System.Drawing.Point(336, 168)
        Me.BtnSaveHeaderItem.Name = "BtnSaveHeaderItem"
        Me.BtnSaveHeaderItem.Size = New System.Drawing.Size(80, 40)
        Me.BtnSaveHeaderItem.TabIndex = 51
        Me.BtnSaveHeaderItem.Tag = "save"
        Me.BtnSaveHeaderItem.Text = "Save"
        '
        'BtnDelHeaderItem
        '
        Me.BtnDelHeaderItem.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelHeaderItem.Appearance.Options.UseFont = True
        Me.BtnDelHeaderItem.Image = CType(resources.GetObject("BtnDelHeaderItem.Image"), System.Drawing.Image)
        Me.BtnDelHeaderItem.Location = New System.Drawing.Point(240, 168)
        Me.BtnDelHeaderItem.Name = "BtnDelHeaderItem"
        Me.BtnDelHeaderItem.Size = New System.Drawing.Size(80, 40)
        Me.BtnDelHeaderItem.TabIndex = 50
        Me.BtnDelHeaderItem.Tag = "view"
        Me.BtnDelHeaderItem.Text = "Delete"
        '
        'BtnEditHeaderItem
        '
        Me.BtnEditHeaderItem.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditHeaderItem.Appearance.Options.UseFont = True
        Me.BtnEditHeaderItem.Image = CType(resources.GetObject("BtnEditHeaderItem.Image"), System.Drawing.Image)
        Me.BtnEditHeaderItem.Location = New System.Drawing.Point(144, 168)
        Me.BtnEditHeaderItem.Name = "BtnEditHeaderItem"
        Me.BtnEditHeaderItem.Size = New System.Drawing.Size(80, 40)
        Me.BtnEditHeaderItem.TabIndex = 49
        Me.BtnEditHeaderItem.Tag = "edit"
        Me.BtnEditHeaderItem.Text = "Edit"
        '
        'BtnAddHeaderItem
        '
        Me.BtnAddHeaderItem.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddHeaderItem.Appearance.Options.UseFont = True
        Me.BtnAddHeaderItem.Image = CType(resources.GetObject("BtnAddHeaderItem.Image"), System.Drawing.Image)
        Me.BtnAddHeaderItem.Location = New System.Drawing.Point(48, 168)
        Me.BtnAddHeaderItem.Name = "BtnAddHeaderItem"
        Me.BtnAddHeaderItem.Size = New System.Drawing.Size(80, 40)
        Me.BtnAddHeaderItem.TabIndex = 48
        Me.BtnAddHeaderItem.Tag = "add"
        Me.BtnAddHeaderItem.Text = "Add"
        '
        'FormHeaderItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.BtnCancelHeaderItem)
        Me.Controls.Add(Me.BtnSaveHeaderItem)
        Me.Controls.Add(Me.BtnDelHeaderItem)
        Me.Controls.Add(Me.BtnEditHeaderItem)
        Me.Controls.Add(Me.BtnAddHeaderItem)
        Me.Controls.Add(Me.RadioGroup1)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtNamaHeaderItem)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "FormHeaderItem"
        Me.Tag = "1100"
        Me.Text = "HeaderItem"
        CType(Me.txtNamaHeaderItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNamaHeaderItem As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BtnCancelHeaderItem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnSaveHeaderItem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnDelHeaderItem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEditHeaderItem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnAddHeaderItem As DevExpress.XtraEditors.SimpleButton
End Class
