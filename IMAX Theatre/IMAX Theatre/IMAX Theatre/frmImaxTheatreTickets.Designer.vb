<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImaxTheatreTickets
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
        Me.lblTicketTotal = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnTicketCost = New System.Windows.Forms.Button()
        Me.txtNumberOfTickets = New System.Windows.Forms.TextBox()
        Me.lblNumberOfTickets = New System.Windows.Forms.Label()
        Me.cboTickets = New System.Windows.Forms.ComboBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblTicketTotal)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnTicketCost)
        Me.Panel1.Controls.Add(Me.txtNumberOfTickets)
        Me.Panel1.Controls.Add(Me.lblNumberOfTickets)
        Me.Panel1.Controls.Add(Me.cboTickets)
        Me.Panel1.Controls.Add(Me.lblHeader)
        Me.Panel1.Location = New System.Drawing.Point(397, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(402, 448)
        Me.Panel1.TabIndex = 0
        '
        'lblTicketTotal
        '
        Me.lblTicketTotal.AutoSize = True
        Me.lblTicketTotal.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblTicketTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicketTotal.ForeColor = System.Drawing.Color.White
        Me.lblTicketTotal.Location = New System.Drawing.Point(111, 375)
        Me.lblTicketTotal.Name = "lblTicketTotal"
        Me.lblTicketTotal.Size = New System.Drawing.Size(180, 20)
        Me.lblTicketTotal.TabIndex = 6
        Me.lblTicketTotal.Text = "$xxx.xx for the tickets"
        Me.lblTicketTotal.Visible = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(132, 300)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(139, 39)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = False
        Me.btnClear.Visible = False
        '
        'btnTicketCost
        '
        Me.btnTicketCost.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnTicketCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTicketCost.ForeColor = System.Drawing.Color.White
        Me.btnTicketCost.Location = New System.Drawing.Point(132, 255)
        Me.btnTicketCost.Name = "btnTicketCost"
        Me.btnTicketCost.Size = New System.Drawing.Size(139, 39)
        Me.btnTicketCost.TabIndex = 4
        Me.btnTicketCost.Text = "Ticket Cost"
        Me.btnTicketCost.UseVisualStyleBackColor = False
        Me.btnTicketCost.Visible = False
        '
        'txtNumberOfTickets
        '
        Me.txtNumberOfTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfTickets.Location = New System.Drawing.Point(176, 187)
        Me.txtNumberOfTickets.Name = "txtNumberOfTickets"
        Me.txtNumberOfTickets.Size = New System.Drawing.Size(50, 29)
        Me.txtNumberOfTickets.TabIndex = 3
        Me.txtNumberOfTickets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNumberOfTickets.Visible = False
        '
        'lblNumberOfTickets
        '
        Me.lblNumberOfTickets.AutoSize = True
        Me.lblNumberOfTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfTickets.Location = New System.Drawing.Point(108, 140)
        Me.lblNumberOfTickets.Name = "lblNumberOfTickets"
        Me.lblNumberOfTickets.Size = New System.Drawing.Size(186, 24)
        Me.lblNumberOfTickets.TabIndex = 2
        Me.lblNumberOfTickets.Text = "Number of Tickets:"
        Me.lblNumberOfTickets.Visible = False
        '
        'cboTickets
        '
        Me.cboTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTickets.FormattingEnabled = True
        Me.cboTickets.Items.AddRange(New Object() {"Matinee $16 ", "Evening $27"})
        Me.cboTickets.Location = New System.Drawing.Point(89, 83)
        Me.cboTickets.Name = "cboTickets"
        Me.cboTickets.Size = New System.Drawing.Size(225, 32)
        Me.cboTickets.TabIndex = 1
        Me.cboTickets.Text = "Select Tickets"
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(16, 21)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(370, 39)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "IMAX Theatre Tickets"
        '
        'frmImaxTheatreTickets
        '
        Me.AcceptButton = Me.btnTicketCost
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.IMAX_Theatre.My.Resources.Resources.imax
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmImaxTheatreTickets"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTicketTotal As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnTicketCost As Button
    Friend WithEvents txtNumberOfTickets As TextBox
    Friend WithEvents lblNumberOfTickets As Label
    Friend WithEvents cboTickets As ComboBox
    Friend WithEvents lblHeader As Label
End Class
