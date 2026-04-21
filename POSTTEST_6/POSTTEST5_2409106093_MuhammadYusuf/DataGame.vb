Imports MySqlConnector

Module DataGame

    Public Function GetData() As DataTable
        Dim dt As New DataTable
        Using conn = GetConn()
            Using da As New MySqlDataAdapter("SELECT * FROM tb_game", conn)
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    Public Sub InsertData(id As String, nama As String, genre As String, harga As Integer)
        Using conn = GetConn()
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO tb_game VALUES (@id,@nama,@genre,@harga)", conn)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@nama", nama)
            cmd.Parameters.AddWithValue("@genre", genre)
            cmd.Parameters.AddWithValue("@harga", harga)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub UpdateData(id As String, nama As String, genre As String, harga As Integer)
        Using conn = GetConn()
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE tb_game SET namaGame=@nama, genre=@genre, hargaSewa=@harga WHERE idGame=@id", conn)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@nama", nama)
            cmd.Parameters.AddWithValue("@genre", genre)
            cmd.Parameters.AddWithValue("@harga", harga)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub DeleteData(id As String)
        Using conn = GetConn()
            conn.Open()
            Dim cmd As New MySqlCommand("DELETE FROM tb_game WHERE idGame=@id", conn)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Function SearchData(keyword As String) As DataTable
        Dim dt As New DataTable
        Using conn = GetConn()
            Using da As New MySqlDataAdapter(
                "SELECT * FROM tb_game WHERE namaGame LIKE @key OR genre LIKE @key", conn)
                da.SelectCommand.Parameters.AddWithValue("@key", "%" & keyword & "%")
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

End Module