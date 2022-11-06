<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSprinkBreakSpecials
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
        Me.picMyrtleBeach = New System.Windows.Forms.PictureBox()
        Me.picKeyWest = New System.Windows.Forms.PictureBox()
        Me.picVeniceBeach = New System.Windows.Forms.PictureBox()
        Me.btnMyrtleBeach = New System.Windows.Forms.Button()
        Me.btnKeyWest = New System.Windows.Forms.Button()
        Me.btnVeniceBeach = New System.Windows.Forms.Button()
        Me.btnPurchaseTrip = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblEnjoy = New System.Windows.Forms.Label()
        CType(Me.picMyrtleBeach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKeyWest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVeniceBeach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Californian FB", 20.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.DimGray
        Me.lblHeading.Location = New System.Drawing.Point(310, 68)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(339, 31)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Spring Break Travel Specials"
        '
        'picMyrtleBeach
        '
        Me.picMyrtleBeach.Image = Global.Spring_Break_Travel_Specials.My.Resources.Resources.Myrtle_Beach
        Me.picMyrtleBeach.Location = New System.Drawing.Point(29, 132)
        Me.picMyrtleBeach.Name = "picMyrtleBeach"
        Me.picMyrtleBeach.Size = New System.Drawing.Size(250, 250)
        Me.picMyrtleBeach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMyrtleBeach.TabIndex = 1
        Me.picMyrtleBeach.TabStop = False
        Me.picMyrtleBeach.Visible = False
        '
        'picKeyWest
        '
        Me.picKeyWest.Image = Global.Spring_Break_Travel_Specials.My.Resources.Resources.Key_West
        Me.picKeyWest.Location = New System.Drawing.Point(354, 132)
        Me.picKeyWest.Name = "picKeyWest"
        Me.picKeyWest.Size = New System.Drawing.Size(250, 250)
        Me.picKeyWest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picKeyWest.TabIndex = 2
        Me.picKeyWest.TabStop = False
        Me.picKeyWest.Visible = False
        '
        'picVeniceBeach
        '
        Me.picVeniceBeach.Image = Global.Spring_Break_Travel_Specials.My.Resources.Resources.Venice_Beach
        Me.picVeniceBeach.Location = New System.Drawing.Point(679, 132)
        Me.picVeniceBeach.Name = "picVeniceBeach"
        Me.picVeniceBeach.Size = New System.Drawing.Size(250, 250)
        Me.picVeniceBeach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVeniceBeach.TabIndex = 3
        Me.picVeniceBeach.TabStop = False
        Me.picVeniceBeach.Visible = False
        '
        'btnMyrtleBeach
        '
        Me.btnMyrtleBeach.BackColor = System.Drawing.Color.Azure
        Me.btnMyrtleBeach.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMyrtleBeach.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.btnMyrtleBeach.Location = New System.Drawing.Point(101, 420)
        Me.btnMyrtleBeach.Name = "btnMyrtleBeach"
        Me.btnMyrtleBeach.Size = New System.Drawing.Size(107, 30)
        Me.btnMyrtleBeach.TabIndex = 4
        Me.btnMyrtleBeach.Text = "Myrtle Beach"
        Me.btnMyrtleBeach.UseVisualStyleBackColor = False
        '
        'btnKeyWest
        '
        Me.btnKeyWest.BackColor = System.Drawing.Color.Azure
        Me.btnKeyWest.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeyWest.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.btnKeyWest.Location = New System.Drawing.Point(426, 420)
        Me.btnKeyWest.Name = "btnKeyWest"
        Me.btnKeyWest.Size = New System.Drawing.Size(107, 30)
        Me.btnKeyWest.TabIndex = 5
        Me.btnKeyWest.Text = "Key West"
        Me.btnKeyWest.UseVisualStyleBackColor = False
        '
        'btnVeniceBeach
        '
        Me.btnVeniceBeach.BackColor = System.Drawing.Color.Azure
        Me.btnVeniceBeach.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVeniceBeach.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.btnVeniceBeach.Location = New System.Drawing.Point(751, 420)
        Me.btnVeniceBeach.Name = "btnVeniceBeach"
        Me.btnVeniceBeach.Size = New System.Drawing.Size(107, 30)
        Me.btnVeniceBeach.TabIndex = 6
        Me.btnVeniceBeach.Text = "Venice Beach"
        Me.btnVeniceBeach.UseVisualStyleBackColor = False
        '
        'btnPurchaseTrip
        '
        Me.btnPurchaseTrip.BackColor = System.Drawing.Color.Azure
        Me.btnPurchaseTrip.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPurchaseTrip.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.btnPurchaseTrip.Location = New System.Drawing.Point(426, 570)
        Me.btnPurchaseTrip.Name = "btnPurchaseTrip"
        Me.btnPurchaseTrip.Size = New System.Drawing.Size(107, 30)
        Me.btnPurchaseTrip.TabIndex = 7
        Me.btnPurchaseTrip.Text = "Purchase Trip"
        Me.btnPurchaseTrip.UseVisualStyleBackColor = False
        Me.btnPurchaseTrip.Visible = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Azure
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.btnExit.Location = New System.Drawing.Point(426, 570)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(107, 30)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit Program"
        Me.btnExit.UseVisualStyleBackColor = False
        Me.btnExit.Visible = False
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.ForeColor = System.Drawing.Color.DimGray
        Me.lblInstructions.Location = New System.Drawing.Point(323, 474)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(312, 18)
        Me.lblInstructions.TabIndex = 9
        Me.lblInstructions.Text = "Please select from one of the trips above"
        '
        'lblEnjoy
        '
        Me.lblEnjoy.AutoSize = True
        Me.lblEnjoy.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnjoy.ForeColor = System.Drawing.Color.DimGray
        Me.lblEnjoy.Location = New System.Drawing.Point(366, 514)
        Me.lblEnjoy.Name = "lblEnjoy"
        Me.lblEnjoy.Size = New System.Drawing.Size(227, 16)
        Me.lblEnjoy.TabIndex = 10
        Me.lblEnjoy.Text = "Enjoy your spring break vacation!"
        Me.lblEnjoy.Visible = False
        '
        'frmSprinkBreakSpecials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(959, 645)
        Me.Controls.Add(Me.lblEnjoy)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPurchaseTrip)
        Me.Controls.Add(Me.btnVeniceBeach)
        Me.Controls.Add(Me.btnKeyWest)
        Me.Controls.Add(Me.btnMyrtleBeach)
        Me.Controls.Add(Me.picVeniceBeach)
        Me.Controls.Add(Me.picKeyWest)
        Me.Controls.Add(Me.picMyrtleBeach)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmSprinkBreakSpecials"
        Me.Text = "Spring Break Travel Specials"
        CType(Me.picMyrtleBeach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKeyWest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVeniceBeach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents picMyrtleBeach As PictureBox
    Friend WithEvents picKeyWest As PictureBox
    Friend WithEvents picVeniceBeach As PictureBox
    Friend WithEvents btnMyrtleBeach As Button
    Friend WithEvents btnKeyWest As Button
    Friend WithEvents btnVeniceBeach As Button
    Friend WithEvents btnPurchaseTrip As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblEnjoy As Label
End Class
