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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbSuppState = New System.Windows.Forms.ComboBox()
        Me.cmbSuppCurrency = New System.Windows.Forms.ComboBox()
        Me.txtSuppVAT = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
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
        Me.txtSuppID = New System.Windows.Forms.TextBox()
        Me.SupplierID = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.cmbSuppState)
        Me.Panel1.Controls.Add(Me.cmbSuppCurrency)
        Me.Panel1.Controls.Add(Me.txtSuppVAT)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TextBox7)
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
        Me.Panel1.Controls.Add(Me.txtSuppID)
        Me.Panel1.Controls.Add(Me.SupplierID)
        Me.Panel1.Font = New System.Drawing.Font("Candara", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(29, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(909, 633)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(543, 482)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(338, 92)
        Me.Panel2.TabIndex = 22
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(188, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 44)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Clear All"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(30, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 44)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbSuppState
        '
        Me.cmbSuppState.FormattingEnabled = True
        Me.cmbSuppState.Location = New System.Drawing.Point(187, 435)
        Me.cmbSuppState.Name = "cmbSuppState"
        Me.cmbSuppState.Size = New System.Drawing.Size(291, 32)
        Me.cmbSuppState.TabIndex = 21
        '
        'cmbSuppCurrency
        '
        Me.cmbSuppCurrency.FormattingEnabled = True
        Me.cmbSuppCurrency.Location = New System.Drawing.Point(662, 14)
        Me.cmbSuppCurrency.Name = "cmbSuppCurrency"
        Me.cmbSuppCurrency.Size = New System.Drawing.Size(219, 32)
        Me.cmbSuppCurrency.TabIndex = 20
        '
        'txtSuppVAT
        '
        Me.txtSuppVAT.Location = New System.Drawing.Point(662, 72)
        Me.txtSuppVAT.Name = "txtSuppVAT"
        Me.txtSuppVAT.Size = New System.Drawing.Size(219, 32)
        Me.txtSuppVAT.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(490, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 24)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Supplier VAT"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(480, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(158, 24)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Supplier Currency"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(187, 542)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(291, 32)
        Me.TextBox7.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 542)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 24)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Supplier PostCode"
        '
        'txtSuppCountry
        '
        Me.txtSuppCountry.Location = New System.Drawing.Point(187, 486)
        Me.txtSuppCountry.Name = "txtSuppCountry"
        Me.txtSuppCountry.Size = New System.Drawing.Size(291, 32)
        Me.txtSuppCountry.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 489)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 24)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Supplier Country"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 438)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 24)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Supplier State"
        '
        'txtSuppCity
        '
        Me.txtSuppCity.Location = New System.Drawing.Point(187, 384)
        Me.txtSuppCity.Name = "txtSuppCity"
        Me.txtSuppCity.Size = New System.Drawing.Size(291, 32)
        Me.txtSuppCity.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 384)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Supplier City"
        '
        'txtSuppAddress
        '
        Me.txtSuppAddress.Location = New System.Drawing.Point(187, 236)
        Me.txtSuppAddress.Multiline = True
        Me.txtSuppAddress.Name = "txtSuppAddress"
        Me.txtSuppAddress.Size = New System.Drawing.Size(291, 130)
        Me.txtSuppAddress.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Supplier Address"
        '
        'txtSuppContact
        '
        Me.txtSuppContact.Location = New System.Drawing.Point(187, 189)
        Me.txtSuppContact.Name = "txtSuppContact"
        Me.txtSuppContact.Size = New System.Drawing.Size(291, 32)
        Me.txtSuppContact.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Supplier Contact"
        '
        'txtSuppName
        '
        Me.txtSuppName.Location = New System.Drawing.Point(187, 143)
        Me.txtSuppName.Name = "txtSuppName"
        Me.txtSuppName.Size = New System.Drawing.Size(291, 32)
        Me.txtSuppName.TabIndex = 3
        '
        'lblSuppName
        '
        Me.lblSuppName.AutoSize = True
        Me.lblSuppName.Location = New System.Drawing.Point(15, 146)
        Me.lblSuppName.Name = "lblSuppName"
        Me.lblSuppName.Size = New System.Drawing.Size(132, 24)
        Me.lblSuppName.TabIndex = 2
        Me.lblSuppName.Text = "Supplier Name"
        '
        'txtSuppID
        '
        Me.txtSuppID.Location = New System.Drawing.Point(145, 11)
        Me.txtSuppID.Name = "txtSuppID"
        Me.txtSuppID.Size = New System.Drawing.Size(187, 32)
        Me.txtSuppID.TabIndex = 1
        '
        'SupplierID
        '
        Me.SupplierID.AutoSize = True
        Me.SupplierID.Location = New System.Drawing.Point(15, 14)
        Me.SupplierID.Name = "SupplierID"
        Me.SupplierID.Size = New System.Drawing.Size(102, 24)
        Me.SupplierID.TabIndex = 0
        Me.SupplierID.Text = "Supplier ID"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.Location = New System.Drawing.Point(-1, 121)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(910, 10)
        Me.Panel3.TabIndex = 23
        '
        'frmSupplierMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(971, 679)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSupplierMaster"
        Me.Text = "Supplier Master"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtSuppID As System.Windows.Forms.TextBox
    Friend WithEvents SupplierID As System.Windows.Forms.Label
    Friend WithEvents txtSuppVAT As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
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
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmbSuppState As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSuppCurrency As System.Windows.Forms.ComboBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
