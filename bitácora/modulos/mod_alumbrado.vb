Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Module mod_alumbrado
    Dim nue_conexion As New conexion

    'VARIABLES PRIVADAS
    Private _adaptador As New MySqlDataAdapter
    Public _dtsalum As New DataSet
    Public lista As Byte
    'variables para las operaciones en clase alumbrado

    Public id_alum As Integer

    Public foco As String

    Public alim_alum As String
    Public Property _id_alum() As Integer
        Get
            Return id_alum
        End Get
        Set(ByVal value As Integer)
            id_alum = value

        End Set

    End Property

    'id_alum 	foco 	alimentacion
    Public Sub maxalum()
        Try
            '_dtsciudad.Reset()
            nue_conexion.conectar()
            _adaptador.SelectCommand = New MySqlCommand("select MAX(id_alum) as id_alum from alumbrado", nue_conexion.conex)
            nue_conexion.conex()
            _adaptador.SelectCommand.Connection = nue_conexion.conex()
            _adaptador.SelectCommand.ExecuteNonQuery()
            _adaptador.Fill(_dtsalum, "alumbrado")
            lista = _dtsalum.Tables("alumbrado").Rows.Count

            '_dtsciudad.WriteXml("E:\Documents and Settings\Administrador\Escritorio\reporte1\reportes.xml", XmlWriteMode.WriteSchema)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            nue_conexion.desconectar()

        End Try

    End Sub

End Module
