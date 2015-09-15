<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProject))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtDescription = New DevExpress.XtraEditors.TextEdit()
        Me.txtContactProject = New DevExpress.XtraEditors.TextEdit()
        Me.txtNamaProject = New DevExpress.XtraEditors.TextEdit()
        Me.txtKodeProject = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.BtnCancelProject = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnSaveProject = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnDelProject = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnEditProject = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnAddProject = New DevExpress.XtraEditors.SimpleButton()
        Me.LookUpCustomer = New DevExpress.XtraEditors.LookUpEdit()
        Me.LookUpMarketing = New DevExpress.XtraEditors.LookUpEdit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContactProject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNamaProject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKodeProject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpMarketing.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GridControl1.TabIndex = 79
        Me.GridControl1.Tag = "view"
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(117, 88)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Properties.Appearance.Options.UseFont = True
        Me.txtDescription.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.txtDescription.Size = New System.Drawing.Size(450, 20)
        Me.txtDescription.TabIndex = 7
        Me.txtDescription.Tag = "input"
        '
        'txtContactProject
        '
        Me.txtContactProject.Location = New System.Drawing.Point(117, 117)
        Me.txtContactProject.Name = "txtContactProject"
        Me.txtContactProject.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactProject.Properties.Appearance.Options.UseFont = True
        Me.txtContactProject.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.txtContactProject.Size = New System.Drawing.Size(450, 20)
        Me.txtContactProject.TabIndex = 8
        Me.txtContactProject.Tag = "input"
        '
        'txtNamaProject
        '
        Me.txtNamaProject.Location = New System.Drawing.Point(117, 59)
        Me.txtNamaProject.Name = "txtNamaProject"
        Me.txtNamaProject.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaProject.Properties.Appearance.Options.UseFont = True
        Me.txtNamaProject.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.txtNamaProject.Size = New System.Drawing.Size(450, 20)
        Me.txtNamaProject.TabIndex = 6
        Me.txtNamaProject.Tag = "input"
        '
        'txtKodeProject
        '
        Me.txtKodeProject.Location = New System.Drawing.Point(117, 29)
        Me.txtKodeProject.Name = "txtKodeProject"
        Me.txtKodeProject.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeProject.Properties.Appearance.Options.UseFont = True
        Me.txtKodeProject.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.txtKodeProject.Properties.MaxLength = 10
        Me.txtKodeProject.Size = New System.Drawing.Size(450, 20)
        Me.txtKodeProject.TabIndex = 5
        Me.txtKodeProject.Tag = "input"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Location = New System.Drawing.Point(21, 62)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl11.TabIndex = 68
        Me.LabelControl11.Text = "Project Name"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(21, 120)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl10.TabIndex = 67
        Me.LabelControl10.Text = "Contact Person"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(591, 32)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl8.TabIndex = 66
        Me.LabelControl8.Text = "ID Marketing"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(591, 62)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl7.TabIndex = 65
        Me.LabelControl7.Text = "ID Customer"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(21, 91)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl5.TabIndex = 63
        Me.LabelControl5.Text = "Description"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(21, 32)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl1.TabIndex = 59
        Me.LabelControl1.Text = "Project Code"
        '
        'BtnCancelProject
        '
        Me.BtnCancelProject.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelProject.Appearance.Options.UseFont = True
        Me.BtnCancelProject.Image = CType(resources.GetObject("BtnCancelProject.Image"), System.Drawing.Image)
        Me.BtnCancelProject.Location = New System.Drawing.Point(977, 97)
        Me.BtnCancelProject.Name = "BtnCancelProject"
        Me.BtnCancelProject.Size = New System.Drawing.Size(80, 40)
        Me.BtnCancelProject.TabIndex = 4
        Me.BtnCancelProject.Tag = "cancel"
        Me.BtnCancelProject.Text = "Cancel"
        '
        'BtnSaveProject
        '
        Me.BtnSaveProject.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveProject.Appearance.Options.UseFont = True
        Me.BtnSaveProject.Image = CType(resources.GetObject("BtnSaveProject.Image"), System.Drawing.Image)
        Me.BtnSaveProject.Location = New System.Drawing.Point(879, 97)
        Me.BtnSaveProject.Name = "BtnSaveProject"
        Me.BtnSaveProject.Size = New System.Drawing.Size(80, 40)
        Me.BtnSaveProject.TabIndex = 3
        Me.BtnSaveProject.Tag = "save"
        Me.BtnSaveProject.Text = "Save"
        '
        'BtnDelProject
        '
        Me.BtnDelProject.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelProject.Appearance.Options.UseFont = True
        Me.BtnDelProject.Image = CType(resources.GetObject("BtnDelProject.Image"), System.Drawing.Image)
        Me.BtnDelProject.Location = New System.Drawing.Point(783, 97)
        Me.BtnDelProject.Name = "BtnDelProject"
        Me.BtnDelProject.Size = New System.Drawing.Size(80, 40)
        Me.BtnDelProject.TabIndex = 2
        Me.BtnDelProject.Tag = "view"
        Me.BtnDelProject.Text = "Delete"
        '
        'BtnEditProject
        '
        Me.BtnEditProject.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditProject.Appearance.Options.UseFont = True
        Me.BtnEditProject.Image = CType(resources.GetObject("BtnEditProject.Image"), System.Drawing.Image)
        Me.BtnEditProject.Location = New System.Drawing.Point(687, 97)
        Me.BtnEditProject.Name = "BtnEditProject"
        Me.BtnEditProject.Size = New System.Drawing.Size(80, 40)
        Me.BtnEditProject.TabIndex = 1
        Me.BtnEditProject.Tag = "edit"
        Me.BtnEditProject.Text = "Edit"
        '
        'BtnAddProject
        '
        Me.BtnAddProject.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddProject.Appearance.Options.UseFont = True
        Me.BtnAddProject.Image = CType(resources.GetObject("BtnAddProject.Image"), System.Drawing.Image)
        Me.BtnAddProject.Location = New System.Drawing.Point(591, 97)
        Me.BtnAddProject.Name = "BtnAddProject"
        Me.BtnAddProject.Size = New System.Drawing.Size(80, 40)
        Me.BtnAddProject.TabIndex = 0
        Me.BtnAddProject.Tag = "add"
        Me.BtnAddProject.Text = "Add"
        '
        'LookUpCustomer
        '
        Me.LookUpCustomer.Location = New System.Drawing.Point(687, 59)
        Me.LookUpCustomer.Name = "LookUpCustomer"
        Me.LookUpCustomer.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LookUpCustomer.Properties.Appearance.Options.UseFont = True
        Me.LookUpCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpCustomer.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.LookUpCustomer.Size = New System.Drawing.Size(450, 20)
        Me.LookUpCustomer.TabIndex = 10
        Me.LookUpCustomer.Tag = "input"
        '
        'LookUpMarketing
        '
        Me.LookUpMarketing.Location = New System.Drawing.Point(687, 29)
        Me.LookUpMarketing.Name = "LookUpMarketing"
        Me.LookUpMarketing.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LookUpMarketing.Properties.Appearance.Options.UseFont = True
        Me.LookUpMarketing.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpMarketing.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.LookUpMarketing.Properties.NullText = "Choose Marketing Name"
        Me.LookUpMarketing.Size = New System.Drawing.Size(450, 20)
        Me.LookUpMarketing.TabIndex = 9
        Me.LookUpMarketing.Tag = "input"
        '
        'FormProject
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.LookUpMarketing)
        Me.Controls.Add(Me.LookUpCustomer)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtContactProject)
        Me.Controls.Add(Me.txtNamaProject)
        Me.Controls.Add(Me.txtKodeProject)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.BtnCancelProject)
        Me.Controls.Add(Me.BtnSaveProject)
        Me.Controls.Add(Me.BtnDelProject)
        Me.Controls.Add(Me.BtnEditProject)
        Me.Controls.Add(Me.BtnAddProject)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormProject"
        Me.Tag = "1100"
        Me.Text = "Project"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContactProject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNamaProject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKodeProject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpMarketing.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtContactProject As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNamaProject As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtKodeProject As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BtnCancelProject As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnSaveProject As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnDelProject As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEditProject As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnAddProject As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LookUpCustomer As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LookUpMarketing As DevExpress.XtraEditors.LookUpEdit
End Class
