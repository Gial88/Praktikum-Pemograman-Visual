<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataBuku
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtKodeBuku = New System.Windows.Forms.TextBox()
        Me.TxtDeskripsi = New System.Windows.Forms.TextBox()
        Me.TxtKodeJenis = New System.Windows.Forms.TextBox()
        Me.TxtJudul = New System.Windows.Forms.TextBox()
        Me.TxtPengarang = New System.Windows.Forms.TextBox()
        Me.TxtPenerbit = New System.Windows.Forms.TextBox()
        Me.TxtJumlah = New System.Windows.Forms.TextBox()
        Me.TxtHarga = New System.Windows.Forms.TextBox()
        Me.ComboJenis = New System.Windows.Forms.ComboBox()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnubah = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btntutup = New System.Windows.Forms.Button()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Buku"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Judul"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Pengarang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Penerbit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(71, 323)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jumlah Buku"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(284, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Jenis"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(284, 323)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Harga"
        '
        'TxtKodeBuku
        '
        Me.TxtKodeBuku.Location = New System.Drawing.Point(178, 52)
        Me.TxtKodeBuku.Name = "TxtKodeBuku"
        Me.TxtKodeBuku.Size = New System.Drawing.Size(100, 26)
        Me.TxtKodeBuku.TabIndex = 7
        '
        'TxtDeskripsi
        '
        Me.TxtDeskripsi.Location = New System.Drawing.Point(449, 186)
        Me.TxtDeskripsi.Multiline = True
        Me.TxtDeskripsi.Name = "TxtDeskripsi"
        Me.TxtDeskripsi.Size = New System.Drawing.Size(297, 167)
        Me.TxtDeskripsi.TabIndex = 8
        '
        'TxtKodeJenis
        '
        Me.TxtKodeJenis.Location = New System.Drawing.Point(470, 54)
        Me.TxtKodeJenis.Name = "TxtKodeJenis"
        Me.TxtKodeJenis.Size = New System.Drawing.Size(276, 26)
        Me.TxtKodeJenis.TabIndex = 9
        '
        'TxtJudul
        '
        Me.TxtJudul.Location = New System.Drawing.Point(178, 114)
        Me.TxtJudul.Name = "TxtJudul"
        Me.TxtJudul.Size = New System.Drawing.Size(568, 26)
        Me.TxtJudul.TabIndex = 10
        '
        'TxtPengarang
        '
        Me.TxtPengarang.Location = New System.Drawing.Point(178, 189)
        Me.TxtPengarang.Name = "TxtPengarang"
        Me.TxtPengarang.Size = New System.Drawing.Size(265, 26)
        Me.TxtPengarang.TabIndex = 11
        '
        'TxtPenerbit
        '
        Me.TxtPenerbit.Location = New System.Drawing.Point(178, 258)
        Me.TxtPenerbit.Name = "TxtPenerbit"
        Me.TxtPenerbit.Size = New System.Drawing.Size(265, 26)
        Me.TxtPenerbit.TabIndex = 12
        '
        'TxtJumlah
        '
        Me.TxtJumlah.Location = New System.Drawing.Point(178, 320)
        Me.TxtJumlah.Name = "TxtJumlah"
        Me.TxtJumlah.Size = New System.Drawing.Size(100, 26)
        Me.TxtJumlah.TabIndex = 13
        '
        'TxtHarga
        '
        Me.TxtHarga.Location = New System.Drawing.Point(343, 323)
        Me.TxtHarga.Name = "TxtHarga"
        Me.TxtHarga.Size = New System.Drawing.Size(100, 26)
        Me.TxtHarga.TabIndex = 14
        '
        'ComboJenis
        '
        Me.ComboJenis.FormattingEnabled = True
        Me.ComboJenis.Location = New System.Drawing.Point(343, 52)
        Me.ComboJenis.Name = "ComboJenis"
        Me.ComboJenis.Size = New System.Drawing.Size(121, 28)
        Me.ComboJenis.TabIndex = 15
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(75, 378)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(97, 34)
        Me.btnsimpan.TabIndex = 16
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btnubah
        '
        Me.btnubah.Location = New System.Drawing.Point(217, 378)
        Me.btnubah.Name = "btnubah"
        Me.btnubah.Size = New System.Drawing.Size(97, 34)
        Me.btnubah.TabIndex = 17
        Me.btnubah.Text = "Ubah"
        Me.btnubah.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(367, 378)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(97, 34)
        Me.btnhapus.TabIndex = 18
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnbatal
        '
        Me.btnbatal.Location = New System.Drawing.Point(508, 378)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(97, 34)
        Me.btnbatal.TabIndex = 19
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'btntutup
        '
        Me.btntutup.Location = New System.Drawing.Point(649, 378)
        Me.btntutup.Name = "btntutup"
        Me.btntutup.Size = New System.Drawing.Size(97, 34)
        Me.btntutup.TabIndex = 20
        Me.btntutup.Text = "Tutup"
        Me.btntutup.UseVisualStyleBackColor = True
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(75, 442)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(671, 26)
        Me.txtcari.TabIndex = 21
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(75, 503)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(671, 389)
        Me.DataGridView1.TabIndex = 22
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 918)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.btntutup)
        Me.Controls.Add(Me.btnbatal)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnubah)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.ComboJenis)
        Me.Controls.Add(Me.TxtHarga)
        Me.Controls.Add(Me.TxtJumlah)
        Me.Controls.Add(Me.TxtPenerbit)
        Me.Controls.Add(Me.TxtPengarang)
        Me.Controls.Add(Me.TxtJudul)
        Me.Controls.Add(Me.TxtKodeJenis)
        Me.Controls.Add(Me.TxtDeskripsi)
        Me.Controls.Add(Me.TxtKodeBuku)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Data Buku"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtKodeBuku As TextBox
    Friend WithEvents TxtDeskripsi As TextBox
    Friend WithEvents TxtKodeJenis As TextBox
    Friend WithEvents TxtJudul As TextBox
    Friend WithEvents TxtPengarang As TextBox
    Friend WithEvents TxtPenerbit As TextBox
    Friend WithEvents TxtJumlah As TextBox
    Friend WithEvents TxtHarga As TextBox
    Friend WithEvents ComboJenis As ComboBox
    Friend WithEvents btnsimpan As Button
    Friend WithEvents btnubah As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnbatal As Button
    Friend WithEvents btntutup As Button
    Friend WithEvents txtcari As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
