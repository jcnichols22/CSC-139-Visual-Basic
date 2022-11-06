<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSoftballScoreboard
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
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.btnEnterScore = New System.Windows.Forms.Button()
        Me.lstScores = New System.Windows.Forms.ListBox()
        Me.lblTotalScore = New System.Windows.Forms.Label()
        Me.lblTotalHeader = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblHeader.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(30, 51)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(333, 39)
        Me.lblHeader.TabIndex = 2
        Me.lblHeader.Text = "Softball Scoreboard"
        '
        'btnEnterScore
        '
        Me.btnEnterScore.BackColor = System.Drawing.Color.Lime
        Me.btnEnterScore.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnterScore.ForeColor = System.Drawing.Color.Red
        Me.btnEnterScore.Location = New System.Drawing.Point(106, 107)
        Me.btnEnterScore.Name = "btnEnterScore"
        Me.btnEnterScore.Size = New System.Drawing.Size(144, 42)
        Me.btnEnterScore.TabIndex = 5
        Me.btnEnterScore.Text = "Enter Score"
        Me.btnEnterScore.UseVisualStyleBackColor = False
        '
        'lstScores
        '
        Me.lstScores.BackColor = System.Drawing.Color.White
        Me.lstScores.FormattingEnabled = True
        Me.lstScores.Location = New System.Drawing.Point(567, 51)
        Me.lstScores.Name = "lstScores"
        Me.lstScores.Size = New System.Drawing.Size(120, 212)
        Me.lstScores.TabIndex = 6
        '
        'lblTotalScore
        '
        Me.lblTotalScore.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalScore.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalScore.ForeColor = System.Drawing.Color.White
        Me.lblTotalScore.Location = New System.Drawing.Point(532, 319)
        Me.lblTotalScore.Name = "lblTotalScore"
        Me.lblTotalScore.Size = New System.Drawing.Size(191, 57)
        Me.lblTotalScore.TabIndex = 105
        Me.lblTotalScore.Text = "0"
        Me.lblTotalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalHeader
        '
        Me.lblTotalHeader.AutoSize = True
        Me.lblTotalHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalHeader.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalHeader.ForeColor = System.Drawing.Color.White
        Me.lblTotalHeader.Location = New System.Drawing.Point(594, 283)
        Me.lblTotalHeader.Name = "lblTotalHeader"
        Me.lblTotalHeader.Size = New System.Drawing.Size(66, 25)
        Me.lblTotalHeader.TabIndex = 104
        Me.lblTotalHeader.Text = "Total"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 106
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
        'frmSoftballScoreboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Softball_Scoreboard.My.Resources.Resources._1d6dcb63_4f67_439d_aaca_7705d6d77078_1140x641
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblTotalScore)
        Me.Controls.Add(Me.lblTotalHeader)
        Me.Controls.Add(Me.lstScores)
        Me.Controls.Add(Me.btnEnterScore)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSoftballScoreboard"
        Me.Text = "Softball Scoreboard"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents btnEnterScore As Button
    Friend WithEvents lstScores As ListBox
    Friend WithEvents lblTotalScore As Label
    Friend WithEvents lblTotalHeader As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
End Class
