Partial Class FormInput
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInput))
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtNoHP = New TextBox()
        txtAlamat = New TextBox()
        rbLaki = New RadioButton()
        rbPerempuan = New RadioButton()
        cbMusik = New CheckBox()
        cbOlahraga = New CheckBox()
        cbGame = New CheckBox()
        pbFoto = New PictureBox()
        btnUpload = New Button()
        btnCetak = New Button()
        cbBerenang = New CheckBox()
        cbmancing = New CheckBox()
        cbMelukis = New CheckBox()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        CType(pbFoto, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(27, 224)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Nama"
        txtNama.Size = New Size(214, 27)
        txtNama.TabIndex = 0
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(27, 264)
        txtUmur.Name = "txtUmur"
        txtUmur.PlaceholderText = "Umur"
        txtUmur.Size = New Size(214, 27)
        txtUmur.TabIndex = 1
        ' 
        ' txtNoHP
        ' 
        txtNoHP.Location = New Point(27, 304)
        txtNoHP.Name = "txtNoHP"
        txtNoHP.PlaceholderText = "No HP"
        txtNoHP.Size = New Size(214, 27)
        txtNoHP.TabIndex = 2
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(27, 344)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.PlaceholderText = "Alamat"
        txtAlamat.Size = New Size(214, 27)
        txtAlamat.TabIndex = 3
        ' 
        ' rbLaki
        ' 
        rbLaki.Location = New Point(27, 384)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(104, 24)
        rbLaki.TabIndex = 4
        rbLaki.Text = "Laki-laki"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.Location = New Point(27, 414)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(104, 24)
        rbPerempuan.TabIndex = 5
        rbPerempuan.Text = "Perempuan"
        ' 
        ' cbMusik
        ' 
        cbMusik.Location = New Point(462, 227)
        cbMusik.Name = "cbMusik"
        cbMusik.Size = New Size(104, 24)
        cbMusik.TabIndex = 6
        cbMusik.Text = "Musik"
        ' 
        ' cbOlahraga
        ' 
        cbOlahraga.Location = New Point(572, 227)
        cbOlahraga.Name = "cbOlahraga"
        cbOlahraga.Size = New Size(104, 24)
        cbOlahraga.TabIndex = 7
        cbOlahraga.Text = "Olahraga"
        ' 
        ' cbGame
        ' 
        cbGame.Location = New Point(691, 227)
        cbGame.Name = "cbGame"
        cbGame.Size = New Size(104, 24)
        cbGame.TabIndex = 8
        cbGame.Text = "Game"
        ' 
        ' pbFoto
        ' 
        pbFoto.Location = New Point(294, 224)
        pbFoto.Name = "pbFoto"
        pbFoto.Size = New Size(150, 150)
        pbFoto.SizeMode = PictureBoxSizeMode.StretchImage
        pbFoto.TabIndex = 9
        pbFoto.TabStop = False
        ' 
        ' btnUpload
        ' 
        btnUpload.Location = New Point(294, 384)
        btnUpload.Name = "btnUpload"
        btnUpload.Size = New Size(150, 34)
        btnUpload.TabIndex = 10
        btnUpload.Text = "Upload"
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(27, 455)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(75, 32)
        btnCetak.TabIndex = 11
        btnCetak.Text = "Cetak"
        ' 
        ' cbBerenang
        ' 
        cbBerenang.AutoSize = True
        cbBerenang.Location = New Point(462, 267)
        cbBerenang.Name = "cbBerenang"
        cbBerenang.Size = New Size(94, 24)
        cbBerenang.TabIndex = 12
        cbBerenang.Text = "Berenang"
        cbBerenang.UseVisualStyleBackColor = True
        ' 
        ' cbmancing
        ' 
        cbmancing.AutoSize = True
        cbmancing.Location = New Point(572, 266)
        cbmancing.Name = "cbmancing"
        cbmancing.Size = New Size(88, 24)
        cbmancing.TabIndex = 13
        cbmancing.Text = "Mancing"
        cbmancing.UseVisualStyleBackColor = True
        ' 
        ' cbMelukis
        ' 
        cbMelukis.AutoSize = True
        cbMelukis.Location = New Point(691, 266)
        cbMelukis.Name = "cbMelukis"
        cbMelukis.Size = New Size(81, 24)
        cbMelukis.TabIndex = 14
        cbMelukis.Text = "Melukis"
        cbMelukis.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(52, 49)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(161, 139)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(256, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(157, 18)
        Label1.TabIndex = 16
        Label1.Text = "KARTU KOMUNITAS"
        ' 
        ' FormInput
        ' 
        ClientSize = New Size(872, 527)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(cbMelukis)
        Controls.Add(cbmancing)
        Controls.Add(cbBerenang)
        Controls.Add(txtNama)
        Controls.Add(txtUmur)
        Controls.Add(txtNoHP)
        Controls.Add(txtAlamat)
        Controls.Add(rbLaki)
        Controls.Add(rbPerempuan)
        Controls.Add(cbMusik)
        Controls.Add(cbOlahraga)
        Controls.Add(cbGame)
        Controls.Add(pbFoto)
        Controls.Add(btnUpload)
        Controls.Add(btnCetak)
        Name = "FormInput"
        CType(pbFoto, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtNoHP As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents cbMusik As CheckBox
    Friend WithEvents cbOlahraga As CheckBox
    Friend WithEvents cbGame As CheckBox
    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents btnUpload As Button
    Friend WithEvents btnCetak As Button
    Friend WithEvents cbBerenang As CheckBox
    Friend WithEvents cbmancing As CheckBox
    Friend WithEvents cbMelukis As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class