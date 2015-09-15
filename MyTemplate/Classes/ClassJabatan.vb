Public Class ClassJabatan
    Public Property id As Integer

    Public Property Jabatan As String
    Public Property IsNew As Boolean

    Public Property DataJabatan As New DataSet

    Sub [Get]()
        If Not dbOpen() Then
            Throw New Exception("Gagal menyambung ke Database")
        End If
        Try
            sqlCmd = New SqlClient.SqlCommand With {.CommandType = CommandType.StoredProcedure, .Connection = sqlConn, .CommandText = "Jabatan_Get"}

            DataJabatan.Dispose()
            DataJabatan = New DataSet

            sqlDa = New SqlClient.SqlDataAdapter With {.SelectCommand = sqlCmd}
            sqlDa.Fill(DataJabatan, "DataJabatan")

            sqlDa.Dispose()
            sqlCmd.Dispose()
        Catch ex As SqlClient.SqlException
            Throw New Exception(ex.Message)
        Finally
            dbClose()

        End Try

    End Sub
    
    Sub [Set](IsNew As Boolean)
        If Not dbOpen() Then
            Throw New Exception("Gagal menyambung ke Database")
        End If


        sqlCmd = New SqlClient.SqlCommand With {.CommandType = CommandType.StoredProcedure, .Connection = sqlConn, .CommandText = "Jabatan_Set"}
        With sqlCmd.Parameters
            .Clear()
            .AddWithValue("id", id)
            .AddWithValue("Jabatan", Jabatan)
            .AddWithValue("IsNew", IsNew)
        End With

        Try
            sqlCmd.ExecuteNonQuery()

        Catch ex As SqlClient.SqlException
            Throw New Exception(ex.Message)
        Finally
            dbClose()

        End Try
    End Sub


    Sub Del()
        If Not dbOpen() Then
            Throw New Exception("Gagal menyambung ke Database")
        End If

        sqlCmd = New SqlClient.SqlCommand With {.CommandType = CommandType.StoredProcedure, .Connection = sqlConn, .CommandText = "Jabatan_Del"}
        With sqlCmd.Parameters
            .AddWithValue("id", id)
        End With

        Try
            sqlCmd.ExecuteNonQuery()

        Catch ex As SqlClient.SqlException
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
