﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPurchaseInvoiceHeader
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPurchaseInvoiceHeader))
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.buttonSave = New DevExpress.XtraEditors.SimpleButton()
        Me.buttonDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.buttonAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl6
        '
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl6.LineVisible = True
        Me.LabelControl6.Location = New System.Drawing.Point(-5, 34)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(435, 13)
        Me.LabelControl6.TabIndex = 25
        '
        'buttonSave
        '
        Me.buttonSave.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.buttonSave.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.buttonSave.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.buttonSave.Appearance.Options.UseBackColor = True
        Me.buttonSave.Appearance.Options.UseBorderColor = True
        Me.buttonSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.buttonSave.Image = CType(resources.GetObject("buttonSave.Image"), System.Drawing.Image)
        Me.buttonSave.Location = New System.Drawing.Point(170, 5)
        Me.buttonSave.Name = "buttonSave"
        Me.buttonSave.Size = New System.Drawing.Size(76, 23)
        Me.buttonSave.TabIndex = 16
        Me.buttonSave.Tag = "save"
        Me.buttonSave.Text = "Save"
        '
        'buttonDelete
        '
        Me.buttonDelete.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.buttonDelete.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.buttonDelete.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.buttonDelete.Appearance.Options.UseBackColor = True
        Me.buttonDelete.Appearance.Options.UseBorderColor = True
        Me.buttonDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.buttonDelete.Image = CType(resources.GetObject("buttonDelete.Image"), System.Drawing.Image)
        Me.buttonDelete.Location = New System.Drawing.Point(89, 5)
        Me.buttonDelete.Name = "buttonDelete"
        Me.buttonDelete.Size = New System.Drawing.Size(75, 23)
        Me.buttonDelete.TabIndex = 18
        Me.buttonDelete.Tag = "view"
        Me.buttonDelete.Text = "Delete"
        '
        'buttonAdd
        '
        Me.buttonAdd.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.buttonAdd.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.buttonAdd.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.buttonAdd.Appearance.Options.UseBackColor = True
        Me.buttonAdd.Appearance.Options.UseBorderColor = True
        Me.buttonAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.buttonAdd.Image = CType(resources.GetObject("buttonAdd.Image"), System.Drawing.Image)
        Me.buttonAdd.Location = New System.Drawing.Point(8, 5)
        Me.buttonAdd.Name = "buttonAdd"
        Me.buttonAdd.Size = New System.Drawing.Size(75, 23)
        Me.buttonAdd.TabIndex = 12
        Me.buttonAdd.Tag = "add"
        Me.buttonAdd.Text = "Add"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(8, 179)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(692, 308)
        Me.GridControl1.TabIndex = 26
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'FormPurchaseInvoiceHeader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 489)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.buttonSave)
        Me.Controls.Add(Me.buttonDelete)
        Me.Controls.Add(Me.buttonAdd)
        Me.Name = "FormPurchaseInvoiceHeader"
        Me.Tag = "2200"
        Me.Text = "Position"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents buttonSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents buttonDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents buttonAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
