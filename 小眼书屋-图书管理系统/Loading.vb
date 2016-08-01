Imports System.IO

Public Class Loading
    'API：鼠标拖动窗体移动
    Private Declare Function ReleaseCapture Lib "user32" () As Integer
    Private Declare Function SendMessageA Lib "user32" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, lParam As VariantType) As Integer

    Private Sub Loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '————————————————————————————
        If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\Data\Data.mdb") Then
            LoadingInfo.ForeColor = Color.Red
            LoadingInfo.Text = "未找到\Data\Data.mdb！"
            MsgBox("未找到必须的数据库文件""\Data\Data.mdb"",暂不支持自动释放该文件。请期待软件的后续更新,或联系作者[QQ:2543280836]。", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxSetForeground + MsgBoxStyle.SystemModal, "小眼书屋：未找到数据库文件！")
            End
        End If
        '————————————————————————————


        '准备工作
        ClosePic.Image = My.Resources.小眼书屋_图书管理系统.关闭_正常
        If Dir(Application.StartupPath & "\Data", FileAttribute.Directory) = "" Then
            LoadingInfo.Text = "未找到\Data,正在创建目录..."
            '\Data\目录不存在，创建之
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\Data")
        End If

        If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\Data\Data.mdb") Then
            LoadingInfo.Text = "未找到\Data\Data.mdb，正在创建..."
            '\Data\Data.mdb文件不存在，从Res资源里释放之
            Dim resources As System.Resources.ResourceManager = My.Resources.ResourceManager
            Dim FileB() As Byte = resources.GetObject("Data")
            Dim FileS As IO.Stream
            Try
                FileS = IO.File.Create("Data\Data.mdb")
                FileS.Write(FileB, 0, FileB.Length)
                FileS.Close()
                MessageBox.Show("资源释放成功")
            Catch Err As Exception
                MessageBox.Show("资源释放失败！" & Err.Message)
                End
            End Try
        End If

        '准备完毕
        LoadingInfo.Text = "数据库文件准备完毕."
    End Sub

    Private Sub Password_LostFocus(sender As Object, e As EventArgs) Handles Password.LostFocus
        '保证用户输入焦点只在两个TextBox控件上
        UserName.Focus()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        '验证管理员账户和密码
        '管理员账户：XiaoYan
        '管理员密码：2543280836
        If UserName.Text = "XiaoYan" And Password.Text = "2543280836" Then
            Me.Hide()
            MainWindow.Show()
        Else
            LoadingInfo.Text = "用户名或密码错误!!!"
        End If
    End Sub

    Private Sub BtnLogin_MouseEnter(sender As Object, e As EventArgs) Handles BtnLogin.MouseEnter
        '鼠标经过”登录“按钮，字体加下划线
        BtnLogin.Font = New Font("宋体", 12, FontStyle.Underline)
    End Sub

    Private Sub BtnLogin_MouseLeave(sender As Object, e As EventArgs) Handles BtnLogin.MouseLeave
        '鼠标离开”登录“按钮，字体取消下划线
        BtnLogin.Font = New Font("宋体", 12)
    End Sub

    Private Sub ClosePic_Click(sender As Object, e As EventArgs) Handles ClosePic.Click
        '点击圆角关闭按钮，询问是否退出程序
        If MsgBox("真的要退出[小眼书屋-图书管理系统]吗？", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "确定退出？") = vbYes Then End
    End Sub

    Private Sub Loading_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        '鼠标左键按下，拖动窗体移动
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessageA(Me.Handle, &HA1, 2, 0&)
        End If
    End Sub

#Region "关闭按钮与鼠标动作有关的动态效果"
    Private Sub ClosePic_MouseDown(sender As Object, e As MouseEventArgs) Handles ClosePic.MouseDown
        ClosePic.Image = My.Resources.小眼书屋_图书管理系统.关闭_按下
    End Sub

    Private Sub ClosePic_MouseEnter(sender As Object, e As EventArgs) Handles ClosePic.MouseEnter
        ClosePic.Image = My.Resources.小眼书屋_图书管理系统.关闭_移动
    End Sub

    Private Sub ClosePic_MouseLeave(sender As Object, e As EventArgs) Handles ClosePic.MouseLeave
        ClosePic.Image = My.Resources.小眼书屋_图书管理系统.关闭_正常
    End Sub

    Private Sub ClosePic_MouseUp(sender As Object, e As MouseEventArgs) Handles ClosePic.MouseUp
        ClosePic.Image = My.Resources.小眼书屋_图书管理系统.关闭_移动
    End Sub
#End Region

End Class