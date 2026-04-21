Public Class FormSewa

    Sub LoadGame()
        cbGame.DataSource = GetData()
        cbGame.DisplayMember = "namaGame"
        cbGame.ValueMember = "idGame"
    End Sub

    Sub LoadData()
        dgvSewa.DataSource = GetSewa()
    End Sub

    Private Sub FormSewa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGame()
        LoadData()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        InsertSewa(
            txtIdSewa.Text,
            cbGame.SelectedValue.ToString(),
            txtNama.Text,
            dtTanggal.Value,
            Convert.ToInt32(txtLama.Text),
            Convert.ToInt32(txtTotal.Text)
        )
        LoadData()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        UpdateSewa(
            txtIdSewa.Text,
            cbGame.SelectedValue.ToString(),
            txtNama.Text,
            dtTanggal.Value,
            Convert.ToInt32(txtLama.Text),
            Convert.ToInt32(txtTotal.Text)
        )
        LoadData()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        DeleteSewa(txtIdSewa.Text)
        LoadData()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        dgvSewa.DataSource = SearchSewa(txtSearch.Text)
    End Sub

End Class