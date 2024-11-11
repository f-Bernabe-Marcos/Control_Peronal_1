Imports System.Data.SqlClient

Public Class fUsuario
    Inherits cConexion
    Dim cmd As New SqlCommand
    Dim rd As SqlDataReader

    Public Function BuscaUsuario(ByVal Usuario As String, ByVal Contrasena As String)
        Dim Regresa() As String = {"", "", "", "", ""}
        Try
            Conectar()
            Dim strSQL As String = "select IdUsuarios, NombreCompleto, Status, Matricula, DescripcionMay from Usuarios 
                                    left join Personal on Matricula = MatriculaPer 
                                    left join Grados on IdGrados = GradoPer
                                    where Matricula = '" & Usuario & "' and Contrasena = " & Contrasena
            cmd = New SqlCommand(strSQL, cn)
            rd = cmd.ExecuteReader

            While rd.Read()
                vGlobales.PidUsuario = rd(0)
                vGlobales.PidNombre = rd(1)
                vGlobales.PidStatus = rd(2)
                vGlobales.PidMatricula = rd(3)
                vGlobales.PidGrado = rd(4)
            End While

            Regresa(0) = vGlobales.PidUsuario
            Regresa(1) = vGlobales.PidNombre
            Regresa(2) = vGlobales.PidStatus
            Regresa(3) = vGlobales.PidMatricula
            Regresa(4) = vGlobales.PidGrado
            pIdUsuario = vGlobales.PidUsuario
            rd.Close()
            cmd.Dispose()

            Return Regresa

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Regresa
        Finally
            Desconectar()
        End Try
    End Function

    Public Function ValidaPassword(ByVal Password As String)
        Dim Regresa As Integer = 0
        Try
            Conectar()
            Dim strSQL As String = "Select isnull(u_idUsuario,0) as IdUsuario from Usuarios where u_idusuario='" & vGlobales.PidUsuario & "' and u_pwdusuario='" & Password & "' and sts_usuario = 'A'"
            cmd = New SqlCommand(strSQL, cn)
            rd = cmd.ExecuteReader

            While rd.Read()
                Regresa = rd(0)
            End While
            rd.Close()
            cmd.Dispose()

            Return Regresa

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Regresa
        Finally
            Desconectar()
        End Try
    End Function

    Public Function CambiarPassword(ByVal Password As String)
        Dim Regresa As Integer = 0
        Try
            Conectar()
            Dim strSQL As String = " update Usuarios set u_pwdusuario='" & Mid(Password, 1, 15) & "' where u_idusuario=" & vGlobales.PidUsuario
            cmd = New SqlCommand(strSQL, cn)
            Regresa = cmd.ExecuteNonQuery()
            cmd.Dispose()

            Return Regresa

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Regresa
        Finally
            Desconectar()
        End Try
    End Function

End Class
