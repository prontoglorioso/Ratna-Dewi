Imports System.IO
Imports Microsoft.VisualBasic.Strings

Public Class ReadConfig
    ''' <summary>
    ''' Variabel Declarations
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Property ConfigFile As String

    Private oConnString As String
    Private oServer As String
    Private oDatabase As String
    Private oUserID As String
    Private oPassword As String

    ''' <summary>
    ''' Connection String Variabel
    ''' </summary>
    ''' <value></value>
    ''' <returns>oConnString</returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ConnectionString As String
        Get
            Return oConnString

        End Get
    End Property

    Public Sub New()
        ConfigFile = Application.StartupPath & "\config.ini"
    End Sub

    Public Sub New(ByVal oConfigFile As String)
        ConfigFile = oConfigFile

    End Sub

    Public Sub Read()
        Dim strLine As String
        Dim strElement() As String

        Try
            If Not File.Exists(ConfigFile) Then
                XtraMessageBox.Show("config.ini file not found" & vbCrLf & "Please Check Your Sources.", "Configuration File is not exist", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Application.Exit()

            End If

            Dim oReader As New StreamReader(ConfigFile)
            Do While oReader.Peek() <> -1

                strLine = oReader.ReadLine
                strElement = Strings.Split(strLine, "=", 2, CompareMethod.Text)

                Select Case strElement(0).ToString.ToLower
                    Case "server"
                        oServer = strElement(1)
                    Case "database"
                        oDatabase = strElement(1)
                    Case "user id"
                        oUserID = strElement(1)
                    Case "password"
                        oPassword = strElement(1)
                End Select

            Loop

            oConnString = String.Format("Server={0}; Database={1};", oServer, oDatabase)

            If oUserID.Length = 0 Then
                oConnString = oConnString & "Trusted_Connection=true;"
            Else
                oConnString = String.Format("{0} User ID={1}; Password={2};", oConnString, oUserID, oPassword)
            End If
        Catch ex As Exception
            Throw New Exception("Fatal Error Occurred, with error message: " & ex.Message)

        End Try
    End Sub
End Class
