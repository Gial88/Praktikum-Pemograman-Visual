Imports MySql.Data.MySqlClient
Public Class DataJenis
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

    Private Sub txtJenis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJenis.KeyPress
        txtJenis.MaxLength = 50
        If e.KeyChar = Chr(13) Then
            txtJenis.Text = UCase(txtJenis.Text)
        End If
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = Me.DataGridView1.CurrentRow.Index
        With DataGridView1.Rows.Item(i)
            Me.txtKode.Text = .Cells(0).Value
            Me.txtJenis.Text = .Cells(1).Value
        End With
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If txtKode.Text = "" Then
            MsgBox("Kode Jenis Belum diisi")
            txtKode.Focus()
        Else
            Dim ubah As String = "UPDATE tbjenis Set kodeJenis = " & txtKode.Text & ", namaJenis = '" & txtJenis.Text & "'
                WHERE kodeJenis = " & txtKode.Text & ""
            CMD = New MySqlCommand(ubah, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call TampilJenis()
            Call Kosong()
            txtKode.Focus()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtKode.Text = "" Then
            MsgBox("Kode Jenis Belum diisi")
            txtKode.Focus()
        Else
            If MessageBox.Show("Apakah Akan menghapus Data Jenis " & txtKode.Text & " ? ",
                               "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim hapus As String = "DELETE FROM tbjenis where kodeJenis = " & txtKode.Text & ""
                CMD = New MySqlCommand(hapus, CONN)
                CMD.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call TampilJenis()
                Call Kosong()
            Else
                Call Kosong()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Call Kosong()
    End Sub

    Private Sub txtKode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKode.KeyPress
        txtKode.MaxLength = 2
        If e.KeyChar = Chr(13) Then
            CMD = New MySqlCommand("Select * FROM tbjenis WHERE kodeJenis=" & txtKode.Text & "", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows = True Then
                txtJenis.Text = RD.Item(1)
                txtJenis.Focus()
            Else
                Call isi()
                txtJenis.Focus()
            End If
            RD.Close()
        End If
    End Sub

    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        If e.KeyChar = Chr(13) Then
            CMD = New MySqlCommand("Select * FROM tbjenis WHERE kodeJenis LIKE '%" & txtCari.Text & "%'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows = True Then
                RD.Close()
                DA = New MySqlDataAdapter("Select * FROM tbjenis WHERE kodeJenis LIKE '%" & txtCari.Text & "%'", CONN)
                DS = New DataSet
                DS.Clear()
                DA.Fill(DS, "Dapat")
                DataGridView1.DataSource = DS.Tables("Dapat")
                DataGridView1.ReadOnly = True
            Else
                RD.Close()
                MsgBox("Data Tidak dapat ditemukan")
            End If
        End If
    End Sub
End Class
