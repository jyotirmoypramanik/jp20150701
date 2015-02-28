<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupplierMaster
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSuppClearAll = New System.Windows.Forms.Button()
        Me.btnSuppSave = New System.Windows.Forms.Button()
        Me.cmbSuppState = New System.Windows.Forms.ComboBox()
        Me.cmbSuppCurrency = New System.Windows.Forms.ComboBox()
        Me.txtSuppVAT = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSuppCountry = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSuppCity = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSuppAddress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSuppContact = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSuppName = New System.Windows.Forms.TextBox()
        Me.lblSuppName = New System.Windows.Forms.Label()
        Me.SupplierID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSuppCellPhone = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSuppURL = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSuppPhone = New System.Windows.Forms.MaskedTextBox()
        Me.txtSuppPostCode = New System.Windows.Forms.MaskedTextBox()
        Me.txtSuppID = New System.Windows.Forms.MaskedTextBox()
        Me.txtSuppEmail = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtSuppEmail)
        Me.Panel1.Controls.Add(Me.txtSuppID)
        Me.Panel1.Controls.Add(Me.txtSuppPostCode)
        Me.Panel1.Controls.Add(Me.txtSuppPhone)
        Me.Panel1.Controls.Add(Me.txtSuppURL)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtSuppCellPhone)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.cmbSuppState)
        Me.Panel1.Controls.Add(Me.cmbSuppCurrency)
        Me.Panel1.Controls.Add(Me.txtSuppVAT)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtSuppCountry)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtSuppCity)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtSuppAddress)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtSuppContact)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtSuppName)
        Me.Panel1.Controls.Add(Me.lblSuppName)
        Me.Panel1.Controls.Add(Me.SupplierID)
        Me.Panel1.Font = New System.Drawing.Font("Candara", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(39, 31)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1209, 987)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.Location = New System.Drawing.Point(-1, 151)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1213, 12)
        Me.Panel3.TabIndex = 23
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Controls.Add(Me.btnSuppClearAll)
        Me.Panel2.Controls.Add(Me.btnSuppSave)
        Me.Panel2.Location = New System.Drawing.Point(699, 825)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(451, 115)
        Me.Panel2.TabIndex = 15
        '
        'btnSuppClearAll
        '
        Me.btnSuppClearAll.Location = New System.Drawing.Point(251, 28)
        Me.btnSuppClearAll.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSuppClearAll.Name = "btnSuppClearAll"
        Me.btnSuppClearAll.Size = New System.Drawing.Size(135, 55)
        Me.btnSuppClearAll.TabIndex = 1
        Me.btnSuppClearAll.Text = "Clear All"
        Me.btnSuppClearAll.UseVisualStyleBackColor = True
        '
        'btnSuppSave
        '
        Me.btnSuppSave.Location = New System.Drawing.Point(40, 28)
        Me.btnSuppSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSuppSave.Name = "btnSuppSave"
        Me.btnSuppSave.Size = New System.Drawing.Size(135, 55)
        Me.btnSuppSave.TabIndex = 0
        Me.btnSuppSave.Text = "Save"
        Me.btnSuppSave.UseVisualStyleBackColor = True
        '
        'cmbSuppState
        '
        Me.cmbSuppState.FormattingEnabled = True
        Me.cmbSuppState.Location = New System.Drawing.Point(249, 544)
        Me.cmbSuppState.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbSuppState.Name = "cmbSuppState"
        Me.cmbSuppState.Size = New System.Drawing.Size(387, 41)
        Me.cmbSuppState.TabIndex = 6
        '
        'cmbSuppCurrency
        '
        Me.cmbSuppCurrency.FormattingEnabled = True
        Me.cmbSuppCurrency.Location = New System.Drawing.Point(883, 18)
        Me.cmbSuppCurrency.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbSuppCurrency.Name = "cmbSuppCurrency"
        Me.cmbSuppCurrency.Size = New System.Drawing.Size(291, 41)
        Me.cmbSuppCurrency.TabIndex = 13
        '
        'txtSuppVAT
        '
        Me.txtSuppVAT.Location = New System.Drawing.Point(883, 90)
        Me.txtSuppVAT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSuppVAT.Name = "txtSuppVAT"
        Me.txtSuppVAT.Size = New System.Drawing.Size(291, 40)
        Me.txtSuppVAT.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(653, 90)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(159, 33)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Supplier VAT"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(640, 24)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(218, 33)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Supplier Currency"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 678)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(225, 33)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Supplier PostCode"
        '
        'txtSuppCountry
        '
        Me.txtSuppCountry.Location = New System.Drawing.Point(249, 608)
        Me.txtSuppCountry.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSuppCountry.Name = "txtSuppCountry"
        Me.txtSuppCountry.Size = New System.Drawing.Size(387, 40)
        Me.txtSuppCountry.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 611)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(207, 33)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Supplier Country"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 548)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 33)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Supplier State"
        '
        'txtSuppCity
        '
        Me.txtSuppCity.Location = New System.Drawing.Point(249, 480)
        Me.txtSuppCity.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSuppCity.Name = "txtSuppCity"
        Me.txtSuppCity.Size = New System.Drawing.Size(387, 40)
        Me.txtSuppCity.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 480)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 33)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Supplier City"
        '
        'txtSuppAddress
        '
        Me.txtSuppAddress.Location = New System.Drawing.Point(249, 295)
        Me.txtSuppAddress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSuppAddress.Multiline = True
        Me.txtSuppAddress.Name = "txtSuppAddress"
        Me.txtSuppAddress.Size = New System.Drawing.Size(387, 162)
        Me.txtSuppAddress.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 295)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 33)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Supplier Address"
        '
        'txtSuppContact
        '
        Me.txtSuppContact.Location = New System.Drawing.Point(249, 236)
        Me.txtSuppContact.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSuppContact.Name = "txtSuppContact"
        Me.txtSuppContact.Size = New System.Drawing.Size(387, 40)
        Me.txtSuppContact.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 240)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 33)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Supplier Contact"
        '
        'txtSuppName
        '
        Me.txtSuppName.Location = New System.Drawing.Point(249, 179)
        Me.txtSuppName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSuppName.Name = "txtSuppName"
        Me.txtSuppName.Size = New System.Drawing.Size(387, 40)
        Me.txtSuppName.TabIndex = 2
        '
        'lblSuppName
        '
        Me.lblSuppName.AutoSize = True
        Me.lblSuppName.Location = New System.Drawing.Point(20, 182)
        Me.lblSuppName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSuppName.Name = "lblSuppName"
        Me.lblSuppName.Size = New System.Drawing.Size(182, 33)
        Me.lblSuppName.TabIndex = 2
        Me.lblSuppName.Text = "Supplier Name"
        '
        'SupplierID
        '
        Me.SupplierID.AutoSize = True
        Me.SupplierID.Location = New System.Drawing.Point(20, 18)
        Me.SupplierID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SupplierID.Name = "SupplierID"
        Me.SupplierID.Size = New System.Drawing.Size(139, 33)
        Me.SupplierID.TabIndex = 0
        Me.SupplierID.Text = "Supplier ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 739)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 33)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Supplier Phone"
        '
        'txtSuppCellPhone
        '
        Me.txtSuppCellPhone.Location = New System.Drawing.Point(250, 798)
        Me.txtSuppCellPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSuppCellPhone.Name = "txtSuppCellPhone"
        Me.txtSuppCellPhone.Size = New System.Drawing.Size(387, 40)
        Me.txtSuppCellPhone.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 798)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(146, 33)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Supplie Cell"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(20, 856)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(176, 33)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Supplier Email"
        '
        'txtSuppURL
        '
        Me.txtSuppURL.Location = New System.Drawing.Point(250, 918)
        Me.txtSuppURL.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSuppURL.Name = "txtSuppURL"
        Me.txtSuppURL.Size = New System.Drawing.Size(387, 40)
        Me.txtSuppURL.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(27, 918)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(208, 33)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Supplier Website"
        '
        'txtSuppPhone
        '
        Me.txtSuppPhone.Location = New System.Drawing.Point(250, 739)
        Me.txtSuppPhone.Mask = "(999) 000-0000"
        Me.txtSuppPhone.Name = "txtSuppPhone"
        Me.txtSuppPhone.Size = New System.Drawing.Size(386, 40)
        Me.txtSuppPhone.TabIndex = 31
        '
        'txtSuppPostCode
        '
        Me.txtSuppPostCode.Location = New System.Drawing.Point(249, 678)
        Me.txtSuppPostCode.Mask = "AAAA AAA"
        Me.txtSuppPostCode.Name = "txtSuppPostCode"
        Me.txtSuppPostCode.Size = New System.Drawing.Size(386, 40)
        Me.txtSuppPostCode.TabIndex = 32
        '
        'txtSuppID
        '
        Me.txtSuppID.Location = New System.Drawing.Point(203, 15)
        Me.txtSuppID.Mask = "AA00000000"
        Me.txtSuppID.Name = "txtSuppID"
        Me.txtSuppID.Size = New System.Drawing.Size(228, 40)
        Me.txtSuppID.TabIndex = 33
        '
        'txtSuppEmail
        '
        Me.txtSuppEmail.Location = New System.Drawing.Point(250, 853)
        Me.txtSuppEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSuppEmail.Name = "txtSuppEmail"
        Me.txtSuppEmail.Size = New System.Drawing.Size(387, 40)
        Me.txtSuppEmail.TabIndex = 34
        '
        'frmSupplierMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(1285, 1039)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmSupplierMaster"
        Me.Text = "Supplier Master"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SupplierID As System.Windows.Forms.Label
    Friend WithEvents txtSuppVAT As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSuppCountry As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSuppCity As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSuppAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSuppContact As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSuppName As System.Windows.Forms.TextBox
    Friend WithEvents lblSuppName As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnSuppClearAll As System.Windows.Forms.Button
    Friend WithEvents btnSuppSave As System.Windows.Forms.Button
    Friend WithEvents cmbSuppState As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSuppCurrency As System.Windows.Forms.ComboBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtSuppURL As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtSuppCellPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSuppPhone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtSuppID As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtSuppPostCode As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtSuppEmail As System.Windows.Forms.TextBox
End Class
