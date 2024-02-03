Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_puntos
    Dim nue_conexion As New conexion

    'VARIABLES PRIVADAS
    Private _adaptador As New MySqlDataAdapter

    'VARIABLES PUBLICAS
    Public _dtspuntos As New DataSet
    Public lista As Byte
    Public var_puntos As Integer
    Public npunto As String
    Public verificarpunto As Boolean

    Public Property _npunto() As Integer
        Get
            Return npunto
        End Get
        Set(ByVal value As Integer)
            npunto = value
        End Set
    End Property

    Public Property pvar_puntos() As Integer
        Get
            Return var_puntos
        End Get
        Set(ByVal value As Integer)

            var_puntos = value

        End Set
    End Property

    Public Sub maxpuntos()
        Try
            '_dtsciudad.Reset()
            nue_conexion.conectar()
            _adaptador.SelectCommand = New MySqlCommand("select MAX(id_punto) as id_punto from puntos", nue_conexion.conex)
            nue_conexion.conex()
            _adaptador.SelectCommand.Connection = nue_conexion.conex()
            _adaptador.SelectCommand.ExecuteNonQuery()
            _adaptador.Fill(_dtspuntos, "puntos")
            lista = _dtspuntos.Tables("puntos").Rows.Count



            '_dtsciudad.WriteXml("E:\Documents and Settings\Administrador\Escritorio\reporte1\reportes.xml", XmlWriteMode.WriteSchema)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            nue_conexion.desconectar()

        End Try

    End Sub

End Module
