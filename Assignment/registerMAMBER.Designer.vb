<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class registerMAMBER
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Car_Renting_System_DatabaseDataSet = New Assignment.Car_Renting_System_DatabaseDataSet()
        Me.Member_Security_informationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Member_Security_informationTableAdapter = New Assignment.Car_Renting_System_DatabaseDataSetTableAdapters.Member_Security_informationTableAdapter()
        Me.TableAdapterManager = New Assignment.Car_Renting_System_DatabaseDataSetTableAdapters.TableAdapterManager()
        CType(Me.Car_Renting_System_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Member_Security_informationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(228, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 17)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "label6"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(154, 277)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 17)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "answer"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(129, 179)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 22)
        Me.TextBox4.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "question"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "password"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "ID"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(129, 140)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 22)
        Me.TextBox3.TabIndex = 14
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(129, 102)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 13
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(129, 60)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 12
        '
        'Car_Renting_System_DatabaseDataSet
        '
        Me.Car_Renting_System_DatabaseDataSet.DataSetName = "Car_Renting_System_DatabaseDataSet"
        Me.Car_Renting_System_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Member_Security_informationBindingSource
        '
        Me.Member_Security_informationBindingSource.DataMember = "Member_Security_information"
        Me.Member_Security_informationBindingSource.DataSource = Me.Car_Renting_System_DatabaseDataSet
        '
        'Member_Security_informationTableAdapter
        '
        Me.Member_Security_informationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Member_Security_informationTableAdapter = Me.Member_Security_informationTableAdapter
        Me.TableAdapterManager.Staff_Security_informationTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Assignment.Car_Renting_System_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'registerMAMBER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 324)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "registerMAMBER"
        Me.Text = "registerMAMBER"
        CType(Me.Car_Renting_System_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Member_Security_informationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Car_Renting_System_DatabaseDataSet As Car_Renting_System_DatabaseDataSet
    Friend WithEvents Member_Security_informationBindingSource As BindingSource
    Friend WithEvents Member_Security_informationTableAdapter As Car_Renting_System_DatabaseDataSetTableAdapters.Member_Security_informationTableAdapter
    Friend WithEvents TableAdapterManager As Car_Renting_System_DatabaseDataSetTableAdapters.TableAdapterManager
End Class
