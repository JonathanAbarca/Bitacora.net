Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_localizacion
    Dim nue_conexion As New conexion

    'VARIABLES PRIVADAS
    Private _adaptador As New MySqlDataAdapter

    'VARIABLES PUBLICAS
    Public _dtsloc As New DataSet
    Public lista As Byte
    Public verificar As Boolean

    Public nloc As Integer

    Public Property _nloc() As Integer
        Get
            Return nloc
        End Get
        Set(ByVal value As Integer)
            nloc = value
        End Set
    End Property
    
    'BUSCAR CIUDADES PARA COMBOBOX
    Public Sub maxloc()
        Try
            '_dtsciudad.Reset()
            nue_conexion.conectar()
            _adaptador.SelectCommand = New MySqlCommand("select MAX(id_loc) as id_loc from localizacion", nue_conexion.conex)
            nue_conexion.conex()
            _adaptador.SelectCommand.Connection = nue_conexion.conex()
            _adaptador.SelectCommand.ExecuteNonQuery()
            _adaptador.Fill(_dtsloc, "localizacion")
            lista = _dtsloc.Tables("localizacion").Rows.Count



            '_dtsciudad.WriteXml("E:\Documents and Settings\Administrador\Escritorio\reporte1\reportes.xml", XmlWriteMode.WriteSchema)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            nue_conexion.desconectar()

        End Try

    End Sub

End Module
