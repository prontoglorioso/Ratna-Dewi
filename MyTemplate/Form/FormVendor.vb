Public Class FormVendor 
   
    Private Sub BtnSaveVendor_Click(sender As Object, e As EventArgs) Handles BtnSaveVendor.Click
        SwitchMode(Me, False)
        If Len(Trim(txtKodeVendor.Text)) = 0 Or Len(Trim(txtNamaVendor.Text)) = 0 Or Len(Trim(RadioTax.SelectedIndex)) = -1 Then

            DevExpress.XtraEditors.XtraMessageBox.Show("data has not been completed yet")
            Exit Sub

        End If


        oVendor.kodevendor = txtKodeVendor.Text
        oVendor.nama = txtNamaVendor.Text()
        oVendor.alamat = txtAlamatVendor.Text()
        oVendor.telp = txtTelpVendor.Text()
        oVendor.fax = txtFaxVendor.Text()
        oVendor.contactPerson = txtContactVendor.Text()
        oVendor.handphone = txtHpVendor.Text()
        oVendor.email = txtEmailVendor.Text()
        oVendor.NPWP = txtNpwpVendor.Text()
        oVendor.statusPajak = RadioTax.EditValue

        oVendor.Save(IsNew)
        If IsNew = True Then
            SetMessage("Save Data Succeeded")
        Else
            SetMessage(String.Format("Vendor Data {0} Updated", txtKodeVendor.Text))

        End If

        EmptyTxt(Me)
        LoadData()
        CanClose = True
        IsSaved = True


    End Sub

    Private Sub BtnAddVendor_Click(sender As Object, e As EventArgs) Handles BtnAddVendor.Click

        SwitchMode(Me, True)
        isNew = True
        CanClose = False
        txtKodeVendor.Focus()

    End Sub

   
    Sub LoadData()
        GridControl1.SuspendLayout()
        oVendor.isDeleted = False

        GridControl1.DataSource = Nothing
        oVendor.Load(True)
        GridControl1.DataSource = oVendor.DataVendor.Tables("TabelVendor")
        GridControl1.Refresh()
        GridView1.BestFitColumns(True)
        GridView1.Columns(1).Caption = "Vendor Code"
        GridView1.Columns(2).Caption = "Vendor Name"
        GridView1.Columns(3).Caption = "Address "
        GridView1.Columns(4).Caption = "Telp."
        GridView1.Columns(5).Caption = "Fax."
        GridView1.Columns(6).Caption = "Contact Person"
        GridView1.Columns(7).Caption = "Handphone"
        GridView1.Columns(8).Caption = "Email"
        GridView1.Columns(9).Caption = "NPWP No."
        GridView1.Columns(10).Caption = "Tax Status"

        GridView1.Columns(0).Visible = False
        GridView1.Columns(11).Visible = False
    End Sub

    Private Sub FormVendor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If CanClose = False Then
            e.Cancel = True
            SetMessage("VENDOR - data has not been saved yet")

        End If
    End Sub

    Private Sub FormVendor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetFormAttribute()

        CanClose = True
        LoadData()

    End Sub

   
    Private Sub BtnCancelVendor_Click(sender As Object, e As EventArgs) Handles BtnCancelVendor.Click
        CanClose = True
        SetFormAttribute()
        ID = 0
        EmptyTxt(Me)
    End Sub

    Private Sub BtnDelVendor_Click(sender As Object, e As EventArgs) Handles BtnDelVendor.Click
        If oVendor.id = 0 Then
            XtraMessageBox.Show("Choose the data do you wish to delete?")
        End If
        If XtraMessageBox.Show("Do you wish to delete this data?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            oVendor.del()

        End If
        LoadData()
    End Sub


    Private Sub BtnEditVendor_Click(sender As Object, e As EventArgs) Handles BtnEditVendor.Click
        GetDetail()
        SwitchMode(Me, True)
        CanClose = False
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        oVendor.id = Convert.ToInt32(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns(0)))


    End Sub

    Private Sub txtTelpVendor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelpVendor.KeyPress
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 40 And Asc(e.KeyChar) <> 41 And Asc(e.KeyChar) <> 45 And Asc(e.KeyChar) <> 44 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                Beep()

            End If
        End If
    End Sub

    Private Sub txtFaxVendor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFaxVendor.KeyPress
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 40 And Asc(e.KeyChar) <> 41 And Asc(e.KeyChar) <> 45 And Asc(e.KeyChar) <> 44 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                Beep()

            End If
        End If
    End Sub

    Private Sub txtHpVendor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHpVendor.KeyPress
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 40 And Asc(e.KeyChar) <> 41 And Asc(e.KeyChar) <> 45 And Asc(e.KeyChar) <> 44 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                Beep()

            End If
        End If
    End Sub

    Private Sub txtNpwpVendor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNpwpVendor.KeyPress
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 40 And Asc(e.KeyChar) <> 41 And Asc(e.KeyChar) <> 45 And Asc(e.KeyChar) <> 44 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                Beep()

            End If
        End If
    End Sub
    Sub GetDetail()
        ID = Convert.ToInt32(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns(0)))
        oVendor.id = ID
        IsNew = False
        oVendor.Load(False)
        txtKodeVendor.Text = oVendor.kodevendor
        txtNamaVendor.Text = oVendor.nama
        txtAlamatVendor.Text = oVendor.alamat
        txtTelpVendor.Text = oVendor.telp
        txtFaxVendor.Text = oVendor.fax
        txtContactVendor.Text = oVendor.contactPerson
        txtHpVendor.Text = oVendor.handphone
        txtEmailVendor.Text = oVendor.email
        txtNpwpVendor.Text = oVendor.NPWP
        RadioTax.EditValue = oVendor.statusPajak

    End Sub

End Class