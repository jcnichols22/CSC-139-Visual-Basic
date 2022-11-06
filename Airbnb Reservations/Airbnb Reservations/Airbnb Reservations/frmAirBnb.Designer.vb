<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAirBnb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAirBnb))
        Me.picPhone = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblPriceHeading = New System.Windows.Forms.Label()
        Me.lblNumofNights = New System.Windows.Forms.Label()
        Me.lblCostOfStay = New System.Windows.Forms.Label()
        Me.btnDisplayCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtNumberOfNights = New System.Windows.Forms.TextBox()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        CType(Me.picPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPhone
        '
        Me.picPhone.Image = CType(resources.GetObject("picPhone.Image"), System.Drawing.Image)
        Me.picPhone.Location = New System.Drawing.Point(12, 12)
        Me.picPhone.Name = "picPhone"
        Me.picPhone.Size = New System.Drawing.Size(358, 426)
        Me.picPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPhone.TabIndex = 0
        Me.picPhone.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Cooper Black", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(384, 24)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(419, 55)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Orlando AirBnB"
        '
        'lblPriceHeading
        '
        Me.lblPriceHeading.AutoSize = True
        Me.lblPriceHeading.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceHeading.Location = New System.Drawing.Point(472, 79)
        Me.lblPriceHeading.Name = "lblPriceHeading"
        Me.lblPriceHeading.Size = New System.Drawing.Size(219, 21)
        Me.lblPriceHeading.TabIndex = 2
        Me.lblPriceHeading.Text = "Only $79.00 per night"
        '
        'lblNumofNights
        '
        Me.lblNumofNights.AutoSize = True
        Me.lblNumofNights.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumofNights.Location = New System.Drawing.Point(429, 163)
        Me.lblNumofNights.Name = "lblNumofNights"
        Me.lblNumofNights.Size = New System.Drawing.Size(179, 24)
        Me.lblNumofNights.TabIndex = 3
        Me.lblNumofNights.Text = "Number of Nights:"
        '
        'lblCostOfStay
        '
        Me.lblCostOfStay.AutoSize = True
        Me.lblCostOfStay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostOfStay.Location = New System.Drawing.Point(429, 220)
        Me.lblCostOfStay.Name = "lblCostOfStay"
        Me.lblCostOfStay.Size = New System.Drawing.Size(125, 24)
        Me.lblCostOfStay.TabIndex = 4
        Me.lblCostOfStay.Text = "Cost of Stay:"
        '
        'btnDisplayCost
        '
        Me.btnDisplayCost.BackColor = System.Drawing.Color.LightGray
        Me.btnDisplayCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayCost.Location = New System.Drawing.Point(388, 334)
        Me.btnDisplayCost.Name = "btnDisplayCost"
        Me.btnDisplayCost.Size = New System.Drawing.Size(134, 35)
        Me.btnDisplayCost.TabIndex = 5
        Me.btnDisplayCost.Text = "Display Cost"
        Me.btnDisplayCost.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightGray
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(528, 334)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(134, 35)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LightGray
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(668, 334)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(134, 35)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtNumberOfNights
        '
        Me.txtNumberOfNights.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfNights.Location = New System.Drawing.Point(638, 158)
        Me.txtNumberOfNights.Name = "txtNumberOfNights"
        Me.txtNumberOfNights.Size = New System.Drawing.Size(35, 29)
        Me.txtNumberOfNights.TabIndex = 8
        Me.txtNumberOfNights.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(609, 220)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(93, 24)
        Me.lblTotalCost.TabIndex = 9
        Me.lblTotalCost.Text = "$0000.00"
        '
        'frmAirBnb
        '
        Me.AcceptButton = Me.btnDisplayCost
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(814, 465)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.txtNumberOfNights)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplayCost)
        Me.Controls.Add(Me.lblCostOfStay)
        Me.Controls.Add(Me.lblNumofNights)
        Me.Controls.Add(Me.lblPriceHeading)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.picPhone)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmAirBnb"
        Me.Text = "AirBnB Reservations"
        CType(Me.picPhone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPhone As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblPriceHeading As Label
    Friend WithEvents lblNumofNights As Label
    Friend WithEvents lblCostOfStay As Label
    Friend WithEvents btnDisplayCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtNumberOfNights As TextBox
    Friend WithEvents lblTotalCost As Label
End Class
