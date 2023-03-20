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
        Me.txtangka1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtangka2 = New System.Windows.Forms.TextBox()
        Me.tambah = New System.Windows.Forms.Button()
        Me.kurang = New System.Windows.Forms.Button()
        Me.kali = New System.Windows.Forms.Button()
        Me.bagi = New System.Windows.Forms.Button()
        Me.txthasil = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.faktorial = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtangka1
        '
        Me.txtangka1.Location = New System.Drawing.Point(267, 45)
        Me.txtangka1.Name = "txtangka1"
        Me.txtangka1.Size = New System.Drawing.Size(220, 26)
        Me.txtangka1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(130, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Angka 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(130, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Angka 2"
        '
        'txtangka2
        '
        Me.txtangka2.Location = New System.Drawing.Point(267, 118)
        Me.txtangka2.Name = "txtangka2"
        Me.txtangka2.Size = New System.Drawing.Size(220, 26)
        Me.txtangka2.TabIndex = 3
        '
        'tambah
        '
        Me.tambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.tambah.Location = New System.Drawing.Point(48, 170)
        Me.tambah.Name = "tambah"
        Me.tambah.Size = New System.Drawing.Size(124, 49)
        Me.tambah.TabIndex = 4
        Me.tambah.Text = "+"
        Me.tambah.UseVisualStyleBackColor = True
        '
        'kurang
        '
        Me.kurang.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.kurang.Location = New System.Drawing.Point(178, 170)
        Me.kurang.Name = "kurang"
        Me.kurang.Size = New System.Drawing.Size(124, 49)
        Me.kurang.TabIndex = 5
        Me.kurang.Text = "-"
        Me.kurang.UseVisualStyleBackColor = True
        '
        'kali
        '
        Me.kali.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.kali.Location = New System.Drawing.Point(308, 170)
        Me.kali.Name = "kali"
        Me.kali.Size = New System.Drawing.Size(124, 49)
        Me.kali.TabIndex = 6
        Me.kali.Text = "*"
        Me.kali.UseVisualStyleBackColor = True
        '
        'bagi
        '
        Me.bagi.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.bagi.Location = New System.Drawing.Point(438, 170)
        Me.bagi.Name = "bagi"
        Me.bagi.Size = New System.Drawing.Size(124, 49)
        Me.bagi.TabIndex = 7
        Me.bagi.Text = "/"
        Me.bagi.UseVisualStyleBackColor = True
        '
        'txthasil
        '
        Me.txthasil.Location = New System.Drawing.Point(267, 256)
        Me.txthasil.Name = "txthasil"
        Me.txthasil.Size = New System.Drawing.Size(220, 26)
        Me.txthasil.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(130, 252)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 29)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Hasil"
        '
        'faktorial
        '
        Me.faktorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.faktorial.Location = New System.Drawing.Point(568, 170)
        Me.faktorial.Name = "faktorial"
        Me.faktorial.Size = New System.Drawing.Size(124, 49)
        Me.faktorial.TabIndex = 10
        Me.faktorial.Text = "!"
        Me.faktorial.UseVisualStyleBackColor = True
        '
        'clear
        '
        Me.clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.clear.Location = New System.Drawing.Point(286, 321)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(186, 77)
        Me.clear.TabIndex = 11
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.faktorial)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txthasil)
        Me.Controls.Add(Me.bagi)
        Me.Controls.Add(Me.kali)
        Me.Controls.Add(Me.kurang)
        Me.Controls.Add(Me.tambah)
        Me.Controls.Add(Me.txtangka2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtangka1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtangka1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtangka2 As TextBox
    Friend WithEvents tambah As Button
    Friend WithEvents kurang As Button
    Friend WithEvents kali As Button
    Friend WithEvents bagi As Button
    Friend WithEvents txthasil As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents faktorial As Button
    Friend WithEvents clear As Button
End Class
