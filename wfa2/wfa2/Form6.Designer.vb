﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.cbItem = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cbItem
        '
        Me.cbItem.FormattingEnabled = True
        Me.cbItem.Location = New System.Drawing.Point(12, 12)
        Me.cbItem.Name = "cbItem"
        Me.cbItem.Size = New System.Drawing.Size(260, 21)
        Me.cbItem.TabIndex = 0
        Me.cbItem.Text = "Enter the input"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.cbItem)
        Me.Name = "Form6"
        Me.Text = "Combo Box Form"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbItem As System.Windows.Forms.ComboBox
End Class
