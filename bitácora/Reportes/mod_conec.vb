Imports System.Data
Imports System.Data.Odbc
Module mod_conec
    Public Sub conexiones()
        conectarme.ConnectionString = "DSN=bitacora;Uid=root;pwd=;"
        conectarme.Open()
    End Sub
End Module
