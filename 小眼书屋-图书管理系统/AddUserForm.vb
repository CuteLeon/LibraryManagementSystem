Public Class AddUserForm
    Public IndexEditing As Integer '记录当前编辑的数据序数

    Private Sub btnAddNewUser_Click(sender As Object, e As EventArgs) Handles btnAddNewUser.Click
        Dim DataArray(6) As String
        Dim Index As Integer

        '保证信息填写完整
        For Each TextBox In Me.Controls
            If TextBox.Text = vbNullString Then MsgBox("请补全新用户信息", MsgBoxStyle.Exclamation, "信息不足") : Exit Sub
        Next
        '为数组变量赋值
        DataArray(0) = txtName.Text
        DataArray(1) = comSex.Text
        DataArray(2) = txtIndexNumber.Text
        DataArray(3) = txtProfession.Text
        DataArray(4) = txtClass.Text
        DataArray(5) = txtTelphone.Text
        DataArray(6) = txtAdress.Text

        If btnAddNewUser.Text = "添加新用户" Then
            '添加新用户
            '防止学号被重复注册
            For Index = 0 To MainWindow.UsersData.Rows.Count - 2
                If MainWindow.UsersData.Rows(Index).Cells(2).Value = txtIndexNumber.Text Then MsgBox("该学号已被注册。", MsgBoxStyle.Exclamation) : txtIndexNumber.Focus() : Exit Sub
            Next
            '信息写入数据库
            MainWindow.AddAccessData("用户数据", DataArray)
            '信息加入控件
            MainWindow.UsersData.Rows.Add(txtName.Text, comSex.Text, txtIndexNumber.Text, txtProfession.Text, txtClass.Text, txtTelphone.Text, txtAdress.Text)
            '设置控件标头
            MainWindow.UsersData.Rows(MainWindow.UsersData.NewRowIndex - 1).HeaderCell.Value = Str(MainWindow.UsersData.NewRowIndex).Trim
        ElseIf btnAddNewUser.Text = "保存修改" Then
            '编辑用户数据
            '信息编辑后写入数据库
            MainWindow.EditAccessData("用户数据", txtIndexNumber.Text, DataArray)

            '修改控件里的信息
            For Index = 0 To MainWindow.UsersData.Columns.Count - 1
                MainWindow.UsersData.Rows(IndexEditing).Cells(Index).Value = DataArray(Index)
            Next
        End If

        Me.Close()  '卸载窗体  而不是隐藏，否则TextBox不会被重置
    End Sub

    Private Sub AddUserForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        For Index = 0 To MainWindow.UsersData.Columns.Count - 1
            '窗体关闭（点击修改按钮或点击叉号）重新使控件允许用户排序
            MainWindow.UsersData.Columns(Index).SortMode = DataGridViewColumnSortMode.Automatic
        Next
    End Sub

End Class