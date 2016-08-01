Option Explicit On

Imports System.Data.Odbc

Public Class MainWindow
    Private Const AccessUserName As String = "XiaoYan"              '数据库账户
    Private Const AccessPassword As String = "2543280836"       '数据库密码  
    Private Const AccessFilePath As String = "\Data\Data.mdb"               '数据库文件末端路径 ”Application.StartupPath & AccessFilePath“

    Dim StrConn As String = "driver={microsoft access driver (*.mdb)};uid=" & AccessUserName & ";pwd=" & AccessPassword & ";dbq=" & Application.StartupPath & AccessFilePath
    Dim OdbcConn As New OdbcConnection(StrConn)
    Dim ListName As String = "用户数据"  '*.mdb里的表名
    Dim DataControl As Windows.Forms.DataGridView = UsersData
    Dim OdbcData As New OdbcDataAdapter("Select * From " & ListName, OdbcConn)
    Dim SetData As New DataSet
    Dim CommandBuilder As New OdbcCommandBuilder(OdbcData)

    Private Sub MainWindow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True  '取消关闭窗口
        If MsgBox("真的要退出[小眼书屋-图书管理系统]吗？", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "确定退出？") = vbYes Then
            OdbcConn.Close()
            End
        End If
    End Sub

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '设置按钮和菜单的图标
        数据库管理ToolStripMenuItem.Image = My.Resources.小眼书屋_图书管理系统.数据管理
        添加新数据ToolStripMenuItem.Image = My.Resources.小眼书屋_图书管理系统.添加数据
        编辑数据ToolStripMenuItem.Image = My.Resources.小眼书屋_图书管理系统.编辑数据
        删除数据ToolStripMenuItem.Image = My.Resources.小眼书屋_图书管理系统.删除数据
        查找数据ToolStripMenuItem.Image = My.Resources.小眼书屋_图书管理系统.查找数据
        btnAddData.Image = My.Resources.小眼书屋_图书管理系统.添加数据
        btnEditData.Image = My.Resources.小眼书屋_图书管理系统.编辑数据
        btnDeleteData.Image = My.Resources.小眼书屋_图书管理系统.删除数据
        btnSearchData.Image = My.Resources.小眼书屋_图书管理系统.查找数据

        OdbcConn.Open()   '打开数据库

        '初始化
        选择加载数据库ToolStripMenuItem.Text = "加载用户数据库"

        LoadAccessData() '加载用户数据库
    End Sub

    Private Sub MainWindow_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        '窗体大小调整，自动调整数据库控件的大小
        UsersData.Width = Me.Width - UsersData.Left - 28
        UsersData.Height = Me.Height - UsersData.Top - 50
        BooksData.Width = Me.Width - UsersData.Left - 28
        BooksData.Height = Me.Height - UsersData.Top - 50
        BorrowBook.Width = Me.Width - UsersData.Left - 28
        BorrowBook.Height = Me.Height - UsersData.Top - 50
    End Sub

    Private Sub 退出小眼书屋ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出小眼书屋ToolStripMenuItem.Click
        If MsgBox("真的要退出[小眼书屋-图书管理系统]吗？", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "确定退出？") = vbYes Then
            OdbcConn.Close() '关闭数据库
            End '退出程序
        End If
    End Sub

    Private Sub 关于ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于ToolStripMenuItem.Click
        '如果“关于”已经打开就激活 否则打开
        If Not AboutMe.Visible Then AboutMe.Show(Me) Else AboutMe.Focus()
    End Sub

    Private Sub LoadAccessData()
        '加载数据库
        Dim Index As Integer = 0
        Dim OdbcListData As New OdbcCommand("Select * From " & ListName, OdbcConn)
        Dim GetOdbcData As OdbcDataReader = OdbcListData.ExecuteReader()

        Select Case 选择加载数据库ToolStripMenuItem.Text
            Case "加载用户数据库"
                UsersData.Rows.Clear()

                Do While GetOdbcData.Read
                    UsersData.Rows.Add(GetOdbcData("姓名").ToString, GetOdbcData("性别").ToString, GetOdbcData("借书证编号").ToString, GetOdbcData("专业").ToString, GetOdbcData("班级").ToString, GetOdbcData("手机号码").ToString, GetOdbcData("家庭住址").ToString)
                    UsersData.Rows(Index).HeaderCell.Value = Str(Index + 1).Trim
                    Index += 1
                Loop

            Case "加载图书数据库"
                BooksData.Rows.Clear()

                Do While GetOdbcData.Read
                    BooksData.Rows.Add(GetOdbcData("图书名称").ToString, GetOdbcData("图书作者").ToString, GetOdbcData("图书编码").ToString, GetOdbcData("购书日期").ToString, GetOdbcData("购书价格").ToString, GetOdbcData("库存数").ToString)
                    BooksData.Rows(Index).HeaderCell.Value = Str(Index + 1).Trim
                    Index += 1
                Loop

            Case "加载借书数据库"
                BorrowBook.Rows.Clear()

                Do While GetOdbcData.Read
                    BorrowBook.Rows.Add(GetOdbcData("借书人姓名").ToString, GetOdbcData("借书证编号").ToString, GetOdbcData("手机号码").ToString, GetOdbcData("家庭住址").ToString, GetOdbcData("借书名称及编号").ToString, GetOdbcData("借书日期").ToString, GetOdbcData("借书ID").ToString)
                    BorrowBook.Rows(Index).HeaderCell.Value = Str(Index + 1).Trim
                    Index += 1
                Loop
        End Select
    End Sub

    Private Sub 选择加载数据库ToolStripMenuItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles 选择加载数据库ToolStripMenuItem.SelectedIndexChanged
        '切换要加载的数据库和要显示的控件
        Select Case 选择加载数据库ToolStripMenuItem.Text
            Case "加载用户数据库"
                ListName = "用户数据"
                DataControl = UsersData
                BooksData.Visible = False
                BorrowBook.Visible = False
                UsersData.Visible = True

            Case "加载图书数据库"
                ListName = "图书数据"
                DataControl = BooksData
                BooksData.Visible = True
                BorrowBook.Visible = False
                UsersData.Visible = False

            Case "加载借书数据库"
                ListName = "借书数据"
                DataControl = BorrowBook
                BooksData.Visible = False
                BorrowBook.Visible = True
                UsersData.Visible = False

        End Select

        LoadAccessData()
        '菜单点击后隐藏菜单
        数据库管理ToolStripMenuItem.HideDropDown()
    End Sub

    Private Sub btnAddData_Click(sender As Object, e As EventArgs) Handles btnAddData.Click
        '添加新数据，判断要打开的窗口
        Select Case 选择加载数据库ToolStripMenuItem.Text
            Case "加载用户数据库"
                If Not AddUserForm.Visible Then AddUserForm.Show(Me) Else AddUserForm.Focus()
            Case "加载图书数据库"
                If Not AddBookForm.Visible Then AddBookForm.Show(Me) Else AddBookForm.Focus()
            Case "加载借书数据库"
                If Not BorrowBookForm.Visible Then BorrowBookForm.Show(Me) Else BorrowBookForm.Focus()
        End Select
    End Sub

    Public Sub AddAccessData(ByVal ListName As String, ByVal DataArray() As String)
        '添加数据库数据_(储存数据的数组)
        OdbcData = New OdbcDataAdapter("Select * From " & ListName, OdbcConn)
        CommandBuilder = New OdbcCommandBuilder(OdbcData)
        OdbcData.Fill(SetData, ListName)
        OdbcData.InsertCommand = CommandBuilder.GetInsertCommand

        Dim RowDataTemp As DataRow = SetData.Tables(ListName).NewRow
        Dim Index As Integer
        '循环为新数据赋值
        For Index = LBound(DataArray) To UBound(DataArray)
            RowDataTemp(Index + 1) = DataArray(Index)
        Next
        SetData.Tables(ListName).Rows.Add(RowDataTemp)

        OdbcData.Update(SetData.Tables(ListName))
    End Sub

    Public Sub EditAccessData(ByVal ListName As String, ByVal IndexNumber As String, ByVal DataArray() As String)
        '编辑数据
        If ListName = "用户数据" Then
            OdbcData = New OdbcDataAdapter("Update " & ListName & " Set 姓名='" & DataArray(0) & "',性别='" & DataArray(1) & "',专业='" & DataArray(3) & "',班级='" & DataArray(4) & "',手机号码='" & DataArray(5) & "',家庭住址='" & DataArray(6) & "' Where 借书证编号='" & IndexNumber & "'", OdbcConn)
        ElseIf ListName = "图书数据" Then
            OdbcData = New OdbcDataAdapter("Update " & ListName & " Set 图书名称='" & DataArray(0) & "',图书作者='" & DataArray(1) & "',购书日期='" & DataArray(3) & "',购书价格='" & DataArray(4) & "',库存数='" & DataArray(5) & "' Where 图书编码='" & IndexNumber & "'", OdbcConn)
        End If

        CommandBuilder = New OdbcCommandBuilder(OdbcData)
        OdbcData.Fill(SetData, ListName)
    End Sub

    Private Sub DeleteAccessData(ByVal RowIndex As Integer)
        '删除数据库数据_(要删除条目的标识)
        Select Case ListName
            Case "用户数据"
                OdbcData = New OdbcDataAdapter("Delete From " & ListName & " Where 手机号码='" & DataControl.Rows(RowIndex).Cells(5).Value & "'", OdbcConn)
                CommandBuilder = New OdbcCommandBuilder(OdbcData)
                OdbcData.Fill(SetData, ListName)
            Case "图书数据"
                OdbcData = New OdbcDataAdapter("Delete From " & ListName & " Where 图书编码='" & DataControl.Rows(RowIndex).Cells(2).Value & "'", OdbcConn)
                CommandBuilder = New OdbcCommandBuilder(OdbcData)
                OdbcData.Fill(SetData, ListName)
            Case "借书数据"
                OdbcData = New OdbcDataAdapter("Delete From " & ListName & " Where 借书ID='" & DataControl.Rows(RowIndex).Cells(6).Value & "'", OdbcConn)
                CommandBuilder = New OdbcCommandBuilder(OdbcData)
                OdbcData.Fill(SetData, ListName)
        End Select
    End Sub

    Private Sub btnDeleteData_Click(sender As Object, e As EventArgs) Handles btnDeleteData.Click
        Dim IndexNow As Integer

        If ListName = "用户数据" Then
            DataControl = UsersData '设置控件
        ElseIf ListName = "图书数据" Then
            DataControl = BooksData
        ElseIf ListName = "借书数据" Then
            DataControl = BorrowBook
        End If

        IndexNow = DataControl.CurrentRow.Index '记录当前激活的条目的ID

        If IndexNow = DataControl.Rows.Count - 1 Then Exit Sub '有些用户手贱，把焦点放在最后不是数据的行

            If MsgBox("真的要删除 [" & DataControl.Rows(IndexNow).Cells(0).Value & "] 吗？", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "确定删除？") = vbYes Then
                DeleteAccessData(IndexNow) '删除数据库里的条目
                DataControl.Rows.RemoveAt(IndexNow) '在控件里删除条目

                For IndexNow = IndexNow To DataControl.Rows.Count - 2
                    DataControl.Rows(IndexNow).HeaderCell.Value = Str(IndexNow + 1).Trim
                Next
            End If
    End Sub

    Private Sub 添加新数据ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 添加新数据ToolStripMenuItem.Click
        btnAddData_Click(sender, e)
    End Sub

    Private Sub 编辑数据ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 编辑数据ToolStripMenuItem.Click
        btnEditData_Click(sender, e)
    End Sub

    Private Sub 删除数据ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 删除数据ToolStripMenuItem.Click
        btnDeleteData_Click(sender, e)
    End Sub

    Private Sub 刷新数据ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 刷新数据ToolStripMenuItem.Click
        LoadAccessData()
    End Sub

    Private Sub ReLoadData_Click(sender As Object, e As EventArgs) Handles ReLoadData.Click
        LoadAccessData()
    End Sub

    Private Sub 借阅图书ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 借阅图书ToolStripMenuItem.Click
        ListName = "借书数据"
        选择加载数据库ToolStripMenuItem.SelectedIndex = 2
        LoadAccessData()

        If Not BorrowBookForm.Visible Then BorrowBookForm.Show(Me) Else BorrowBookForm.Focus()
    End Sub

    Private Sub 归还书籍ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 归还书籍ToolStripMenuItem.Click
        MsgBox("说明：我懒！还没来得及写这个功能" & vbCrLf & "但是可以使用以下操作达到相同目的：" & vbCrLf & "    先在""数据库管理""菜单里选择加载借书数据库，然后鼠标点击要还书的数据，再点击删除数据即可实现""还书""功能。", MsgBoxStyle.Information, "关于""还书""功能的说明：")
    End Sub

    Private Sub MainWindow_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        AboutMe.Show(Me)
        AboutMe.Focus()
    End Sub

    Private Sub btnEditData_Click(sender As Object, e As EventArgs) Handles btnEditData.Click
        Dim IndexNow As Integer
        Dim Index As Integer

        If ListName = "用户数据" Then
            For Index = 0 To UsersData.Columns.Count - 1
                UsersData.Columns(Index).SortMode = DataGridViewColumnSortMode.Programmatic
            Next

            DataControl = UsersData '设置控件
            IndexNow = UsersData.CurrentRow.Index
            AddUserForm.IndexEditing = IndexNow
            If Not AddUserForm.Visible Then AddUserForm.Show(Me) Else AddUserForm.Focus()
            AddUserForm.Text = "编辑用户信息："
            AddUserForm.txtName.Text = UsersData.Rows(IndexNow).Cells(0).Value
            AddUserForm.comSex.SelectedIndex = If(UsersData.Rows(IndexNow).Cells(1).Value = "男", 0, 1)
            AddUserForm.txtIndexNumber.Text = UsersData.Rows(IndexNow).Cells(2).Value
            AddUserForm.txtIndexNumber.Enabled = False
            AddUserForm.txtProfession.Text = UsersData.Rows(IndexNow).Cells(3).Value
            AddUserForm.txtClass.Text = UsersData.Rows(IndexNow).Cells(4).Value
            AddUserForm.txtTelphone.Text = UsersData.Rows(IndexNow).Cells(5).Value
            AddUserForm.txtAdress.Text = UsersData.Rows(IndexNow).Cells(6).Value
            AddUserForm.btnAddNewUser.Text = "保存修改"
        ElseIf ListName = "图书数据" Then
            For Index = 0 To BooksData.Columns.Count - 1
                BooksData.Columns(Index).SortMode = DataGridViewColumnSortMode.Programmatic
            Next

            DataControl = BooksData
            IndexNow = BooksData.CurrentRow.Index
            AddBookForm.IndexEditing = IndexNow
            If Not AddBookForm.Visible Then AddBookForm.Show(Me) Else AddBookForm.Focus()
            AddBookForm.Text = "编辑图书信息："
            AddBookForm.txtBookName.Text = BooksData.Rows(IndexNow).Cells(0).Value
            AddBookForm.txtBookWriter.Text = BooksData.Rows(IndexNow).Cells(1).Value
            AddBookForm.txtBookNumber.Text = BooksData.Rows(IndexNow).Cells(2).Value
            AddBookForm.txtBookNumber.Enabled = False
            AddBookForm.txtBuyDate.Text = BooksData.Rows(IndexNow).Cells(3).Value
            AddBookForm.txtHowMuch.Text = BooksData.Rows(IndexNow).Cells(4).Value
            AddBookForm.nupBookCount.Value = Int(BooksData.Rows(IndexNow).Cells(5).Value)
            AddBookForm.btnAddBookData.Text = "保存修改"
        ElseIf ListName = "借书数据" Then
            MsgBox("借书订单不允许修改！", MsgBoxStyle.Information, "禁止修改已保存的订单")
        End If
    End Sub

    Private Sub btnSearchData_Click(sender As Object, e As EventArgs) Handles btnSearchData.Click
        MsgBox("这个功能还没来得及开发，开不开发看心情。", MsgBoxStyle.Information, "查找数据")
    End Sub

    Private Sub 查找数据ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 查找数据ToolStripMenuItem.Click
        MsgBox("这个功能还没来得及开发，开不开发看心情。", MsgBoxStyle.Information, "查找数据")
    End Sub

End Class