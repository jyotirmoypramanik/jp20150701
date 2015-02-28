Imports DBOra.db
Public Class frmLogin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.
     Public odbconn As Odbc.OdbcConnection
    Dim MyConn As DBUsersGenClass
    Dim varuser As String
    Dim varpwd As String

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        ' Me.Close()
        If checkinput() = True Then
            varuser = Me.UsernameTextBox.Text
            varpwd = Me.PasswordTextBox.Text
            Dim retsts As Integer = checkappuser(odbconn, varuser, varpwd)
            If retsts = 1 Then
                'MsgBox("Login Sucessfull")
                MyConn = New DBUsersGenClass
                MyConn.CheckDBVersion()

            Else
                MsgBox("Database Login Not Sucessfull, Please review the database configuration file - dbconn.xml")
            End If
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Size = New System.Drawing.Size(800, 640)
        Me.UsernameTextBox.Text = ""
        Me.PasswordTextBox.Text = ""

#If DEBUG Then
        Me.UsernameTextBox.Text = "jyoti"
        Me.PasswordTextBox.Text = "jyoti123"
#End If
        readdbconfig()
        appdbconn = New DBOra.db(mydsn, myuserid, mypwd)
        If appdbconn.ConnectToDb() = False Then
            MsgBox("DB Connection unsucessfull")
        Else
#If DEBUG Then
            Debug.WriteLine("DB Connection sucessfull")
            MsgBox("DB Connection sucessfull")
#End If
        End If
        'Associating DB appdbconn with odbconn
        odbconn = appdbconn.getDBConn
        'If appdbconn.ConnStatus() = True Then
        '    MsgBox("Connected")
        'End If

    End Sub
    Function checkinput() As Boolean
        If Me.UsernameTextBox.Text = "" Then
            MsgBox("Input UserName  Left Blank")
            Return False
        End If
        If Me.PasswordTextBox.Text = "" Then
            MsgBox("Input UserPassword  Left Blank")
            Return False
        End If
        Return True


    End Function
End Class
