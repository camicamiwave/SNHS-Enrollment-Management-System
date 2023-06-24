<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class subject
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cb_studentId = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.seach_bar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvSearch = New System.Windows.Forms.DataGridView()
        Me.subject_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.meeting_schedule = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subject_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txttimeshed = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbftyId = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtsubId = New System.Windows.Forms.TextBox()
        Me.txtsched = New System.Windows.Forms.TextBox()
        Me.txtsubname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_modify = New System.Windows.Forms.Button()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.txteval = New System.Windows.Forms.TextBox()
        Me.txtstarttech = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.cb_studentId)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.seach_bar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dgvSearch)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(1, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(927, 517)
        Me.Panel1.TabIndex = 86
        '
        'cb_studentId
        '
        Me.cb_studentId.FormattingEnabled = True
        Me.cb_studentId.Location = New System.Drawing.Point(59, 8)
        Me.cb_studentId.Name = "cb_studentId"
        Me.cb_studentId.Size = New System.Drawing.Size(121, 21)
        Me.cb_studentId.TabIndex = 101
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "Student:"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnClose.Location = New System.Drawing.Point(839, 472)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(74, 31)
        Me.btnClose.TabIndex = 105
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'seach_bar
        '
        Me.seach_bar.Location = New System.Drawing.Point(611, 14)
        Me.seach_bar.Name = "seach_bar"
        Me.seach_bar.Size = New System.Drawing.Size(302, 20)
        Me.seach_bar.TabIndex = 85
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(561, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Search:"
        '
        'dgvSearch
        '
        Me.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.subject_Id, Me.meeting_schedule, Me.subject_name})
        Me.dgvSearch.Location = New System.Drawing.Point(367, 40)
        Me.dgvSearch.Name = "dgvSearch"
        Me.dgvSearch.Size = New System.Drawing.Size(546, 426)
        Me.dgvSearch.TabIndex = 83
        '
        'subject_Id
        '
        Me.subject_Id.HeaderText = "ID"
        Me.subject_Id.Name = "subject_Id"
        '
        'meeting_schedule
        '
        Me.meeting_schedule.HeaderText = "Schedule"
        Me.meeting_schedule.Name = "meeting_schedule"
        Me.meeting_schedule.Width = 200
        '
        'subject_name
        '
        Me.subject_name.HeaderText = "Subject"
        Me.subject_name.Name = "subject_name"
        Me.subject_name.Width = 205
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Lavender
        Me.Panel2.Controls.Add(Me.txtstarttech)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txttimeshed)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txteval)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.cbftyId)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Controls.Add(Me.txtsubId)
        Me.Panel2.Controls.Add(Me.txtsched)
        Me.Panel2.Controls.Add(Me.txtsubname)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.btn_modify)
        Me.Panel2.Controls.Add(Me.btn_del)
        Me.Panel2.Location = New System.Drawing.Point(9, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(352, 463)
        Me.Panel2.TabIndex = 82
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Lavender
        Me.Label8.Location = New System.Drawing.Point(26, 307)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 105
        Me.Label8.Text = "Start Teaching:"
        '
        'txttimeshed
        '
        Me.txttimeshed.Location = New System.Drawing.Point(29, 284)
        Me.txttimeshed.Name = "txttimeshed"
        Me.txttimeshed.Size = New System.Drawing.Size(288, 20)
        Me.txttimeshed.TabIndex = 104
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Lavender
        Me.Label7.Location = New System.Drawing.Point(26, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 103
        Me.Label7.Text = "Time Schedule:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Lavender
        Me.Label6.Location = New System.Drawing.Point(26, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 101
        Me.Label6.Text = "Evaluation:"
        '
        'cbftyId
        '
        Me.cbftyId.FormattingEnabled = True
        Me.cbftyId.Location = New System.Drawing.Point(29, 195)
        Me.cbftyId.Name = "cbftyId"
        Me.cbftyId.Size = New System.Drawing.Size(288, 21)
        Me.cbftyId.TabIndex = 100
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Lavender
        Me.Label5.Location = New System.Drawing.Point(26, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "Faculty ID:"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnAdd.Location = New System.Drawing.Point(38, 380)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(89, 36)
        Me.btnAdd.TabIndex = 98
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtsubId
        '
        Me.txtsubId.Enabled = False
        Me.txtsubId.Location = New System.Drawing.Point(29, 55)
        Me.txtsubId.Name = "txtsubId"
        Me.txtsubId.ReadOnly = True
        Me.txtsubId.Size = New System.Drawing.Size(288, 20)
        Me.txtsubId.TabIndex = 97
        '
        'txtsched
        '
        Me.txtsched.Location = New System.Drawing.Point(29, 134)
        Me.txtsched.Name = "txtsched"
        Me.txtsched.Size = New System.Drawing.Size(288, 20)
        Me.txtsched.TabIndex = 95
        '
        'txtsubname
        '
        Me.txtsubname.Location = New System.Drawing.Point(29, 95)
        Me.txtsubname.Name = "txtsubname"
        Me.txtsubname.Size = New System.Drawing.Size(288, 20)
        Me.txtsubname.TabIndex = 94
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Lavender
        Me.Label3.Location = New System.Drawing.Point(26, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Subject Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Lavender
        Me.Label2.Location = New System.Drawing.Point(26, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Meeting Date:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Lavender
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label10.Location = New System.Drawing.Point(26, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Subject ID:"
        '
        'btn_modify
        '
        Me.btn_modify.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_modify.Location = New System.Drawing.Point(133, 380)
        Me.btn_modify.Name = "btn_modify"
        Me.btn_modify.Size = New System.Drawing.Size(89, 36)
        Me.btn_modify.TabIndex = 91
        Me.btn_modify.Text = "Modify"
        Me.btn_modify.UseVisualStyleBackColor = False
        '
        'btn_del
        '
        Me.btn_del.BackColor = System.Drawing.Color.Crimson
        Me.btn_del.Location = New System.Drawing.Point(228, 380)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(89, 36)
        Me.btn_del.TabIndex = 57
        Me.btn_del.Text = "Delete"
        Me.btn_del.UseVisualStyleBackColor = False
        '
        'txteval
        '
        Me.txteval.Location = New System.Drawing.Point(29, 245)
        Me.txteval.Name = "txteval"
        Me.txteval.Size = New System.Drawing.Size(288, 20)
        Me.txteval.TabIndex = 102
        '
        'txtstarttech
        '
        Me.txtstarttech.Location = New System.Drawing.Point(29, 324)
        Me.txtstarttech.Name = "txtstarttech"
        Me.txtstarttech.Size = New System.Drawing.Size(288, 20)
        Me.txtstarttech.TabIndex = 107
        '
        'subject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 513)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "subject"
        Me.Text = "subject"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents seach_bar As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvSearch As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtsubId As System.Windows.Forms.TextBox
    Friend WithEvents txtsched As System.Windows.Forms.TextBox
    Friend WithEvents txtsubname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btn_modify As System.Windows.Forms.Button
    Friend WithEvents btn_del As System.Windows.Forms.Button
    Friend WithEvents subject_Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents meeting_schedule As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subject_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents cb_studentId As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txttimeshed As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbftyId As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txteval As System.Windows.Forms.TextBox
    Friend WithEvents txtstarttech As System.Windows.Forms.DateTimePicker
End Class
