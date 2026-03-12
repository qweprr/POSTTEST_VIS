Public Class Form1

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Nama hanya boleh huruf")
        End If

    End Sub

    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Umur hanya boleh angka")
        End If

    End Sub

    Private Sub txtNoTelpon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoTelpon.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Nomor telepon hanya boleh angka")
        End If

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Dim openFile As New OpenFileDialog

        openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png"

        If openFile.ShowDialog() = DialogResult.OK Then

            picProfile.Image = Image.FromFile(openFile.FileName)
            picProfile.SizeMode = PictureBoxSizeMode.StretchImage

        End If

    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        If txtNama.Text = "" Or txtUmur.Text = "" Or txtNoTelpon.Text = "" Or txtAlamat.Text = "" Then

            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub

        End If

        If Not rdoLaki.Checked And Not rdoPerempuan.Checked Then

            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub

        End If

        If Not (chkGaming.Checked Or chkOlahraga.Checked Or chkBerenang.Checked Or chkMembaca.Checked Or chkMenari.Checked Or chkMenyanyi.Checked Or chkCoding.Checked Or chkMemancing.Checked Or chkBelajar.Checked Or chkMenggambar.Checked) Then

            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub

        End If
        MessageBox.Show("Kartu berhasil dicetak!", "Informasi")

    End Sub
End Class