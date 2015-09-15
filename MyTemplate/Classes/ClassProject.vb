Public Class ClassProject
    Public Property id As Integer
    Public Property isNew As Boolean
    Public Property isAll As Boolean
    Public Property projectNo As String
    Public Property projectName As String
    Public Property description As String
    Public Property contactName As String
    Public Property idMarketing As Integer
    Public Property idCustomer As Integer
    Public Property isDeleted As Boolean
    Public Property DataProject As New DataSet
    Sub Save(isNew As Boolean)
        If Not dbOpen() Then
            Throw New Exception("Database Can't Open")
        End If
        sqlCMD = New SqlClient.SqlCommand With {.CommandType = CommandType.StoredProcedure, .Connection = sqlConn, .CommandText = "project_Set"}
        With sqlCMD.Parameters
            .Clear()
            .AddWithValue("id", id)
            .AddWithValue("projectNo", projectNo)
            .AddWithValue("projectName", projectName)
            .AddWithValue("description", description)
            .AddWithValue("contactName", contactName)
            .AddWithValue("idMarketing", idMarketing)
            .AddWithValue("idCustomer", idCustomer)
            .AddWithValue("isDeleted", isDeleted)
            .AddWithValue("isNew", isNew)
        End With
        Try
            sqlCMD.ExecuteNonQuery()
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
        DataProject.Dispose()
        DataProject = New DataSet
        SqlCMD = New SqlClient.SqlCommand With {.CommandType = CommandType.StoredProcedure, .Connection = sqlConn, .CommandText = "Project_Get"}
        With SqlCMD.Parameters
            .Clear()
            .AddWithValue("isAll", isAll)
            .AddWithValue("isDeleted", isDeleted)
            .AddWithValue("id", id)
        End With
        Try
            sqlDA = New SqlClient.SqlDataAdapter With {.SelectCommand = SqlCMD}
            sqlDA.Fill(DataProject, "TabelProject")
            sqlDA.Dispose()
            SqlCMD.Dispose()
            If isAll = False Then
                With DataProject.Tables("TabelProject")
                    projectNo = .Rows(0).Item(1)
                    projectName = .Rows(0).Item(2)
                    description = .Rows(0).Item(3)
                    contactName = .Rows(0).Item(4)
                    idMarketing = .Rows(0).Item(5)
                    idCustomer = .Rows(0).Item(6)
                    isDeleted = .Rows(0).Item(7)
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
        sqlCMD = New SqlClient.SqlCommand With {.CommandType = CommandType.StoredProcedure, .Connection = sqlConn, .CommandText = "Project_Del"}
        With sqlCMD.Parameters
            .Clear()
            .AddWithValue("id", id)
        End With
        Try
            sqlCMD.ExecuteNonQuery()

        Catch ex As SqlClient.SqlException
            Throw New Exception(ex.Message)
        Finally
            sqlConn.Close()
        End Try
    End Sub
End Class
