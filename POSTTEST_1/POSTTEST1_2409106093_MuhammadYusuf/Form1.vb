Public Class Form1
    ' Variabel untuk menyimpan daftar IP Semester
    Private daftarIPSemester As New List(Of Double)

    ' Event handler untuk Form Load
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Atur judul form
        Me.Text = "Kalkulator IPK"

        ' Atur posisi di tengah layar
        Me.StartPosition = FormStartPosition.CenterScreen

        ' Inisialisasi tampilan awal
        txtIPK.Text = "0.00"
        lblPredikat.Text = "-"
        txtIP.Focus()
    End Sub

    ' Event handler untuk tombol Tambah
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        TambahIPSemester()
    End Sub

    ' Event handler untuk tombol Reset
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim hasil = MessageBox.Show("Yakin ingin mereset semua data?",
                                   "Konfirmasi Reset",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then
            ResetData()
        End If
    End Sub

    ' Event handler untuk Enter key di TextBox IP
    Private Sub txtIP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIP.KeyPress
        ' Hanya mengizinkan angka, titik, dan backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso
           e.KeyChar <> "." AndAlso
           e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

        ' Cegah titik ganda
        If e.KeyChar = "." AndAlso txtIP.Text.Contains(".") Then
            e.Handled = True
        End If

        ' Jika Enter ditekan
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            TambahIPSemester()
        End If
    End Sub

    ' Fungsi untuk menambah IP Semester
    Private Sub TambahIPSemester()
        Dim input As String = txtIP.Text.Trim()

        ' Validasi input kosong
        If String.IsNullOrEmpty(input) Then
            MessageBox.Show("Masukkan IP Semester terlebih dahulu!",
                          "Peringatan",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Warning)
            txtIP.Focus()
            Return
        End If

        ' Konversi ke angka
        Dim ipSemester As Double
        If Not Double.TryParse(input, ipSemester) Then
            MessageBox.Show("Masukkan angka yang valid!",
                          "Error",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error)
            txtIP.SelectAll()
            txtIP.Focus()
            Return
        End If

        ' Validasi range IP (0-4)
        If ipSemester < 0.0 Or ipSemester > 4.0 Then
            MessageBox.Show("IP Semester harus antara 0.00 - 4.00!",
                          "Error",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error)
            txtIP.SelectAll()
            txtIP.Focus()
            Return
        End If

        ' Tambahkan ke daftar
        daftarIPSemester.Add(ipSemester)

        ' Hitung IPK
        HitungIPK()

        ' Kosongkan TextBox IP
        txtIP.Text = ""
        txtIP.Focus()

        ' Tampilkan pesan sukses (opsional)
        ' MessageBox.Show($"IP Semester {ipSemester.ToString("0.00")} berhasil ditambahkan!", 
        '               "Sukses", 
        '               MessageBoxButtons.OK, 
        '               MessageBoxIcon.Information)
    End Sub

    ' Fungsi menghitung IPK (rata-rata)
    Private Sub HitungIPK()
        Dim total As Double = 0
        Dim ipk As Double = 0

        If daftarIPSemester.Count > 0 Then
            For Each ip In daftarIPSemester
                total += ip
            Next
            ipk = total / daftarIPSemester.Count
        End If

        ' Tampilkan IPK di TextBox
        txtIPK.Text = ipk.ToString("0.00")

        ' Tentukan predikat
        TentukanPredikat(ipk)
    End Sub

    ' Fungsi menentukan predikat berdasarkan IPK
    Private Sub TentukanPredikat(ipk As Double)
        If ipk >= 2.0 AndAlso ipk <= 2.75 Then
            lblPredikat.Text = "Cukup"
        ElseIf ipk >= 2.76 AndAlso ipk <= 3.0 Then
            lblPredikat.Text = "Memuaskan"
        ElseIf ipk > 3.01 Then
            lblPredikat.Text = "Sangat Memuaskan"
        Else
            lblPredikat.Text = "-"
        End If
    End Sub

    ' Fungsi mereset semua data
    Private Sub ResetData()
        daftarIPSemester.Clear()
        txtIPK.Text = "0.00"
        lblPredikat.Text = "-"
        txtIP.Text = ""
        txtIP.Focus()
    End Sub

    ' Optional: Validasi saat meninggalkan TextBox
    Private Sub txtIP_Leave(sender As Object, e As EventArgs) Handles txtIP.Leave
        If txtIP.Text.Trim() <> "" Then
            Dim test As Double
            If Not Double.TryParse(txtIP.Text.Trim(), test) Then
                MessageBox.Show("Format angka tidak valid!",
                              "Peringatan",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning)
                txtIP.Focus()
            End If
        End If
    End Sub
End Class
