Public Class Form2

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Form1.Close()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If My.Settings.konum = "Sol Alt" Then
                Me.Location = New Point(0, My.Computer.Screen.WorkingArea.Height - Me.Height)
            End If


            If My.Settings.konum = "Sağ Alt" Then
                Me.Location = New Point(My.Computer.Screen.WorkingArea.Width - Me.Width, My.Computer.Screen.WorkingArea.Height - Me.Height)
            End If

            If My.Settings.p1gizli = True Then
                p1.Visible = True
                t1.Text = My.Settings.t1adi
            End If

            If My.Settings.p2gizli = True Then
                p2.Visible = True
                t2.Text = My.Settings.t2adi

            End If
            If My.Settings.p3gizli = True Then
                p3.Visible = True
                t3.Text = My.Settings.t3adi

            End If
            If My.Settings.p4gizli = True Then
                p4.Visible = True
                t4.Text = My.Settings.t4adi

            End If
            If My.Settings.p5gizli = True Then
                p5.Visible = True
                t5.Text = My.Settings.t5adi

            End If
            If My.Settings.p6gizli = True Then
                p6.Visible = True
                t6.Text = My.Settings.t6adi

            End If
            If My.Settings.p7gizli = True Then
                p7.Visible = True
                t7.Text = My.Settings.t7adi

            End If
            If My.Settings.p8gizli = True Then
                p8.Visible = True
                t8.Text = My.Settings.t8adi

            End If
            If My.Settings.p9gizli = True Then
                p9.Visible = True
                t9.Text = My.Settings.t9adi

            End If
            If My.Settings.p10gizli = True Then
                p10.Visible = True
                t10.Text = My.Settings.t10adi

            End If
        Catch ex As Exception
            MsgBox(ex.Message & "İşlem Başarısız. Lütfen üreticiye başvurun.", MsgBoxStyle.Critical, "Hata !")
        End Try
    
        
    End Sub

    Private Sub t1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t1.Click
        Try
            Process.Start(My.Settings.t1link)
        Catch ex As Exception
            MsgBox("Lütfen geçerli bir adres girin !", MsgBoxStyle.Critical, "Hata !")
        End Try

    End Sub

    Private Sub t2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t2.Click
        Try
            Process.Start(My.Settings.t2link)
        Catch ex As Exception
            MsgBox("Lütfen geçerli bir adres girin !", MsgBoxStyle.Critical, "Hata !")
        End Try

    End Sub

    Private Sub t3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t3.Click
        Try
            Process.Start(My.Settings.t3link)
        Catch ex As Exception
            MsgBox("Lütfen geçerli bir adres girin !", MsgBoxStyle.Critical, "Hata !")
        End Try

    End Sub

    Private Sub t4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t4.Click
        Try
            Process.Start(My.Settings.t4link)
        Catch ex As Exception
            MsgBox("Lütfen geçerli bir adres girin !", MsgBoxStyle.Critical, "Hata !")
        End Try

    End Sub

    Private Sub t5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t5.Click
        Try
            Process.Start(My.Settings.t5link)
        Catch ex As Exception
            MsgBox("Lütfen geçerli bir adres girin !", MsgBoxStyle.Critical, "Hata !")
        End Try

    End Sub

    Private Sub t6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t6.Click
        Try
            Process.Start(My.Settings.t6link)
        Catch ex As Exception
            MsgBox("Lütfen geçerli bir adres girin !", MsgBoxStyle.Critical, "Hata !")
        End Try

    End Sub

    Private Sub t7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t7.Click
        Try
            Process.Start(My.Settings.t7link)
        Catch ex As Exception
            MsgBox("Lütfen geçerli bir adres girin !", MsgBoxStyle.Critical, "Hata !")
        End Try

    End Sub

    Private Sub t8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t8.Click
        Try
            Process.Start(My.Settings.t8link)
        Catch ex As Exception
            MsgBox("Lütfen geçerli bir adres girin !", MsgBoxStyle.Critical, "Hata !")
        End Try

    End Sub

    Private Sub t9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t9.Click
        Try
            Process.Start(My.Settings.t9link)
        Catch ex As Exception
            MsgBox("Lütfen geçerli bir adres girin !", MsgBoxStyle.Critical, "Hata !")
        End Try

    End Sub

    Private Sub t10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t10.Click
        Try
            Process.Start(My.Settings.t10link)
        Catch ex As Exception
            MsgBox("Lütfen geçerli bir adres girin !", MsgBoxStyle.Critical, "Hata !")
        End Try

    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Try
            If SimpleButton3.Text = "Tuşları Gizle" Then
                If My.Settings.p1gizli = True Then
                    p1.Visible = False
                End If

                If My.Settings.p2gizli = True Then
                    p2.Visible = False
                End If

                If My.Settings.p3gizli = True Then
                    p3.Visible = False
                End If

                If My.Settings.p4gizli = True Then
                    p4.Visible = False
                End If

                If My.Settings.p5gizli = True Then
                    p5.Visible = False
                End If

                If My.Settings.p6gizli = True Then
                    p6.Visible = False
                End If

                If My.Settings.p7gizli = True Then
                    p7.Visible = False
                End If

                If My.Settings.p8gizli = True Then
                    p8.Visible = False
                End If

                If My.Settings.p9gizli = True Then
                    p9.Visible = False
                End If

                If My.Settings.p10gizli = True Then
                    p10.Visible = False
                End If

                SimpleButton3.Text = "Tuşları Göster"
            Else
                If My.Settings.p1gizli = True Then
                    p1.Visible = True
                End If

                If My.Settings.p2gizli = True Then
                    p2.Visible = True
                End If

                If My.Settings.p3gizli = True Then
                    p3.Visible = True
                End If

                If My.Settings.p4gizli = True Then
                    p4.Visible = True
                End If

                If My.Settings.p5gizli = True Then
                    p5.Visible = True
                End If

                If My.Settings.p6gizli = True Then
                    p6.Visible = True
                End If

                If My.Settings.p7gizli = True Then
                    p7.Visible = True
                End If

                If My.Settings.p8gizli = True Then
                    p8.Visible = True
                End If

                If My.Settings.p9gizli = True Then
                    p9.Visible = True
                End If

                If My.Settings.p10gizli = True Then
                    p10.Visible = True
                End If

                SimpleButton3.Text = "Tuşları Gizle"
            End If
        Catch ex As Exception
            MsgBox("İşlem Başarısız. Lütfen üreticiye başvurun.", MsgBoxStyle.Critical, "Hata !")
        End Try
        

        

    End Sub
End Class