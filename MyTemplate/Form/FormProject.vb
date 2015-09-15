Public Class FormProject
    Private Sub BtnSaveProject_Click(sender As Object, e As EventArgs) Handles BtnSaveProject.Click
        SwitchMode(Me, False)
        If Len(Trim(txtKodeProject.Text)) = 0 Or Len(Trim(txtNamaProject.Text)) = 0 Or Len(Trim(txtContactProject.Text)) = 0 Or Len(Trim(LookUpMarketing.EditValue)) = 0 Or Len(Trim(LookUpCustomer.EditValue)) = 0 Then

            DevExpress.XtraEditors.XtraMessageBox.Show("data has not been completed yet")
            Exit Sub
        End If

        oProject.projectNo = txtKodeProject.Text()
        oProject.projectName = txtNamaProject.Text()
        oProject.description = txtDescription.Text()
        oProject.contactName = txtContactProject.Text()
        oProject.idMarketing = LookUpMarketing.EditValue
        oProject.idCustomer = LookUpCustomer.EditValue

        oProject.Save(IsNew)
        If IsNew = True Then
            SetMessage("Save Data Succeeded")
        Else
            SetMessage(String.Format("Project Data {0} Updated", txtKodeProject.Text))
        End If

        EmptyTxt(Me)
        LoadData()
        CanClose = True
        IsSaved = True
    End Sub
    Sub LoadData()
        GridControl1.SuspendLayout()
        oProject.isDeleted = False

        GridControl1.DataSource = Nothing
        oProject.Load(True)
        GridControl1.DataSource = oProject.DataProject.Tables("TabelProject")
        GridControl1.Refresh()
        GridView1.BestFitColumns(True)

        GridView1.Columns(1).Caption = "Project Code"
        GridView1.Columns(2).Caption = "Project Name"
        GridView1.Columns(3).Caption = "Description"
        GridView1.Columns(4).Caption = "Contact Name"
        GridView1.Columns(5).Caption = "Marketing Name"
        GridView1.Columns(6).Caption = "Customer Code"
        
        GridView1.Columns(0).Visible = False
        GridView1.Columns(7).Visible = False
        GridView1.Columns(8).Visible = False
        GridView1.Columns(9).Visible = False
    End Sub
    Private Sub FormProject_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If CanClose = False Then
            e.Cancel = True
            SetMessage("PROJECT - data has not been saved yet")
        End If
    End Sub
    Private Sub FormProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetFormAttribute()
        CanClose = True
        LoadData()
        loadComboCustomer()
        loadComboMarketing()
    End Sub
    Private Sub BtnCancelProject_Click(sender As Object, e As EventArgs) Handles BtnCancelProject.Click
        CanClose = True
        SetFormAttribute()
        ID = 0
        EmptyTxt(Me)
    End Sub
    Private Sub BtnAddProject_Click(sender As Object, e As EventArgs) Handles BtnAddProject.Click
        SwitchMode(Me, True)
        IsNew = True
        CanClose = False
        txtKodeProject.Focus()
    End Sub

    Private Sub BtnDelProject_Click(sender As Object, e As EventArgs) Handles BtnDelProject.Click
        If oProject.id = 0 Then
            XtraMessageBox.Show("Choose the data do you wish to delete?")
        End If
        If XtraMessageBox.Show("Do you wish to delete this data?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            oProject.del()
        End If
        LoadData()
    End Sub

    Private Sub BtnEditProject_Click(sender As Object, e As EventArgs) Handles BtnEditProject.Click
        GetDetail()
        SwitchMode(Me, True)
        CanClose = False
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        oProject.id = Convert.ToInt32(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns(0)))
    End Sub
    Sub loadComboMarketing()
        oHelper.getMarketing()
        LookUpMarketing.Properties.DataSource = oHelper.DataMarketing.Tables(0)
        LookUpMarketing.Properties.DisplayMember = "namaKaryawan"
        LookUpMarketing.Properties.ValueMember = "id"
    End Sub
    Sub loadComboCustomer()
        oHelper.getCustomer()
        LookUpCustomer.Properties.DataSource = oHelper.DataCustomer.Tables(0)
        LookUpCustomer.Properties.DisplayMember = "nama"
        LookUpCustomer.Properties.ValueMember = "id"
    End Sub
    Sub GetDetail()
        ID = Convert.ToInt32(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns(0)))
        oProject.id = ID
        IsNew = False
        oProject.Load(False)
        txtKodeProject.Text = oProject.projectNo
        txtNamaProject.Text = oProject.projectName
        txtDescription.Text = oProject.description
        txtContactProject.Text = oProject.contactName
        LookUpMarketing.EditValue = oProject.idMarketing
        LookUpCustomer.EditValue = oProject.idCustomer
    End Sub
End Class