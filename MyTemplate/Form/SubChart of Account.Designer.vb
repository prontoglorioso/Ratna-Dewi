<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class COA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(COA))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.BtnCancelSubCOA = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnSaveSubCOA = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnDelSubCOA = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnEditSubCOA = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnAddSubCOA = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEditSubCoa = New DevExpress.XtraEditors.DateEdit()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.txtAccNoSubCOA = New DevExpress.XtraEditors.TextEdit()
        Me.txtNamaSubCOA = New DevExpress.XtraEditors.TextEdit()
        Me.txtOpB = New DevExpress.XtraEditors.TextEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LookUpEditParent = New DevExpress.XtraEditors.LookUpEdit()
        Me.LookUpEditAccTyp = New DevExpress.XtraEditors.LookUpEdit()
        CType(Me.DateEditSubCoa.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditSubCoa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAccNoSubCOA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNamaSubCOA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOpB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditParent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditAccTyp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(40, 30)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Account Type"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(40, 62)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Account No."
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(40, 92)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "Name"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(40, 123)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl4.TabIndex = 8
        Me.LabelControl4.Text = "Sub Account Of"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(40, 155)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(89, 13)
        Me.LabelControl5.TabIndex = 9
        Me.LabelControl5.Text = "Opening Balance"
        '
        'BtnCancelSubCOA
        '
        Me.BtnCancelSubCOA.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelSubCOA.Appearance.Options.UseFont = True
        Me.BtnCancelSubCOA.Image = CType(resources.GetObject("BtnCancelSubCOA.Image"), System.Drawing.Image)
        Me.BtnCancelSubCOA.Location = New System.Drawing.Point(426, 189)
        Me.BtnCancelSubCOA.Name = "BtnCancelSubCOA"
        Me.BtnCancelSubCOA.Size = New System.Drawing.Size(80, 40)
        Me.BtnCancelSubCOA.TabIndex = 15
        Me.BtnCancelSubCOA.Tag = "cancel"
        Me.BtnCancelSubCOA.Text = "Cancel"
        '
        'BtnSaveSubCOA
        '
        Me.BtnSaveSubCOA.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveSubCOA.Appearance.Options.UseFont = True
        Me.BtnSaveSubCOA.Image = CType(resources.GetObject("BtnSaveSubCOA.Image"), System.Drawing.Image)
        Me.BtnSaveSubCOA.Location = New System.Drawing.Point(328, 189)
        Me.BtnSaveSubCOA.Name = "BtnSaveSubCOA"
        Me.BtnSaveSubCOA.Size = New System.Drawing.Size(80, 40)
        Me.BtnSaveSubCOA.TabIndex = 14
        Me.BtnSaveSubCOA.Tag = "save"
        Me.BtnSaveSubCOA.Text = "Save"
        '
        'BtnDelSubCOA
        '
        Me.BtnDelSubCOA.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelSubCOA.Appearance.Options.UseFont = True
        Me.BtnDelSubCOA.Image = CType(resources.GetObject("BtnDelSubCOA.Image"), System.Drawing.Image)
        Me.BtnDelSubCOA.Location = New System.Drawing.Point(232, 189)
        Me.BtnDelSubCOA.Name = "BtnDelSubCOA"
        Me.BtnDelSubCOA.Size = New System.Drawing.Size(80, 40)
        Me.BtnDelSubCOA.TabIndex = 13
        Me.BtnDelSubCOA.Tag = "view"
        Me.BtnDelSubCOA.Text = "Delete"
        '
        'BtnEditSubCOA
        '
        Me.BtnEditSubCOA.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditSubCOA.Appearance.Options.UseFont = True
        Me.BtnEditSubCOA.Image = CType(resources.GetObject("BtnEditSubCOA.Image"), System.Drawing.Image)
        Me.BtnEditSubCOA.Location = New System.Drawing.Point(136, 189)
        Me.BtnEditSubCOA.Name = "BtnEditSubCOA"
        Me.BtnEditSubCOA.Size = New System.Drawing.Size(80, 40)
        Me.BtnEditSubCOA.TabIndex = 12
        Me.BtnEditSubCOA.Tag = "edit"
        Me.BtnEditSubCOA.Text = "Edit"
        '
        'BtnAddSubCOA
        '
        Me.BtnAddSubCOA.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddSubCOA.Appearance.Options.UseFont = True
        Me.BtnAddSubCOA.Image = CType(resources.GetObject("BtnAddSubCOA.Image"), System.Drawing.Image)
        Me.BtnAddSubCOA.Location = New System.Drawing.Point(40, 189)
        Me.BtnAddSubCOA.Name = "BtnAddSubCOA"
        Me.BtnAddSubCOA.Size = New System.Drawing.Size(80, 40)
        Me.BtnAddSubCOA.TabIndex = 11
        Me.BtnAddSubCOA.Tag = "add"
        Me.BtnAddSubCOA.Text = "Add"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(994, 155)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl7.TabIndex = 16
        Me.LabelControl7.Text = "As Of"
        '
        'DateEditSubCoa
        '
        Me.DateEditSubCoa.EditValue = Nothing
        Me.DateEditSubCoa.Location = New System.Drawing.Point(1052, 152)
        Me.DateEditSubCoa.Name = "DateEditSubCoa"
        Me.DateEditSubCoa.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateEditSubCoa.Properties.Appearance.Options.UseFont = True
        Me.DateEditSubCoa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditSubCoa.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditSubCoa.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.DateEditSubCoa.Size = New System.Drawing.Size(100, 20)
        Me.DateEditSubCoa.TabIndex = 20
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(994, 59)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Caption = "Suspended"
        Me.CheckEdit1.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.CheckEdit1.Size = New System.Drawing.Size(175, 19)
        Me.CheckEdit1.TabIndex = 22
        '
        'txtAccNoSubCOA
        '
        Me.txtAccNoSubCOA.Location = New System.Drawing.Point(152, 59)
        Me.txtAccNoSubCOA.Name = "txtAccNoSubCOA"
        Me.txtAccNoSubCOA.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccNoSubCOA.Properties.Appearance.Options.UseFont = True
        Me.txtAccNoSubCOA.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.txtAccNoSubCOA.Size = New System.Drawing.Size(820, 20)
        Me.txtAccNoSubCOA.TabIndex = 25
        Me.txtAccNoSubCOA.Tag = "input"
        '
        'txtNamaSubCOA
        '
        Me.txtNamaSubCOA.Location = New System.Drawing.Point(152, 89)
        Me.txtNamaSubCOA.Name = "txtNamaSubCOA"
        Me.txtNamaSubCOA.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaSubCOA.Properties.Appearance.Options.UseFont = True
        Me.txtNamaSubCOA.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.txtNamaSubCOA.Size = New System.Drawing.Size(1000, 20)
        Me.txtNamaSubCOA.TabIndex = 26
        Me.txtNamaSubCOA.Tag = "input"
        '
        'txtOpB
        '
        Me.txtOpB.EditValue = "0"
        Me.txtOpB.Location = New System.Drawing.Point(152, 152)
        Me.txtOpB.Name = "txtOpB"
        Me.txtOpB.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOpB.Properties.Appearance.Options.UseFont = True
        Me.txtOpB.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.txtOpB.Size = New System.Drawing.Size(820, 20)
        Me.txtOpB.TabIndex = 27
        Me.txtOpB.Tag = "input"
        '
        'GridControl1
        '
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridControl1.Location = New System.Drawing.Point(40, 248)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1200, 200)
        Me.GridControl1.TabIndex = 28
        Me.GridControl1.Tag = "view"
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'LookUpEditParent
        '
        Me.LookUpEditParent.Location = New System.Drawing.Point(152, 120)
        Me.LookUpEditParent.Name = "LookUpEditParent"
        Me.LookUpEditParent.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LookUpEditParent.Properties.Appearance.Options.UseFont = True
        Me.LookUpEditParent.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditParent.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.LookUpEditParent.Size = New System.Drawing.Size(820, 20)
        Me.LookUpEditParent.TabIndex = 29
        Me.LookUpEditParent.Tag = "input"
        '
        'LookUpEditAccTyp
        '
        Me.LookUpEditAccTyp.Location = New System.Drawing.Point(152, 27)
        Me.LookUpEditAccTyp.Name = "LookUpEditAccTyp"
        Me.LookUpEditAccTyp.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LookUpEditAccTyp.Properties.Appearance.Options.UseFont = True
        Me.LookUpEditAccTyp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditAccTyp.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.LookUpEditAccTyp.Size = New System.Drawing.Size(820, 20)
        Me.LookUpEditAccTyp.TabIndex = 30
        Me.LookUpEditAccTyp.Tag = "input"
        '
        'COA
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.LookUpEditAccTyp)
        Me.Controls.Add(Me.LookUpEditParent)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.txtOpB)
        Me.Controls.Add(Me.txtNamaSubCOA)
        Me.Controls.Add(Me.txtAccNoSubCOA)
        Me.Controls.Add(Me.CheckEdit1)
        Me.Controls.Add(Me.DateEditSubCoa)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.BtnCancelSubCOA)
        Me.Controls.Add(Me.BtnSaveSubCOA)
        Me.Controls.Add(Me.BtnDelSubCOA)
        Me.Controls.Add(Me.BtnEditSubCOA)
        Me.Controls.Add(Me.BtnAddSubCOA)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "COA"
        Me.Tag = "1100"
        Me.Text = "Chart Of Account"
        CType(Me.DateEditSubCoa.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditSubCoa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAccNoSubCOA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNamaSubCOA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOpB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditParent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditAccTyp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BtnCancelSubCOA As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnSaveSubCOA As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnDelSubCOA As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEditSubCOA As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnAddSubCOA As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEditSubCoa As DevExpress.XtraEditors.DateEdit
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtAccNoSubCOA As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNamaSubCOA As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOpB As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LookUpEditParent As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LookUpEditAccTyp As DevExpress.XtraEditors.LookUpEdit
End Class
