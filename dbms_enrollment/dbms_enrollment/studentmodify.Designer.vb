<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentmodify
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
        Me.bt_close = New System.Windows.Forms.Button()
        Me.cbstudent_Id = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.chckbc = New System.Windows.Forms.CheckBox()
        Me.chckgmoral = New System.Windows.Forms.CheckBox()
        Me.chckform137 = New System.Windows.Forms.CheckBox()
        Me.rbFemale = New System.Windows.Forms.RadioButton()
        Me.rbMale = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtemail_add = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcp_num = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bdate = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnmodify = New System.Windows.Forms.Button()
        Me.txtaddress = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtstu_lname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtstu_fname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtstu_mname = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'bt_close
        '
        Me.bt_close.BackColor = System.Drawing.Color.PaleVioletRed
        Me.bt_close.Location = New System.Drawing.Point(159, 393)
        Me.bt_close.Name = "bt_close"
        Me.bt_close.Size = New System.Drawing.Size(132, 47)
        Me.bt_close.TabIndex = 123
        Me.bt_close.Text = "Close"
        Me.bt_close.UseVisualStyleBackColor = False
        '
        'cbstudent_Id
        '
        Me.cbstudent_Id.FormattingEnabled = True
        Me.cbstudent_Id.Location = New System.Drawing.Point(83, 73)
        Me.cbstudent_Id.Name = "cbstudent_Id"
        Me.cbstudent_Id.Size = New System.Drawing.Size(646, 21)
        Me.cbstudent_Id.TabIndex = 122
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Lavender
        Me.Label8.Location = New System.Drawing.Point(16, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 121
        Me.Label8.Text = "Student ID:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(740, 74)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(181, 261)
        Me.TabControl1.TabIndex = 120
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
        'rbFemale
        '
        Me.rbFemale.AutoSize = True
        Me.rbFemale.Location = New System.Drawing.Point(542, 237)
        Me.rbFemale.Name = "rbFemale"
        Me.rbFemale.Size = New System.Drawing.Size(59, 17)
        Me.rbFemale.TabIndex = 118
        Me.rbFemale.TabStop = True
        Me.rbFemale.Text = "Female"
        Me.rbFemale.UseVisualStyleBackColor = True
        '
        'rbMale
        '
        Me.rbMale.AutoSize = True
        Me.rbMale.Location = New System.Drawing.Point(488, 237)
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Size = New System.Drawing.Size(48, 17)
        Me.rbMale.TabIndex = 117
        Me.rbMale.TabStop = True
        Me.rbMale.Text = "Male"
        Me.rbMale.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Lavender
        Me.Label11.Location = New System.Drawing.Point(485, 220)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 119
        Me.Label11.Text = "Sex :"
        '
        'txtemail_add
        '
        Me.txtemail_add.Location = New System.Drawing.Point(392, 304)
        Me.txtemail_add.Name = "txtemail_add"
        Me.txtemail_add.Size = New System.Drawing.Size(337, 20)
        Me.txtemail_add.TabIndex = 116
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Lavender
        Me.Label5.Location = New System.Drawing.Point(389, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 115
        Me.Label5.Text = "Email Address :"
        '
        'txtcp_num
        '
        Me.txtcp_num.Location = New System.Drawing.Point(19, 304)
        Me.txtcp_num.Name = "txtcp_num"
        Me.txtcp_num.Size = New System.Drawing.Size(367, 20)
        Me.txtcp_num.TabIndex = 114
        '
        'Label7
        '
        Me.Label7.AutoEllipsis = True
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Lavender
        Me.Label7.Location = New System.Drawing.Point(16, 289)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 113
        Me.Label7.Text = "Cp Number:"
        '
        'bdate
        '
        Me.bdate.CustomFormat = "yyyy-MM-dd"
        Me.bdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.bdate.Location = New System.Drawing.Point(19, 257)
        Me.bdate.Name = "bdate"
        Me.bdate.Size = New System.Drawing.Size(367, 20)
        Me.bdate.TabIndex = 111
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Lavender
        Me.Label9.Location = New System.Drawing.Point(16, 241)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 112
        Me.Label9.Text = "Date Of Birth :"
        '
        'btnmodify
        '
        Me.btnmodify.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnmodify.Location = New System.Drawing.Point(19, 393)
        Me.btnmodify.Name = "btnmodify"
        Me.btnmodify.Size = New System.Drawing.Size(132, 47)
        Me.btnmodify.TabIndex = 110
        Me.btnmodify.Text = "Modify"
        Me.btnmodify.UseVisualStyleBackColor = False
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(19, 188)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(367, 37)
        Me.txtaddress.TabIndex = 109
        Me.txtaddress.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Lavender
        Me.Label1.Location = New System.Drawing.Point(16, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Last Name:"
        '
        'txtstu_lname
        '
        Me.txtstu_lname.Location = New System.Drawing.Point(19, 140)
        Me.txtstu_lname.Name = "txtstu_lname"
        Me.txtstu_lname.Size = New System.Drawing.Size(272, 20)
        Me.txtstu_lname.TabIndex = 104
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Lavender
        Me.Label2.Location = New System.Drawing.Point(294, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "First Name :"
        '
        'txtstu_fname
        '
        Me.txtstu_fname.Location = New System.Drawing.Point(297, 140)
        Me.txtstu_fname.Name = "txtstu_fname"
        Me.txtstu_fname.Size = New System.Drawing.Size(226, 20)
        Me.txtstu_fname.TabIndex = 105
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Lavender
        Me.Label3.Location = New System.Drawing.Point(526, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "Middle Name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Lavender
        Me.Label4.Location = New System.Drawing.Point(16, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "Address :"
        '
        'txtstu_mname
        '
        Me.txtstu_mname.Location = New System.Drawing.Point(529, 140)
        Me.txtstu_mname.Name = "txtstu_mname"
        Me.txtstu_mname.Size = New System.Drawing.Size(200, 20)
        Me.txtstu_mname.TabIndex = 106
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(933, 516)
        Me.Panel1.TabIndex = 124
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Californian FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(15, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 22)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Student Information"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(3, 42)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(731, 342)
        Me.Panel2.TabIndex = 114
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(732, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(195, 342)
        Me.Panel3.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Lavender
        Me.Label10.Location = New System.Drawing.Point(13, 247)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 13)
        Me.Label10.TabIndex = 125
        Me.Label10.Text = "Cp Number:"
        '
        'studentmodify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 513)
        Me.Controls.Add(Me.bt_close)
        Me.Controls.Add(Me.cbstudent_Id)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.rbFemale)
        Me.Controls.Add(Me.rbMale)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtemail_add)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtcp_num)
        Me.Controls.Add(Me.bdate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnmodify)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtstu_lname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtstu_fname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtstu_mname)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "studentmodify"
        Me.Text = "studentmodify"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_close As System.Windows.Forms.Button
    Friend WithEvents cbstudent_Id As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents chckbc As System.Windows.Forms.CheckBox
    Friend WithEvents chckgmoral As System.Windows.Forms.CheckBox
    Friend WithEvents chckform137 As System.Windows.Forms.CheckBox
    Friend WithEvents rbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents rbMale As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtemail_add As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtcp_num As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents bdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnmodify As System.Windows.Forms.Button
    Friend WithEvents txtaddress As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtstu_lname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtstu_fname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtstu_mname As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
