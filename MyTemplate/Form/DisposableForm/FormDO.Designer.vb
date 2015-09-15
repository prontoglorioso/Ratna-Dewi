<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDO
    Inherits DevExpress.XtraEditors.XtraForm

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
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.DropDownButton2 = New DevExpress.XtraEditors.DropDownButton()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.DropDownButton1 = New DevExpress.XtraEditors.DropDownButton()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Location = New System.Drawing.Point(19, 374)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(87, 23)
        Me.SimpleButton4.TabIndex = 73
        Me.SimpleButton4.Text = "Make Invoice"
        '
        'TextEdit5
        '
        Me.TextEdit5.Location = New System.Drawing.Point(78, 338)
        Me.TextEdit5.Name = "TextEdit5"
        ' = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.TextEdit5.Size = New System.Drawing.Size(750, 20)
        Me.TextEdit5.TabIndex = 71
        '
        'GridControl1
        '
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.Location = New System.Drawing.Point(12, 81)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1150, 251)
        Me.GridControl1.TabIndex = 74
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(19, 341)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl5.TabIndex = 72
        Me.LabelControl5.Text = "Description"
        '
        'DropDownButton2
        '
        Me.DropDownButton2.Location = New System.Drawing.Point(1027, 20)
        Me.DropDownButton2.Name = "DropDownButton2"
        Me.DropDownButton2.Size = New System.Drawing.Size(135, 23)
        Me.DropDownButton2.TabIndex = 70
        Me.DropDownButton2.Text = "Preview" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(19, 56)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl14.TabIndex = 65
        Me.LabelControl14.Text = "Delivery Date"
        '
        'DropDownButton1
        '
        Me.DropDownButton1.Location = New System.Drawing.Point(331, 22)
        Me.DropDownButton1.Name = "DropDownButton1"
        Me.DropDownButton1.Size = New System.Drawing.Size(135, 23)
        Me.DropDownButton1.TabIndex = 69
        Me.DropDownButton1.Text = "Select SO"
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(201, 56)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl13.TabIndex = 64
        Me.LabelControl13.Text = "Delivery No."
        '
        'TextEdit4
        '
        Me.TextEdit4.Location = New System.Drawing.Point(271, 53)
        Me.TextEdit4.Name = "TextEdit4"
        ' = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.TextEdit4.Size = New System.Drawing.Size(100, 20)
        Me.TextEdit4.TabIndex = 62
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(183, 403)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton2.TabIndex = 67
        Me.SimpleButton2.Text = "Cancel"
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(95, 53)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        ' = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.DateEdit1.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit1.TabIndex = 60
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(19, 403)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 66
        Me.SimpleButton1.Text = "Save New"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Location = New System.Drawing.Point(102, 403)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton3.TabIndex = 68
        Me.SimpleButton3.Text = "Save Close"
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.Location = New System.Drawing.Point(175, 25)
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        ' = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.LookUpEdit1.Properties.NullText = "PT Samsung Electronic Indonesia"
        Me.LookUpEdit1.Size = New System.Drawing.Size(141, 20)
        Me.LookUpEdit1.TabIndex = 63
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(17, 30)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl1.TabIndex = 59
        Me.LabelControl1.Text = "Customer"
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(69, 25)
        Me.TextEdit1.Name = "TextEdit1"
        ' = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.TextEdit1.Size = New System.Drawing.Size(100, 20)
        Me.TextEdit1.TabIndex = 61
        '
        'FormDO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 438)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.TextEdit5)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.DropDownButton2)
        Me.Controls.Add(Me.LabelControl14)
        Me.Controls.Add(Me.DropDownButton1)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.TextEdit4)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.DateEdit1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.LookUpEdit1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.TextEdit1)
        Me.Name = "FormDO"
        Me.Text = "FormDO"
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DropDownButton2 As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DropDownButton1 As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
End Class
