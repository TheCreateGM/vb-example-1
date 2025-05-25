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
        Me.btnHeight = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.osShape = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.SuspendLayout()
        '
        'btnHeight
        '
        Me.btnHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHeight.Location = New System.Drawing.Point(12, 35)
        Me.btnHeight.Name = "btnHeight"
        Me.btnHeight.Size = New System.Drawing.Size(149, 44)
        Me.btnHeight.TabIndex = 0
        Me.btnHeight.Text = "Change Height"
        Me.btnHeight.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(12, 160)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(149, 44)
        Me.btnCalc.TabIndex = 1
        Me.btnCalc.Text = "Calculate Area"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.osShape})
        Me.ShapeContainer1.Size = New System.Drawing.Size(440, 261)
        Me.ShapeContainer1.TabIndex = 2
        Me.ShapeContainer1.TabStop = False
        '
        'osShape
        '
        Me.osShape.BackColor = System.Drawing.SystemColors.Control
        Me.osShape.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.osShape.FillColor = System.Drawing.SystemColors.MenuHighlight
        Me.osShape.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.osShape.Location = New System.Drawing.Point(254, 70)
        Me.osShape.Name = "osShape"
        Me.osShape.Size = New System.Drawing.Size(100, 100)
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 261)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnHeight)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Form3"
        Me.Text = "Resizing and Calculate Area"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnHeight As System.Windows.Forms.Button
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents osShape As Microsoft.VisualBasic.PowerPacks.OvalShape
End Class
