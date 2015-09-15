Public Class FormItem

    Sub LoadData()

        GridControl1.SuspendLayout()
        oItem.id = False

        GridControl1.DataSource = Nothing
        oItem.Load(True)
        GridControl1.DataSource = oItem.DataItem.Tables("TabelItem")
        GridControl1.Refresh()
        GridView1.BestFitColumns(True)
        GridView1.Columns(0).Visible = False
        GridView1.Columns(10).Visible = False
        GridView1.Columns(9).Caption = "Item Type"
        GridView1.Columns(1).Caption = "Sub Item Of"
        GridView1.Columns(2).Caption = "Item Code"
        GridView1.Columns(3).Caption = "Item Name"
        GridView1.Columns(4).Caption = "Suspended"
        GridView1.Columns(5).Caption = "Qty"
        GridView1.Columns(6).Caption = "Unit"
        GridView1.Columns(7).Caption = "Cost"
        GridView1.Columns(8).Caption = "As Of"


       
    End Sub

    Private Sub BtnAddItem_Click(sender As Object, e As EventArgs) Handles BtnAddItem.Click
        SwitchMode(Me, True)
        IsNew = True
        CanClose = False
    End Sub

    Private Sub BtnCancelItem_Click(sender As Object, e As EventArgs) Handles BtnCancelItem.Click
        CanClose = True
        SetFormAttribute()
        ID = 0
        EmptyTxt(Me)
    End Sub

    Private Sub FormItem_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If CanClose = False Then
            e.Cancel = True
            SetMessage("ITEM - data has not been saved yet")

        End If
    End Sub
    Private Sub FormItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetFormAttribute()
        CanClose = True
        LoadData()
    End Sub
    Private Sub BtnDelItem_Click(sender As Object, e As EventArgs) Handles BtnDelItem.Click
        If oItem.id = 0 Then
            XtraMessageBox.Show("Choose the data do you wish to delete?")
        End If
        If XtraMessageBox.Show("Do you wish to delete this data?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            oItem.del()

        End If
        LoadData()
    End Sub
    Private Sub BtnEditItem_Click(sender As Object, e As EventArgs) Handles BtnEditItem.Click
        GetDetail()
        SwitchMode(Me, True)
        CanClose = False
    End Sub
    Private Sub RadioGroup1_EditValueChanged(sender As Object, e As EventArgs) Handles RadioGroup1.EditValueChanged

        If RadioGroup1.EditValue = True Then

            txtQty.Enabled = True
            txtCost.Enabled = True

            DateEditItem.Enabled = True
            oHelper.TypeItem = True
        Else
            txtQty.Enabled = False
            txtCost.Enabled = False

            DateEditItem.Enabled = False
            oHelper.TypeItem = False

        End If

        oHelper.getHeaderItem()

        LookUpItemType.Properties.DataSource = oHelper.DataHeaderItem.Tables(0)
        LookUpItemType.Properties.DisplayMember = "namaHeader"
        LookUpItemType.Properties.ValueMember = "id"
    End Sub
    Private Sub BtnSaveItem_Click(sender As Object, e As EventArgs) Handles BtnSaveItem.Click
        SwitchMode(Me, False)
        If RadioGroup1.EditValue = True Then
            If Len(Trim(LookUpItemType.EditValue)) = 0 Or Len(Trim(RadioGroup1.EditValue)) = 0 Or Len(Trim(txtAccNoItem.Text)) = 0 Or Len(Trim(txtNamaItem.Text)) = 0 Or Len(Trim(txtUnit.Text)) = 0 Then
                DevExpress.XtraEditors.XtraMessageBox.Show("data has not been completed yet")
                Exit Sub
            End If
            oItem.idHeaderItem = LookUpItemType.EditValue()
            oItem.kodeItem = txtAccNoItem.Text()
            oItem.namaItem = txtNamaItem.Text()
            oItem.status = CheckEdit1.Checked()

            If Len(Trim(txtQty.Text)) = 0 Then
                oItem.qty = 0
            Else
                oItem.qty = txtQty.Text()

            End If


            If Len(Trim(txtCost.Text)) = 0 Then
                oItem.cost = 0
            Else
                oItem.cost = txtCost.Text()
            End If

            If Len(Trim(DateEditItem.EditValue)) = 0 Then
                oItem.openingbalancedate = Now
            Else
                oItem.openingbalancedate = DateEditItem.EditValue()
            End If
            oItem.unit = txtUnit.Text
       
        oItem.typeItem = RadioGroup1.EditValue()
        oItem.Save(IsNew)

        If IsNew = True Then
            SetMessage("Save Data Succeeded")
        Else
            SetMessage(String.Format("Item Data {0} Updated", txtAccNoItem.Text))

        End If
        Else
        If Len(Trim(LookUpItemType.EditValue)) = 0 Or Len(Trim(RadioGroup1.EditValue)) = 0 Or Len(Trim(txtAccNoItem.Text)) = 0 Or Len(Trim(txtNamaItem.Text)) = 0 Or Len(Trim(txtUnit.Text)) = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show("data has not been completed yet")
            Exit Sub

        End If
        oItem.idHeaderItem = LookUpItemType.EditValue()
        oItem.kodeItem = txtAccNoItem.Text()
        oItem.namaItem = txtNamaItem.Text()
        oItem.status = CheckEdit1.Checked()
        oItem.qty = 0
        oItem.unit = txtUnit.Text()
        oItem.cost = 0
        oItem.openingbalancedate = Now
        oItem.typeItem = RadioGroup1.EditValue()
        oItem.Save(IsNew)
        End If
        EmptyTxt(Me)
        LoadData()
        CanClose = True
        IsSaved = True
    End Sub
    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        oItem.id = Convert.ToInt32(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns(0)))
    End Sub
    Sub GetDetail()
        ID = Convert.ToInt32(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns(0)))
        oItem.id = ID
        IsNew = False
        oItem.Load(False)
        LookUpItemType.EditValue = oItem.idHeaderItem
        txtAccNoItem.Text = oItem.kodeItem
        txtNamaItem.Text = oItem.namaItem
        RadioGroup1.EditValue = oItem.status
        txtQty.EditValue = oItem.qty
        txtUnit.Text = oItem.unit
        txtCost.Text = oItem.cost
        DateEditItem.EditValue = oItem.openingbalancedate
        RadioGroup1.EditValue = oItem.typeItem
    End Sub

    Private Sub DateEditItem_DateTimeChanged(sender As Object, e As EventArgs) Handles DateEditItem.DateTimeChanged
        If Len(Trim(DateEditItem.EditValue)) > 0 Then
            If DateEditItem.EditValue > Date.Now Then
                DevExpress.XtraEditors.XtraMessageBox.Show("Wrong input date")
                DateEditItem.Text = ""
            End If
        End If
    End Sub
End Class