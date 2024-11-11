<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExtraccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmExtraccion))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CbCuota = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CbDetall = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblEstatus = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbMes = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbAnio = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GbModificaciones = New System.Windows.Forms.GroupBox()
        Me.BtnCargar = New System.Windows.Forms.Button()
        Me.GbVisuaDatos = New System.Windows.Forms.GroupBox()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnPasar = New System.Windows.Forms.Button()
        Me.DgvExtraccion = New System.Windows.Forms.DataGridView()
        Me.DgvActivos = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GbModificaciones.SuspendLayout()
        Me.GbVisuaDatos.SuspendLayout()
        CType(Me.DgvExtraccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvActivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.CbCuota)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CbDetall)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.LblEstatus)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CbMes)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CbAnio)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1232, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Actuales"
        '
        'CbCuota
        '
        Me.CbCuota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbCuota.FormattingEnabled = True
        Me.CbCuota.Location = New System.Drawing.Point(813, 37)
        Me.CbCuota.Name = "CbCuota"
        Me.CbCuota.Size = New System.Drawing.Size(84, 24)
        Me.CbCuota.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(763, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Cuota"
        '
        'CbDetall
        '
        Me.CbDetall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbDetall.FormattingEnabled = True
        Me.CbDetall.Location = New System.Drawing.Point(485, 37)
        Me.CbDetall.Name = "CbDetall"
        Me.CbDetall.Size = New System.Drawing.Size(251, 24)
        Me.CbDetall.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(435, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Detall"
        '
        'LblEstatus
        '
        Me.LblEstatus.AutoSize = True
        Me.LblEstatus.Location = New System.Drawing.Point(986, 42)
        Me.LblEstatus.Name = "LblEstatus"
        Me.LblEstatus.Size = New System.Drawing.Size(12, 17)
        Me.LblEstatus.TabIndex = 8
        Me.LblEstatus.Text = "."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(923, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Estatus"
        '
        'CbMes
        '
        Me.CbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbMes.FormattingEnabled = True
        Me.CbMes.Location = New System.Drawing.Point(247, 37)
        Me.CbMes.Name = "CbMes"
        Me.CbMes.Size = New System.Drawing.Size(169, 24)
        Me.CbMes.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(208, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Mes"
        '
        'CbAnio
        '
        Me.CbAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbAnio.FormattingEnabled = True
        Me.CbAnio.Location = New System.Drawing.Point(54, 37)
        Me.CbAnio.Name = "CbAnio"
        Me.CbAnio.Size = New System.Drawing.Size(140, 24)
        Me.CbAnio.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Año"
        '
        'GbModificaciones
        '
        Me.GbModificaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GbModificaciones.Controls.Add(Me.BtnCargar)
        Me.GbModificaciones.Location = New System.Drawing.Point(12, 118)
        Me.GbModificaciones.Name = "GbModificaciones"
        Me.GbModificaciones.Size = New System.Drawing.Size(136, 525)
        Me.GbModificaciones.TabIndex = 1
        Me.GbModificaciones.TabStop = False
        Me.GbModificaciones.Text = "Modificaciones"
        '
        'BtnCargar
        '
        Me.BtnCargar.Image = Global.GN.My.Resources.Resources.recalcular
        Me.BtnCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCargar.Location = New System.Drawing.Point(18, 35)
        Me.BtnCargar.Name = "BtnCargar"
        Me.BtnCargar.Size = New System.Drawing.Size(97, 30)
        Me.BtnCargar.TabIndex = 10
        Me.BtnCargar.Text = "Cargar"
        Me.BtnCargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCargar.UseVisualStyleBackColor = True
        '
        'GbVisuaDatos
        '
        Me.GbVisuaDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbVisuaDatos.Controls.Add(Me.BtnRegresar)
        Me.GbVisuaDatos.Controls.Add(Me.BtnPasar)
        Me.GbVisuaDatos.Controls.Add(Me.DgvExtraccion)
        Me.GbVisuaDatos.Controls.Add(Me.DgvActivos)
        Me.GbVisuaDatos.Location = New System.Drawing.Point(154, 118)
        Me.GbVisuaDatos.Name = "GbVisuaDatos"
        Me.GbVisuaDatos.Size = New System.Drawing.Size(1090, 402)
        Me.GbVisuaDatos.TabIndex = 2
        Me.GbVisuaDatos.TabStop = False
        Me.GbVisuaDatos.Text = "Visualizar Datos"
        '
        'BtnRegresar
        '
        Me.BtnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRegresar.Location = New System.Drawing.Point(489, 212)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(37, 30)
        Me.BtnRegresar.TabIndex = 12
        Me.BtnRegresar.Text = "<="
        Me.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'BtnPasar
        '
        Me.BtnPasar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPasar.Location = New System.Drawing.Point(491, 154)
        Me.BtnPasar.Name = "BtnPasar"
        Me.BtnPasar.Size = New System.Drawing.Size(37, 30)
        Me.BtnPasar.TabIndex = 11
        Me.BtnPasar.Text = "=>"
        Me.BtnPasar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPasar.UseVisualStyleBackColor = True
        '
        'DgvExtraccion
        '
        Me.DgvExtraccion.AllowUserToAddRows = False
        Me.DgvExtraccion.AllowUserToDeleteRows = False
        Me.DgvExtraccion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvExtraccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DgvExtraccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvExtraccion.Location = New System.Drawing.Point(536, 21)
        Me.DgvExtraccion.MultiSelect = False
        Me.DgvExtraccion.Name = "DgvExtraccion"
        Me.DgvExtraccion.ReadOnly = True
        Me.DgvExtraccion.RowHeadersWidth = 51
        Me.DgvExtraccion.RowTemplate.Height = 24
        Me.DgvExtraccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvExtraccion.Size = New System.Drawing.Size(548, 375)
        Me.DgvExtraccion.TabIndex = 4
        '
        'DgvActivos
        '
        Me.DgvActivos.AllowUserToAddRows = False
        Me.DgvActivos.AllowUserToDeleteRows = False
        Me.DgvActivos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DgvActivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DgvActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvActivos.Location = New System.Drawing.Point(6, 21)
        Me.DgvActivos.Name = "DgvActivos"
        Me.DgvActivos.ReadOnly = True
        Me.DgvActivos.RowHeadersWidth = 51
        Me.DgvActivos.RowTemplate.Height = 24
        Me.DgvActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvActivos.Size = New System.Drawing.Size(473, 375)
        Me.DgvActivos.TabIndex = 3
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Location = New System.Drawing.Point(154, 526)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1090, 117)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Resumen"
        '
        'FrmExtraccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1256, 655)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GbVisuaDatos)
        Me.Controls.Add(Me.GbModificaciones)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmExtraccion"
        Me.Text = "Extracción"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GbModificaciones.ResumeLayout(False)
        Me.GbVisuaDatos.ResumeLayout(False)
        CType(Me.DgvExtraccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvActivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CbAnio As ComboBox
    Friend WithEvents CbMes As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LblEstatus As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CbDetall As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GbModificaciones As GroupBox
    Friend WithEvents BtnCargar As Button
    Friend WithEvents GbVisuaDatos As GroupBox
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents BtnPasar As Button
    Friend WithEvents DgvExtraccion As DataGridView
    Friend WithEvents DgvActivos As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents CbCuota As ComboBox
    Friend WithEvents Label5 As Label
End Class
