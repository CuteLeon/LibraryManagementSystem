<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowBookForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtStudentNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckNumber = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBorrowerName = New System.Windows.Forms.TextBox()
        Me.txtBorrowerTelephone = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBookName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBorrowDate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBorrowBook = New System.Windows.Forms.Button()
        Me.txtBorrowerAdress = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtStudentNumber
        '
        Me.txtStudentNumber.Location = New System.Drawing.Point(114, 18)
        Me.txtStudentNumber.Name = "txtStudentNumber"
        Me.txtStudentNumber.Size = New System.Drawing.Size(168, 21)
        Me.txtStudentNumber.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "借书证编号："
        '
        'CheckNumber
        '
        Me.CheckNumber.AutoSize = True
        Me.CheckNumber.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CheckNumber.Location = New System.Drawing.Point(113, 42)
        Me.CheckNumber.Name = "CheckNumber"
        Me.CheckNumber.Size = New System.Drawing.Size(101, 12)
        Me.CheckNumber.TabIndex = 4
        Me.CheckNumber.Text = "请输入借书证编号"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "借书人姓名："
        '
        'txtBorrowerName
        '
        Me.txtBorrowerName.Enabled = False
        Me.txtBorrowerName.Location = New System.Drawing.Point(114, 69)
        Me.txtBorrowerName.Name = "txtBorrowerName"
        Me.txtBorrowerName.Size = New System.Drawing.Size(168, 21)
        Me.txtBorrowerName.TabIndex = 6
        '
        'txtBorrowerTelephone
        '
        Me.txtBorrowerTelephone.Enabled = False
        Me.txtBorrowerTelephone.Location = New System.Drawing.Point(114, 96)
        Me.txtBorrowerTelephone.Name = "txtBorrowerTelephone"
        Me.txtBorrowerTelephone.Size = New System.Drawing.Size(168, 21)
        Me.txtBorrowerTelephone.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 12)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "手机号码："
        '
        'txtBookName
        '
        Me.txtBookName.Location = New System.Drawing.Point(114, 150)
        Me.txtBookName.Name = "txtBookName"
        Me.txtBookName.Size = New System.Drawing.Size(168, 21)
        Me.txtBookName.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 12)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "图书名称和编号："
        '
        'txtBorrowDate
        '
        Me.txtBorrowDate.Enabled = False
        Me.txtBorrowDate.Location = New System.Drawing.Point(114, 177)
        Me.txtBorrowDate.Name = "txtBorrowDate"
        Me.txtBorrowDate.Size = New System.Drawing.Size(168, 21)
        Me.txtBorrowDate.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "借书日期："
        '
        'btnBorrowBook
        '
        Me.btnBorrowBook.Location = New System.Drawing.Point(114, 206)
        Me.btnBorrowBook.Name = "btnBorrowBook"
        Me.btnBorrowBook.Size = New System.Drawing.Size(168, 42)
        Me.btnBorrowBook.TabIndex = 13
        Me.btnBorrowBook.Text = "提交借书单"
        Me.btnBorrowBook.UseVisualStyleBackColor = True
        '
        'txtBorrowerAdress
        '
        Me.txtBorrowerAdress.Enabled = False
        Me.txtBorrowerAdress.Location = New System.Drawing.Point(114, 123)
        Me.txtBorrowerAdress.Name = "txtBorrowerAdress"
        Me.txtBorrowerAdress.Size = New System.Drawing.Size(168, 21)
        Me.txtBorrowerAdress.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 12)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "家庭住址："
        '
        'BorrowBookForm
        '
        Me.AcceptButton = Me.btnBorrowBook
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 258)
        Me.Controls.Add(Me.txtBorrowerAdress)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnBorrowBook)
        Me.Controls.Add(Me.txtBorrowDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBookName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBorrowerTelephone)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBorrowerName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CheckNumber)
        Me.Controls.Add(Me.txtStudentNumber)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "BorrowBookForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "借阅书籍:"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtStudentNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CheckNumber As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBorrowerName As System.Windows.Forms.TextBox
    Friend WithEvents txtBorrowerTelephone As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBookName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBorrowDate As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBorrowBook As System.Windows.Forms.Button
    Friend WithEvents txtBorrowerAdress As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
