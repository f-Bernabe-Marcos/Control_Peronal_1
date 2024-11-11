<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDatosGenerales
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDatosGenerales))
        Me.TabControlGen = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BtnBuscaAdjunto = New System.Windows.Forms.Button()
        Me.CbEstatus = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PbFoto = New System.Windows.Forms.PictureBox()
        Me.CbSituacion = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CbIntegracion = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CbOrganica = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CbBanco = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtCuenta = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtNomCompleto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtMaterno = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtPaterno = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtMatricula = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbGrado = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DgvBusqueda = New System.Windows.Forms.DataGridView()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TabControlGen.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DgvBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControlGen
        '
        Me.TabControlGen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControlGen.Controls.Add(Me.TabPage1)
        Me.TabControlGen.Controls.Add(Me.TabPage2)
        Me.TabControlGen.Location = New System.Drawing.Point(640, 12)
        Me.TabControlGen.Name = "TabControlGen"
        Me.TabControlGen.SelectedIndex = 0
        Me.TabControlGen.Size = New System.Drawing.Size(692, 442)
        Me.TabControlGen.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BtnBuscaAdjunto)
        Me.TabPage1.Controls.Add(Me.CbEstatus)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.PbFoto)
        Me.TabPage1.Controls.Add(Me.CbSituacion)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.CbIntegracion)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.CbOrganica)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.CbBanco)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.TxtCuenta)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.TxtNomCompleto)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.TxtMaterno)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.TxtPaterno)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.TxtNombre)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.TxtMatricula)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.CbGrado)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.TxtId)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(684, 413)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos Generales"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BtnBuscaAdjunto
        '
        Me.BtnBuscaAdjunto.Image = Global.GN.My.Resources.Resources.buscar
        Me.BtnBuscaAdjunto.Location = New System.Drawing.Point(424, 359)
        Me.BtnBuscaAdjunto.Name = "BtnBuscaAdjunto"
        Me.BtnBuscaAdjunto.Size = New System.Drawing.Size(38, 43)
        Me.BtnBuscaAdjunto.TabIndex = 27
        Me.BtnBuscaAdjunto.UseVisualStyleBackColor = True
        '
        'CbEstatus
        '
        Me.CbEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbEstatus.FormattingEnabled = True
        Me.CbEstatus.Location = New System.Drawing.Point(24, 329)
        Me.CbEstatus.Name = "CbEstatus"
        Me.CbEstatus.Size = New System.Drawing.Size(207, 24)
        Me.CbEstatus.TabIndex = 26
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(21, 309)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 17)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Estatus"
        '
        'PbFoto
        '
        Me.PbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PbFoto.Location = New System.Drawing.Point(473, 197)
        Me.PbFoto.Name = "PbFoto"
        Me.PbFoto.Size = New System.Drawing.Size(205, 205)
        Me.PbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbFoto.TabIndex = 24
        Me.PbFoto.TabStop = False
        '
        'CbSituacion
        '
        Me.CbSituacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbSituacion.FormattingEnabled = True
        Me.CbSituacion.Location = New System.Drawing.Point(237, 329)
        Me.CbSituacion.Name = "CbSituacion"
        Me.CbSituacion.Size = New System.Drawing.Size(230, 24)
        Me.CbSituacion.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(234, 309)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 17)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Situación"
        '
        'CbIntegracion
        '
        Me.CbIntegracion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbIntegracion.FormattingEnabled = True
        Me.CbIntegracion.Location = New System.Drawing.Point(237, 273)
        Me.CbIntegracion.Name = "CbIntegracion"
        Me.CbIntegracion.Size = New System.Drawing.Size(230, 24)
        Me.CbIntegracion.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(234, 253)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(145, 17)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Compañia Integración"
        '
        'CbOrganica
        '
        Me.CbOrganica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbOrganica.FormattingEnabled = True
        Me.CbOrganica.Location = New System.Drawing.Point(24, 273)
        Me.CbOrganica.Name = "CbOrganica"
        Me.CbOrganica.Size = New System.Drawing.Size(207, 24)
        Me.CbOrganica.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 253)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(133, 17)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Compañia Organica"
        '
        'CbBanco
        '
        Me.CbBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbBanco.FormattingEnabled = True
        Me.CbBanco.Location = New System.Drawing.Point(237, 215)
        Me.CbBanco.Name = "CbBanco"
        Me.CbBanco.Size = New System.Drawing.Size(230, 24)
        Me.CbBanco.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(234, 195)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 17)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Banco"
        '
        'TxtCuenta
        '
        Me.TxtCuenta.Location = New System.Drawing.Point(24, 217)
        Me.TxtCuenta.Name = "TxtCuenta"
        Me.TxtCuenta.Size = New System.Drawing.Size(207, 22)
        Me.TxtCuenta.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 197)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Cuenta"
        '
        'TxtNomCompleto
        '
        Me.TxtNomCompleto.Enabled = False
        Me.TxtNomCompleto.Location = New System.Drawing.Point(24, 159)
        Me.TxtNomCompleto.Name = "TxtNomCompleto"
        Me.TxtNomCompleto.Size = New System.Drawing.Size(633, 22)
        Me.TxtNomCompleto.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Nombre Completo"
        '
        'TxtMaterno
        '
        Me.TxtMaterno.Location = New System.Drawing.Point(450, 102)
        Me.TxtMaterno.Name = "TxtMaterno"
        Me.TxtMaterno.Size = New System.Drawing.Size(207, 22)
        Me.TxtMaterno.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(447, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Apellido Materno"
        '
        'TxtPaterno
        '
        Me.TxtPaterno.Location = New System.Drawing.Point(237, 102)
        Me.TxtPaterno.Name = "TxtPaterno"
        Me.TxtPaterno.Size = New System.Drawing.Size(207, 22)
        Me.TxtPaterno.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(234, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Apellido Paterno"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(24, 102)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(207, 22)
        Me.TxtNombre.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nombre"
        '
        'TxtMatricula
        '
        Me.TxtMatricula.Location = New System.Drawing.Point(400, 40)
        Me.TxtMatricula.Name = "TxtMatricula"
        Me.TxtMatricula.Size = New System.Drawing.Size(183, 22)
        Me.TxtMatricula.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(397, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Matricula"
        '
        'CbGrado
        '
        Me.CbGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbGrado.FormattingEnabled = True
        Me.CbGrado.Location = New System.Drawing.Point(130, 40)
        Me.CbGrado.Name = "CbGrado"
        Me.CbGrado.Size = New System.Drawing.Size(230, 24)
        Me.CbGrado.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(127, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Grado"
        '
        'TxtId
        '
        Me.TxtId.Enabled = False
        Me.TxtId.Location = New System.Drawing.Point(24, 40)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(69, 22)
        Me.TxtId.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(684, 413)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Archivos Digitales"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Location = New System.Drawing.Point(12, 12)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(622, 482)
        Me.TabControl2.TabIndex = 2
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DgvBusqueda)
        Me.TabPage3.Controls.Add(Me.BtnBuscar)
        Me.TabPage3.Controls.Add(Me.TxtBusqueda)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(614, 453)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Busqueda"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DgvBusqueda
        '
        Me.DgvBusqueda.AllowUserToAddRows = False
        Me.DgvBusqueda.AllowUserToDeleteRows = False
        Me.DgvBusqueda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvBusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBusqueda.Location = New System.Drawing.Point(6, 93)
        Me.DgvBusqueda.MultiSelect = False
        Me.DgvBusqueda.Name = "DgvBusqueda"
        Me.DgvBusqueda.ReadOnly = True
        Me.DgvBusqueda.RowHeadersWidth = 51
        Me.DgvBusqueda.RowTemplate.Height = 24
        Me.DgvBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvBusqueda.Size = New System.Drawing.Size(602, 354)
        Me.DgvBusqueda.TabIndex = 2
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnBuscar.Image = Global.GN.My.Resources.Resources.buscar
        Me.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscar.Location = New System.Drawing.Point(265, 43)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(97, 30)
        Me.BtnBuscar.TabIndex = 1
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBusqueda.Location = New System.Drawing.Point(59, 15)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(514, 22)
        Me.TxtBusqueda.TabIndex = 0
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNuevo.Image = Global.GN.My.Resources.Resources.nuevo
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(1009, 460)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(97, 30)
        Me.BtnNuevo.TabIndex = 9
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Image = Global.GN.My.Resources.Resources.cerrar
        Me.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrar.Location = New System.Drawing.Point(1231, 460)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(97, 30)
        Me.BtnCerrar.TabIndex = 8
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGuardar.Image = Global.GN.My.Resources.Resources.guardar
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(1116, 460)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(97, 30)
        Me.BtnGuardar.TabIndex = 7
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'FrmDatosGenerales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 510)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.TabControlGen)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmDatosGenerales"
        Me.Text = "Datos Generales"
        Me.TabControlGen.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DgvBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControlGen As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DgvBusqueda As DataGridView
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents TxtId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtMaterno As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtPaterno As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtMatricula As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CbGrado As ComboBox
    Friend WithEvents TxtNomCompleto As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PbFoto As PictureBox
    Friend WithEvents CbSituacion As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents CbIntegracion As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents CbOrganica As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CbBanco As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtCuenta As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CbEstatus As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents BtnBuscaAdjunto As Button
End Class
