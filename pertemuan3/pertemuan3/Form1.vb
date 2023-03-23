Public Class Form1
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        BukaFile.Filter = "*.jpg|"
        BukaFile.ShowDialog()
        profilePicture.ImageLocation = BukaFile.FileName
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim Nama, JK, Prodi, Hobi As String
        Dim Nim As Integer
        Dim Tanggal As Date

        Nama = txtNama.Text
        Nim = txtNim.Text

        If btnCowok.Checked Then
            JK = btnCowok.Text
        Else
            JK = btnCewek.Text
        End If

        Tanggal = pickDate.Text
        Prodi = comboProdi.Text
        Hobi = ""

        txtHasil.Text = ""

        If boxMakan.Checked = True Then
            Hobi = Hobi & boxMakan.Text & vbCrLf
        End If

        If boxTidur.Checked = True Then
            Hobi = Hobi & boxTidur.Text & vbCrLf
        End If

        If boxJalan.Checked = True Then
            Hobi = Hobi & boxJalan.Text & vbCrLf
        End If

        txtHasil.Text = "Nama      : " & Nama & vbCrLf &
                        "NIM       : " & Nim & vbCrLf &
                        "JK        : " & JK & vbCrLf &
                        "Tgl Lahir : " & Tanggal & vbCrLf &
                        "Prodi     : " & Prodi & vbCrLf &
                        "Hobi      : " & vbCrLf & Hobi
    End Sub
End Class
