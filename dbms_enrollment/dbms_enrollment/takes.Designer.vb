<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class takes
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
        Me.dgvSearch = New System.Windows.Forms.DataGridView()
        Me.subject_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.meeting_schedule = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subject_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.stu_search = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSearch
        '
        Me.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.subject_Id, Me.meeting_schedule, Me.subject_name})
        Me.dgvSearch.Location = New System.Drawing.Point(118, 42)
        Me.dgvSearch.Name = "dgvSearch"
        Me.dgvSearch.Size = New System.Drawing.Size(694, 418)
        Me.dgvSearch.TabIndex = 84
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(116, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "Search:"
        '
        'stu_search
        '
        Me.stu_search.Location = New System.Drawing.Point(166, 16)
        Me.stu_search.Name = "stu_search"
        Me.stu_search.Size = New System.Drawing.Size(212, 20)
        Me.stu_search.TabIndex = 87
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnClose.Location = New System.Drawing.Point(822, 463)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(74, 31)
        Me.btnClose.TabIndex = 105
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'takes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 506)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.stu_search)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvSearch)
        Me.Name = "takes"
        Me.Text = "takes"
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvSearch As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents stu_search As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents subject_Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents meeting_schedule As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subject_name As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
