<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKaraokeMusicNight
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
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.cboKaraokeSelection = New System.Windows.Forms.ComboBox()
        Me.lblRentalType = New System.Windows.Forms.Label()
        Me.txtNumberOfHoursOrSongs = New System.Windows.Forms.TextBox()
        Me.btnTotalCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.lblTotalCost)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnTotalCost)
        Me.Panel1.Controls.Add(Me.txtNumberOfHoursOrSongs)
        Me.Panel1.Controls.Add(Me.lblRentalType)
        Me.Panel1.Controls.Add(Me.cboKaraokeSelection)
        Me.Panel1.Controls.Add(Me.lblHeader)
        Me.Panel1.Location = New System.Drawing.Point(303, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(504, 474)
        Me.Panel1.TabIndex = 0
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(74, 29)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(356, 39)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Karaoke Music Night"
        '
        'cboKaraokeSelection
        '
        Me.cboKaraokeSelection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKaraokeSelection.FormattingEnabled = True
        Me.cboKaraokeSelection.Items.AddRange(New Object() {"Request number of songs ($2.99 per song)", "Hours in private Karaoke Booth ($8.99 per hour)"})
        Me.cboKaraokeSelection.Location = New System.Drawing.Point(43, 89)
        Me.cboKaraokeSelection.Name = "cboKaraokeSelection"
        Me.cboKaraokeSelection.Size = New System.Drawing.Size(418, 28)
        Me.cboKaraokeSelection.TabIndex = 1
        Me.cboKaraokeSelection.Text = "Make a Karaoke Selection"
        '
        'lblRentalType
        '
        Me.lblRentalType.AutoSize = True
        Me.lblRentalType.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRentalType.ForeColor = System.Drawing.Color.White
        Me.lblRentalType.Location = New System.Drawing.Point(46, 179)
        Me.lblRentalType.Name = "lblRentalType"
        Me.lblRentalType.Size = New System.Drawing.Size(413, 24)
        Me.lblRentalType.TabIndex = 2
        Me.lblRentalType.Text = "Please Enter a number of hours to rent the room"
        Me.lblRentalType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblRentalType.Visible = False
        '
        'txtNumberOfHoursOrSongs
        '
        Me.txtNumberOfHoursOrSongs.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfHoursOrSongs.Location = New System.Drawing.Point(232, 230)
        Me.txtNumberOfHoursOrSongs.Name = "txtNumberOfHoursOrSongs"
        Me.txtNumberOfHoursOrSongs.Size = New System.Drawing.Size(41, 29)
        Me.txtNumberOfHoursOrSongs.TabIndex = 3
        Me.txtNumberOfHoursOrSongs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNumberOfHoursOrSongs.Visible = False
        '
        'btnTotalCost
        '
        Me.btnTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotalCost.Location = New System.Drawing.Point(67, 296)
        Me.btnTotalCost.Name = "btnTotalCost"
        Me.btnTotalCost.Size = New System.Drawing.Size(161, 39)
        Me.btnTotalCost.TabIndex = 4
        Me.btnTotalCost.Text = "Total Cost"
        Me.btnTotalCost.UseVisualStyleBackColor = True
        Me.btnTotalCost.Visible = False
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(277, 296)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(161, 39)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = True
        Me.btnClear.Visible = False
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.ForeColor = System.Drawing.Color.White
        Me.lblTotalCost.Location = New System.Drawing.Point(90, 406)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(324, 20)
        Me.lblTotalCost.TabIndex = 6
        Me.lblTotalCost.Text = "Total Cost Of Karaoke Night - $XXX.XX"
        Me.lblTotalCost.Visible = False
        '
        'frmKaraokeMusicNight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Karaoke_Music_Night.My.Resources.Resources.karaoke
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(810, 476)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmKaraokeMusicNight"
        Me.Text = "Karaoke Music"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnTotalCost As Button
    Friend WithEvents txtNumberOfHoursOrSongs As TextBox
    Friend WithEvents lblRentalType As Label
    Friend WithEvents cboKaraokeSelection As ComboBox
    Friend WithEvents lblHeader As Label
End Class
