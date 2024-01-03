<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    'Inherits System.Windows.Forms.Form'
    Inherits Sunny.UI.UIForm

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim TreeNode1 As TreeNode = New TreeNode("龟苓膏(亚太)")
        Dim TreeNode2 As TreeNode = New TreeNode("烧仙草(欧盟)")
        Dim TreeNode3 As TreeNode = New TreeNode("黑凉粉(北美)")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        UiLine1 = New Sunny.UI.UILine()
        UiStyleManager = New Sunny.UI.UIStyleManager(components)
        UiSymbolButton1 = New Sunny.UI.UISymbolButton()
        UiNavMenu1 = New Sunny.UI.UINavMenu()
        UiLine2 = New Sunny.UI.UILine()
        UiCheckBox1 = New Sunny.UI.UICheckBox()
        UiCheckBox2 = New Sunny.UI.UICheckBox()
        UiCheckBox3 = New Sunny.UI.UICheckBox()
        UiLine3 = New Sunny.UI.UILine()
        UiCheckBox4 = New Sunny.UI.UICheckBox()
        UiTextBox1 = New Sunny.UI.UITextBox()
        UiTextBox2 = New Sunny.UI.UITextBox()
        BackgroundWorkerKillNP = New ComponentModel.BackgroundWorker()
        BackgroundWorkerKillGOST = New ComponentModel.BackgroundWorker()
        BackgroundWorkerConn = New ComponentModel.BackgroundWorker()
        UiButton1 = New Sunny.UI.UIButton()
        BackgroundWorkerSysProxy = New ComponentModel.BackgroundWorker()
        BackgroundWorkerSSRelay = New ComponentModel.BackgroundWorker()
        UiLabel1 = New Sunny.UI.UILabel()
        UiLabel2 = New Sunny.UI.UILabel()
        UiButton2 = New Sunny.UI.UIButton()
        UiLinkLabel1 = New Sunny.UI.UILinkLabel()
        SuspendLayout()
        ' 
        ' UiLine1
        ' 
        UiLine1.BackColor = Color.Transparent
        UiLine1.Font = New Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point)
        UiLine1.ForeColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiLine1.LineColor = Color.FromArgb(CByte(0), CByte(150), CByte(136))
        UiLine1.LineColor2 = Color.FromArgb(CByte(238), CByte(248), CByte(248))
        UiLine1.LineDashStyle = Sunny.UI.UILineDashStyle.Dash
        UiLine1.Location = New Point(13, 53)
        UiLine1.MinimumSize = New Size(1, 1)
        UiLine1.Name = "UiLine1"
        UiLine1.Size = New Size(218, 29)
        UiLine1.Style = Sunny.UI.UIStyle.Custom
        UiLine1.TabIndex = 2
        UiLine1.Text = "节点设置"
        UiLine1.TextAlign = ContentAlignment.MiddleLeft
        UiLine1.TextInterval = 30
        ' 
        ' UiStyleManager
        ' 
        UiStyleManager.GlobalFont = True
        UiStyleManager.GlobalFontName = "微软雅黑"
        ' 
        ' UiSymbolButton1
        ' 
        UiSymbolButton1.FillColor = Color.FromArgb(CByte(0), CByte(150), CByte(136))
        UiSymbolButton1.FillColor2 = Color.FromArgb(CByte(0), CByte(150), CByte(136))
        UiSymbolButton1.FillHoverColor = Color.FromArgb(CByte(51), CByte(171), CByte(160))
        UiSymbolButton1.FillPressColor = Color.FromArgb(CByte(0), CByte(120), CByte(109))
        UiSymbolButton1.FillSelectedColor = Color.FromArgb(CByte(0), CByte(120), CByte(109))
        UiSymbolButton1.Font = New Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point)
        UiSymbolButton1.Location = New Point(258, 263)
        UiSymbolButton1.MinimumSize = New Size(1, 1)
        UiSymbolButton1.Name = "UiSymbolButton1"
        UiSymbolButton1.RectColor = Color.FromArgb(CByte(0), CByte(150), CByte(136))
        UiSymbolButton1.RectHoverColor = Color.FromArgb(CByte(51), CByte(171), CByte(160))
        UiSymbolButton1.RectPressColor = Color.FromArgb(CByte(0), CByte(120), CByte(109))
        UiSymbolButton1.RectSelectedColor = Color.FromArgb(CByte(0), CByte(120), CByte(109))
        UiSymbolButton1.Size = New Size(173, 55)
        UiSymbolButton1.Style = Sunny.UI.UIStyle.Custom
        UiSymbolButton1.Symbol = 61956
        UiSymbolButton1.TabIndex = 3
        UiSymbolButton1.Text = "建立连接"
        UiSymbolButton1.TipsFont = New Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ' 
        ' UiNavMenu1
        ' 
        UiNavMenu1.BackColor = Color.FromArgb(CByte(240), CByte(240), CByte(240))
        UiNavMenu1.BorderStyle = BorderStyle.None
        UiNavMenu1.DrawMode = TreeViewDrawMode.OwnerDrawAll
        UiNavMenu1.FillColor = Color.FromArgb(CByte(240), CByte(240), CByte(240))
        UiNavMenu1.Font = New Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point)
        UiNavMenu1.ForeColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiNavMenu1.FullRowSelect = True
        UiNavMenu1.HoverColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        UiNavMenu1.ItemHeight = 50
        UiNavMenu1.Location = New Point(15, 88)
        UiNavMenu1.MenuStyle = Sunny.UI.UIMenuStyle.Custom
        UiNavMenu1.Name = "UiNavMenu1"
        TreeNode1.Name = "s01"
        TreeNode1.Text = "龟苓膏(亚太)"
        TreeNode2.Name = "s02"
        TreeNode2.Text = "烧仙草(欧盟)"
        TreeNode3.Name = "s03"
        TreeNode3.Text = "黑凉粉(北美)"
        UiNavMenu1.Nodes.AddRange(New TreeNode() {TreeNode1, TreeNode2, TreeNode3})
        UiNavMenu1.ScrollBarColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiNavMenu1.ScrollBarHoverColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiNavMenu1.ScrollBarPressColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiNavMenu1.ScrollFillColor = Color.FromArgb(CByte(240), CByte(240), CByte(240))
        UiNavMenu1.SecondBackColor = Color.FromArgb(CByte(235), CByte(235), CByte(235))
        UiNavMenu1.SelectedColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        UiNavMenu1.SelectedColor2 = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        UiNavMenu1.SelectedForeColor = Color.FromArgb(CByte(0), CByte(150), CByte(136))
        UiNavMenu1.SelectedHighColor = Color.FromArgb(CByte(0), CByte(150), CByte(136))
        UiNavMenu1.ShowLines = False
        UiNavMenu1.Size = New Size(207, 150)
        UiNavMenu1.Style = Sunny.UI.UIStyle.Custom
        UiNavMenu1.TabIndex = 4
        UiNavMenu1.TipsFont = New Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ' 
        ' UiLine2
        ' 
        UiLine2.BackColor = Color.Transparent
        UiLine2.Font = New Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point)
        UiLine2.ForeColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiLine2.LineColor = Color.FromArgb(CByte(0), CByte(150), CByte(136))
        UiLine2.LineColor2 = Color.FromArgb(CByte(238), CByte(248), CByte(248))
        UiLine2.LineDashStyle = Sunny.UI.UILineDashStyle.Dash
        UiLine2.Location = New Point(237, 53)
        UiLine2.MinimumSize = New Size(1, 1)
        UiLine2.Name = "UiLine2"
        UiLine2.Size = New Size(218, 29)
        UiLine2.Style = Sunny.UI.UIStyle.Custom
        UiLine2.TabIndex = 5
        UiLine2.Text = "代理设置"
        UiLine2.TextAlign = ContentAlignment.MiddleLeft
        UiLine2.TextInterval = 30
        ' 
        ' UiCheckBox1
        ' 
        UiCheckBox1.CheckBoxColor = Color.FromArgb(CByte(0), CByte(150), CByte(136))
        UiCheckBox1.Checked = True
        UiCheckBox1.Font = New Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point)
        UiCheckBox1.ForeColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiCheckBox1.Location = New Point(237, 88)
        UiCheckBox1.MinimumSize = New Size(1, 1)
        UiCheckBox1.Name = "UiCheckBox1"
        UiCheckBox1.Size = New Size(150, 29)
        UiCheckBox1.Style = Sunny.UI.UIStyle.Custom
        UiCheckBox1.TabIndex = 6
        UiCheckBox1.Text = "启用系统代理"
        ' 
        ' UiCheckBox2
        ' 
        UiCheckBox2.CheckBoxColor = Color.FromArgb(CByte(0), CByte(150), CByte(136))
        UiCheckBox2.Checked = True
        UiCheckBox2.Font = New Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point)
        UiCheckBox2.ForeColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiCheckBox2.Location = New Point(237, 123)
        UiCheckBox2.MinimumSize = New Size(1, 1)
        UiCheckBox2.Name = "UiCheckBox2"
        UiCheckBox2.Size = New Size(150, 29)
        UiCheckBox2.Style = Sunny.UI.UIStyle.Custom
        UiCheckBox2.TabIndex = 7
        UiCheckBox2.Text = "允许非本机连接"
        ' 
        ' UiCheckBox3
        ' 
        UiCheckBox3.CheckBoxColor = Color.FromArgb(CByte(0), CByte(150), CByte(136))
        UiCheckBox3.Font = New Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point)
        UiCheckBox3.ForeColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiCheckBox3.Location = New Point(237, 158)
        UiCheckBox3.MinimumSize = New Size(1, 1)
        UiCheckBox3.Name = "UiCheckBox3"
        UiCheckBox3.Size = New Size(150, 29)
        UiCheckBox3.Style = Sunny.UI.UIStyle.Custom
        UiCheckBox3.TabIndex = 8
        UiCheckBox3.Text = "使用Socks5协议"
        ' 
        ' UiLine3
        ' 
        UiLine3.BackColor = Color.Transparent
        UiLine3.Font = New Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point)
        UiLine3.ForeColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiLine3.LineColor = Color.FromArgb(CByte(0), CByte(150), CByte(136))
        UiLine3.LineColor2 = Color.FromArgb(CByte(238), CByte(248), CByte(248))
        UiLine3.LineDashStyle = Sunny.UI.UILineDashStyle.Dash
        UiLine3.Location = New Point(461, 53)
        UiLine3.MinimumSize = New Size(1, 1)
        UiLine3.Name = "UiLine3"
        UiLine3.Size = New Size(218, 29)
        UiLine3.Style = Sunny.UI.UIStyle.Custom
        UiLine3.TabIndex = 9
        UiLine3.Text = "中继设置"
        UiLine3.TextAlign = ContentAlignment.MiddleLeft
        UiLine3.TextInterval = 30
        ' 
        ' UiCheckBox4
        ' 
        UiCheckBox4.CheckBoxColor = Color.FromArgb(CByte(0), CByte(150), CByte(136))
        UiCheckBox4.Font = New Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point)
        UiCheckBox4.ForeColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiCheckBox4.Location = New Point(461, 88)
        UiCheckBox4.MinimumSize = New Size(1, 1)
        UiCheckBox4.Name = "UiCheckBox4"
        UiCheckBox4.Size = New Size(204, 29)
        UiCheckBox4.Style = Sunny.UI.UIStyle.Custom
        UiCheckBox4.TabIndex = 10
        UiCheckBox4.Text = "开启ShadowSocks中继"
        ' 
        ' UiTextBox1
        ' 
        UiTextBox1.ButtonFillColor = Color.FromArgb(CByte(0), CByte(150), CByte(136))
        UiTextBox1.ButtonFillHoverColor = Color.FromArgb(CByte(51), CByte(171), CByte(160))
        UiTextBox1.ButtonFillPressColor = Color.FromArgb(CByte(0), CByte(120), CByte(109))
        UiTextBox1.ButtonRectColor = Color.FromArgb(CByte(0), CByte(150), CByte(136))
        UiTextBox1.ButtonRectHoverColor = Color.FromArgb(CByte(51), CByte(171), CByte(160))
        UiTextBox1.ButtonRectPressColor = Color.FromArgb(CByte(0), CByte(120), CByte(109))
        UiTextBox1.ButtonStyleInherited = False
        UiTextBox1.FillColor2 = Color.FromArgb(CByte(238), CByte(248), CByte(248))
        UiTextBox1.FillColorGradient = True
        UiTextBox1.Font = New Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point)
        UiTextBox1.Location = New Point(461, 123)
        UiTextBox1.Margin = New Padding(4, 5, 4, 5)
        UiTextBox1.MinimumSize = New Size(1, 16)
        UiTextBox1.Name = "UiTextBox1"
        UiTextBox1.Padding = New Padding(5)
        UiTextBox1.RectColor = Color.FromArgb(CByte(0), CByte(150), CByte(136))
        UiTextBox1.ScrollBarColor = Color.FromArgb(CByte(0), CByte(150), CByte(136))
        UiTextBox1.ScrollBarStyleInherited = False
        UiTextBox1.ShowButton = True
        UiTextBox1.ShowText = False
        UiTextBox1.Size = New Size(204, 29)
        UiTextBox1.Style = Sunny.UI.UIStyle.Custom
        UiTextBox1.Symbol = 61572
        UiTextBox1.TabIndex = 13
        UiTextBox1.Text = "password"
        UiTextBox1.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBox1.Watermark = ""
        ' 
        ' UiTextBox2
        ' 
        UiTextBox2.ButtonFillColor = Color.FromArgb(CByte(0), CByte(150), CByte(136))
        UiTextBox2.ButtonFillHoverColor = Color.FromArgb(CByte(51), CByte(171), CByte(160))
        UiTextBox2.ButtonFillPressColor = Color.FromArgb(CByte(0), CByte(120), CByte(109))
        UiTextBox2.ButtonRectColor = Color.FromArgb(CByte(0), CByte(150), CByte(136))
        UiTextBox2.ButtonRectHoverColor = Color.FromArgb(CByte(51), CByte(171), CByte(160))
        UiTextBox2.ButtonRectPressColor = Color.FromArgb(CByte(0), CByte(120), CByte(109))
        UiTextBox2.ButtonStyleInherited = False
        UiTextBox2.DoubleValue = 1080R
        UiTextBox2.FillColor2 = Color.FromArgb(CByte(238), CByte(248), CByte(248))
        UiTextBox2.FillColorGradient = True
        UiTextBox2.Font = New Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point)
        UiTextBox2.IntValue = 1080
        UiTextBox2.Location = New Point(461, 158)
        UiTextBox2.Margin = New Padding(4, 5, 4, 5)
        UiTextBox2.MinimumSize = New Size(1, 16)
        UiTextBox2.Name = "UiTextBox2"
        UiTextBox2.Padding = New Padding(5)
        UiTextBox2.RectColor = Color.FromArgb(CByte(0), CByte(150), CByte(136))
        UiTextBox2.ScrollBarColor = Color.FromArgb(CByte(0), CByte(150), CByte(136))
        UiTextBox2.ScrollBarStyleInherited = False
        UiTextBox2.ShowText = False
        UiTextBox2.Size = New Size(204, 29)
        UiTextBox2.Style = Sunny.UI.UIStyle.Custom
        UiTextBox2.Symbol = 61926
        UiTextBox2.TabIndex = 14
        UiTextBox2.Text = "1080"
        UiTextBox2.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBox2.Watermark = ""
        ' 
        ' BackgroundWorkerKillNP
        ' 
        ' 
        ' BackgroundWorkerKillGOST
        ' 
        ' 
        ' BackgroundWorkerConn
        ' 
        ' 
        ' UiButton1
        ' 
        UiButton1.FillColor = Color.FromArgb(CByte(0), CByte(150), CByte(136))
        UiButton1.FillColor2 = Color.FromArgb(CByte(0), CByte(150), CByte(136))
        UiButton1.FillHoverColor = Color.FromArgb(CByte(51), CByte(171), CByte(160))
        UiButton1.FillPressColor = Color.FromArgb(CByte(0), CByte(120), CByte(109))
        UiButton1.FillSelectedColor = Color.FromArgb(CByte(0), CByte(120), CByte(109))
        UiButton1.Font = New Font("微软雅黑", 8F, FontStyle.Regular, GraphicsUnit.Point)
        UiButton1.LightColor = Color.FromArgb(CByte(238), CByte(248), CByte(248))
        UiButton1.Location = New Point(579, 351)
        UiButton1.MinimumSize = New Size(1, 1)
        UiButton1.Name = "UiButton1"
        UiButton1.RectColor = Color.FromArgb(CByte(0), CByte(150), CByte(136))
        UiButton1.RectHoverColor = Color.FromArgb(CByte(51), CByte(171), CByte(160))
        UiButton1.RectPressColor = Color.FromArgb(CByte(0), CByte(120), CByte(109))
        UiButton1.RectSelectedColor = Color.FromArgb(CByte(0), CByte(120), CByte(109))
        UiButton1.Size = New Size(100, 35)
        UiButton1.Style = Sunny.UI.UIStyle.Custom
        UiButton1.TabIndex = 15
        UiButton1.Text = "DebugView"
        UiButton1.TipsFont = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ' 
        ' BackgroundWorkerSysProxy
        ' 
        ' 
        ' BackgroundWorkerSSRelay
        ' 
        ' 
        ' UiLabel1
        ' 
        UiLabel1.Font = New Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point)
        UiLabel1.ForeColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiLabel1.Location = New Point(10, 356)
        UiLabel1.Name = "UiLabel1"
        UiLabel1.Size = New Size(221, 30)
        UiLabel1.TabIndex = 16
        UiLabel1.Text = "BY:神龟 , MeowRabbit"
        UiLabel1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiLabel2
        ' 
        UiLabel2.Font = New Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point)
        UiLabel2.ForeColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiLabel2.Location = New Point(15, 245)
        UiLabel2.Name = "UiLabel2"
        UiLabel2.Size = New Size(106, 30)
        UiLabel2.TabIndex = 17
        UiLabel2.Text = "传输协议:https"
        UiLabel2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiButton2
        ' 
        UiButton2.FillColor = Color.FromArgb(CByte(140), CByte(140), CByte(140))
        UiButton2.FillColor2 = Color.FromArgb(CByte(140), CByte(140), CByte(140))
        UiButton2.FillHoverColor = Color.FromArgb(CByte(163), CByte(163), CByte(163))
        UiButton2.FillPressColor = Color.FromArgb(CByte(112), CByte(112), CByte(112))
        UiButton2.FillSelectedColor = Color.FromArgb(CByte(112), CByte(112), CByte(112))
        UiButton2.Font = New Font("微软雅黑", 8F, FontStyle.Regular, GraphicsUnit.Point)
        UiButton2.LightColor = Color.FromArgb(CByte(248), CByte(248), CByte(248))
        UiButton2.Location = New Point(127, 244)
        UiButton2.MinimumSize = New Size(1, 1)
        UiButton2.Name = "UiButton2"
        UiButton2.RectColor = Color.FromArgb(CByte(140), CByte(140), CByte(140))
        UiButton2.RectHoverColor = Color.FromArgb(CByte(163), CByte(163), CByte(163))
        UiButton2.RectPressColor = Color.FromArgb(CByte(112), CByte(112), CByte(112))
        UiButton2.RectSelectedColor = Color.FromArgb(CByte(112), CByte(112), CByte(112))
        UiButton2.Size = New Size(95, 35)
        UiButton2.Style = Sunny.UI.UIStyle.Custom
        UiButton2.TabIndex = 18
        UiButton2.Text = "切换为QUIC"
        ' 
        ' UiLinkLabel1
        ' 
        UiLinkLabel1.ActiveLinkColor = Color.FromArgb(CByte(0), CByte(190), CByte(172))
        UiLinkLabel1.Font = New Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point)
        UiLinkLabel1.ForeColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiLinkLabel1.LinkBehavior = LinkBehavior.AlwaysUnderline
        UiLinkLabel1.Location = New Point(162, 360)
        UiLinkLabel1.Name = "UiLinkLabel1"
        UiLinkLabel1.Size = New Size(100, 23)
        UiLinkLabel1.Style = Sunny.UI.UIStyle.Custom
        UiLinkLabel1.TabIndex = 19
        UiLinkLabel1.TabStop = True
        UiLinkLabel1.Text = "加入TG讨论组"
        UiLinkLabel1.VisitedLinkColor = Color.FromArgb(CByte(230), CByte(80), CByte(80))
        ' 
        ' Main
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(238), CByte(248), CByte(248))
        ClientSize = New Size(688, 394)
        ControlBoxFillHoverColor = Color.FromArgb(CByte(51), CByte(171), CByte(160))
        Controls.Add(UiLinkLabel1)
        Controls.Add(UiButton2)
        Controls.Add(UiLabel2)
        Controls.Add(UiLabel1)
        Controls.Add(UiButton1)
        Controls.Add(UiTextBox2)
        Controls.Add(UiTextBox1)
        Controls.Add(UiCheckBox4)
        Controls.Add(UiLine3)
        Controls.Add(UiCheckBox3)
        Controls.Add(UiCheckBox2)
        Controls.Add(UiCheckBox1)
        Controls.Add(UiLine2)
        Controls.Add(UiNavMenu1)
        Controls.Add(UiSymbolButton1)
        Controls.Add(UiLine1)
        Font = New Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        IsForbidAltF4 = True
        MaximizeBox = False
        Name = "Main"
        Padding = New Padding(0, 50, 0, 0)
        RectColor = Color.FromArgb(CByte(0), CByte(150), CByte(136))
        Style = Sunny.UI.UIStyle.Custom
        Text = "神龟翻滚 2024 v7.0.1"
        TitleColor = Color.FromArgb(CByte(0), CByte(150), CByte(136))
        TitleFont = New Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TitleHeight = 50
        ZoomScaleRect = New Rectangle(15, 15, 800, 450)
        ResumeLayout(False)
    End Sub
    Friend WithEvents UiLine1 As Sunny.UI.UILine
    Friend WithEvents UiStyleManager As Sunny.UI.UIStyleManager
    Friend WithEvents UiSymbolButton1 As Sunny.UI.UISymbolButton
    Friend WithEvents UiNavMenu1 As Sunny.UI.UINavMenu
    Friend WithEvents UiLine2 As Sunny.UI.UILine
    Friend WithEvents UiCheckBox1 As Sunny.UI.UICheckBox
    Friend WithEvents UiCheckBox2 As Sunny.UI.UICheckBox
    Friend WithEvents UiCheckBox3 As Sunny.UI.UICheckBox
    Friend WithEvents UiLine3 As Sunny.UI.UILine
    Friend WithEvents UiCheckBox4 As Sunny.UI.UICheckBox
    Friend WithEvents UiTextBox1 As Sunny.UI.UITextBox
    Friend WithEvents UiTextBox2 As Sunny.UI.UITextBox
    Friend WithEvents BackgroundWorkerKillNP As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorkerKillGOST As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorkerConn As System.ComponentModel.BackgroundWorker
    Friend WithEvents UiButton1 As Sunny.UI.UIButton
    Friend WithEvents BackgroundWorkerSysProxy As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorkerSSRelay As System.ComponentModel.BackgroundWorker
    Friend WithEvents UiLabel1 As Sunny.UI.UILabel
    Friend WithEvents UiLabel2 As Sunny.UI.UILabel
    Friend WithEvents UiButton2 As Sunny.UI.UIButton
    Friend WithEvents UiLinkLabel1 As Sunny.UI.UILinkLabel
End Class
