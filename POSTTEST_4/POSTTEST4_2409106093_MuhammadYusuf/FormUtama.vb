Public Class FormUtama

    Private Sub InputDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataToolStripMenuItem.Click
        FormInput.Show()
    End Sub

    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        FormKartu.Show()
    End Sub

    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click
        SaveFileDialog1.Filter = "Text File|*.txt"

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim data As String =
                FormInput.nama & vbCrLf &
                FormInput.id & vbCrLf &
                FormInput.komunitas

            IO.File.WriteAllText(SaveFileDialog1.FileName, data)
            MessageBox.Show("Data tersimpan")
        End If
    End Sub

    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click
        OpenFileDialog1.Filter = "Text File|*.txt"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim isi As String = IO.File.ReadAllText(OpenFileDialog1.FileName)
            MessageBox.Show(isi)
        End If
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        If MessageBox.Show("Yakin keluar?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

End Class