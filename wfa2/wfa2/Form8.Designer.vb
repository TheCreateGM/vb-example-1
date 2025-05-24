<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Me.btnSetColor = New System.Windows.Forms.Button()
        Me.rbRedBg = New System.Windows.Forms.RadioButton()
        Me.rbBlueBg = New System.Windows.Forms.RadioButton()
        Me.rbGreenBg = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'btnSetColor
        '
        Me.btnSetColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetColor.Location = New System.Drawing.Point(158, 12)
        Me.btnSetColor.Name = "btnSetColor"
        Me.btnSetColor.Size = New System.Drawing.Size(114, 72)
        Me.btnSetColor.TabIndex = 3
        Me.btnSetColor.Text = "Select Background Color"
        Me.btnSetColor.UseVisualStyleBackColor = True
        '
        'rbRedBg
        '
        Me.rbRedBg.AutoSize = True
        Me.rbRedBg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRedBg.Location = New System.Drawing.Point(12, 12)
        Me.rbRedBg.Name = "rbRedBg"
        Me.rbRedBg.Size = New System.Drawing.Size(128, 20)
        Me.rbRedBg.TabIndex = 4
        Me.rbRedBg.TabStop = True
        Me.rbRedBg.Text = "Red Background"
        Me.rbRedBg.UseVisualStyleBackColor = True
        '
        'rbBlueBg
        '
        Me.rbBlueBg.AutoSize = True
        Me.rbBlueBg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBlueBg.Location = New System.Drawing.Point(12, 38)
        Me.rbBlueBg.Name = "rbBlueBg"
        Me.rbBlueBg.Size = New System.Drawing.Size(129, 20)
        Me.rbBlueBg.TabIndex = 5
        Me.rbBlueBg.TabStop = True
        Me.rbBlueBg.Text = "Blue Background"
        Me.rbBlueBg.UseVisualStyleBackColor = True
        '
        'rbGreenBg
        '
        Me.rbGreenBg.AutoSize = True
        Me.rbGreenBg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbGreenBg.Location = New System.Drawing.Point(12, 64)
        Me.rbGreenBg.Name = "rbGreenBg"
        Me.rbGreenBg.Size = New System.Drawing.Size(139, 20)
        Me.rbGreenBg.TabIndex = 6
        Me.rbGreenBg.TabStop = True
        Me.rbGreenBg.Text = "Green Background"
        Me.rbGreenBg.UseVisualStyleBackColor = True
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 101)
        Me.Controls.Add(Me.rbGreenBg)
        Me.Controls.Add(Me.rbBlueBg)
        Me.Controls.Add(Me.rbRedBg)
        Me.Controls.Add(Me.btnSetColor)
        Me.Name = "Form8"
        Me.Text = "Set Background Color"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSetColor As System.Windows.Forms.Button
    Friend WithEvents rbRedBg As System.Windows.Forms.RadioButton
    Friend WithEvents rbBlueBg As System.Windows.Forms.RadioButton
    Friend WithEvents rbGreenBg As System.Windows.Forms.RadioButton
End Class
