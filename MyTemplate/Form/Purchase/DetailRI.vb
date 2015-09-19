Public Class DetailRI

#Region "Property Declaration"
    Public Property IdHeaderPO As Integer
    Public Property IdHeaderRI As Integer
    Public Property RINumber As Integer
    Public Property idItem As Integer
    Public Property itemName As String
    Public Property itemQuantity As Integer

#End Region

#Region "PO Property For RI Header"
    Private Sub loadDataHeaderPO()
        Try
            Me.SelectHeaderPO_DetailTableAdapter.Fill(Me.DataSetRI.SelectHeaderPO_Detail, New System.Nullable(Of Integer)(CType(IdHeaderPO, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
#End Region

#Region "Form Event"

    Private Sub DetailRI_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()

    End Sub
    Private Sub FormReceiveItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetRI.SelectSubAccCOADataTable' table. You can move, or remove it, as needed.
        Me.SelectSubAccCOADataTableTableAdapter.Fill(Me.DataSetRI.SelectSubAccCOADataTable)
        loadDataHeaderPO()
        groupControlHeaderRI.Enabled = False

        LoadItem()



    End Sub
#End Region

#Region "RI Header Function"
    Sub SaveHeaderRI()
        Me.Validate()
        Me.HeaderRI_DataTableBindingSource.EndEdit()
        Me.TableAdapterManagerHeaderRI.UpdateAll(Me.DataSetRI)
    End Sub
    Sub LoadHeaderRI()
        Try
            Me.HeaderRI_DataTableTableAdapter.Fill(Me.DataSetRI.HeaderRI_DataTable, New System.Nullable(Of Integer)(CType(IdHeaderPO, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "RI Detail Function"
    'Sub saveDetailRI()
    '    'Me.Validate()
    '    'Me.DetailRiDataTableBindingSource.EndEdit()
    '    'Me.TableAdapterManagerDetailRI.UpdateAll(Me.DataSetRI)

    'End Sub

    'Sub LoadDetailRI()
    '    'Try
    '    '    Me.DetailRiTableAdapter.Fill(Me.DataSetRI.DetailRiDataTable, New System.Nullable(Of Integer)(CType(IdHeaderRI, Integer)))
    '    'Catch ex As System.Exception
    '    '    System.Windows.Forms.MessageBox.Show(ex.Message)
    '    'End Try

    'End Sub
#End Region

#Region "Form Control Event"
    Sub AddNew()

        If groupControlHeaderRI.Enabled = False Then
            groupControlHeaderRI.Enabled = True
            Me.HeaderRI_DataTableBindingSource.AddNew()
        Else
            XtraMessageBox.Show("Editor already Opened", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
    Private Sub buttonSave_Click(sender As Object, e As EventArgs) Handles buttonSave.Click
        SaveHeaderRI()
        SaveDetailRi()



    End Sub
    Private Sub buttonAddNew_Click(sender As Object, e As EventArgs) Handles buttonAddNew.Click
        AddNew()
        IDHeaderPOTextEdit.Text = IdHeaderPO
    End Sub
#End Region
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        'If Len(Trim(IDTextBox.Text)) = 0 Then
        '    alert.Show(Me, "Attention", "Data RI main must" & vbNewLine & " be filled before adding new detail value")
        '    Exit Sub
        'Else

        'End If


        GridView1.AddNewRow()
        GridView1.SetFocusedRowCellValue(colIDHeaderRI, IDTextEdit.Text)
        LoadIdHeaderRI()


    End Sub
    Private Sub SaveDetailRi()
        Me.Validate()
        Me.DetailRIDataTableBindingSource.EndEdit()
        Me.TableAdapterManagerDetailRI.UpdateAll(Me.DataSetRIDetailRI)

    End Sub

    Private Sub LoadDataRI()
        Try
            Me.DetailRITableAdapter.Fill(Me.DataSetRIDetailRI.DetailRIDataTable, New System.Nullable(Of Integer)(CType(IdHeaderRI, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub

    Sub LoadItem()
        Try
            Me.SP_Select_Item_DetalRITableAdapter1.Fill(Me.DataSetRISelectItem2.SP_Select_Item_DetalRI, New System.Nullable(Of Integer)(CType(IdHeaderPO, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub LoadIdHeaderRI()
        RINumber = NoRITextEdit.Text
        Try
            Me.GetIdHeaderRITableAdapter.Fill(Me.DataSetRI.getIdHeaderRI, New System.Nullable(Of Integer)(CType(RINumber, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        GridView1.SetFocusedRowCellValue(colIDHeaderRI, IDTextBox.Text)

    End Sub

    Private Sub GridView3_DoubleClick(sender As Object, e As EventArgs) Handles GridView3.DoubleClick
        Cursor = Cursors.WaitCursor
        ChooseItem()
        SetEditorValue()
        Cursor = Cursors.Default
    End Sub

    Private Sub ChooseItem()
        Try
            If GridView3.RowCount <= 0 Then
                Exit Sub

            End If

            idItem = GridView3.GetFocusedRowCellValue(colID2).ToString
            itemQuantity = GridView3.GetFocusedRowCellValue(colQty2).ToString
            itemName = GridView3.GetFocusedRowCellValue(colnamaItem2).ToString

            If Not RepositoryItemPopupContainerEdit1.OwnerEdit Is Nothing Then
                RepositoryItemPopupContainerEdit1.OwnerEdit.ClosePopup()

            End If


            'If Not PCC1.OwnerEdit Is Nothing Then
            '    PCC1.OwnerEdit.ClosePopup()
            'End If

            'PCC1.OwnerEdit.ClosePopup()

        Catch ex As Exception
            alert.Show(Me, "Check On ChooseItem()", ex.Message)
        End Try
    End Sub
    Private Sub SetEditorValue()
        Try
            GridView1.ShowEditor()

            GridView1.SetFocusedRowCellValue(colIDDetailPO, idItem)
            GridView1.SetFocusedRowCellValue(colnamaItem1, itemName)
            GridView1.SetFocusedRowCellValue(colQty1, itemQuantity)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub PCC1_Leave(sender As Object, e As EventArgs) Handles PCC1.Leave

    End Sub

    'Private Sub RepositoryItemPopupContainerEdit1_Leave(sender As Object, e As EventArgs) Handles RepositoryItemPopupContainerEdit1.Leave
    '    GridView3.SetFocusedRowCellValue(colID2, idItem)
    '    GridView3.SetFocusedRowCellValue(colnamaItem2, itemName)
    '    GridView3.SetFocusedRowCellValue(colQty2, itemQuantity)
    'End Sub

    'Private Sub GridView3_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView3.FocusedRowChanged
    '    GridView3.SetFocusedRowCellValue(colID2, idItem)
    '    GridView3.SetFocusedRowCellValue(colnamaItem2, itemName)
    '    GridView3.SetFocusedRowCellValue(colQty2, itemQuantity)
    'End Sub

    Private Sub RepositoryItemPopupContainerEdit1_QueryResultValue(sender As Object, e As Controls.QueryResultValueEventArgs) Handles RepositoryItemPopupContainerEdit1.QueryResultValue

        Try
            If GridView3.RowCount > 0 Then
                e.Value = idItem
                BeginInvoke(New MethodInvoker(AddressOf SetEditorValue))
            End If
        Catch ex As Exception
            alert.Show(Me, "", "Check QueryResult")
        End Try
      

    End Sub

    Private Sub GridView3_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView3.KeyDown
        Cursor = Cursors.WaitCursor
        ChooseItem()
        SetEditorValue()

        Cursor = Cursors.Default
    End Sub
End Class