Imports Microsoft.Win32

Public Class ayarlar2


    Private Sub BunifuFlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton1.Click
        If MsgBox("Bütün Tuş Ayarları Sıfırlansınmı ?", MsgBoxStyle.YesNo, "Dikkat") = MsgBoxResult.Yes Then
            My.Settings.t1adi = "Tuş Adı"
            My.Settings.t1link = "Gidilecek Link"
            My.Settings.p1gizli = False

            My.Settings.t2adi = "Tuş Adı"
            My.Settings.t2link = "Gidilecek Link"
            My.Settings.p2gizli = False

            My.Settings.t3adi = "Tuş Adı"
            My.Settings.t3link = "Gidilecek Link"
            My.Settings.p3gizli = False

            My.Settings.t4adi = "Tuş Adı"
            My.Settings.t4link = "Gidilecek Link"
            My.Settings.p4gizli = False

            My.Settings.t5adi = "Tuş Adı"
            My.Settings.t5link = "Gidilecek Link"
            My.Settings.p5gizli = False

            My.Settings.t6adi = "Tuş Adı"
            My.Settings.t6link = "Gidilecek Link"
            My.Settings.p6gizli = False

            My.Settings.t7adi = "Tuş Adı"
            My.Settings.t7link = "Gidilecek Link"
            My.Settings.p7gizli = False

            My.Settings.t8adi = "Tuş Adı"
            My.Settings.t8link = "Gidilecek Link"
            My.Settings.p8gizli = False

            My.Settings.t9adi = "Tuş Adı"
            My.Settings.t9link = "Gidilecek Link"
            My.Settings.p9gizli = False

            My.Settings.t10adi = "Tuş Adı"
            My.Settings.t10link = "Gidilecek Link"
            My.Settings.p10gizli = False
            My.Settings.Save()
        Else
        End If

    End Sub

    Private Sub BunifuDropdown1_onItemSelected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuDropdown1.onItemSelected
        My.Settings.konum = BunifuDropdown1.selectedValue
        My.Settings.Save()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub acilisaekle(ByVal name As String, ByVal path As String)
        Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)
        key.SetValue(name, path)
    End Sub

    Private Sub acilistankaldir(ByVal name As String)
        Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)
        key.DeleteValue(name, False)
    End Sub

    Private Sub ToggleSwitch1_Toggled(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToggleSwitch1.Toggled
        If ToggleSwitch1.IsOn = True Then
            My.Settings.ac = True
            My.Settings.Save()
            acilisaekle("StartupExample", System.Reflection.Assembly.GetEntryAssembly.Location)
            MsgBox("Uygulama Başlangıca Eklendi", MsgBoxStyle.Information)
        Else
            My.Settings.ac = False
            My.Settings.Save()
            acilistankaldir("StartupExample")
            MsgBox("Uygulama Başlangıçtan Kaldırıldı!", MsgBoxStyle.Information)

        End If
    End Sub

    Private Sub ayarlar2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToggleSwitch1.IsOn = My.Settings.ac
    End Sub
End Class