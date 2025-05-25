<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password: "
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(113, 38)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(136, 20)
        Me.txtName.TabIndex = 2
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(113, 80)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(136, 20)
        Me.txtPass.TabIndex = 3
        Me.txtPass.UseSystemPasswordChar = True
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(80, 130)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(117, 45)
        Me.btnEnter.TabIndex = 4
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents btnEnter As System.Windows.Forms.Button
End Class
