<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class enrollment_reports
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbStu = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtyear = New System.Windows.Forms.TextBox()
        Me.txtadviser = New System.Windows.Forms.TextBox()
        Me.txtschoolyr = New System.Windows.Forms.TextBox()
        Me.dgvSearch = New System.Windows.Forms.DataGridView()
        Me.subject_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.meeting_schedule = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subject_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Lavender
        Me.Label8.Location = New System.Drawing.Point(81, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 122
        Me.Label8.Text = "Student ID:"
        '
        'cbStu
        '
        Me.cbStu.FormattingEnabled = True
        Me.cbStu.Location = New System.Drawing.Point(170, 81)
        Me.cbStu.Name = "cbStu"
        Me.cbStu.Size = New System.Drawing.Size(121, 21)
        Me.cbStu.TabIndex = 125
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Lavender
        Me.Label1.Location = New System.Drawing.Point(81, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 126
        Me.Label1.Text = "NAME:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Lavender
        Me.Label2.Location = New System.Drawing.Point(641, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 127
        Me.Label2.Text = "SCHOOL YEAR:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Lavender
        Me.Label5.Location = New System.Drawing.Point(549, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 130
        Me.Label5.Text = "ADVICER:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Lavender
        Me.Label6.Location = New System.Drawing.Point(549, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 131
        Me.Label6.Text = "YEAR/SEC:"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(140, 118)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(249, 20)
        Me.txtname.TabIndex = 132
        '
        'txtyear
        '
        Me.txtyear.Location = New System.Drawing.Point(620, 106)
        Me.txtyear.Name = "txtyear"
        Me.txtyear.Size = New System.Drawing.Size(225, 20)
        Me.txtyear.TabIndex = 134
        '
        'txtadviser
        '
        Me.txtadviser.Location = New System.Drawing.Point(620, 139)
        Me.txtadviser.Name = "txtadviser"
        Me.txtadviser.Size = New System.Drawing.Size(225, 20)
        Me.txtadviser.TabIndex = 135
        '
        'txtschoolyr
        '
        Me.txtschoolyr.Location = New System.Drawing.Point(733, 36)
        Me.txtschoolyr.Name = "txtschoolyr"
        Me.txtschoolyr.Size = New System.Drawing.Size(112, 20)
        Me.txtschoolyr.TabIndex = 137
        '
        'dgvSearch
        '
        Me.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.subject_Id, Me.meeting_schedule, Me.subject_name})
        Me.dgvSearch.Location = New System.Drawing.Point(116, 190)
        Me.dgvSearch.Name = "dgvSearch"
        Me.dgvSearch.Size = New System.Drawing.Size(694, 295)
        Me.dgvSearch.TabIndex = 138
        '
        'subject_Id
        '
        Me.subject_Id.HeaderText = "ID"
        Me.subject_Id.Name = "subject_Id"
        Me.subject_Id.Width = 150
        '
        'meeting_schedule
        '
        Me.meeting_schedule.HeaderText = "Schedule"
        Me.meeting_schedule.Name = "meeting_schedule"
        Me.meeting_schedule.Width = 250
        '
        'subject_name
        '
        Me.subject_name.HeaderText = "Subject"
        Me.subject_name.Name = "subject_name"
        Me.subject_name.Width = 250
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(917, 513)
        Me.Panel1.TabIndex = 139
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.cbStu)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtname)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(14, 24)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(891, 476)
        Me.Panel2.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Californian FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 22)
        Me.Label3.TabIndex = 140
        Me.Label3.Text = "ENROLLMENT REPORT"
        '
        'enrollment_reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 512)
        Me.Controls.Add(Me.dgvSearch)
        Me.Controls.Add(Me.txtschoolyr)
        Me.Controls.Add(Me.txtadviser)
        Me.Controls.Add(Me.txtyear)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "enrollment_reports"
        Me.Text = "enrollment_reports"
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbStu As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtyear As System.Windows.Forms.TextBox
    Friend WithEvents txtadviser As System.Windows.Forms.TextBox
    Friend WithEvents txtschoolyr As System.Windows.Forms.TextBox
    Friend WithEvents dgvSearch As System.Windows.Forms.DataGridView
    Friend WithEvents subject_Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents meeting_schedule As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subject_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
