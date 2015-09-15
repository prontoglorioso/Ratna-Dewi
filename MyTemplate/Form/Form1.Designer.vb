<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim IDLabel As System.Windows.Forms.Label
        Dim IDHeaderPOLabel As System.Windows.Forms.Label
        Dim TglRILabel As System.Windows.Forms.Label
        Dim NoRILabel As System.Windows.Forms.Label
        Dim DescriptionRILabel As System.Windows.Forms.Label
        Dim IDSubAccCOALabel As System.Windows.Forms.Label
        Dim IsDeletedLabel As System.Windows.Forms.Label
        Me.DataSetRI = New MyTemplate.DataSetRI()
        Me.HeaderRI_DataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HeaderRI_DataTableTableAdapter = New MyTemplate.DataSetRITableAdapters.HeaderRI_DataTableTableAdapter()
        Me.TableAdapterManagerHeaderRI = New MyTemplate.DataSetRITableAdapters.TableAdapterManager()
        Me.HeaderRI_DataTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.HeaderRI_DataTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FillToolStrip = New System.Windows.Forms.ToolStrip()
        Me.IdHeaderPoToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.IdHeaderPoToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.HeaderRI_DataTableGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.IDSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.IDHeaderPOTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TglRIDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.NoRITextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DescriptionRITextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IDSubAccCOASpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.IsDeletedCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        IDLabel = New System.Windows.Forms.Label()
        IDHeaderPOLabel = New System.Windows.Forms.Label()
        TglRILabel = New System.Windows.Forms.Label()
        NoRILabel = New System.Windows.Forms.Label()
        DescriptionRILabel = New System.Windows.Forms.Label()
        IDSubAccCOALabel = New System.Windows.Forms.Label()
        IsDeletedLabel = New System.Windows.Forms.Label()
        CType(Me.DataSetRI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderRI_DataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderRI_DataTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderRI_DataTableBindingNavigator.SuspendLayout()
        Me.FillToolStrip.SuspendLayout()
        CType(Me.HeaderRI_DataTableGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDHeaderPOTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TglRIDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TglRIDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoRITextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescriptionRITextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDSubAccCOASpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsDeletedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetRI
        '
        Me.DataSetRI.DataSetName = "DataSetRI"
        Me.DataSetRI.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HeaderRI_DataTableBindingSource
        '
        Me.HeaderRI_DataTableBindingSource.DataMember = "HeaderRI_DataTable"
        Me.HeaderRI_DataTableBindingSource.DataSource = Me.DataSetRI
        '
        'HeaderRI_DataTableTableAdapter
        '
        Me.HeaderRI_DataTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManagerHeaderRI
        '
        Me.TableAdapterManagerHeaderRI.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManagerHeaderRI.HeaderRI_DataTableTableAdapter = Me.HeaderRI_DataTableTableAdapter
        Me.TableAdapterManagerHeaderRI.UpdateOrder = MyTemplate.DataSetRITableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'HeaderRI_DataTableBindingNavigator
        '
        Me.HeaderRI_DataTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.HeaderRI_DataTableBindingNavigator.BindingSource = Me.HeaderRI_DataTableBindingSource
        Me.HeaderRI_DataTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.HeaderRI_DataTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.HeaderRI_DataTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.HeaderRI_DataTableBindingNavigatorSaveItem})
        Me.HeaderRI_DataTableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.HeaderRI_DataTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.HeaderRI_DataTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.HeaderRI_DataTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.HeaderRI_DataTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.HeaderRI_DataTableBindingNavigator.Name = "HeaderRI_DataTableBindingNavigator"
        Me.HeaderRI_DataTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.HeaderRI_DataTableBindingNavigator.Size = New System.Drawing.Size(572, 25)
        Me.HeaderRI_DataTableBindingNavigator.TabIndex = 0
        Me.HeaderRI_DataTableBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'HeaderRI_DataTableBindingNavigatorSaveItem
        '
        Me.HeaderRI_DataTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HeaderRI_DataTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("HeaderRI_DataTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.HeaderRI_DataTableBindingNavigatorSaveItem.Name = "HeaderRI_DataTableBindingNavigatorSaveItem"
        Me.HeaderRI_DataTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.HeaderRI_DataTableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FillToolStrip
        '
        Me.FillToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IdHeaderPoToolStripLabel, Me.IdHeaderPoToolStripTextBox, Me.FillToolStripButton})
        Me.FillToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillToolStrip.Name = "FillToolStrip"
        Me.FillToolStrip.Size = New System.Drawing.Size(572, 25)
        Me.FillToolStrip.TabIndex = 1
        Me.FillToolStrip.Text = "FillToolStrip"
        '
        'IdHeaderPoToolStripLabel
        '
        Me.IdHeaderPoToolStripLabel.Name = "IdHeaderPoToolStripLabel"
        Me.IdHeaderPoToolStripLabel.Size = New System.Drawing.Size(72, 22)
        Me.IdHeaderPoToolStripLabel.Text = "IdHeaderPo:"
        '
        'IdHeaderPoToolStripTextBox
        '
        Me.IdHeaderPoToolStripTextBox.Name = "IdHeaderPoToolStripTextBox"
        Me.IdHeaderPoToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillToolStripButton
        '
        Me.FillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillToolStripButton.Name = "FillToolStripButton"
        Me.FillToolStripButton.Size = New System.Drawing.Size(26, 22)
        Me.FillToolStripButton.Text = "Fill"
        '
        'HeaderRI_DataTableGridControl
        '
        Me.HeaderRI_DataTableGridControl.DataSource = Me.HeaderRI_DataTableBindingSource
        Me.HeaderRI_DataTableGridControl.Location = New System.Drawing.Point(43, 211)
        Me.HeaderRI_DataTableGridControl.MainView = Me.GridView1
        Me.HeaderRI_DataTableGridControl.Name = "HeaderRI_DataTableGridControl"
        Me.HeaderRI_DataTableGridControl.Size = New System.Drawing.Size(300, 129)
        Me.HeaderRI_DataTableGridControl.TabIndex = 2
        Me.HeaderRI_DataTableGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.HeaderRI_DataTableGridControl
        Me.GridView1.Name = "GridView1"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(25, 88)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 3
        IDLabel.Text = "ID:"
        '
        'IDSpinEdit
        '
        Me.IDSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.HeaderRI_DataTableBindingSource, "ID", True))
        Me.IDSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.IDSpinEdit.Location = New System.Drawing.Point(52, 85)
        Me.IDSpinEdit.Name = "IDSpinEdit"
        Me.IDSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IDSpinEdit.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.IDSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.IDSpinEdit.TabIndex = 4
        '
        'IDHeaderPOLabel
        '
        IDHeaderPOLabel.AutoSize = True
        IDHeaderPOLabel.Location = New System.Drawing.Point(227, 85)
        IDHeaderPOLabel.Name = "IDHeaderPOLabel"
        IDHeaderPOLabel.Size = New System.Drawing.Size(74, 13)
        IDHeaderPOLabel.TabIndex = 5
        IDHeaderPOLabel.Text = "IDHeader PO:"
        '
        'IDHeaderPOTextEdit
        '
        Me.IDHeaderPOTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.HeaderRI_DataTableBindingSource, "IDHeaderPO", True))
        Me.IDHeaderPOTextEdit.Location = New System.Drawing.Point(307, 82)
        Me.IDHeaderPOTextEdit.Name = "IDHeaderPOTextEdit"
        Me.IDHeaderPOTextEdit.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.IDHeaderPOTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.IDHeaderPOTextEdit.TabIndex = 6
        '
        'TglRILabel
        '
        TglRILabel.AutoSize = True
        TglRILabel.Location = New System.Drawing.Point(42, 128)
        TglRILabel.Name = "TglRILabel"
        TglRILabel.Size = New System.Drawing.Size(35, 13)
        TglRILabel.TabIndex = 7
        TglRILabel.Text = "tgl RI:"
        '
        'TglRIDateEdit
        '
        Me.TglRIDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.HeaderRI_DataTableBindingSource, "tglRI", True))
        Me.TglRIDateEdit.EditValue = Nothing
        Me.TglRIDateEdit.Location = New System.Drawing.Point(83, 125)
        Me.TglRIDateEdit.Name = "TglRIDateEdit"
        Me.TglRIDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TglRIDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TglRIDateEdit.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.TglRIDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.TglRIDateEdit.TabIndex = 8
        '
        'NoRILabel
        '
        NoRILabel.AutoSize = True
        NoRILabel.Location = New System.Drawing.Point(232, 126)
        NoRILabel.Name = "NoRILabel"
        NoRILabel.Size = New System.Drawing.Size(38, 13)
        NoRILabel.TabIndex = 9
        NoRILabel.Text = "No RI:"
        '
        'NoRITextEdit
        '
        Me.NoRITextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.HeaderRI_DataTableBindingSource, "NoRI", True))
        Me.NoRITextEdit.Location = New System.Drawing.Point(276, 123)
        Me.NoRITextEdit.Name = "NoRITextEdit"
        Me.NoRITextEdit.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.NoRITextEdit.Size = New System.Drawing.Size(100, 20)
        Me.NoRITextEdit.TabIndex = 10
        '
        'DescriptionRILabel
        '
        DescriptionRILabel.AutoSize = True
        DescriptionRILabel.Location = New System.Drawing.Point(45, 168)
        DescriptionRILabel.Name = "DescriptionRILabel"
        DescriptionRILabel.Size = New System.Drawing.Size(77, 13)
        DescriptionRILabel.TabIndex = 11
        DescriptionRILabel.Text = "Description RI:"
        '
        'DescriptionRITextEdit
        '
        Me.DescriptionRITextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.HeaderRI_DataTableBindingSource, "DescriptionRI", True))
        Me.DescriptionRITextEdit.Location = New System.Drawing.Point(128, 165)
        Me.DescriptionRITextEdit.Name = "DescriptionRITextEdit"
        Me.DescriptionRITextEdit.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.DescriptionRITextEdit.Size = New System.Drawing.Size(100, 20)
        Me.DescriptionRITextEdit.TabIndex = 12
        '
        'IDSubAccCOALabel
        '
        IDSubAccCOALabel.AutoSize = True
        IDSubAccCOALabel.Location = New System.Drawing.Point(281, 165)
        IDSubAccCOALabel.Name = "IDSubAccCOALabel"
        IDSubAccCOALabel.Size = New System.Drawing.Size(87, 13)
        IDSubAccCOALabel.TabIndex = 13
        IDSubAccCOALabel.Text = "IDSub Acc COA:"
        '
        'IDSubAccCOASpinEdit
        '
        Me.IDSubAccCOASpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.HeaderRI_DataTableBindingSource, "IDSubAccCOA", True))
        Me.IDSubAccCOASpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.IDSubAccCOASpinEdit.Location = New System.Drawing.Point(374, 162)
        Me.IDSubAccCOASpinEdit.Name = "IDSubAccCOASpinEdit"
        Me.IDSubAccCOASpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IDSubAccCOASpinEdit.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.IDSubAccCOASpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.IDSubAccCOASpinEdit.TabIndex = 14
        '
        'IsDeletedLabel
        '
        IsDeletedLabel.AutoSize = True
        IsDeletedLabel.Location = New System.Drawing.Point(414, 214)
        IsDeletedLabel.Name = "IsDeletedLabel"
        IsDeletedLabel.Size = New System.Drawing.Size(57, 13)
        IsDeletedLabel.TabIndex = 15
        IsDeletedLabel.Text = "is Deleted:"
        '
        'IsDeletedCheckEdit
        '
        Me.IsDeletedCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.HeaderRI_DataTableBindingSource, "isDeleted", True))
        Me.IsDeletedCheckEdit.Location = New System.Drawing.Point(477, 211)
        Me.IsDeletedCheckEdit.Name = "IsDeletedCheckEdit"
        Me.IsDeletedCheckEdit.Properties.Caption = "CheckEdit1"
        Me.IsDeletedCheckEdit.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.IsDeletedCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.IsDeletedCheckEdit.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 360)
        Me.Controls.Add(IsDeletedLabel)
        Me.Controls.Add(Me.IsDeletedCheckEdit)
        Me.Controls.Add(IDSubAccCOALabel)
        Me.Controls.Add(Me.IDSubAccCOASpinEdit)
        Me.Controls.Add(DescriptionRILabel)
        Me.Controls.Add(Me.DescriptionRITextEdit)
        Me.Controls.Add(NoRILabel)
        Me.Controls.Add(Me.NoRITextEdit)
        Me.Controls.Add(TglRILabel)
        Me.Controls.Add(Me.TglRIDateEdit)
        Me.Controls.Add(IDHeaderPOLabel)
        Me.Controls.Add(Me.IDHeaderPOTextEdit)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDSpinEdit)
        Me.Controls.Add(Me.HeaderRI_DataTableGridControl)
        Me.Controls.Add(Me.FillToolStrip)
        Me.Controls.Add(Me.HeaderRI_DataTableBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataSetRI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeaderRI_DataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeaderRI_DataTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderRI_DataTableBindingNavigator.ResumeLayout(False)
        Me.HeaderRI_DataTableBindingNavigator.PerformLayout()
        Me.FillToolStrip.ResumeLayout(False)
        Me.FillToolStrip.PerformLayout()
        CType(Me.HeaderRI_DataTableGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDHeaderPOTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TglRIDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TglRIDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoRITextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescriptionRITextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDSubAccCOASpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsDeletedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSetRI As MyTemplate.DataSetRI
    Friend WithEvents HeaderRI_DataTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HeaderRI_DataTableTableAdapter As MyTemplate.DataSetRITableAdapters.HeaderRI_DataTableTableAdapter
    Friend WithEvents TableAdapterManagerHeaderRI As MyTemplate.DataSetRITableAdapters.TableAdapterManager
    Friend WithEvents HeaderRI_DataTableBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HeaderRI_DataTableBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FillToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents IdHeaderPoToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents IdHeaderPoToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents HeaderRI_DataTableGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IDSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents IDHeaderPOTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TglRIDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents NoRITextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DescriptionRITextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IDSubAccCOASpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents IsDeletedCheckEdit As DevExpress.XtraEditors.CheckEdit
End Class
