Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_componentes
    Public id_com As Integer
    Public cb_princ, rele_princ, cb_bom, cont_bom, ol_bom, cb_vent, cont_vent, ol_vent, cb_trafo, trafo600, trafo220, cb_enchu, enchu_hem As String
    'id_componentes 	cb_princ 	rele_princ 	cb_bom 	cont_bom 	ol_bom 	cb_vent 	
    'cont_vent 	ol_vent 	cb_trafo 	trafo600 	trafo220 	cb_enchu 	enchu_hem
    Dim nue_conexion As New conexion

    Private _adaptador As New MySqlDataAdapter
    Public _dtscompo As New DataSet
    Public lista As Byte
    Public Property _id_com() As Integer
        Get
            Return id_com
        End Get
        Set(ByVal value As Integer)
            id_com = value

        End Set

    End Property
    Public Sub maxcompo()
        Try
            _dtscompo.Reset()
            nue_conexion.conectar()
            _adaptador.SelectCommand = New MySqlCommand("select MAX(id_componentes) as id_componentes from componentes", nue_conexion.conex)
            nue_conexion.conex()
            _adaptador.SelectCommand.Connection = nue_conexion.conex()
            _adaptador.SelectCommand.ExecuteNonQuery()
            _adaptador.Fill(_dtscompo, "componentes")
            lista = _dtscompo.Tables("componentes").Rows.Count

            '_dtsciudad.WriteXml("E:\Documents and Settings\Administrador\Escritorio\reporte1\reportes.xml", XmlWriteMode.WriteSchema)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            nue_conexion.desconectar()

        End Try

    End Sub

End Module
