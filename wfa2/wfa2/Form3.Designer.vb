<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtShowPass = New System.Windows.Forms.TextBox()
        Me.btnShowPass = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Your Password :"
        '
        'txtShowPass
        '
        Me.txtShowPass.Location = New System.Drawing.Point(175, 10)
        Me.txtShowPass.Name = "txtShowPass"
        Me.txtShowPass.Size = New System.Drawing.Size(169, 20)
        Me.txtShowPass.TabIndex = 1
        Me.txtShowPass.UseSystemPasswordChar = True
        '
        'btnShowPass
        '
        Me.btnShowPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowPass.Location = New System.Drawing.Point(15, 40)
        Me.btnShowPass.Name = "btnShowPass"
        Me.btnShowPass.Size = New System.Drawing.Size(329, 62)
        Me.btnShowPass.TabIndex = 2
        Me.btnShowPass.Text = "Show Password"
        Me.btnShowPass.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 118)
        Me.Controls.Add(Me.btnShowPass)
        Me.Controls.Add(Me.txtShowPass)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Password Cracker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtShowPass As System.Windows.Forms.TextBox
    Friend WithEvents btnShowPass As System.Windows.Forms.Button
End Class
