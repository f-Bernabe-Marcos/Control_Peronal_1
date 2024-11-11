Imports System.Data.SqlClient

Public Class cConexion
    Protected cn As New SqlConnection
    Protected cnEmp As New SqlConnection

    'Private connectionPredet As String = My.Settings.ConStrPredeterminada.ToString
    Private connectionPredet As String = My.Settings.ConStrPredeterminada.ToString
    Public connectionBD As New SqlConnection
    Public connectionBDHelpDesk As New SqlConnection

    Public Sub Conexion_Predeterminada()

        'If connectionPredet = "L" Then
        connectionBD = New SqlConnection(My.Settings.ConStrLocal)
        'ElseIf connectionPredet = "E" Then
        connectionBDHelpDesk = New SqlConnection(My.Settings.ConStrExterna)
        'Else
        'MsgBox("No hay conexión predeterminada")
        'End If
    End Sub


    Public Function Obtiene_Conex_Predet() As String
        Dim sConexion As String = ""
        'connectionPredet = My.Settings.ConStrLocal.ToString

        'If connectionPredet = "L" Then
        sConexion = My.Settings.ConStrLocal.ToString
        'ElseIf connectionPredet = "E" Then
        'sConexion = My.Settings.ConStrExterna.ToString
        'End If

        Return sConexion
    End Function

    Public Function Obtiene_Conex_Predet_HelpDesk() As String
        Dim sConexion As String = ""
        'connectionPredet = My.Settings.ConStrExterna.ToString

        'If connectionPredet = "L" Then
        'sConexion = My.Settings.ConStrLocal.ToString
        'ElseIf connectionPredet = "E" Then
        sConexion = My.Settings.ConStrExterna.ToString
        'End If

        Return sConexion
    End Function

    ' --------------------------------------------------------------------------------------
    ' Prueba una Nueva Conexión (ProbarConexion(), AbrirConexion(), CerrarConexion() )
    Public Function ProbarConexion(ByVal nuevaconexion As String) As Boolean
        connectionBD.ConnectionString = nuevaconexion
        If AbrirConexion() Then
            ProbarConexion = True
            CerrarConexion()
        Else
            ProbarConexion = False
        End If
    End Function

    Public Function AbrirConexion() As Boolean
        Try
            connectionBD.Open()
            AbrirConexion = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            AbrirConexion = False
        End Try

    End Function

    Public Function CerrarConexion() As Boolean
        Try
            connectionBD.Close()
            CerrarConexion = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            CerrarConexion = False
        End Try
    End Function
    ' --------------------------------------------------------------------------------------

    ' --------------------------------------------------------------------------------------
    ' Conexión a la BD del sistema
    Public Function Conectar()
        Try
            If My.Settings.ConStrPredeterminada = "" Then
                Dim result As DialogResult
                result = MessageBox.Show("No cuenta con la Conexión Predeterminada a la base de datos del sistema" & vbCrLf & "¿Desea configurarla?", "Error de Conexión a Base de Datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = System.Windows.Forms.DialogResult.Yes Then
                    frmDBConnection.Show()
                End If
                Return False
            Else
                Conexion_Predeterminada()

                'cnSA = New SqlConnection(My.Settings.ConStrLocal)
                cn = connectionBD
                cn.Open()
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Desconectar()
        Try
            If cn.State = ConnectionState.Open Then
                cn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


    Public Function Conecta_Empresa() As Boolean
        Try
            If vGlobales.PCSEmpresa = "" Then
                MessageBox.Show("No cuenta con la conexión a la base de datos del sistema", "Error de Conexión a Base de Datos de la Empresa", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Else
                cnEmp = New SqlConnection(vGlobales.PCSEmpresa)
                cnEmp.Open()
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Desconecta_Empresa() As Boolean
        Try
            If cnEmp.State = ConnectionState.Open Then
                cnEmp.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
