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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Counter : "
        '
        'lblDisplay
        '
        Me.lblDisplay.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDisplay.Location = New System.Drawing.Point(96, 9)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(176, 20)
        Me.lblDisplay.TabIndex = 1
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(16, 48)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(256, 35)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "Start Counting"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.Location = New System.Drawing.Point(16, 99)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(256, 35)
        Me.btnStop.TabIndex = 3
        Me.btnStop.Text = "Stop Counting"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 154)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Counter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDisplay As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button

End Class
