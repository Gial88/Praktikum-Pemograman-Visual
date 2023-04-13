Imports MySql.Data.MySqlClient

Public Class DataBuku
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call TampilJenis()
        Call TampilBuku()
        Call Kosong()
        Call AturGrid()
    End Sub

    Sub Kosong()
        TxtKodeBuku.Clear()
        ComboJenis.Text = ""
        TxtJudul.Clear()
        TxtPenerbit.Clear()
        TxtPengarang.Clear()
        TxtJumlah.Clear()
        TxtHarga.Clear()
        TxtDeskripsi.Clear()
        TxtKodeJenis.Clear()
        TxtKodeBuku.Focus()
    End Sub

    Sub Isi()
        ComboJenis.Text = ""
        TxtJudul.Clear()
        TxtPenerbit.Clear()
        TxtPengarang.Clear()
        TxtJumlah.Clear()
        TxtHarga.Clear()
        TxtDeskripsi.Clear()
        ComboJenis.Focus()
    End Sub
    Sub TampilBuku()
        Call koneksi()
        DA = New MySqlDataAdapter("Select * From tbbuku", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbbuku")
        DataGridView1.DataSource = DS.Tables("tbbuku")
        DataGridView1.Refresh()
    End Sub
    Sub TampilJenis()
        CMD = New MySqlCommand("Select KodeJenis From tbjenis", CONN)
        RD = CMD.ExecuteReader
        Do While RD.Read
            ComboJenis.Items.Add(RD.Item(0))
        Loop
    End Sub
    Sub AturGrid()
        DataGridView1.Columns(0).Width = 60
        DataGridView1.Columns(1).Width = 50
        DataGridView1.Columns(2).Width = 300
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(4).Width = 100
        DataGridView1.Columns(5).Width = 100
        DataGridView1.Columns(6).Width = 100
        DataGridView1.Columns(7).Width = 300

        DataGridView1.Columns(0).HeaderText = "KODE BUKU"
        DataGridView1.Columns(1).HeaderText = "KODE JENIS"
        DataGridView1.Columns(2).HeaderText = "JUDUL"
        DataGridView1.Columns(3).HeaderText = "PENGARANG"
        DataGridView1.Columns(4).HeaderText = "PENERBIT"
        DataGridView1.Columns(5).HeaderText = "JUMLAH"
        DataGridView1.Columns(6).HeaderText = "HARGA"
        DataGridView1.Columns(7).HeaderText = "DESKRIPSI"
    End Sub
    Private Sub ComboJenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboJenis.SelectedIndexChanged
        CMD = New MySqlCommand("Select * from tbjenis where KodeJenis=" & ComboJenis.Text & "", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows = True Then
            TxtKodeJenis.Text = RD.Item(1)
            RD.Close()
        Else
            MsgBox("Kode jenis ini tidak terdaftar")
        End If
    End Sub
    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If TxtKodeBuku.Text = "" Or ComboJenis.Text = "" Or TxtJudul.Text = "" Or
            TxtPengarang.Text = "" Or TxtPenerbit.Text = "" Or TxtJumlah.Text = "" Or TxtHarga.Text = "" Then
            MsgBox("Data belum lengkap")
            TxtKodeBuku.Focus()
            Exit Sub
        Else
            CMD = New MySqlCommand("Select * From tbbuku where KodeBuku=" & TxtKodeBuku.Text & "", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If Not RD.HasRows Then
                RD.Close()
                Dim Simpan As String =
                    "Insert into tbbuku(KodeBuku,KodeJenis,Judul,Pengarang,Penerbit,JumlahBuku,Harga,Deskripsi) values (" &
                    TxtKodeBuku.Text & "," & ComboJenis.Text & ",'" &
                    TxtJudul.Text & "','" & TxtPengarang.Text & "','" &
                    TxtPenerbit.Text & "'," & TxtJumlah.Text & "," &
                    TxtHarga.Text & ",'" & TxtDeskripsi.Text & "')"
                CMD = New MySqlCommand(Simpan, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Simpan data sukses...!", MsgBoxStyle.Information, "Perhatian")
            End If

            'RD.Close()
            Call TampilJenis()
            Call Kosong()
            TxtKodeBuku.Focus()
        End If
    End Sub
End Class