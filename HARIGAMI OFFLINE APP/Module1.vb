Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Data.Odbc
Module Module1
    Public cmd As OdbcCommand
    Public rd As OdbcDataReader
    Public rd2 As OdbcDataReader
    Public adapter As OdbcDataAdapter
    Public dataset As New DataSet
    Public connection2 As OdbcConnection
    Public connection As OdbcConnection
    Private Declare Auto Function GetPrivateProfileString Lib "kernel32" (ByVal lpAppName As String,
            ByVal lpKeyName As String,
            ByVal lpDefault As String,
            ByVal lpReturnedString As StringBuilder,
            ByVal nSize As Integer,
            ByVal lpFileName As String) As Integer
    Public server, uid, pwd, databases, port, web, server_select, uid_select, pwd_select, databases_select, port_select As String
    Dim objIniFile As New clsIni(My.Application.Info.DirectoryPath & "\conf.txt")
    Public connection_stat, connection_content As Boolean
    Public Sub conf()
        'koneksi
        server = objIniFile.GetString("conn", "server", "")
        uid = objIniFile.GetString("conn", "uid", "")
        pwd = objIniFile.GetString("conn", "pwd", "")
        databases = objIniFile.GetString("conn", "databases", "")
        port = objIniFile.GetString("conn", "port", "")

        'select
        server_select = objIniFile.GetString("conn_zone", "server_zone", "")
        uid_select = objIniFile.GetString("conn_zone", "uid_zone", "")
        pwd_select = objIniFile.GetString("conn_zone", "pwd_zone", "")
        databases_select = objIniFile.GetString("conn_zone", "databases_zone", "")
        port_select = objIniFile.GetString("conn_zone", "port_zone", "")
    End Sub
    Sub koneksi()
        Call conf()
        Try
            connection = New OdbcConnection("Driver=MySQL ODBC 5.1 Driver;SERVER=" & server & ";UID=" & uid & ";pwd=" & pwd & ";DATABASE=" & databases & ";PORT=" & port & "")
            'membuka koneksi
            If connection.State = ConnectionState.Closed Then
                connection.Open()
                connection_stat = True
            End If
        Catch ex As Exception
            connection_stat = False
        End Try
    End Sub
    Public Sub Koneksi_content()
        Try
            connection2 = New OdbcConnection("Driver=MySQL ODBC 5.1 Driver;SERVER=" & server_select & ";UID=" & uid_select & ";pwd=" & pwd_select & ";DATABASE=" & databases_select & ";PORT=" & port_select & "")
            'membuka koneksi
            If connection2.State = ConnectionState.Closed Then
                connection2.Open()
                connection_content = True
            End If
        Catch ex As Exception
            connection_content = False
        End Try
        '/
    End Sub
    Sub baca_text()

        Dim res As Integer
        Dim sb As StringBuilder

        sb = New StringBuilder(500)
        res = GetPrivateProfileString("contoh", "server", "", sb, sb.Capacity, My.Application.Info.DirectoryPath & "baca.txt")
        Console.WriteLine("GetPrivateProfileStrng returned : " & res.ToString())
        Console.WriteLine("server=" & sb.ToString())
        Console.ReadLine()

    End Sub
End Module