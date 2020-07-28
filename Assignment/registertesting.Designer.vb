<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class registertesting
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Car_Renting_System_DatabaseDataSet = New Assignment.Car_Renting_System_DatabaseDataSet()
        Me.Staff_Security_informationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Staff_Security_informationTableAdapter = New Assignment.Car_Renting_System_DatabaseDataSetTableAdapters.Staff_Security_informationTableAdapter()
        Me.TableAdapterManager = New Assignment.Car_Renting_System_DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.Car_Renting_System_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Staff_Security_informationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(113, 56)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(113, 98)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(113, 136)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 22)
        Me.TextBox3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "password"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "question"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(113, 175)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 22)
        Me.TextBox4.TabIndex = 6
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(113, 213)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 22)
        Me.TextBox5.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "answer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "privileges"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(138, 273)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Car_Renting_System_DatabaseDataSet
        '
        Me.Car_Renting_System_DatabaseDataSet.DataSetName = "Car_Renting_System_DatabaseDataSet"
        Me.Car_Renting_System_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Staff_Security_informationBindingSource
        '
        Me.Staff_Security_informationBindingSource.DataMember = "Staff_Security_information"
        Me.Staff_Security_informationBindingSource.DataSource = Me.Car_Renting_System_DatabaseDataSet
        '
        'Staff_Security_informationTableAdapter
        '
        Me.Staff_Security_informationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Member_Security_informationTableAdapter = Nothing
        Me.TableAdapterManager.Staff_Security_informationTableAdapter = Me.Staff_Security_informationTableAdapter
        Me.TableAdapterManager.UpdateOrder = Assignment.Car_Renting_System_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(212, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "label6"
        '
        'registertesting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 324)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "registertesting"
        Me.Text = "registertesting"
        CType(Me.Car_Renting_System_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Staff_Security_informationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Car_Renting_System_DatabaseDataSet As Car_Renting_System_DatabaseDataSet
    Friend WithEvents Staff_Security_informationBindingSource As BindingSource
    Friend WithEvents Staff_Security_informationTableAdapter As Car_Renting_System_DatabaseDataSetTableAdapters.Staff_Security_informationTableAdapter
    Friend WithEvents TableAdapterManager As Car_Renting_System_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label6 As Label
End Class
