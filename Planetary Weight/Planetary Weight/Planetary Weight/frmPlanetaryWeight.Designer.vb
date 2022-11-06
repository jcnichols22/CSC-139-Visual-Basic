<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlanetaryWeight
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlanetaryWeight))
        Me.picSpace = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblEnterWeight = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.grpConvertWeight = New System.Windows.Forms.GroupBox()
        Me.radMars = New System.Windows.Forms.RadioButton()
        Me.radVenus = New System.Windows.Forms.RadioButton()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblWeightFinal = New System.Windows.Forms.Label()
        CType(Me.picSpace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpConvertWeight.SuspendLayout()
        Me.SuspendLayout()
        '
        'picSpace
        '
        Me.picSpace.Image = CType(resources.GetObject("picSpace.Image"), System.Drawing.Image)
        Me.picSpace.Location = New System.Drawing.Point(1, 4)
        Me.picSpace.Name = "picSpace"
        Me.picSpace.Size = New System.Drawing.Size(353, 446)
        Me.picSpace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSpace.TabIndex = 0
        Me.picSpace.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Goudy Old Style", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(455, 42)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(220, 37)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Venus or Mars?"
        '
        'lblEnterWeight
        '
        Me.lblEnterWeight.AutoSize = True
        Me.lblEnterWeight.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterWeight.Location = New System.Drawing.Point(417, 121)
        Me.lblEnterWeight.Name = "lblEnterWeight"
        Me.lblEnterWeight.Size = New System.Drawing.Size(135, 25)
        Me.lblEnterWeight.TabIndex = 2
        Me.lblEnterWeight.Text = "Enter Weight:"
        '
        'txtWeight
        '
        Me.txtWeight.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.Location = New System.Drawing.Point(587, 113)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(51, 33)
        Me.txtWeight.TabIndex = 3
        Me.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpConvertWeight
        '
        Me.grpConvertWeight.BackColor = System.Drawing.Color.White
        Me.grpConvertWeight.Controls.Add(Me.radMars)
        Me.grpConvertWeight.Controls.Add(Me.radVenus)
        Me.grpConvertWeight.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpConvertWeight.Location = New System.Drawing.Point(420, 178)
        Me.grpConvertWeight.Name = "grpConvertWeight"
        Me.grpConvertWeight.Size = New System.Drawing.Size(290, 123)
        Me.grpConvertWeight.TabIndex = 4
        Me.grpConvertWeight.TabStop = False
        Me.grpConvertWeight.Text = "Convert Weight"
        '
        'radMars
        '
        Me.radMars.AutoSize = True
        Me.radMars.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMars.Location = New System.Drawing.Point(18, 66)
        Me.radMars.Name = "radMars"
        Me.radMars.Size = New System.Drawing.Size(240, 29)
        Me.radMars.TabIndex = 1
        Me.radMars.TabStop = True
        Me.radMars.Text = "Convert to Mars Weight"
        Me.radMars.UseVisualStyleBackColor = True
        '
        'radVenus
        '
        Me.radVenus.AutoSize = True
        Me.radVenus.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radVenus.Location = New System.Drawing.Point(18, 31)
        Me.radVenus.Name = "radVenus"
        Me.radVenus.Size = New System.Drawing.Size(251, 29)
        Me.radVenus.TabIndex = 0
        Me.radVenus.TabStop = True
        Me.radVenus.Text = "Convert to Venus Weight"
        Me.radVenus.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(446, 335)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(97, 43)
        Me.btnDisplay.TabIndex = 5
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(592, 335)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(97, 43)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblWeightFinal
        '
        Me.lblWeightFinal.AutoSize = True
        Me.lblWeightFinal.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeightFinal.Location = New System.Drawing.Point(387, 402)
        Me.lblWeightFinal.Name = "lblWeightFinal"
        Me.lblWeightFinal.Size = New System.Drawing.Size(401, 25)
        Me.lblWeightFinal.TabIndex = 7
        Me.lblWeightFinal.Text = "Your weight on venus is 181.4 lbs or 82.4 kg."
        '
        'frmPlanetaryWeight
        '
        Me.AcceptButton = Me.btnDisplay
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblWeightFinal)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.grpConvertWeight)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.lblEnterWeight)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.picSpace)
        Me.Name = "frmPlanetaryWeight"
        Me.Text = "Planetary Weight"
        CType(Me.picSpace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpConvertWeight.ResumeLayout(False)
        Me.grpConvertWeight.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picSpace As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblEnterWeight As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents grpConvertWeight As GroupBox
    Friend WithEvents radMars As RadioButton
    Friend WithEvents radVenus As RadioButton
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblWeightFinal As Label
End Class
