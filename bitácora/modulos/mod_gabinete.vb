Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_gabinete
    'variables para las operaciones en clase gabinete

    Public id_gab As Integer

    Public va_aldaba As String

    Public va_chapa As String

    Public va_candado As String

    Public va_sw As String

    Public va_alim600 As String

    Public Property _id_gab() As Integer
        Get
            Return id_gab
        End Get
        Set(ByVal value As Integer)
            id_gab = value

        End Set

    End Property

    Dim nue_conexion As New conexion

    'VARIABLES PRIVADAS
    Private _adaptador As New MySqlDataAdapter
    Public _dtssgab As New DataSet
    Public lista As Byte
    

    'id_gabinete 	aldaba 	candado 	chapa 	seguridad_sw 	sw_alim
    Public Sub maxasgab()
        Try
            '_dtsciudad.Reset()
            nue_conexion.conectar()
            _adaptador.SelectCommand = New MySqlCommand("select MAX(id_gabinete) as id_gabinete from gabinete", nue_conexion.conex)
            nue_conexion.conex()
            _adaptador.SelectCommand.Connection = nue_conexion.conex()
            _adaptador.SelectCommand.ExecuteNonQuery()
            _adaptador.Fill(_dtssgab, "gabinete")
            lista = _dtssgab.Tables("gabinete").Rows.Count

            '_dtsciudad.WriteXml("E:\Documents and Settings\Administrador\Escritorio\reporte1\reportes.xml", XmlWriteMode.WriteSchema)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            nue_conexion.desconectar()

        End Try

    End Sub
End Module
