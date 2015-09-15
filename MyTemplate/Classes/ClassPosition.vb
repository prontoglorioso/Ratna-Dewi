Public Class ClassPosition
    Public Property id As Integer
    Public Property isNew As Boolean
    Public Property isAll As Boolean
    Public Property namaJabatan As String
    Public Property isDeleted As Boolean
    Public Property DataPosition As New DataSet
    Sub Save(isNew As Boolean)
        If Not dbOpen() Then
            Throw New Exception("Database Can't Open")
        End If
        SqlCMD = New SqlClient.SqlCommand With {.CommandType = CommandType.StoredProcedure, .Connection = sqlConn, .CommandText = "Position_Set"}
        With SqlCMD.Parameters
            .Clear()
            .AddWithValue("id", id)
            .AddWithValue("namaJabatan", namaJabatan)
            .AddWithValue("isDeleted", isDeleted)
            .AddWithValue("isNew", isNew)
        End With
        Try
            SqlCMD.ExecuteNonQuery()
        Catch ex As SqlClient.SqlException
            If ex.Message.ToString.Contains("UNIQUE KEY") Then
                XtraMessageBox.Show("Duplicate value detected")
                Exit Sub
            End If
            Throw New Exception(ex.Message)
        Finally
            sqlConn.Close()
        End Try
    End Sub
    Sub Load(ByVal isAll As Boolean)
        If Not dbOpen() Then
            Throw New Exception("Database Can't Open")
        End If
        DataPosition.Dispose()
        DataPosition = New DataSet
        SqlCMD = New SqlClient.SqlCommand With {.CommandType = CommandType.StoredProcedure, .Connection = sqlConn, .CommandText = "Position_Get"}
        With SqlCMD.Parameters
            .Clear()
            .AddWithValue("isAll", isAll)
            .AddWithValue("isDeleted", isDeleted)
            .AddWithValue("id", id)
        End With
        Try
            sqlDA = New SqlClient.SqlDataAdapter With {.SelectCommand = SqlCMD}
            sqlDA.Fill(DataPosition, "TabelPosition")
            sqlDA.Dispose()
            SqlCMD.Dispose()
            If isAll = False Then
                With DataPosition.Tables("TabelPosition")
                    namaJabatan = .Rows(0).Item(1)
                    isDeleted = .Rows(0).Item(2)
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
        SqlCMD = New SqlClient.SqlCommand With {.CommandType = CommandType.StoredProcedure, .Connection = sqlConn, .CommandText = "Position_Del"}
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
