<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Private Sub InitializeComponent()
        txtId = New TextBox()
        txtNama = New TextBox()
        txtGenre = New TextBox()
        txtHarga = New TextBox()
        txtSearch = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        dgvGame = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        CType(dgvGame, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(139, 30)
        txtId.Name = "txtId"
        txtId.Size = New Size(291, 27)
        txtId.TabIndex = 0
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(139, 64)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(291, 27)
        txtNama.TabIndex = 1
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(139, 97)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(291, 27)
        txtGenre.TabIndex = 2
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(139, 130)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(291, 27)
        txtHarga.TabIndex = 3
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(30, 203)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search..."
        txtSearch.Size = New Size(170, 27)
        txtSearch.TabIndex = 4
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(24, 168)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(75, 29)
        btnSimpan.TabIndex = 5
        btnSimpan.Text = "Simpan"
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(105, 168)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(75, 29)
        btnUbah.TabIndex = 6
        btnUbah.Text = "Ubah"
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(186, 168)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(75, 29)
        btnHapus.TabIndex = 7
        btnHapus.Text = "Hapus"
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(267, 168)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(75, 29)
        btnBatal.TabIndex = 8
        btnBatal.Text = "Batal"
        ' 
        ' dgvGame
        ' 
        dgvGame.ColumnHeadersHeight = 29
        dgvGame.Location = New Point(30, 236)
        dgvGame.Name = "dgvGame"
        dgvGame.RowHeadersWidth = 51
        dgvGame.Size = New Size(400, 200)
        dgvGame.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(24, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 20)
        Label1.TabIndex = 10
        Label1.Text = "ID Game"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(24, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 20)
        Label2.TabIndex = 11
        Label2.Text = "Nama Game"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(24, 104)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 20)
        Label3.TabIndex = 12
        Label3.Text = "Genre"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(24, 137)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 20)
        Label4.TabIndex = 13
        Label4.Text = "Harga sewa"
        ' 
        ' Form1
        ' 
        ClientSize = New Size(682, 493)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtId)
        Controls.Add(txtNama)
        Controls.Add(txtGenre)
        Controls.Add(txtHarga)
        Controls.Add(txtSearch)
        Controls.Add(btnSimpan)
        Controls.Add(btnUbah)
        Controls.Add(btnHapus)
        Controls.Add(btnBatal)
        Controls.Add(dgvGame)
        Name = "Form1"
        Text = "Sistem Penyewaan Game PS"
        CType(dgvGame, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtId As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents dgvGame As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class