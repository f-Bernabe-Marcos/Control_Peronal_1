Imports System.Data.SqlClient
Imports GN.Var_Globales
Imports System.Drawing.Imaging
Imports System.IO

Public Class FrmDatosGenerales
    Dim bNuevo As Boolean = True
    Dim byImgAdjunto() As Byte

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If Len(Trim(TxtBusqueda.Text)) > 0 Then
            If cn.State = ConnectionState.Closed Then cn.Open()
            sQuery = "select IdPer, DescripcionMay, NombreCompleto, MatriculaPer, GradoPer, Nombre, ApellidoPaterno, ApellidoMaterno, Cuenta, Sucursal, CompaniaPer, CompaniaIntegracion, EstatusPer, SituacionPer " &
                     "from Personal " &
                     "left join Grados on GradoPer = IdGrados " &
                     "where NombreCompleto like '%" & Trim(TxtBusqueda.Text) & "%' or MatriculaPer like '%" & Trim(TxtBusqueda.Text) & "%' " &
                     "order by GradoPer desc, NombreCompleto asc"
            cmd = New SqlCommand(sQuery, cn)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "datosGenBus")
            DgvBusqueda.DataSource = ds.Tables("datosGenBus")
            DgvBusqueda.Columns("IdPer").HeaderText = "Id"
            DgvBusqueda.Columns("DescripcionMay").HeaderText = "Grado"
            DgvBusqueda.Columns("NombreCompleto").HeaderText = "Nombre Completo"
            DgvBusqueda.Columns("MatriculaPer").HeaderText = "Matricula"
            DgvBusqueda.Columns("GradoPer").Visible = False
            DgvBusqueda.Columns("Nombre").Visible = False
            DgvBusqueda.Columns("ApellidoPaterno").Visible = False
            DgvBusqueda.Columns("ApellidoMaterno").Visible = False
            DgvBusqueda.Columns("Cuenta").Visible = False
            DgvBusqueda.Columns("Sucursal").Visible = False
            DgvBusqueda.Columns("CompaniaPer").Visible = False
            DgvBusqueda.Columns("CompaniaIntegracion").Visible = False
            DgvBusqueda.Columns("EstatusPer").Visible = False
            DgvBusqueda.Columns("SituacionPer").Visible = False
            cmd.Dispose()
            da.Dispose()
            ds.Dispose()
            cn.Close()

            Limpia_Datos()
        Else
            MsgBox("Debe ingresar una descripción para la busqueda.", vbExclamation + vbOKOnly, pTituloMsgVentana)
        End If
    End Sub

    Private Sub FrmDatosGenerales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Muestra_Datos()
        Carga_Entorno()
        Ultimo_Registro()
    End Sub

    Private Sub Muestra_Datos()
        If cn.State = ConnectionState.Closed Then cn.Open()
        sQuery = "select IdPer, DescripcionMay, NombreCompleto, MatriculaPer, GradoPer, Nombre, ApellidoPaterno, ApellidoMaterno, Cuenta, Sucursal, CompaniaPer, CompaniaIntegracion, EstatusPer, SituacionPer from personal " &
                 "left join Grados on GradoPer = IdGrados " &
                 "order by GradoPer desc, NombreCompleto asc"
        cmd = New SqlCommand(sQuery, cn)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "datosGen")
        DgvBusqueda.DataSource = ds.Tables("datosGen")
        DgvBusqueda.Columns("IdPer").HeaderText = "Id"
        DgvBusqueda.Columns("DescripcionMay").HeaderText = "Grado"
        DgvBusqueda.Columns("NombreCompleto").HeaderText = "Nombre Completo"
        DgvBusqueda.Columns("MatriculaPer").HeaderText = "Matricula"
        DgvBusqueda.Columns("GradoPer").Visible = False
        DgvBusqueda.Columns("Nombre").Visible = False
        DgvBusqueda.Columns("ApellidoPaterno").Visible = False
        DgvBusqueda.Columns("ApellidoMaterno").Visible = False
        DgvBusqueda.Columns("Cuenta").Visible = False
        DgvBusqueda.Columns("Sucursal").Visible = False
        DgvBusqueda.Columns("CompaniaPer").Visible = False
        DgvBusqueda.Columns("CompaniaIntegracion").Visible = False
        DgvBusqueda.Columns("EstatusPer").Visible = False
        DgvBusqueda.Columns("SituacionPer").Visible = False
        cmd.Dispose()
        da.Dispose()
        ds.Dispose()
        cn.Close()
    End Sub

    Private Sub Carga_Entorno()
        If cn.State = ConnectionState.Closed Then cn.Open()
        sQuery = " select IdGrados, rtrim(IdGrados) + ' - ' + DescripcionMay as DescripcionMay from Grados order by IdGrados "
        cmd = New SqlCommand(sQuery, cn)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "grados")
        CbGrado.DataSource = ds.Tables("grados")
        CbGrado.ValueMember = ds.Tables("grados").Columns("IdGrados").ToString
        CbGrado.DisplayMember = ds.Tables("grados").Columns("DescripcionMay").ToString
        cmd.Dispose()
        da.Dispose()
        ds.Dispose()

        sQuery = " select IdSuc, rtrim(IdSuc) + ' - ' + NomSuc as NomSuc from Sucursales order by IdSuc "
        cmd = New SqlCommand(sQuery, cn)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "bancos")
        CbBanco.DataSource = ds.Tables("bancos")
        CbBanco.ValueMember = ds.Tables("bancos").Columns("IdSuc").ToString
        CbBanco.DisplayMember = ds.Tables("bancos").Columns("NomSuc").ToString
        cmd.Dispose()
        da.Dispose()
        ds.Dispose()

        sQuery = " select NumCia, rtrim(NumCia) + ' - ' + NombreCia as NombreCia from Compania order by NumCia "
        cmd = New SqlCommand(sQuery, cn)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "compania")
        CbOrganica.DataSource = ds.Tables("compania")
        CbOrganica.ValueMember = ds.Tables("compania").Columns("NumCia").ToString
        CbOrganica.DisplayMember = ds.Tables("compania").Columns("NombreCia").ToString
        cmd.Dispose()
        da.Dispose()
        ds.Dispose()

        sQuery = " select NumCia, rtrim(NumCia) + ' - ' + NombreCia as NombreCia from Compania order by NumCia "
        cmd = New SqlCommand(sQuery, cn)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "companiaInt")
        CbIntegracion.DataSource = ds.Tables("companiaInt")
        CbIntegracion.ValueMember = ds.Tables("companiaInt").Columns("NumCia").ToString
        CbIntegracion.DisplayMember = ds.Tables("companiaInt").Columns("NombreCia").ToString
        cmd.Dispose()
        da.Dispose()
        ds.Dispose()

        sQuery = " select IdEstatus, rtrim(IdEstatus) + ' - ' + DescEstatus as DescEstatus from Estatus order by IdEstatus "
        cmd = New SqlCommand(sQuery, cn)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "estatus")
        CbEstatus.DataSource = ds.Tables("estatus")
        CbEstatus.ValueMember = ds.Tables("estatus").Columns("IdEstatus").ToString
        CbEstatus.DisplayMember = ds.Tables("estatus").Columns("DescEstatus").ToString
        cmd.Dispose()
        da.Dispose()
        ds.Dispose()

        cn.Close()

        'Mayuculas 
        TxtBusqueda.CharacterCasing = CharacterCasing.Upper
        TxtMatricula.CharacterCasing = CharacterCasing.Upper
        TxtNombre.CharacterCasing = CharacterCasing.Upper
        TxtPaterno.CharacterCasing = CharacterCasing.Upper
        TxtMaterno.CharacterCasing = CharacterCasing.Upper
        TxtNomCompleto.CharacterCasing = CharacterCasing.Upper

    End Sub

    Private Sub DgvBusqueda_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvBusqueda.CellClick
        If DgvBusqueda.Rows.Count > 0 Then
            bNuevo = False
            Dim row As DataGridViewRow = DgvBusqueda.SelectedRows(0)
            TxtId.Text = Trim(row.Cells("IdPer").Value)
            CbGrado.SelectedValue = Trim(row.Cells("GradoPer").Value)
            TxtMatricula.Text = Trim(row.Cells("MatriculaPer").Value)
            TxtNombre.Text = Trim(row.Cells("Nombre").Value)
            TxtPaterno.Text = Trim(row.Cells("ApellidoPaterno").Value)
            TxtMaterno.Text = Trim(row.Cells("ApellidoMaterno").Value)
            TxtNomCompleto.Text = Trim(row.Cells("NombreCompleto").Value)
            TxtCuenta.Text = Trim(row.Cells("Cuenta").Value)
            CbBanco.SelectedValue = Trim(row.Cells("Sucursal").Value)
            CbOrganica.SelectedValue = Trim(row.Cells("CompaniaPer").Value)
            CbIntegracion.SelectedValue = Trim(row.Cells("CompaniaIntegracion").Value)
            CbEstatus.SelectedValue = Trim(row.Cells("EstatusPer").Value)

            If cn.State = ConnectionState.Closed Then cn.Open()
            sQuery = " select foto from Personal where IdPer = " & Trim(row.Cells("IdPer").Value)
            cmd = New SqlCommand(sQuery, cn)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    byImgAdjunto = dr("foto")
                End While
            End If
            dr.Close()
            cn.Close()

            MuestraImagen(byImgAdjunto)

        End If
    End Sub

    Sub MuestraImagen(ByVal byImgAdjunto As Byte())
        ' Imagen adjunto 
        If byImgAdjunto.ToString <> "0" And byImgAdjunto.ToString <> "0x30" And byImgAdjunto.Length <> 0 And byImgAdjunto.Length <> 1 Then
            PbFoto.Image = Image.FromStream(New MemoryStream(byImgAdjunto))
            PbFoto.SizeMode = PictureBoxSizeMode.StretchImage
        ElseIf byImgAdjunto.Length <= 1 Then
            PbFoto.Image = Nothing
        End If
    End Sub

    Private Sub BtnBuscaAdjunto_Click(sender As Object, e As EventArgs) Handles BtnBuscaAdjunto.Click
        'Buscar imagen desde disco duro
        Using OpenFileDialog1 As New OpenFileDialog()

            With OpenFileDialog1
                .CheckFileExists = True
                .ShowReadOnly = False
                .Filter = "All Files|*.*|Bitmap Files (*)|*.bmp;*.gif;*.jpg;*.png"
                .FilterIndex = 2

                If .ShowDialog = DialogResult.OK Then
                    ' Mostramos la imagen en el control PictureBox
                    PbFoto.ImageLocation = .FileName
                End If
            End With

        End Using
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Limpia_Datos()
        Ultimo_Registro()
    End Sub

    Private Sub Limpia_Datos()
        bNuevo = True
        TxtId.Text = ""
        CbGrado.SelectedIndex = 0
        TxtMatricula.Text = ""
        TxtNombre.Text = ""
        TxtPaterno.Text = ""
        TxtMaterno.Text = ""
        TxtNomCompleto.Text = ""
        TxtCuenta.Text = ""
        CbBanco.SelectedIndex = 0
        CbOrganica.SelectedIndex = 0
        CbIntegracion.SelectedIndex = 0
        CbEstatus.SelectedIndex = 0
        PbFoto.Image = Nothing
    End Sub

    Private Sub Ultimo_Registro()
        If cn.State = ConnectionState.Closed Then cn.Open()
        'If Not dr.IsClosed Then dr.Close()
        sQuery = " select isnull(max(IdPer),0) as IdPer from Personal "
        cmd = New SqlCommand(sQuery, cn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                TxtId.Text = dr("IdPer") + 1
            End While
        End If
        dr.Close()
        cn.Close()
        cmd.Dispose()
    End Sub

    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged
        Nombre_Completo()
    End Sub

    Private Sub TxtPaterno_TextChanged(sender As Object, e As EventArgs) Handles TxtPaterno.TextChanged
        Nombre_Completo()
    End Sub

    Private Sub TxtMaterno_TextChanged(sender As Object, e As EventArgs) Handles TxtMaterno.TextChanged
        Nombre_Completo()
    End Sub

    Private Sub Nombre_Completo()
        TxtNomCompleto.Text = Trim(TxtNombre.Text) & " " & Trim(TxtPaterno.Text) & " " & Trim(TxtMaterno.Text)
    End Sub

    Private Sub TxtCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCuenta.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Valida_Datos() Then
            If bNuevo Then
                If cn.State = ConnectionState.Closed Then cn.Open()
                sQuery = " insert into Personal (             MatriculaPer          ,                 GradoPer            ,              Nombre            ,          ApellidoPaterno        ,           ApellidoMaterno       ,              NombreCompleto         ,                Cuenta          ,           Sucursal            ,             CompaniaPer          ,           CompaniaIntegracion       ,            EstatusPer           , SituacionPer ,   Foto   ) " &
                         "               values ( '" & Trim(TxtMatricula.Text) & "' , " & Trim(CbGrado.SelectedValue) & " , '" & Trim(TxtNombre.Text) & "' , '" & Trim(TxtPaterno.Text) & "' , '" & Trim(TxtPaterno.Text) & "' , '" & Trim(TxtNomCompleto.Text) & "' , '" & Trim(TxtCuenta.Text) & "' , " & CbBanco.SelectedValue & " , " & CbOrganica.SelectedValue & " , " & CbIntegracion.SelectedValue & " , " & CbEstatus.SelectedValue & " ,       1      , @Adjunto ) "
                cmd = New SqlCommand(sQuery, cn)
                cmd.Parameters.Add("@Adjunto", System.Data.SqlDbType.Image).Value = ImageToByteArray(PbFoto.Image)
                If cmd.ExecuteNonQuery < 1 Then
                    MsgBox("Ocurrió un error. Intente nuevamente.", vbExclamation + vbOKOnly, pTituloMsgVentana)
                Else
                    MsgBox("Se registró correctamente.", vbInformation + vbOKOnly, pTituloMsgVentana)
                    Muestra_Datos()
                    Limpia_Datos()
                    Ultimo_Registro()
                End If
                cmd.Dispose()
                cn.Close()
            Else

                If cn.State = ConnectionState.Closed Then cn.Open()
                sQuery = "update Personal set MatriculaPer = '" & Trim(TxtMatricula.Text) & "' , GradoPer = " & CbGrado.SelectedValue & " , Nombre = '" & Trim(TxtNombre.Text) & "' , ApellidoPaterno = '" & Trim(TxtPaterno.Text) & "' , ApellidoMaterno = '" & Trim(TxtMaterno.Text) & "' , NombreCompleto = '" & Trim(TxtNomCompleto.Text) & "' , Cuenta = '" & Trim(TxtCuenta.Text) & "' , Sucursal = " & CbBanco.SelectedValue & " , CompaniaPer = " & CbOrganica.SelectedValue & " , CompaniaIntegracion = " & CbIntegracion.SelectedValue & " , EstatusPer = " & CbEstatus.SelectedValue & " , SituacionPer = 1, Foto = @Adjunto where IdPer = " & TxtId.Text
                cmd = New SqlCommand(sQuery, cn)
                cmd.Parameters.Add("@Adjunto", System.Data.SqlDbType.Image).Value = ImageToByteArray(PbFoto.Image)
                If cmd.ExecuteNonQuery < 1 Then
                    MsgBox("Ocurrió un error. Intente nuevamente.", vbExclamation + vbOKOnly, pTituloMsgVentana)
                Else
                    MsgBox("Actualizado correctamente.", vbInformation + vbOKOnly, pTituloMsgVentana)
                    'Limpia_Datos()
                    Muestra_Datos()
                End If
                cmd.Dispose()
                cn.Close()
            End If
        End If
    End Sub

    Private Function Valida_Datos() As Boolean
        Dim bValida As Boolean = True



        Return bValida
    End Function

    'Imagen -> Array de Byte
    Public Function ImageToByteArray(ByVal imageIn As Image) As Byte()
        If imageIn Is Nothing Then
            Dim ms As New MemoryStream()
            Return ms.ToArray()
        Else
            Dim ms As New MemoryStream()
            imageIn.Save(ms, ImageFormat.Jpeg)
            Return ms.ToArray()
        End If
    End Function

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub
End Class