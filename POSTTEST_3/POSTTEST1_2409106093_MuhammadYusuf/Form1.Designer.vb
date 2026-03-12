<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Nama = New Label()
        btnBrowse = New Button()
        picProfile = New PictureBox()
        Umur = New Label()
        TanggalLahir = New Label()
        NoTelpon = New Label()
        Alamat = New Label()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtNoTelpon = New TextBox()
        txtAlamat = New TextBox()
        grpJenisKelamin = New GroupBox()
        rdoPerempuan = New RadioButton()
        rdoLaki = New RadioButton()
        grpHobby = New GroupBox()
        chkMenggambar = New CheckBox()
        chkBelajar = New CheckBox()
        chkMenari = New CheckBox()
        chkMemancing = New CheckBox()
        chkCoding = New CheckBox()
        chkMenyanyi = New CheckBox()
        chkMembaca = New CheckBox()
        chkBerenang = New CheckBox()
        chkOlahraga = New CheckBox()
        chkGaming = New CheckBox()
        dtpTanggalLahir = New DateTimePicker()
        btnCetak = New Button()
        CType(picProfile, ComponentModel.ISupportInitialize).BeginInit()
        grpJenisKelamin.SuspendLayout()
        grpHobby.SuspendLayout()
        SuspendLayout()
        ' 
        ' Nama
        ' 
        Nama.AutoSize = True
        Nama.Location = New Point(277, 37)
        Nama.Name = "Nama"
        Nama.Size = New Size(49, 20)
        Nama.TabIndex = 0
        Nama.Text = "Nama"
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(66, 399)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(127, 39)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browser"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' picProfile
        ' 
        picProfile.Location = New Point(23, 55)
        picProfile.Name = "picProfile"
        picProfile.Size = New Size(227, 328)
        picProfile.TabIndex = 2
        picProfile.TabStop = False
        ' 
        ' Umur
        ' 
        Umur.AutoSize = True
        Umur.Location = New Point(277, 74)
        Umur.Name = "Umur"
        Umur.Size = New Size(45, 20)
        Umur.TabIndex = 3
        Umur.Text = "Umur"
        ' 
        ' TanggalLahir
        ' 
        TanggalLahir.AutoSize = True
        TanggalLahir.Location = New Point(277, 109)
        TanggalLahir.Name = "TanggalLahir"
        TanggalLahir.Size = New Size(97, 20)
        TanggalLahir.TabIndex = 4
        TanggalLahir.Text = "Tanggal Lahir"
        ' 
        ' NoTelpon
        ' 
        NoTelpon.AutoSize = True
        NoTelpon.Location = New Point(277, 144)
        NoTelpon.Name = "NoTelpon"
        NoTelpon.Size = New Size(89, 20)
        NoTelpon.TabIndex = 5
        NoTelpon.Text = "No. Telepon"
        ' 
        ' Alamat
        ' 
        Alamat.AutoSize = True
        Alamat.Location = New Point(277, 181)
        Alamat.Name = "Alamat"
        Alamat.Size = New Size(57, 20)
        Alamat.TabIndex = 6
        Alamat.Text = "Alamat"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(405, 37)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(250, 27)
        txtNama.TabIndex = 7
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(405, 71)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(250, 27)
        txtUmur.TabIndex = 8
        ' 
        ' txtNoTelpon
        ' 
        txtNoTelpon.Location = New Point(405, 141)
        txtNoTelpon.Name = "txtNoTelpon"
        txtNoTelpon.Size = New Size(250, 27)
        txtNoTelpon.TabIndex = 9
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(405, 178)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(250, 27)
        txtAlamat.TabIndex = 10
        ' 
        ' grpJenisKelamin
        ' 
        grpJenisKelamin.Controls.Add(rdoPerempuan)
        grpJenisKelamin.Controls.Add(rdoLaki)
        grpJenisKelamin.Location = New Point(276, 203)
        grpJenisKelamin.Name = "grpJenisKelamin"
        grpJenisKelamin.Size = New Size(232, 189)
        grpJenisKelamin.TabIndex = 11
        grpJenisKelamin.TabStop = False
        grpJenisKelamin.Text = "Jenis Kelamin"
        ' 
        ' rdoPerempuan
        ' 
        rdoPerempuan.AutoSize = True
        rdoPerempuan.Location = New Point(19, 75)
        rdoPerempuan.Name = "rdoPerempuan"
        rdoPerempuan.Size = New Size(104, 24)
        rdoPerempuan.TabIndex = 1
        rdoPerempuan.TabStop = True
        rdoPerempuan.Text = "Perempuan"
        rdoPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rdoLaki
        ' 
        rdoLaki.AutoSize = True
        rdoLaki.Location = New Point(19, 35)
        rdoLaki.Name = "rdoLaki"
        rdoLaki.Size = New Size(96, 24)
        rdoLaki.TabIndex = 0
        rdoLaki.TabStop = True
        rdoLaki.Text = "Laki - Laki"
        rdoLaki.UseVisualStyleBackColor = True
        ' 
        ' grpHobby
        ' 
        grpHobby.Controls.Add(chkMenggambar)
        grpHobby.Controls.Add(chkBelajar)
        grpHobby.Controls.Add(chkMenari)
        grpHobby.Controls.Add(chkMemancing)
        grpHobby.Controls.Add(chkCoding)
        grpHobby.Controls.Add(chkMenyanyi)
        grpHobby.Controls.Add(chkMembaca)
        grpHobby.Controls.Add(chkBerenang)
        grpHobby.Controls.Add(chkOlahraga)
        grpHobby.Controls.Add(chkGaming)
        grpHobby.Location = New Point(531, 203)
        grpHobby.Name = "grpHobby"
        grpHobby.Size = New Size(247, 189)
        grpHobby.TabIndex = 12
        grpHobby.TabStop = False
        grpHobby.Text = "Hobby"
        ' 
        ' chkMenggambar
        ' 
        chkMenggambar.AutoSize = True
        chkMenggambar.Location = New Point(125, 155)
        chkMenggambar.Name = "chkMenggambar"
        chkMenggambar.Size = New Size(121, 24)
        chkMenggambar.TabIndex = 9
        chkMenggambar.Text = "Menggambar"
        chkMenggambar.UseVisualStyleBackColor = True
        ' 
        ' chkBelajar
        ' 
        chkBelajar.AutoSize = True
        chkBelajar.Location = New Point(125, 125)
        chkBelajar.Name = "chkBelajar"
        chkBelajar.Size = New Size(77, 24)
        chkBelajar.TabIndex = 8
        chkBelajar.Text = "Belajar"
        chkBelajar.UseVisualStyleBackColor = True
        ' 
        ' chkMenari
        ' 
        chkMenari.AutoSize = True
        chkMenari.Location = New Point(18, 156)
        chkMenari.Name = "chkMenari"
        chkMenari.Size = New Size(77, 24)
        chkMenari.TabIndex = 4
        chkMenari.Text = "Menari"
        chkMenari.UseVisualStyleBackColor = True
        ' 
        ' chkMemancing
        ' 
        chkMemancing.AutoSize = True
        chkMemancing.Location = New Point(125, 95)
        chkMemancing.Name = "chkMemancing"
        chkMemancing.Size = New Size(109, 24)
        chkMemancing.TabIndex = 7
        chkMemancing.Text = "Memancing"
        chkMemancing.UseVisualStyleBackColor = True
        ' 
        ' chkCoding
        ' 
        chkCoding.AutoSize = True
        chkCoding.Location = New Point(125, 65)
        chkCoding.Name = "chkCoding"
        chkCoding.Size = New Size(79, 24)
        chkCoding.TabIndex = 6
        chkCoding.Text = "Coding"
        chkCoding.UseVisualStyleBackColor = True
        ' 
        ' chkMenyanyi
        ' 
        chkMenyanyi.AutoSize = True
        chkMenyanyi.Location = New Point(125, 35)
        chkMenyanyi.Name = "chkMenyanyi"
        chkMenyanyi.Size = New Size(94, 24)
        chkMenyanyi.TabIndex = 5
        chkMenyanyi.Text = "Menyanyi"
        chkMenyanyi.UseVisualStyleBackColor = True
        ' 
        ' chkMembaca
        ' 
        chkMembaca.AutoSize = True
        chkMembaca.Location = New Point(18, 125)
        chkMembaca.Name = "chkMembaca"
        chkMembaca.Size = New Size(97, 24)
        chkMembaca.TabIndex = 3
        chkMembaca.Text = "Membaca"
        chkMembaca.UseVisualStyleBackColor = True
        ' 
        ' chkBerenang
        ' 
        chkBerenang.AutoSize = True
        chkBerenang.Location = New Point(18, 95)
        chkBerenang.Name = "chkBerenang"
        chkBerenang.Size = New Size(94, 24)
        chkBerenang.TabIndex = 2
        chkBerenang.Text = "Berenang"
        chkBerenang.UseVisualStyleBackColor = True
        ' 
        ' chkOlahraga
        ' 
        chkOlahraga.AutoSize = True
        chkOlahraga.Location = New Point(18, 65)
        chkOlahraga.Name = "chkOlahraga"
        chkOlahraga.Size = New Size(92, 24)
        chkOlahraga.TabIndex = 1
        chkOlahraga.Text = "Olahraga"
        chkOlahraga.UseVisualStyleBackColor = True
        ' 
        ' chkGaming
        ' 
        chkGaming.AutoSize = True
        chkGaming.Location = New Point(18, 36)
        chkGaming.Name = "chkGaming"
        chkGaming.Size = New Size(83, 24)
        chkGaming.TabIndex = 0
        chkGaming.Text = "Gaming"
        chkGaming.UseVisualStyleBackColor = True
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.Location = New Point(405, 108)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(250, 27)
        dtpTanggalLahir.TabIndex = 13
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(276, 399)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(502, 39)
        btnCetak.TabIndex = 14
        btnCetak.Text = "Cetak kartu"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCetak)
        Controls.Add(dtpTanggalLahir)
        Controls.Add(grpHobby)
        Controls.Add(grpJenisKelamin)
        Controls.Add(txtAlamat)
        Controls.Add(txtNoTelpon)
        Controls.Add(txtUmur)
        Controls.Add(txtNama)
        Controls.Add(Alamat)
        Controls.Add(NoTelpon)
        Controls.Add(TanggalLahir)
        Controls.Add(Umur)
        Controls.Add(picProfile)
        Controls.Add(btnBrowse)
        Controls.Add(Nama)
        Name = "Form1"
        Text = "Form1"
        CType(picProfile, ComponentModel.ISupportInitialize).EndInit()
        grpJenisKelamin.ResumeLayout(False)
        grpJenisKelamin.PerformLayout()
        grpHobby.ResumeLayout(False)
        grpHobby.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Nama As Label
    Friend WithEvents btnBrowse As Button
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents Umur As Label
    Friend WithEvents TanggalLahir As Label
    Friend WithEvents NoTelpon As Label
    Friend WithEvents Alamat As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtNoTelpon As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents grpJenisKelamin As GroupBox
    Friend WithEvents grpHobby As GroupBox
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents rdoPerempuan As RadioButton
    Friend WithEvents rdoLaki As RadioButton
    Friend WithEvents chkMenggambar As CheckBox
    Friend WithEvents chkBelajar As CheckBox
    Friend WithEvents chkMemancing As CheckBox
    Friend WithEvents chkCoding As CheckBox
    Friend WithEvents chkMenyanyi As CheckBox
    Friend WithEvents chkMenari As CheckBox
    Friend WithEvents chkMembaca As CheckBox
    Friend WithEvents chkBerenang As CheckBox
    Friend WithEvents chkOlahraga As CheckBox
    Friend WithEvents chkGaming As CheckBox
    Friend WithEvents btnCetak As Button

End Class
