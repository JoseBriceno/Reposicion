<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FarmaciaGerente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FarmaciaGerente))
        Me.BarraTitulo = New System.Windows.Forms.Panel()
        Me.txtflag = New System.Windows.Forms.TextBox()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.lempleado = New System.Windows.Forms.Panel()
        Me.lcompras = New System.Windows.Forms.Panel()
        Me.btnReportes = New System.Windows.Forms.Button()
        Me.MenuVertical = New System.Windows.Forms.Panel()
        Me.lreporte = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lproveedor = New System.Windows.Forms.Panel()
        Me.btnproveedor = New System.Windows.Forms.Button()
        Me.btnproductos = New System.Windows.Forms.Button()
        Me.btncategoria = New System.Windows.Forms.Button()
        Me.btnempleados = New System.Windows.Forms.Button()
        Me.btncompras = New System.Windows.Forms.Button()
        Me.btnclientes = New System.Windows.Forms.Button()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.btnventas = New System.Windows.Forms.Button()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.panel4 = New System.Windows.Forms.Panel()
        Me.panel7 = New System.Windows.Forms.Panel()
        Me.PanelForms = New System.Windows.Forms.Panel()
        Me.BarraTitulo.SuspendLayout()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuVertical.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarraTitulo
        '
        Me.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BarraTitulo.Controls.Add(Me.txtflag)
        Me.BarraTitulo.Controls.Add(Me.btnMinimizar)
        Me.BarraTitulo.Controls.Add(Me.btnCerrar)
        Me.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.BarraTitulo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BarraTitulo.Name = "BarraTitulo"
        Me.BarraTitulo.Size = New System.Drawing.Size(1726, 46)
        Me.BarraTitulo.TabIndex = 6
        '
        'txtflag
        '
        Me.txtflag.Location = New System.Drawing.Point(1596, 26)
        Me.txtflag.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(20, 22)
        Me.txtflag.TabIndex = 31
        Me.txtflag.Text = "0"
        Me.txtflag.Visible = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(1633, 7)
        Me.btnMinimizar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(34, 30)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMinimizar.TabIndex = 2
        Me.btnMinimizar.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(1675, 7)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(34, 30)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.TabStop = False
        '
        'lempleado
        '
        Me.lempleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.lempleado.Location = New System.Drawing.Point(-2, 517)
        Me.lempleado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lempleado.Name = "lempleado"
        Me.lempleado.Size = New System.Drawing.Size(10, 68)
        Me.lempleado.TabIndex = 12
        '
        'lcompras
        '
        Me.lcompras.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.lcompras.Location = New System.Drawing.Point(-2, 649)
        Me.lcompras.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lcompras.Name = "lcompras"
        Me.lcompras.Size = New System.Drawing.Size(9, 73)
        Me.lcompras.TabIndex = 10
        '
        'btnReportes
        '
        Me.btnReportes.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReportes.FlatAppearance.BorderSize = 0
        Me.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportes.ForeColor = System.Drawing.Color.White
        Me.btnReportes.Image = CType(resources.GetObject("btnReportes.Image"), System.Drawing.Image)
        Me.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReportes.Location = New System.Drawing.Point(7, 454)
        Me.btnReportes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(286, 61)
        Me.btnReportes.TabIndex = 13
        Me.btnReportes.Text = "Auto Servicio"
        Me.btnReportes.UseVisualStyleBackColor = False
        '
        'MenuVertical
        '
        Me.MenuVertical.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MenuVertical.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.MenuVertical.Controls.Add(Me.btnReportes)
        Me.MenuVertical.Controls.Add(Me.lreporte)
        Me.MenuVertical.Controls.Add(Me.PictureBox1)
        Me.MenuVertical.Controls.Add(Me.Panel9)
        Me.MenuVertical.Controls.Add(Me.Button1)
        Me.MenuVertical.Controls.Add(Me.lproveedor)
        Me.MenuVertical.Controls.Add(Me.btnproveedor)
        Me.MenuVertical.Controls.Add(Me.btnproductos)
        Me.MenuVertical.Controls.Add(Me.lempleado)
        Me.MenuVertical.Controls.Add(Me.btncategoria)
        Me.MenuVertical.Controls.Add(Me.lcompras)
        Me.MenuVertical.Controls.Add(Me.btnempleados)
        Me.MenuVertical.Controls.Add(Me.btncompras)
        Me.MenuVertical.Controls.Add(Me.btnclientes)
        Me.MenuVertical.Controls.Add(Me.panel2)
        Me.MenuVertical.Controls.Add(Me.btnventas)
        Me.MenuVertical.Controls.Add(Me.panel1)
        Me.MenuVertical.Controls.Add(Me.panel4)
        Me.MenuVertical.Controls.Add(Me.panel7)
        Me.MenuVertical.Location = New System.Drawing.Point(0, 0)
        Me.MenuVertical.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MenuVertical.Name = "MenuVertical"
        Me.MenuVertical.Size = New System.Drawing.Size(293, 754)
        Me.MenuVertical.TabIndex = 7
        '
        'lreporte
        '
        Me.lreporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.lreporte.Location = New System.Drawing.Point(-1, 454)
        Me.lreporte.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lreporte.Name = "lreporte"
        Me.lreporte.Size = New System.Drawing.Size(9, 62)
        Me.lreporte.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(64, 50)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(179, 132)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel9.Location = New System.Drawing.Point(-2, 724)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(9, 38)
        Me.Panel9.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkRed
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(11, 724)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(282, 35)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Cerrar Sesion"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lproveedor
        '
        Me.lproveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.lproveedor.Location = New System.Drawing.Point(1, 588)
        Me.lproveedor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lproveedor.Name = "lproveedor"
        Me.lproveedor.Size = New System.Drawing.Size(7, 55)
        Me.lproveedor.TabIndex = 11
        '
        'btnproveedor
        '
        Me.btnproveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnproveedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnproveedor.FlatAppearance.BorderSize = 0
        Me.btnproveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnproveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnproveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnproveedor.ForeColor = System.Drawing.Color.White
        Me.btnproveedor.Image = CType(resources.GetObject("btnproveedor.Image"), System.Drawing.Image)
        Me.btnproveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnproveedor.Location = New System.Drawing.Point(4, 589)
        Me.btnproveedor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnproveedor.Name = "btnproveedor"
        Me.btnproveedor.Size = New System.Drawing.Size(285, 55)
        Me.btnproveedor.TabIndex = 15
        Me.btnproveedor.Text = "Proveedor"
        Me.btnproveedor.UseVisualStyleBackColor = False
        '
        'btnproductos
        '
        Me.btnproductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnproductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnproductos.FlatAppearance.BorderSize = 0
        Me.btnproductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnproductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnproductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnproductos.ForeColor = System.Drawing.Color.White
        Me.btnproductos.Image = CType(resources.GetObject("btnproductos.Image"), System.Drawing.Image)
        Me.btnproductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnproductos.Location = New System.Drawing.Point(7, 254)
        Me.btnproductos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnproductos.Name = "btnproductos"
        Me.btnproductos.Size = New System.Drawing.Size(286, 68)
        Me.btnproductos.TabIndex = 1
        Me.btnproductos.Text = "Productos"
        Me.btnproductos.UseVisualStyleBackColor = False
        '
        'btncategoria
        '
        Me.btncategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btncategoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncategoria.FlatAppearance.BorderSize = 0
        Me.btncategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btncategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncategoria.ForeColor = System.Drawing.Color.White
        Me.btncategoria.Image = CType(resources.GetObject("btncategoria.Image"), System.Drawing.Image)
        Me.btncategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncategoria.Location = New System.Drawing.Point(7, 390)
        Me.btncategoria.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btncategoria.Name = "btncategoria"
        Me.btncategoria.Size = New System.Drawing.Size(290, 62)
        Me.btncategoria.TabIndex = 11
        Me.btncategoria.Text = "Categoría"
        Me.btncategoria.UseVisualStyleBackColor = False
        '
        'btnempleados
        '
        Me.btnempleados.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnempleados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnempleados.FlatAppearance.BorderSize = 0
        Me.btnempleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnempleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnempleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnempleados.ForeColor = System.Drawing.Color.White
        Me.btnempleados.Image = CType(resources.GetObject("btnempleados.Image"), System.Drawing.Image)
        Me.btnempleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnempleados.Location = New System.Drawing.Point(8, 518)
        Me.btnempleados.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnempleados.Name = "btnempleados"
        Me.btnempleados.Size = New System.Drawing.Size(285, 66)
        Me.btnempleados.TabIndex = 9
        Me.btnempleados.Text = "Empleados"
        Me.btnempleados.UseVisualStyleBackColor = False
        '
        'btncompras
        '
        Me.btncompras.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btncompras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncompras.FlatAppearance.BorderSize = 0
        Me.btncompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btncompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncompras.ForeColor = System.Drawing.Color.White
        Me.btncompras.Image = CType(resources.GetObject("btncompras.Image"), System.Drawing.Image)
        Me.btncompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncompras.Location = New System.Drawing.Point(5, 650)
        Me.btncompras.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btncompras.Name = "btncompras"
        Me.btncompras.Size = New System.Drawing.Size(286, 71)
        Me.btncompras.TabIndex = 7
        Me.btncompras.Text = "Compras"
        Me.btncompras.UseVisualStyleBackColor = False
        '
        'btnclientes
        '
        Me.btnclientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnclientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclientes.FlatAppearance.BorderSize = 0
        Me.btnclientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclientes.ForeColor = System.Drawing.Color.White
        Me.btnclientes.Image = CType(resources.GetObject("btnclientes.Image"), System.Drawing.Image)
        Me.btnclientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclientes.Location = New System.Drawing.Point(7, 324)
        Me.btnclientes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnclientes.Name = "btnclientes"
        Me.btnclientes.Size = New System.Drawing.Size(285, 63)
        Me.btnclientes.TabIndex = 5
        Me.btnclientes.Text = "Clientes"
        Me.btnclientes.UseVisualStyleBackColor = False
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.panel2.Location = New System.Drawing.Point(0, 254)
        Me.panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(13, 66)
        Me.panel2.TabIndex = 4
        '
        'btnventas
        '
        Me.btnventas.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnventas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnventas.FlatAppearance.BorderSize = 0
        Me.btnventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnventas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnventas.ForeColor = System.Drawing.Color.White
        Me.btnventas.Image = CType(resources.GetObject("btnventas.Image"), System.Drawing.Image)
        Me.btnventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnventas.Location = New System.Drawing.Point(8, 182)
        Me.btnventas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnventas.Name = "btnventas"
        Me.btnventas.Size = New System.Drawing.Size(290, 68)
        Me.btnventas.TabIndex = 3
        Me.btnventas.Text = "     Ventas"
        Me.btnventas.UseVisualStyleBackColor = False
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.panel1.Location = New System.Drawing.Point(0, 182)
        Me.panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(13, 67)
        Me.panel1.TabIndex = 2
        '
        'panel4
        '
        Me.panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.panel4.Location = New System.Drawing.Point(0, 324)
        Me.panel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panel4.Name = "panel4"
        Me.panel4.Size = New System.Drawing.Size(13, 63)
        Me.panel4.TabIndex = 8
        '
        'panel7
        '
        Me.panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.panel7.Location = New System.Drawing.Point(0, 390)
        Me.panel7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panel7.Name = "panel7"
        Me.panel7.Size = New System.Drawing.Size(13, 61)
        Me.panel7.TabIndex = 14
        '
        'PanelForms
        '
        Me.PanelForms.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.PanelForms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelForms.Location = New System.Drawing.Point(0, 0)
        Me.PanelForms.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelForms.Name = "PanelForms"
        Me.PanelForms.Size = New System.Drawing.Size(1726, 754)
        Me.PanelForms.TabIndex = 8
        '
        'FarmaciaGerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1726, 754)
        Me.Controls.Add(Me.BarraTitulo)
        Me.Controls.Add(Me.MenuVertical)
        Me.Controls.Add(Me.PanelForms)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FarmaciaGerente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FarmaciaGerente"
        Me.BarraTitulo.ResumeLayout(False)
        Me.BarraTitulo.PerformLayout()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuVertical.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents BarraTitulo As Panel
    Private WithEvents btnMinimizar As PictureBox
    Private WithEvents btnCerrar As PictureBox
    Private WithEvents lempleado As Panel
    Private WithEvents lcompras As Panel
    Private WithEvents btnReportes As Button
    Private WithEvents MenuVertical As Panel
    Private WithEvents panel7 As Panel
    Private WithEvents btncategoria As Button
    Private WithEvents btnempleados As Button
    Private WithEvents panel4 As Panel
    Private WithEvents btncompras As Button
    Private WithEvents btnclientes As Button
    Private WithEvents panel2 As Panel
    Private WithEvents btnventas As Button
    Private WithEvents panel1 As Panel
    Private WithEvents btnproductos As Button
    Private WithEvents lproveedor As Panel
    Private WithEvents btnproveedor As Button
    Private WithEvents lreporte As Panel
    Private WithEvents PanelForms As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Private WithEvents Panel9 As Panel
    Private WithEvents Button1 As Button
    Friend WithEvents txtflag As TextBox
End Class
