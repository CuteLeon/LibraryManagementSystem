<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loading
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loading))
        Me.LoadingInfo = New System.Windows.Forms.Label()
        Me.BtnLogin = New System.Windows.Forms.Label()
        Me.UserName = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.ClosePic = New System.Windows.Forms.PictureBox()
        CType(Me.ClosePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoadingInfo
        '
        Me.LoadingInfo.AutoSize = True
        Me.LoadingInfo.BackColor = System.Drawing.Color.Transparent
        Me.LoadingInfo.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LoadingInfo.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.LoadingInfo.Location = New System.Drawing.Point(12, 334)
        Me.LoadingInfo.Name = "LoadingInfo"
        Me.LoadingInfo.Size = New System.Drawing.Size(112, 14)
        Me.LoadingInfo.TabIndex = 0
        Me.LoadingInfo.Text = "正在加载程序..."
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.Transparent
        Me.BtnLogin.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.Color.Magenta
        Me.BtnLogin.Location = New System.Drawing.Point(184, 251)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(171, 42)
        Me.BtnLogin.TabIndex = 1
        Me.BtnLogin.Text = "管理员登录"
        Me.BtnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserName
        '
        Me.UserName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserName.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UserName.ForeColor = System.Drawing.Color.Black
        Me.UserName.Location = New System.Drawing.Point(221, 141)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(153, 26)
        Me.UserName.TabIndex = 0
        Me.UserName.Text = "XiaoYan"
        Me.UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Password
        '
        Me.Password.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Password.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Password.ForeColor = System.Drawing.Color.Black
        Me.Password.Location = New System.Drawing.Point(221, 179)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(153, 23)
        Me.Password.TabIndex = 1
        Me.Password.Text = "2543280836"
        Me.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Password.UseSystemPasswordChar = True
        '
        'ClosePic
        '
        Me.ClosePic.BackColor = System.Drawing.Color.Transparent
        Me.ClosePic.Location = New System.Drawing.Point(492, 1)
        Me.ClosePic.Name = "ClosePic"
        Me.ClosePic.Size = New System.Drawing.Size(47, 46)
        Me.ClosePic.TabIndex = 2
        Me.ClosePic.TabStop = False
        '
        'Loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.小眼书屋_图书管理系统.My.Resources.小眼书屋_图书管理系统.小眼书屋_Loading
        Me.ClientSize = New System.Drawing.Size(540, 359)
        Me.Controls.Add(Me.ClosePic)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.UserName)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.LoadingInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Loading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loading"
        Me.TopMost = True
        CType(Me.ClosePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LoadingInfo As System.Windows.Forms.Label
    Friend WithEvents BtnLogin As System.Windows.Forms.Label
    Friend WithEvents UserName As System.Windows.Forms.TextBox
    Friend WithEvents Password As System.Windows.Forms.TextBox
    Friend WithEvents ClosePic As System.Windows.Forms.PictureBox

End Class
