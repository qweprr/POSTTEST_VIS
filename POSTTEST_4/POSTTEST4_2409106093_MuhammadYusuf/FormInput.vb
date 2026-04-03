Public Class FormInput

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg"

        If ofd.ShowDialog() = DialogResult.OK Then
            pbFoto.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub

    Private Function ValidasiInput() As Boolean

        If txtNama.Text.Trim() = "" Then
            MessageBox.Show("Nama tidak boleh kosong")
            txtNama.Focus()
            Return False
        End If

        If txtUmur.Text.Trim() = "" Then
            MessageBox.Show("Umur tidak boleh kosong")
            txtUmur.Focus()
            Return False
        End If

        If txtNoHP.Text.Trim() = "" Then
            MessageBox.Show("No HP tidak boleh kosong")
            txtNoHP.Focus()
            Return False
        End If

        If txtAlamat.Text.Trim() = "" Then
            MessageBox.Show("Alamat tidak boleh kosong")
            txtAlamat.Focus()
            Return False
        End If

        If Not rbLaki.Checked And Not rbPerempuan.Checked Then
            MessageBox.Show("Pilih jenis kelamin")
            Return False
        End If

        If Not cbMusik.Checked And Not cbOlahraga.Checked And Not cbGame.Checked Then
            MessageBox.Show("Pilih minimal 1 hobi")
            Return False
        End If

        If pbFoto.Image Is Nothing Then
            MessageBox.Show("Foto belum dipilih")
            Return False
        End If

        Return True
    End Function

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNoHP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoHP.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        If Not ValidasiInput() Then Exit Sub

        Dim jk As String
        If rbLaki.Checked Then
            jk = "Laki-laki"
        Else
            jk = "Perempuan"
        End If

        Dim hobi As String = ""
        If cbMusik.Checked Then hobi &= "Musik "
        If cbOlahraga.Checked Then hobi &= "Olahraga "
        If cbGame.Checked Then hobi &= "Game "
        If cbMusik.Checked Then hobi &= "Berenang "
        If cbOlahraga.Checked Then hobi &= "Mancing "
        If cbGame.Checked Then hobi &= "Melukis "

        FormHasil.lblNama.Text = "Nama: " & txtNama.Text
        FormHasil.lblUmur.Text = "Umur: " & txtUmur.Text
        FormHasil.lblNoHP.Text = "No HP: " & txtNoHP.Text
        FormHasil.lblAlamat.Text = "Alamat: " & txtAlamat.Text
        FormHasil.lblJK.Text = "JK: " & jk
        FormHasil.lblHobi.Text = "Hobi: " & hobi
        FormHasil.pbHasil.Image = pbFoto.Image

        FormHasil.Show()
    End Sub

End Class