Public Class FormCustomer 
    Private Sub BtnSaveCustomer_Click(sender As Object, e As EventArgs) Handles BtnSaveCustomer.Click
        SwitchMode(Me, False)
        If Len(Trim(txtKodeCustomer.Text)) = 0 Or Len(Trim(txtNamaCustomer.Text)) = 0 Or Len(Trim(RadioTax.SelectedIndex)) = -1 Then

            DevExpress.XtraEditors.XtraMessageBox.Show("data has not been saved yet")
            Exit Sub

        End If

        oCustomer.kodeCustomer = txtKodeCustomer.Text
        oCustomer.nama = txtNamaCustomer.Text()
        oCustomer.alamat = txtAlamatCustomer.Text()
        oCustomer.telp = txtTelpCustomer.Text()
        oCustomer.fax = txtFaxCustomer.Text()
        oCustomer.contactPerson = txtContactCustomer.Text()
        oCustomer.handphone = txtHpCustomer.Text()
        oCustomer.email = txtEmailCustomer.Text()
        oCustomer.NPWP = txtNpwpCustomer.Text()
        oCustomer.statusPajak = RadioTax.EditValue()


        oCustomer.Save(IsNew)
        If IsNew = True Then
            SetMessage("Save Data Succeeded")
        Else
            SetMessage(String.Format("Customer Data {0} Updated", txtKodeCustomer.Text))
            
        End If

        EmptyTxt(Me)
        LoadData()
        CanClose = True
        IsSaved = True

    End Sub
    Sub LoadData()
        GridControl1.SuspendLayout()
        oCustomer.isDeleted = False

        GridControl1.DataSource = Nothing
        oCustomer.Load(True)
        GridControl1.DataSource = oCustomer.DataCustomer.Tables("TabelCustomer")
        GridControl1.Refresh()
        GridView1.BestFitColumns(True)
        GridView1.Columns(1).Caption = "Customer Code"
        GridView1.Columns(2).Caption = "Customer Name"
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

    Private Sub FormCustomer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If CanClose = False Then
            e.Cancel = True
            SetMessage("CUSTOMER - data has not been saved yet")

        End If
    End Sub

    Private Sub FormCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetFormAttribute()
        CanClose = True
        LoadData()

    End Sub

    Private Sub BtnAddCustomer_Click(sender As Object, e As EventArgs) Handles BtnAddCustomer.Click
        SwitchMode(Me, True)
        isNew = True
        CanClose = False
        txtKodeCustomer.Focus()

    End Sub

    Private Sub BtnCancelCustomer_Click(sender As Object, e As EventArgs) Handles BtnCancelCustomer.Click
        CanClose = True
        SetFormAttribute()
        ID = 0
        EmptyTxt(Me)
    End Sub

    Private Sub BtnEditCustomer_Click(sender As Object, e As EventArgs) Handles BtnEditCustomer.Click
        GetDetail()
        SwitchMode(Me, True)
        CanClose = False
    End Sub

    Private Sub BtnDelCustomer_Click(sender As Object, e As EventArgs) Handles BtnDelCustomer.Click

        If oCustomer.id = 0 Then
            XtraMessageBox.Show("Choose the data do you wish to delete?")
        End If
        If XtraMessageBox.Show("Do you wish to delete this data?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            oCustomer.del()

        End If
        LoadData()
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged

        oCustomer.id = Convert.ToInt32(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns(0)))
       

    End Sub


    Private Sub txtFaxCustomer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFaxCustomer.KeyPress
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 40 And Asc(e.KeyChar) <> 41 And Asc(e.KeyChar) <> 45 And Asc(e.KeyChar) <> 44 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                Beep()

            End If
        End If
    End Sub

    Private Sub txtHpCustomer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHpCustomer.KeyPress
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 40 And Asc(e.KeyChar) <> 41 And Asc(e.KeyChar) <> 45 And Asc(e.KeyChar) <> 44 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                Beep()

            End If
        End If
    End Sub

    Private Sub txtTelpCustomer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelpCustomer.KeyPress
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 40 And Asc(e.KeyChar) <> 41 And Asc(e.KeyChar) <> 45 And Asc(e.KeyChar) <> 44 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                Beep()

            End If
        End If
    End Sub
    Sub GetDetail()
        ID = Convert.ToInt32(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns(0)))
        oCustomer.id = ID
        IsNew = False
        oCustomer.Load(False)
        txtKodeCustomer.Text = oCustomer.kodeCustomer
        txtNamaCustomer.Text = oCustomer.nama
        txtAlamatCustomer.Text = oCustomer.alamat
        txtTelpCustomer.Text = oCustomer.telp
        txtFaxCustomer.Text = oCustomer.fax
        txtContactCustomer.Text = oCustomer.contactPerson
        txtHpCustomer.Text = oCustomer.handphone
        txtEmailCustomer.Text = oCustomer.email
        txtNpwpCustomer.Text = oCustomer.NPWP
        RadioTax.EditValue = oCustomer.statusPajak


    End Sub
End Class