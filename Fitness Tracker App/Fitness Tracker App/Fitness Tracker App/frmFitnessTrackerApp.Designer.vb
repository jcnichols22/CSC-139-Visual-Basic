<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFitnessTrackerApp
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
        Me.lblCurrentDay = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblCurrentMonth = New System.Windows.Forms.Label()
        Me.lblCurrentDate = New System.Windows.Forms.Label()
        Me.lblBirthYear = New System.Windows.Forms.Label()
        Me.lblBirthDay = New System.Windows.Forms.Label()
        Me.lblBirthMonth = New System.Windows.Forms.Label()
        Me.lblBirthDate = New System.Windows.Forms.Label()
        Me.txtBirthMonth = New System.Windows.Forms.TextBox()
        Me.txtBirthYear = New System.Windows.Forms.TextBox()
        Me.txtBirthDay = New System.Windows.Forms.TextBox()
        Me.txtCurrentMonth = New System.Windows.Forms.TextBox()
        Me.txtCurrentDay = New System.Windows.Forms.TextBox()
        Me.txtCurrentYear = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblHoursHeader = New System.Windows.Forms.Label()
        Me.lblHoursTotal = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(239, 30)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(372, 42)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Fitness Tracker App"
        '
        'lblCurrentDay
        '
        Me.lblCurrentDay.AutoSize = True
        Me.lblCurrentDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentDay.Location = New System.Drawing.Point(598, 249)
        Me.lblCurrentDay.Name = "lblCurrentDay"
        Me.lblCurrentDay.Size = New System.Drawing.Size(28, 15)
        Me.lblCurrentDay.TabIndex = 1
        Me.lblCurrentDay.Text = "Day"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(672, 249)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 15)
        Me.lblYear.TabIndex = 2
        Me.lblYear.Text = "Year"
        '
        'lblCurrentMonth
        '
        Me.lblCurrentMonth.AutoSize = True
        Me.lblCurrentMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentMonth.Location = New System.Drawing.Point(513, 249)
        Me.lblCurrentMonth.Name = "lblCurrentMonth"
        Me.lblCurrentMonth.Size = New System.Drawing.Size(42, 15)
        Me.lblCurrentMonth.TabIndex = 4
        Me.lblCurrentMonth.Text = "Month"
        '
        'lblCurrentDate
        '
        Me.lblCurrentDate.AutoSize = True
        Me.lblCurrentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentDate.Location = New System.Drawing.Point(478, 203)
        Me.lblCurrentDate.Name = "lblCurrentDate"
        Me.lblCurrentDate.Size = New System.Drawing.Size(280, 24)
        Me.lblCurrentDate.TabIndex = 5
        Me.lblCurrentDate.Text = "Please enter the current date"
        '
        'lblBirthYear
        '
        Me.lblBirthYear.AutoSize = True
        Me.lblBirthYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthYear.Location = New System.Drawing.Point(293, 249)
        Me.lblBirthYear.Name = "lblBirthYear"
        Me.lblBirthYear.Size = New System.Drawing.Size(32, 15)
        Me.lblBirthYear.TabIndex = 6
        Me.lblBirthYear.Text = "Year"
        '
        'lblBirthDay
        '
        Me.lblBirthDay.AutoSize = True
        Me.lblBirthDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthDay.Location = New System.Drawing.Point(219, 249)
        Me.lblBirthDay.Name = "lblBirthDay"
        Me.lblBirthDay.Size = New System.Drawing.Size(28, 15)
        Me.lblBirthDay.TabIndex = 7
        Me.lblBirthDay.Text = "Day"
        '
        'lblBirthMonth
        '
        Me.lblBirthMonth.AutoSize = True
        Me.lblBirthMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthMonth.Location = New System.Drawing.Point(134, 249)
        Me.lblBirthMonth.Name = "lblBirthMonth"
        Me.lblBirthMonth.Size = New System.Drawing.Size(42, 15)
        Me.lblBirthMonth.TabIndex = 8
        Me.lblBirthMonth.Text = "Month"
        '
        'lblBirthDate
        '
        Me.lblBirthDate.AutoSize = True
        Me.lblBirthDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthDate.Location = New System.Drawing.Point(93, 203)
        Me.lblBirthDate.Name = "lblBirthDate"
        Me.lblBirthDate.Size = New System.Drawing.Size(290, 24)
        Me.lblBirthDate.TabIndex = 9
        Me.lblBirthDate.Text = "Please enter your date of birth"
        '
        'txtBirthMonth
        '
        Me.txtBirthMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBirthMonth.Location = New System.Drawing.Point(135, 274)
        Me.txtBirthMonth.Name = "txtBirthMonth"
        Me.txtBirthMonth.Size = New System.Drawing.Size(34, 29)
        Me.txtBirthMonth.TabIndex = 10
        Me.txtBirthMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBirthYear
        '
        Me.txtBirthYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBirthYear.Location = New System.Drawing.Point(278, 274)
        Me.txtBirthYear.Name = "txtBirthYear"
        Me.txtBirthYear.Size = New System.Drawing.Size(58, 29)
        Me.txtBirthYear.TabIndex = 12
        Me.txtBirthYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBirthDay
        '
        Me.txtBirthDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBirthDay.Location = New System.Drawing.Point(215, 274)
        Me.txtBirthDay.Name = "txtBirthDay"
        Me.txtBirthDay.Size = New System.Drawing.Size(34, 29)
        Me.txtBirthDay.TabIndex = 11
        Me.txtBirthDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCurrentMonth
        '
        Me.txtCurrentMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentMonth.Location = New System.Drawing.Point(514, 275)
        Me.txtCurrentMonth.Name = "txtCurrentMonth"
        Me.txtCurrentMonth.Size = New System.Drawing.Size(34, 29)
        Me.txtCurrentMonth.TabIndex = 13
        Me.txtCurrentMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCurrentDay
        '
        Me.txtCurrentDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentDay.Location = New System.Drawing.Point(594, 275)
        Me.txtCurrentDay.Name = "txtCurrentDay"
        Me.txtCurrentDay.Size = New System.Drawing.Size(34, 29)
        Me.txtCurrentDay.TabIndex = 14
        Me.txtCurrentDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCurrentYear
        '
        Me.txtCurrentYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentYear.Location = New System.Drawing.Point(657, 275)
        Me.txtCurrentYear.Name = "txtCurrentYear"
        Me.txtCurrentYear.Size = New System.Drawing.Size(58, 29)
        Me.txtCurrentYear.TabIndex = 15
        Me.txtCurrentYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(168, 499)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(119, 37)
        Me.btnCalculate.TabIndex = 16
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(366, 499)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(119, 37)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(564, 499)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(119, 37)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblHoursHeader
        '
        Me.lblHoursHeader.AutoSize = True
        Me.lblHoursHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoursHeader.Location = New System.Drawing.Point(221, 370)
        Me.lblHoursHeader.Name = "lblHoursHeader"
        Me.lblHoursHeader.Size = New System.Drawing.Size(407, 24)
        Me.lblHoursHeader.TabIndex = 19
        Me.lblHoursHeader.Text = "Number of hours exercised in your lifetime"
        '
        'lblHoursTotal
        '
        Me.lblHoursTotal.AutoSize = True
        Me.lblHoursTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoursTotal.Location = New System.Drawing.Point(185, 439)
        Me.lblHoursTotal.Name = "lblHoursTotal"
        Me.lblHoursTotal.Size = New System.Drawing.Size(481, 24)
        Me.lblHoursTotal.TabIndex = 20
        Me.lblHoursTotal.Text = "Name has worked out 111.11 hours in their lifetime"
        Me.lblHoursTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(193, 125)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(238, 24)
        Me.lblName.TabIndex = 21
        Me.lblName.Text = "Please enter your name:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(472, 120)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(185, 29)
        Me.txtName.TabIndex = 22
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmFitnessTrackerApp
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(850, 589)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblHoursTotal)
        Me.Controls.Add(Me.lblHoursHeader)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtCurrentYear)
        Me.Controls.Add(Me.txtCurrentDay)
        Me.Controls.Add(Me.txtCurrentMonth)
        Me.Controls.Add(Me.txtBirthDay)
        Me.Controls.Add(Me.txtBirthYear)
        Me.Controls.Add(Me.txtBirthMonth)
        Me.Controls.Add(Me.lblBirthDate)
        Me.Controls.Add(Me.lblBirthMonth)
        Me.Controls.Add(Me.lblBirthDay)
        Me.Controls.Add(Me.lblBirthYear)
        Me.Controls.Add(Me.lblCurrentDate)
        Me.Controls.Add(Me.lblCurrentMonth)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblCurrentDay)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmFitnessTrackerApp"
        Me.Text = "Fitness Tracker App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblCurrentDay As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblCurrentMonth As Label
    Friend WithEvents lblCurrentDate As Label
    Friend WithEvents lblBirthYear As Label
    Friend WithEvents lblBirthDay As Label
    Friend WithEvents lblBirthMonth As Label
    Friend WithEvents lblBirthDate As Label
    Friend WithEvents txtBirthMonth As TextBox
    Friend WithEvents txtBirthYear As TextBox
    Friend WithEvents txtBirthDay As TextBox
    Friend WithEvents txtCurrentMonth As TextBox
    Friend WithEvents txtCurrentDay As TextBox
    Friend WithEvents txtCurrentYear As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblHoursHeader As Label
    Friend WithEvents lblHoursTotal As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
End Class
