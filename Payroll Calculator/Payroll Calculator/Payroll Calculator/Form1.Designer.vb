<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayrollCalculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayrollCalculator))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblGrossPay = New System.Windows.Forms.Label()
        Me.txtGrossWeekly = New System.Windows.Forms.TextBox()
        Me.lblFicaTax = New System.Windows.Forms.Label()
        Me.lblFederalTax = New System.Windows.Forms.Label()
        Me.lblStateTax = New System.Windows.Forms.Label()
        Me.lblNetPay = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblFicaTotal = New System.Windows.Forms.Label()
        Me.lblFederalTotal = New System.Windows.Forms.Label()
        Me.lblStateTotal = New System.Windows.Forms.Label()
        Me.lblNetPayTotal = New System.Windows.Forms.Label()
        Me.picDollarSign = New System.Windows.Forms.PictureBox()
        CType(Me.picDollarSign, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(236, 23)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(328, 42)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Payroll Calculator"
        '
        'lblGrossPay
        '
        Me.lblGrossPay.AutoSize = True
        Me.lblGrossPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrossPay.Location = New System.Drawing.Point(215, 112)
        Me.lblGrossPay.Name = "lblGrossPay"
        Me.lblGrossPay.Size = New System.Drawing.Size(229, 20)
        Me.lblGrossPay.TabIndex = 1
        Me.lblGrossPay.Text = "Enter Gross Bi-Weekly Pay:"
        '
        'txtGrossWeekly
        '
        Me.txtGrossWeekly.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrossWeekly.Location = New System.Drawing.Point(485, 109)
        Me.txtGrossWeekly.Name = "txtGrossWeekly"
        Me.txtGrossWeekly.Size = New System.Drawing.Size(100, 26)
        Me.txtGrossWeekly.TabIndex = 2
        Me.txtGrossWeekly.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFicaTax
        '
        Me.lblFicaTax.AutoSize = True
        Me.lblFicaTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFicaTax.Location = New System.Drawing.Point(263, 156)
        Me.lblFicaTax.Name = "lblFicaTax"
        Me.lblFicaTax.Size = New System.Drawing.Size(133, 20)
        Me.lblFicaTax.TabIndex = 3
        Me.lblFicaTax.Text = "FICA Tax Total:"
        '
        'lblFederalTax
        '
        Me.lblFederalTax.AutoSize = True
        Me.lblFederalTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFederalTax.Location = New System.Drawing.Point(253, 196)
        Me.lblFederalTax.Name = "lblFederalTax"
        Me.lblFederalTax.Size = New System.Drawing.Size(153, 20)
        Me.lblFederalTax.TabIndex = 4
        Me.lblFederalTax.Text = "Federal Tax Total:"
        '
        'lblStateTax
        '
        Me.lblStateTax.AutoSize = True
        Me.lblStateTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateTax.Location = New System.Drawing.Point(261, 231)
        Me.lblStateTax.Name = "lblStateTax"
        Me.lblStateTax.Size = New System.Drawing.Size(136, 20)
        Me.lblStateTax.TabIndex = 5
        Me.lblStateTax.Text = "State Tax Total:"
        '
        'lblNetPay
        '
        Me.lblNetPay.AutoSize = True
        Me.lblNetPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetPay.Location = New System.Drawing.Point(269, 271)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(121, 20)
        Me.lblNetPay.TabIndex = 6
        Me.lblNetPay.Text = "Net Pay Total:"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.AliceBlue
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(121, 343)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(132, 35)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.AliceBlue
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(334, 343)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(132, 35)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.AliceBlue
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(547, 343)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(132, 35)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblFicaTotal
        '
        Me.lblFicaTotal.AutoSize = True
        Me.lblFicaTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFicaTotal.Location = New System.Drawing.Point(481, 156)
        Me.lblFicaTotal.Name = "lblFicaTotal"
        Me.lblFicaTotal.Size = New System.Drawing.Size(109, 20)
        Me.lblFicaTotal.TabIndex = 10
        Me.lblFicaTotal.Text = "$100,000.00"
        '
        'lblFederalTotal
        '
        Me.lblFederalTotal.AutoSize = True
        Me.lblFederalTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFederalTotal.Location = New System.Drawing.Point(481, 196)
        Me.lblFederalTotal.Name = "lblFederalTotal"
        Me.lblFederalTotal.Size = New System.Drawing.Size(109, 20)
        Me.lblFederalTotal.TabIndex = 11
        Me.lblFederalTotal.Text = "$100,000.00"
        '
        'lblStateTotal
        '
        Me.lblStateTotal.AutoSize = True
        Me.lblStateTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateTotal.Location = New System.Drawing.Point(481, 231)
        Me.lblStateTotal.Name = "lblStateTotal"
        Me.lblStateTotal.Size = New System.Drawing.Size(109, 20)
        Me.lblStateTotal.TabIndex = 12
        Me.lblStateTotal.Text = "$100,000.00"
        '
        'lblNetPayTotal
        '
        Me.lblNetPayTotal.AutoSize = True
        Me.lblNetPayTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetPayTotal.Location = New System.Drawing.Point(481, 271)
        Me.lblNetPayTotal.Name = "lblNetPayTotal"
        Me.lblNetPayTotal.Size = New System.Drawing.Size(109, 20)
        Me.lblNetPayTotal.TabIndex = 13
        Me.lblNetPayTotal.Text = "$100,000.00"
        '
        'picDollarSign
        '
        Me.picDollarSign.Image = CType(resources.GetObject("picDollarSign.Image"), System.Drawing.Image)
        Me.picDollarSign.Location = New System.Drawing.Point(28, 23)
        Me.picDollarSign.Name = "picDollarSign"
        Me.picDollarSign.Size = New System.Drawing.Size(181, 279)
        Me.picDollarSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDollarSign.TabIndex = 14
        Me.picDollarSign.TabStop = False
        '
        'frmPayrollCalculator
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.picDollarSign)
        Me.Controls.Add(Me.lblNetPayTotal)
        Me.Controls.Add(Me.lblStateTotal)
        Me.Controls.Add(Me.lblFederalTotal)
        Me.Controls.Add(Me.lblFicaTotal)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblNetPay)
        Me.Controls.Add(Me.lblStateTax)
        Me.Controls.Add(Me.lblFederalTax)
        Me.Controls.Add(Me.lblFicaTax)
        Me.Controls.Add(Me.txtGrossWeekly)
        Me.Controls.Add(Me.lblGrossPay)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmPayrollCalculator"
        Me.Text = "Payroll Calculator"
        CType(Me.picDollarSign, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblGrossPay As Label
    Friend WithEvents txtGrossWeekly As TextBox
    Friend WithEvents lblFicaTax As Label
    Friend WithEvents lblFederalTax As Label
    Friend WithEvents lblStateTax As Label
    Friend WithEvents lblNetPay As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblFicaTotal As Label
    Friend WithEvents lblFederalTotal As Label
    Friend WithEvents lblStateTotal As Label
    Friend WithEvents lblNetPayTotal As Label
    Friend WithEvents picDollarSign As PictureBox
End Class
