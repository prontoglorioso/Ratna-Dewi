Public Class FormPosition 
    
    Private Sub BtnCancelVendor_Click(sender As Object, e As EventArgs) Handles BtnCancelPosition.Click
        CanClose = True
        SetFormAttribute()
        ID = 0
        EmptyTxt(Me)

    End Sub

    Private Sub FormPosition_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If CanClose = False Then
            e.Cancel = True
            SetMessage("POSITION - data has not been saved yet")

        End If
    End Sub

    Private Sub FormPosition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetFormAttribute()
        CanClose = True
        LoadData()
    End Sub
    Sub LoadData()
        GridControl1.SuspendLayout()
        oPosition.isDeleted = False

        GridControl1.DataSource = Nothing
        oPosition.Load(True)
        GridControl1.DataSource = oPosition.DataPosition.Tables("TabelPosition")
        GridControl1.Refresh()
        GridView1.BestFitColumns(True)

        GridView1.Columns(1).Caption = "Position Name"
       

        GridView1.Columns(0).Visible = False
        GridView1.Columns(2).Visible = False
    End Sub

    Private Sub BtnAddPosition_Click(sender As Object, e As EventArgs) Handles BtnAddPosition.Click

        SwitchMode(Me, True)
        isNew = True
        CanClose = False
        txtJabatan.Focus()

    End Sub
    
    Private Sub BtnSavePosition_Click(sender As Object, e As EventArgs) Handles BtnSavePosition.Click
        SwitchMode(Me, False)
        If Len(Trim(txtJabatan.Text)) = 0 Then

            DevExpress.XtraEditors.XtraMessageBox.Show("data has not been completed yet")
            Exit Sub

        End If
        oPosition.namaJabatan = txtJabatan.EditValue
        Try
            oPosition.Save(IsNew)
            If IsNew = True Then
                SetMessage("Save Data Succeeded")
            Else
                SetMessage(String.Format("Position Data {0} Updated", txtJabatan.Text))

            End If
        Catch ex As Exception

        End Try
        EmptyTxt(Me)
        LoadData()
        CanClose = True
        IsSaved = True

    End Sub
   
    Private Sub BtnEditPosition_Click(sender As Object, e As EventArgs) Handles BtnEditPosition.Click

        GetDetail()
        SwitchMode(Me, True)
        CanClose = False
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged

        oPosition.id = Convert.ToInt32(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns(0)))

    End Sub

    Private Sub BtnDelPosition_Click(sender As Object, e As EventArgs) Handles BtnDelPosition.Click
        If BtnDelPosition.Text.ToLower = "non active" Then

            If XtraMessageBox.Show("Do you wish to delete this data?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                oPosition.del()
                LoadData()
            End If

        Else

            If XtraMessageBox.Show("Do you wish to restore this data?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                oPosition.Restore()
                LoadData2()
            End If
        End If
    End Sub
    Sub GetDetail()
        ID = Convert.ToInt32(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns(0)))
        oPosition.id = ID
        IsNew = False
        oPosition.Load(False)
        txtJabatan.Text = oPosition.namaJabatan

    End Sub
    Private Sub CheckEdit1_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckStateChanged
        If CheckEdit1.CheckState = CheckState.Checked Then
            LoadData2()
            BtnDelPosition.Text = "Restore"
        Else
            LoadData()
            BtnDelPosition.Text = "Non Active"

        End If
    End Sub
    Sub LoadData2()
        GridControl1.SuspendLayout()
        oPosition.isDeleted = False
        GridControl1.DataSource = Nothing
        oPosition.Load2()
        GridControl1.DataSource = oPosition.DataPosition.Tables("TabelPosition")
        GridControl1.Refresh()
        GridView1.BestFitColumns(True)
        GridView1.Columns(1).Caption = "Position Name"
        GridView1.Columns(0).Visible = False
        GridView1.Columns(2).Visible = False
    End Sub
End Class