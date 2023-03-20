Public Class Form1
    Dim angka1, angka2, hasil As Double
    Private Sub tambah_Click(sender As Object, e As EventArgs) Handles tambah.Click

        angka1 = Val(txtangka1.Text)
        angka2 = Val(txtangka2.Text)

        hasil = angka1 + angka2

        txthasil.Text = hasil
    End Sub

    Private Sub kurang_Click(sender As Object, e As EventArgs) Handles kurang.Click
        'Code By 096'
        angka1 = Val(txtangka1.Text)
        angka2 = Val(txtangka2.Text)

        hasil = angka1 - angka2

        txthasil.Text = hasil
    End Sub

    Private Sub kali_Click(sender As Object, e As EventArgs) Handles kali.Click
        angka1 = Val(txtangka1.Text)
        angka2 = Val(txtangka2.Text)

        hasil = angka1 * angka2

        txthasil.Text = hasil
    End Sub

    Private Sub bagi_Click(sender As Object, e As EventArgs) Handles bagi.Click
        angka1 = Val(txtangka1.Text)
        angka2 = Val(txtangka2.Text)

        hasil = angka1 / angka2

        txthasil.Text = hasil
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles faktorial.Click
        Dim i, f, n, hasil As Integer
        'Code By 096'
        'f = Val(txtangka1.Text)
        'n = 
        'For i = 1 To n
        'f = f * i
        'Next
        'txthasil.Text = f

        'Code By 94
        'i = 1
        'Do While f > 0
        '   i = i * f
        'f = f - 1
        'Loop
        'txthasil.Text = i

        'Code By 90
        i = 1
        f = Val(txtangka1.Text)
        Do
            i = i * f
            f = f - 1
        Loop Until f < 2
        txthasil.Text = i

    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        'Code by 105'
        txtangka1.Text = " "
        txtangka2.Text = " "
        txthasil.Text = " "
    End Sub
End Class
