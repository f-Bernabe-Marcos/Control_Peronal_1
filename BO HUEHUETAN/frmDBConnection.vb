
Imports System.Data.SqlClient
Imports System.IO

Public Class frmDBConnection

    Dim claseconnect As New cConexion
    Dim bPruebaOK As Boolean = False
    Dim bPruebaExtOk As Boolean = False
    Dim strConOK As String = ""
    Dim fConexion As New cConexion
    'Dim cn As New SqlConnection(fConexion.Obtiene_Conex_Predet.ToString())

    Private Sub frmDBConnection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x, y
        Dim I As Integer

        ' Si hay una Conexión local
        ' Primero cargo el string conexion y lo desglozo en partes para asignarlas
        If My.Settings.ConStrLocal.ToString <> "" Then
            x = Split(My.Settings.ConStrLocal, ";")
            For I = 0 To UBound(x)
                If InStr(x(I), "Data Source=") = 1 Then
                    y = Split(x(I), "=")
                    txtServer.Text = y(1)
                End If

                If InStr(x(I), "Initial Catalog=") = 1 Then
                    y = Split(x(I), "=")
                    txtDataBase.Text = y(1)
                End If

                If InStr(x(I), "Integrated Security=") = 1 Then
                    y = Split(x(I), "=")
                    If y(1) = "True" Then
                        optAutWin.Checked = True
                    End If
                    If y(1) = "False" Then
                        optAutSQL.Checked = True
                    End If
                End If

                If InStr(x(I), "Persist Security Info=") = 1 Then
                    y = Split(x(I), "=")
                    If y(1) = "True" Then
                        optAutSQL.Checked = True
                    End If
                    If y(1) = "False" Then
                        optAutWin.Checked = True
                    End If
                End If

                If InStr(x(I), "User ID=") = 1 Then
                    y = Split(x(I), "=")
                    txtUser.Text = y(1)
                End If

                If InStr(x(I), "Password=") = 1 Then
                    y = Split(x(I), "=")
                    txtPassword.Text = y(1)
                End If
            Next I
        End If

        ' Si hay una Conexión Externa
        ' Primero cargo el string conexion y lo desglozo en partes para asignarlas
        If My.Settings.ConStrExterna.ToString <> "" Then
            x = Split(My.Settings.ConStrExterna, ";")
            For I = 0 To UBound(x)
                If InStr(x(I), "Data Source=") = 1 Then
                    y = Split(x(I), "=")
                    txtServerExt.Text = y(1)
                End If

                If InStr(x(I), "Initial Catalog=") = 1 Then
                    y = Split(x(I), "=")
                    txtDataBaseExt.Text = y(1)
                End If

                If InStr(x(I), "Integrated Security=") = 1 Then
                    y = Split(x(I), "=")
                    If y(1) = "True" Then
                        optAutWinExt.Checked = True
                    End If
                    If y(1) = "False" Then
                        optAutSQLExt.Checked = True
                    End If
                End If

                If InStr(x(I), "Persist Security Info=") = 1 Then
                    y = Split(x(I), "=")
                    If y(1) = "True" Then
                        optAutSQLExt.Checked = True
                    End If
                    If y(1) = "False" Then
                        optAutWinExt.Checked = True
                    End If
                End If

                If InStr(x(I), "User ID=") = 1 Then
                    y = Split(x(I), "=")
                    txtUserExt.Text = y(1)
                End If

                If InStr(x(I), "Password=") = 1 Then
                    y = Split(x(I), "=")
                    txtPasswordExt.Text = y(1)
                End If
            Next I
        End If
    End Sub

    Private Sub btnPruebaCon_Click(sender As Object, e As EventArgs) Handles btnPruebaCon.Click
        Dim strCon As String
        'Ejemplo de Acceso con seguridad de SQL
        'Data Source=IAT-SQL\LAJOYA;Integrated Security=False;User ID=sa;Password=********;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False
        'Ejemplo de Acceso con Seguridad de Windows
        'Data Source=ACLAIRGUE-PC\SQLEXPRESS;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False


        If txtServer.Text <> "" And txtDataBase.Text <> "" Then
            strCon = ""
            If optAutSQL.Checked = True Then
                If txtUser.Text <> "" And txtPassword.Text <> "" Then
                    strCon = ";Integrated Security=False;User ID=" + txtUser.Text + ";Password=" + txtPassword.Text
                End If
            End If
            If optAutWin.Checked = True Then
                strCon = ";Integrated Security=True"
            End If
            Dim nuevaconexion As String = "Data Source=" + txtServer.Text + ";Initial Catalog=" + txtDataBase.Text + strCon + ";Connect Timeout=15;Encrypt=False;TrustServerCertificate=False"
            If claseconnect.ProbarConexion(nuevaconexion) Then
                MessageBox.Show("Conexión exitosa", "Probar Conexión", MessageBoxButtons.OK, MessageBoxIcon.Information)
                bPruebaOK = True
            Else
                MessageBox.Show("Conexión erronea", "Probar Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                bPruebaOK = False
            End If
        End If
    End Sub

    Private Sub btnGuardaCon_Click(sender As Object, e As EventArgs) Handles btnGuardaCon.Click
        Dim bPasa As Boolean = False
        Dim strCon As String = ""

        If bPruebaOK = True Then
            If optAutSQL.Checked = True Then
                If txtUser.Text <> "" And txtPassword.Text <> "" Then
                    bPasa = True
                Else
                    bPasa = False
                End If
            End If
            If optAutWin.Checked = True Then
                bPasa = True
            End If
            If txtServer.Text <> "" And txtDataBase.Text <> "" And bPasa Then
                Try
                    strCon = ""
                    If optAutSQL.Checked = True Then
                        strCon = ";Integrated Security=False;User ID=" + txtUser.Text + ";Password=" + txtPassword.Text
                    End If
                    If optAutWin.Checked = True Then
                        strCon = ";Integrated Security=True"
                    End If
                    Dim sConexionOK As String = "Data Source=" + txtServer.Text + ";Initial Catalog=" + txtDataBase.Text + strCon + ";Connect Timeout=0;Encrypt=False;TrustServerCertificate=False"
                    My.Settings.ConStrLocal = sConexionOK
                    My.Settings.Save()
                    MessageBox.Show("La Conexión se guardó correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else
                MessageBox.Show("Todos los datos son necesarios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Primero debe realizar la prueba de conexión.", "Guardar Datos de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub chkMuestraCar_CheckedChanged(sender As Object, e As EventArgs) Handles chkMuestraCar.CheckedChanged
        If chkMuestraCar.CheckState = CheckState.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        bPruebaOK = False
    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged
        bPruebaOK = False
    End Sub

    Private Sub txtServer_TextChanged(sender As Object, e As EventArgs) Handles txtServer.TextChanged
        bPruebaOK = False
    End Sub

    Private Sub txtDataBase_TextChanged(sender As Object, e As EventArgs) Handles txtDataBase.TextChanged
        bPruebaOK = False
    End Sub

    Private Sub optAutSQL_CheckedChanged(sender As Object, e As EventArgs) Handles optAutSQL.CheckedChanged
        If optAutSQL.Checked = True Then
            txtUser.Text = ""
            txtUser.Enabled = True
            txtPassword.Text = ""
            txtPassword.Enabled = True
            chkMuestraCar.Checked = False
            chkMuestraCar.Enabled = True
        End If
        bPruebaOK = False
    End Sub

    Private Sub optAutWin_CheckedChanged_1(sender As Object, e As EventArgs) Handles optAutWin.CheckedChanged
        If optAutWin.Checked = True Then
            txtUser.Text = ""
            txtUser.Enabled = False
            txtPassword.Text = ""
            txtPassword.Enabled = False
            chkMuestraCar.Checked = False
            chkMuestraCar.Enabled = False
        End If
        bPruebaOK = False
    End Sub

    Private Sub btnConexLocPred_Click(sender As Object, e As EventArgs) Handles btnConexLocPred.Click
        If My.Settings.ConStrLocal.ToString <> "" Then
            Try
                My.Settings.ConStrPredeterminada = "L"
                My.Settings.Save()

                ' Crear el archivo de configuración a la base de datos en el Temp
                Crea_DBConfig_Epicor()

                MessageBox.Show("La Conexión Local se estableció como Predeterminada", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("Antes debe guardar la Conexión Local.", "Guardar Datos de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Crea_DBConfig_Epicor()
        Try
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "DBConfig.Config", fConexion.Obtiene_Conex_Predet.ToString() & vbCrLf, False)
        Catch ex As Exception
            MsgBox("Error al crear el archivo de configuración a la base de datos. " & ex.Message)
        End Try
    End Sub

    Private Sub Crea_DBConfig_HelpDesk()
        Try
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "DBConfig.Config", fConexion.Obtiene_Conex_Predet_HelpDesk.ToString() & vbCrLf, False)
        Catch ex As Exception
            MsgBox("Error al crear el archivo de configuración a la base de datos. " & ex.Message)
        End Try
    End Sub


    ' **************************************************
    ' Aquí comienza el proceso para la Conexión Externa
    ' **************************************************

    Private Sub optAutSQLExt_CheckedChanged(sender As Object, e As EventArgs) Handles optAutSQLExt.CheckedChanged
        If optAutSQLExt.Checked = True Then
            txtUserExt.Text = ""
            txtUserExt.Enabled = True
            txtPasswordExt.Text = ""
            txtPasswordExt.Enabled = True
            chkMuestraCarExt.Checked = False
            chkMuestraCarExt.Enabled = True
        End If
        bPruebaExtOK = False
    End Sub

    Private Sub optAutWinExt_CheckedChanged(sender As Object, e As EventArgs) Handles optAutWinExt.CheckedChanged
        If optAutWinExt.Checked = True Then
            txtUserExt.Text = ""
            txtUserExt.Enabled = False
            txtPasswordExt.Text = ""
            txtPasswordExt.Enabled = False
            chkMuestraCarExt.Checked = False
            chkMuestraCarExt.Enabled = False
        End If
        bPruebaExtOK = False
    End Sub

    Private Sub txtServerExt_TextChanged(sender As Object, e As EventArgs) Handles txtServerExt.TextChanged
        bPruebaExtOK = False
    End Sub

    Private Sub txtDataBaseExt_TextChanged(sender As Object, e As EventArgs) Handles txtDataBaseExt.TextChanged
        bPruebaExtOK = False
    End Sub

    Private Sub txtUserExt_TextChanged(sender As Object, e As EventArgs) Handles txtUserExt.TextChanged
        bPruebaExtOK = False
    End Sub

    Private Sub txtPasswordExt_TextChanged(sender As Object, e As EventArgs) Handles txtPasswordExt.TextChanged
        bPruebaExtOK = False
    End Sub

    Private Sub chkMuestraCarExt_CheckedChanged(sender As Object, e As EventArgs) Handles chkMuestraCarExt.CheckedChanged
        If chkMuestraCarExt.CheckState = CheckState.Checked Then
            txtPasswordExt.UseSystemPasswordChar = False
        Else
            txtPasswordExt.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnPruebaConExt_Click(sender As Object, e As EventArgs) Handles btnPruebaConExt.Click
        Dim strCon As String
        'Ejemplo de Acceso con seguridad de SQL
        'Data Source=IAT-SQL\LAJOYA;Integrated Security=False;User ID=sa;Password=********;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False
        'Ejemplo de Acceso con Seguridad de Windows
        'Data Source=ACLAIRGUE-PC\SQLEXPRESS;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False


        If txtServerExt.Text <> "" And txtDataBaseExt.Text <> "" Then
            strCon = ""
            If optAutSQLExt.Checked = True Then
                If txtUserExt.Text <> "" And txtPasswordExt.Text <> "" Then
                    strCon = ";Integrated Security=False;User ID=" + txtUserExt.Text + ";Password=" + txtPasswordExt.Text
                End If
            End If
            If optAutWinExt.Checked = True Then
                strCon = ";Integrated Security=True"
            End If
            Dim nuevaconexion As String = "Data Source=" + txtServerExt.Text + ";Initial Catalog=" + txtDataBaseExt.Text + strCon + ";Connect Timeout=15;Encrypt=False;TrustServerCertificate=False"
            If claseconnect.ProbarConexion(nuevaconexion) Then
                MessageBox.Show("Conexión exitosa", "Probar Conexión", MessageBoxButtons.OK, MessageBoxIcon.Information)
                bPruebaExtOK = True
            Else
                MessageBox.Show("Conexión erronea", "Probar Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                bPruebaExtOK = False
            End If
        End If
    End Sub

    Private Sub btnGuardaConExt_Click(sender As Object, e As EventArgs) Handles btnGuardaConExt.Click
        Dim bPasa As Boolean = False
        Dim strCon As String = ""

        If bPruebaExtOK = True Then
            If optAutSQLExt.Checked = True Then
                If txtUserExt.Text <> "" And txtPasswordExt.Text <> "" Then
                    bPasa = True
                Else
                    bPasa = False
                End If
            End If

            If optAutWinExt.Checked = True Then
                bPasa = True
            End If

            If txtServerExt.Text <> "" And txtDataBaseExt.Text <> "" And bPasa Then
                Try
                    strCon = ""
                    If optAutSQLExt.Checked = True Then
                        strCon = ";Integrated Security=False;User ID=" + txtUserExt.Text + ";Password=" + txtPasswordExt.Text
                    End If

                    If optAutWinExt.Checked = True Then
                        strCon = ";Integrated Security=True"
                    End If

                    Dim sConexionOK As String = "Data Source=" + txtServerExt.Text + ";Initial Catalog=" + txtDataBaseExt.Text + strCon + ";Connect Timeout=0;Encrypt=False;TrustServerCertificate=False"
                    My.Settings.ConStrExterna = sConexionOK
                    My.Settings.Save()
                    MessageBox.Show("La Conexión Externa se guardó correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else
                MessageBox.Show("Todos los datos son necesarios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Primero debe realizar la prueba de conexión.", "Guardar Datos de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnConexExtPred_Click(sender As Object, e As EventArgs) Handles btnConexExtPred.Click
        If My.Settings.ConStrExterna.ToString <> "" Then
            Try
                My.Settings.ConStrPredeterminada = "E"
                My.Settings.Save()

                ' Crear el archivo de configuración a la base de datos en el Temp
                Crea_DBConfig_HelpDesk()

                MessageBox.Show("La Conexión Externa se estableció como Predeterminada", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("Antes debe guardar la Conexión Externa.", "Guardar Datos de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

End Class
