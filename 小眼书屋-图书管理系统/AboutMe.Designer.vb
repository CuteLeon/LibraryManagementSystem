<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutMe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutMe))
        Me.CopyToClipboard = New System.Windows.Forms.LinkLabel()
        Me.VisitMyHomePage = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'CopyToClipboard
        '
        Me.CopyToClipboard.ActiveLinkColor = System.Drawing.Color.Gray
        Me.CopyToClipboard.AutoSize = True
        Me.CopyToClipboard.BackColor = System.Drawing.Color.Transparent
        Me.CopyToClipboard.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CopyToClipboard.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.CopyToClipboard.LinkColor = System.Drawing.Color.White
        Me.CopyToClipboard.Location = New System.Drawing.Point(150, 184)
        Me.CopyToClipboard.Name = "CopyToClipboard"
        Me.CopyToClipboard.Size = New System.Drawing.Size(77, 12)
        Me.CopyToClipboard.TabIndex = 1
        Me.CopyToClipboard.TabStop = True
        Me.CopyToClipboard.Text = "复制到剪切板"
        '
        'VisitMyHomePage
        '
        Me.VisitMyHomePage.ActiveLinkColor = System.Drawing.Color.Gray
        Me.VisitMyHomePage.AutoSize = True
        Me.VisitMyHomePage.BackColor = System.Drawing.Color.Transparent
        Me.VisitMyHomePage.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.VisitMyHomePage.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.VisitMyHomePage.LinkColor = System.Drawing.Color.White
        Me.VisitMyHomePage.Location = New System.Drawing.Point(266, 184)
        Me.VisitMyHomePage.Name = "VisitMyHomePage"
        Me.VisitMyHomePage.Size = New System.Drawing.Size(77, 12)
        Me.VisitMyHomePage.TabIndex = 2
        Me.VisitMyHomePage.TabStop = True
        Me.VisitMyHomePage.Text = "访问我的主页"
        '
        'AboutMe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(395, 221)
        Me.Controls.Add(Me.VisitMyHomePage)
        Me.Controls.Add(Me.CopyToClipboard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "AboutMe"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "关于 小眼书屋-图书管理系统 "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CopyToClipboard As System.Windows.Forms.LinkLabel
    Friend WithEvents VisitMyHomePage As System.Windows.Forms.LinkLabel
End Class
