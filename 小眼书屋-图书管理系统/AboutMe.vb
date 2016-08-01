Public Class AboutMe

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CopyToClipboard.LinkClicked
        '赋值文本到剪切板
        My.Computer.Clipboard.SetText("小眼书屋—图书管理系统" & vbCrLf & "QQ:2543280836" & vbCrLf & "邮箱：15824734237@QQ.com")
    End Sub

    Private Sub VisitMyHomePage_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles VisitMyHomePage.LinkClicked
        '访问我的QQ空间
        System.Diagnostics.Process.Start("http://user.qzone.qq.com/2543280836")
    End Sub
End Class