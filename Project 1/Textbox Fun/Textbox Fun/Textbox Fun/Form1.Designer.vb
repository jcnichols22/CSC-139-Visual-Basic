<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtTop = New System.Windows.Forms.TextBox()
        Me.txtBottom = New System.Windows.Forms.TextBox()
        Me.btnAddAnA = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTop
        '
        Me.txtTop.Location = New System.Drawing.Point(230, 61)
        Me.txtTop.Name = "txtTop"
        Me.txtTop.Size = New System.Drawing.Size(100, 20)
        Me.txtTop.TabIndex = 0
        '
        'txtBottom
        '
        Me.txtBottom.Location = New System.Drawing.Point(230, 120)
        Me.txtBottom.Name = "txtBottom"
        Me.txtBottom.Size = New System.Drawing.Size(100, 20)
        Me.txtBottom.TabIndex = 1
        '
        'btnAddAnA
        '
        Me.btnAddAnA.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAnA.Location = New System.Drawing.Point(283, 237)
        Me.btnAddAnA.Name = "btnAddAnA"
        Me.btnAddAnA.Size = New System.Drawing.Size(142, 65)
        Me.btnAddAnA.TabIndex = 2
        Me.btnAddAnA.Text = "Add an 'A'"
        Me.btnAddAnA.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAddAnA)
        Me.Controls.Add(Me.txtBottom)
        Me.Controls.Add(Me.txtTop)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTop As TextBox
    Friend WithEvents txtBottom As TextBox
    Friend WithEvents btnAddAnA As Button
End Class
