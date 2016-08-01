Public Class BorrowBookForm

    Private Sub txtStudentNumber_TextChanged(sender As Object, e As EventArgs) Handles txtStudentNumber.TextChanged
        Dim Index As Integer
        '文本发生变化  自动检测用户是否存在
        For Index = 0 To MainWindow.UsersData.Rows.Count - 2
            If MainWindow.UsersData.Rows(Index).Cells(2).Value = txtStudentNumber.Text Then
                '用户存在
                CheckNumber.Text = "已找到该用户."
                CheckNumber.ForeColor = Color.Green
                txtBorrowerName.Text = MainWindow.UsersData.Rows(Index).Cells(0).Value
                txtBorrowerTelephone.Text = MainWindow.UsersData.Rows(Index).Cells(5).Value
                txtBorrowerAdress.Text = MainWindow.UsersData.Rows(Index).Cells(6).Value
                Exit Sub
            End If
        Next
        '用户不存在
        CheckNumber.Text = "未找到该用户。"
        CheckNumber.ForeColor = Color.Red
        txtBorrowerName.Text = vbNullString
        txtBorrowerTelephone.Text = vbNullString
        txtBorrowerAdress.Text = vbNullString
    End Sub

    Private Sub BorrowBookForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '自动获取日期 并修改格式
        txtBorrowDate.Text = Format(My.Computer.Clock.LocalTime.Date, "yyyy.MM.dd")
    End Sub

    Private Sub btnBorrowBook_Click(sender As Object, e As EventArgs) Handles btnBorrowBook.Click
        '提交新的借书订单
        '检测
        If txtBookName.Text = vbNullString Or CheckNumber.ForeColor = Color.Red Then
            MsgBox("信息不符合要求，请核实借书证编号并填写图书信息。", MsgBoxStyle.Critical, "请核实信息：")
            txtStudentNumber.Focus()
            Exit Sub
        End If

        '变量数组赋值
        Dim DataArray(6) As String
        DataArray(0) = txtBorrowerName.Text
        DataArray(1) = txtStudentNumber.Text
        DataArray(2) = txtBorrowerTelephone.Text
        DataArray(3) = txtBorrowerAdress.Text
        DataArray(4) = txtBookName.Text
        DataArray(5) = txtBorrowDate.Text
        DataArray(6) = GetBorrowID().ToString.Trim

        '信息写入数据库
        MainWindow.AddAccessData("借书数据", DataArray)
        '信息加入控件
        MainWindow.BorrowBook.Rows.Add(DataArray(0), DataArray(1), DataArray(2), DataArray(3), DataArray(4), DataArray(5), DataArray(6))
        '设置控件标头
        MainWindow.BorrowBook.Rows(MainWindow.BorrowBook.NewRowIndex - 1).HeaderCell.Value = Str(MainWindow.BorrowBook.NewRowIndex).Trim

        Me.Close()  '卸载窗体  而不是隐藏，否则TextBox不会被重置
    End Sub

    Private Function GetBorrowID() As Long
        '用来返回一个不存在且最小的借书ID
        '外层循环从0到数据库里借书ID的最大值
        '内层循环遍历控件里所有借书数据
        '寻找最小且未被占用的借书ID当做事件的标识，方便后面数据的删除
        '找不到则返回最大值+1
        Dim Index As Integer = 0, Result As Integer, MaxID As Integer, FindNot As Boolean
        MaxID = GetMax()
        For Result = 0 To MaxID
            FindNot = True
            For Index = 0 To MainWindow.BorrowBook.Rows.Count - 2
                If MainWindow.BorrowBook.Rows(Index).Cells(6).Value = Result Then FindNot = False : Exit For
            Next
            If FindNot Then Return Result
        Next
        Return Result
    End Function

    Private Function GetMax()
        '得到最大值
        '递归调用MaxInTwo(IntX,IntY)
        Dim Index As Integer, Result As Integer
        For Index = 0 To MainWindow.BorrowBook.Rows.Count - 2
            Result = MaxInTwo(Result, Int(MainWindow.BorrowBook.Rows(Index).Cells(6).Value))
        Next
        Return Result
    End Function

    Private Function MaxInTwo(ByVal IntX As Long, ByVal IntY As Long) As Long
        '比较两个数大小
        Return IIf(IntX > IntY, IntX, IntY)
    End Function

End Class