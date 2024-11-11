Imports System.Data.SqlClient
Imports GN.Var_Globales

Public Class FrmGrados
    Dim bNuevo As Boolean = True

    Private Sub FormGrados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Muestra_Datos()
        Limpia_Datos()
    End Sub

    Private Sub Muestra_Datos()
        If cn.State = ConnectionState.Closed Then cn.Open()
        sQuery = " select IdGrados, DescripcionMin, DescripcionMay from Grados order by IdGrados asc"
        cmd = New SqlCommand(sQuery, cn)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "grados_1")
        dgvGrados.DataSource = ds.Tables("grados_1")
        dgvGrados.Columns("IdGrados").HeaderText = "Id"
        dgvGrados.Columns("DescripcionMin").HeaderText = "Descripción Minuscula"
        dgvGrados.Columns("DescripcionMay").HeaderText = "Descripción Mayuscula"
        cmd.Dispose()
        da.Dispose()
        ds.Dispose()
        cn.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Valida_Datos() Then
            If bNuevo Then
                If cn.State = ConnectionState.Closed Then cn.Open()
                sQuery = " insert into Grados (           IdGrados       ,          DescripcionMin         ,            DescripcionMay      ) " &
                         "             values ( " & Trim(txtId.Text) & " , '" & Trim(txtDescMin.Text) & "' , '" & Trim(txtDescMay.Text) & "') "
                cmd = New SqlCommand(sQuery, cn)
                If cmd.ExecuteNonQuery < 1 Then
                    MsgBox("Ocurrió un error. Intente nuevamente.", vbExclamation + vbOKOnly, pTituloMsgVentana)
                Else
                    MsgBox("Se registró correctamente.", vbInformation + vbOKOnly, pTituloMsgVentana)
                    Muestra_Datos()
                    Limpia_Datos()
                End If
                cmd.Dispose()
                cn.Close()
            Else
                If cn.State = ConnectionState.Closed Then cn.Open()
                sQuery = "update Grados set DescripcionMin = '" & Trim(txtDescMin.Text) & "', DescripcionMay = '" & Trim(txtDescMay.Text) & "' where IdGrados = " & Trim(txtId.Text)
                cmd = New SqlCommand(sQuery, cn)
                If cmd.ExecuteNonQuery < 1 Then
                    MsgBox("Ocurrió un error. Intente nuevamente.", vbExclamation + vbOKOnly, pTituloMsgVentana)
                Else
                    MsgBox("Actualizado correctamente.", vbInformation + vbOKOnly, pTituloMsgVentana)
                    Limpia_Datos()
                    Muestra_Datos()
                End If
                cmd.Dispose()
                cn.Close()
            End If
        End If
    End Sub

    Private Function Valida_Datos() As Boolean
        Dim bValida As Boolean = True
        If Len(Trim(txtId.Text)) = 0 Then
            MsgBox("Debe ingresar un ID.", vbExclamation + vbOKOnly, pTituloMsgVentana)
            bValida = False
        End If
        If Len(Trim(txtDescMin.Text)) = 0 Then
            MsgBox("Debe ingresar una descripción en minuscula", vbExclamation + vbOKOnly, pTituloMsgVentana)
            bValida = False
        End If
        If Len(Trim(txtDescMay.Text)) = 0 Then
            MsgBox("Debe ingresar una descripción en mayuscula", vbExclamation + vbOKOnly, pTituloMsgVentana)
            bValida = False
        End If
        Return bValida
    End Function

    Private Sub dgvGrados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGrados.CellClick
        If dgvGrados.Rows.Count > 0 Then
            bNuevo = False
            Dim row As DataGridViewRow = dgvGrados.SelectedRows(0)
            txtId.Text = Trim(row.Cells("IdGrados").Value)
            txtDescMin.Text = Trim(row.Cells("DescripcionMin").Value)
            txtDescMay.Text = Trim(row.Cells("DescripcionMay").Value)
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Limpia_Datos()
    End Sub

    Private Sub Limpia_Datos()
        bNuevo = True
        txtId.Text = ""
        txtDescMin.Text = ""
        txtDescMay.Text = ""

        If cn.State = ConnectionState.Closed Then cn.Open()
        sQuery = "select max(IdGrados) as IdGrados from Grados"
        cmd = New SqlCommand(sQuery, cn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                txtId.Text = dr("IdGrados") + 1
            End While
        Else
            txtId.Text = "1"
        End If
        dr.Close()
        cmd.Dispose()
        cn.Close()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub

End Class