Public Class Form1

    Sub LoadData()
        dgvGame.DataSource = GetData()
    End Sub

    Sub ClearForm()
        txtId.Clear()
        txtNama.Clear()
        txtGenre.Clear()
        txtHarga.Clear()
        txtSearch.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        InsertData(txtId.Text, txtNama.Text, txtGenre.Text, txtHarga.Text)
        LoadData()
        ClearForm()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        UpdateData(txtId.Text, txtNama.Text, txtGenre.Text, txtHarga.Text)
        LoadData()
        ClearForm()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        DeleteData(txtId.Text)
        LoadData()
        ClearForm()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        ClearForm()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        dgvGame.DataSource = SearchData(txtSearch.Text)
    End Sub

    Private Sub dgvGame_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGame.CellClick
        txtId.Text = dgvGame.CurrentRow.Cells(0).Value
        txtNama.Text = dgvGame.CurrentRow.Cells(1).Value
        txtGenre.Text = dgvGame.CurrentRow.Cells(2).Value
        txtHarga.Text = dgvGame.CurrentRow.Cells(3).Value
    End Sub

    Private Sub Sewabtn_Click(sender As Object, e As EventArgs) Handles Sewabtn.Click
        FormSewa.Show()
    End Sub
End Class