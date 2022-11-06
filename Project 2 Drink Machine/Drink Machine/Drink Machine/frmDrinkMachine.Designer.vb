<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDrinkMachine
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
        Me.btnNickel = New System.Windows.Forms.Button()
        Me.btnDime = New System.Windows.Forms.Button()
        Me.btnQuarter = New System.Windows.Forms.Button()
        Me.btnDollar = New System.Windows.Forms.Button()
        Me.lblDrinkPrice = New System.Windows.Forms.Label()
        Me.lblAmountInserted = New System.Windows.Forms.Label()
        Me.lblAmountTotal = New System.Windows.Forms.Label()
        Me.lblChangeTotal = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.picEnjoy = New System.Windows.Forms.PictureBox()
        Me.picVendLogo = New System.Windows.Forms.PictureBox()
        Me.btnDietCoke = New System.Windows.Forms.Button()
        Me.btnDietMtnDew = New System.Windows.Forms.Button()
        Me.btnMtnDew = New System.Windows.Forms.Button()
        Me.btnCoke = New System.Windows.Forms.Button()
        Me.btnDietDrPepper = New System.Windows.Forms.Button()
        Me.btnDrPepper = New System.Windows.Forms.Button()
        Me.lblInsertMore = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picEnjoy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVendLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNickel
        '
        Me.btnNickel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNickel.Location = New System.Drawing.Point(39, 45)
        Me.btnNickel.Name = "btnNickel"
        Me.btnNickel.Size = New System.Drawing.Size(61, 34)
        Me.btnNickel.TabIndex = 0
        Me.btnNickel.Text = "$0.05"
        Me.btnNickel.UseVisualStyleBackColor = True
        '
        'btnDime
        '
        Me.btnDime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDime.Location = New System.Drawing.Point(39, 85)
        Me.btnDime.Name = "btnDime"
        Me.btnDime.Size = New System.Drawing.Size(61, 34)
        Me.btnDime.TabIndex = 1
        Me.btnDime.Text = "$0.10"
        Me.btnDime.UseVisualStyleBackColor = True
        '
        'btnQuarter
        '
        Me.btnQuarter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuarter.Location = New System.Drawing.Point(39, 125)
        Me.btnQuarter.Name = "btnQuarter"
        Me.btnQuarter.Size = New System.Drawing.Size(61, 34)
        Me.btnQuarter.TabIndex = 2
        Me.btnQuarter.Text = "$0.25"
        Me.btnQuarter.UseVisualStyleBackColor = True
        '
        'btnDollar
        '
        Me.btnDollar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDollar.Location = New System.Drawing.Point(39, 165)
        Me.btnDollar.Name = "btnDollar"
        Me.btnDollar.Size = New System.Drawing.Size(61, 34)
        Me.btnDollar.TabIndex = 3
        Me.btnDollar.Text = "$1.00"
        Me.btnDollar.UseVisualStyleBackColor = True
        '
        'lblDrinkPrice
        '
        Me.lblDrinkPrice.AutoSize = True
        Me.lblDrinkPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrinkPrice.Location = New System.Drawing.Point(36, 232)
        Me.lblDrinkPrice.Name = "lblDrinkPrice"
        Me.lblDrinkPrice.Size = New System.Drawing.Size(121, 16)
        Me.lblDrinkPrice.TabIndex = 4
        Me.lblDrinkPrice.Text = "ALL DRINKS: $1.25"
        '
        'lblAmountInserted
        '
        Me.lblAmountInserted.AutoSize = True
        Me.lblAmountInserted.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountInserted.Location = New System.Drawing.Point(287, 231)
        Me.lblAmountInserted.Name = "lblAmountInserted"
        Me.lblAmountInserted.Size = New System.Drawing.Size(107, 16)
        Me.lblAmountInserted.TabIndex = 5
        Me.lblAmountInserted.Text = "Amount Inserted:"
        '
        'lblAmountTotal
        '
        Me.lblAmountTotal.AutoSize = True
        Me.lblAmountTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountTotal.Location = New System.Drawing.Point(400, 231)
        Me.lblAmountTotal.Name = "lblAmountTotal"
        Me.lblAmountTotal.Size = New System.Drawing.Size(39, 16)
        Me.lblAmountTotal.TabIndex = 6
        Me.lblAmountTotal.Text = "$0.00"
        '
        'lblChangeTotal
        '
        Me.lblChangeTotal.AutoSize = True
        Me.lblChangeTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangeTotal.Location = New System.Drawing.Point(400, 539)
        Me.lblChangeTotal.Name = "lblChangeTotal"
        Me.lblChangeTotal.Size = New System.Drawing.Size(39, 16)
        Me.lblChangeTotal.TabIndex = 8
        Me.lblChangeTotal.Text = "$0.00"
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(336, 539)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(58, 16)
        Me.lblChange.TabIndex = 7
        Me.lblChange.Text = "Change:"
        '
        'picEnjoy
        '
        Me.picEnjoy.BackgroundImage = Global.Drink_Machine.My.Resources.Resources._360_F_241372790_IaK4wwYRK0oOOOpX1m1sMnwHMyq7r1Z0
        Me.picEnjoy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picEnjoy.Location = New System.Drawing.Point(95, 568)
        Me.picEnjoy.Name = "picEnjoy"
        Me.picEnjoy.Size = New System.Drawing.Size(288, 130)
        Me.picEnjoy.TabIndex = 16
        Me.picEnjoy.TabStop = False
        Me.picEnjoy.Visible = False
        '
        'picVendLogo
        '
        Me.picVendLogo.BackgroundImage = Global.Drink_Machine.My.Resources.Resources.attachment_108654470
        Me.picVendLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picVendLogo.Location = New System.Drawing.Point(143, 30)
        Me.picVendLogo.Name = "picVendLogo"
        Me.picVendLogo.Size = New System.Drawing.Size(315, 183)
        Me.picVendLogo.TabIndex = 15
        Me.picVendLogo.TabStop = False
        '
        'btnDietCoke
        '
        Me.btnDietCoke.BackColor = System.Drawing.Color.Transparent
        Me.btnDietCoke.BackgroundImage = Global.Drink_Machine.My.Resources.Resources._6e7918e2_2615_4cc0_bd0d_7e2dedb292bc_c96162b9bf031cc0cb3ed24e2f76961e
        Me.btnDietCoke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDietCoke.Location = New System.Drawing.Point(318, 392)
        Me.btnDietCoke.Name = "btnDietCoke"
        Me.btnDietCoke.Size = New System.Drawing.Size(121, 135)
        Me.btnDietCoke.TabIndex = 14
        Me.btnDietCoke.UseVisualStyleBackColor = False
        '
        'btnDietMtnDew
        '
        Me.btnDietMtnDew.BackColor = System.Drawing.Color.Transparent
        Me.btnDietMtnDew.BackgroundImage = Global.Drink_Machine.My.Resources.Resources._96bf350a_5293_4fb0_b280_4b99d0cc3736_b6b7824e05568773147099b84e0c19e6
        Me.btnDietMtnDew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDietMtnDew.Location = New System.Drawing.Point(174, 392)
        Me.btnDietMtnDew.Name = "btnDietMtnDew"
        Me.btnDietMtnDew.Size = New System.Drawing.Size(121, 135)
        Me.btnDietMtnDew.TabIndex = 13
        Me.btnDietMtnDew.UseVisualStyleBackColor = False
        '
        'btnMtnDew
        '
        Me.btnMtnDew.BackColor = System.Drawing.Color.Transparent
        Me.btnMtnDew.BackgroundImage = Global.Drink_Machine.My.Resources.Resources._5a214d4c_b0f7_4eb5_b014_4be4ee70a0ec_1_fa15401fb1e92228dc963f0535d4278c
        Me.btnMtnDew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMtnDew.Location = New System.Drawing.Point(174, 251)
        Me.btnMtnDew.Name = "btnMtnDew"
        Me.btnMtnDew.Size = New System.Drawing.Size(121, 135)
        Me.btnMtnDew.TabIndex = 12
        Me.btnMtnDew.UseVisualStyleBackColor = False
        '
        'btnCoke
        '
        Me.btnCoke.BackColor = System.Drawing.Color.Transparent
        Me.btnCoke.BackgroundImage = Global.Drink_Machine.My.Resources.Resources.cb4c9f0b_a402_4b63_afb9_efdbdfd72450_450d53103f6484ee1ab57a6c8e665ea4
        Me.btnCoke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCoke.Location = New System.Drawing.Point(318, 251)
        Me.btnCoke.Name = "btnCoke"
        Me.btnCoke.Size = New System.Drawing.Size(121, 135)
        Me.btnCoke.TabIndex = 11
        Me.btnCoke.UseVisualStyleBackColor = False
        '
        'btnDietDrPepper
        '
        Me.btnDietDrPepper.BackColor = System.Drawing.Color.Transparent
        Me.btnDietDrPepper.BackgroundImage = Global.Drink_Machine.My.Resources.Resources.diet_dr_pepper
        Me.btnDietDrPepper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDietDrPepper.Location = New System.Drawing.Point(36, 392)
        Me.btnDietDrPepper.Name = "btnDietDrPepper"
        Me.btnDietDrPepper.Size = New System.Drawing.Size(121, 135)
        Me.btnDietDrPepper.TabIndex = 10
        Me.btnDietDrPepper.UseVisualStyleBackColor = False
        '
        'btnDrPepper
        '
        Me.btnDrPepper.BackColor = System.Drawing.Color.Transparent
        Me.btnDrPepper.BackgroundImage = Global.Drink_Machine.My.Resources.Resources.Dr_pepper
        Me.btnDrPepper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDrPepper.Location = New System.Drawing.Point(36, 251)
        Me.btnDrPepper.Name = "btnDrPepper"
        Me.btnDrPepper.Size = New System.Drawing.Size(121, 135)
        Me.btnDrPepper.TabIndex = 9
        Me.btnDrPepper.UseVisualStyleBackColor = False
        '
        'lblInsertMore
        '
        Me.lblInsertMore.AutoSize = True
        Me.lblInsertMore.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsertMore.Location = New System.Drawing.Point(47, 588)
        Me.lblInsertMore.Name = "lblInsertMore"
        Me.lblInsertMore.Size = New System.Drawing.Size(378, 37)
        Me.lblInsertMore.TabIndex = 17
        Me.lblInsertMore.Text = "Please insert $xx.xx more"
        Me.lblInsertMore.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(399, 628)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 70)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmDrinkMachine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 710)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblInsertMore)
        Me.Controls.Add(Me.picEnjoy)
        Me.Controls.Add(Me.picVendLogo)
        Me.Controls.Add(Me.btnDietCoke)
        Me.Controls.Add(Me.btnDietMtnDew)
        Me.Controls.Add(Me.btnMtnDew)
        Me.Controls.Add(Me.btnCoke)
        Me.Controls.Add(Me.btnDietDrPepper)
        Me.Controls.Add(Me.btnDrPepper)
        Me.Controls.Add(Me.lblChangeTotal)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.lblAmountTotal)
        Me.Controls.Add(Me.lblAmountInserted)
        Me.Controls.Add(Me.lblDrinkPrice)
        Me.Controls.Add(Me.btnDollar)
        Me.Controls.Add(Me.btnQuarter)
        Me.Controls.Add(Me.btnDime)
        Me.Controls.Add(Me.btnNickel)
        Me.Name = "frmDrinkMachine"
        Me.Text = "Drink Machine"
        CType(Me.picEnjoy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVendLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNickel As Button
    Friend WithEvents btnDime As Button
    Friend WithEvents btnQuarter As Button
    Friend WithEvents btnDollar As Button
    Friend WithEvents lblDrinkPrice As Label
    Friend WithEvents lblAmountInserted As Label
    Friend WithEvents lblAmountTotal As Label
    Friend WithEvents lblChangeTotal As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents btnDrPepper As Button
    Friend WithEvents btnDietDrPepper As Button
    Friend WithEvents btnCoke As Button
    Friend WithEvents btnMtnDew As Button
    Friend WithEvents btnDietMtnDew As Button
    Friend WithEvents btnDietCoke As Button
    Friend WithEvents picVendLogo As PictureBox
    Friend WithEvents picEnjoy As PictureBox
    Friend WithEvents lblInsertMore As Label
    Friend WithEvents btnExit As Button
End Class
