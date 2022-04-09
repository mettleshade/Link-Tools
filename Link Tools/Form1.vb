Imports System.ComponentModel
Imports System.Text


Partial Public Class Form1
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub BunifuTileButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuTileButton12.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuTileButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuTileButton1.Click
        ayalar.baslik.LabelText = "Link Tools - 1 - Tuş Ayarları"
        Me.Hide()
        ayalar.Show()
    End Sub

    Private Sub BunifuTileButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuTileButton2.Click
        ayalar.baslik.LabelText = "Link Tools - 2 - Tuş Ayarları"
        Me.Hide()
        ayalar.Show()
    End Sub

    Private Sub BunifuTileButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuTileButton3.Click
        ayalar.baslik.LabelText = "Link Tools - 3 - Tuş Ayarları"
        Me.Hide()
        ayalar.Show()
    End Sub

    Private Sub BunifuTileButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuTileButton4.Click
        ayalar.baslik.LabelText = "Link Tools - 4 - Tuş Ayarları"
        Me.Hide()
        ayalar.Show()
    End Sub

    Private Sub BunifuTileButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuTileButton5.Click
        ayalar.baslik.LabelText = "Link Tools - 5 - Tuş Ayarları"
        Me.Hide()
        ayalar.Show()
    End Sub

    Private Sub BunifuTileButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuTileButton11.Click
        ayalar.baslik.LabelText = "Link Tools - 6 - Tuş Ayarları"
        Me.Hide()
        ayalar.Show()
    End Sub

    Private Sub BunifuTileButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuTileButton10.Click
        ayalar.baslik.LabelText = "Link Tools - 7 - Tuş Ayarları"
        Me.Hide()
        ayalar.Show()
    End Sub

    Private Sub BunifuTileButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuTileButton9.Click
        ayalar.baslik.LabelText = "Link Tools - 8 - Tuş Ayarları"
        Me.Hide()
        ayalar.Show()
    End Sub

    Private Sub BunifuTileButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuTileButton8.Click
        ayalar.baslik.LabelText = "Link Tools - 9 - Tuş Ayarları"
        Me.Hide()
        ayalar.Show()
    End Sub

    Private Sub BunifuTileButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuTileButton7.Click
        ayalar.baslik.LabelText = "Link Tools - 10 - Tuş Ayarları"
        Me.Hide()
        ayalar.Show()
    End Sub

    Private Sub BunifuTileButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuTileButton13.Click
        ayarlar2.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BunifuTileButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuTileButton14.Click
        Process.Start("http://www.facebook.com/MettlessDizayn")
        Process.Start("http://www.facebook.com/Metlesshade")
        Process.Start("http://www.mettlessdizayn.tk")
    End Sub

    Private Sub BunifuTileButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuTileButton15.Click
        Process.Start("http://www.facebook.com/Metlesshade")
    End Sub

    Private Sub BunifuTileButton16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuTileButton16.Click
        hakkinda.Show()
    End Sub
End Class
