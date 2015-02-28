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
        Me.cmbPayTo = New System.Windows.Forms.ComboBox()
        Me.JMultiColCombo1 = New jMutliColumnCombo.jMultiColCombo()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.JMultiColCombo1)
        Me.Panel1.Controls.Add(Me.cmbPayTo)
        Me.Panel1.Location = New System.Drawing.Point(25, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1366, 436)
        Me.Panel1.TabIndex = 0
        '
        'cmbPayTo
        '
        Me.cmbPayTo.FormattingEnabled = True
        Me.cmbPayTo.Location = New System.Drawing.Point(22, 18)
        Me.cmbPayTo.Name = "cmbPayTo"
        Me.cmbPayTo.Size = New System.Drawing.Size(219, 33)
        Me.cmbPayTo.TabIndex = 0
        '
        'JMultiColCombo1
        '
        Me.JMultiColCombo1.ColumnWidths = "100"
        Me.JMultiColCombo1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.JMultiColCombo1.FormattingEnabled = True
        Me.JMultiColCombo1.Location = New System.Drawing.Point(703, 119)
        Me.JMultiColCombo1.Name = "JMultiColCombo1"
        Me.JMultiColCombo1.Size = New System.Drawing.Size(427, 32)
        Me.JMultiColCombo1.TabIndex = 1
        '
        'frmSuppPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1418, 1037)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSuppPayment"
        Me.Text = "Pay Supplier"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbPayTo As System.Windows.Forms.ComboBox
    Friend WithEvents JMultiColCombo1 As jMutliColumnCombo.jMultiColCombo
End Class
