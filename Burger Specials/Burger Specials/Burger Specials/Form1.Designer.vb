<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBurgerSpecials
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
        Me.btnPrimeBeef = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnVeggie = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblChooseMessage = New System.Windows.Forms.Label()
        Me.lblEnjoy = New System.Windows.Forms.Label()
        Me.picVeggie = New System.Windows.Forms.PictureBox()
        Me.picPrimeBeef = New System.Windows.Forms.PictureBox()
        CType(Me.picVeggie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPrimeBeef, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Red
        Me.lblHeading.Location = New System.Drawing.Point(349, 77)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(233, 25)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Farm Burger Specials"
        '
        'btnPrimeBeef
        '
        Me.btnPrimeBeef.BackColor = System.Drawing.Color.Wheat
        Me.btnPrimeBeef.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimeBeef.Location = New System.Drawing.Point(190, 471)
        Me.btnPrimeBeef.Name = "btnPrimeBeef"
        Me.btnPrimeBeef.Size = New System.Drawing.Size(102, 24)
        Me.btnPrimeBeef.TabIndex = 1
        Me.btnPrimeBeef.Text = "Prime Beef"
        Me.btnPrimeBeef.UseVisualStyleBackColor = False
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.Wheat
        Me.btnSelect.Enabled = False
        Me.btnSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.Location = New System.Drawing.Point(414, 471)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(102, 24)
        Me.btnSelect.TabIndex = 2
        Me.btnSelect.Text = "Select Meal"
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'btnVeggie
        '
        Me.btnVeggie.BackColor = System.Drawing.Color.Wheat
        Me.btnVeggie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVeggie.Location = New System.Drawing.Point(625, 471)
        Me.btnVeggie.Name = "btnVeggie"
        Me.btnVeggie.Size = New System.Drawing.Size(102, 24)
        Me.btnVeggie.TabIndex = 3
        Me.btnVeggie.Text = "Veggie"
        Me.btnVeggie.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Wheat
        Me.btnExit.Enabled = False
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(414, 594)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(102, 24)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblChooseMessage
        '
        Me.lblChooseMessage.AutoSize = True
        Me.lblChooseMessage.Location = New System.Drawing.Point(343, 527)
        Me.lblChooseMessage.Name = "lblChooseMessage"
        Me.lblChooseMessage.Size = New System.Drawing.Size(244, 13)
        Me.lblChooseMessage.TabIndex = 5
        Me.lblChooseMessage.Text = "Choose a burger then click the Select Meal button"
        '
        'lblEnjoy
        '
        Me.lblEnjoy.AutoSize = True
        Me.lblEnjoy.Location = New System.Drawing.Point(401, 555)
        Me.lblEnjoy.Name = "lblEnjoy"
        Me.lblEnjoy.Size = New System.Drawing.Size(128, 13)
        Me.lblEnjoy.TabIndex = 8
        Me.lblEnjoy.Text = "Enjoy your burger special!"
        Me.lblEnjoy.Visible = False
        '
        'picVeggie
        '
        Me.picVeggie.Image = Global.Burger_Specials.My.Resources.Resources.veggie
        Me.picVeggie.Location = New System.Drawing.Point(526, 126)
        Me.picVeggie.Name = "picVeggie"
        Me.picVeggie.Size = New System.Drawing.Size(300, 300)
        Me.picVeggie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVeggie.TabIndex = 7
        Me.picVeggie.TabStop = False
        Me.picVeggie.Visible = False
        '
        'picPrimeBeef
        '
        Me.picPrimeBeef.Image = Global.Burger_Specials.My.Resources.Resources.prime
        Me.picPrimeBeef.Location = New System.Drawing.Point(91, 126)
        Me.picPrimeBeef.Name = "picPrimeBeef"
        Me.picPrimeBeef.Size = New System.Drawing.Size(300, 300)
        Me.picPrimeBeef.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPrimeBeef.TabIndex = 6
        Me.picPrimeBeef.TabStop = False
        Me.picPrimeBeef.Visible = False
        '
        'frmBurgerSpecials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(931, 685)
        Me.Controls.Add(Me.lblEnjoy)
        Me.Controls.Add(Me.picVeggie)
        Me.Controls.Add(Me.picPrimeBeef)
        Me.Controls.Add(Me.lblChooseMessage)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnVeggie)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnPrimeBeef)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmBurgerSpecials"
        Me.Text = "Burger Specials"
        CType(Me.picVeggie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPrimeBeef, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents btnPrimeBeef As Button
    Friend WithEvents btnSelect As Button
    Friend WithEvents btnVeggie As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblChooseMessage As Label
    Friend WithEvents picPrimeBeef As PictureBox
    Friend WithEvents picVeggie As PictureBox
    Friend WithEvents lblEnjoy As Label
End Class
