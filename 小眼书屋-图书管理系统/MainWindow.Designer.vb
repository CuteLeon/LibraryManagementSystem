<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.XiaoYanDataMenu = New System.Windows.Forms.MenuStrip()
        Me.图书租借ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.借阅图书ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.归还书籍ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.数据库管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.选择加载数据库ToolStripMenuItem = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.刷新数据ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.添加新数据ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.编辑数据ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.删除数据ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.查找数据ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出小眼书屋ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersData = New System.Windows.Forms.DataGridView()
        Me.LstUserName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LstUserSex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LstStudentIndex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LstProfession = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LstClass = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LstTelephone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LstAdress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddData = New System.Windows.Forms.Button()
        Me.btnEditData = New System.Windows.Forms.Button()
        Me.btnDeleteData = New System.Windows.Forms.Button()
        Me.btnSearchData = New System.Windows.Forms.Button()
        Me.BooksData = New System.Windows.Forms.DataGridView()
        Me.LstBookName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LstBookWriter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LstBookNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LstBuyTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LstHowMuch = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LstBookCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowBook = New System.Windows.Forms.DataGridView()
        Me.LstBorrowName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LstBorrowNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LstBorrowTelephone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LstBorrowAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LstBorrowBookInfo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LstBorrowDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LstBorrowID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReLoadData = New System.Windows.Forms.Button()
        Me.XiaoYanDataMenu.SuspendLayout()
        CType(Me.UsersData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorrowBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XiaoYanDataMenu
        '
        Me.XiaoYanDataMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.图书租借ToolStripMenuItem, Me.数据库管理ToolStripMenuItem, Me.退出小眼书屋ToolStripMenuItem, Me.关于ToolStripMenuItem})
        Me.XiaoYanDataMenu.Location = New System.Drawing.Point(0, 0)
        Me.XiaoYanDataMenu.Name = "XiaoYanDataMenu"
        Me.XiaoYanDataMenu.Size = New System.Drawing.Size(811, 25)
        Me.XiaoYanDataMenu.TabIndex = 0
        Me.XiaoYanDataMenu.Text = "MenuStrip1"
        '
        '图书租借ToolStripMenuItem
        '
        Me.图书租借ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.借阅图书ToolStripMenuItem, Me.归还书籍ToolStripMenuItem})
        Me.图书租借ToolStripMenuItem.Name = "图书租借ToolStripMenuItem"
        Me.图书租借ToolStripMenuItem.Size = New System.Drawing.Size(84, 21)
        Me.图书租借ToolStripMenuItem.Text = "图书租借(&B)"
        '
        '借阅图书ToolStripMenuItem
        '
        Me.借阅图书ToolStripMenuItem.Name = "借阅图书ToolStripMenuItem"
        Me.借阅图书ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.借阅图书ToolStripMenuItem.Text = "借阅图书"
        '
        '归还书籍ToolStripMenuItem
        '
        Me.归还书籍ToolStripMenuItem.Name = "归还书籍ToolStripMenuItem"
        Me.归还书籍ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.归还书籍ToolStripMenuItem.Text = "归还书籍"
        '
        '数据库管理ToolStripMenuItem
        '
        Me.数据库管理ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.选择加载数据库ToolStripMenuItem, Me.ToolStripSeparator3, Me.刷新数据ToolStripMenuItem, Me.ToolStripSeparator1, Me.添加新数据ToolStripMenuItem, Me.编辑数据ToolStripMenuItem, Me.删除数据ToolStripMenuItem, Me.ToolStripSeparator2, Me.查找数据ToolStripMenuItem})
        Me.数据库管理ToolStripMenuItem.Name = "数据库管理ToolStripMenuItem"
        Me.数据库管理ToolStripMenuItem.Size = New System.Drawing.Size(97, 21)
        Me.数据库管理ToolStripMenuItem.Text = "数据库管理(&D)"
        '
        '选择加载数据库ToolStripMenuItem
        '
        Me.选择加载数据库ToolStripMenuItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.选择加载数据库ToolStripMenuItem.Items.AddRange(New Object() {"加载用户数据库", "加载图书数据库", "加载借书数据库"})
        Me.选择加载数据库ToolStripMenuItem.Name = "选择加载数据库ToolStripMenuItem"
        Me.选择加载数据库ToolStripMenuItem.Size = New System.Drawing.Size(176, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(233, 6)
        '
        '刷新数据ToolStripMenuItem
        '
        Me.刷新数据ToolStripMenuItem.Name = "刷新数据ToolStripMenuItem"
        Me.刷新数据ToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.刷新数据ToolStripMenuItem.Text = "刷新数据"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(233, 6)
        '
        '添加新数据ToolStripMenuItem
        '
        Me.添加新数据ToolStripMenuItem.Name = "添加新数据ToolStripMenuItem"
        Me.添加新数据ToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.添加新数据ToolStripMenuItem.Text = "添加新数据"
        '
        '编辑数据ToolStripMenuItem
        '
        Me.编辑数据ToolStripMenuItem.Name = "编辑数据ToolStripMenuItem"
        Me.编辑数据ToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.编辑数据ToolStripMenuItem.Text = "编辑数据"
        '
        '删除数据ToolStripMenuItem
        '
        Me.删除数据ToolStripMenuItem.Name = "删除数据ToolStripMenuItem"
        Me.删除数据ToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.删除数据ToolStripMenuItem.Text = "删除数据"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(233, 6)
        '
        '查找数据ToolStripMenuItem
        '
        Me.查找数据ToolStripMenuItem.Name = "查找数据ToolStripMenuItem"
        Me.查找数据ToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.查找数据ToolStripMenuItem.Text = "查找数据"
        '
        '退出小眼书屋ToolStripMenuItem
        '
        Me.退出小眼书屋ToolStripMenuItem.Name = "退出小眼书屋ToolStripMenuItem"
        Me.退出小眼书屋ToolStripMenuItem.Size = New System.Drawing.Size(107, 21)
        Me.退出小眼书屋ToolStripMenuItem.Text = "退出小眼书屋(&E)"
        '
        '关于ToolStripMenuItem
        '
        Me.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem"
        Me.关于ToolStripMenuItem.Size = New System.Drawing.Size(60, 21)
        Me.关于ToolStripMenuItem.Text = "关于(&A)"
        '
        'UsersData
        '
        Me.UsersData.AllowUserToResizeRows = False
        Me.UsersData.BackgroundColor = System.Drawing.Color.White
        Me.UsersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsersData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LstUserName, Me.LstUserSex, Me.LstStudentIndex, Me.LstProfession, Me.LstClass, Me.LstTelephone, Me.LstAdress})
        Me.UsersData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.UsersData.Location = New System.Drawing.Point(12, 79)
        Me.UsersData.Name = "UsersData"
        Me.UsersData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.UsersData.RowTemplate.Height = 23
        Me.UsersData.Size = New System.Drawing.Size(787, 488)
        Me.UsersData.TabIndex = 1
        '
        'LstUserName
        '
        Me.LstUserName.HeaderText = "用户姓名"
        Me.LstUserName.Name = "LstUserName"
        Me.LstUserName.Width = 80
        '
        'LstUserSex
        '
        Me.LstUserSex.HeaderText = "性别"
        Me.LstUserSex.Name = "LstUserSex"
        Me.LstUserSex.Width = 70
        '
        'LstStudentIndex
        '
        Me.LstStudentIndex.HeaderText = "借书证编号"
        Me.LstStudentIndex.Name = "LstStudentIndex"
        '
        'LstProfession
        '
        Me.LstProfession.HeaderText = "专业"
        Me.LstProfession.Name = "LstProfession"
        '
        'LstClass
        '
        Me.LstClass.HeaderText = "班级"
        Me.LstClass.Name = "LstClass"
        '
        'LstTelephone
        '
        Me.LstTelephone.HeaderText = "手机号码"
        Me.LstTelephone.Name = "LstTelephone"
        '
        'LstAdress
        '
        Me.LstAdress.HeaderText = "家庭住址"
        Me.LstAdress.Name = "LstAdress"
        Me.LstAdress.Width = 180
        '
        'btnAddData
        '
        Me.btnAddData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddData.Location = New System.Drawing.Point(12, 28)
        Me.btnAddData.Name = "btnAddData"
        Me.btnAddData.Size = New System.Drawing.Size(110, 45)
        Me.btnAddData.TabIndex = 2
        Me.btnAddData.Text = "添加数据"
        Me.btnAddData.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddData.UseVisualStyleBackColor = True
        '
        'btnEditData
        '
        Me.btnEditData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditData.Location = New System.Drawing.Point(128, 28)
        Me.btnEditData.Name = "btnEditData"
        Me.btnEditData.Size = New System.Drawing.Size(110, 45)
        Me.btnEditData.TabIndex = 3
        Me.btnEditData.Text = "编辑数据"
        Me.btnEditData.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditData.UseVisualStyleBackColor = True
        '
        'btnDeleteData
        '
        Me.btnDeleteData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteData.Location = New System.Drawing.Point(244, 28)
        Me.btnDeleteData.Name = "btnDeleteData"
        Me.btnDeleteData.Size = New System.Drawing.Size(110, 45)
        Me.btnDeleteData.TabIndex = 4
        Me.btnDeleteData.Text = "删除数据"
        Me.btnDeleteData.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDeleteData.UseVisualStyleBackColor = True
        '
        'btnSearchData
        '
        Me.btnSearchData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchData.Location = New System.Drawing.Point(360, 28)
        Me.btnSearchData.Name = "btnSearchData"
        Me.btnSearchData.Size = New System.Drawing.Size(110, 45)
        Me.btnSearchData.TabIndex = 5
        Me.btnSearchData.Text = "查找数据"
        Me.btnSearchData.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearchData.UseVisualStyleBackColor = True
        '
        'BooksData
        '
        Me.BooksData.AllowUserToResizeRows = False
        Me.BooksData.BackgroundColor = System.Drawing.Color.White
        Me.BooksData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BooksData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LstBookName, Me.LstBookWriter, Me.LstBookNumber, Me.LstBuyTime, Me.LstHowMuch, Me.LstBookCount})
        Me.BooksData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.BooksData.Location = New System.Drawing.Point(12, 79)
        Me.BooksData.Name = "BooksData"
        Me.BooksData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.BooksData.RowTemplate.Height = 23
        Me.BooksData.Size = New System.Drawing.Size(787, 488)
        Me.BooksData.TabIndex = 6
        Me.BooksData.Visible = False
        '
        'LstBookName
        '
        Me.LstBookName.HeaderText = "图书名称"
        Me.LstBookName.Name = "LstBookName"
        Me.LstBookName.Width = 120
        '
        'LstBookWriter
        '
        Me.LstBookWriter.HeaderText = "图书作者"
        Me.LstBookWriter.Name = "LstBookWriter"
        '
        'LstBookNumber
        '
        Me.LstBookNumber.HeaderText = "图书编号"
        Me.LstBookNumber.Name = "LstBookNumber"
        '
        'LstBuyTime
        '
        Me.LstBuyTime.HeaderText = "购书日期"
        Me.LstBuyTime.Name = "LstBuyTime"
        '
        'LstHowMuch
        '
        Me.LstHowMuch.HeaderText = "购书价格"
        Me.LstHowMuch.Name = "LstHowMuch"
        '
        'LstBookCount
        '
        Me.LstBookCount.HeaderText = "库存数"
        Me.LstBookCount.Name = "LstBookCount"
        '
        'BorrowBook
        '
        Me.BorrowBook.AllowUserToResizeRows = False
        Me.BorrowBook.BackgroundColor = System.Drawing.Color.White
        Me.BorrowBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BorrowBook.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LstBorrowName, Me.LstBorrowNumber, Me.LstBorrowTelephone, Me.LstBorrowAddress, Me.LstBorrowBookInfo, Me.LstBorrowDate, Me.LstBorrowID})
        Me.BorrowBook.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.BorrowBook.Location = New System.Drawing.Point(12, 79)
        Me.BorrowBook.Name = "BorrowBook"
        Me.BorrowBook.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.BorrowBook.RowTemplate.Height = 23
        Me.BorrowBook.Size = New System.Drawing.Size(787, 488)
        Me.BorrowBook.TabIndex = 7
        Me.BorrowBook.Visible = False
        '
        'LstBorrowName
        '
        Me.LstBorrowName.HeaderText = "借书人姓名"
        Me.LstBorrowName.Name = "LstBorrowName"
        '
        'LstBorrowNumber
        '
        Me.LstBorrowNumber.HeaderText = "借书证编号"
        Me.LstBorrowNumber.Name = "LstBorrowNumber"
        '
        'LstBorrowTelephone
        '
        Me.LstBorrowTelephone.HeaderText = "手机号码"
        Me.LstBorrowTelephone.Name = "LstBorrowTelephone"
        '
        'LstBorrowAddress
        '
        Me.LstBorrowAddress.HeaderText = "家庭住址"
        Me.LstBorrowAddress.Name = "LstBorrowAddress"
        '
        'LstBorrowBookInfo
        '
        Me.LstBorrowBookInfo.HeaderText = "借书名称及编号"
        Me.LstBorrowBookInfo.Name = "LstBorrowBookInfo"
        Me.LstBorrowBookInfo.Width = 180
        '
        'LstBorrowDate
        '
        Me.LstBorrowDate.HeaderText = "借书日期"
        Me.LstBorrowDate.Name = "LstBorrowDate"
        Me.LstBorrowDate.Width = 90
        '
        'LstBorrowID
        '
        Me.LstBorrowID.HeaderText = "借书ID"
        Me.LstBorrowID.Name = "LstBorrowID"
        Me.LstBorrowID.Width = 80
        '
        'ReLoadData
        '
        Me.ReLoadData.Location = New System.Drawing.Point(476, 28)
        Me.ReLoadData.Name = "ReLoadData"
        Me.ReLoadData.Size = New System.Drawing.Size(110, 45)
        Me.ReLoadData.TabIndex = 8
        Me.ReLoadData.Text = "刷新数据"
        Me.ReLoadData.UseVisualStyleBackColor = True
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(811, 579)
        Me.Controls.Add(Me.ReLoadData)
        Me.Controls.Add(Me.btnSearchData)
        Me.Controls.Add(Me.btnDeleteData)
        Me.Controls.Add(Me.btnEditData)
        Me.Controls.Add(Me.btnAddData)
        Me.Controls.Add(Me.XiaoYanDataMenu)
        Me.Controls.Add(Me.BooksData)
        Me.Controls.Add(Me.BorrowBook)
        Me.Controls.Add(Me.UsersData)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.XiaoYanDataMenu
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "小眼书屋-图书管理系统"
        Me.XiaoYanDataMenu.ResumeLayout(False)
        Me.XiaoYanDataMenu.PerformLayout()
        CType(Me.UsersData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorrowBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents XiaoYanDataMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents 图书租借ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 借阅图书ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 归还书籍ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 数据库管理ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 添加新数据ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 编辑数据ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 删除数据ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 查找数据ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 退出小眼书屋ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 关于ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsersData As System.Windows.Forms.DataGridView
    Friend WithEvents 选择加载数据库ToolStripMenuItem As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents btnAddData As System.Windows.Forms.Button
    Friend WithEvents btnEditData As System.Windows.Forms.Button
    Friend WithEvents btnDeleteData As System.Windows.Forms.Button
    Friend WithEvents btnSearchData As System.Windows.Forms.Button
    Friend WithEvents LstUserName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LstUserSex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LstStudentIndex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LstProfession As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LstClass As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LstTelephone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LstAdress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BooksData As System.Windows.Forms.DataGridView
    Friend WithEvents BorrowBook As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 刷新数据ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReLoadData As System.Windows.Forms.Button
    Friend WithEvents LstBookName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LstBookWriter As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LstBookNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LstBuyTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LstHowMuch As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LstBookCount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LstBorrowName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LstBorrowNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LstBorrowTelephone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LstBorrowAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LstBorrowBookInfo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LstBorrowDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LstBorrowID As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
