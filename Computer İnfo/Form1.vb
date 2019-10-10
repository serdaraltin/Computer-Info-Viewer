Imports System.Environment
Imports System.Net
Imports System.Text.RegularExpressions
Public Class Form1
    Private Function GetIP() As String
        Dim wc As New WebClient()
        Dim strIP As String = wc.DownloadString("http://checkip.dyndns.org")
        strIP = (New Regex("\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b")).Match(strIP).Value
        wc.Dispose()
        Return strIP
    End Function
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pcadi_text.Text = MachineName.ToString
        user_text.Text = UserName.ToString
        platform_text.Text = OSVersion.ToString
        surum_text.Text = Version.ToString
        Dim myip As System.Net.IPHostEntry = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName)
        localip_text.Text = myip.AddressList.GetValue(0).ToString()
    End Sub
    Private Sub dinamikip_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dinamikip_button.Click
        Try
            dinamikip_text.Text = "İp getiriliyor..."
            dinamikip_text.Text = GetIP().ToString
        Catch ex As Exception
            MessageBox.Show("İnternet hızınızdan dolayı Dinamic İp alınamadı.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
