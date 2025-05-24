<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.cbApple = New System.Windows.Forms.CheckBox()
        Me.cbOrange = New System.Windows.Forms.CheckBox()
        Me.cbPear = New System.Windows.Forms.CheckBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbApple
        '
        Me.cbApple.AutoSize = True
        Me.cbApple.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbApple.Location = New System.Drawing.Point(12, 12)
        Me.cbApple.Name = "cbApple"
        Me.cbApple.Size = New System.Drawing.Size(63, 20)
        Me.cbApple.TabIndex = 0
        Me.cbApple.Text = "Apple"
        Me.cbApple.UseVisualStyleBackColor = True
        '
        'cbOrange
        '
        Me.cbOrange.AutoSize = True
        Me.cbOrange.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOrange.Location = New System.Drawing.Point(12, 38)
        Me.cbOrange.Name = "cbOrange"
        Me.cbOrange.Size = New System.Drawing.Size(72, 20)
        Me.cbOrange.TabIndex = 1
        Me.cbOrange.Text = "Orange"
        Me.cbOrange.UseVisualStyleBackColor = True
        '
        'cbPear
        '
        Me.cbPear.AutoSize = True
        Me.cbPear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPear.Location = New System.Drawing.Point(12, 64)
        Me.cbPear.Name = "cbPear"
        Me.cbPear.Size = New System.Drawing.Size(56, 20)
        Me.cbPear.TabIndex = 2
        Me.cbPear.Text = "Pear"
        Me.cbPear.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(130, 23)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(119, 49)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 105)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.cbPear)
        Me.Controls.Add(Me.cbOrange)
        Me.Controls.Add(Me.cbApple)
        Me.Name = "Form7"
        Me.Text = "Check Box Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbApple As System.Windows.Forms.CheckBox
    Friend WithEvents cbOrange As System.Windows.Forms.CheckBox
    Friend WithEvents cbPear As System.Windows.Forms.CheckBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
End Class
