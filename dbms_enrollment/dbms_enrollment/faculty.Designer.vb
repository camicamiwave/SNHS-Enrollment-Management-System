<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class faculty
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
        Me.txtnumreq = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.datestat = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbReq = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.search_bar = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvSearch = New System.Windows.Forms.DataGridView()
        Me.faculty_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fty_lname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fty_fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fty_mname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.faculty_bdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cpnum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.position = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.datetime = New System.Windows.Forms.Label()
        Me.rbFemale = New System.Windows.Forms.RadioButton()
        Me.bdate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rbMale = New System.Windows.Forms.RadioButton()
        Me.txtcp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtftyId = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtftymname = New System.Windows.Forms.TextBox()
        Me.txtpos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtftyfname = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtftylname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.txtnumreq)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.datestat)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.cbReq)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.search_bar)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.dgvSearch)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(945, 514)
        Me.Panel1.TabIndex = 1
        '
        'txtnumreq
        '
        Me.txtnumreq.Location = New System.Drawing.Point(748, 59)
        Me.txtnumreq.Name = "txtnumreq"
        Me.txtnumreq.Size = New System.Drawing.Size(138, 20)
        Me.txtnumreq.TabIndex = 113
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(689, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(127, 13)
        Me.Label12.TabIndex = 112
        Me.Label12.Text = "Number of Requirements:"
        '
        'datestat
        '
        Me.datestat.Location = New System.Drawing.Point(434, 60)
        Me.datestat.Name = "datestat"
        Me.datestat.Size = New System.Drawing.Size(200, 20)
        Me.datestat.TabIndex = 111
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(362, 66)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 13)
        Me.Label13.TabIndex = 110
        Me.Label13.Text = "Date Status:"
        '
        'cbReq
        '
        Me.cbReq.FormattingEnabled = True
        Me.cbReq.Location = New System.Drawing.Point(450, 27)
        Me.cbReq.Name = "cbReq"
        Me.cbReq.Size = New System.Drawing.Size(184, 21)
        Me.cbReq.TabIndex = 108
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(362, 30)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(89, 13)
        Me.Label15.TabIndex = 106
        Me.Label15.Text = "Requirements ID:"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnClose.Location = New System.Drawing.Point(845, 471)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(74, 31)
        Me.btnClose.TabIndex = 104
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'search_bar
        '
        Me.search_bar.Location = New System.Drawing.Point(675, 137)
        Me.search_bar.Name = "search_bar"
        Me.search_bar.Size = New System.Drawing.Size(244, 20)
        Me.search_bar.TabIndex = 103
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(625, 140)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 102
        Me.Label10.Text = "Search:"
        '
        'dgvSearch
        '
        Me.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.faculty_id, Me.fty_lname, Me.fty_fname, Me.fty_mname, Me.gender, Me.faculty_bdate, Me.address, Me.cpnum, Me.email, Me.position})
        Me.dgvSearch.Location = New System.Drawing.Point(351, 163)
        Me.dgvSearch.Name = "dgvSearch"
        Me.dgvSearch.Size = New System.Drawing.Size(571, 302)
        Me.dgvSearch.TabIndex = 84
        '
        'faculty_id
        '
        Me.faculty_id.HeaderText = "Faculty ID"
        Me.faculty_id.Name = "faculty_id"
        '
        'fty_lname
        '
        Me.fty_lname.HeaderText = "Last Name"
        Me.fty_lname.Name = "fty_lname"
        Me.fty_lname.Width = 153
        '
        'fty_fname
        '
        Me.fty_fname.HeaderText = "First Name"
        Me.fty_fname.Name = "fty_fname"
        Me.fty_fname.Width = 120
        '
        'fty_mname
        '
        Me.fty_mname.HeaderText = "Middle Name"
        Me.fty_mname.Name = "fty_mname"
        Me.fty_mname.Width = 130
        '
        'gender
        '
        Me.gender.HeaderText = "Gender"
        Me.gender.Name = "gender"
        '
        'faculty_bdate
        '
        Me.faculty_bdate.HeaderText = "Date of Birth"
        Me.faculty_bdate.Name = "faculty_bdate"
        '
        'address
        '
        Me.address.HeaderText = "Address"
        Me.address.Name = "address"
        '
        'cpnum
        '
        Me.cpnum.HeaderText = "Cp Number"
        Me.cpnum.Name = "cpnum"
        '
        'email
        '
        Me.email.HeaderText = "Email Address"
        Me.email.Name = "email"
        '
        'position
        '
        Me.position.HeaderText = "Position"
        Me.position.Name = "position"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Lavender
        Me.Panel2.Controls.Add(Me.btnModify)
        Me.Panel2.Controls.Add(Me.txtaddress)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.datetime)
        Me.Panel2.Controls.Add(Me.rbFemale)
        Me.Panel2.Controls.Add(Me.bdate)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.rbMale)
        Me.Panel2.Controls.Add(Me.txtcp)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Controls.Add(Me.txtftyId)
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Controls.Add(Me.txtftymname)
        Me.Panel2.Controls.Add(Me.txtpos)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtftyfname)
        Me.Panel2.Controls.Add(Me.txtemail)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtftylname)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(342, 514)
        Me.Panel2.TabIndex = 101
        '
        'btnModify
        '
        Me.btnModify.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnModify.Location = New System.Drawing.Point(134, 451)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(76, 31)
        Me.btnModify.TabIndex = 104
        Me.btnModify.Text = "Modify"
        Me.btnModify.UseVisualStyleBackColor = False
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(46, 294)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(255, 20)
        Me.txtaddress.TabIndex = 103
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Lavender
        Me.Label7.Location = New System.Drawing.Point(46, 317)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Email Address:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Lavender
        Me.Label9.Location = New System.Drawing.Point(46, 278)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 102
        Me.Label9.Text = "Address:"
        '
        'datetime
        '
        Me.datetime.AutoSize = True
        Me.datetime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datetime.Location = New System.Drawing.Point(12, 9)
        Me.datetime.Name = "datetime"
        Me.datetime.Size = New System.Drawing.Size(33, 15)
        Me.datetime.TabIndex = 109
        Me.datetime.Text = "Date"
        '
        'rbFemale
        '
        Me.rbFemale.AutoSize = True
        Me.rbFemale.BackColor = System.Drawing.Color.Lavender
        Me.rbFemale.Location = New System.Drawing.Point(106, 219)
        Me.rbFemale.Name = "rbFemale"
        Me.rbFemale.Size = New System.Drawing.Size(59, 17)
        Me.rbFemale.TabIndex = 99
        Me.rbFemale.TabStop = True
        Me.rbFemale.Text = "Female"
        Me.rbFemale.UseVisualStyleBackColor = False
        '
        'bdate
        '
        Me.bdate.Location = New System.Drawing.Point(46, 255)
        Me.bdate.Name = "bdate"
        Me.bdate.Size = New System.Drawing.Size(252, 20)
        Me.bdate.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Lavender
        Me.Label6.Location = New System.Drawing.Point(45, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Date of Birth:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'rbMale
        '
        Me.rbMale.AutoSize = True
        Me.rbMale.BackColor = System.Drawing.Color.Lavender
        Me.rbMale.Location = New System.Drawing.Point(52, 219)
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Size = New System.Drawing.Size(48, 17)
        Me.rbMale.TabIndex = 98
        Me.rbMale.TabStop = True
        Me.rbMale.Text = "Male"
        Me.rbMale.UseVisualStyleBackColor = False
        '
        'txtcp
        '
        Me.txtcp.Location = New System.Drawing.Point(48, 372)
        Me.txtcp.Name = "txtcp"
        Me.txtcp.Size = New System.Drawing.Size(255, 20)
        Me.txtcp.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Lavender
        Me.Label5.Location = New System.Drawing.Point(45, 356)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Cp Number:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Lavender
        Me.Label11.Location = New System.Drawing.Point(49, 203)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 100
        Me.Label11.Text = "Sex :"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Crimson
        Me.btnDelete.Location = New System.Drawing.Point(216, 451)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(74, 31)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'txtftyId
        '
        Me.txtftyId.Enabled = False
        Me.txtftyId.Location = New System.Drawing.Point(46, 63)
        Me.txtftyId.Name = "txtftyId"
        Me.txtftyId.ReadOnly = True
        Me.txtftyId.Size = New System.Drawing.Size(255, 20)
        Me.txtftyId.TabIndex = 16
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnAdd.Location = New System.Drawing.Point(52, 451)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(76, 31)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtftymname
        '
        Me.txtftymname.Location = New System.Drawing.Point(46, 180)
        Me.txtftymname.Name = "txtftymname"
        Me.txtftymname.Size = New System.Drawing.Size(255, 20)
        Me.txtftymname.TabIndex = 7
        '
        'txtpos
        '
        Me.txtpos.Location = New System.Drawing.Point(48, 411)
        Me.txtpos.Name = "txtpos"
        Me.txtpos.Size = New System.Drawing.Size(255, 20)
        Me.txtpos.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Lavender
        Me.Label4.Location = New System.Drawing.Point(46, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Middle Name:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Lavender
        Me.Label8.Location = New System.Drawing.Point(47, 395)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Position:"
        '
        'txtftyfname
        '
        Me.txtftyfname.Location = New System.Drawing.Point(49, 141)
        Me.txtftyfname.Name = "txtftyfname"
        Me.txtftyfname.Size = New System.Drawing.Size(255, 20)
        Me.txtftyfname.TabIndex = 5
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(46, 333)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(255, 20)
        Me.txtemail.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Lavender
        Me.Label3.Location = New System.Drawing.Point(46, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "First Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Lavender
        Me.Label1.Location = New System.Drawing.Point(45, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Faculty ID:"
        '
        'txtftylname
        '
        Me.txtftylname.Location = New System.Drawing.Point(49, 102)
        Me.txtftylname.Name = "txtftylname"
        Me.txtftylname.Size = New System.Drawing.Size(255, 20)
        Me.txtftylname.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Lavender
        Me.Label2.Location = New System.Drawing.Point(45, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Last Name:"
        '
        'faculty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 514)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "faculty"
        Me.Text = "faculty"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtnumreq As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents datestat As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbReq As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents search_bar As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dgvSearch As System.Windows.Forms.DataGridView
    Friend WithEvents faculty_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fty_lname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fty_fname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fty_mname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gender As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents faculty_bdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cpnum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents position As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents datetime As System.Windows.Forms.Label
    Friend WithEvents rbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents bdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rbMale As System.Windows.Forms.RadioButton
    Friend WithEvents txtcp As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtftyId As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtftymname As System.Windows.Forms.TextBox
    Friend WithEvents txtpos As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtftyfname As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtftylname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
