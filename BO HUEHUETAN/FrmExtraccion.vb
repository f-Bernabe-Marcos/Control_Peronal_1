Imports System.Data.SqlClient
Imports GN.Var_Globales
Public Class FrmExtraccion
    Private Sub FrmExtraccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga_Entorno()
        Carga_AnioMes()
        Carga_Datos_Actual()
    End Sub

    Private Sub Carga_Entorno()
        If cn.State = ConnectionState.Closed Then cn.Open()
        sQuery = " select IdAnio, DescAnio from Anio order by DescAnio "
        cmd = New SqlCommand(sQuery, cn)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "anios")
        CbAnio.DataSource = ds.Tables("anios")
        CbAnio.ValueMember = ds.Tables("anios").Columns("DescAnio").ToString
        CbAnio.DisplayMember = ds.Tables("anios").Columns("DescAnio").ToString
        cmd.Dispose()
        da.Dispose()
        ds.Dispose()

        sQuery = " select IdMes, DescMes from Mes order by IdMes "
        cmd = New SqlCommand(sQuery, cn)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "meses")
        CbMes.DataSource = ds.Tables("meses")
        CbMes.ValueMember = ds.Tables("meses").Columns("IdMes").ToString
        CbMes.DisplayMember = ds.Tables("meses").Columns("DescMes").ToString
        cmd.Dispose()
        da.Dispose()
        ds.Dispose()

        sQuery = " select IdCuota, CantCuota from Cuota order by IdCuota "
        cmd = New SqlCommand(sQuery, cn)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "cuota")
        CbCuota.DataSource = ds.Tables("cuota")
        CbCuota.ValueMember = ds.Tables("cuota").Columns("IdCuota").ToString
        CbCuota.DisplayMember = ds.Tables("cuota").Columns("CantCuota").ToString
        cmd.Dispose()
        da.Dispose()
        ds.Dispose()
        cn.Close()

        CbAnio.SelectedValue = Date.Now.Year
        CbMes.SelectedValue = Date.Now.Month
    End Sub

    Private Sub Carga_AnioMes()
        If cn.State = ConnectionState.Closed Then cn.Open()
        sQuery = " select IdAnioMes, AnioProc, MesProc, rtrim(FechaIniProc) + ' - ' + rtrim(FechaFinProc) as FechaProc from AnioMesProceso " &
                 " where AnioProc = " & CbAnio.SelectedValue & " and MesProc = " & CbMes.SelectedValue &
                 " order by FechaIniProc "
        cmd = New SqlCommand(sQuery, cn)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "anioMes")
        CbDetall.DataSource = ds.Tables("anioMes")
        CbDetall.ValueMember = ds.Tables("anioMes").Columns("IdAnioMes").ToString
        CbDetall.DisplayMember = ds.Tables("anioMes").Columns("FechaProc").ToString

        If ds.Tables("anioMes").Rows.Count > 0 Then
            GbModificaciones.Enabled = True
            GbVisuaDatos.Enabled = True
        Else
            GbModificaciones.Enabled = False
            GbVisuaDatos.Enabled = False
        End If

        cmd.Dispose()
        da.Dispose()
        ds.Dispose()
        cn.Close()
    End Sub

    Private Sub CbAnio_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CbAnio.SelectionChangeCommitted
        Carga_AnioMes()
        Carga_Datos_Actual()
    End Sub

    Private Sub CbMes_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CbMes.SelectionChangeCommitted
        Carga_AnioMes()
        Carga_Datos_Actual()
    End Sub

    Private Sub BtnCargar_Click(sender As Object, e As EventArgs) Handles BtnCargar.Click
        'Carga_Anterior()
        Carga_Datos_Actual()
    End Sub

    Private Sub Carga_Anterior()
        'If cn.State = ConnectionState.Closed Then cn.Open()
        'sQuery = " select AnioProc, MesProc, rtrim(FechaIniProc) + ' - ' + rtrim(FechaFinProc) as FechaProc from AnioMesProceso " &
        '         " where AnioProc = " & CbAnio.SelectedValue & " and MesProc = " & CbMes.SelectedValue &
        '         " order by FechaIniProc "
        'cmd = New SqlCommand(sQuery, cn)
        'da = New SqlDataAdapter(cmd)
        'ds = New DataSet
        'da.Fill(ds, "anioMes")
        'CbDetall.DataSource = ds.Tables("anioMes")
        'CbDetall.ValueMember = ds.Tables("anioMes").Columns("MesProc").ToString
        'CbDetall.DisplayMember = ds.Tables("anioMes").Columns("FechaProc").ToString
        'cmd.Dispose()
        'da.Dispose()
        'ds.Dispose()
        'cn.Close()
    End Sub

    Private Sub Carga_Datos_Actual()
        If CbDetall.SelectedIndex > 0 Then
            If cn.State = ConnectionState.Closed Then cn.Open()
            sQuery = " select IdExt, MatriculaExt, GradoPer, DescripcionMay, NombreCompleto, AnioExt, MesExt, DiasExt, IdAnioMesExt, CuotaExt, (DiasExt *  CuotaExt) as Total from Personal " &
                     " left join Extraccion on  MatriculaExt = MatriculaPer " &
                     " Left join Grados On IdGrados = GradoPer " &
                     " where EstatusPer = 1 and IdExt is null " &
                     " order by GradoPer desc, NombreCompleto asc"
            cmd = New SqlCommand(sQuery, cn)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "datosActivos")
            DgvActivos.DataSource = ds.Tables("datosActivos")
            DgvActivos.Columns("IdExt").Visible = False
            DgvActivos.Columns("MatriculaExt").Visible = False
            DgvActivos.Columns("GradoPer").Visible = False
            DgvActivos.Columns("DescripcionMay").HeaderText = "Grado"
            DgvActivos.Columns("NombreCompleto").HeaderText = "Nombre"
            DgvActivos.Columns("AnioExt").Visible = False
            DgvActivos.Columns("MesExt").Visible = False
            DgvActivos.Columns("DiasExt").Visible = False
            DgvActivos.Columns("IdAnioMesExt").Visible = False
            DgvActivos.Columns("CuotaExt").Visible = False
            DgvActivos.Columns("Total").Visible = False
            cmd.Dispose()
            da.Dispose()
            ds.Dispose()

            sQuery = " select IdExt, MatriculaExt, GradoPer, DescripcionMay, NombreCompleto, AnioExt, MesExt, DiasExt, IdAnioMesExt, CuotaExt, (DiasExt *  CuotaExt) as Total from Extraccion " &
                     " left join Personal on MatriculaPer = MatriculaExt " &
                     " Left join Grados On IdGrados = GradoPer " &
                     " where AnioExt = " & CbAnio.SelectedValue & " and MesExt = " & CbMes.SelectedValue & " and IdAnioMesExt = " & CbDetall.SelectedValue &
                     " order by GradoPer desc, NombreCompleto asc"
            cmd = New SqlCommand(sQuery, cn)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "datosGenBus")
            DgvExtraccion.DataSource = ds.Tables("datosGenBus")
            DgvExtraccion.Columns("IdExt").HeaderText = "Id"
            DgvExtraccion.Columns("MatriculaExt").Visible = False
            DgvExtraccion.Columns("GradoPer").Visible = False
            DgvExtraccion.Columns("DescripcionMay").HeaderText = "Grado"
            DgvExtraccion.Columns("NombreCompleto").HeaderText = "Nombre"
            DgvExtraccion.Columns("AnioExt").Visible = False
            DgvExtraccion.Columns("MesExt").Visible = False
            DgvExtraccion.Columns("DiasExt").HeaderText = "Dias"
            DgvExtraccion.Columns("IdAnioMesExt").Visible = False
            DgvExtraccion.Columns("CuotaExt").HeaderText = "Cuota"
            DgvExtraccion.Columns("Total").HeaderText = "Total"
            cmd.Dispose()
            da.Dispose()
            ds.Dispose()
            cn.Close()

        End If
    End Sub

    Private Sub CbDetall_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CbDetall.SelectionChangeCommitted
        Carga_Datos_Actual()
    End Sub

    Private Sub BtnPasar_Click(sender As Object, e As EventArgs) Handles BtnPasar.Click
        For Each row As DataGridViewRow In DgvActivos.SelectedRows
            DgvExtraccion.Rows.Add(row.AccessibilityObject.Value)
            DgvActivos.Rows.Remove(row)
        Next
    End Sub

End Class