Public Class AddBookForm
    Public IndexEditing As Integer '记录当前编辑的数据序数

    Private Sub btnAddBookData_Click(sender As Object, e As EventArgs) Handles btnAddBookData.Click
        Dim DataArray(5) As String
        Dim Index As Integer

        '不允许出现内容为空的文本框
        For Each TextBox In Me.Controls
            If TextBox.Text = vbNullString Then MsgBox("请补全新图书信息", MsgBoxStyle.Exclamation, "信息不足") : Exit Sub
        Next

        '给变量数组赋值
        DataArray(0) = txtBookName.Text
        DataArray(1) = txtBookWriter.Text
        DataArray(2) = txtBookNumber.Text
        DataArray(3) = txtBuyDate.Text
        DataArray(4) = txtHowMuch.Text
        DataArray(5) = nupBookCount.Value

        If btnAddBookData.Text = "添加新图书" Then
            '添加新图书
            For Index = 0 To MainWindow.BooksData.Rows.Count - 2
                '检测：防止图书编码重复
                If MainWindow.BooksData.Rows(Index).Cells(2).Value = txtBookNumber.Text Then MsgBox("该图书编号已被注册。", MsgBoxStyle.Exclamation) : txtBookNumber.Focus() : Exit Sub
            Next
            '信息写入数据库文件
            MainWindow.AddAccessData("图书数据", DataArray)
            '信息加入控件
            MainWindow.BooksData.Rows.Add(txtBookName.Text, txtBookWriter.Text, txtBookNumber.Text, txtBuyDate.Text, txtHowMuch.Text, nupBookCount.Value.ToString.Trim)
            '设置数据标头
            MainWindow.BooksData.Rows(MainWindow.BooksData.NewRowIndex - 1).HeaderCell.Value = Str(MainWindow.BooksData.NewRowIndex).Trim
        ElseIf btnAddBookData.Text = "保存修改" Then
            '编辑图书信息
            '信息写入数据库
            MainWindow.EditAccessData("图书数据", txtBookNumber.Text, DataArray)

            '信息加入控件
            For Index = 0 To MainWindow.BooksData.Columns.Count - 1
                MainWindow.BooksData.Rows(IndexEditing).Cells(Index).Value = DataArray(Index)
            Next
        End If

        Me.Close()  '卸载窗体  而不是隐藏，否则TextBox不会被重置
    End Sub

    Private Sub AddBookForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        For Index = 0 To MainWindow.BooksData.Columns.Count - 1
            '窗体关闭（点击修改按钮或点击叉号）重新使控件允许用户排序
            MainWindow.BooksData.Columns(Index).SortMode = DataGridViewColumnSortMode.Automatic
        Next

    End Sub

End Class