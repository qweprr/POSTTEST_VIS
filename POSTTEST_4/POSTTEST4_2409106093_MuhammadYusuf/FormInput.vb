Public Class FormInput

    Public Shared nama As String
    Public Shared id As String
    Public Shared komunitas As String
    Public Shared kontak As String
    Public Shared hobi As String
    Public Shared foto As Image

    Function Validasi() As Boolean
        If txtNama.Text = "" Or txtID.Text = "" Or mtbHP.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Return False
        End If
        Return True
    End Function

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image|*.jpg;*.png"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            pbFoto.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not Validasi() Then Exit Sub

        nama = txtNama.Text
        id = txtID.Text
        komunitas = cmbKomunitas.Text
        kontak = mtbHP.Text
        foto = pbFoto.Image

        hobi = ""
        For Each ctrl As Control In TabPage3.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = ctrl
                If cb.Checked Then hobi &= cb.Text & ", "
            End If
        Next

        If MessageBox.Show("Cetak kartu?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            FormKartu.Show()
        End If
    End Sub

End Class