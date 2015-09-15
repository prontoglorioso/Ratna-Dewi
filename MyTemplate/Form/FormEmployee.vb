Public Class FormEmployee

  
    Sub loadDept()
        oHelper.getPosition()
        LookUpDept.Properties.DataSource = oHelper.DataPosition.Tables(0)
        LookUpDept.Properties.DisplayMember = "namaJabatan"
        LookUpDept.Properties.ValueMember = "id"

    End Sub
    Private Sub BtnSaveDept_Click(sender As Object, e As EventArgs) Handles BtnSaveDept.Click
        SwitchMode(Me, False)
        If Len(Trim(LookUpDept.Text)) = 0 Or Len(Trim(txtNamaKaryawan.Text)) = 0 Or Len(Trim(DateTglBergabung.Text)) = 0 Or Len(Trim(txtGapok.Text)) = 0 Then

            DevExpress.XtraEditors.XtraMessageBox.Show("data has not been completed yet")
            Exit Sub

        End If

        oEmployee.idJabatan = LookUpDept.EditValue
        oEmployee.namaKaryawan = txtNamaKaryawan.Text()
        oEmployee.tglBergabung = DateTglBergabung.DateTime
        oEmployee.gajiPokok = txtGapok.Text

        oEmployee.Save(IsNew)
        If IsNew = True Then
            SetMessage("Save Data Succeeded")
        Else
            SetMessage(String.Format("Employee Data {0} Updated", txtNamaKaryawan.Text))

        End If

        EmptyTxt(Me)
        LoadData()
        CanClose = True
        IsSaved = True


    End Sub
    Sub LoadData()
        GridControl1.SuspendLayout()
        oEmployee.isDeleted = False

        GridControl1.DataSource = Nothing
        oEmployee.Load(True)
        GridControl1.DataSource = oEmployee.DataEmployee.Tables("TabelEmployee")
        GridControl1.Refresh()
        GridView1.BestFitColumns(True)

        GridView1.Columns(2).Caption = "Position Name"
        GridView1.Columns(3).Caption = "Employee Name"
        GridView1.Columns(5).Caption = "Salary Balance"
        GridView1.Columns(4).Caption = "Start Work Since"



        GridView1.Columns(0).Visible = False
        GridView1.Columns(1).Visible = False
        GridView1.Columns(6).Visible = False
    End Sub

    Private Sub FormEmployee_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If CanClose = False Then
            e.Cancel = True
            SetMessage("EMPLOYEE - data has not been saved yet")

        End If

    End Sub

    Private Sub FormEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SetFormAttribute()

        CanClose = True
        LoadData()
        loadDept()
        LookUpDept.Focus()

    End Sub

    Private Sub BtnAddDept_Click(sender As Object, e As EventArgs) Handles BtnAddDept.Click

        SwitchMode(Me, True)
        IsNew = True
        CanClose = False

    End Sub

    Private Sub BtnCancelDept_Click(sender As Object, e As EventArgs) Handles BtnCancelDept.Click

        CanClose = True
        SetFormAttribute()
        ID = 0
        EmptyTxt(Me)

    End Sub

    Private Sub BtnDelDept_Click(sender As Object, e As EventArgs) Handles BtnDelDept.Click

        If oEmployee.id = 0 Then
            XtraMessageBox.Show("Choose the data do you wish to delete?")
        End If
        If XtraMessageBox.Show("Do you wish to delete this data?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            oEmployee.del()

        End If
        LoadData()

    End Sub

    Private Sub BtnEditDept_Click(sender As Object, e As EventArgs) Handles BtnEditDept.Click
        GetDetail()
        SwitchMode(Me, True)
        CanClose = False
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        oEmployee.id = Convert.ToInt32(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns(0)))


    End Sub

    Private Sub DateTglBergabung_DateTimeChanged(sender As Object, e As EventArgs) Handles DateTglBergabung.DateTimeChanged
        If Len(Trim(DateTglBergabung.Text)) > 0 Then
            If DateTglBergabung.EditValue > Date.Now Then
                DevExpress.XtraEditors.XtraMessageBox.Show("Wrong input date")
                DateTglBergabung.Text = ""
            End If
        End If

    End Sub
    Sub GetDetail()
        ID = Convert.ToInt32(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns(0)))
        oEmployee.id = ID
        IsNew = False
        oEmployee.Load(False)
        

        LookUpDept.EditValue = oEmployee.idJabatan
        txtNamaKaryawan.Text = oEmployee.namaKaryawan
        DateTglBergabung.EditValue = oEmployee.tglBergabung
        txtGapok.EditValue = oEmployee.gajiPokok
        

    End Sub

  
End Class