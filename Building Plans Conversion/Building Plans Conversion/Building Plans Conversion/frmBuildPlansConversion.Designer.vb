<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuildPlansConversion
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
        Me.lblEnterNumber = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.grpSelection = New System.Windows.Forms.GroupBox()
        Me.radImperialToMetric = New System.Windows.Forms.RadioButton()
        Me.radMetricToImperial = New System.Windows.Forms.RadioButton()
        Me.grpSelection.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(113, 51)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(574, 37)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Convert Between Metric and Imperial"
        '
        'lblEnterNumber
        '
        Me.lblEnterNumber.AutoSize = True
        Me.lblEnterNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterNumber.Location = New System.Drawing.Point(213, 150)
        Me.lblEnterNumber.Name = "lblEnterNumber"
        Me.lblEnterNumber.Size = New System.Drawing.Size(233, 24)
        Me.lblEnterNumber.TabIndex = 1
        Me.lblEnterNumber.Text = "Please Enter a Number:"
        '
        'txtNumber
        '
        Me.txtNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber.Location = New System.Drawing.Point(488, 145)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(100, 29)
        Me.txtNumber.TabIndex = 2
        Me.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(194, 401)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(126, 45)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(459, 401)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(126, 45)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(172, 512)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(434, 24)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = "Your measurement in inches is 65.000 inches"
        '
        'grpSelection
        '
        Me.grpSelection.Controls.Add(Me.radMetricToImperial)
        Me.grpSelection.Controls.Add(Me.radImperialToMetric)
        Me.grpSelection.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSelection.Location = New System.Drawing.Point(217, 193)
        Me.grpSelection.Name = "grpSelection"
        Me.grpSelection.Size = New System.Drawing.Size(371, 187)
        Me.grpSelection.TabIndex = 6
        Me.grpSelection.TabStop = False
        Me.grpSelection.Text = "Measurement Selection"
        '
        'radImperialToMetric
        '
        Me.radImperialToMetric.AutoSize = True
        Me.radImperialToMetric.Location = New System.Drawing.Point(27, 47)
        Me.radImperialToMetric.Name = "radImperialToMetric"
        Me.radImperialToMetric.Size = New System.Drawing.Size(188, 28)
        Me.radImperialToMetric.TabIndex = 0
        Me.radImperialToMetric.TabStop = True
        Me.radImperialToMetric.Text = "Imperial to Metric"
        Me.radImperialToMetric.UseVisualStyleBackColor = True
        '
        'radMetricToImperial
        '
        Me.radMetricToImperial.AutoSize = True
        Me.radMetricToImperial.Location = New System.Drawing.Point(27, 109)
        Me.radMetricToImperial.Name = "radMetricToImperial"
        Me.radMetricToImperial.Size = New System.Drawing.Size(188, 28)
        Me.radMetricToImperial.TabIndex = 1
        Me.radMetricToImperial.TabStop = True
        Me.radMetricToImperial.Text = "Metric to Imperial"
        Me.radMetricToImperial.UseVisualStyleBackColor = True
        '
        'frmBuildPlansConversion
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(800, 563)
        Me.Controls.Add(Me.grpSelection)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.lblEnterNumber)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmBuildPlansConversion"
        Me.Text = "Building Plans Conversion"
        Me.grpSelection.ResumeLayout(False)
        Me.grpSelection.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblEnterNumber As Label
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents grpSelection As GroupBox
    Friend WithEvents radMetricToImperial As RadioButton
    Friend WithEvents radImperialToMetric As RadioButton
End Class
