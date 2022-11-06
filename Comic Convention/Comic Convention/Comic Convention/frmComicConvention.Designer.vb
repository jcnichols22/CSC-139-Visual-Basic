<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComicConvention
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComicConvention))
        Me.picComic = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblGroupSize = New System.Windows.Forms.Label()
        Me.txtGroupSize = New System.Windows.Forms.TextBox()
        Me.grpBadgeType = New System.Windows.Forms.GroupBox()
        Me.radConvention = New System.Windows.Forms.RadioButton()
        Me.radAutographs = New System.Windows.Forms.RadioButton()
        Me.radSuperhero = New System.Windows.Forms.RadioButton()
        Me.lblRegistrationCost = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.picComic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBadgeType.SuspendLayout()
        Me.SuspendLayout()
        '
        'picComic
        '
        Me.picComic.Image = CType(resources.GetObject("picComic.Image"), System.Drawing.Image)
        Me.picComic.Location = New System.Drawing.Point(3, 3)
        Me.picComic.Name = "picComic"
        Me.picComic.Size = New System.Drawing.Size(730, 172)
        Me.picComic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picComic.TabIndex = 0
        Me.picComic.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Red
        Me.lblHeading.Location = New System.Drawing.Point(126, 211)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(484, 45)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Comic Convention Registration"
        '
        'lblGroupSize
        '
        Me.lblGroupSize.AutoSize = True
        Me.lblGroupSize.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupSize.ForeColor = System.Drawing.Color.Red
        Me.lblGroupSize.Location = New System.Drawing.Point(293, 283)
        Me.lblGroupSize.Name = "lblGroupSize"
        Me.lblGroupSize.Size = New System.Drawing.Size(101, 23)
        Me.lblGroupSize.TabIndex = 2
        Me.lblGroupSize.Text = "Group Size:"
        '
        'txtGroupSize
        '
        Me.txtGroupSize.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupSize.ForeColor = System.Drawing.Color.Red
        Me.txtGroupSize.Location = New System.Drawing.Point(400, 277)
        Me.txtGroupSize.Name = "txtGroupSize"
        Me.txtGroupSize.Size = New System.Drawing.Size(44, 34)
        Me.txtGroupSize.TabIndex = 3
        Me.txtGroupSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpBadgeType
        '
        Me.grpBadgeType.BackColor = System.Drawing.Color.SkyBlue
        Me.grpBadgeType.Controls.Add(Me.radConvention)
        Me.grpBadgeType.Controls.Add(Me.radAutographs)
        Me.grpBadgeType.Controls.Add(Me.radSuperhero)
        Me.grpBadgeType.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBadgeType.ForeColor = System.Drawing.Color.Red
        Me.grpBadgeType.Location = New System.Drawing.Point(161, 329)
        Me.grpBadgeType.Name = "grpBadgeType"
        Me.grpBadgeType.Size = New System.Drawing.Size(415, 162)
        Me.grpBadgeType.TabIndex = 4
        Me.grpBadgeType.TabStop = False
        Me.grpBadgeType.Text = "Select Badge Type:"
        '
        'radConvention
        '
        Me.radConvention.AutoSize = True
        Me.radConvention.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radConvention.ForeColor = System.Drawing.Color.Red
        Me.radConvention.Location = New System.Drawing.Point(28, 105)
        Me.radConvention.Name = "radConvention"
        Me.radConvention.Size = New System.Drawing.Size(126, 31)
        Me.radConvention.TabIndex = 2
        Me.radConvention.TabStop = True
        Me.radConvention.Text = "Convention"
        Me.radConvention.UseVisualStyleBackColor = True
        '
        'radAutographs
        '
        Me.radAutographs.AutoSize = True
        Me.radAutographs.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radAutographs.ForeColor = System.Drawing.Color.Red
        Me.radAutographs.Location = New System.Drawing.Point(28, 68)
        Me.radAutographs.Name = "radAutographs"
        Me.radAutographs.Size = New System.Drawing.Size(257, 31)
        Me.radAutographs.TabIndex = 1
        Me.radAutographs.TabStop = True
        Me.radAutographs.Text = "Convention + Autographs"
        Me.radAutographs.UseVisualStyleBackColor = True
        '
        'radSuperhero
        '
        Me.radSuperhero.AutoSize = True
        Me.radSuperhero.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSuperhero.ForeColor = System.Drawing.Color.Red
        Me.radSuperhero.Location = New System.Drawing.Point(28, 32)
        Me.radSuperhero.Name = "radSuperhero"
        Me.radSuperhero.Size = New System.Drawing.Size(356, 31)
        Me.radSuperhero.TabIndex = 0
        Me.radSuperhero.TabStop = True
        Me.radSuperhero.Text = "Convention + Superhero Experience"
        Me.radSuperhero.UseVisualStyleBackColor = True
        '
        'lblRegistrationCost
        '
        Me.lblRegistrationCost.AutoSize = True
        Me.lblRegistrationCost.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistrationCost.ForeColor = System.Drawing.Color.Red
        Me.lblRegistrationCost.Location = New System.Drawing.Point(219, 523)
        Me.lblRegistrationCost.Name = "lblRegistrationCost"
        Me.lblRegistrationCost.Size = New System.Drawing.Size(178, 27)
        Me.lblRegistrationCost.TabIndex = 5
        Me.lblRegistrationCost.Text = "Registration Cost:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Red
        Me.lblTotal.Location = New System.Drawing.Point(405, 523)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(113, 27)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.Text = "$1,254.00"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.SkyBlue
        Me.btnCalculate.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(190, 575)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(124, 41)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.SkyBlue
        Me.btnClear.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(422, 575)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(124, 41)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'frmComicConvention
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(737, 648)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblRegistrationCost)
        Me.Controls.Add(Me.grpBadgeType)
        Me.Controls.Add(Me.txtGroupSize)
        Me.Controls.Add(Me.lblGroupSize)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.picComic)
        Me.Name = "frmComicConvention"
        Me.Text = "Comic Convention Registration"
        CType(Me.picComic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBadgeType.ResumeLayout(False)
        Me.grpBadgeType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picComic As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblGroupSize As Label
    Friend WithEvents txtGroupSize As TextBox
    Friend WithEvents grpBadgeType As GroupBox
    Friend WithEvents radConvention As RadioButton
    Friend WithEvents radAutographs As RadioButton
    Friend WithEvents radSuperhero As RadioButton
    Friend WithEvents lblRegistrationCost As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
End Class
