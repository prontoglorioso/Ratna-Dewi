Public Class FormHeaderItem
    Sub LoadData()
        GridControl1.SuspendLayout()
        oHeaderItem.id = False

        GridControl1.DataSource = Nothing
        oHeaderItem.Load(True)
        GridControl1.DataSource = oHeaderItem.DataHeaderItem.Tables("TabelHeaderItem")
        GridControl1.Refresh()
        GridView1.BestFitColumns(True)
        GridView1.Columns(0).Visible = False
        GridView1.Columns(1).Caption = "Item Name"
        GridView1.Columns(2).Caption = "Type Item"

    End Sub

    Private Sub FormHeaderItem_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If CanClose = False Then
            e.Cancel = True
            SetMessage("HEADER ITEM - data has not been saved yet")

        End If
    End Sub
    Private Sub HeaderItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetFormAttribute()
        CanClose = True
        LoadData()
    End Sub

    Private Sub BtnCancelHeaderItem_Click(sender As Object, e As EventArgs) Handles BtnCancelHeaderItem.Click
        CanClose = True
        SetFormAttribute()
        id = 0
        EmptyTxt(Me)
    End Sub

    Private Sub BtnDelHeaderItem_Click(sender As Object, e As EventArgs) Handles BtnDelHeaderItem.Click
        If oHeaderItem.id = 0 Then
            XtraMessageBox.Show("Choose the data do you wish to delete?")
        End If
        If XtraMessageBox.Show("Do you wish to delete this data?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            oHeaderItem.del()

        End If
        LoadData()
    End Sub
    Private Sub BtnEditHeaderItem_Click(sender As Object, e As EventArgs) Handles BtnEditHeaderItem.Click
        GetDetail()
        SwitchMode(Me, True)
        CanClose = False
    End Sub

    Private Sub BtnAddHeaderItem_Click(sender As Object, e As EventArgs) Handles BtnAddHeaderItem.Click
        SwitchMode(Me, True)
        IsNew = True
        CanClose = False
        txtNamaHeaderItem.Focus()
    End Sub


    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        oHeaderItem.id = Convert.ToInt32(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns(0)))

    End Sub

    Private Sub BtnSaveHeaderItem_Click(sender As Object, e As EventArgs) Handles BtnSaveHeaderItem.Click
        SwitchMode(Me, False)
        If Len(Trim(txtNamaHeaderItem.Text)) = 0 Or Len(Trim(RadioGroup1.EditValue)) = 0 Then

            DevExpress.XtraEditors.XtraMessageBox.Show("data has not been completed yet")
            Exit Sub

        End If

        oHeaderItem.namaHeaderItem = txtNamaHeaderItem.Text()
        oHeaderItem.typeItem = RadioGroup1.EditValue()

        oHeaderItem.Save(IsNew)
        If IsNew = True Then
            SetMessage("Save Data Succeeded")
        Else
            SetMessage(String.Format("Header Item Data {0} Updated", txtNamaHeaderItem.Text))

        End If

        EmptyTxt(Me)
        LoadData()
        CanClose = True
        IsSaved = True

    End Sub
    Sub GetDetail()
        ID = Convert.ToInt32(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns(0)))
        oHeaderItem.id = ID
        IsNew = False
        oHeaderItem.Load(False)
        txtNamaHeaderItem.Text = oHeaderItem.namaHeaderItem
        RadioGroup1.EditValue = oHeaderItem.typeItem
    End Sub
End Class