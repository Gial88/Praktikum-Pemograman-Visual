Imports MySql.Data.MySqlClient
Public Class Form1
    Sub Kosong()
        txtKode.Clear()
        txtJenis.Clear()
        txtCari.Clear()
    End Sub

    Sub isi()
        txtJenis.Clear()
        txtJenis.Focus()
    End Sub

    Sub TampilJenis()
        DA = New MySqlDataAdapter("SELECT * FROM tbjenis", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "Jenis")
        DataGridView1.DataSource = DS.Tables("Jenis")
        DataGridView1.Refresh()
    End Sub

    Sub AturGrid()
        DataGridView1.Columns(0).Width = 60
        DataGridView1.Columns(1).Width = 200
        DataGridView1.Columns(0).HeaderText = "Kode Jenis"
        DataGridView1.Columns(1).HeaderText = "Nama Jenis"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call TampilJenis()
        Call Kosong()
        Call AturGrid()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtKode.Text = "" Or txtJenis.Text = "" Then
            MsgBox("Data Belum Lengkap")
            txtKode.Focus()
            Exit Sub
        Else
            CMD = New MySqlCommand("Select * FROM tbjenis WHERE kodeJenis=" & txtKode.Text & "", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If Not RD.HasRows Then
                RD.Close()
                Dim Simpan As String = "Insert Into tbjenis values (" & txtKode.Text & ",'" & txtJenis.Text & "' )"
                CMD = New MySqlCommand(Simpan, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil Di Simpan", MsgBoxStyle.Information, "Perhatian")
            Else
                MsgBox("Kode Sudah digunakan")
                RD.Close()
            End If
            Call TampilJenis()
            Call Kosong()
            txtKode.Focus()
        End If
    End Sub
End Class
