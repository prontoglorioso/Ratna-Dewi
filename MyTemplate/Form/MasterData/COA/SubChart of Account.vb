Public Class COA 
    
    Sub LoadData()
        GridControl1.SuspendLayout()
        oSubAccCOA.isDeleted = False

        GridControl1.DataSource = Nothing
        oSubAccCOA.Load(True)
        GridControl1.DataSource = oSubAccCOA.DataCOA.Tables("TabelCOA")
        GridControl1.Refresh()
        GridView1.BestFitColumns(True)

        GridView1.Columns(1).Caption = "Account Type"
        GridView1.Columns(2).Caption = "Account No"
        GridView1.Columns(3).Caption = "Account Name"
        GridView1.Columns(4).Caption = "Suspended"
        GridView1.Columns(5).Caption = "Sub Account Of"
        GridView1.Columns(6).Caption = "Opening Balance"
        GridView1.Columns(7).Caption = "As Of"

        GridView1.Columns(0).Visible = False


    End Sub

    Private Sub BtnSaveSubCOA_Click(sender As Object, e As EventArgs) Handles BtnSaveSubCOA.Click
        SwitchMode(Me, False)
        If Len(Trim(LookUpEditParent.Text)) = 0 Or Len(Trim(txtAccNoSubCOA.Text)) = 0 Or Len(Trim(txtNamaSubCOA.Text)) = 0 Or Len(Trim(LookUpEditAccTyp.Text)) = 0 Then

            DevExpress.XtraEditors.XtraMessageBox.Show("data has not been saved yet")
            Exit Sub

        End If

        oSubAccCOA.idTypeAcc = LookUpEditAccTyp.EditValue
        oSubAccCOA.kodeSubAccountCOA = txtAccNoSubCOA.Text
        oSubAccCOA.namaSubAccountCOA = txtNamaSubCOA.Text
        If Len(Trim(txtOpB.Text)) = 0 Then
            oSubAccCOA.balance = 0
        Else
            oSubAccCOA.balance = Convert.ToDecimal(txtOpB.Text)
        End If
        oSubAccCOA.Status = CheckEdit1.Checked

        If Len(Trim(DateEditSubCoa.Text)) = 0 Then
            oSubAccCOA.openingBalanceDate = Now
        Else
            oSubAccCOA.openingBalanceDate = DateEditSubCoa.EditValue
        End If

        oSubAccCOA.idParentAccount = LookUpEditParent.EditValue

        oSubAccCOA.Save(IsNew)
        If IsNew = True Then
            SetMessage("Save Data Succeeded")
        Else
            SetMessage(String.Format("Chart Of Account {0} Updated", txtAccNoSubCOA.Text))

        End If

        EmptyTxt(Me)
        LoadData()
        CanClose = True
        IsSaved = True
    End Sub

    Private Sub COA_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
       If CanClose = False Then
            e.Cancel = True
            SetMessage("Chart Of Account - data has not been saved yet")

        End If

    End Sub

    Private Sub COA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetFormAttribute()

        CanClose = True
        LoadData()
        loadComboTypeAccCOA()
        LoadComboParentAccount()


    End Sub

    Private Sub BtnCancelSubCOA_Click(sender As Object, e As EventArgs) Handles BtnCancelSubCOA.Click
        CanClose = True
        SetFormAttribute()
        ID = 0
        EmptyTxt(Me)

    End Sub

    Private Sub BtnAddSubCOA_Click(sender As Object, e As EventArgs) Handles BtnAddSubCOA.Click
        SwitchMode(Me, True)
        isNew = True
        CanClose = False
        txtAccNoSubCOA.Focus()

    End Sub

    Private Sub BtnDelSubCOA_Click(sender As Object, e As EventArgs) Handles BtnDelSubCOA.Click
        If oSubAccCOA.id = 0 Then
            XtraMessageBox.Show("Choose the data do you wish to delete?")
        End If
        If XtraMessageBox.Show("Do you wish to delete this data?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            oSubAccCOA.del()

        End If
        LoadData()
    End Sub

    Private Sub BtnEditSubCOA_Click(sender As Object, e As EventArgs) Handles BtnEditSubCOA.Click
        GetDetail()
        SwitchMode(Me, True)
        CanClose = False
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        oSubAccCOA.id = Convert.ToInt32(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns(0)))

    End Sub
    Sub loadComboTypeAccCOA()

        oHelper.getTypeAccCOA()
        LookUpEditAccTyp.Properties.DataSource = oHelper.DataTypeAcc.Tables(0)
        LookUpEditAccTyp.Properties.DisplayMember = "namaTypeAccount"
        LookUpEditAccTyp.Properties.ValueMember = "id"
    End Sub



    Private Sub LookUpEditMaster_EditValueChanged(sender As Object, e As EventArgs) Handles LookUpEditParent.EditValueChanged
        loadComboTypeAccCOA()
    End Sub

    
    Private Sub DateEditSubCoa_DateTimeChanged(sender As Object, e As EventArgs) Handles DateEditSubCoa.DateTimeChanged
        If Len(Trim(DateEditSubCoa.Text)) > 0 Then
            If DateEditSubCoa.EditValue > Date.Now Then
                DevExpress.XtraEditors.XtraMessageBox.Show("Wrong Date Input")
                DateEditSubCoa.Text = ""
            End If
        End If
    End Sub
    Sub LoadComboParentAccount()
        oHelper.idTypeAccount = LookUpEditAccTyp.EditValue
        oHelper.getParentAccount()
        LookUpEditParent.Properties.DataSource = oHelper.DataParentAccount.Tables(0)
        LookUpEditParent.Properties.ValueMember = "id"
        LookUpEditParent.Properties.DisplayMember = "namaParentAccount"
    End Sub
 
    Private Sub LookUpEditAccTyp_EditValueChanged(sender As Object, e As EventArgs) Handles LookUpEditAccTyp.EditValueChanged
        LoadComboParentAccount()
    End Sub
    Sub GetDetail()
        ID = Convert.ToInt32(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns(0)))
        oSubAccCOA.id = ID
        IsNew = False
        oSubAccCOA.Load(False)
        LookUpEditAccTyp.EditValue = oSubAccCOA.idTypeAcc
        txtAccNoSubCOA.Text = oSubAccCOA.kodeSubAccountCOA
        txtNamaSubCOA.Text = oSubAccCOA.namaSubAccountCOA
        CheckEdit1.EditValue = oSubAccCOA.Status
        txtOpB.Text = oSubAccCOA.balance
        DateEditSubCoa.EditValue = oSubAccCOA.openingBalanceDate
        LookUpEditParent.EditValue = oSubAccCOA.idParentAccount


    End Sub
End Class