Imports System.Windows.Forms
Public Class getDSN
    Private Declare Function SQLDataSources Lib "ODBC32.DLL" (ByVal henv As Integer, ByVal fDirection As Short, ByVal szDSN As String, ByVal cbDSNMax As Short, ByRef pcbDSN As Short, ByVal szDescription As String, ByVal cbDescriptionMax As Short, ByRef pcbDescription As Short) As Short
    Private Declare Function SQLAllocEnv Lib "ODBC32.DLL" (ByRef env As Integer) As Short
    Const SQL_SUCCESS As Integer = 0
    Const SQL_FETCH_NEXT As Integer = 1
    Sub GetDSNName(ByRef CB As ComboBox)
        Dim ReturnValue As Short
        Dim DSNName As String
        Dim DriverName As String
        Dim DSNNameLen As Short
        Dim DriverNameLen As Short
        Dim SQLEnv As Integer 'handle to the environment

        If SQLAllocEnv(SQLEnv) <> -1 Then
            Do Until ReturnValue <> SQL_SUCCESS
                DSNName = Space(1024)
                DriverName = Space(1024)
                ReturnValue = SQLDataSources(SQLEnv, SQL_FETCH_NEXT, DSNName, 1024, DSNNameLen, DriverName, 1024, DriverNameLen)
                DSNName = Left(DSNName, DSNNameLen)
                DriverName = Left(DriverName, DriverNameLen)
                If DSNName <> Space(DSNNameLen) Then
                    'If Left(DriverName, 8) = "Teradata" Then
                    CB.Items.Add(DSNName)
                    '    Console.WriteLine("DSN Name: " + DSNName)
                    '    Console.WriteLine("Driver Name: " + DriverName)
                    '    Console.WriteLine("")
                    'End If
                End If
            Loop
        End If
        Console.Read()

    End Sub
End Class
