<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class section
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cb_acad = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.seach_bar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvSearch = New System.Windows.Forms.DataGridView()
        Me.section_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.section_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grade_level = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.student_capacity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbassignedsub = New System.Windows.Forms.ComboBox()
        Me.cbftyId = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtsecId = New System.Windows.Forms.TextBox()
        Me.txtstucap = New System.Windows.Forms.TextBox()
        Me.txtgl = New System.Windows.Forms.TextBox()
        Me.txtsecname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_modify = New System.Windows.Forms.Button()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.cb_studentId)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.cb_acad)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.seach_bar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dgvSearch)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(927, 517)
        Me.Panel1.TabIndex = 85
        '
        'cb_studentId
        '
        Me.cb_studentId.FormattingEnabled = True
        Me.cb_studentId.Location = New System.Drawing.Point(80, 56)
        Me.cb_studentId.Name = "cb_studentId"
        Me.cb_studentId.Size = New System.Drawing.Size(121, 21)
        Me.cb_studentId.TabIndex = 113
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 112
        Me.Label7.Text = "Student ID:"
        '
        'cb_acad
        '
        Me.cb_acad.FormattingEnabled = True
        Me.cb_acad.Location = New System.Drawing.Point(100, 10)
        Me.cb_acad.Name = "cb_acad"
        Me.cb_acad.Size = New System.Drawing.Size(121, 21)
        Me.cb_acad.TabIndex = 110
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "Academic Year:"
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
        Me.seach_bar.Location = New System.Drawing.Point(638, 10)
        Me.seach_bar.Name = "seach_bar"
        Me.seach_bar.Size = New System.Drawing.Size(275, 20)
        Me.seach_bar.TabIndex = 85
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(588, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Search:"
        '
        'dgvSearch
        '
        Me.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.section_Id, Me.section_name, Me.grade_level, Me.student_capacity})
        Me.dgvSearch.Location = New System.Drawing.Point(367, 49)
        Me.dgvSearch.Name = "dgvSearch"
        Me.dgvSearch.Size = New System.Drawing.Size(546, 417)
        Me.dgvSearch.TabIndex = 83
        '
        'section_Id
        '
        Me.section_Id.HeaderText = "ID"
        Me.section_Id.Name = "section_Id"
        '
        'section_name
        '
        Me.section_name.HeaderText = "Section"
        Me.section_name.Name = "section_name"
        Me.section_name.Width = 153
        '
        'grade_level
        '
        Me.grade_level.HeaderText = "Level"
        Me.grade_level.Name = "grade_level"
        Me.grade_level.Width = 120
        '
        'student_capacity
        '
        Me.student_capacity.HeaderText = "Student Capacity"
        Me.student_capacity.Name = "student_capacity"
        Me.student_capacity.Width = 130
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Lavender
        Me.Panel2.Controls.Add(Me.cbassignedsub)
        Me.Panel2.Controls.Add(Me.cbftyId)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Controls.Add(Me.txtsecId)
        Me.Panel2.Controls.Add(Me.txtstucap)
        Me.Panel2.Controls.Add(Me.txtgl)
        Me.Panel2.Controls.Add(Me.txtsecname)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.btn_modify)
        Me.Panel2.Controls.Add(Me.btn_del)
        Me.Panel2.Location = New System.Drawing.Point(9, 83)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(352, 420)
        Me.Panel2.TabIndex = 82
        '
        'cbassignedsub
        '
        Me.cbassignedsub.FormattingEnabled = True
        Me.cbassignedsub.Location = New System.Drawing.Point(29, 295)
        Me.cbassignedsub.Name = "cbassignedsub"
        Me.cbassignedsub.Size = New System.Drawing.Size(288, 21)
        Me.cbassignedsub.TabIndex = 115
        '
        'cbftyId
        '
        Me.cbftyId.FormattingEnabled = True
        Me.cbftyId.Location = New System.Drawing.Point(29, 247)
        Me.cbftyId.Name = "cbftyId"
        Me.cbftyId.Size = New System.Drawing.Size(288, 21)
        Me.cbftyId.TabIndex = 114
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Lavender
        Me.Label8.Location = New System.Drawing.Point(26, 279)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 13)
        Me.Label8.TabIndex = 101
        Me.Label8.Text = "Assigned Subject:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Lavender
        Me.Label6.Location = New System.Drawing.Point(26, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 99
        Me.Label6.Text = "Faculty ID"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnAdd.Location = New System.Drawing.Point(38, 347)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(89, 36)
        Me.btnAdd.TabIndex = 98
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtsecId
        '
        Me.txtsecId.Enabled = False
        Me.txtsecId.Location = New System.Drawing.Point(29, 64)
        Me.txtsecId.Name = "txtsecId"
        Me.txtsecId.ReadOnly = True
        Me.txtsecId.Size = New System.Drawing.Size(288, 20)
        Me.txtsecId.TabIndex = 97
        '
        'txtstucap
        '
        Me.txtstucap.Location = New System.Drawing.Point(29, 183)
        Me.txtstucap.Name = "txtstucap"
        Me.txtstucap.Size = New System.Drawing.Size(288, 20)
        Me.txtstucap.TabIndex = 96
        '
        'txtgl
        '
        Me.txtgl.Location = New System.Drawing.Point(29, 143)
        Me.txtgl.Name = "txtgl"
        Me.txtgl.Size = New System.Drawing.Size(288, 20)
        Me.txtgl.TabIndex = 95
        '
        'txtsecname
        '
        Me.txtsecname.Location = New System.Drawing.Point(29, 104)
        Me.txtsecname.Name = "txtsecname"
        Me.txtsecname.Size = New System.Drawing.Size(288, 20)
        Me.txtsecname.TabIndex = 94
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Lavender
        Me.Label4.Location = New System.Drawing.Point(26, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Student Capacity:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Lavender
        Me.Label3.Location = New System.Drawing.Point(26, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Section Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Lavender
        Me.Label2.Location = New System.Drawing.Point(26, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Grade Level:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Lavender
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label10.Location = New System.Drawing.Point(26, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Section ID:"
        '
        'btn_modify
        '
        Me.btn_modify.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_modify.Location = New System.Drawing.Point(133, 347)
        Me.btn_modify.Name = "btn_modify"
        Me.btn_modify.Size = New System.Drawing.Size(89, 36)
        Me.btn_modify.TabIndex = 91
        Me.btn_modify.Text = "Modify"
        Me.btn_modify.UseVisualStyleBackColor = False
        '
        'btn_del
        '
        Me.btn_del.BackColor = System.Drawing.Color.Crimson
        Me.btn_del.Location = New System.Drawing.Point(228, 347)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(89, 36)
        Me.btn_del.TabIndex = 57
        Me.btn_del.Text = "Delete"
        Me.btn_del.UseVisualStyleBackColor = False
        '
        'section
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 511)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "section"
        Me.Text = "section"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvSearch As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_modify As System.Windows.Forms.Button
    Friend WithEvents btn_del As System.Windows.Forms.Button
    Friend WithEvents seach_bar As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtstucap As System.Windows.Forms.TextBox
    Friend WithEvents txtgl As System.Windows.Forms.TextBox
    Friend WithEvents txtsecname As System.Windows.Forms.TextBox
    Friend WithEvents txtsecId As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cb_acad As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbassignedsub As System.Windows.Forms.ComboBox
    Friend WithEvents cbftyId As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents section_Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents section_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grade_level As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents student_capacity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cb_studentId As System.Windows.Forms.ComboBox
End Class
