<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHasil
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHasil))
        pbHasil = New PictureBox()
        lblNama = New Label()
        lblUmur = New Label()
        lblNoHP = New Label()
        lblAlamat = New Label()
        lblJK = New Label()
        lblHobi = New Label()
        LabelJudul = New Label()
        PictureBox1 = New PictureBox()
        CType(pbHasil, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbHasil
        ' 
        pbHasil.BorderStyle = BorderStyle.FixedSingle
        pbHasil.Location = New Point(20, 50)
        pbHasil.Name = "pbHasil"
        pbHasil.Size = New Size(120, 120)
        pbHasil.SizeMode = PictureBoxSizeMode.StretchImage
        pbHasil.TabIndex = 1
        pbHasil.TabStop = False
        ' 
        ' lblNama
        ' 
        lblNama.Location = New Point(160, 50)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(200, 20)
        lblNama.TabIndex = 2
        lblNama.Text = "Nama:"
        ' 
        ' lblUmur
        ' 
        lblUmur.Location = New Point(160, 75)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(200, 20)
        lblUmur.TabIndex = 3
        lblUmur.Text = "Umur:"
        ' 
        ' lblNoHP
        ' 
        lblNoHP.Location = New Point(160, 100)
        lblNoHP.Name = "lblNoHP"
        lblNoHP.Size = New Size(200, 20)
        lblNoHP.TabIndex = 4
        lblNoHP.Text = "No HP:"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.Location = New Point(160, 125)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(200, 20)
        lblAlamat.TabIndex = 5
        lblAlamat.Text = "Alamat:"
        ' 
        ' lblJK
        ' 
        lblJK.Location = New Point(160, 150)
        lblJK.Name = "lblJK"
        lblJK.Size = New Size(200, 20)
        lblJK.TabIndex = 6
        lblJK.Text = "JK:"
        ' 
        ' lblHobi
        ' 
        lblHobi.Location = New Point(160, 175)
        lblHobi.Name = "lblHobi"
        lblHobi.Size = New Size(200, 20)
        lblHobi.TabIndex = 7
        lblHobi.Text = "Hobi:"
        ' 
        ' LabelJudul
        ' 
        LabelJudul.AutoSize = True
        LabelJudul.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        LabelJudul.Location = New Point(120, 10)
        LabelJudul.Name = "LabelJudul"
        LabelJudul.Size = New Size(243, 32)
        LabelJudul.TabIndex = 0
        LabelJudul.Text = "KARTU KOMUNITAS"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(20, 10)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(35, 32)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' FormHasil
        ' 
        ClientSize = New Size(539, 285)
        Controls.Add(PictureBox1)
        Controls.Add(LabelJudul)
        Controls.Add(pbHasil)
        Controls.Add(lblNama)
        Controls.Add(lblUmur)
        Controls.Add(lblNoHP)
        Controls.Add(lblAlamat)
        Controls.Add(lblJK)
        Controls.Add(lblHobi)
        Name = "FormHasil"
        Text = "Hasil Kartu"
        CType(pbHasil, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbHasil As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblNoHP As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblJK As Label
    Friend WithEvents lblHobi As Label
    Friend WithEvents LabelJudul As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class