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
        Me.pbImg = New System.Windows.Forms.PictureBox()
        Me.btn = New System.Windows.Forms.Button()
        CType(Me.pbImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbImg
        '
        Me.pbImg.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pbImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbImg.Location = New System.Drawing.Point(12, 12)
        Me.pbImg.Name = "pbImg"
        Me.pbImg.Size = New System.Drawing.Size(260, 203)
        Me.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImg.TabIndex = 0
        Me.pbImg.TabStop = False
        '
        'btn
        '
        Me.btn.Location = New System.Drawing.Point(12, 221)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(260, 28)
        Me.btn.TabIndex = 1
        Me.btn.Text = "Load Picture"
        Me.btn.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btn)
        Me.Controls.Add(Me.pbImg)
        Me.Name = "Form4"
        Me.Text = "Picture Viewer"
        CType(Me.pbImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbImg As System.Windows.Forms.PictureBox
    Friend WithEvents btn As System.Windows.Forms.Button
End Class
