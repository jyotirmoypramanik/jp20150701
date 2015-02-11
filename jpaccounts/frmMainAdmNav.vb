Public Class frmMainAdmNav

    Private Sub frmMainAdmNav_FormClosed1(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
 
    Private Sub frmMainAdmNav_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub RefreshForm()

    End Sub
    Private Sub frmMainAdmNav_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim result As Integer = MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Select Case result
            Case Windows.Forms.DialogResult.Yes
                'nothing to do here the form is already closing



            Case Windows.Forms.DialogResult.No
                e.Cancel = True 'cancel the form closing event
                'minimize to tray/hide etc here 
        End Select
    End Sub




    Private Sub btnAddSupplier_Click(sender As Object, e As EventArgs) Handles btnAddSupplier.Click
        Me.Hide()
        frmSupplierMaster.Show()

    End Sub
End Class