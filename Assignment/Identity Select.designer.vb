<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Identity_Select
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnMember = New System.Windows.Forms.Button()
        Me.btnStaff = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'btnMember
        '
        Me.btnMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMember.Location = New System.Drawing.Point(63, 80)
        Me.btnMember.Name = "btnMember"
        Me.btnMember.Size = New System.Drawing.Size(224, 55)
        Me.btnMember.TabIndex = 0
        Me.btnMember.Text = "MEMBER"
        Me.ToolTip1.SetToolTip(Me.btnMember, "Member Identity")
        Me.btnMember.UseVisualStyleBackColor = True
        '
        'btnStaff
        '
        Me.btnStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaff.Location = New System.Drawing.Point(63, 215)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(224, 55)
        Me.btnStaff.TabIndex = 1
        Me.btnStaff.Text = "STAFF"
        Me.ToolTip1.SetToolTip(Me.btnStaff, "Staff Identity")
        Me.btnStaff.UseVisualStyleBackColor = True
        '
        'Identity_Select
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 350)
        Me.Controls.Add(Me.btnStaff)
        Me.Controls.Add(Me.btnMember)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Identity_Select"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Identity Select Form"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMember As Button
    Friend WithEvents btnStaff As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
