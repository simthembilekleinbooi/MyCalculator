<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btncoma = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnaddition = New System.Windows.Forms.Button()
        Me.btnsubstract = New System.Windows.Forms.Button()
        Me.btnmultiply = New System.Windows.Forms.Button()
        Me.btndivision = New System.Windows.Forms.Button()
        Me.btnequal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(12, 30)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(322, 79)
        Me.txtDisplay.TabIndex = 0
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(12, 135)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(75, 47)
        Me.btn1.TabIndex = 1
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(93, 135)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(75, 47)
        Me.btn2.TabIndex = 2
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(178, 135)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(75, 47)
        Me.btn3.TabIndex = 3
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(12, 215)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(75, 47)
        Me.btn4.TabIndex = 4
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.Location = New System.Drawing.Point(93, 215)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(75, 47)
        Me.btn5.TabIndex = 5
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.Location = New System.Drawing.Point(174, 215)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(75, 47)
        Me.btn6.TabIndex = 6
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.Location = New System.Drawing.Point(12, 299)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(75, 47)
        Me.btn7.TabIndex = 7
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.Location = New System.Drawing.Point(93, 299)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(75, 47)
        Me.btn8.TabIndex = 8
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.Location = New System.Drawing.Point(174, 299)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(75, 47)
        Me.btn9.TabIndex = 9
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.Location = New System.Drawing.Point(12, 379)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(75, 47)
        Me.btn0.TabIndex = 10
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btncoma
        '
        Me.btncoma.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncoma.Location = New System.Drawing.Point(93, 379)
        Me.btncoma.Name = "btncoma"
        Me.btncoma.Size = New System.Drawing.Size(75, 47)
        Me.btncoma.TabIndex = 11
        Me.btncoma.Text = "."
        Me.btncoma.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(174, 379)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 47)
        Me.btncancel.TabIndex = 12
        Me.btncancel.Text = "c"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnaddition
        '
        Me.btnaddition.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddition.Location = New System.Drawing.Point(259, 135)
        Me.btnaddition.Name = "btnaddition"
        Me.btnaddition.Size = New System.Drawing.Size(75, 47)
        Me.btnaddition.TabIndex = 13
        Me.btnaddition.Text = "+"
        Me.btnaddition.UseVisualStyleBackColor = True
        '
        'btnsubstract
        '
        Me.btnsubstract.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsubstract.Location = New System.Drawing.Point(255, 215)
        Me.btnsubstract.Name = "btnsubstract"
        Me.btnsubstract.Size = New System.Drawing.Size(75, 47)
        Me.btnsubstract.TabIndex = 14
        Me.btnsubstract.Text = "-"
        Me.btnsubstract.UseVisualStyleBackColor = True
        '
        'btnmultiply
        '
        Me.btnmultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmultiply.Location = New System.Drawing.Point(259, 299)
        Me.btnmultiply.Name = "btnmultiply"
        Me.btnmultiply.Size = New System.Drawing.Size(75, 47)
        Me.btnmultiply.TabIndex = 15
        Me.btnmultiply.Text = "*"
        Me.btnmultiply.UseVisualStyleBackColor = True
        '
        'btndivision
        '
        Me.btndivision.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndivision.Location = New System.Drawing.Point(259, 379)
        Me.btndivision.Name = "btndivision"
        Me.btndivision.Size = New System.Drawing.Size(75, 47)
        Me.btndivision.TabIndex = 16
        Me.btndivision.Text = "/"
        Me.btndivision.UseVisualStyleBackColor = True
        '
        'btnequal
        '
        Me.btnequal.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnequal.Location = New System.Drawing.Point(12, 449)
        Me.btnequal.Name = "btnequal"
        Me.btnequal.Size = New System.Drawing.Size(322, 43)
        Me.btnequal.TabIndex = 17
        Me.btnequal.Text = "="
        Me.btnequal.UseVisualStyleBackColor = True
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 515)
        Me.Controls.Add(Me.btnequal)
        Me.Controls.Add(Me.btndivision)
        Me.Controls.Add(Me.btnmultiply)
        Me.Controls.Add(Me.btnsubstract)
        Me.Controls.Add(Me.btnaddition)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btncoma)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.txtDisplay)
        Me.Name = "Calculator"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDisplay As System.Windows.Forms.TextBox
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents btn6 As System.Windows.Forms.Button
    Friend WithEvents btn7 As System.Windows.Forms.Button
    Friend WithEvents btn8 As System.Windows.Forms.Button
    Friend WithEvents btn9 As System.Windows.Forms.Button
    Friend WithEvents btn0 As System.Windows.Forms.Button
    Friend WithEvents btncoma As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnaddition As System.Windows.Forms.Button
    Friend WithEvents btnsubstract As System.Windows.Forms.Button
    Friend WithEvents btnmultiply As System.Windows.Forms.Button
    Friend WithEvents btndivision As System.Windows.Forms.Button
    Friend WithEvents btnequal As System.Windows.Forms.Button

End Class
