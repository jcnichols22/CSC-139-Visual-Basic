<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMostRainfall
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lstRainfall = New System.Windows.Forms.ListBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.lblAverageTotal = New System.Windows.Forms.Label()
        Me.btnEnterRainfall = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstRainfall
        '
        Me.lstRainfall.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRainfall.ForeColor = System.Drawing.Color.Red
        Me.lstRainfall.FormattingEnabled = True
        Me.lstRainfall.ItemHeight = 20
        Me.lstRainfall.Location = New System.Drawing.Point(530, 73)
        Me.lstRainfall.Name = "lstRainfall"
        Me.lstRainfall.Size = New System.Drawing.Size(64, 244)
        Me.lstRainfall.TabIndex = 6
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.Red
        Me.lblHeader.Location = New System.Drawing.Point(60, 73)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(425, 37)
        Me.lblHeader.TabIndex = 7
        Me.lblHeader.Text = "Most Rainfall in US - Kauai"
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverage.ForeColor = System.Drawing.Color.Blue
        Me.lblAverage.Location = New System.Drawing.Point(199, 122)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(146, 24)
        Me.lblAverage.TabIndex = 8
        Me.lblAverage.Text = "Rainfall Average"
        '
        'lblAverageTotal
        '
        Me.lblAverageTotal.AutoSize = True
        Me.lblAverageTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageTotal.ForeColor = System.Drawing.Color.Red
        Me.lblAverageTotal.Location = New System.Drawing.Point(73, 264)
        Me.lblAverageTotal.Name = "lblAverageTotal"
        Me.lblAverageTotal.Size = New System.Drawing.Size(398, 24)
        Me.lblAverageTotal.TabIndex = 10
        Me.lblAverageTotal.Text = "Average Rainfall per Mopnth is 8.0 inches"
        '
        'btnEnterRainfall
        '
        Me.btnEnterRainfall.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnEnterRainfall.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnterRainfall.Location = New System.Drawing.Point(188, 178)
        Me.btnEnterRainfall.Name = "btnEnterRainfall"
        Me.btnEnterRainfall.Size = New System.Drawing.Size(169, 35)
        Me.btnEnterRainfall.TabIndex = 9
        Me.btnEnterRainfall.Text = "Enter Rainfall"
        Me.btnEnterRainfall.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(657, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClear, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(180, 22)
        Me.mnuClear.Text = "&Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(180, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'frmMostRainfall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Most_Rainfal_in_the_USA1.My.Resources.Resources.hawaii
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(657, 519)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblAverageTotal)
        Me.Controls.Add(Me.btnEnterRainfall)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.lstRainfall)
        Me.Name = "frmMostRainfall"
        Me.Text = "Most Rainfall in US"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstRainfall As ListBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblAverage As Label
    Friend WithEvents lblAverageTotal As Label
    Friend WithEvents btnEnterRainfall As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
End Class
