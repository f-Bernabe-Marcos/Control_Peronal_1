<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDBConnection
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabLocal = New System.Windows.Forms.TabPage()
        Me.btnConexLocPred = New System.Windows.Forms.Button()
        Me.btnGuardaCon = New System.Windows.Forms.Button()
        Me.btnPruebaCon = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkMuestraCar = New System.Windows.Forms.CheckBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtDataBase = New System.Windows.Forms.TextBox()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.optAutWin = New System.Windows.Forms.RadioButton()
        Me.optAutSQL = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabExterna = New System.Windows.Forms.TabPage()
        Me.btnConexExtPred = New System.Windows.Forms.Button()
        Me.btnGuardaConExt = New System.Windows.Forms.Button()
        Me.btnPruebaConExt = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkMuestraCarExt = New System.Windows.Forms.CheckBox()
        Me.txtPasswordExt = New System.Windows.Forms.TextBox()
        Me.txtUserExt = New System.Windows.Forms.TextBox()
        Me.txtDataBaseExt = New System.Windows.Forms.TextBox()
        Me.txtServerExt = New System.Windows.Forms.TextBox()
        Me.optAutWinExt = New System.Windows.Forms.RadioButton()
        Me.optAutSQLExt = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabLocal.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabExterna.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabLocal)
        Me.TabControl1.Controls.Add(Me.TabExterna)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(354, 459)
        Me.TabControl1.TabIndex = 1
        '
        'TabLocal
        '
        Me.TabLocal.Controls.Add(Me.btnConexLocPred)
        Me.TabLocal.Controls.Add(Me.btnGuardaCon)
        Me.TabLocal.Controls.Add(Me.btnPruebaCon)
        Me.TabLocal.Controls.Add(Me.GroupBox1)
        Me.TabLocal.Location = New System.Drawing.Point(4, 22)
        Me.TabLocal.Name = "TabLocal"
        Me.TabLocal.Padding = New System.Windows.Forms.Padding(3)
        Me.TabLocal.Size = New System.Drawing.Size(346, 433)
        Me.TabLocal.TabIndex = 0
        Me.TabLocal.Text = "Conexión Local"
        Me.TabLocal.UseVisualStyleBackColor = True
        '
        'btnConexLocPred
        '
        Me.btnConexLocPred.BackColor = System.Drawing.SystemColors.Control
        Me.btnConexLocPred.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConexLocPred.ForeColor = System.Drawing.Color.Black
        Me.btnConexLocPred.Location = New System.Drawing.Point(34, 370)
        Me.btnConexLocPred.Name = "btnConexLocPred"
        Me.btnConexLocPred.Size = New System.Drawing.Size(275, 42)
        Me.btnConexLocPred.TabIndex = 12
        Me.btnConexLocPred.Text = "Establecer como Predeterminada"
        Me.btnConexLocPred.UseVisualStyleBackColor = False
        '
        'btnGuardaCon
        '
        Me.btnGuardaCon.BackColor = System.Drawing.Color.Green
        Me.btnGuardaCon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardaCon.ForeColor = System.Drawing.Color.White
        Me.btnGuardaCon.Location = New System.Drawing.Point(182, 313)
        Me.btnGuardaCon.Name = "btnGuardaCon"
        Me.btnGuardaCon.Size = New System.Drawing.Size(143, 42)
        Me.btnGuardaCon.TabIndex = 11
        Me.btnGuardaCon.Text = "Guardar Conexión"
        Me.btnGuardaCon.UseVisualStyleBackColor = False
        '
        'btnPruebaCon
        '
        Me.btnPruebaCon.BackColor = System.Drawing.Color.SteelBlue
        Me.btnPruebaCon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPruebaCon.ForeColor = System.Drawing.Color.White
        Me.btnPruebaCon.Location = New System.Drawing.Point(15, 313)
        Me.btnPruebaCon.Name = "btnPruebaCon"
        Me.btnPruebaCon.Size = New System.Drawing.Size(145, 42)
        Me.btnPruebaCon.TabIndex = 10
        Me.btnPruebaCon.Text = "Probar Conexión"
        Me.btnPruebaCon.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkMuestraCar)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.txtUser)
        Me.GroupBox1.Controls.Add(Me.txtDataBase)
        Me.GroupBox1.Controls.Add(Me.txtServer)
        Me.GroupBox1.Controls.Add(Me.optAutWin)
        Me.GroupBox1.Controls.Add(Me.optAutSQL)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(15, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(313, 296)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'chkMuestraCar
        '
        Me.chkMuestraCar.AutoSize = True
        Me.chkMuestraCar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkMuestraCar.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMuestraCar.Location = New System.Drawing.Point(171, 233)
        Me.chkMuestraCar.Name = "chkMuestraCar"
        Me.chkMuestraCar.Size = New System.Drawing.Size(124, 20)
        Me.chkMuestraCar.TabIndex = 12
        Me.chkMuestraCar.Text = "Mostrar caracteres"
        Me.chkMuestraCar.UseVisualStyleBackColor = True
        Me.chkMuestraCar.Visible = False
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(18, 254)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(276, 24)
        Me.txtPassword.TabIndex = 11
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(18, 203)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(276, 24)
        Me.txtUser.TabIndex = 10
        '
        'txtDataBase
        '
        Me.txtDataBase.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataBase.Location = New System.Drawing.Point(18, 83)
        Me.txtDataBase.Name = "txtDataBase"
        Me.txtDataBase.Size = New System.Drawing.Size(276, 24)
        Me.txtDataBase.TabIndex = 9
        '
        'txtServer
        '
        Me.txtServer.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServer.Location = New System.Drawing.Point(18, 36)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(276, 24)
        Me.txtServer.TabIndex = 8
        '
        'optAutWin
        '
        Me.optAutWin.AutoSize = True
        Me.optAutWin.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAutWin.Location = New System.Drawing.Point(18, 151)
        Me.optAutWin.Name = "optAutWin"
        Me.optAutWin.Size = New System.Drawing.Size(168, 20)
        Me.optAutWin.TabIndex = 7
        Me.optAutWin.Text = "Autenticación de Windows"
        Me.optAutWin.UseVisualStyleBackColor = True
        '
        'optAutSQL
        '
        Me.optAutSQL.AutoSize = True
        Me.optAutSQL.Checked = True
        Me.optAutSQL.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAutSQL.Location = New System.Drawing.Point(18, 127)
        Me.optAutSQL.Name = "optAutSQL"
        Me.optAutSQL.Size = New System.Drawing.Size(140, 20)
        Me.optAutSQL.TabIndex = 6
        Me.optAutSQL.TabStop = True
        Me.optAutSQL.Text = "Autenticación de SQL"
        Me.optAutSQL.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Contraseña"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Base de Datos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Servidor\Instancia"
        '
        'TabExterna
        '
        Me.TabExterna.Controls.Add(Me.btnConexExtPred)
        Me.TabExterna.Controls.Add(Me.btnGuardaConExt)
        Me.TabExterna.Controls.Add(Me.btnPruebaConExt)
        Me.TabExterna.Controls.Add(Me.GroupBox2)
        Me.TabExterna.Location = New System.Drawing.Point(4, 22)
        Me.TabExterna.Name = "TabExterna"
        Me.TabExterna.Padding = New System.Windows.Forms.Padding(3)
        Me.TabExterna.Size = New System.Drawing.Size(346, 433)
        Me.TabExterna.TabIndex = 1
        Me.TabExterna.Text = "Conexión Externa"
        Me.TabExterna.UseVisualStyleBackColor = True
        '
        'btnConexExtPred
        '
        Me.btnConexExtPred.BackColor = System.Drawing.SystemColors.Control
        Me.btnConexExtPred.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConexExtPred.ForeColor = System.Drawing.Color.Black
        Me.btnConexExtPred.Location = New System.Drawing.Point(33, 370)
        Me.btnConexExtPred.Name = "btnConexExtPred"
        Me.btnConexExtPred.Size = New System.Drawing.Size(276, 42)
        Me.btnConexExtPred.TabIndex = 15
        Me.btnConexExtPred.Text = "Establecer como Predeterminada"
        Me.btnConexExtPred.UseVisualStyleBackColor = False
        '
        'btnGuardaConExt
        '
        Me.btnGuardaConExt.BackColor = System.Drawing.Color.Green
        Me.btnGuardaConExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardaConExt.ForeColor = System.Drawing.Color.White
        Me.btnGuardaConExt.Location = New System.Drawing.Point(182, 313)
        Me.btnGuardaConExt.Name = "btnGuardaConExt"
        Me.btnGuardaConExt.Size = New System.Drawing.Size(143, 42)
        Me.btnGuardaConExt.TabIndex = 14
        Me.btnGuardaConExt.Text = "Guardar Conexión"
        Me.btnGuardaConExt.UseVisualStyleBackColor = False
        '
        'btnPruebaConExt
        '
        Me.btnPruebaConExt.BackColor = System.Drawing.Color.SteelBlue
        Me.btnPruebaConExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPruebaConExt.ForeColor = System.Drawing.Color.White
        Me.btnPruebaConExt.Location = New System.Drawing.Point(15, 313)
        Me.btnPruebaConExt.Name = "btnPruebaConExt"
        Me.btnPruebaConExt.Size = New System.Drawing.Size(145, 42)
        Me.btnPruebaConExt.TabIndex = 13
        Me.btnPruebaConExt.Text = "Probar Conexión"
        Me.btnPruebaConExt.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkMuestraCarExt)
        Me.GroupBox2.Controls.Add(Me.txtPasswordExt)
        Me.GroupBox2.Controls.Add(Me.txtUserExt)
        Me.GroupBox2.Controls.Add(Me.txtDataBaseExt)
        Me.GroupBox2.Controls.Add(Me.txtServerExt)
        Me.GroupBox2.Controls.Add(Me.optAutWinExt)
        Me.GroupBox2.Controls.Add(Me.optAutSQLExt)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(15, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(313, 296)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'chkMuestraCarExt
        '
        Me.chkMuestraCarExt.AutoSize = True
        Me.chkMuestraCarExt.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkMuestraCarExt.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMuestraCarExt.Location = New System.Drawing.Point(171, 233)
        Me.chkMuestraCarExt.Name = "chkMuestraCarExt"
        Me.chkMuestraCarExt.Size = New System.Drawing.Size(124, 20)
        Me.chkMuestraCarExt.TabIndex = 12
        Me.chkMuestraCarExt.Text = "Mostrar caracteres"
        Me.chkMuestraCarExt.UseVisualStyleBackColor = True
        Me.chkMuestraCarExt.Visible = False
        '
        'txtPasswordExt
        '
        Me.txtPasswordExt.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswordExt.Location = New System.Drawing.Point(18, 254)
        Me.txtPasswordExt.Name = "txtPasswordExt"
        Me.txtPasswordExt.Size = New System.Drawing.Size(276, 24)
        Me.txtPasswordExt.TabIndex = 11
        Me.txtPasswordExt.UseSystemPasswordChar = True
        '
        'txtUserExt
        '
        Me.txtUserExt.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserExt.Location = New System.Drawing.Point(18, 203)
        Me.txtUserExt.Name = "txtUserExt"
        Me.txtUserExt.Size = New System.Drawing.Size(276, 24)
        Me.txtUserExt.TabIndex = 10
        '
        'txtDataBaseExt
        '
        Me.txtDataBaseExt.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataBaseExt.Location = New System.Drawing.Point(18, 83)
        Me.txtDataBaseExt.Name = "txtDataBaseExt"
        Me.txtDataBaseExt.Size = New System.Drawing.Size(276, 24)
        Me.txtDataBaseExt.TabIndex = 9
        '
        'txtServerExt
        '
        Me.txtServerExt.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServerExt.Location = New System.Drawing.Point(18, 36)
        Me.txtServerExt.Name = "txtServerExt"
        Me.txtServerExt.Size = New System.Drawing.Size(276, 24)
        Me.txtServerExt.TabIndex = 8
        '
        'optAutWinExt
        '
        Me.optAutWinExt.AutoSize = True
        Me.optAutWinExt.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAutWinExt.Location = New System.Drawing.Point(18, 151)
        Me.optAutWinExt.Name = "optAutWinExt"
        Me.optAutWinExt.Size = New System.Drawing.Size(168, 20)
        Me.optAutWinExt.TabIndex = 7
        Me.optAutWinExt.Text = "Autenticación de Windows"
        Me.optAutWinExt.UseVisualStyleBackColor = True
        '
        'optAutSQLExt
        '
        Me.optAutSQLExt.AutoSize = True
        Me.optAutSQLExt.Checked = True
        Me.optAutSQLExt.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAutSQLExt.Location = New System.Drawing.Point(18, 127)
        Me.optAutSQLExt.Name = "optAutSQLExt"
        Me.optAutSQLExt.Size = New System.Drawing.Size(140, 20)
        Me.optAutSQLExt.TabIndex = 6
        Me.optAutSQLExt.TabStop = True
        Me.optAutSQLExt.Text = "Autenticación de SQL"
        Me.optAutSQLExt.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Contraseña"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 19)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Usuario"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 19)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Base de Datos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 19)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Servidor\Instancia"
        '
        'frmDBConnection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 483)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.Name = "frmDBConnection"
        Me.Text = "Configurar conexión a la Base de Datos - SA"
        Me.TabControl1.ResumeLayout(False)
        Me.TabLocal.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabExterna.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabLocal As System.Windows.Forms.TabPage
    Friend WithEvents btnGuardaCon As System.Windows.Forms.Button
    Friend WithEvents btnPruebaCon As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkMuestraCar As System.Windows.Forms.CheckBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtDataBase As System.Windows.Forms.TextBox
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents optAutWin As System.Windows.Forms.RadioButton
    Friend WithEvents optAutSQL As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabExterna As System.Windows.Forms.TabPage
    Friend WithEvents btnGuardaConExt As System.Windows.Forms.Button
    Friend WithEvents btnPruebaConExt As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkMuestraCarExt As System.Windows.Forms.CheckBox
    Friend WithEvents txtPasswordExt As System.Windows.Forms.TextBox
    Friend WithEvents txtUserExt As System.Windows.Forms.TextBox
    Friend WithEvents txtDataBaseExt As System.Windows.Forms.TextBox
    Friend WithEvents txtServerExt As System.Windows.Forms.TextBox
    Friend WithEvents optAutWinExt As System.Windows.Forms.RadioButton
    Friend WithEvents optAutSQLExt As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnConexLocPred As System.Windows.Forms.Button
    Friend WithEvents btnConexExtPred As System.Windows.Forms.Button
End Class
