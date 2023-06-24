<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentInfo
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
        Me.btn_close = New System.Windows.Forms.Button()
        Me.txtstuId = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rbFemale = New System.Windows.Forms.RadioButton()
        Me.rbMale = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtemail_add = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcp_num = New System.Windows.Forms.TextBox()
        Me.bdate = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtaddress = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtstu_lname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtstu_fname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtstu_mname = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.chckbc = New System.Windows.Forms.CheckBox()
        Me.chckgmoral = New System.Windows.Forms.CheckBox()
        Me.chckform137 = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btn_close.Location = New System.Drawing.Point(157, 393)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(132, 47)
        Me.btn_close.TabIndex = 103
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'txtstuId
        '
        Me.txtstuId.Enabled = False
        Me.txtstuId.Location = New System.Drawing.Point(82, 73)
        Me.txtstuId.Name = "txtstuId"
        Me.txtstuId.ReadOnly = True
        Me.txtstuId.Size = New System.Drawing.Size(645, 20)
        Me.txtstuId.TabIndex = 100
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Lavender
        Me.Label8.Location = New System.Drawing.Point(14, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = "Student ID:"
        '
        'rbFemale
        '
        Me.rbFemale.AutoSize = True
        Me.rbFemale.Location = New System.Drawing.Point(540, 223)
        Me.rbFemale.Name = "rbFemale"
        Me.rbFemale.Size = New System.Drawing.Size(59, 17)
        Me.rbFemale.TabIndex = 96
        Me.rbFemale.TabStop = True
        Me.rbFemale.Text = "Female"
        Me.rbFemale.UseVisualStyleBackColor = True
        '
        'rbMale
        '
        Me.rbMale.AutoSize = True
        Me.rbMale.Location = New System.Drawing.Point(486, 223)
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Size = New System.Drawing.Size(48, 17)
        Me.rbMale.TabIndex = 95
        Me.rbMale.TabStop = True
        Me.rbMale.Text = "Male"
        Me.rbMale.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Lavender
        Me.Label11.Location = New System.Drawing.Point(483, 206)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 97
        Me.Label11.Text = "Sex :"
        '
        'txtemail_add
        '
        Me.txtemail_add.Location = New System.Drawing.Point(410, 311)
        Me.txtemail_add.Name = "txtemail_add"
        Me.txtemail_add.Size = New System.Drawing.Size(317, 20)
        Me.txtemail_add.TabIndex = 94
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Lavender
        Me.Label5.Location = New System.Drawing.Point(407, 295)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "Email Address :"
        '
        'txtcp_num
        '
        Me.txtcp_num.Location = New System.Drawing.Point(17, 311)
        Me.txtcp_num.Name = "txtcp_num"
        Me.txtcp_num.Size = New System.Drawing.Size(367, 20)
        Me.txtcp_num.TabIndex = 92
        '
        'bdate
        '
        Me.bdate.CustomFormat = "yyyy-MM-dd"
        Me.bdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.bdate.Location = New System.Drawing.Point(17, 257)
        Me.bdate.Name = "bdate"
        Me.bdate.Size = New System.Drawing.Size(367, 20)
        Me.bdate.TabIndex = 89
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Lavender
        Me.Label9.Location = New System.Drawing.Point(14, 241)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 90
        Me.Label9.Text = "Date Of Birth :"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnSubmit.Location = New System.Drawing.Point(17, 393)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(132, 47)
        Me.btnSubmit.TabIndex = 88
        Me.btnSubmit.Text = "Save Student"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(17, 188)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(367, 37)
        Me.txtaddress.TabIndex = 87
        Me.txtaddress.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Lavender
        Me.Label1.Location = New System.Drawing.Point(14, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Last Name:"
        '
        'txtstu_lname
        '
        Me.txtstu_lname.Location = New System.Drawing.Point(17, 140)
        Me.txtstu_lname.Name = "txtstu_lname"
        Me.txtstu_lname.Size = New System.Drawing.Size(272, 20)
        Me.txtstu_lname.TabIndex = 82
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Lavender
        Me.Label2.Location = New System.Drawing.Point(292, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "First Name :"
        '
        'txtstu_fname
        '
        Me.txtstu_fname.Location = New System.Drawing.Point(295, 140)
        Me.txtstu_fname.Name = "txtstu_fname"
        Me.txtstu_fname.Size = New System.Drawing.Size(226, 20)
        Me.txtstu_fname.TabIndex = 83
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Lavender
        Me.Label3.Location = New System.Drawing.Point(524, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "Middle Name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Lavender
        Me.Label4.Location = New System.Drawing.Point(14, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Address :"
        '
        'txtstu_mname
        '
        Me.txtstu_mname.Location = New System.Drawing.Point(527, 140)
        Me.txtstu_mname.Name = "txtstu_mname"
        Me.txtstu_mname.Size = New System.Drawing.Size(200, 20)
        Me.txtstu_mname.TabIndex = 84
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(734, 42)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(191, 346)
        Me.Panel4.TabIndex = 107
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(738, 74)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(181, 261)
        Me.TabControl1.TabIndex = 98
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.Controls.Add(Me.chckbc)
        Me.TabPage1.Controls.Add(Me.chckgmoral)
        Me.TabPage1.Controls.Add(Me.chckform137)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(173, 235)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Requirements"
        '
        'chckbc
        '
        Me.chckbc.AutoSize = True
        Me.chckbc.Location = New System.Drawing.Point(16, 44)
        Me.chckbc.Name = "chckbc"
        Me.chckbc.Size = New System.Drawing.Size(97, 17)
        Me.chckbc.TabIndex = 18
        Me.chckbc.Text = "Birth Certificate"
        Me.chckbc.UseVisualStyleBackColor = True
        '
        'chckgmoral
        '
        Me.chckgmoral.AutoSize = True
        Me.chckgmoral.Location = New System.Drawing.Point(16, 149)
        Me.chckgmoral.Name = "chckgmoral"
        Me.chckgmoral.Size = New System.Drawing.Size(77, 17)
        Me.chckgmoral.TabIndex = 21
        Me.chckgmoral.Text = "Goodmoral"
        Me.chckgmoral.UseVisualStyleBackColor = True
        '
        'chckform137
        '
        Me.chckform137.AutoSize = True
        Me.chckform137.Location = New System.Drawing.Point(16, 98)
        Me.chckform137.Name = "chckform137"
        Me.chckform137.Size = New System.Drawing.Size(70, 17)
        Me.chckform137.TabIndex = 19
        Me.chckform137.Text = "Form 137"
        Me.chckform137.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(3, 42)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(729, 346)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(731, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(194, 343)
        Me.Panel3.TabIndex = 106
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Lavender
        Me.Label7.Location = New System.Drawing.Point(12, 252)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 105
        Me.Label7.Text = "Cp Number :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Californian FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(14, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 22)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Student Information"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(931, 515)
        Me.Panel1.TabIndex = 104
        '
        'studentInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 513)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.txtstuId)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.rbFemale)
        Me.Controls.Add(Me.rbMale)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtemail_add)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtcp_num)
        Me.Controls.Add(Me.bdate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtstu_lname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtstu_fname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtstu_mname)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "studentInfo"
        Me.Text = "studentinfo"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents txtstuId As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents rbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents rbMale As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtemail_add As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtcp_num As System.Windows.Forms.TextBox
    Friend WithEvents bdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents txtaddress As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtstu_lname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtstu_fname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtstu_mname As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents chckbc As System.Windows.Forms.CheckBox
    Friend WithEvents chckgmoral As System.Windows.Forms.CheckBox
    Friend WithEvents chckform137 As System.Windows.Forms.CheckBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
