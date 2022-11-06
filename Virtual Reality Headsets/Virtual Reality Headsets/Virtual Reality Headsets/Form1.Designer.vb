<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVRForward
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
        Me.btnVRCrown = New System.Windows.Forms.Button()
        Me.btnVREarbud = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picVREarbud = New System.Windows.Forms.PictureBox()
        Me.picVRCrown = New System.Windows.Forms.PictureBox()
        CType(Me.picVREarbud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVRCrown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.DarkGray
        Me.lblHeading.Location = New System.Drawing.Point(314, 51)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(205, 39)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "VR Forward"
        '
        'btnVRCrown
        '
        Me.btnVRCrown.Location = New System.Drawing.Point(151, 385)
        Me.btnVRCrown.Name = "btnVRCrown"
        Me.btnVRCrown.Size = New System.Drawing.Size(108, 28)
        Me.btnVRCrown.TabIndex = 3
        Me.btnVRCrown.Text = "VR Crown"
        Me.btnVRCrown.UseVisualStyleBackColor = True
        '
        'btnVREarbud
        '
        Me.btnVREarbud.Location = New System.Drawing.Point(557, 385)
        Me.btnVREarbud.Name = "btnVREarbud"
        Me.btnVREarbud.Size = New System.Drawing.Size(108, 28)
        Me.btnVREarbud.TabIndex = 4
        Me.btnVREarbud.Text = "VR Earbud"
        Me.btnVREarbud.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Enabled = False
        Me.btnExit.Location = New System.Drawing.Point(362, 445)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(108, 28)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picVREarbud
        '
        Me.picVREarbud.Image = Global.Virtual_Reality_Headsets.My.Resources.Resources.earbud
        Me.picVREarbud.Location = New System.Drawing.Point(486, 111)
        Me.picVREarbud.Name = "picVREarbud"
        Me.picVREarbud.Size = New System.Drawing.Size(250, 250)
        Me.picVREarbud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVREarbud.TabIndex = 2
        Me.picVREarbud.TabStop = False
        Me.picVREarbud.Visible = False
        '
        'picVRCrown
        '
        Me.picVRCrown.Image = Global.Virtual_Reality_Headsets.My.Resources.Resources.crown
        Me.picVRCrown.Location = New System.Drawing.Point(80, 111)
        Me.picVRCrown.Name = "picVRCrown"
        Me.picVRCrown.Size = New System.Drawing.Size(250, 250)
        Me.picVRCrown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVRCrown.TabIndex = 1
        Me.picVRCrown.TabStop = False
        Me.picVRCrown.Visible = False
        '
        'frmVRForward
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(833, 559)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnVREarbud)
        Me.Controls.Add(Me.btnVRCrown)
        Me.Controls.Add(Me.picVREarbud)
        Me.Controls.Add(Me.picVRCrown)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmVRForward"
        Me.Text = "VR Forward"
        CType(Me.picVREarbud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVRCrown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents picVRCrown As PictureBox
    Friend WithEvents picVREarbud As PictureBox
    Friend WithEvents btnVRCrown As Button
    Friend WithEvents btnVREarbud As Button
    Friend WithEvents btnExit As Button
End Class
