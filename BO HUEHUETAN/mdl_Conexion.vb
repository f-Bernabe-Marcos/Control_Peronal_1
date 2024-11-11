Module mdl_Conexion
    Function ConexionSqlDefinir(str_servidor As String, str_BaseDatos As String, str_Usuario As String, str_clave As String) As Data.SqlClient.SqlConnection
        Dim scn_Conexion As Data.SqlClient.SqlConnection
        scn_Conexion = New Data.SqlClient.SqlConnection
        scn_Conexion.ConnectionString = "Server" & str_servidor & ";Database=" & str_BaseDatos & ";User id=" & str_Usuario & ";Password=" & str_clave & ";Integrated Security=SSPI;"
        ConexionSqlDefinir = scn_Conexion
    End Function

    Function SQLAdaptador(str_SQL As String, sda_Adaptador As SqlClient.SqlDataAdapter, dtb_tabla As DataTable, ByRef scn_Conexion As Data.SqlClient.SqlConnection) As SqlClient.SqlDataAdapter

        Try
            sda_Adaptador = New SqlClient.SqlDataAdapter(str_SQL, scn_Conexion)
            sda_Adaptador.FillSchema(dtb_tabla, SchemaType.Mapped)


            SQLAdaptador = sda_Adaptador
        Catch ex As Exception

            SQLAdaptador = Nothing

        End Try

    End Function

End Module
