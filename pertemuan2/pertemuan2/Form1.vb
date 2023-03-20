Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Procedure Function"
        ListView1.GridLines = True
        ListView1.View = View.Details
        ListView1.Columns.Add("Kode Barang")
        ListView1.Columns.Add("Nama Barang")
        ListView1.Columns.Add("Satuan")
        ListView1.Columns.Add("Harga Barang")
        ListView1.Columns.Add("Jumlah")
        ListView1.Columns.Add("Total")

        txtkode.Focus()

        Call Bersih()
    End Sub
    Sub Bersih()
        txtnama.Text = ""
        txtsatuan.Text = ""
        txthsatuan.Text = ""
        txtjumlah.Text = ""
        txttotal.Text = ""

        txtkode.Focus()
        txttotal.Enabled = False
    End Sub

    Private Function Hitung()
        Dim Jumlah, Hsatuan, Total As Integer
        Jumlah = Val(txtjumlah.Text)
        Hsatuan = Val(txthsatuan.Text)
        Total = Jumlah * Hsatuan

        txttotal.Text = Total
        Return Total
    End Function

    Private Function CekDataKosong()
        If txtkode.Text = "" Then
            MessageBox.Show("Kode Barang Wajib Disi !!!", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtkode.Focus()
        ElseIf txtnama.Text = "" Then
            MessageBox.Show("Nama Barang Wajib Disi !!!", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtnama.Focus()
        ElseIf txtsatuan.Text = "" Then
            MessageBox.Show("Satuan Barang Wajib Disi !!!", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtsatuan.Focus()

        ElseIf txthsatuan.Text = "" Then
            MessageBox.Show("Harga Satuan Barang Wajib Disi !!!", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txthsatuan.Focus()
        ElseIf txtjumlah.Text = "" Then
            MessageBox.Show("Jumlah Barang Wajib Disi !!!", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtjumlah.Focus()
        Else
            Return True
        End If

        Return False
    End Function

    Private Sub btnhitung_Click(sender As Object, e As EventArgs) Handles btnhitung.Click
        If CekDataKosong() = True Then
            Dim Arr(6) As String
            Arr(0) = txtkode.Text
            Arr(1) = txtnama.Text
            Arr(2) = txtsatuan.Text
            Arr(3) = txthsatuan.Text
            Arr(4) = txtjumlah.Text
            Arr(5) = Hitung()

            Dim Listitem As ListViewItem
            Listitem = ListView1.Items.Add(Arr(0))
            Listitem.SubItems.Add(Arr(1))
            Listitem.SubItems.Add(Arr(2))
            Listitem.SubItems.Add(Arr(3))
            Listitem.SubItems.Add(Arr(4))
            Listitem.SubItems.Add(Arr(5))

            txtkode.Text = txtkode.Text + 1
            txtkode.Focus()
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Call Bersih()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Dim Tutup As String
        Tutup = MessageBox.Show("Apakah Ingin Keluar ?", "Konfirmasi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Tutup = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub
End Class
