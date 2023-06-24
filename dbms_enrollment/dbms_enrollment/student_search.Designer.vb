<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class student_search
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
        Me.btn_del = New System.Windows.Forms.Button()
        Me.dgvSearch = New System.Windows.Forms.DataGridView()
        Me.student_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_lname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_mname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_bdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cpnum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.search = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_del
        '
        Me.btn_del.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_del.Location = New System.Drawing.Point(704, 462)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(91, 41)
        Me.btn_del.TabIndex = 11
        Me.btn_del.Text = "Delete"
        Me.btn_del.UseVisualStyleBackColor = False
        '
        'dgvSearch
        '
        Me.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.student_Id, Me.col_fname, Me.col_lname, Me.col_mname, Me.col_gender, Me.col_bdate, Me.col_address, Me.col_cpnum, Me.col_email})
        Me.dgvSearch.Location = New System.Drawing.Point(38, 53)
        Me.dgvSearch.Name = "dgvSearch"
        Me.dgvSearch.Size = New System.Drawing.Size(855, 403)
        Me.dgvSearch.TabIndex = 10
        '
        'student_Id
        '
        Me.student_Id.HeaderText = "Student ID"
        Me.student_Id.Name = "student_Id"
        '
        'col_fname
        '
        Me.col_fname.HeaderText = "Last Name"
        Me.col_fname.Name = "col_fname"
        '
        'col_lname
        '
        Me.col_lname.HeaderText = "First Name"
        Me.col_lname.Name = "col_lname"
        '
        'col_mname
        '
        Me.col_mname.HeaderText = "Middle Name"
        Me.col_mname.Name = "col_mname"
        '
        'col_gender
        '
        Me.col_gender.HeaderText = "Gender"
        Me.col_gender.Name = "col_gender"
        '
        'col_bdate
        '
        Me.col_bdate.HeaderText = "Date of Birth"
        Me.col_bdate.Name = "col_bdate"
        '
        'col_address
        '
        Me.col_address.HeaderText = "Address"
        Me.col_address.Name = "col_address"
        '
        'col_cpnum
        '
        Me.col_cpnum.HeaderText = "Cp Number"
        Me.col_cpnum.Name = "col_cpnum"
        '
        'col_email
        '
        Me.col_email.HeaderText = "Email Address"
        Me.col_email.Name = "col_email"
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(685, 266)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(281, 20)
        Me.txt_search.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Lavender
        Me.Label1.Location = New System.Drawing.Point(34, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Search Student"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.search)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btn_del)
        Me.Panel1.Controls.Add(Me.txt_search)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(927, 514)
        Me.Panel1.TabIndex = 12
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(121, 22)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(172, 20)
        Me.search.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PaleVioletRed
        Me.Button1.Location = New System.Drawing.Point(801, 462)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 41)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'student_search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 515)
        Me.Controls.Add(Me.dgvSearch)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "student_search"
        Me.Text = "student_search"
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_del As System.Windows.Forms.Button
    Friend WithEvents dgvSearch As System.Windows.Forms.DataGridView
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents student_Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_fname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_lname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_mname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_gender As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_bdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_cpnum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents search As System.Windows.Forms.TextBox
End Class
