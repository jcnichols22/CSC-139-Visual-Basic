<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInternetSpeedTest
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
        Me.btnInternetSpeed = New System.Windows.Forms.Button()
        Me.lstInternetSpeed = New System.Windows.Forms.ListBox()
        Me.lblAverageSpeed = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.BackColor = System.Drawing.Color.White
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(292, 68)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(427, 37)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Internet Speed Test Survey"
        '
        'btnInternetSpeed
        '
        Me.btnInternetSpeed.BackColor = System.Drawing.Color.Khaki
        Me.btnInternetSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInternetSpeed.Location = New System.Drawing.Point(387, 134)
        Me.btnInternetSpeed.Name = "btnInternetSpeed"
        Me.btnInternetSpeed.Size = New System.Drawing.Size(225, 35)
        Me.btnInternetSpeed.TabIndex = 1
        Me.btnInternetSpeed.Text = "Enter Internet Speed"
        Me.btnInternetSpeed.UseVisualStyleBackColor = False
        '
        'lstInternetSpeed
        '
        Me.lstInternetSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstInternetSpeed.FormattingEnabled = True
        Me.lstInternetSpeed.ItemHeight = 20
        Me.lstInternetSpeed.Location = New System.Drawing.Point(712, 134)
        Me.lstInternetSpeed.Name = "lstInternetSpeed"
        Me.lstInternetSpeed.Size = New System.Drawing.Size(66, 184)
        Me.lstInternetSpeed.TabIndex = 2
        '
        'lblAverageSpeed
        '
        Me.lblAverageSpeed.AutoSize = True
        Me.lblAverageSpeed.BackColor = System.Drawing.Color.White
        Me.lblAverageSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageSpeed.Location = New System.Drawing.Point(466, 393)
        Me.lblAverageSpeed.Name = "lblAverageSpeed"
        Me.lblAverageSpeed.Size = New System.Drawing.Size(302, 20)
        Me.lblAverageSpeed.TabIndex = 3
        Me.lblAverageSpeed.Text = "Average internet Speed: xxx.xx Mbps"
        '
        'frmInternetSpeedTest
        '
        Me.AcceptButton = Me.btnInternetSpeed
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Internet_Speed_Test_Survey.My.Resources.Resources.speed
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(809, 493)
        Me.Controls.Add(Me.lblAverageSpeed)
        Me.Controls.Add(Me.lstInternetSpeed)
        Me.Controls.Add(Me.btnInternetSpeed)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "frmInternetSpeedTest"
        Me.Text = "Internet Speed Test Survey for Home Users"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents btnInternetSpeed As Button
    Friend WithEvents lstInternetSpeed As ListBox
    Friend WithEvents lblAverageSpeed As Label
End Class
