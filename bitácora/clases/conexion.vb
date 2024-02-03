Imports MySql.Data.MySqlClient
Public Class conexion

    'aqui coloca tu cadena de conexion de xampp, wampp o lo que sea que uses
    Private con As New MySqlConnection("server=localhost; user=root; database=bd_bitacora")

    'procedimiento que abre la conexion mysql
    Public Sub conectar()
        con.Open()
    End Sub

    'procedimiento quecierra la conexion mysql
    Public Sub desconectar()
        con.Close()
    End Sub

    'funcion que devuelve la conexion mysql
    Function conex() As MySqlConnection
        conex = con
        Return conex
    End Function

End Class