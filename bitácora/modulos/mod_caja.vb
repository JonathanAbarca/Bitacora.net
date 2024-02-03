Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_caja
    'variables para las operaciones en clase caja local
    Public id_caja As Integer
    Public aldaba As String
    Public candado As String
    Public chapa As String
    Public en60 As String
    Public en30 As String
    Public en35 As String
    'id_local 	aldaba 	candado 	chapa 	enchufe_60 	enchufe_30 	enchufe_35p
    Dim nue_conexion As New conexion

    'VARIABLES PRIVADAS
    Private _adaptador As New MySqlDataAdapter
    Public _dtscaja As New DataSet
    Public lista As Byte
    Public Property _id_caja() As Integer
        Get
            Return id_caja
        End Get
        Set(ByVal value As Integer)
            id_caja = value

        End Set

    End Property


    Public Sub maxacaja()
        Try
            '_dtsciudad.Reset()
            nue_conexion.conectar()
            _adaptador.SelectCommand = New MySqlCommand("select MAX(id_local) as id_local from caja", nue_conexion.conex)
            nue_conexion.conex()
            _adaptador.SelectCommand.Connection = nue_conexion.conex()
            _adaptador.SelectCommand.ExecuteNonQuery()
            _adaptador.Fill(_dtscaja, "caja")
            lista = _dtscaja.Tables("caja").Rows.Count

            '_dtsciudad.WriteXml("E:\Documents and Settings\Administrador\Escritorio\reporte1\reportes.xml", XmlWriteMode.WriteSchema)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            nue_conexion.desconectar()

        End Try

    End Sub
End Module
