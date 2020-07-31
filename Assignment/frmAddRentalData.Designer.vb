<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddRentalData
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtCustomerId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCarName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dateBookEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dateBookStart = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.DataSet_Car_Rental = New Assignment.DataSet_Car_Rental()
        Me.TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableTableAdapter = New Assignment.DataSet_Car_RentalTableAdapters.TableTableAdapter()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCarId = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataSet_Car_Rental, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblEmail)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.txtCustomerId)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(218, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 186)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Details"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmail.Location = New System.Drawing.Point(6, 151)
        Me.lblEmail.MinimumSize = New System.Drawing.Size(185, 30)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(185, 30)
        Me.lblEmail.TabIndex = 7
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Location = New System.Drawing.Point(6, 101)
        Me.lblName.MinimumSize = New System.Drawing.Size(185, 30)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(185, 30)
        Me.lblName.TabIndex = 6
        '
        'txtCustomerId
        '
        Me.txtCustomerId.Location = New System.Drawing.Point(6, 48)
        Me.txtCustomerId.MaximumSize = New System.Drawing.Size(1000, 100)
        Me.txtCustomerId.MinimumSize = New System.Drawing.Size(100, 20)
        Me.txtCustomerId.Name = "txtCustomerId"
        Me.txtCustomerId.Size = New System.Drawing.Size(188, 29)
        Me.txtCustomerId.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CustomerID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblCarId)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblStatus)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtCarName)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 186)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Car Details"
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(6, 150)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(188, 29)
        Me.lblStatus.TabIndex = 9
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Status"
        '
        'txtCarName
        '
        Me.txtCarName.Location = New System.Drawing.Point(6, 48)
        Me.txtCarName.MaximumSize = New System.Drawing.Size(1000, 100)
        Me.txtCarName.MinimumSize = New System.Drawing.Size(100, 20)
        Me.txtCarName.Name = "txtCarName"
        Me.txtCarName.Size = New System.Drawing.Size(188, 29)
        Me.txtCarName.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Car Name"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblPrice)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.lblDuration)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.dateBookEnd)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.dateBookStart)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(424, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 215)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Renting Details"
        '
        'lblPrice
        '
        Me.lblPrice.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(6, 181)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(188, 29)
        Me.lblPrice.TabIndex = 15
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 163)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 18)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Price"
        '
        'lblDuration
        '
        Me.lblDuration.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuration.Location = New System.Drawing.Point(6, 129)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(188, 29)
        Me.lblDuration.TabIndex = 10
        Me.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 18)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Duration"
        '
        'dateBookEnd
        '
        Me.dateBookEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateBookEnd.Location = New System.Drawing.Point(6, 90)
        Me.dateBookEnd.Name = "dateBookEnd"
        Me.dateBookEnd.Size = New System.Drawing.Size(177, 18)
        Me.dateBookEnd.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 18)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Book End"
        '
        'dateBookStart
        '
        Me.dateBookStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateBookStart.Location = New System.Drawing.Point(6, 48)
        Me.dateBookStart.Name = "dateBookStart"
        Me.dateBookStart.Size = New System.Drawing.Size(177, 18)
        Me.dateBookStart.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 18)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Book Start"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(640, 123)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(99, 47)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(640, 180)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(99, 47)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'DataSet_Car_Rental
        '
        Me.DataSet_Car_Rental.DataSetName = "DataSet_Car_Rental"
        Me.DataSet_Car_Rental.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableBindingSource
        '
        Me.TableBindingSource.DataMember = "Table"
        Me.TableBindingSource.DataSource = Me.DataSet_Car_Rental
        '
        'TableTableAdapter
        '
        Me.TableTableAdapter.ClearBeforeFill = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 18)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Car ID"
        '
        'lblCarId
        '
        Me.lblCarId.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCarId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCarId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarId.Location = New System.Drawing.Point(6, 101)
        Me.lblCarId.Name = "lblCarId"
        Me.lblCarId.Size = New System.Drawing.Size(188, 29)
        Me.lblCarId.TabIndex = 11
        Me.lblCarId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmAddRentalData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 233)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAddRentalData"
        Me.Text = "\"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataSet_Car_Rental, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCarName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblDuration As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dateBookEnd As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents dateBookStart As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtCustomerId As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet_Car_Rental As DataSet_Car_Rental
    Friend WithEvents TableBindingSource As BindingSource
    Friend WithEvents TableTableAdapter As DataSet_Car_RentalTableAdapters.TableTableAdapter
    Friend WithEvents lblCarId As Label
    Friend WithEvents Label6 As Label
End Class
