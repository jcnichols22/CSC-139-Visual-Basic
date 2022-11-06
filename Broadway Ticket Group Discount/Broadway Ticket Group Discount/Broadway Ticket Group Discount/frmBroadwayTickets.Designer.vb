<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBroadwayTickets
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblNumOfGuests = New System.Windows.Forms.Label()
        Me.txtNumOfGuests = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(214, 70)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(372, 37)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Broadway Ticket Prices"
        '
        'lblNumOfGuests
        '
        Me.lblNumOfGuests.AutoSize = True
        Me.lblNumOfGuests.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumOfGuests.Location = New System.Drawing.Point(207, 157)
        Me.lblNumOfGuests.Name = "lblNumOfGuests"
        Me.lblNumOfGuests.Size = New System.Drawing.Size(309, 24)
        Me.lblNumOfGuests.TabIndex = 1
        Me.lblNumOfGuests.Text = "Please Enter Number of Guests:"
        '
        'txtNumOfGuests
        '
        Me.txtNumOfGuests.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumOfGuests.Location = New System.Drawing.Point(543, 152)
        Me.txtNumOfGuests.Name = "txtNumOfGuests"
        Me.txtNumOfGuests.Size = New System.Drawing.Size(51, 29)
        Me.txtNumOfGuests.TabIndex = 2
        Me.txtNumOfGuests.Text = "99"
        Me.txtNumOfGuests.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(157, 363)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(487, 24)
        Me.lblTotal.TabIndex = 3
        Me.lblTotal.Text = "For your Group of 99 the cost would be  $16,731.00"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(224, 242)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(126, 46)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(450, 242)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(126, 46)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmBroadwayTickets
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtNumOfGuests)
        Me.Controls.Add(Me.lblNumOfGuests)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmBroadwayTickets"
        Me.Text = "Broadway Ticket Prices"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblNumOfGuests As Label
    Friend WithEvents txtNumOfGuests As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
End Class
