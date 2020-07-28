<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Question
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
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnVerify = New System.Windows.Forms.Button()
        Me.lblUserId = New System.Windows.Forms.Label()
        Me.lblIdentity = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Car_Renting_System_DatabaseDataSet = New Assignment.Car_Renting_System_DatabaseDataSet()
        Me.Staff_Security_informationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Staff_Security_informationTableAdapter = New Assignment.Car_Renting_System_DatabaseDataSetTableAdapters.Staff_Security_informationTableAdapter()
        Me.TableAdapterManager = New Assignment.Car_Renting_System_DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Member_Security_informationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Member_Security_informationTableAdapter = New Assignment.Car_Renting_System_DatabaseDataSetTableAdapters.Member_Security_informationTableAdapter()
        CType(Me.Car_Renting_System_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Staff_Security_informationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Member_Security_informationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAnswer
        '
        Me.txtAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.Location = New System.Drawing.Point(12, 172)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(428, 34)
        Me.txtAnswer.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtAnswer, "Please Insert your answer")
        '
        'lblQuestion
        '
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(12, 120)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(428, 42)
        Me.lblQuestion.TabIndex = 2
        Me.lblQuestion.Text = "Question"
        Me.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(0, 0)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(129, 38)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "BACK"
        Me.ToolTip1.SetToolTip(Me.btnBack, "Back")
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnVerify
        '
        Me.btnVerify.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerify.Location = New System.Drawing.Point(134, 226)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(192, 53)
        Me.btnVerify.TabIndex = 4
        Me.btnVerify.Text = "VERIFY"
        Me.ToolTip1.SetToolTip(Me.btnVerify, "Verify")
        Me.btnVerify.UseVisualStyleBackColor = True
        '
        'lblUserId
        '
        Me.lblUserId.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserId.Location = New System.Drawing.Point(16, 58)
        Me.lblUserId.Name = "lblUserId"
        Me.lblUserId.Padding = New System.Windows.Forms.Padding(30, 0, 30, 0)
        Me.lblUserId.Size = New System.Drawing.Size(424, 32)
        Me.lblUserId.TabIndex = 5
        Me.lblUserId.Text = "ID"
        Me.lblUserId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIdentity
        '
        Me.lblIdentity.AutoSize = True
        Me.lblIdentity.Location = New System.Drawing.Point(389, 0)
        Me.lblIdentity.Name = "lblIdentity"
        Me.lblIdentity.Size = New System.Drawing.Size(51, 17)
        Me.lblIdentity.TabIndex = 6
        Me.lblIdentity.Text = "Label3"
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
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "STAFF_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "STAFF_ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PASSWORD"
        Me.DataGridViewTextBoxColumn2.HeaderText = "PASSWORD"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "RECOVER_QUESTION"
        Me.DataGridViewTextBoxColumn3.HeaderText = "RECOVER_QUESTION"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "RECOVER_ANSWER"
        Me.DataGridViewTextBoxColumn4.HeaderText = "RECOVER_ANSWER"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PRIVILEGE"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PRIVILEGE"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
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
        'Question
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 294)
        Me.Controls.Add(Me.lblIdentity)
        Me.Controls.Add(Me.lblUserId)
        Me.Controls.Add(Me.btnVerify)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.txtAnswer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Question"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Answer Question Form"
        CType(Me.Car_Renting_System_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Staff_Security_informationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Member_Security_informationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents lblQuestion As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnVerify As Button
    Friend WithEvents lblUserId As Label
    Friend WithEvents lblIdentity As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Car_Renting_System_DatabaseDataSet As Car_Renting_System_DatabaseDataSet
    Friend WithEvents Staff_Security_informationBindingSource As BindingSource
    Friend WithEvents Staff_Security_informationTableAdapter As Car_Renting_System_DatabaseDataSetTableAdapters.Staff_Security_informationTableAdapter
    Friend WithEvents TableAdapterManager As Car_Renting_System_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Member_Security_informationBindingSource As BindingSource
    Friend WithEvents Member_Security_informationTableAdapter As Car_Renting_System_DatabaseDataSetTableAdapters.Member_Security_informationTableAdapter
End Class
