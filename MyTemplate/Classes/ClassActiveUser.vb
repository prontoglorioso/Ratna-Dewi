Imports System.Data.SqlClient

Public Class ClassActiveUser

#Region "Private variables"
    Dim _ID As Integer
    Dim _RoleID As Integer
    Dim _RoleName As String
#End Region

#Region "Public Enums and Structures"
    ''' <summary>
    ''' Enum of LoginResultEnum, as return value from Stored Procedure
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum LoginResultEnum
        Success = 0
        FailedByUnregisterdID = 1
        FailedByUnMatchedPassword = 2
        FailedByUnknown = 99
    End Enum
#End Region
#Region "Public Properties of the class clsActiveUser"
    Public ReadOnly Property ID As Integer
        Get
            Return _ID
        End Get
    End Property
    Public Property [Username] As String

    Public Property [Password] As String
    Public ReadOnly Property RoleID As Integer
        Get
            Return _RoleID
        End Get
    End Property

    Public ReadOnly Property RoleName As String
        Get
            Return _RoleName
        End Get
    End Property

    Public Property UserAccessLevel As DataTable
    Public Property EncryptedPassword As String

#End Region

#Region "Public Methods of the Class"
    ''' <summary>
    ''' Class constructor
    ''' </summary>
    ''' <remarks></remarks>
    Sub New()
        _ID = 0
        Username = ""
        Password = ""
        _RoleID = 0
        _RoleName = ""
        UserAccessLevel = New DataTable("UserAccessLevel")
    End Sub


    Function Verification() As LoginResultEnum
        If Not dbOpen() Then Return LoginResultEnum.FailedByUnknown

        Dim wrapper As New ClassEncrypt([Password])
        EncryptedPassword = wrapper.EncryptData([Password])

        sqlCmd = New SqlClient.SqlCommand With {.Connection = sqlConn, .CommandType = CommandType.StoredProcedure, .CommandText = "SP_Login"}

        With sqlCmd.Parameters
            .Clear()
            .AddWithValue("@UserName", Username)
            .AddWithValue("@Password", EncryptedPassword)
            .Add("@Result", SqlDbType.Int).Direction = ParameterDirection.Output

        End With
        Try
            sqlCmd.ExecuteScalar()
            Return sqlCmd.Parameters("@Result").Value
        Catch ex As SqlException
            Return LoginResultEnum.FailedByUnknown
        End Try
    End Function

    Sub GetUserInfo()
        If Not dbOpen() Then
            _RoleID = 0
            Throw New Exception("Can not open database.")
            Exit Sub
        End If

        sqlCmd = New SqlCommand With {.Connection = sqlConn, .CommandType = CommandType.StoredProcedure, .CommandText = "ActiveUser_GetInfo"}
        sqlCmd.Parameters.Clear()
        sqlCmd.Parameters.AddWithValue("username", Username)
        sqlCmd.Parameters.AddWithValue("userpassword", EncryptedPassword)
        Try
            sqlDr = sqlCmd.ExecuteReader
            If Not sqlDr.HasRows Then
                Throw New Exception("No data found.")
                Exit Sub
            End If
            sqlDr.Read()
            _ID = sqlDr("ID")
            _RoleID = sqlDr("RoleID")
            _RoleName = sqlDr("RoleName")
            sqlCmd.Dispose()
        Catch ex As SqlException
            Throw New Exception("System failed with this error message: " & ex.Message)
        Finally
            dbClose()
        End Try
    End Sub

    Sub GetAccessLevel()
        UserAccessLevel.Dispose()
        UserAccessLevel = New DataTable("UserAccessLevel")

        If Not dbOpen() Then
            Throw New Exception("Can not open database")
            Exit Sub
        End If

        sqlCmd = New SqlCommand With {.Connection = sqlConn, .CommandType = CommandType.StoredProcedure, .CommandText = "ActiveUser_GetAccessLevel"}
        sqlCmd.Parameters.Clear()
        sqlCmd.Parameters.AddWithValue("@IDRole", RoleID)

        Try
            sqlDr = sqlCmd.ExecuteReader
            UserAccessLevel.Load(sqlDr)
            sqlCmd.Dispose()
        Catch ex As SqlException
            Throw New Exception("System failed with this error message: " & ex.Message)
        Finally
            dbClose()
        End Try

    End Sub
#End Region
End Class
