﻿Imports DevExpress.XtraReports.UI
Class FormTaxes
    Private Sub FormTaxes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If CanClose = False Then
            e.Cancel = True
            SetMessage("TAX data has not been saved yet")
        End If
    End Sub
    Sub LoadData()
        GridControl1.SuspendLayout()
        oTax.isDeleted = False

        GridControl1.DataSource = Nothing
        oTax.Load(True)
        GridControl1.DataSource = oTax.DataTax.Tables("TabelTax")
        GridControl1.Refresh()
        GridView1.BestFitColumns(True)

        GridView1.Columns(1).Caption = "Tax Code"
        GridView1.Columns(2).Caption = "Tax Name"
        GridView1.Columns(3).Caption = "Description"
        GridView1.Columns(4).Caption = "Tax Amount"
        GridView1.Columns(5).Caption = "Sales Tax"
        GridView1.Columns(6).Caption = "Purchase Tax"

        GridView1.Columns(0).Visible = False
    End Sub
    Private Sub FormTaxes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetFormAttribute()
        CanClose = True
        LoadData()
        loadComboSalesTax()
        loadComboPurchaseTax()
    End Sub
    Private Sub BtnCancelTax_Click(sender As Object, e As EventArgs) Handles BtnCancelTax.Click
        CanClose = True
        SetFormAttribute()
        ID = 0
        EmptyTxt(Me)
    End Sub
    Private Sub BtnAddTax_Click(sender As Object, e As EventArgs) Handles BtnAddTax.Click
        SwitchMode(Me, True)
        IsNew = True
        CanClose = False
        txtNamaPajak.Focus()
    End Sub
    Private Sub BtnEditTax_Click(sender As Object, e As EventArgs) Handles BtnEditTax.Click
        GetDetail()
        SwitchMode(Me, True)
        CanClose = False
    End Sub

    Private Sub BtnSaveTax_Click(sender As Object, e As EventArgs) Handles BtnSaveTax.Click
        SwitchMode(Me, False)
        If Len(Trim(txtNamaPajak.Text)) = 0 Or Len(Trim(txtKodePajak.Text)) = 0 Or Len(Trim(txtNilaiPajak.Text)) = 0 Or Len(Trim(LookUpEditSalesTax.EditValue)) = 0 Or Len(Trim(LookUpEditPurchaseTax.EditValue)) = 0 Then

            DevExpress.XtraEditors.XtraMessageBox.Show("data has not been completed yet")
            Exit Sub
        End If

        oTax.kodePajak = txtKodePajak.Text
        oTax.namaPajak = txtNamaPajak.Text
        oTax.tarifPajak = txtNilaiPajak.Text
        oTax.description = txtDesPajak.Text
        oTax.penjId = LookUpEditSalesTax.EditValue
        oTax.pemId = LookUpEditPurchaseTax.EditValue

        oTax.Save(IsNew)
        If IsNew = True Then
            SetMessage("Save Data Succeeded")
        Else
            SetMessage(String.Format("Tax Data {0} Updated", txtNamaPajak.Text))
        End If

        EmptyTxt(Me)
        LoadData()
        CanClose = True
        IsSaved = True
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        oTax.id = Convert.ToInt32(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns(0)))
    End Sub
    Sub loadComboSalesTax()
        oHelper.getSalesTax()
        LookUpEditSalesTax.Properties.DataSource = oHelper.DataSalesTax.Tables(0)
        LookUpEditSalesTax.Properties.DisplayMember = "namaSubAccount"
        LookUpEditSalesTax.Properties.ValueMember = "id"
    End Sub
    Sub loadComboPurchaseTax()
        oHelper.getPurchaseTax()
        LookUpEditPurchaseTax.Properties.DataSource = oHelper.DataPurchaseTax.Tables(0)
        LookUpEditPurchaseTax.Properties.DisplayMember = "namaSubAccount"
        LookUpEditPurchaseTax.Properties.ValueMember = "id"
    End Sub
    Sub GetDetail()
        ID = Convert.ToInt32(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns(0)))
        oTax.id = ID
        IsNew = False
        oTax.Load(False)
        txtKodePajak.Text = oTax.kodePajak
        txtNamaPajak.Text = oTax.namaPajak
        txtNilaiPajak.Text = oTax.tarifPajak
        txtDesPajak.Text = oTax.description
        LookUpEditSalesTax.EditValue = oTax.penjId
        LookUpEditPurchaseTax.EditValue = oTax.pemId
    End Sub

    Private Sub BtnDelTax_Click(sender As Object, e As EventArgs) Handles BtnDelTax.Click
        If BtnDelTax.Text.ToLower = "non active" Then
            If XtraMessageBox.Show("Do you wish to delete this data?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                oTax.del()
                LoadData()
            End If
        Else
            If XtraMessageBox.Show("Do you wish to restore this data?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                oTax.Restore()
                LoadData2()
            End If
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        LoadReport()
    End Sub
    Sub LoadReport()
        Me.ReportTaxTableAdapter.Fill(Me.DataSetReport.ReportTax)

        Dim Report As New ReportTax With {.DataSource = DataSetReport.Tables("ReportTax"), .DataMember = "ReportTax"}
        Dim tool As New ReportPrintTool(Report)
        tool.ShowPreview()
    End Sub
    Sub LoadData2()
        GridControl1.SuspendLayout()
        oTax.isDeleted = False

        GridControl1.DataSource = Nothing
        oTax.Load2()
        GridControl1.DataSource = oTax.DataTax.Tables("TabelTax")
        GridControl1.Refresh()
        GridView1.BestFitColumns(True)

        GridView1.Columns(1).Caption = "Tax Code"
        GridView1.Columns(2).Caption = "Tax Name"
        GridView1.Columns(3).Caption = "Description"
        GridView1.Columns(4).Caption = "Tax Amount"
        GridView1.Columns(5).Caption = "Sales Tax"
        GridView1.Columns(6).Caption = "Purchase Tax"

        GridView1.Columns(0).Visible = False
    End Sub
    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.CheckState = CheckState.Checked Then
            LoadData2()
            BtnDelTax.Text = "Restore"
        Else
            LoadData()
            BtnDelTax.Text = "Non Active"
        End If
    End Sub
End Class