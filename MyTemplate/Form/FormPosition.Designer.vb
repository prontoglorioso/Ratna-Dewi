<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPosition
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPosition))
        Me.txtJabatan = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.BtnCancelPosition = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnSavePosition = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnDelPosition = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnEditPosition = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnAddPosition = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.txtJabatan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtJabatan
        '
        Me.txtJabatan.Location = New System.Drawing.Point(145, 47)
        Me.txtJabatan.Name = "txtJabatan"
        Me.txtJabatan.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.txtJabatan.Properties.MaxLength = 30
        Me.txtJabatan.Size = New System.Drawing.Size(220, 20)
        Me.txtJabatan.TabIndex = 5
        Me.txtJabatan.Tag = "input"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(19, 54)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Position Name"
        '
        'BtnCancelPosition
        '
        Me.BtnCancelPosition.Image = CType(resources.GetObject("BtnCancelPosition.Image"), System.Drawing.Image)
        Me.BtnCancelPosition.Location = New System.Drawing.Point(19, 187)
        Me.BtnCancelPosition.Name = "BtnCancelPosition"
        Me.BtnCancelPosition.Size = New System.Drawing.Size(339, 40)
        Me.BtnCancelPosition.TabIndex = 4
        Me.BtnCancelPosition.Tag = "cancel"
        Me.BtnCancelPosition.Text = "Cancel"
        '
        'BtnSavePosition
        '
        Me.BtnSavePosition.Image = CType(resources.GetObject("BtnSavePosition.Image"), System.Drawing.Image)
        Me.BtnSavePosition.Location = New System.Drawing.Point(278, 109)
        Me.BtnSavePosition.Name = "BtnSavePosition"
        Me.BtnSavePosition.Size = New System.Drawing.Size(80, 40)
        Me.BtnSavePosition.TabIndex = 3
        Me.BtnSavePosition.Tag = "save"
        Me.BtnSavePosition.Text = "Save"
        '
        'BtnDelPosition
        '
        Me.BtnDelPosition.Image = CType(resources.GetObject("BtnDelPosition.Image"), System.Drawing.Image)
        Me.BtnDelPosition.Location = New System.Drawing.Point(192, 109)
        Me.BtnDelPosition.Name = "BtnDelPosition"
        Me.BtnDelPosition.Size = New System.Drawing.Size(80, 40)
        Me.BtnDelPosition.TabIndex = 2
        Me.BtnDelPosition.Tag = "view"
        Me.BtnDelPosition.Text = "Delete"
        '
        'BtnEditPosition
        '
        Me.BtnEditPosition.Image = CType(resources.GetObject("BtnEditPosition.Image"), System.Drawing.Image)
        Me.BtnEditPosition.Location = New System.Drawing.Point(106, 109)
        Me.BtnEditPosition.Name = "BtnEditPosition"
        Me.BtnEditPosition.Size = New System.Drawing.Size(80, 40)
        Me.BtnEditPosition.TabIndex = 1
        Me.BtnEditPosition.Tag = "edit"
        Me.BtnEditPosition.Text = "Edit"
        '
        'BtnAddPosition
        '
        Me.BtnAddPosition.Image = CType(resources.GetObject("BtnAddPosition.Image"), System.Drawing.Image)
        Me.BtnAddPosition.Location = New System.Drawing.Point(20, 109)
        Me.BtnAddPosition.Name = "BtnAddPosition"
        Me.BtnAddPosition.Size = New System.Drawing.Size(80, 40)
        Me.BtnAddPosition.TabIndex = 0
        Me.BtnAddPosition.Tag = "add"
        Me.BtnAddPosition.Text = "Add"
        '
        'GridControl1
        '
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.Location = New System.Drawing.Point(380, 50)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(793, 211)
        Me.GridControl1.TabIndex = 28
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'FormPosition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.BtnCancelPosition)
        Me.Controls.Add(Me.BtnSavePosition)
        Me.Controls.Add(Me.BtnDelPosition)
        Me.Controls.Add(Me.BtnEditPosition)
        Me.Controls.Add(Me.BtnAddPosition)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtJabatan)
        Me.Name = "FormPosition"
        Me.Tag = "1100"
        Me.Text = "Position"
        CType(Me.txtJabatan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtJabatan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BtnCancelPosition As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnSavePosition As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnDelPosition As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEditPosition As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnAddPosition As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
