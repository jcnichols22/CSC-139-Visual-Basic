<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSimpleCalculator
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
        Me.lblOperand1 = New System.Windows.Forms.Label()
        Me.lblOperand2 = New System.Windows.Forms.Label()
        Me.txtOperand1 = New System.Windows.Forms.TextBox()
        Me.txtOperand2 = New System.Windows.Forms.TextBox()
        Me.btnOne = New System.Windows.Forms.Button()
        Me.btnTwo = New System.Windows.Forms.Button()
        Me.btnThree = New System.Windows.Forms.Button()
        Me.btnZero = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDecimal = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnSix = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnFive = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnFour = New System.Windows.Forms.Button()
        Me.btnNine = New System.Windows.Forms.Button()
        Me.btnSeven = New System.Windows.Forms.Button()
        Me.btnEight = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblOperand1
        '
        Me.lblOperand1.AutoSize = True
        Me.lblOperand1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperand1.ForeColor = System.Drawing.Color.White
        Me.lblOperand1.Location = New System.Drawing.Point(43, 46)
        Me.lblOperand1.Name = "lblOperand1"
        Me.lblOperand1.Size = New System.Drawing.Size(127, 24)
        Me.lblOperand1.TabIndex = 0
        Me.lblOperand1.Text = "OPERAND 1"
        '
        'lblOperand2
        '
        Me.lblOperand2.AutoSize = True
        Me.lblOperand2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperand2.ForeColor = System.Drawing.Color.White
        Me.lblOperand2.Location = New System.Drawing.Point(204, 46)
        Me.lblOperand2.Name = "lblOperand2"
        Me.lblOperand2.Size = New System.Drawing.Size(127, 24)
        Me.lblOperand2.TabIndex = 0
        Me.lblOperand2.Text = "OPERAND 2"
        '
        'txtOperand1
        '
        Me.txtOperand1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOperand1.Location = New System.Drawing.Point(45, 92)
        Me.txtOperand1.Name = "txtOperand1"
        Me.txtOperand1.Size = New System.Drawing.Size(123, 29)
        Me.txtOperand1.TabIndex = 1
        Me.txtOperand1.Text = "123456789"
        '
        'txtOperand2
        '
        Me.txtOperand2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOperand2.Location = New System.Drawing.Point(206, 92)
        Me.txtOperand2.Name = "txtOperand2"
        Me.txtOperand2.Size = New System.Drawing.Size(123, 29)
        Me.txtOperand2.TabIndex = 2
        Me.txtOperand2.Text = "123456789"
        '
        'btnOne
        '
        Me.btnOne.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOne.ForeColor = System.Drawing.Color.White
        Me.btnOne.Location = New System.Drawing.Point(46, 204)
        Me.btnOne.Name = "btnOne"
        Me.btnOne.Size = New System.Drawing.Size(66, 43)
        Me.btnOne.TabIndex = 0
        Me.btnOne.Text = "1"
        Me.btnOne.UseVisualStyleBackColor = False
        '
        'btnTwo
        '
        Me.btnTwo.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnTwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTwo.ForeColor = System.Drawing.Color.White
        Me.btnTwo.Location = New System.Drawing.Point(118, 204)
        Me.btnTwo.Name = "btnTwo"
        Me.btnTwo.Size = New System.Drawing.Size(66, 43)
        Me.btnTwo.TabIndex = 0
        Me.btnTwo.Text = "2"
        Me.btnTwo.UseVisualStyleBackColor = False
        '
        'btnThree
        '
        Me.btnThree.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnThree.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThree.ForeColor = System.Drawing.Color.White
        Me.btnThree.Location = New System.Drawing.Point(190, 204)
        Me.btnThree.Name = "btnThree"
        Me.btnThree.Size = New System.Drawing.Size(66, 43)
        Me.btnThree.TabIndex = 0
        Me.btnThree.Text = "3"
        Me.btnThree.UseVisualStyleBackColor = False
        '
        'btnZero
        '
        Me.btnZero.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnZero.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZero.ForeColor = System.Drawing.Color.White
        Me.btnZero.Location = New System.Drawing.Point(118, 351)
        Me.btnZero.Name = "btnZero"
        Me.btnZero.Size = New System.Drawing.Size(66, 43)
        Me.btnZero.TabIndex = 0
        Me.btnZero.Text = "0"
        Me.btnZero.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(154, 400)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(66, 43)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnDecimal
        '
        Me.btnDecimal.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnDecimal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecimal.ForeColor = System.Drawing.Color.White
        Me.btnDecimal.Location = New System.Drawing.Point(190, 351)
        Me.btnDecimal.Name = "btnDecimal"
        Me.btnDecimal.Size = New System.Drawing.Size(66, 43)
        Me.btnDecimal.TabIndex = 0
        Me.btnDecimal.Text = "."
        Me.btnDecimal.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(46, 351)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(66, 43)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "CLR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnMultiply
        '
        Me.btnMultiply.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiply.ForeColor = System.Drawing.Color.White
        Me.btnMultiply.Location = New System.Drawing.Point(262, 302)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(66, 43)
        Me.btnMultiply.TabIndex = 5
        Me.btnMultiply.Text = "x"
        Me.btnMultiply.UseVisualStyleBackColor = False
        '
        'btnSix
        '
        Me.btnSix.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSix.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSix.ForeColor = System.Drawing.Color.White
        Me.btnSix.Location = New System.Drawing.Point(190, 253)
        Me.btnSix.Name = "btnSix"
        Me.btnSix.Size = New System.Drawing.Size(66, 43)
        Me.btnSix.TabIndex = 0
        Me.btnSix.Text = "6"
        Me.btnSix.UseVisualStyleBackColor = False
        '
        'btnMinus
        '
        Me.btnMinus.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinus.ForeColor = System.Drawing.Color.White
        Me.btnMinus.Location = New System.Drawing.Point(262, 253)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(66, 43)
        Me.btnMinus.TabIndex = 4
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = False
        '
        'btnFive
        '
        Me.btnFive.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnFive.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFive.ForeColor = System.Drawing.Color.White
        Me.btnFive.Location = New System.Drawing.Point(118, 253)
        Me.btnFive.Name = "btnFive"
        Me.btnFive.Size = New System.Drawing.Size(66, 43)
        Me.btnFive.TabIndex = 0
        Me.btnFive.Text = "5"
        Me.btnFive.UseVisualStyleBackColor = False
        '
        'btnDivide
        '
        Me.btnDivide.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivide.ForeColor = System.Drawing.Color.White
        Me.btnDivide.Location = New System.Drawing.Point(262, 351)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(66, 43)
        Me.btnDivide.TabIndex = 6
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(262, 204)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(66, 43)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnFour
        '
        Me.btnFour.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnFour.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFour.ForeColor = System.Drawing.Color.White
        Me.btnFour.Location = New System.Drawing.Point(46, 253)
        Me.btnFour.Name = "btnFour"
        Me.btnFour.Size = New System.Drawing.Size(66, 43)
        Me.btnFour.TabIndex = 0
        Me.btnFour.Text = "4"
        Me.btnFour.UseVisualStyleBackColor = False
        '
        'btnNine
        '
        Me.btnNine.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnNine.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNine.ForeColor = System.Drawing.Color.White
        Me.btnNine.Location = New System.Drawing.Point(190, 302)
        Me.btnNine.Name = "btnNine"
        Me.btnNine.Size = New System.Drawing.Size(66, 43)
        Me.btnNine.TabIndex = 0
        Me.btnNine.Text = "9"
        Me.btnNine.UseVisualStyleBackColor = False
        '
        'btnSeven
        '
        Me.btnSeven.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSeven.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeven.ForeColor = System.Drawing.Color.White
        Me.btnSeven.Location = New System.Drawing.Point(46, 302)
        Me.btnSeven.Name = "btnSeven"
        Me.btnSeven.Size = New System.Drawing.Size(66, 43)
        Me.btnSeven.TabIndex = 0
        Me.btnSeven.Text = "7"
        Me.btnSeven.UseVisualStyleBackColor = False
        '
        'btnEight
        '
        Me.btnEight.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnEight.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEight.ForeColor = System.Drawing.Color.White
        Me.btnEight.Location = New System.Drawing.Point(118, 302)
        Me.btnEight.Name = "btnEight"
        Me.btnEight.Size = New System.Drawing.Size(66, 43)
        Me.btnEight.TabIndex = 0
        Me.btnEight.Text = "8"
        Me.btnEight.UseVisualStyleBackColor = False
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.ForeColor = System.Drawing.Color.White
        Me.lblResult.Location = New System.Drawing.Point(54, 150)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(175, 20)
        Me.lblResult.TabIndex = 0
        Me.lblResult.Text = "0000 - 0000 = 00000"
        '
        'frmSimpleCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(374, 474)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnEight)
        Me.Controls.Add(Me.btnSeven)
        Me.Controls.Add(Me.btnNine)
        Me.Controls.Add(Me.btnFour)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnFive)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnSix)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDecimal)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnZero)
        Me.Controls.Add(Me.btnThree)
        Me.Controls.Add(Me.btnTwo)
        Me.Controls.Add(Me.btnOne)
        Me.Controls.Add(Me.txtOperand2)
        Me.Controls.Add(Me.txtOperand1)
        Me.Controls.Add(Me.lblOperand2)
        Me.Controls.Add(Me.lblOperand1)
        Me.Name = "frmSimpleCalculator"
        Me.Text = "Simple Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOperand1 As Label
    Friend WithEvents lblOperand2 As Label
    Friend WithEvents txtOperand1 As TextBox
    Friend WithEvents txtOperand2 As TextBox
    Friend WithEvents btnOne As Button
    Friend WithEvents btnTwo As Button
    Friend WithEvents btnThree As Button
    Friend WithEvents btnZero As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnDecimal As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnSix As Button
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnFive As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnFour As Button
    Friend WithEvents btnNine As Button
    Friend WithEvents btnSeven As Button
    Friend WithEvents btnEight As Button
    Friend WithEvents lblResult As Label
End Class
