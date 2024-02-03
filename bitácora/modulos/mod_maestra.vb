Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_maestra
    Dim nue_conexion As New conexion
    Public n_calle As String
    Public n_op As String
    Public id_selecion As Integer
    Public id_maestra As Integer
    Public ver_fecha As DateTime
    Public Property fecha() As DateTime
        Get
            Return ver_fecha
        End Get
        Set(ByVal value As DateTime)
            ver_fecha = value
        End Set
    End Property
    Public Property _id_selecion() As Integer
        Get
            Return id_selecion
        End Get
        Set(ByVal value As Integer)
            id_selecion = value
        End Set
    End Property
    'VARIABLES PRIVADAS
    Private _adaptador As New MySqlDataAdapter

    'VARIABLES PUBLICAS
    Public _dtsmaes As New DataSet
    Public lista As Byte

    
    'buscar el maximo numero del id
    Public Sub maxmaestra()
        Try
            '_dtsciudad.Reset()
            nue_conexion.conectar()
            _adaptador.SelectCommand = New MySqlCommand("select MAX(id_enlaces) as id_enlaces from maestra", nue_conexion.conex)
            nue_conexion.conex()
            _adaptador.SelectCommand.Connection = nue_conexion.conex()
            _adaptador.SelectCommand.ExecuteNonQuery()
            _adaptador.Fill(_dtsmaes, "maestra")
            lista = _dtsmaes.Tables("maestra").Rows.Count

            'id_enlaces	id_loc	id_alum	id_caja	id_gabex	id_componentes	fecha_mod

            '_dtsciudad.WriteXml("E:\Documents and Settings\Administrador\Escritorio\reporte1\reportes.xml", XmlWriteMode.WriteSchema)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            nue_conexion.desconectar()

        End Try

    End Sub
End Module
