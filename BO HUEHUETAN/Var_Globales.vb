Imports System.Data.SqlClient
Imports System.Data
Module Var_Globales

    'Variables anteriores 
    Public iIdCasoAsigancion As Integer = 0
    Public bTipoUsuario As Boolean = True
    Public pStrConHelpDesk As String
    Public sEstatusCaso As String
    Public pCveIng As Integer
    Public pNumZaf As Integer
    Public pNomIng As String
    Public pDomIng As String
    Public pPobIng As String
    Public pRFCIng As String
    Public pIdUsuario As String
    Public pIdModulo As Integer
    Public pIdPerfil As Integer
    Public pServidorBD As String = ""
    Public pBD As String = ""
    Public pUsuarioBD As String = ""
    Public pPassBD As String = ""
    Public cn As New SqlConnection
    Public ds As DataSet
    Public dr As SqlDataReader
    Public da As SqlDataAdapter
    Public cmd As New SqlCommand
    Public sQuery As String
    Public pTituloMsgVentana As String = "SEDENA - Guardia Nacional."
    Public pFechaFormatoGuardar As String = "dd/MM/yyyy HH:mm:ss"
    Public pFechaFormatoMostrar As String = "dd/MM/yyyy HH:mm:ss"
    Public pFechaFormatoCortoGuardar As String = "dd/MM/yyyy"
    Public pFechaFormatoCortoMostrar As String = "dd/MM/yyyy"
    Public pPathAyuda As String = ""
    Public pTituloMsgNoVideo As String = "Esta opción no tiene video de ayuda asignado."
    Public pGenerarSolicitud As Boolean = True
    Public pGenerarSolicAlMomentoDe As String = ""
    Public pProgramarContratosNoAut As Boolean = True


    'Public cn As New SqlConnection
    'Public Str2 As String
    'Public StrConexion1 As String = "Data Source=LAPTOP-9ELDR1PN\SQLEXPRESS;initial catalog=GuardiaNacional;user id=sasa;password=sasa;pooling = false; integrated security=true"
    'Public cn As New SqlConnection(StrConexion1)

    'Dim sTextoDBConfigEpicor As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "DBConfigEpicor.HelpDesk")
    Dim sTextoDBConfigHelpDesk As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "DBConfig.Config")

    Public Function CargaPublic_GN() As Boolean

        Dim divide
        Dim bSigue As Boolean = True
        Dim x, y
        Dim i As Integer = 0

        ' Carga conexion para epicor (para consulta de usuario) 
        divide = Split(sTextoDBConfigHelpDesk, vbCrLf)
        'Cargo la cadena de conexión
        If Len(Trim(divide(0))) = 0 Then
            MessageBox.Show("No se cargó la cadena de conexión del archivo de configuracion.", "HelpDesk", MessageBoxButtons.OK, MessageBoxIcon.Error)
            bSigue = False
        Else
            ' Cargo la cadena de conexión
            pStrConHelpDesk = divide(0)
            cn.ConnectionString = pStrConHelpDesk

            ' Obtengo el servidor, BD, usuario y password de la conexión
            x = Split(pStrConHelpDesk, ";")
            For i = 0 To UBound(x)
                If InStr(x(i), "Data Source=") = 1 Then
                    y = Split(x(i), "=")
                    pServidorBD = y(1)
                End If

                If InStr(x(i), "Initial Catalog=") = 1 Then
                    y = Split(x(i), "=")
                    pBD = y(1)
                End If

                If InStr(x(i), "User ID=") = 1 Then
                    y = Split(x(i), "=")
                    pUsuarioBD = y(1)
                End If

                If InStr(x(i), "Password=") = 1 Then
                    y = Split(x(i), "=")
                    pPassBD = y(1)
                End If
            Next i

        End If

        Return bSigue
    End Function

    Public Sub soloNumeros(ByRef e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub NumConFrac(ByVal texto As TextBox, ByVal e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not texto.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub soloLetras(ByRef e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Module
