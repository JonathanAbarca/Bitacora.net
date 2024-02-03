Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_calles
    Dim nue_conexion As New conexion

    'VARIABLES PRIVADAS
    Private _adaptador As New MySqlDataAdapter

    'VARIABLES PUBLICAS
    Public _dtscalles As New DataSet
    Public lista As Byte
    Public var_calles As Integer
    Public ncalle As String
    Public verificar As Boolean

    Public Property pvar_calles() As Integer
        Get
            Return var_calles
        End Get
        Set(ByVal value As Integer)
            var_calles = value
        End Set
    End Property
    Public Property _ncalle() As Integer
        Get
            Return ncalle
        End Get
        Set(ByVal value As Integer)
            ncalle = value
        End Set
    End Property
    'BUSCAR CIUDADES PARA COMBOBOX
    Public Sub maxcalle()
        Try
            '_dtsciudad.Reset()
            nue_conexion.conectar()
            _adaptador.SelectCommand = New MySqlCommand("select MAX(id_calles) as id_calles from calles", nue_conexion.conex)
            nue_conexion.conex()
            _adaptador.SelectCommand.Connection = nue_conexion.conex()
            _adaptador.SelectCommand.ExecuteNonQuery()
            _adaptador.Fill(_dtscalles, "calles")
            lista = _dtscalles.Tables("calles").Rows.Count
            '_dtsciudad.WriteXml("E:\Documents and Settings\Administrador\Escritorio\reporte1\reportes.xml", XmlWriteMode.WriteSchema)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            nue_conexion.desconectar()

        End Try

    End Sub


End Module


