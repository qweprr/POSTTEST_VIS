Imports MySqlConnector

Module DataSewa

    Public Function GetSewa() As DataTable
        Dim dt As New DataTable
        Dim query As String =
            "SELECT tb_sewa.idSewa, tb_game.namaGame, tb_sewa.namaPenyewa, tb_sewa.tanggal, tb_sewa.lamaSewa, tb_sewa.totalBayar " &
            "FROM tb_sewa INNER JOIN tb_game ON tb_sewa.idGame = tb_game.idGame"

        Using conn = GetConn()
            Using da As New MySqlDataAdapter(query, conn)
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    Public Sub InsertSewa(id As String, idGame As String, nama As String, tgl As Date, lama As Integer, total As Integer)
        Using conn = GetConn()
            conn.Open()
            Dim cmd As New MySqlCommand(
                "INSERT INTO tb_sewa VALUES (@id,@game,@nama,@tgl,@lama,@total)", conn)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@game", idGame)
            cmd.Parameters.AddWithValue("@nama", nama)
            cmd.Parameters.AddWithValue("@tgl", tgl)
            cmd.Parameters.AddWithValue("@lama", lama)
            cmd.Parameters.AddWithValue("@total", total)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub UpdateSewa(id As String, idGame As String, nama As String, tgl As Date, lama As Integer, total As Integer)
        Using conn = GetConn()
            conn.Open()
            Dim cmd As New MySqlCommand(
                "UPDATE tb_sewa SET idGame=@game, namaPenyewa=@nama, tanggal=@tgl, lamaSewa=@lama, totalBayar=@total WHERE idSewa=@id", conn)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@game", idGame)
            cmd.Parameters.AddWithValue("@nama", nama)
            cmd.Parameters.AddWithValue("@tgl", tgl)
            cmd.Parameters.AddWithValue("@lama", lama)
            cmd.Parameters.AddWithValue("@total", total)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub DeleteSewa(id As String)
        Using conn = GetConn()
            conn.Open()
            Dim cmd As New MySqlCommand("DELETE FROM tb_sewa WHERE idSewa=@id", conn)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Function SearchSewa(key As String) As DataTable
        Dim dt As New DataTable
        Using conn = GetConn()
            Using da As New MySqlDataAdapter(
                "SELECT * FROM tb_sewa WHERE namaPenyewa LIKE @key", conn)
                da.SelectCommand.Parameters.AddWithValue("@key", "%" & key & "%")
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

End Module