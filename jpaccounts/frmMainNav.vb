Public Class frmMainNav

   
    Public Sub RefreshForm()

    End Sub








    Private Sub frmMainNav_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAddSupplier_Click(sender As Object, e As EventArgs) Handles btnAddSupplier.Click
        frmSupplierMaster.Show()
        Me.Hide()



    End Sub
End Class