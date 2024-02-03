Imports System.Data
Imports System.Data.Odbc
Module mod_reportes
    Public conectarme As New OdbcConnection
    Public dataset, dat As New DataSet
    Public adapter, ada As New OdbcDataAdapter
    Public buscar, bus As String

    Public var_call As Integer
    Public var_pun As Integer
    Public var_result As Integer
End Module
