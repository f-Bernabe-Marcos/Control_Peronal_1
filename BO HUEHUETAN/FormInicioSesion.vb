Imports System.IO
Imports System.Data.SqlClient
Imports GN.Var_Globales

Public Class FormInicioSesion
    Dim nNumVeces As Integer = 0


    Private Sub FormInicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Close()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Valida_Usuario()
    End Sub

    Private Sub Valida_Usuario()

        If (Len(Trim(TxtUsuario.Text)) > 0) And (Len(Trim(TxtContrasena.Text)) > 0) Then
            ' Validar el usuario y contraseña
            Dim funcion As New fUsuario
            Dim Regresa() As String = {""}
            Try
                If nNumVeces < 3 Then
                    If TxtUsuario.Text <> "" Then
                        Regresa = funcion.BuscaUsuario(TxtUsuario.Text, TxtContrasena.Text)
                        If Regresa(0) = "" Then
                            MsgBox("El Usuario no es válido, verifique por favor.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Seguridad.")
                            nNumVeces += 1
                        ElseIf Regresa(2) = False Then
                            MsgBox("El usuario esta inactivo.", vbExclamation + vbOKOnly, pTituloMsgVentana)
                        Else
                            bTipoUsuario = Regresa(2)
                            Try
                                Dim archivo_security As String = Path.GetTempPath() & "DBConfig.Config"

                                ' True, para añadir texto al existente, False, para reemplazar todo el texto existente
                                My.Computer.FileSystem.WriteAllText(archivo_security, Regresa(0) & vbCrLf, False)

                                'Muestro el menú
                                MDI_Principal.Show()
                                Me.Hide()

                            Catch ex As Exception
                                MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
                            End Try

                        End If
                    End If
                Else
                    MsgBox("Está atacando la seguridad del sistema, excedió el número máximo de intentos.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Violación de Seguridad.")
                    'Me.btnCerrar_Click(sender, e)
                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Ocurrio un Error ...")
            End Try
        Else
            MessageBox.Show("Error: Introduce tu usuario y contraseña.", "Iniciar sesión - SA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub BtnConexion_Click(sender As Object, e As EventArgs) Handles BtnConexion.Click
        frmDBConnection.Show()
    End Sub

    Private Sub TxtUsuario_TextChanged(sender As Object, e As EventArgs) Handles TxtUsuario.TextChanged

    End Sub



    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

End Class
