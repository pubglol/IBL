<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnMaths = New System.Windows.Forms.Button
        Me.btnPhysics = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnMaths
        '
        Me.btnMaths.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMaths.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMaths.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.MATH_IMAGE23
        Me.btnMaths.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMaths.Location = New System.Drawing.Point(144, 245)
        Me.btnMaths.Name = "btnMaths"
        Me.btnMaths.Size = New System.Drawing.Size(587, 192)
        Me.btnMaths.TabIndex = 0
        Me.btnMaths.Text = " "
        Me.btnMaths.UseVisualStyleBackColor = True
        '
        'btnPhysics
        '
        Me.btnPhysics.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPhysics.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.physicsce_vector_21208553
        Me.btnPhysics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPhysics.Location = New System.Drawing.Point(144, 32)
        Me.btnPhysics.Name = "btnPhysics"
        Me.btnPhysics.Size = New System.Drawing.Size(587, 185)
        Me.btnPhysics.TabIndex = 0
        Me.btnPhysics.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 471)
        Me.Controls.Add(Me.btnMaths)
        Me.Controls.Add(Me.btnPhysics)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPhysics As System.Windows.Forms.Button
    Friend WithEvents btnMaths As System.Windows.Forms.Button
End Class
