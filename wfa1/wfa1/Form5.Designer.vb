<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.lbl = New System.Windows.Forms.Label()
        Me.btnCommand1 = New System.Windows.Forms.Button()
        Me.btnCommand2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl
        '
        Me.lbl.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Location = New System.Drawing.Point(12, 9)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(260, 145)
        Me.lbl.TabIndex = 1
        Me.lbl.Text = "text 1"
        '
        'btnCommand1
        '
        Me.btnCommand1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommand1.Location = New System.Drawing.Point(17, 157)
        Me.btnCommand1.Name = "btnCommand1"
        Me.btnCommand1.Size = New System.Drawing.Size(255, 43)
        Me.btnCommand1.TabIndex = 2
        Me.btnCommand1.Text = "Change Background Color"
        Me.btnCommand1.UseVisualStyleBackColor = True
        '
        'btnCommand2
        '
        Me.btnCommand2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommand2.Location = New System.Drawing.Point(17, 206)
        Me.btnCommand2.Name = "btnCommand2"
        Me.btnCommand2.Size = New System.Drawing.Size(255, 43)
        Me.btnCommand2.TabIndex = 3
        Me.btnCommand2.Text = "Change Foreground Color"
        Me.btnCommand2.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnCommand2)
        Me.Controls.Add(Me.btnCommand1)
        Me.Controls.Add(Me.lbl)
        Me.Name = "Form5"
        Me.Text = "Text print 4"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents btnCommand1 As System.Windows.Forms.Button
    Friend WithEvents btnCommand2 As System.Windows.Forms.Button
End Class
