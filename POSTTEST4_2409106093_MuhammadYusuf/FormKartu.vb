Public Class FormKartu

    Private Sub FormKartu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNama.Text = "Nama: " & FormInput.nama
        lblID.Text = "ID: " & FormInput.id
        lblKomunitas.Text = "Komunitas: " & FormInput.komunitas
        lblKontak.Text = "Kontak: " & FormInput.kontak
        lblHobi.Text = "Hobi: " & FormInput.hobi

        pbFoto.Image = FormInput.foto
    End Sub

End Class