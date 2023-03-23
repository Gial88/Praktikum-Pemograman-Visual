<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtNim = New System.Windows.Forms.TextBox()
        Me.pilihan = New System.Windows.Forms.GroupBox()
        Me.btnCowok = New System.Windows.Forms.RadioButton()
        Me.btnCewek = New System.Windows.Forms.RadioButton()
        Me.pickDate = New System.Windows.Forms.DateTimePicker()
        Me.comboProdi = New System.Windows.Forms.ComboBox()
        Me.boxMakan = New System.Windows.Forms.CheckBox()
        Me.boxJalan = New System.Windows.Forms.CheckBox()
        Me.boxTidur = New System.Windows.Forms.CheckBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.txtHasil = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.profilePicture = New System.Windows.Forms.PictureBox()
        Me.BukaFile = New System.Windows.Forms.OpenFileDialog()
        Me.pilihan.SuspendLayout()
        CType(Me.profilePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(268, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Mahasiswa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NIM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Gender"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 364)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tanggal Lahir"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 420)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Prodi"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 474)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Hobi"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(158, 104)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(297, 26)
        Me.txtNama.TabIndex = 7
        '
        'txtNim
        '
        Me.txtNim.Location = New System.Drawing.Point(158, 166)
        Me.txtNim.Name = "txtNim"
        Me.txtNim.Size = New System.Drawing.Size(297, 26)
        Me.txtNim.TabIndex = 8
        '
        'pilihan
        '
        Me.pilihan.Controls.Add(Me.btnCewek)
        Me.pilihan.Controls.Add(Me.btnCowok)
        Me.pilihan.Location = New System.Drawing.Point(158, 223)
        Me.pilihan.Name = "pilihan"
        Me.pilihan.Size = New System.Drawing.Size(333, 100)
        Me.pilihan.TabIndex = 10
        Me.pilihan.TabStop = False
        Me.pilihan.Text = "Pilihan"
        '
        'btnCowok
        '
        Me.btnCowok.AutoSize = True
        Me.btnCowok.Location = New System.Drawing.Point(26, 46)
        Me.btnCowok.Name = "btnCowok"
        Me.btnCowok.Size = New System.Drawing.Size(105, 24)
        Me.btnCowok.TabIndex = 0
        Me.btnCowok.TabStop = True
        Me.btnCowok.Text = "Laki - Laki"
        Me.btnCowok.UseVisualStyleBackColor = True
        '
        'btnCewek
        '
        Me.btnCewek.AutoSize = True
        Me.btnCewek.Location = New System.Drawing.Point(181, 46)
        Me.btnCewek.Name = "btnCewek"
        Me.btnCewek.Size = New System.Drawing.Size(116, 24)
        Me.btnCewek.TabIndex = 1
        Me.btnCewek.TabStop = True
        Me.btnCewek.Text = "Perempuan"
        Me.btnCewek.UseVisualStyleBackColor = True
        '
        'pickDate
        '
        Me.pickDate.Location = New System.Drawing.Point(158, 364)
        Me.pickDate.Name = "pickDate"
        Me.pickDate.Size = New System.Drawing.Size(297, 26)
        Me.pickDate.TabIndex = 11
        '
        'comboProdi
        '
        Me.comboProdi.FormattingEnabled = True
        Me.comboProdi.Items.AddRange(New Object() {"Informatika", "Sistem Informasi", "Teknologi Informasi"})
        Me.comboProdi.Location = New System.Drawing.Point(158, 420)
        Me.comboProdi.Name = "comboProdi"
        Me.comboProdi.Size = New System.Drawing.Size(297, 28)
        Me.comboProdi.TabIndex = 12
        '
        'boxMakan
        '
        Me.boxMakan.AutoSize = True
        Me.boxMakan.Location = New System.Drawing.Point(158, 469)
        Me.boxMakan.Name = "boxMakan"
        Me.boxMakan.Size = New System.Drawing.Size(83, 24)
        Me.boxMakan.TabIndex = 13
        Me.boxMakan.Text = "Makan"
        Me.boxMakan.UseVisualStyleBackColor = True
        '
        'boxJalan
        '
        Me.boxJalan.AutoSize = True
        Me.boxJalan.Location = New System.Drawing.Point(158, 529)
        Me.boxJalan.Name = "boxJalan"
        Me.boxJalan.Size = New System.Drawing.Size(73, 24)
        Me.boxJalan.TabIndex = 14
        Me.boxJalan.Text = "Jalan"
        Me.boxJalan.UseVisualStyleBackColor = True
        '
        'boxTidur
        '
        Me.boxTidur.AutoSize = True
        Me.boxTidur.Location = New System.Drawing.Point(158, 499)
        Me.boxTidur.Name = "boxTidur"
        Me.boxTidur.Size = New System.Drawing.Size(70, 24)
        Me.boxTidur.TabIndex = 15
        Me.boxTidur.Text = "Tidur"
        Me.boxTidur.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(444, 547)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(109, 47)
        Me.btnTambah.TabIndex = 16
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'txtHasil
        '
        Me.txtHasil.Location = New System.Drawing.Point(590, 223)
        Me.txtHasil.Multiline = True
        Me.txtHasil.Name = "txtHasil"
        Me.txtHasil.Size = New System.Drawing.Size(520, 371)
        Me.txtHasil.TabIndex = 17
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(590, 104)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(108, 37)
        Me.btnBrowse.TabIndex = 18
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'profilePicture
        '
        Me.profilePicture.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.profilePicture.Location = New System.Drawing.Point(730, 17)
        Me.profilePicture.Name = "profilePicture"
        Me.profilePicture.Size = New System.Drawing.Size(200, 200)
        Me.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.profilePicture.TabIndex = 19
        Me.profilePicture.TabStop = False
        '
        'BukaFile
        '
        Me.BukaFile.FileName = "Buka File"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1122, 629)
        Me.Controls.Add(Me.profilePicture)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtHasil)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.boxTidur)
        Me.Controls.Add(Me.boxJalan)
        Me.Controls.Add(Me.boxMakan)
        Me.Controls.Add(Me.comboProdi)
        Me.Controls.Add(Me.pickDate)
        Me.Controls.Add(Me.pilihan)
        Me.Controls.Add(Me.txtNim)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.pilihan.ResumeLayout(False)
        Me.pilihan.PerformLayout()
        CType(Me.profilePicture, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNim As TextBox
    Friend WithEvents pilihan As GroupBox
    Friend WithEvents btnCowok As RadioButton
    Friend WithEvents btnCewek As RadioButton
    Friend WithEvents pickDate As DateTimePicker
    Friend WithEvents comboProdi As ComboBox
    Friend WithEvents boxMakan As CheckBox
    Friend WithEvents boxJalan As CheckBox
    Friend WithEvents boxTidur As CheckBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtHasil As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents profilePicture As PictureBox
    Friend WithEvents BukaFile As OpenFileDialog
End Class
