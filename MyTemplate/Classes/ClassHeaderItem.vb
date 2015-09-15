Public Class ClassHeaderItem
    Public Property id As Integer
    Public Property isNew As Boolean
    Public Property isAll As Boolean
    Public Property namaHeaderItem As String
    Public Property typeItem As Boolean
    Public Property DataHeaderItem As New DataSet
    Sub Save(isNew As Boolean)
        If Not dbOpen() Then
            Throw New Exception("Database Can't Open")
        End If
        SqlCMD = New SqlClient.SqlCommand With {.CommandType = CommandType.StoredProcedure, .Connection = sqlConn, .CommandText = "Header_Set"}
        With SqlCMD.Parameters
            .Clear()
            .AddWithValue("id", id)
            .AddWithValue("namaHeader", namaHeaderItem)
            .AddWithValue("typeItem", typeItem)
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
        DataHeaderItem.Dispose()
        DataHeaderItem = New DataSet

        SqlCMD = New SqlClient.SqlCommand With {.CommandType = CommandType.StoredProcedure, .Connection = sqlConn, .CommandText = "Header_Get"}
        With SqlCMD.Parameters
            .Clear()
            .AddWithValue("isAll", isAll)
            .AddWithValue("id", id)
        End With
        Try
            sqlDA = New SqlClient.SqlDataAdapter With {.SelectCommand = SqlCMD}
            sqlDA.Fill(DataHeaderItem, "TabelHeaderItem")
            sqlDA.Dispose()

            SqlCMD.Dispose()
            If isAll = False Then
                With DataHeaderItem.Tables("TabelHeaderItem")
                    namaHeaderItem = .Rows(0).Item(1)
                    typeItem = .Rows(0).Item(2)

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
        SqlCMD = New SqlClient.SqlCommand With {.CommandType = CommandType.StoredProcedure, .Connection = sqlConn, .CommandText = "Header_Del"}
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
