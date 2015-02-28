Imports System.Data.Odbc
Imports DBOra.db
Imports System.Diagnostics

Module SupplierAdd
    Function AddNewSupplier(ByRef dbconn As OdbcConnection) As Int16

        'Function to Add a brand new Supplier

#If DEBUG Then
        Debug.WriteLine("Module : SupplierAdd  & Function : AddNewSupplier")

#End If

        Dim cmd As New OdbcCommand

        'SQL Command for Adding Data to Supplier Master 
        ' USE [jpaccounts]
        ' GO()

        ' INSERT INTO [dbo].[SUPPMAST]
        ' ([SUPPID]
        ' ,[SUPPNAME]
        ',[SUPPCONTACT]
        ',[SUPPADDRESS]
        ',[SUPPCITY]
        ',[SUPPSTATE]
        ',[SUPPCOUNTRY]
        ',[SUPPPOSTCODE]
        ',[SUPPPHONE]
        ',[SUPPCELL]
        ',[SUPPEMAIL]
        ',[SUPPWEBSITE]
        ',[SUPPCURRENCY]
        ',[SUPPVAT])
        ' VALUES()
        '  (<SUPPID, char(10),>
        ' ,<SUPPNAME, varchar(50),>
        ' ,<SUPPCONTACT, varchar(50),>
        ' ,<SUPPADDRESS, varchar(250),>
        ' ,<SUPPCITY, varchar(50),>
        ' ,<SUPPSTATE, varchar(50),>
        ' ,<SUPPCOUNTRY, varchar(50),>
        ' ,<SUPPPOSTCODE, varchar(10),>
        ' ,<SUPPPHONE, varchar(16),>
        ' ,<SUPPCELL, varchar(16),>
        ' ,<SUPPEMAIL, varchar(250),>
        ' ,<SUPPWEBSITE, varchar(250),>
        ' ,<SUPPCURRENCY, varchar(10),>
        ' ,<SUPPVAT, varchar(20),>)
        ' GO


        cmd.CommandText = "INSERT INTO [dbo].[SUPPMAST]" & _
        "(SUPPID" & _
        ",SUPPNAME" & _
        ",SUPPCONTACT" & _
        ",SUPPADDRESS" & _
        ",SUPPCITY" & _
        ",SUPPSTATE" & _
        ",SUPPCOUNTRY" & _
        ",SUPPPOSTCODE" & _
        ",SUPPPHONE" & _
        ",SUPPCELL" & _
        ",SUPPEMAIL" & _
        ",SUPPWEBSITE" & _
        ",SUPPCURRENCY" & _
        ",SUPPVAT)" & _
        " VALUES('" & _
          varSuppId.ToString() & "','" & _
          varSuppName.ToString() & "','" & _
          varSuppContact.ToString & "','" & _
          varSuppAddress.ToString() & "','" & _
          varSuppCity.ToString() & "','" & _
          varSuppState.ToString() & "','" & _
          varSuppCountry.ToString() & "','" & _
          varSuppPostCode.ToString() & "','" & _
          varSuppPhone.ToString() & "','" & _
          varSuppCell.ToString() & "','" & _
          varSuppEmail.ToString() & "','" & _
          varSuppWeb.ToString() & "','" & _
          varSuppCurrency.ToString() & "','" & _
          varSuppVAT.ToString() & "')"

#If DEBUG Then
        Debug.WriteLine("Running in Debug Mode: SQL Query " + cmd.CommandText)
#End If
        'Initialize Command Connection object with ODBC Connection object
        cmd.Connection = dbconn
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Database Error :" + ex.Message)
            Return 1

        End Try



        cmd = Nothing

        Return 0

    End Function

End Module
