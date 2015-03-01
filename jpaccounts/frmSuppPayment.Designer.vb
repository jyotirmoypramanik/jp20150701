<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuppPayment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSuppPostCode = New System.Windows.Forms.MaskedTextBox()
        Me.txtSuppPhone = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbSuppState = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSuppCountry = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSuppCity = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSuppAddress = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSuppContact = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSuppName = New System.Windows.Forms.TextBox()
        Me.lblSuppName = New System.Windows.Forms.Label()
        Me.txtPayDate = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblSuppID = New System.Windows.Forms.Label()
        Me.cmbPayTo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.lblAmt = New System.Windows.Forms.Label()
        Me.txtVoucherAmt = New System.Windows.Forms.TextBox()
        Me.lblVoucherAmt = New System.Windows.Forms.Label()
        Me.lblPaymentType = New System.Windows.Forms.Label()
        Me.txtPaymentRef = New System.Windows.Forms.TextBox()
        Me.lblPaymentReference = New System.Windows.Forms.Label()
        Me.cmbPaymentType = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblVoucherAmtdue = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtSuppPostCode)
        Me.Panel1.Controls.Add(Me.txtSuppPhone)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cmbSuppState)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtSuppCountry)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtSuppCity)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtSuppAddress)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtSuppContact)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtSuppName)
        Me.Panel1.Controls.Add(Me.lblSuppName)
        Me.Panel1.Location = New System.Drawing.Point(27, 129)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1363, 322)
        Me.Panel1.TabIndex = 0
        '
        'txtSuppPostCode
        '
        Me.txtSuppPostCode.Location = New System.Drawing.Point(893, 209)
        Me.txtSuppPostCode.Mask = "AAAA AAA"
        Me.txtSuppPostCode.Name = "txtSuppPostCode"
        Me.txtSuppPostCode.Size = New System.Drawing.Size(386, 31)
        Me.txtSuppPostCode.TabIndex = 42
        '
        'txtSuppPhone
        '
        Me.txtSuppPhone.Location = New System.Drawing.Point(894, 270)
        Me.txtSuppPhone.Mask = "(999) 000-0000"
        Me.txtSuppPhone.Name = "txtSuppPhone"
        Me.txtSuppPhone.Size = New System.Drawing.Size(386, 31)
        Me.txtSuppPhone.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(663, 270)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 25)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Supplier Phone"
        '
        'cmbSuppState
        '
        Me.cmbSuppState.FormattingEnabled = True
        Me.cmbSuppState.Location = New System.Drawing.Point(893, 75)
        Me.cmbSuppState.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSuppState.Name = "cmbSuppState"
        Me.cmbSuppState.Size = New System.Drawing.Size(387, 33)
        Me.cmbSuppState.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(663, 209)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(191, 25)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Supplier PostCode"
        '
        'txtSuppCountry
        '
        Me.txtSuppCountry.Location = New System.Drawing.Point(893, 139)
        Me.txtSuppCountry.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSuppCountry.Name = "txtSuppCountry"
        Me.txtSuppCountry.Size = New System.Drawing.Size(387, 31)
        Me.txtSuppCountry.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(663, 142)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(172, 25)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Supplier Country"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(671, 79)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(147, 25)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Supplier State"
        '
        'txtSuppCity
        '
        Me.txtSuppCity.Location = New System.Drawing.Point(893, 11)
        Me.txtSuppCity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSuppCity.Name = "txtSuppCity"
        Me.txtSuppCity.Size = New System.Drawing.Size(387, 31)
        Me.txtSuppCity.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(664, 11)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(134, 25)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Supplier City"
        '
        'txtSuppAddress
        '
        Me.txtSuppAddress.Enabled = False
        Me.txtSuppAddress.Location = New System.Drawing.Point(247, 127)
        Me.txtSuppAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSuppAddress.Multiline = True
        Me.txtSuppAddress.Name = "txtSuppAddress"
        Me.txtSuppAddress.Size = New System.Drawing.Size(387, 162)
        Me.txtSuppAddress.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Location = New System.Drawing.Point(18, 127)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 25)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Supplier Address"
        '
        'txtSuppContact
        '
        Me.txtSuppContact.Enabled = False
        Me.txtSuppContact.Location = New System.Drawing.Point(247, 68)
        Me.txtSuppContact.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSuppContact.Name = "txtSuppContact"
        Me.txtSuppContact.Size = New System.Drawing.Size(387, 31)
        Me.txtSuppContact.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Location = New System.Drawing.Point(18, 72)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Supplier Contact"
        '
        'txtSuppName
        '
        Me.txtSuppName.Enabled = False
        Me.txtSuppName.Location = New System.Drawing.Point(247, 11)
        Me.txtSuppName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSuppName.Name = "txtSuppName"
        Me.txtSuppName.Size = New System.Drawing.Size(387, 31)
        Me.txtSuppName.TabIndex = 8
        '
        'lblSuppName
        '
        Me.lblSuppName.AutoSize = True
        Me.lblSuppName.Enabled = False
        Me.lblSuppName.Location = New System.Drawing.Point(18, 14)
        Me.lblSuppName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSuppName.Name = "lblSuppName"
        Me.lblSuppName.Size = New System.Drawing.Size(153, 25)
        Me.lblSuppName.TabIndex = 9
        Me.lblSuppName.Text = "Supplier Name"
        '
        'txtPayDate
        '
        Me.txtPayDate.Location = New System.Drawing.Point(896, 19)
        Me.txtPayDate.Name = "txtPayDate"
        Me.txtPayDate.Size = New System.Drawing.Size(188, 31)
        Me.txtPayDate.TabIndex = 3
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(809, 23)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(69, 25)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "Date :"
        '
        'lblSuppID
        '
        Me.lblSuppID.AutoSize = True
        Me.lblSuppID.Location = New System.Drawing.Point(39, 26)
        Me.lblSuppID.Name = "lblSuppID"
        Me.lblSuppID.Size = New System.Drawing.Size(168, 25)
        Me.lblSuppID.TabIndex = 1
        Me.lblSuppID.Text = "Choose Supp ID"
        '
        'cmbPayTo
        '
        Me.cmbPayTo.FormattingEnabled = True
        Me.cmbPayTo.Location = New System.Drawing.Point(242, 23)
        Me.cmbPayTo.Name = "cmbPayTo"
        Me.cmbPayTo.Size = New System.Drawing.Size(285, 33)
        Me.cmbPayTo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Voucher No#"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(242, 22)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(285, 33)
        Me.ComboBox1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.cmbPayTo)
        Me.Panel2.Controls.Add(Me.lblSuppID)
        Me.Panel2.Controls.Add(Me.lblDate)
        Me.Panel2.Controls.Add(Me.txtPayDate)
        Me.Panel2.Location = New System.Drawing.Point(27, 29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1366, 80)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Controls.Add(Me.TextBox2)
        Me.Panel3.Controls.Add(Me.lblVoucherAmtdue)
        Me.Panel3.Controls.Add(Me.ComboBox1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txtVoucherAmt)
        Me.Panel3.Controls.Add(Me.lblVoucherAmt)
        Me.Panel3.Location = New System.Drawing.Point(27, 467)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1363, 150)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel4.Controls.Add(Me.txtPaymentRef)
        Me.Panel4.Controls.Add(Me.cmbPaymentType)
        Me.Panel4.Controls.Add(Me.lblPaymentReference)
        Me.Panel4.Controls.Add(Me.txtAmount)
        Me.Panel4.Controls.Add(Me.lblAmt)
        Me.Panel4.Controls.Add(Me.lblPaymentType)
        Me.Panel4.Location = New System.Drawing.Point(27, 663)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1363, 136)
        Me.Panel4.TabIndex = 3
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(902, 19)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(387, 31)
        Me.txtAmount.TabIndex = 42
        '
        'lblAmt
        '
        Me.lblAmt.AutoSize = True
        Me.lblAmt.Location = New System.Drawing.Point(673, 19)
        Me.lblAmt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAmt.Name = "lblAmt"
        Me.lblAmt.Size = New System.Drawing.Size(175, 25)
        Me.lblAmt.TabIndex = 44
        Me.lblAmt.Text = "Payment Amount"
        '
        'txtVoucherAmt
        '
        Me.txtVoucherAmt.Enabled = False
        Me.txtVoucherAmt.Location = New System.Drawing.Point(894, 25)
        Me.txtVoucherAmt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVoucherAmt.Name = "txtVoucherAmt"
        Me.txtVoucherAmt.Size = New System.Drawing.Size(387, 31)
        Me.txtVoucherAmt.TabIndex = 40
        '
        'lblVoucherAmt
        '
        Me.lblVoucherAmt.AutoSize = True
        Me.lblVoucherAmt.Enabled = False
        Me.lblVoucherAmt.Location = New System.Drawing.Point(665, 28)
        Me.lblVoucherAmt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVoucherAmt.Name = "lblVoucherAmt"
        Me.lblVoucherAmt.Size = New System.Drawing.Size(171, 25)
        Me.lblVoucherAmt.TabIndex = 41
        Me.lblVoucherAmt.Text = "Voucher Amount"
        '
        'lblPaymentType
        '
        Me.lblPaymentType.AutoSize = True
        Me.lblPaymentType.Enabled = False
        Me.lblPaymentType.Location = New System.Drawing.Point(27, 22)
        Me.lblPaymentType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPaymentType.Name = "lblPaymentType"
        Me.lblPaymentType.Size = New System.Drawing.Size(150, 25)
        Me.lblPaymentType.TabIndex = 39
        Me.lblPaymentType.Text = "Payment Type"
        '
        'txtPaymentRef
        '
        Me.txtPaymentRef.Enabled = False
        Me.txtPaymentRef.Location = New System.Drawing.Point(902, 68)
        Me.txtPaymentRef.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPaymentRef.Name = "txtPaymentRef"
        Me.txtPaymentRef.Size = New System.Drawing.Size(387, 31)
        Me.txtPaymentRef.TabIndex = 10
        '
        'lblPaymentReference
        '
        Me.lblPaymentReference.AutoSize = True
        Me.lblPaymentReference.Enabled = False
        Me.lblPaymentReference.Location = New System.Drawing.Point(673, 71)
        Me.lblPaymentReference.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPaymentReference.Name = "lblPaymentReference"
        Me.lblPaymentReference.Size = New System.Drawing.Size(201, 25)
        Me.lblPaymentReference.TabIndex = 11
        Me.lblPaymentReference.Text = "Payment Reference"
        '
        'cmbPaymentType
        '
        Me.cmbPaymentType.FormattingEnabled = True
        Me.cmbPaymentType.Items.AddRange(New Object() {"Cheque", "Cash", "Credit Note"})
        Me.cmbPaymentType.Location = New System.Drawing.Point(256, 16)
        Me.cmbPaymentType.Name = "cmbPaymentType"
        Me.cmbPaymentType.Size = New System.Drawing.Size(285, 33)
        Me.cmbPaymentType.TabIndex = 46
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(894, 80)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(387, 31)
        Me.TextBox2.TabIndex = 42
        '
        'lblVoucherAmtdue
        '
        Me.lblVoucherAmtdue.AutoSize = True
        Me.lblVoucherAmtdue.Enabled = False
        Me.lblVoucherAmtdue.Location = New System.Drawing.Point(665, 83)
        Me.lblVoucherAmtdue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVoucherAmtdue.Name = "lblVoucherAmtdue"
        Me.lblVoucherAmtdue.Size = New System.Drawing.Size(216, 25)
        Me.lblVoucherAmtdue.TabIndex = 43
        Me.lblVoucherAmtdue.Text = "Voucher Amount Due"
        '
        'frmSuppPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(1418, 827)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSuppPayment"
        Me.Text = "Pay Supplier"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbPayTo As System.Windows.Forms.ComboBox
    Friend WithEvents lblSuppID As System.Windows.Forms.Label
    Friend WithEvents txtPayDate As System.Windows.Forms.TextBox
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSuppAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSuppContact As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSuppName As System.Windows.Forms.TextBox
    Friend WithEvents lblSuppName As System.Windows.Forms.Label
    Friend WithEvents txtSuppPostCode As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtSuppPhone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbSuppState As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSuppCountry As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSuppCity As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents lblVoucherAmtdue As System.Windows.Forms.Label
    Friend WithEvents txtVoucherAmt As System.Windows.Forms.TextBox
    Friend WithEvents lblVoucherAmt As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtPaymentRef As System.Windows.Forms.TextBox
    Friend WithEvents cmbPaymentType As System.Windows.Forms.ComboBox
    Friend WithEvents lblPaymentReference As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblAmt As System.Windows.Forms.Label
    Friend WithEvents lblPaymentType As System.Windows.Forms.Label
End Class
