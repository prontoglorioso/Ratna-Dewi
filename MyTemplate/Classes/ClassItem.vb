Public Class ClassItem
    Public Property id As Integer
    Public Property isNew As Boolean
    Public Property isAll As Boolean
    Public Property idHeaderItem As Integer
    Public Property kodeItem As String
    Public Property namaItem As String
    Public Property status As Boolean
    Public Property qty As Integer
    Public Property unit As String
    Public Property cost As Decimal
    Public Property openingbalancedate As Date
    Public Property isdeleted As Boolean
    Public Property typeItem As Boolean
    Public Property DataItem As New DataSet
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub New()
        qty = 0
    End Sub
    Sub Save(isNew As Boolean)
        If Not dbOpen() Then
            Throw New Exception("Database Can't Open")
        End If
        SqlCMD = New SqlClient.SqlCommand With {.CommandType = CommandType.StoredProcedure, .Connection = sqlConn, .CommandText = "Item_Set"}
        With SqlCMD.Parameters
            .Clear()
            .AddWithValue("id", id)
            .AddWithValue("idHeaderItem", idHeaderItem)
            .AddWithValue("kodeItem", kodeItem)
            .AddWithValue("namaItem", namaItem)
            .AddWithValue("status", status)
            .AddWithValue("qty", qty)
            .AddWithValue("unit", unit)
            .AddWithValue("cost", cost)
            .AddWithValue("openingbalancedate", openingbalancedate)
            .AddWithValue("typeItem", typeItem)
            .AddWithValue("isdeleted", isdeleted)
            .AddWithValue("isNew", isNew)
        End With
        Try
            SqlCMD.ExecuteNonQuery()

        Catch ex As SqlClient.SqlException
            Throw New Exception(ex.Message)
        Finally
            sqlConn.Close()

        End Try
    End Sub
    Sub Load(ByVal isAll As Boolean)
        If Not dbOpen() Then
            Throw New Exception("Database Can't Open")
        End If
        DataItem.Dispose()
        DataItem = New DataSet

        SqlCMD = New SqlClient.SqlCommand With {.CommandType = CommandType.StoredProcedure, .Connection = sqlConn, .CommandText = "Item_Get"}
        With SqlCMD.Parameters
            .Clear()
            .AddWithValue("isAll", isAll)
            .AddWithValue("isDeleted", isdeleted)
            .AddWithValue("id", id)
        End With
        Try
            sqlDA = New SqlClient.SqlDataAdapter With {.SelectCommand = SqlCMD}
            sqlDA.Fill(DataItem, "TabelItem")
            sqlDA.Dispose()

            SqlCMD.Dispose()
            If isAll = False Then
                With DataItem.Tables("TabelItem")
                    idHeaderItem = .Rows(0).Item(1)
                    kodeItem = .Rows(0).Item(2)
                    namaItem = .Rows(0).Item(3)
                    status = .Rows(0).Item(4)
                    qty = .Rows(0).Item(5)
                    unit = .Rows(0).Item(6)
                    cost = .Rows(0).Item(7)
                    openingbalancedate = .Rows(0).Item(8)
                    typeItem = .Rows(0).Item(9)
                    isdeleted = .Rows(0).Item(10)

                End With
            End If
        Catch ex As SqlClient.SqlException
            Throw New Exception(ex.Message)
        Finally
            dbClose()
        End Try
    End Sub
    
    Sub del()
        If Not dbOpen() Then
            Throw New Exception("Database Can't Open")
        End If
        SqlCMD = New SqlClient.SqlCommand With {.CommandType = CommandType.StoredProcedure, .Connection = sqlConn, .CommandText = "Item_Del"}
        With SqlCMD.Parameters
            .Clear()
            .AddWithValue("id", id)

        End With
        Try
            SqlCMD.ExecuteNonQuery()

        Catch ex As SqlClient.SqlException
            Throw New Exception(ex.Message)
        Finally
            sqlConn.Close()

        End Try
    End Sub
   
End Class
