Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_historial
    Dim nue_conexion As New conexion

    'VARIABLES PRIVADAS
    Private _adaptador As New MySqlDataAdapter

    'VARIABLES PUBLICAS
    Public id_actuhis As Integer
    Public _dtshis As New DataSet
    Public lista As Byte
    Dim id_his As Integer
    Public Property _id_his() As Integer
        Get
            Return id_his
        End Get
        Set(ByVal value As Integer)

            id_his = value

        End Set
    End Property
    Public Sub maxhis()
        Try
            '_dtshis.Reset()
            nue_conexion.conectar()
            _adaptador.SelectCommand = New MySqlCommand("select MAX(id_his) as id_his from historial", nue_conexion.conex)
            nue_conexion.conex()
            _adaptador.SelectCommand.Connection = nue_conexion.conex()
            _adaptador.SelectCommand.ExecuteNonQuery()
            _adaptador.Fill(_dtshis, "historial")
            lista = _dtshis.Tables("historial").Rows.Count


            '_dtsciudad.WriteXml("E:\Documents and Settings\Administrador\Escritorio\reporte1\reportes.xml", XmlWriteMode.WriteSchema)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            nue_conexion.desconectar()

        End Try

    End Sub

End Module
