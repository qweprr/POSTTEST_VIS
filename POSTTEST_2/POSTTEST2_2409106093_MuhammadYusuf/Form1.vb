Public Class Form1
    Function CekJudulAda(judul As String) As Boolean
        Try
            For i = 0 To jumlahBuku - 1
                If daftarBuku(i) <> "" Then
                    Dim data() As String = daftarBuku(i).Split(" (")
                    If data.Length > 0 Then
                        If data(0).ToLower() = judul.ToLower() Then
                            Return True
                        End If
                    End If
                End If
            Next
            Return False
        Catch ex As Exception
            MessageBox.Show("Error saat cek judul: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Function CariIndexBuku(judul As String) As Integer
        Try
            For i = 0 To jumlahBuku - 1
                If daftarBuku(i) <> "" Then
                    Dim data() As String = daftarBuku(i).Split(" (")
                    If data.Length > 0 Then
                        If data(0).ToLower() = judul.ToLower() Then
                            Return i
                        End If
                    End If
                End If
            Next
            Return -1
        Catch ex As Exception
            MessageBox.Show("Error saat cari index: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End Try
    End Function

    Sub TambahBuku(judul As String, genre As String)
        Try
            If jumlahBuku < 100 Then
                daftarBuku(jumlahBuku) = judul & " (" & genre & ")"
                jumlahBuku += 1
                TampilkanBuku()
            Else
                MessageBox.Show("Daftar buku sudah penuh!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error saat tambah buku: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub HapusBuku(ByRef arrBuku() As String, ByRef jml As Integer, index As Integer)
        Try
            If index >= 0 AndAlso index < jml Then
                For i = index To jml - 2
                    arrBuku(i) = arrBuku(i + 1)
                Next
                jml -= 1
                arrBuku(jml) = ""
            End If
        Catch ex As Exception
            MessageBox.Show("Error saat hapus buku: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub TampilkanBuku()
        Try
            ListBox1.Items.Clear()

            For Each buku In daftarBuku
                If buku IsNot Nothing AndAlso buku <> "" Then
                    ListBox1.Items.Add(buku)
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Error saat tampilkan buku: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub ContohWhile()
        Try
            Dim i As Integer = 0
            Dim pesan As String = ""

            While i < jumlahBuku AndAlso daftarBuku(i) <> ""
                pesan &= daftarBuku(i) & vbCrLf
                i += 1
            End While

            If pesan <> "" Then
                MessageBox.Show("Daftar buku pake While:" & vbCrLf & pesan, "Info")
            End If
        Catch ex As Exception
            MessageBox.Show("Error di contoh While: " & ex.Message, "Error")
        End Try
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Try
            Dim judul As String = txtJudulTambah.Text.Trim()
            Dim genre As String = txtGenre.Text.Trim()

            If judul = "" Or genre = "" Then
                MessageBox.Show("Judul dan Genre harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If CekJudulAda(judul) Then
                MessageBox.Show("Judul buku sudah ada!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtJudulTambah.Focus()
                Exit Sub
            End If

            TambahBuku(judul, genre)

            txtJudulTambah.Text = ""
            txtGenre.Text = ""
            txtJudulTambah.Focus()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Try
            Dim judul As String = txtJudulHapus.Text.Trim()

            If judul = "" Then
                MessageBox.Show("Masukkan judul buku yang akan dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim index As Integer = CariIndexBuku(judul)

            If index = -1 Then
                MessageBox.Show("Buku dengan judul '" & judul & "' tidak ditemukan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtJudulHapus.SelectAll()
                txtJudulHapus.Focus()
                Exit Sub
            End If

            Dim confirm = MessageBox.Show("Yakin ingin menghapus buku '" & judul & "'?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If confirm = DialogResult.Yes Then
                HapusBuku(daftarBuku, jumlahBuku, index)
                TampilkanBuku()
                txtJudulHapus.Text = ""
                txtJudulHapus.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub ContohArrayMulti()
        Try

            dataBukuLengkap(0, 0) = "Contoh Buku"
            dataBukuLengkap(0, 1) = "Contoh Genre"
            dataBukuLengkap(0, 2) = "2024"
            jumlahDataLengkap = 1
        Catch ex As Exception
            MessageBox.Show("Error array multi: " & ex.Message, "Error")
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ContohArrayMulti()
    End Sub
End Class
