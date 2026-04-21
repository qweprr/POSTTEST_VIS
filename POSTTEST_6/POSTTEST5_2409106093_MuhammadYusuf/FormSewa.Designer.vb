<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSewa
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Private Sub InitializeComponent()
        Me.txtIdSewa = New System.Windows.Forms.TextBox()
        Me.cbGame = New System.Windows.Forms.ComboBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.dtTanggal = New System.Windows.Forms.DateTimePicker()
        Me.txtLama = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()

        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()

        Me.dgvSewa = New System.Windows.Forms.DataGridView()

        CType(Me.dgvSewa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        Me.txtIdSewa.Location = New System.Drawing.Point(30, 20)
        Me.txtIdSewa.Size = New System.Drawing.Size(150, 23)
        Me.txtIdSewa.PlaceholderText = "ID Sewa"

        Me.cbGame.Location = New System.Drawing.Point(30, 50)
        Me.cbGame.Size = New System.Drawing.Size(200, 23)

        Me.txtNama.Location = New System.Drawing.Point(30, 80)
        Me.txtNama.Size = New System.Drawing.Size(200, 23)
        Me.txtNama.PlaceholderText = "Nama Penyewa"

        Me.dtTanggal.Location = New System.Drawing.Point(30, 110)
        Me.dtTanggal.Size = New System.Drawing.Size(200, 23)

        Me.txtLama.Location = New System.Drawing.Point(30, 140)
        Me.txtLama.Size = New System.Drawing.Size(200, 23)
        Me.txtLama.PlaceholderText = "Lama Sewa"

        Me.txtTotal.Location = New System.Drawing.Point(30, 170)
        Me.txtTotal.Size = New System.Drawing.Size(200, 23)
        Me.txtTotal.PlaceholderText = "Total Bayar"

        Me.txtSearch.Location = New System.Drawing.Point(30, 210)
        Me.txtSearch.Size = New System.Drawing.Size(200, 23)
        Me.txtSearch.PlaceholderText = "Search..."

        Me.btnSimpan.Location = New System.Drawing.Point(260, 20)
        Me.btnSimpan.Size = New System.Drawing.Size(100, 30)
        Me.btnSimpan.Text = "Simpan"

        Me.btnUbah.Location = New System.Drawing.Point(260, 60)
        Me.btnUbah.Size = New System.Drawing.Size(100, 30)
        Me.btnUbah.Text = "Ubah"

        Me.btnHapus.Location = New System.Drawing.Point(260, 100)
        Me.btnHapus.Size = New System.Drawing.Size(100, 30)
        Me.btnHapus.Text = "Hapus"

        Me.btnBatal.Location = New System.Drawing.Point(260, 140)
        Me.btnBatal.Size = New System.Drawing.Size(100, 30)
        Me.btnBatal.Text = "Batal"

        Me.dgvSewa.Location = New System.Drawing.Point(30, 250)
        Me.dgvSewa.Size = New System.Drawing.Size(500, 200)
        Me.dgvSewa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Me.ClientSize = New System.Drawing.Size(600, 480)
        Me.Controls.Add(Me.txtIdSewa)
        Me.Controls.Add(Me.cbGame)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.dtTanggal)
        Me.Controls.Add(Me.txtLama)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtSearch)

        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnBatal)

        Me.Controls.Add(Me.dgvSewa)

        Me.Text = "Form Penyewaan Game PS"

        CType(Me.dgvSewa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents txtIdSewa As TextBox
    Friend WithEvents cbGame As ComboBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents dtTanggal As DateTimePicker
    Friend WithEvents txtLama As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtSearch As TextBox

    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button

    Friend WithEvents dgvSewa As DataGridView

End Class