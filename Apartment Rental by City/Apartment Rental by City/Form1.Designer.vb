<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbCity = New System.Windows.Forms.ListBox()
        Me.lblRentalCost = New System.Windows.Forms.Label()
        Me.lblRentalAvg = New System.Windows.Forms.Label()
        Me.btnComputeAverage = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TopTenCitiesRentalCostToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pbRentals = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pbRentals, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(380, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Two Bedroom Median Appartment Rentals"
        '
        'lbCity
        '
        Me.lbCity.FormattingEnabled = True
        Me.lbCity.Location = New System.Drawing.Point(219, 55)
        Me.lbCity.Name = "lbCity"
        Me.lbCity.Size = New System.Drawing.Size(128, 147)
        Me.lbCity.TabIndex = 2
        '
        'lblRentalCost
        '
        Me.lblRentalCost.AutoSize = True
        Me.lblRentalCost.Location = New System.Drawing.Point(9, 233)
        Me.lblRentalCost.Name = "lblRentalCost"
        Me.lblRentalCost.Size = New System.Drawing.Size(39, 13)
        Me.lblRentalCost.TabIndex = 3
        Me.lblRentalCost.Text = "Label2"
        '
        'lblRentalAvg
        '
        Me.lblRentalAvg.AutoSize = True
        Me.lblRentalAvg.Location = New System.Drawing.Point(9, 300)
        Me.lblRentalAvg.Name = "lblRentalAvg"
        Me.lblRentalAvg.Size = New System.Drawing.Size(39, 13)
        Me.lblRentalAvg.TabIndex = 4
        Me.lblRentalAvg.Text = "Label3"
        '
        'btnComputeAverage
        '
        Me.btnComputeAverage.Location = New System.Drawing.Point(12, 261)
        Me.btnComputeAverage.Name = "btnComputeAverage"
        Me.btnComputeAverage.Size = New System.Drawing.Size(191, 23)
        Me.btnComputeAverage.TabIndex = 5
        Me.btnComputeAverage.Text = "Compute Average Rental"
        Me.btnComputeAverage.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(350, 261)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(239, 261)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(500, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TopTenCitiesRentalCostToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'TopTenCitiesRentalCostToolStripMenuItem
        '
        Me.TopTenCitiesRentalCostToolStripMenuItem.Name = "TopTenCitiesRentalCostToolStripMenuItem"
        Me.TopTenCitiesRentalCostToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.TopTenCitiesRentalCostToolStripMenuItem.Text = "Top Ten Cities Rental Cost"
        '
        'pbRentals
        '
        Me.pbRentals.Image = Global.Apartment_Rental_by_City.My.Resources.Resources.rental
        Me.pbRentals.Location = New System.Drawing.Point(38, 55)
        Me.pbRentals.Name = "pbRentals"
        Me.pbRentals.Size = New System.Drawing.Size(146, 147)
        Me.pbRentals.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbRentals.TabIndex = 0
        Me.pbRentals.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 344)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnComputeAverage)
        Me.Controls.Add(Me.lblRentalAvg)
        Me.Controls.Add(Me.lblRentalCost)
        Me.Controls.Add(Me.lbCity)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbRentals)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Appartment Rentals by City"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pbRentals, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbRentals As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbCity As ListBox
    Friend WithEvents lblRentalCost As Label
    Friend WithEvents lblRentalAvg As Label
    Friend WithEvents btnComputeAverage As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TopTenCitiesRentalCostToolStripMenuItem As ToolStripMenuItem

End Class
