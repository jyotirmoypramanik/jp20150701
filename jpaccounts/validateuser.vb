Imports System.Data.Odbc
Imports DBOra.db
Imports System.Diagnostics


Module validateuser
    Function checkappuser(ByRef dbconn As OdbcConnection, ByVal appuser As String, ByVal apppwd As String) As Integer
        'Function to Check whether user connecting to the Application Exists and if the user Exists whether the User has Admin rights
        'A countappuser value of more than 1 means user exists 
        'A WADM value of 1 means the user is an Administrator and hence should get a different screen 
#If DEBUG Then
        Debug.WriteLine("Module : validateuser  & Function : checkappuser ")

#End If

        Dim countappuser As Integer
        Dim WADM As Boolean 'Variable for Admin User for the Application
        Dim cmd As New OdbcCommand
        cmd.CommandText = "SELECT COUNT(*) FROM DBUSERS WHERE USERNAME='" + appuser + "' AND PKEY='" + apppwd + "'"
#If DEBUG Then
        Debug.WriteLine("Running in Debug Mode: SQL Query " + cmd.CommandText)
#End If
        'Initialize Command Connection object with ODBC Connection object
        cmd.Connection = dbconn


        Dim dreader As OdbcDataReader = cmd.ExecuteReader()
        dreader.Read()
        countappuser = dreader(0).ToString
        dreader.Close()
        cmd = Nothing
        If countappuser >= 1 Then
            'Check User for Admin rights 
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
