Imports System
Imports System.Data
Imports System.Data.Odbc
'***************************************************************************
'Code    -  Main Code Behind for Database Connection
'Author  -  Jyotirmoy Pramanik
'Email   -  Jyotirmoy.Pramanik@outlook.com
'Date    -   31-DEC-2014
'Modified Date - 31-DEC-2014
'***************************************************************************
'MS Reference - http://support.microsoft.com/kb/310985


Public Class db
    Public ConnString As String
    Public DBDSN As String
    Public DBUser As String
    Dim DBConn As OdbcConnection
    Sub New(ByVal ldsn As String, ByVal luser As String, ByVal lpassword As String)
        DBDSN = ldsn
        DBUser = luser
        ConnString = "dsn=" & ldsn & ";User=" & luser & ";Pwd=" & lpassword & ";connection timeout=120;"        ' Set up query string
        ' Get all the Table from Target except for those that are already present in the Source Database 
        ' CmdString = "locking row for access select tablename from dbc.tables where databasename='" & lsource & "' and tablekind='T' and tablename not in (select tablename from dbc.tables where databasename='" & ldest & "' and tablekind='T') order by 1;"
        DBConn = New OdbcConnection(ConnString)
    End Sub
    Function ConnStatus() As Boolean

        If DBConn.State = ConnectionState.Open Then
            Return True
        Else
            Return False
        End If

    End Function
    Function getDBConn() As System.Data.Odbc.OdbcConnection
        Return DBConn
    End Function
    Function ConnectToDb() As Boolean
        Try
            If DBConn.State = ConnectionState.Open Then
                Return True
            Else
                DBConn.Open()
                Return True
            End If
        Catch ex As Exception
#If DEBUG Then
            Debug.WriteLine("Problem with Connection to Database " & ex.Message)
#End If
            'MsgBox("Problem with Connection to Database " & ex.Message)
            Return False
        End Try

    End Function
    Sub DisConnectFromDb()
        Try
            If DBConn.State = ConnectionState.Open Then
                DBConn.Close()
            End If
        Catch ex As Exception
            MsgBox("Error When Closing Connection to DB DSN :" & DBDSN & ex.Message)
        End Try
        DBConn = Nothing
        GC.Collect()
    End Sub
End Class
