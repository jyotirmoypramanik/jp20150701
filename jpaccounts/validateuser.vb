Imports System.Data.Odbc
Imports DBOra.db
Imports System.Diagnostics


Module validateuser
    Function checkappuser(ByRef dbconn As OdbcConnection, ByVal appuser As String, ByVal apppwd As String) As Integer
        Dim countappuser As Integer
        Dim WADM As Boolean
        Dim cmd As New OdbcCommand
        cmd.CommandText = "SELECT COUNT(*) FROM DBUSERS WHERE USERNAME='" + appuser + "' AND PKEY='" + apppwd + "'"
#If DEBUG Then
        Debug.WriteLine("Running in Debug Mode: SQL Query " + cmd.CommandText)
#End If
        cmd.Connection = dbconn


        Dim dreader As OdbcDataReader = cmd.ExecuteReader()
        dreader.Read()
        countappuser = dreader(0).ToString
        dreader.Close()
        cmd = Nothing
        If countappuser >= 1 Then
            Dim cmd1 As New OdbcCommand
            cmd1.Connection = dbconn
            cmd1.CommandText = "SELECT WADM FROM DBUSERS WHERE USERNAME='" + appuser + "'"
            Dim dreader1 = cmd1.ExecuteReader()
            dreader1.Read()
            WADM = dreader1.GetBoolean(0)


            If WADM = True Then
                ModuleOwner = "Admin"
            Else
                ModuleOwner = "Developer"

            End If
            dreader1.Close()
            cmd1 = Nothing
        End If
#If DEBUG Then
        Debug.WriteLine("Running in Debug Mode: SQL Output : " + countappuser.ToString)
#End If

        

        Return countappuser

    End Function
End Module
