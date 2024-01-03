Imports System.Net.NetworkInformation
Imports System.Security.Cryptography.X509Certificates
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Sunny.UI
Imports Sunny.UI.Win32
Public Class Main
    Public PROXY_LISTEN_STR As String
    Public PROXY_METHOD_STR As String
    Public PROXY_SERVER_STR As String
    'Public PROXY_SERVER_METHOD_STR As String'
    Public PROXY_PASSWORD_STR As String
    Public RELAY_PASSWORD_STR As String
    Public RELAY_PORT_STR As String
    Public SYSPROXY_DO_STR As String
    Public PROXY_PROTOCOL As String
    Private Sub UiSymbolButton1_Click(sender As Object, e As EventArgs) Handles UiSymbolButton1.Click
        If UiSymbolButton1.Symbol = "61956" Then
            '建立连接'
            Try
                If UiNavMenu1.SelectedNode.Name = "s01" Then
                    '建立连接UI事件'
                    Sunny.UI.UIMessageTip.ShowOk("已连接", 2000)
                    UiSymbolButton1.Symbol = "61957"
                    UiSymbolButton1.Text = "断开连接"
                    UiSymbolButton1.Style = UIStyle.LayuiRed
                    UiCheckBox1.Enabled = False
                    UiCheckBox2.Enabled = False
                    UiCheckBox3.Enabled = False
                    UiNavMenu1.Enabled = False
                    UiButton2.Enabled = False
                    '建立连接call事件'
                    '定义拼接用字符串'
                    PROXY_SERVER_STR = "worst-proxy.digital"
                    PROXY_PASSWORD_STR = "t2GhiyJOJlzk9fKm26O5eg=="
                    '弃用PROXY_SERVER_METHOD_STR'
                    'PROXY_SERVER_METHOD_STR = "https"'
                    '判断是否使用Socks5'
                    If UiCheckBox3.Checked = True Then
                        PROXY_METHOD_STR = "socks"
                    Else
                        PROXY_METHOD_STR = "http"
                    End If
                    '判断是否允许连入'
                    If UiCheckBox2.Checked = True Then
                        PROXY_LISTEN_STR = "0.0.0.0"
                    Else
                        PROXY_LISTEN_STR = "127.0.0.1"
                    End If
                    '启动NaiveProxy'
                    BackgroundWorkerConn.RunWorkerAsync()
                    '判断是否使用系统代理'
                    If UiCheckBox1.Checked = True Then
                        '传参给蓝灯tool为on并执行'
                        SYSPROXY_DO_STR = "on"
                        BackgroundWorkerSysProxy.RunWorkerAsync()
                    End If
                ElseIf UiNavMenu1.SelectedNode.Name = "s02" Then
                    '建立连接UI事件'
                    Sunny.UI.UIMessageTip.ShowOk("已连接", 2000)
                    UiSymbolButton1.Symbol = "61957"
                    UiSymbolButton1.Text = "断开连接"
                    UiSymbolButton1.Style = UIStyle.LayuiRed
                    UiCheckBox1.Enabled = False
                    UiCheckBox2.Enabled = False
                    UiCheckBox3.Enabled = False
                    UiNavMenu1.Enabled = False
                    UiButton2.Enabled = False
                    '建立连接call事件'
                    '定义拼接用字符串'
                    PROXY_SERVER_STR = "ni.su.dwg.us.in"
                    PROXY_PASSWORD_STR = "Q52uG0m0BeibMT49IzMc0g=="
                    '弃用PROXY_SERVER_METHOD_STR'
                    'PROXY_SERVER_METHOD_STR = "https"'
                    '判断是否使用Socks5'
                    If UiCheckBox3.Checked = True Then
                        PROXY_METHOD_STR = "socks"
                    Else
                        PROXY_METHOD_STR = "http"
                    End If
                    '判断是否允许连入'
                    If UiCheckBox2.Checked = True Then
                        PROXY_LISTEN_STR = "0.0.0.0"
                    Else
                        PROXY_LISTEN_STR = "127.0.0.1"
                    End If
                    '启动NaiveProxy'
                    BackgroundWorkerConn.RunWorkerAsync()
                    '判断是否使用系统代理'
                    If UiCheckBox1.Checked = True Then
                        '传参给蓝灯tool为on并执行'
                        SYSPROXY_DO_STR = "on"
                        BackgroundWorkerSysProxy.RunWorkerAsync()
                    End If
                ElseIf UiNavMenu1.SelectedNode.Name = "s03" Then
                    '建立连接UI事件'
                    Sunny.UI.UIMessageTip.ShowOk("已连接", 2000)
                    UiSymbolButton1.Symbol = "61957"
                    UiSymbolButton1.Text = "断开连接"
                    UiSymbolButton1.Style = UIStyle.LayuiRed
                    UiCheckBox1.Enabled = False
                    UiCheckBox2.Enabled = False
                    UiCheckBox3.Enabled = False
                    UiNavMenu1.Enabled = False
                    UiButton2.Enabled = False
                    '建立连接call事件'
                    '定义拼接用字符串'
                    PROXY_SERVER_STR = "ns.iu.dwg.us.in"
                    PROXY_PASSWORD_STR = "toi7eOpDfgdqrIdIuHgs7w=="
                    '弃用PROXY_SERVER_METHOD_STR'
                    'PROXY_SERVER_METHOD_STR = "quic"'
                    '判断是否使用Socks5'
                    If UiCheckBox3.Checked = True Then
                        PROXY_METHOD_STR = "socks"
                    Else
                        PROXY_METHOD_STR = "http"
                    End If
                    '判断是否允许连入'
                    If UiCheckBox2.Checked = True Then
                        PROXY_LISTEN_STR = "0.0.0.0"
                    Else
                        PROXY_LISTEN_STR = "127.0.0.1"
                    End If
                    '启动NaiveProxy'
                    BackgroundWorkerConn.RunWorkerAsync()
                    '判断是否使用系统代理'
                    If UiCheckBox1.Checked = True Then
                        '传参给蓝灯tool为on并执行'
                        SYSPROXY_DO_STR = "on"
                        BackgroundWorkerSysProxy.RunWorkerAsync()
                    End If
                End If
            Catch
                Sunny.UI.UIMessageTip.ShowError("你好像没有选择节点哦", 2000)
            End Try
            'TODO'
        ElseIf UiSymbolButton1.Symbol = "61957" Then
            '断开连接UI事件'
            UiCheckBox1.Enabled = True
            UiCheckBox2.Enabled = True
            UiCheckBox3.Enabled = True
            UiCheckBox4.Checked = False
            UiNavMenu1.Enabled = True
            UiButton2.Enabled = True
            Sunny.UI.UIMessageTip.ShowOk("已断开", 2000)
            UiSymbolButton1.Symbol = "61956"
            UiSymbolButton1.Text = "建立连接"
            UiSymbolButton1.Style = UIStyle.LayuiGreen
            '断开连接call事件'
            '结束NaiveProxy'
            BackgroundWorkerKillNP.RunWorkerAsync()
            '判断是否使用系统代理'
            If UiCheckBox1.Checked = True Then
                '传参给蓝灯tool为off并执行'
                SYSPROXY_DO_STR = "off"
                BackgroundWorkerSysProxy.RunWorkerAsync()
            End If
        End If

    End Sub

    Private Sub UiNavMenu1_MenuItemClick(node As TreeNode, item As NavMenuItem, pageIndex As Integer) Handles UiNavMenu1.MenuItemClick
        If UiNavMenu1.SelectedNode.Name = "s01" Then
            '判断是否ping通'
            Dim pingreq As Ping = New Ping()
            '捕获ping错误以判断DNS无法解析'
            Try
                '定义ping目标'
                Dim rep As PingReply = pingreq.Send("worst-proxy.digital", 500)
                '如果返回0则是ping不通'
                If rep.RoundtripTime = 0 Then
                    'Sunny.UI.UIMessageTip.ShowError("该节点似乎不可用", 1000)'
                    Dim rep2 As PingReply = pingreq.Send("worst-proxy.digital", 500)
                    If rep2.RoundtripTime = 0 Then
                        Sunny.UI.UIMessageTip.ShowError("该节点似乎不可用", 1000)
                    Else
                        Sunny.UI.UIMessageTip.ShowOk("该节点似乎可用,延迟:" & rep2.RoundtripTime & "ms", 1000)
                    End If
                Else
                    Sunny.UI.UIMessageTip.ShowOk("该节点似乎可用,延迟:" & rep.RoundtripTime & "ms", 1000)
                End If
            Catch
                Sunny.UI.UIMessageDialog.ShowMessageDialog("无法解析节点域名,请检查系统DNS" & vbCrLf & "检测方法:nslookup in.us.dwg.us.in", UILocalize.ErrorTitle, False, UIStyle.Red)
            End Try

        ElseIf UiNavMenu1.SelectedNode.Name = "s02" Then
            '判断是否ping通'
            Dim pingreq As Ping = New Ping()
            '捕获ping错误以判断DNS无法解析'
            Try
                '定义ping目标'
                Dim rep As PingReply = pingreq.Send("ni.su.dwg.us.in", 500)
                '如果返回0则是ping不通'
                If rep.RoundtripTime = 0 Then
                    'Sunny.UI.UIMessageTip.ShowError("该节点似乎不可用", 1000)'
                    Dim rep2 As PingReply = pingreq.Send("ni.su.dwg.us.in", 500)
                    If rep2.RoundtripTime = 0 Then
                        Sunny.UI.UIMessageTip.ShowError("该节点似乎不可用", 1000)
                    Else
                        Sunny.UI.UIMessageTip.ShowOk("该节点似乎可用,延迟:" & rep2.RoundtripTime & "ms", 1000)
                    End If
                Else
                    Sunny.UI.UIMessageTip.ShowOk("该节点似乎可用,延迟:" & rep.RoundtripTime & "ms", 1000)
                End If
            Catch
                Sunny.UI.UIMessageDialog.ShowMessageDialog("无法解析节点域名,请检查系统DNS" & vbCrLf & "检测方法:nslookup ni.su.dwg.us.in", UILocalize.ErrorTitle, False, UIStyle.Red)
            End Try
        ElseIf UiNavMenu1.SelectedNode.Name = "s03" Then
            '判断是否ping通'
            Dim pingreq As Ping = New Ping()
            '捕获ping错误以判断DNS无法解析'
            Try
                '定义ping目标'
                Dim rep As PingReply = pingreq.Send("ns.iu.dwg.us.in", 500)
                '如果返回0则是ping不通'
                If rep.RoundtripTime = 0 Then
                    'Sunny.UI.UIMessageTip.ShowError("该节点似乎不可用", 1000)'
                    Dim rep2 As PingReply = pingreq.Send("ns.iu.dwg.us.in", 500)
                    If rep2.RoundtripTime = 0 Then
                        Sunny.UI.UIMessageTip.ShowError("该节点似乎不可用", 1000)
                    Else
                        Sunny.UI.UIMessageTip.ShowOk("该节点似乎可用,延迟:" & rep2.RoundtripTime & "ms", 1000)
                    End If
                Else
                    Sunny.UI.UIMessageTip.ShowOk("该节点似乎可用,延迟:" & rep.RoundtripTime & "ms", 1000)
                End If
            Catch
                Sunny.UI.UIMessageDialog.ShowMessageDialog("无法解析节点域名,请检查系统DNS" & vbCrLf & "检测方法:nslookup ni.su.dwg.us.in", UILocalize.ErrorTitle, False, UIStyle.Red)
            End Try
        End If
    End Sub

    Private Sub UiTextBox1_TextChanged(sender As Object, e As EventArgs) Handles UiTextBox1.ButtonClick
        '密码生成器'
        Dim source As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        Dim random As New Random
        Dim sb As New StringBuilder
        Dim cnt As Integer = random.Next(8, 17)
        For i As Integer = 1 To cnt
            Dim idx As Integer = random.Next(0, source.Length)
            sb.Append(source.Substring(idx, 1))
        Next
        UiTextBox1.Text = sb.ToString()
    End Sub

    Private Sub UiCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles UiCheckBox1.CheckedChanged
        '取消选中系统代理时显示使用提示'
        If UiCheckBox1.Checked = False And UiCheckBox3.Checked = False Then
            Sunny.UI.UIMessageDialog.ShowMessageDialog("若关闭系统代理,你需要手动设置代理:" & vbCrLf & "HTTP 127.0.0.1:7788", "提示", False, UIStyle.LayuiGreen)
        ElseIf UiCheckBox1.Checked = True Then
            '重新选中时取消选中Socks5选项'
            UiCheckBox3.Checked = False
        End If
    End Sub

    Private Sub UiCheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles UiCheckBox3.CheckedChanged
        '选中Socks5时显示使用提示'
        If UiCheckBox3.Checked = True Then
            Sunny.UI.UIMessageDialog.ShowMessageDialog("若使用Socks5,你需要手动设置代理:" & vbCrLf & "SOCKS5 127.0.0.1:7788" & vbCrLf & "该选项和系统代理互斥", "提示", False, UIStyle.LayuiGreen)
            '同时取消选中系统代理选项'
            UiCheckBox1.Checked = False
        End If
    End Sub

    Private Sub UiCheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles UiCheckBox4.CheckedChanged
        '没建立连接不准开启中继'
        If UiSymbolButton1.Symbol = "61956" And UiCheckBox4.Checked = True Then
            Sunny.UI.UIMessageTip.ShowWarning("建立连接后才可以开启SS中继", 1000)
            UiCheckBox4.Checked = False
        End If
        '连接建立状态下取消选中时结束Gost'
        If UiSymbolButton1.Symbol = "61957" And UiCheckBox4.Checked = False Then
            BackgroundWorkerKillGOST.RunWorkerAsync()
        End If
        '开启中继'
        If UiSymbolButton1.Symbol = "61957" And UiCheckBox4.Checked = True Then
            '传入用户定义的端口和密码'
            RELAY_PORT_STR = UiTextBox2.Text
            RELAY_PASSWORD_STR = UiTextBox1.Text
            '启动Gost'
            BackgroundWorkerSSRelay.RunWorkerAsync()
            '弹出SS连接信息'
            Sunny.UI.UIMessageDialog.ShowMessageDialog("请在局域网其他设备运行Shadowsocks" & vbCrLf & "服务器:本机内网IP" & vbCrLf & "远程端口:" & RELAY_PORT_STR & vbCrLf & "密码:" & RELAY_PASSWORD_STR & vbCrLf & "加密方式:AES-128-GCM", "提示", False, UIStyle.LayuiGreen)
        End If
    End Sub

    Private Sub BackgroundWorkerKillNP_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerKillNP.DoWork
        Dim process As Process = New Process()
        process.StartInfo.FileName = "taskkill.exe"
        process.StartInfo.Arguments = "/f /im sgfgcore-np.exe"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.RedirectStandardOutput = True
        process.Start()
        process.StandardOutput.ReadToEnd()
        process.WaitForExit()
        process.Close()
    End Sub

    Private Sub BackgroundWorkerKillGOST_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerKillGOST.DoWork
        Dim process As Process = New Process()
        process.StartInfo.FileName = "taskkill.exe"
        process.StartInfo.Arguments = "/f /im sgfgcore-gost3.exe"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.RedirectStandardOutput = True
        process.Start()
        process.StandardOutput.ReadToEnd()
        process.WaitForExit()
        process.Close()
    End Sub

    Private Sub BackgroundWorkerConn_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerConn.DoWork
        Dim process As Process = New Process()
        process.StartInfo.FileName = "sgfgcore-np.exe"
        process.StartInfo.Arguments = "--listen=" & PROXY_METHOD_STR & "://" & PROXY_LISTEN_STR & ":7788 --proxy=" & PROXY_PROTOCOL & "://sgfg:" & PROXY_PASSWORD_STR & "@" & PROXY_SERVER_STR & ":443"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.RedirectStandardOutput = True
        process.Start()
        process.StandardOutput.ReadToEnd()
        process.WaitForExit()
        process.Close()
    End Sub

    Private Sub UiButton1_Click(sender As Object, e As EventArgs) Handles UiButton1.Click
        '!!!REMOVE BEFORE STABLE RELEASE!!!'
        Sunny.UI.UIMessageDialog.ShowMessageDialog("Spliced NaiveProxy Argument:" & vbCrLf & "sgfgcore-np.exe " & "--listen=" & PROXY_METHOD_STR & "://" & PROXY_LISTEN_STR & ":7788 --proxy=" & PROXY_PROTOCOL & "://sgfg:" & PROXY_PASSWORD_STR & "@" & PROXY_SERVER_STR & ":443" & vbCrLf & "Spliced Gost Argument:" & vbCrLf & "sgfgcore-gost3.exe" & " -L ss://aes-128-gcm:" & RELAY_PASSWORD_STR & "@0.0.0.0:" & RELAY_PORT_STR & " -F " & PROXY_METHOD_STR & "://127.0.0.1:7788", "DebugView", False, UIStyle.Green)
    End Sub

    Private Sub BackgroundWorkerSysProxy_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerSysProxy.DoWork
        Dim process As Process = New Process()
        process.StartInfo.FileName = "sgfgsysproxy.exe"
        process.StartInfo.Arguments = SYSPROXY_DO_STR & " 127.0.0.1 7788"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.RedirectStandardOutput = True
        process.Start()
        process.StandardOutput.ReadToEnd()
        process.WaitForExit()
        process.Close()
    End Sub

    Private Sub BackgroundWorkerSSRelay_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerSSRelay.DoWork
        Dim process As Process = New Process()
        process.StartInfo.FileName = "sgfgcore-gost3.exe"
        process.StartInfo.Arguments = "-L ss://aes-128-gcm:" & RELAY_PASSWORD_STR & "@0.0.0.0:" & RELAY_PORT_STR & " -F " & PROXY_METHOD_STR & "://127.0.0.1:7788"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.RedirectStandardOutput = True
        process.Start()
        process.StandardOutput.ReadToEnd()
        process.WaitForExit()
        process.Close()
    End Sub

    Private Sub UiButton2_Click(sender As Object, e As EventArgs) Handles UiButton2.Click
        If PROXY_PROTOCOL = "https" Then
            UiLabel2.Text = "传输协议:quic"
            UiButton2.Text = "切换为HTTPS"
            UiButton2.Style = UIStyle.Green
            PROXY_PROTOCOL = "quic"
        ElseIf PROXY_PROTOCOL = "quic" Then
            UiLabel2.Text = "传输协议:https"
            UiButton2.Text = "切换为QUIC"
            UiButton2.Style = UIStyle.Gray
            PROXY_PROTOCOL = "https"
        End If
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PROXY_PROTOCOL = "https"
    End Sub

    Private Sub UiLinkLabel1_Click(sender As Object, e As EventArgs) Handles UiLinkLabel1.Click
        Process.Start("explorer.exe", "https://t.me/sgfangun")
    End Sub
End Class