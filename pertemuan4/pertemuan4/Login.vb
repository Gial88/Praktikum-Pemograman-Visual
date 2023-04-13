Imports MySql.Data.MySqlClient
Public Class Login
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Call koneksi()
        CMD = New MySqlCommand("Select NamaUser,PasswordUser,StatusUser from tbakun where NamaUser='" &
                               TxtUname.Text & "' and PasswordUser='" &
                               TxtPass.Text = "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Me.Visible = False
            FMenu.Show()
            FMenu.ToolStripStatusLabel1.Text = RD.GetString(0)
            FMenu.ToolStripStatusLabel2.Text = RD.GetString(1)
            FMenu.ToolStripStatusLabel3.Text = RD.GetString(2)
            If FMenu.ToolStripStatusLabel3.Text <> "admin" Then
                FMenu.AkunToolStripMenuItem.Enabled = False
            Else
                FMenu.AkunToolStripMenuItem.Enabled = True
            End If
        Else
            MsgBox("Login salah, periksa kembali nama user dan password anda")
            TxtUname.Focus()
        End If
    End Sub

    Private Sub TxtUname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUname.KeyPress
        If e.KeyChar = Chr(13) Then TxtPass.Focus()
    End Sub

    Private Sub TxtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPass.KeyPress
        If e.KeyChar = Chr(13) Then BtnLogin.Focus()
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        TxtUname.Clear()
        TxtPass.Clear()
    End Sub

End Class