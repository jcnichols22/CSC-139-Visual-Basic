<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeattleWalkingTour
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSeattleWalkingTour))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblPriceHeading = New System.Windows.Forms.Label()
        Me.lblNumberOfTickets = New System.Windows.Forms.Label()
        Me.lblTotalCostTxt = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.btnDisplayCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtNumberOfTickets = New System.Windows.Forms.TextBox()
        Me.picSeattle = New System.Windows.Forms.PictureBox()
        CType(Me.picSeattle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.White
        Me.lblHeading.Location = New System.Drawing.Point(31, 21)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(418, 31)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Seattle Walking Tour Tickets"
        '
        'lblPriceHeading
        '
        Me.lblPriceHeading.AutoSize = True
        Me.lblPriceHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceHeading.ForeColor = System.Drawing.Color.White
        Me.lblPriceHeading.Location = New System.Drawing.Point(166, 62)
        Me.lblPriceHeading.Name = "lblPriceHeading"
        Me.lblPriceHeading.Size = New System.Drawing.Size(149, 20)
        Me.lblPriceHeading.TabIndex = 1
        Me.lblPriceHeading.Text = "$14.99 Per Ticket"
        '
        'lblNumberOfTickets
        '
        Me.lblNumberOfTickets.AutoSize = True
        Me.lblNumberOfTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfTickets.ForeColor = System.Drawing.Color.White
        Me.lblNumberOfTickets.Location = New System.Drawing.Point(73, 163)
        Me.lblNumberOfTickets.Name = "lblNumberOfTickets"
        Me.lblNumberOfTickets.Size = New System.Drawing.Size(208, 20)
        Me.lblNumberOfTickets.TabIndex = 2
        Me.lblNumberOfTickets.Text = "Enter Number of Tickets:"
        '
        'lblTotalCostTxt
        '
        Me.lblTotalCostTxt.AutoSize = True
        Me.lblTotalCostTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCostTxt.ForeColor = System.Drawing.Color.White
        Me.lblTotalCostTxt.Location = New System.Drawing.Point(73, 229)
        Me.lblTotalCostTxt.Name = "lblTotalCostTxt"
        Me.lblTotalCostTxt.Size = New System.Drawing.Size(179, 20)
        Me.lblTotalCostTxt.TabIndex = 3
        Me.lblTotalCostTxt.Text = "Total Cost of Tickets:"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.ForeColor = System.Drawing.Color.White
        Me.lblTotalCost.Location = New System.Drawing.Point(294, 229)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(74, 20)
        Me.lblTotalCost.TabIndex = 4
        Me.lblTotalCost.Text = "$000.00"
        '
        'btnDisplayCost
        '
        Me.btnDisplayCost.BackColor = System.Drawing.Color.LightGray
        Me.btnDisplayCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayCost.Location = New System.Drawing.Point(57, 329)
        Me.btnDisplayCost.Name = "btnDisplayCost"
        Me.btnDisplayCost.Size = New System.Drawing.Size(81, 56)
        Me.btnDisplayCost.TabIndex = 5
        Me.btnDisplayCost.Text = "Display Cost"
        Me.btnDisplayCost.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightGray
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(196, 329)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(81, 56)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LightGray
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(335, 329)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(81, 56)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtNumberOfTickets
        '
        Me.txtNumberOfTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfTickets.Location = New System.Drawing.Point(320, 163)
        Me.txtNumberOfTickets.Name = "txtNumberOfTickets"
        Me.txtNumberOfTickets.Size = New System.Drawing.Size(23, 26)
        Me.txtNumberOfTickets.TabIndex = 8
        Me.txtNumberOfTickets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'picSeattle
        '
        Me.picSeattle.Image = CType(resources.GetObject("picSeattle.Image"), System.Drawing.Image)
        Me.picSeattle.Location = New System.Drawing.Point(480, 12)
        Me.picSeattle.Name = "picSeattle"
        Me.picSeattle.Size = New System.Drawing.Size(350, 408)
        Me.picSeattle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSeattle.TabIndex = 9
        Me.picSeattle.TabStop = False
        '
        'frmSeattleWalkingTour
        '
        Me.AcceptButton = Me.btnDisplayCost
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(842, 432)
        Me.Controls.Add(Me.picSeattle)
        Me.Controls.Add(Me.txtNumberOfTickets)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplayCost)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblTotalCostTxt)
        Me.Controls.Add(Me.lblNumberOfTickets)
        Me.Controls.Add(Me.lblPriceHeading)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmSeattleWalkingTour"
        Me.Text = "Seattle Walking Tour Tickets"
        CType(Me.picSeattle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblPriceHeading As Label
    Friend WithEvents lblNumberOfTickets As Label
    Friend WithEvents lblTotalCostTxt As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents btnDisplayCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtNumberOfTickets As TextBox
    Friend WithEvents picSeattle As PictureBox
End Class
