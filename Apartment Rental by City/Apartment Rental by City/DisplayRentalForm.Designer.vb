<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DisplayRentalForm
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
        Me.lbCityList = New System.Windows.Forms.ListBox()
        Me.lbRentalList = New System.Windows.Forms.ListBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()

        'lbCityList
        Me.lbCityList.FormattingEnabled = True
        Me.lbCityList.Location = New System.Drawing.Point(46, 37)
        Me.lbCityList.Name = "lbCityList"
        Me.lbCityList.Size = New System.Drawing.Size(120, 173)
        Me.lbCityList.TabIndex = 0        '

        'lbRentalList        '

        Me.lbRentalList.FormattingEnabled = True
        Me.lbRentalList.Location = New System.Drawing.Point(195, 37)
        Me.lbRentalList.Name = "lbRentalList"
        Me.lbRentalList.Size = New System.Drawing.Size(120, 173)
        Me.lbRentalList.TabIndex = 1        '

        'btnClose        '

        Me.btnClose.Location = New System.Drawing.Point(85, 237)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(199, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Return to Rental Cities"
        Me.btnClose.UseVisualStyleBackColor = True        '

        'DisplayRentalForm        '

        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 279)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lbRentalList)
        Me.Controls.Add(Me.lbCityList)
        Me.Name = "DisplayRentalForm"
        Me.Text = "DisplayRentalForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbCityList As ListBox

    Friend WithEvents lbRentalList As ListBox

    Friend WithEvents btnClose As Button

End Class
