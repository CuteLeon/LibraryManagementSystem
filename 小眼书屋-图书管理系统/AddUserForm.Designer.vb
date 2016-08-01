<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUserForm
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
        Me.LabName = New System.Windows.Forms.Label()
        Me.LabSex = New System.Windows.Forms.Label()
        Me.LabIndexNumber = New System.Windows.Forms.Label()
        Me.LabProfession = New System.Windows.Forms.Label()
        Me.LabClass = New System.Windows.Forms.Label()
        Me.LabTelphone = New System.Windows.Forms.Label()
        Me.LabAdress = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtIndexNumber = New System.Windows.Forms.TextBox()
        Me.txtProfession = New System.Windows.Forms.TextBox()
        Me.txtClass = New System.Windows.Forms.TextBox()
        Me.txtTelphone = New System.Windows.Forms.TextBox()
        Me.txtAdress = New System.Windows.Forms.TextBox()
        Me.comSex = New System.Windows.Forms.ComboBox()
        Me.btnAddNewUser = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabName
        '
        Me.LabName.AutoSize = True
        Me.LabName.Location = New System.Drawing.Point(47, 20)
        Me.LabName.Name = "LabName"
        Me.LabName.Size = New System.Drawing.Size(35, 12)
        Me.LabName.TabIndex = 0
        Me.LabName.Text = "姓名:"
        '
        'LabSex
        '
        Me.LabSex.AutoSize = True
        Me.LabSex.Location = New System.Drawing.Point(47, 43)
        Me.LabSex.Name = "LabSex"
        Me.LabSex.Size = New System.Drawing.Size(35, 12)
        Me.LabSex.TabIndex = 1
        Me.LabSex.Text = "性别:"
        '
        'LabIndexNumber
        '
        Me.LabIndexNumber.AutoSize = True
        Me.LabIndexNumber.Location = New System.Drawing.Point(47, 66)
        Me.LabIndexNumber.Name = "LabIndexNumber"
        Me.LabIndexNumber.Size = New System.Drawing.Size(35, 12)
        Me.LabIndexNumber.TabIndex = 2
        Me.LabIndexNumber.Text = "学号:"
        '
        'LabProfession
        '
        Me.LabProfession.AutoSize = True
        Me.LabProfession.Location = New System.Drawing.Point(47, 89)
        Me.LabProfession.Name = "LabProfession"
        Me.LabProfession.Size = New System.Drawing.Size(35, 12)
        Me.LabProfession.TabIndex = 3
        Me.LabProfession.Text = "专业:"
        '
        'LabClass
        '
        Me.LabClass.AutoSize = True
        Me.LabClass.Location = New System.Drawing.Point(47, 112)
        Me.LabClass.Name = "LabClass"
        Me.LabClass.Size = New System.Drawing.Size(35, 12)
        Me.LabClass.TabIndex = 4
        Me.LabClass.Text = "班级:"
        '
        'LabTelphone
        '
        Me.LabTelphone.AutoSize = True
        Me.LabTelphone.Location = New System.Drawing.Point(23, 135)
        Me.LabTelphone.Name = "LabTelphone"
        Me.LabTelphone.Size = New System.Drawing.Size(59, 12)
        Me.LabTelphone.TabIndex = 5
        Me.LabTelphone.Text = "手机号码:"
        '
        'LabAdress
        '
        Me.LabAdress.AutoSize = True
        Me.LabAdress.Location = New System.Drawing.Point(23, 158)
        Me.LabAdress.Name = "LabAdress"
        Me.LabAdress.Size = New System.Drawing.Size(59, 12)
        Me.LabAdress.TabIndex = 6
        Me.LabAdress.Text = "家庭住址:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(88, 17)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(154, 21)
        Me.txtName.TabIndex = 0
        '
        'txtIndexNumber
        '
        Me.txtIndexNumber.Location = New System.Drawing.Point(88, 63)
        Me.txtIndexNumber.Name = "txtIndexNumber"
        Me.txtIndexNumber.Size = New System.Drawing.Size(154, 21)
        Me.txtIndexNumber.TabIndex = 2
        '
        'txtProfession
        '
        Me.txtProfession.Location = New System.Drawing.Point(88, 86)
        Me.txtProfession.Name = "txtProfession"
        Me.txtProfession.Size = New System.Drawing.Size(154, 21)
        Me.txtProfession.TabIndex = 3
        '
        'txtClass
        '
        Me.txtClass.Location = New System.Drawing.Point(88, 109)
        Me.txtClass.Name = "txtClass"
        Me.txtClass.Size = New System.Drawing.Size(154, 21)
        Me.txtClass.TabIndex = 4
        '
        'txtTelphone
        '
        Me.txtTelphone.Location = New System.Drawing.Point(88, 132)
        Me.txtTelphone.Name = "txtTelphone"
        Me.txtTelphone.Size = New System.Drawing.Size(154, 21)
        Me.txtTelphone.TabIndex = 5
        '
        'txtAdress
        '
        Me.txtAdress.Location = New System.Drawing.Point(88, 155)
        Me.txtAdress.Name = "txtAdress"
        Me.txtAdress.Size = New System.Drawing.Size(154, 21)
        Me.txtAdress.TabIndex = 6
        '
        'comSex
        '
        Me.comSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comSex.FormattingEnabled = True
        Me.comSex.Items.AddRange(New Object() {"男", "女"})
        Me.comSex.Location = New System.Drawing.Point(88, 41)
        Me.comSex.Name = "comSex"
        Me.comSex.Size = New System.Drawing.Size(154, 20)
        Me.comSex.TabIndex = 1
        '
        'btnAddNewUser
        '
        Me.btnAddNewUser.Location = New System.Drawing.Point(88, 182)
        Me.btnAddNewUser.Name = "btnAddNewUser"
        Me.btnAddNewUser.Size = New System.Drawing.Size(154, 37)
        Me.btnAddNewUser.TabIndex = 7
        Me.btnAddNewUser.Text = "添加新用户"
        Me.btnAddNewUser.UseVisualStyleBackColor = True
        '
        'AddUserForm
        '
        Me.AcceptButton = Me.btnAddNewUser
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(261, 230)
        Me.Controls.Add(Me.btnAddNewUser)
        Me.Controls.Add(Me.comSex)
        Me.Controls.Add(Me.txtAdress)
        Me.Controls.Add(Me.txtTelphone)
        Me.Controls.Add(Me.txtClass)
        Me.Controls.Add(Me.txtProfession)
        Me.Controls.Add(Me.txtIndexNumber)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.LabAdress)
        Me.Controls.Add(Me.LabTelphone)
        Me.Controls.Add(Me.LabClass)
        Me.Controls.Add(Me.LabProfession)
        Me.Controls.Add(Me.LabIndexNumber)
        Me.Controls.Add(Me.LabSex)
        Me.Controls.Add(Me.LabName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AddUserForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "添加新用户"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabName As System.Windows.Forms.Label
    Friend WithEvents LabSex As System.Windows.Forms.Label
    Friend WithEvents LabIndexNumber As System.Windows.Forms.Label
    Friend WithEvents LabProfession As System.Windows.Forms.Label
    Friend WithEvents LabClass As System.Windows.Forms.Label
    Friend WithEvents LabTelphone As System.Windows.Forms.Label
    Friend WithEvents LabAdress As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtIndexNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtProfession As System.Windows.Forms.TextBox
    Friend WithEvents txtClass As System.Windows.Forms.TextBox
    Friend WithEvents txtTelphone As System.Windows.Forms.TextBox
    Friend WithEvents txtAdress As System.Windows.Forms.TextBox
    Friend WithEvents comSex As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddNewUser As System.Windows.Forms.Button
End Class
