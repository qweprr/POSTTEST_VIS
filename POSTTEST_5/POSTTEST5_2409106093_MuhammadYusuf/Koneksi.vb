Imports MySqlConnector

Module Koneksi
    Public connString As String =
        "server=localhost;user id=root;password=;database=dbps_rental"

    Public Function GetConn() As MySqlConnection
        Return New MySqlConnection(connString)
    End Function
End Module