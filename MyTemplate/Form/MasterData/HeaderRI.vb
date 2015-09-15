Public Class HeaderRI
    Private Sub FormTemplate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetSPPK.SelectSubAccCOA' table. You can move, or remove it, as needed.
        Me.SelectSubAccCOATableAdapter.Fill(Me.DataSetSPPK.SelectSubAccCOA)
        'TODO: This line of code loads data into the 'DataSetSPPK.SelectVendor' table. You can move, or remove it, as needed.
        Me.SelectVendorTableAdapter.Fill(Me.DataSetSPPK.SelectVendor)
        'TODO: This line of code loads data into the 'DataSetSPPK.RIHeader_Select' table. You can move, or remove it, as needed.
        Me.RIHeader_SelectTableAdapter.Fill(Me.DataSetSPPK.RIHeader_Select)
        SetFormAttribute()

        CanClose = True
        LoadData()
    End Sub
    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        If XtraMessageBox.Show("Apakah anda yakin akan menghapus data ini", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim row() As Integer = GridView1.GetSelectedRows
            If row.Count > 0 Then
                RIHeader_SelectBindingSource.RemoveCurrent()
                SaveData()
                LoadData()
            End If
        End If
    End Sub
    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        SaveData()
        SetMessage("Data Has Been Saved")
    End Sub
   Sub SaveData()
        Me.Validate()
        Me.RIHeader_SelectBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetSPPK)
    End Sub
    Sub LoadData()
        Me.RIHeader_SelectTableAdapter.Fill(Me.DataSetSPPK.RIHeader_Select)
        GridView1.Columns(0).Visible = False
    End Sub

    Private Sub ButtonDetailRI_Click(sender As Object, e As EventArgs) Handles ButtonDetailRI.Click
        DetailRI.ShowDialog()
    End Sub
End Class