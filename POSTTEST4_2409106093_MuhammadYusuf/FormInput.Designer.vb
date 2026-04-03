<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInput
    Inherits Form

    Private components As System.ComponentModel.IContainer

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage

    ' TAB 1
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents cmbKomunitas As ComboBox
    Friend WithEvents dtpLahir As DateTimePicker
    Friend WithEvents rbL As RadioButton
    Friend WithEvents rbP As RadioButton

    ' TAB 2
    Friend WithEvents mtbHP As MaskedTextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtAlamat As TextBox

    ' TAB 3
    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents GroupBox1 As GroupBox

    ' Checkbox
    Friend WithEvents cb1 As CheckBox
    Friend WithEvents cb2 As CheckBox
    Friend WithEvents cb3 As CheckBox
    Friend WithEvents cb4 As CheckBox
    Friend WithEvents cb5 As CheckBox
    Friend WithEvents cb6 As CheckBox
    Friend WithEvents cb7 As CheckBox
    Friend WithEvents cb8 As CheckBox

    Friend WithEvents OpenFileDialog1 As OpenFileDialog

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        txtNama = New TextBox()
        txtID = New TextBox()
        cmbKomunitas = New ComboBox()
        dtpLahir = New DateTimePicker()
        rbL = New RadioButton()
        rbP = New RadioButton()
        TabPage2 = New TabPage()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        mtbHP = New MaskedTextBox()
        txtEmail = New TextBox()
        txtAlamat = New TextBox()
        TabPage3 = New TabPage()
        pbFoto = New PictureBox()
        btnBrowse = New Button()
        btnSimpan = New Button()
        GroupBox1 = New GroupBox()
        rb1 = New RadioButton()
        rb2 = New RadioButton()
        rb3 = New RadioButton()
        cb1 = New CheckBox()
        cb2 = New CheckBox()
        cb3 = New CheckBox()
        cb4 = New CheckBox()
        cb5 = New CheckBox()
        cb6 = New CheckBox()
        cb7 = New CheckBox()
        cb8 = New CheckBox()
        OpenFileDialog1 = New OpenFileDialog()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        CType(pbFoto, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(482, 303)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Label8)
        TabPage1.Controls.Add(Label7)
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(txtNama)
        TabPage1.Controls.Add(txtID)
        TabPage1.Controls.Add(cmbKomunitas)
        TabPage1.Controls.Add(dtpLahir)
        TabPage1.Controls.Add(rbL)
        TabPage1.Controls.Add(rbP)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Size = New Size(474, 270)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Data Utama"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(35, 184)
        Label8.Name = "Label8"
        Label8.Size = New Size(103, 20)
        Label8.TabIndex = 10
        Label8.Text = "Jenis kelamin :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(35, 147)
        Label7.Name = "Label7"
        Label7.Size = New Size(101, 20)
        Label7.TabIndex = 9
        Label7.Text = "Tanggal lahir :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(35, 108)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 20)
        Label6.TabIndex = 8
        Label6.Text = "Komunitas :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(35, 67)
        Label5.Name = "Label5"
        Label5.Size = New Size(31, 20)
        Label5.TabIndex = 7
        Label5.Text = "ID :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(35, 27)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 20)
        Label4.TabIndex = 6
        Label4.Text = "Nama :"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(150, 20)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(100, 27)
        txtNama.TabIndex = 0
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(150, 60)
        txtID.Name = "txtID"
        txtID.Size = New Size(100, 27)
        txtID.TabIndex = 1
        ' 
        ' cmbKomunitas
        ' 
        cmbKomunitas.Items.AddRange(New Object() {"Gaming", "Programming", "Design", "Multimedia"})
        cmbKomunitas.Location = New Point(150, 100)
        cmbKomunitas.Name = "cmbKomunitas"
        cmbKomunitas.Size = New Size(121, 28)
        cmbKomunitas.TabIndex = 2
        ' 
        ' dtpLahir
        ' 
        dtpLahir.Location = New Point(150, 140)
        dtpLahir.Name = "dtpLahir"
        dtpLahir.Size = New Size(200, 27)
        dtpLahir.TabIndex = 3
        dtpLahir.Value = New Date(2026, 4, 3, 20, 53, 30, 0)
        ' 
        ' rbL
        ' 
        rbL.Location = New Point(150, 180)
        rbL.Name = "rbL"
        rbL.Size = New Size(104, 24)
        rbL.TabIndex = 4
        rbL.Text = "Laki-laki"
        ' 
        ' rbP
        ' 
        rbP.Location = New Point(260, 180)
        rbP.Name = "rbP"
        rbP.Size = New Size(104, 24)
        rbP.TabIndex = 5
        rbP.Text = "Perempuan"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Label3)
        TabPage2.Controls.Add(Label2)
        TabPage2.Controls.Add(Label1)
        TabPage2.Controls.Add(mtbHP)
        TabPage2.Controls.Add(txtEmail)
        TabPage2.Controls.Add(txtAlamat)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Size = New Size(474, 270)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kontak"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(41, 107)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 20)
        Label3.TabIndex = 5
        Label3.Text = "Alamat :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(41, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 4
        Label2.Text = "Email :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(41, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 20)
        Label1.TabIndex = 3
        Label1.Text = "No Hp :"
        ' 
        ' mtbHP
        ' 
        mtbHP.Location = New Point(150, 20)
        mtbHP.Mask = "0000-0000-0000"
        mtbHP.Name = "mtbHP"
        mtbHP.Size = New Size(100, 27)
        mtbHP.TabIndex = 0
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(150, 60)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(100, 27)
        txtEmail.TabIndex = 1
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(150, 100)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(100, 27)
        txtAlamat.TabIndex = 2
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(pbFoto)
        TabPage3.Controls.Add(btnBrowse)
        TabPage3.Controls.Add(btnSimpan)
        TabPage3.Controls.Add(GroupBox1)
        TabPage3.Controls.Add(cb1)
        TabPage3.Controls.Add(cb2)
        TabPage3.Controls.Add(cb3)
        TabPage3.Controls.Add(cb4)
        TabPage3.Controls.Add(cb5)
        TabPage3.Controls.Add(cb6)
        TabPage3.Controls.Add(cb7)
        TabPage3.Controls.Add(cb8)
        TabPage3.Location = New Point(4, 29)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(474, 270)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Profil"
        ' 
        ' pbFoto
        ' 
        pbFoto.BackColor = SystemColors.Control
        pbFoto.BorderStyle = BorderStyle.FixedSingle
        pbFoto.Location = New Point(20, 20)
        pbFoto.Name = "pbFoto"
        pbFoto.Size = New Size(120, 120)
        pbFoto.SizeMode = PictureBoxSizeMode.Zoom
        pbFoto.TabIndex = 0
        pbFoto.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(20, 150)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(75, 23)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(20, 200)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(75, 23)
        btnSimpan.TabIndex = 2
        btnSimpan.Text = "Simpan & Cetak"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rb1)
        GroupBox1.Controls.Add(rb2)
        GroupBox1.Controls.Add(rb3)
        GroupBox1.Location = New Point(200, 20)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(200, 100)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Peran"
        ' 
        ' rb1
        ' 
        rb1.Location = New Point(10, 20)
        rb1.Name = "rb1"
        rb1.Size = New Size(104, 24)
        rb1.TabIndex = 0
        rb1.Text = "Ketua"
        ' 
        ' rb2
        ' 
        rb2.Location = New Point(10, 45)
        rb2.Name = "rb2"
        rb2.Size = New Size(104, 24)
        rb2.TabIndex = 1
        rb2.Text = "Anggota"
        ' 
        ' rb3
        ' 
        rb3.Location = New Point(10, 70)
        rb3.Name = "rb3"
        rb3.Size = New Size(104, 24)
        rb3.TabIndex = 2
        rb3.Text = "Admin"
        ' 
        ' cb1
        ' 
        cb1.Location = New Point(200, 130)
        cb1.Name = "cb1"
        cb1.Size = New Size(104, 24)
        cb1.TabIndex = 4
        cb1.Text = "Gaming"
        ' 
        ' cb2
        ' 
        cb2.Location = New Point(200, 160)
        cb2.Name = "cb2"
        cb2.Size = New Size(104, 24)
        cb2.TabIndex = 5
        cb2.Text = "Design"
        ' 
        ' cb3
        ' 
        cb3.Location = New Point(200, 190)
        cb3.Name = "cb3"
        cb3.Size = New Size(104, 24)
        cb3.TabIndex = 6
        cb3.Text = "Coding"
        ' 
        ' cb4
        ' 
        cb4.Location = New Point(200, 220)
        cb4.Name = "cb4"
        cb4.Size = New Size(104, 24)
        cb4.TabIndex = 7
        cb4.Text = "Music"
        ' 
        ' cb5
        ' 
        cb5.Location = New Point(310, 130)
        cb5.Name = "cb5"
        cb5.Size = New Size(104, 24)
        cb5.TabIndex = 8
        cb5.Text = "Sport"
        ' 
        ' cb6
        ' 
        cb6.Location = New Point(310, 160)
        cb6.Name = "cb6"
        cb6.Size = New Size(104, 24)
        cb6.TabIndex = 9
        cb6.Text = "Editing"
        ' 
        ' cb7
        ' 
        cb7.Location = New Point(310, 190)
        cb7.Name = "cb7"
        cb7.Size = New Size(104, 24)
        cb7.TabIndex = 10
        cb7.Text = "Streaming"
        ' 
        ' cb8
        ' 
        cb8.Location = New Point(310, 220)
        cb8.Name = "cb8"
        cb8.Size = New Size(104, 24)
        cb8.TabIndex = 11
        cb8.Text = "Content"
        ' 
        ' FormInput
        ' 
        ClientSize = New Size(482, 303)
        Controls.Add(TabControl1)
        Name = "FormInput"
        Text = "Form Input"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        CType(pbFoto, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents rb1 As RadioButton
    Friend WithEvents rb2 As RadioButton
    Friend WithEvents rb3 As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
End Class