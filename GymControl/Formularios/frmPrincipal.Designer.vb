<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlNavegacion = New Panel()
        btnCerrarSesion = New Button()
        btnBitacora = New Button()
        btnUsuarios = New Button()
        btnHorarios = New Button()
        btnActividadesSalas = New Button()
        btnInstructores = New Button()
        btnPagos = New Button()
        btnMembresias = New Button()
        btnSocios = New Button()
        btnInicio = New Button()
        pnlIndicadores = New Panel()
        pnlClasesHoy = New Panel()
        lblTotalClasesHoy = New Label()
        lblClasesHoy = New Label()
        pnlIngresosMes = New Panel()
        lblTotalIngresos = New Label()
        lblIngresosMes = New Label()
        pnlMembresiasPorVencer = New Panel()
        lblTotalPorVencer = New Label()
        lblMembresiasPorVencer = New Label()
        pnlSociosActivos = New Panel()
        lblTotalSocios = New Label()
        lblSociosActivos = New Label()
        dgvPorVencer = New DataGridView()
        lblTituloPorVencer = New Label()
        dgvClasesHoy = New DataGridView()
        lblTituloClasesHoy = New Label()
        lblTituloPanel = New Label()
        lblAccesosRapidos = New Label()
        btnNuevoSocio = New Button()
        btnRegistrarPago = New Button()
        btnRenovarMembresia = New Button()
        btnVerHorarios = New Button()
        stsSesion = New StatusStrip()
        lblSesionUsuario = New ToolStripStatusLabel()
        lblSesionRol = New ToolStripStatusLabel()
        lblSesionServidor = New ToolStripStatusLabel()
        lblSesionFechaHora = New ToolStripStatusLabel()
        mnuPrincipal = New MenuStrip()
        mnuArchivo = New ToolStripMenuItem()
        mnuCerrarSesion = New ToolStripMenuItem()
        mnuSalir = New ToolStripMenuItem()
        mnuSocios = New ToolStripMenuItem()
        mnuGestionarSocios = New ToolStripMenuItem()
        mnuNuevoSocio = New ToolStripMenuItem()
        mnuMmbresias = New ToolStripMenuItem()
        mnuTiposMembresia = New ToolStripMenuItem()
        mnuMembresiasPagos = New ToolStripMenuItem()
        mnuPagos = New ToolStripMenuItem()
        mnuRegistrarPago = New ToolStripMenuItem()
        mnuInstructores = New ToolStripMenuItem()
        mnuGestionarInstructores = New ToolStripMenuItem()
        mnuActividadesSalas = New ToolStripMenuItem()
        mnuActividades = New ToolStripMenuItem()
        mnuSalas = New ToolStripMenuItem()
        mnuHorarios = New ToolStripMenuItem()
        mnuProgramacionSemanal = New ToolStripMenuItem()
        mnuUsuarios = New ToolStripMenuItem()
        mnuGestionarUsuarios = New ToolStripMenuItem()
        mnuBitacoraAccesos = New ToolStripMenuItem()
        mnuConsultarBitacora = New ToolStripMenuItem()
        mnuSeguridad = New ToolStripMenuItem()
        mnuCambiarContrasena = New ToolStripMenuItem()
        lblSubtituloPanel = New Label()
        pnlNavegacion.SuspendLayout()
        pnlIndicadores.SuspendLayout()
        pnlClasesHoy.SuspendLayout()
        pnlIngresosMes.SuspendLayout()
        pnlMembresiasPorVencer.SuspendLayout()
        pnlSociosActivos.SuspendLayout()
        CType(dgvPorVencer, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvClasesHoy, ComponentModel.ISupportInitialize).BeginInit()
        stsSesion.SuspendLayout()
        mnuPrincipal.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlNavegacion
        ' 
        pnlNavegacion.BackColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        pnlNavegacion.Controls.Add(btnCerrarSesion)
        pnlNavegacion.Controls.Add(btnBitacora)
        pnlNavegacion.Controls.Add(btnUsuarios)
        pnlNavegacion.Controls.Add(btnHorarios)
        pnlNavegacion.Controls.Add(btnActividadesSalas)
        pnlNavegacion.Controls.Add(btnInstructores)
        pnlNavegacion.Controls.Add(btnPagos)
        pnlNavegacion.Controls.Add(btnMembresias)
        pnlNavegacion.Controls.Add(btnSocios)
        pnlNavegacion.Controls.Add(btnInicio)
        pnlNavegacion.Dock = DockStyle.Left
        pnlNavegacion.Location = New Point(0, 28)
        pnlNavegacion.Name = "pnlNavegacion"
        pnlNavegacion.Padding = New Padding(4)
        pnlNavegacion.Size = New Size(217, 622)
        pnlNavegacion.TabIndex = 0
        ' 
        ' btnCerrarSesion
        ' 
        btnCerrarSesion.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnCerrarSesion.BackColor = Color.Transparent
        btnCerrarSesion.FlatAppearance.BorderSize = 0
        btnCerrarSesion.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(58), CByte(78), CByte(98))
        btnCerrarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(96), CByte(122))
        btnCerrarSesion.FlatStyle = FlatStyle.Flat
        btnCerrarSesion.ForeColor = Color.White
        btnCerrarSesion.Location = New Point(6, 588)
        btnCerrarSesion.Name = "btnCerrarSesion"
        btnCerrarSesion.Padding = New Padding(10, 0, 0, 0)
        btnCerrarSesion.Size = New Size(205, 30)
        btnCerrarSesion.TabIndex = 9
        btnCerrarSesion.Text = "Cerrar sesión"
        btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft
        btnCerrarSesion.UseVisualStyleBackColor = False
        ' 
        ' btnBitacora
        ' 
        btnBitacora.BackColor = Color.Transparent
        btnBitacora.FlatAppearance.BorderSize = 0
        btnBitacora.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(58), CByte(78), CByte(98))
        btnBitacora.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(96), CByte(122))
        btnBitacora.FlatStyle = FlatStyle.Flat
        btnBitacora.ForeColor = Color.White
        btnBitacora.Location = New Point(8, 320)
        btnBitacora.Name = "btnBitacora"
        btnBitacora.Padding = New Padding(10, 0, 0, 0)
        btnBitacora.Size = New Size(204, 34)
        btnBitacora.TabIndex = 8
        btnBitacora.Text = "Bitácora de accesos"
        btnBitacora.TextAlign = ContentAlignment.MiddleLeft
        btnBitacora.UseVisualStyleBackColor = False
        ' 
        ' btnUsuarios
        ' 
        btnUsuarios.BackColor = Color.Transparent
        btnUsuarios.FlatAppearance.BorderSize = 0
        btnUsuarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(58), CByte(78), CByte(98))
        btnUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(96), CByte(122))
        btnUsuarios.FlatStyle = FlatStyle.Flat
        btnUsuarios.ForeColor = Color.White
        btnUsuarios.Location = New Point(8, 282)
        btnUsuarios.Name = "btnUsuarios"
        btnUsuarios.Padding = New Padding(10, 0, 0, 0)
        btnUsuarios.Size = New Size(204, 34)
        btnUsuarios.TabIndex = 7
        btnUsuarios.Text = "Usuarios"
        btnUsuarios.TextAlign = ContentAlignment.MiddleLeft
        btnUsuarios.UseVisualStyleBackColor = False
        ' 
        ' btnHorarios
        ' 
        btnHorarios.BackColor = Color.Transparent
        btnHorarios.FlatAppearance.BorderSize = 0
        btnHorarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(58), CByte(78), CByte(98))
        btnHorarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(96), CByte(122))
        btnHorarios.FlatStyle = FlatStyle.Flat
        btnHorarios.ForeColor = Color.White
        btnHorarios.Location = New Point(8, 244)
        btnHorarios.Name = "btnHorarios"
        btnHorarios.Padding = New Padding(10, 0, 0, 0)
        btnHorarios.Size = New Size(204, 34)
        btnHorarios.TabIndex = 6
        btnHorarios.Text = "Horarios"
        btnHorarios.TextAlign = ContentAlignment.MiddleLeft
        btnHorarios.UseVisualStyleBackColor = False
        ' 
        ' btnActividadesSalas
        ' 
        btnActividadesSalas.BackColor = Color.Transparent
        btnActividadesSalas.FlatAppearance.BorderSize = 0
        btnActividadesSalas.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(58), CByte(78), CByte(98))
        btnActividadesSalas.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(96), CByte(122))
        btnActividadesSalas.FlatStyle = FlatStyle.Flat
        btnActividadesSalas.ForeColor = Color.White
        btnActividadesSalas.Location = New Point(8, 206)
        btnActividadesSalas.Name = "btnActividadesSalas"
        btnActividadesSalas.Padding = New Padding(10, 0, 0, 0)
        btnActividadesSalas.Size = New Size(204, 34)
        btnActividadesSalas.TabIndex = 5
        btnActividadesSalas.Text = "Actividades y salas"
        btnActividadesSalas.TextAlign = ContentAlignment.MiddleLeft
        btnActividadesSalas.UseVisualStyleBackColor = False
        ' 
        ' btnInstructores
        ' 
        btnInstructores.BackColor = Color.Transparent
        btnInstructores.FlatAppearance.BorderSize = 0
        btnInstructores.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(58), CByte(78), CByte(98))
        btnInstructores.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(96), CByte(122))
        btnInstructores.FlatStyle = FlatStyle.Flat
        btnInstructores.ForeColor = Color.White
        btnInstructores.Location = New Point(8, 168)
        btnInstructores.Name = "btnInstructores"
        btnInstructores.Padding = New Padding(10, 0, 0, 0)
        btnInstructores.Size = New Size(204, 34)
        btnInstructores.TabIndex = 4
        btnInstructores.Text = "Instructores"
        btnInstructores.TextAlign = ContentAlignment.MiddleLeft
        btnInstructores.UseVisualStyleBackColor = False
        ' 
        ' btnPagos
        ' 
        btnPagos.BackColor = Color.Transparent
        btnPagos.FlatAppearance.BorderSize = 0
        btnPagos.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(58), CByte(78), CByte(98))
        btnPagos.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(96), CByte(122))
        btnPagos.FlatStyle = FlatStyle.Flat
        btnPagos.ForeColor = Color.White
        btnPagos.Location = New Point(8, 130)
        btnPagos.Name = "btnPagos"
        btnPagos.Padding = New Padding(10, 0, 0, 0)
        btnPagos.Size = New Size(204, 34)
        btnPagos.TabIndex = 3
        btnPagos.Text = "Pagos"
        btnPagos.TextAlign = ContentAlignment.MiddleLeft
        btnPagos.UseVisualStyleBackColor = False
        ' 
        ' btnMembresias
        ' 
        btnMembresias.BackColor = Color.Transparent
        btnMembresias.FlatAppearance.BorderSize = 0
        btnMembresias.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(58), CByte(78), CByte(98))
        btnMembresias.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(96), CByte(122))
        btnMembresias.FlatStyle = FlatStyle.Flat
        btnMembresias.ForeColor = Color.White
        btnMembresias.Location = New Point(8, 92)
        btnMembresias.Name = "btnMembresias"
        btnMembresias.Padding = New Padding(10, 0, 0, 0)
        btnMembresias.Size = New Size(204, 34)
        btnMembresias.TabIndex = 2
        btnMembresias.Text = "Membresías"
        btnMembresias.TextAlign = ContentAlignment.MiddleLeft
        btnMembresias.UseVisualStyleBackColor = False
        ' 
        ' btnSocios
        ' 
        btnSocios.BackColor = Color.Transparent
        btnSocios.FlatAppearance.BorderSize = 0
        btnSocios.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(58), CByte(78), CByte(98))
        btnSocios.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(96), CByte(122))
        btnSocios.FlatStyle = FlatStyle.Flat
        btnSocios.ForeColor = Color.White
        btnSocios.Location = New Point(8, 54)
        btnSocios.Name = "btnSocios"
        btnSocios.Padding = New Padding(10, 0, 0, 0)
        btnSocios.Size = New Size(204, 34)
        btnSocios.TabIndex = 1
        btnSocios.Text = "Socios"
        btnSocios.TextAlign = ContentAlignment.MiddleLeft
        btnSocios.UseVisualStyleBackColor = False
        ' 
        ' btnInicio
        ' 
        btnInicio.BackColor = Color.FromArgb(CByte(79), CByte(124), CByte(172))
        btnInicio.FlatAppearance.BorderSize = 0
        btnInicio.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(58), CByte(78), CByte(98))
        btnInicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(96), CByte(122))
        btnInicio.FlatStyle = FlatStyle.Flat
        btnInicio.ForeColor = Color.White
        btnInicio.Location = New Point(8, 16)
        btnInicio.Name = "btnInicio"
        btnInicio.Padding = New Padding(10, 0, 0, 0)
        btnInicio.Size = New Size(204, 34)
        btnInicio.TabIndex = 0
        btnInicio.Text = "Inicio"
        btnInicio.TextAlign = ContentAlignment.MiddleLeft
        btnInicio.UseVisualStyleBackColor = False
        ' 
        ' pnlIndicadores
        ' 
        pnlIndicadores.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlIndicadores.BackColor = Color.FromArgb(CByte(244), CByte(246), CByte(248))
        pnlIndicadores.Controls.Add(pnlClasesHoy)
        pnlIndicadores.Controls.Add(pnlIngresosMes)
        pnlIndicadores.Controls.Add(pnlMembresiasPorVencer)
        pnlIndicadores.Controls.Add(pnlSociosActivos)
        pnlIndicadores.Location = New Point(220, 77)
        pnlIndicadores.Name = "pnlIndicadores"
        pnlIndicadores.Padding = New Padding(10, 5, 10, 5)
        pnlIndicadores.Size = New Size(870, 90)
        pnlIndicadores.TabIndex = 1
        ' 
        ' pnlClasesHoy
        ' 
        pnlClasesHoy.BackColor = Color.White
        pnlClasesHoy.BorderStyle = BorderStyle.FixedSingle
        pnlClasesHoy.Controls.Add(lblTotalClasesHoy)
        pnlClasesHoy.Controls.Add(lblClasesHoy)
        pnlClasesHoy.Location = New Point(655, 8)
        pnlClasesHoy.Name = "pnlClasesHoy"
        pnlClasesHoy.Padding = New Padding(10, 0, 0, 0)
        pnlClasesHoy.Size = New Size(200, 70)
        pnlClasesHoy.TabIndex = 3
        ' 
        ' lblTotalClasesHoy
        ' 
        lblTotalClasesHoy.AutoSize = True
        lblTotalClasesHoy.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalClasesHoy.ForeColor = Color.FromArgb(CByte(79), CByte(124), CByte(172))
        lblTotalClasesHoy.Location = New Point(10, 25)
        lblTotalClasesHoy.Name = "lblTotalClasesHoy"
        lblTotalClasesHoy.Size = New Size(35, 41)
        lblTotalClasesHoy.TabIndex = 1
        lblTotalClasesHoy.Text = "0"
        ' 
        ' lblClasesHoy
        ' 
        lblClasesHoy.AutoSize = True
        lblClasesHoy.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblClasesHoy.ForeColor = Color.FromArgb(CByte(96), CByte(125), CByte(139))
        lblClasesHoy.Location = New Point(10, 8)
        lblClasesHoy.Name = "lblClasesHoy"
        lblClasesHoy.Size = New Size(159, 19)
        lblClasesHoy.TabIndex = 0
        lblClasesHoy.Text = "Clases programadas hoy"
        ' 
        ' pnlIngresosMes
        ' 
        pnlIngresosMes.BackColor = Color.White
        pnlIngresosMes.BorderStyle = BorderStyle.FixedSingle
        pnlIngresosMes.Controls.Add(lblTotalIngresos)
        pnlIngresosMes.Controls.Add(lblIngresosMes)
        pnlIngresosMes.Location = New Point(440, 8)
        pnlIngresosMes.Name = "pnlIngresosMes"
        pnlIngresosMes.Padding = New Padding(10, 0, 0, 0)
        pnlIngresosMes.Size = New Size(200, 70)
        pnlIngresosMes.TabIndex = 2
        ' 
        ' lblTotalIngresos
        ' 
        lblTotalIngresos.AutoSize = True
        lblTotalIngresos.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalIngresos.ForeColor = Color.FromArgb(CByte(79), CByte(124), CByte(172))
        lblTotalIngresos.Location = New Point(10, 25)
        lblTotalIngresos.Name = "lblTotalIngresos"
        lblTotalIngresos.Size = New Size(112, 37)
        lblTotalIngresos.TabIndex = 1
        lblTotalIngresos.Text = "C$ 0.00"
        ' 
        ' lblIngresosMes
        ' 
        lblIngresosMes.AutoSize = True
        lblIngresosMes.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblIngresosMes.ForeColor = Color.FromArgb(CByte(96), CByte(125), CByte(139))
        lblIngresosMes.Location = New Point(10, 8)
        lblIngresosMes.Name = "lblIngresosMes"
        lblIngresosMes.Size = New Size(112, 19)
        lblIngresosMes.TabIndex = 0
        lblIngresosMes.Text = "Ingresos del mes"
        ' 
        ' pnlMembresiasPorVencer
        ' 
        pnlMembresiasPorVencer.BackColor = Color.White
        pnlMembresiasPorVencer.BorderStyle = BorderStyle.FixedSingle
        pnlMembresiasPorVencer.Controls.Add(lblTotalPorVencer)
        pnlMembresiasPorVencer.Controls.Add(lblMembresiasPorVencer)
        pnlMembresiasPorVencer.Location = New Point(225, 8)
        pnlMembresiasPorVencer.Name = "pnlMembresiasPorVencer"
        pnlMembresiasPorVencer.Padding = New Padding(10, 0, 0, 0)
        pnlMembresiasPorVencer.Size = New Size(200, 70)
        pnlMembresiasPorVencer.TabIndex = 1
        ' 
        ' lblTotalPorVencer
        ' 
        lblTotalPorVencer.AutoSize = True
        lblTotalPorVencer.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalPorVencer.ForeColor = Color.FromArgb(CByte(79), CByte(124), CByte(172))
        lblTotalPorVencer.Location = New Point(10, 25)
        lblTotalPorVencer.Name = "lblTotalPorVencer"
        lblTotalPorVencer.Size = New Size(35, 41)
        lblTotalPorVencer.TabIndex = 1
        lblTotalPorVencer.Text = "0"
        ' 
        ' lblMembresiasPorVencer
        ' 
        lblMembresiasPorVencer.AutoSize = True
        lblMembresiasPorVencer.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMembresiasPorVencer.ForeColor = Color.FromArgb(CByte(96), CByte(125), CByte(139))
        lblMembresiasPorVencer.Location = New Point(10, 8)
        lblMembresiasPorVencer.Name = "lblMembresiasPorVencer"
        lblMembresiasPorVencer.Size = New Size(152, 19)
        lblMembresiasPorVencer.TabIndex = 0
        lblMembresiasPorVencer.Text = "Membresías por vencer"
        ' 
        ' pnlSociosActivos
        ' 
        pnlSociosActivos.BackColor = Color.White
        pnlSociosActivos.BorderStyle = BorderStyle.FixedSingle
        pnlSociosActivos.Controls.Add(lblTotalSocios)
        pnlSociosActivos.Controls.Add(lblSociosActivos)
        pnlSociosActivos.Location = New Point(10, 8)
        pnlSociosActivos.Name = "pnlSociosActivos"
        pnlSociosActivos.Padding = New Padding(10, 0, 0, 0)
        pnlSociosActivos.Size = New Size(200, 70)
        pnlSociosActivos.TabIndex = 0
        ' 
        ' lblTotalSocios
        ' 
        lblTotalSocios.AutoSize = True
        lblTotalSocios.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalSocios.ForeColor = Color.FromArgb(CByte(79), CByte(124), CByte(172))
        lblTotalSocios.Location = New Point(10, 25)
        lblTotalSocios.Name = "lblTotalSocios"
        lblTotalSocios.Size = New Size(35, 41)
        lblTotalSocios.TabIndex = 1
        lblTotalSocios.Text = "0"
        ' 
        ' lblSociosActivos
        ' 
        lblSociosActivos.AutoSize = True
        lblSociosActivos.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSociosActivos.ForeColor = Color.FromArgb(CByte(96), CByte(125), CByte(139))
        lblSociosActivos.Location = New Point(10, 8)
        lblSociosActivos.Name = "lblSociosActivos"
        lblSociosActivos.Size = New Size(93, 19)
        lblSociosActivos.TabIndex = 0
        lblSociosActivos.Text = "Socios activos"
        ' 
        ' dgvPorVencer
        ' 
        dgvPorVencer.AllowUserToAddRows = False
        dgvPorVencer.AllowUserToDeleteRows = False
        dgvPorVencer.AllowUserToResizeRows = False
        dgvPorVencer.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvPorVencer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPorVencer.BackgroundColor = Color.White
        dgvPorVencer.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvPorVencer.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvPorVencer.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvPorVencer.ColumnHeadersHeight = 32
        dgvPorVencer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvPorVencer.EnableHeadersVisualStyles = False
        dgvPorVencer.Location = New Point(220, 195)
        dgvPorVencer.MultiSelect = False
        dgvPorVencer.Name = "dgvPorVencer"
        dgvPorVencer.ReadOnly = True
        dgvPorVencer.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvPorVencer.RowHeadersVisible = False
        dgvPorVencer.RowHeadersWidth = 51
        dgvPorVencer.RowTemplate.Height = 28
        dgvPorVencer.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPorVencer.Size = New Size(455, 275)
        dgvPorVencer.TabIndex = 2
        ' 
        ' lblTituloPorVencer
        ' 
        lblTituloPorVencer.AutoSize = True
        lblTituloPorVencer.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTituloPorVencer.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        lblTituloPorVencer.Location = New Point(220, 170)
        lblTituloPorVencer.Name = "lblTituloPorVencer"
        lblTituloPorVencer.Size = New Size(285, 25)
        lblTituloPorVencer.TabIndex = 3
        lblTituloPorVencer.Text = "Membresías próximas a vencer"
        ' 
        ' dgvClasesHoy
        ' 
        dgvClasesHoy.AllowUserToAddRows = False
        dgvClasesHoy.AllowUserToDeleteRows = False
        dgvClasesHoy.AllowUserToResizeRows = False
        dgvClasesHoy.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvClasesHoy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvClasesHoy.BackgroundColor = Color.White
        dgvClasesHoy.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvClasesHoy.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvClasesHoy.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvClasesHoy.ColumnHeadersHeight = 32
        dgvClasesHoy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvClasesHoy.EnableHeadersVisualStyles = False
        dgvClasesHoy.Location = New Point(681, 195)
        dgvClasesHoy.MultiSelect = False
        dgvClasesHoy.Name = "dgvClasesHoy"
        dgvClasesHoy.ReadOnly = True
        dgvClasesHoy.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvClasesHoy.RowHeadersVisible = False
        dgvClasesHoy.RowHeadersWidth = 51
        dgvClasesHoy.RowTemplate.Height = 28
        dgvClasesHoy.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvClasesHoy.Size = New Size(399, 275)
        dgvClasesHoy.TabIndex = 4
        ' 
        ' lblTituloClasesHoy
        ' 
        lblTituloClasesHoy.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblTituloClasesHoy.AutoSize = True
        lblTituloClasesHoy.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTituloClasesHoy.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        lblTituloClasesHoy.Location = New Point(800, 170)
        lblTituloClasesHoy.Name = "lblTituloClasesHoy"
        lblTituloClasesHoy.Size = New Size(130, 25)
        lblTituloClasesHoy.TabIndex = 5
        lblTituloClasesHoy.Text = "Clases de hoy"
        ' 
        ' lblTituloPanel
        ' 
        lblTituloPanel.AutoSize = True
        lblTituloPanel.BackColor = Color.Transparent
        lblTituloPanel.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTituloPanel.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        lblTituloPanel.Location = New Point(223, 22)
        lblTituloPanel.Name = "lblTituloPanel"
        lblTituloPanel.Size = New Size(226, 37)
        lblTituloPanel.TabIndex = 13
        lblTituloPanel.Text = "Panel de control"
        ' 
        ' lblAccesosRapidos
        ' 
        lblAccesosRapidos.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblAccesosRapidos.AutoSize = True
        lblAccesosRapidos.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAccesosRapidos.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        lblAccesosRapidos.Location = New Point(220, 495)
        lblAccesosRapidos.Name = "lblAccesosRapidos"
        lblAccesosRapidos.Size = New Size(153, 25)
        lblAccesosRapidos.TabIndex = 6
        lblAccesosRapidos.Text = "Accesos rápidos"
        ' 
        ' btnNuevoSocio
        ' 
        btnNuevoSocio.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnNuevoSocio.BackColor = Color.FromArgb(CByte(79), CByte(124), CByte(172))
        btnNuevoSocio.FlatAppearance.BorderSize = 0
        btnNuevoSocio.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(58), CByte(78), CByte(98))
        btnNuevoSocio.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(96), CByte(122))
        btnNuevoSocio.FlatStyle = FlatStyle.Flat
        btnNuevoSocio.ForeColor = Color.White
        btnNuevoSocio.Location = New Point(220, 520)
        btnNuevoSocio.Name = "btnNuevoSocio"
        btnNuevoSocio.Padding = New Padding(12, 4, 12, 4)
        btnNuevoSocio.Size = New Size(100, 43)
        btnNuevoSocio.TabIndex = 7
        btnNuevoSocio.Text = "Nuevo socio"
        btnNuevoSocio.UseVisualStyleBackColor = False
        ' 
        ' btnRegistrarPago
        ' 
        btnRegistrarPago.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnRegistrarPago.BackColor = Color.White
        btnRegistrarPago.FlatAppearance.BorderColor = Color.FromArgb(CByte(217), CByte(224), CByte(229))
        btnRegistrarPago.FlatStyle = FlatStyle.Flat
        btnRegistrarPago.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        btnRegistrarPago.Location = New Point(333, 520)
        btnRegistrarPago.Name = "btnRegistrarPago"
        btnRegistrarPago.Padding = New Padding(10, 4, 10, 4)
        btnRegistrarPago.Size = New Size(128, 43)
        btnRegistrarPago.TabIndex = 8
        btnRegistrarPago.Text = "Registrar pago"
        btnRegistrarPago.UseVisualStyleBackColor = False
        ' 
        ' btnRenovarMembresia
        ' 
        btnRenovarMembresia.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnRenovarMembresia.BackColor = Color.White
        btnRenovarMembresia.FlatAppearance.BorderColor = Color.FromArgb(CByte(217), CByte(224), CByte(229))
        btnRenovarMembresia.FlatStyle = FlatStyle.Flat
        btnRenovarMembresia.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        btnRenovarMembresia.Location = New Point(473, 520)
        btnRenovarMembresia.Name = "btnRenovarMembresia"
        btnRenovarMembresia.Padding = New Padding(10, 4, 10, 4)
        btnRenovarMembresia.Size = New Size(156, 43)
        btnRenovarMembresia.TabIndex = 9
        btnRenovarMembresia.Text = "Renovar membresía"
        btnRenovarMembresia.UseVisualStyleBackColor = False
        ' 
        ' btnVerHorarios
        ' 
        btnVerHorarios.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnVerHorarios.BackColor = Color.White
        btnVerHorarios.FlatAppearance.BorderColor = Color.FromArgb(CByte(217), CByte(224), CByte(229))
        btnVerHorarios.FlatStyle = FlatStyle.Flat
        btnVerHorarios.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        btnVerHorarios.Location = New Point(643, 520)
        btnVerHorarios.Name = "btnVerHorarios"
        btnVerHorarios.Padding = New Padding(10, 4, 10, 4)
        btnVerHorarios.Size = New Size(128, 43)
        btnVerHorarios.TabIndex = 10
        btnVerHorarios.Text = "Ver horarios"
        btnVerHorarios.UseVisualStyleBackColor = False
        ' 
        ' stsSesion
        ' 
        stsSesion.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        stsSesion.ForeColor = Color.FromArgb(CByte(96), CByte(125), CByte(139))
        stsSesion.ImageScalingSize = New Size(20, 20)
        stsSesion.Items.AddRange(New ToolStripItem() {lblSesionUsuario, lblSesionRol, lblSesionServidor, lblSesionFechaHora})
        stsSesion.Location = New Point(217, 624)
        stsSesion.Name = "stsSesion"
        stsSesion.Padding = New Padding(10, 0, 10, 0)
        stsSesion.Size = New Size(883, 26)
        stsSesion.SizingGrip = False
        stsSesion.TabIndex = 11
        stsSesion.Text = "StatusStrip1"
        ' 
        ' lblSesionUsuario
        ' 
        lblSesionUsuario.ForeColor = Color.FromArgb(CByte(96), CByte(125), CByte(139))
        lblSesionUsuario.Name = "lblSesionUsuario"
        lblSesionUsuario.Size = New Size(72, 20)
        lblSesionUsuario.Text = "Usuario: -"
        ' 
        ' lblSesionRol
        ' 
        lblSesionRol.ForeColor = Color.FromArgb(CByte(96), CByte(125), CByte(139))
        lblSesionRol.Margin = New Padding(12, 3, 0, 2)
        lblSesionRol.Name = "lblSesionRol"
        lblSesionRol.Size = New Size(44, 21)
        lblSesionRol.Text = "Rol: -"
        ' 
        ' lblSesionServidor
        ' 
        lblSesionServidor.ForeColor = Color.FromArgb(CByte(96), CByte(125), CByte(139))
        lblSesionServidor.Margin = New Padding(12, 3, 0, 2)
        lblSesionServidor.Name = "lblSesionServidor"
        lblSesionServidor.Size = New Size(77, 21)
        lblSesionServidor.Text = "Servidor: -"
        ' 
        ' lblSesionFechaHora
        ' 
        lblSesionFechaHora.ForeColor = Color.FromArgb(CByte(96), CByte(125), CByte(139))
        lblSesionFechaHora.Name = "lblSesionFechaHora"
        lblSesionFechaHora.Size = New Size(646, 20)
        lblSesionFechaHora.Spring = True
        lblSesionFechaHora.Text = "Fecha-hora: -"
        lblSesionFechaHora.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' mnuPrincipal
        ' 
        mnuPrincipal.BackColor = Color.White
        mnuPrincipal.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        mnuPrincipal.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        mnuPrincipal.ImageScalingSize = New Size(20, 20)
        mnuPrincipal.Items.AddRange(New ToolStripItem() {mnuArchivo, mnuSocios, mnuMmbresias, mnuPagos, mnuInstructores, mnuActividadesSalas, mnuHorarios, mnuUsuarios, mnuBitacoraAccesos, mnuSeguridad})
        mnuPrincipal.Location = New Point(0, 0)
        mnuPrincipal.Name = "mnuPrincipal"
        mnuPrincipal.RenderMode = ToolStripRenderMode.Professional
        mnuPrincipal.Size = New Size(1100, 28)
        mnuPrincipal.TabIndex = 12
        mnuPrincipal.Text = "MenuStrip1"
        ' 
        ' mnuArchivo
        ' 
        mnuArchivo.DropDownItems.AddRange(New ToolStripItem() {mnuCerrarSesion, mnuSalir})
        mnuArchivo.Name = "mnuArchivo"
        mnuArchivo.Size = New Size(73, 24)
        mnuArchivo.Text = "Archivo"
        ' 
        ' mnuCerrarSesion
        ' 
        mnuCerrarSesion.Name = "mnuCerrarSesion"
        mnuCerrarSesion.Size = New Size(177, 26)
        mnuCerrarSesion.Text = "Cerrar sesión"
        ' 
        ' mnuSalir
        ' 
        mnuSalir.Name = "mnuSalir"
        mnuSalir.Size = New Size(177, 26)
        mnuSalir.Text = "Salir"
        ' 
        ' mnuSocios
        ' 
        mnuSocios.DropDownItems.AddRange(New ToolStripItem() {mnuGestionarSocios, mnuNuevoSocio})
        mnuSocios.Name = "mnuSocios"
        mnuSocios.Size = New Size(66, 24)
        mnuSocios.Text = "Socios"
        ' 
        ' mnuGestionarSocios
        ' 
        mnuGestionarSocios.Name = "mnuGestionarSocios"
        mnuGestionarSocios.Size = New Size(200, 26)
        mnuGestionarSocios.Text = "Gestionar socios"
        ' 
        ' mnuNuevoSocio
        ' 
        mnuNuevoSocio.Name = "mnuNuevoSocio"
        mnuNuevoSocio.Size = New Size(200, 26)
        mnuNuevoSocio.Text = "Nuevo socio"
        ' 
        ' mnuMmbresias
        ' 
        mnuMmbresias.DropDownItems.AddRange(New ToolStripItem() {mnuTiposMembresia, mnuMembresiasPagos})
        mnuMmbresias.Name = "mnuMmbresias"
        mnuMmbresias.Size = New Size(103, 24)
        mnuMmbresias.Text = "Membresías"
        ' 
        ' mnuTiposMembresia
        ' 
        mnuTiposMembresia.Name = "mnuTiposMembresia"
        mnuTiposMembresia.Size = New Size(233, 26)
        mnuTiposMembresia.Text = "Tipos de membresías"
        ' 
        ' mnuMembresiasPagos
        ' 
        mnuMembresiasPagos.Name = "mnuMembresiasPagos"
        mnuMembresiasPagos.Size = New Size(233, 26)
        mnuMembresiasPagos.Text = "Membresías y pagos"
        ' 
        ' mnuPagos
        ' 
        mnuPagos.DropDownItems.AddRange(New ToolStripItem() {mnuRegistrarPago})
        mnuPagos.Name = "mnuPagos"
        mnuPagos.Size = New Size(62, 24)
        mnuPagos.Text = "Pagos"
        ' 
        ' mnuRegistrarPago
        ' 
        mnuRegistrarPago.Name = "mnuRegistrarPago"
        mnuRegistrarPago.Size = New Size(190, 26)
        mnuRegistrarPago.Text = "Registrat pago"
        ' 
        ' mnuInstructores
        ' 
        mnuInstructores.DropDownItems.AddRange(New ToolStripItem() {mnuGestionarInstructores})
        mnuInstructores.Name = "mnuInstructores"
        mnuInstructores.Size = New Size(99, 24)
        mnuInstructores.Text = "Instructores"
        ' 
        ' mnuGestionarInstructores
        ' 
        mnuGestionarInstructores.Name = "mnuGestionarInstructores"
        mnuGestionarInstructores.Size = New Size(235, 26)
        mnuGestionarInstructores.Text = "Gestionar instructores"
        ' 
        ' mnuActividadesSalas
        ' 
        mnuActividadesSalas.DropDownItems.AddRange(New ToolStripItem() {mnuActividades, mnuSalas})
        mnuActividadesSalas.Name = "mnuActividadesSalas"
        mnuActividadesSalas.Size = New Size(147, 24)
        mnuActividadesSalas.Text = "Actividades y salas"
        ' 
        ' mnuActividades
        ' 
        mnuActividades.Name = "mnuActividades"
        mnuActividades.Size = New Size(169, 26)
        mnuActividades.Text = "Actividades"
        ' 
        ' mnuSalas
        ' 
        mnuSalas.Name = "mnuSalas"
        mnuSalas.Size = New Size(169, 26)
        mnuSalas.Text = "Salas"
        ' 
        ' mnuHorarios
        ' 
        mnuHorarios.DropDownItems.AddRange(New ToolStripItem() {mnuProgramacionSemanal})
        mnuHorarios.Name = "mnuHorarios"
        mnuHorarios.Size = New Size(80, 24)
        mnuHorarios.Text = "Horarios"
        ' 
        ' mnuProgramacionSemanal
        ' 
        mnuProgramacionSemanal.Name = "mnuProgramacionSemanal"
        mnuProgramacionSemanal.Size = New Size(244, 26)
        mnuProgramacionSemanal.Text = "Programación semanal"
        ' 
        ' mnuUsuarios
        ' 
        mnuUsuarios.DropDownItems.AddRange(New ToolStripItem() {mnuGestionarUsuarios})
        mnuUsuarios.Name = "mnuUsuarios"
        mnuUsuarios.Size = New Size(79, 24)
        mnuUsuarios.Text = "Usuarios"
        ' 
        ' mnuGestionarUsuarios
        ' 
        mnuGestionarUsuarios.Name = "mnuGestionarUsuarios"
        mnuGestionarUsuarios.Size = New Size(213, 26)
        mnuGestionarUsuarios.Text = "Gestionar usuarios"
        ' 
        ' mnuBitacoraAccesos
        ' 
        mnuBitacoraAccesos.DropDownItems.AddRange(New ToolStripItem() {mnuConsultarBitacora})
        mnuBitacoraAccesos.Name = "mnuBitacoraAccesos"
        mnuBitacoraAccesos.Size = New Size(154, 24)
        mnuBitacoraAccesos.Text = "Bitácora de accesos"
        ' 
        ' mnuConsultarBitacora
        ' 
        mnuConsultarBitacora.Name = "mnuConsultarBitacora"
        mnuConsultarBitacora.Size = New Size(213, 26)
        mnuConsultarBitacora.Text = "Consultar bitácora"
        ' 
        ' mnuSeguridad
        ' 
        mnuSeguridad.DropDownItems.AddRange(New ToolStripItem() {mnuCambiarContrasena})
        mnuSeguridad.Name = "mnuSeguridad"
        mnuSeguridad.Size = New Size(91, 24)
        mnuSeguridad.Text = "Seguridad"
        ' 
        ' mnuCambiarContrasena
        ' 
        mnuCambiarContrasena.Name = "mnuCambiarContrasena"
        mnuCambiarContrasena.Size = New Size(224, 26)
        mnuCambiarContrasena.Text = "Cambiar contraseña"
        ' 
        ' lblSubtituloPanel
        ' 
        lblSubtituloPanel.AutoSize = True
        lblSubtituloPanel.ForeColor = Color.FromArgb(CByte(96), CByte(125), CByte(139))
        lblSubtituloPanel.Location = New Point(223, 59)
        lblSubtituloPanel.Name = "lblSubtituloPanel"
        lblSubtituloPanel.Size = New Size(337, 20)
        lblSubtituloPanel.TabIndex = 14
        lblSubtituloPanel.Text = "Resumen del día, lunes 21 de septiembre de 2026"
        ' 
        ' frmPrincipal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(244), CByte(246), CByte(248))
        ClientSize = New Size(1100, 650)
        Controls.Add(lblSubtituloPanel)
        Controls.Add(btnVerHorarios)
        Controls.Add(btnRenovarMembresia)
        Controls.Add(btnRegistrarPago)
        Controls.Add(btnNuevoSocio)
        Controls.Add(lblAccesosRapidos)
        Controls.Add(lblTituloClasesHoy)
        Controls.Add(dgvClasesHoy)
        Controls.Add(lblTituloPorVencer)
        Controls.Add(dgvPorVencer)
        Controls.Add(stsSesion)
        Controls.Add(pnlIndicadores)
        Controls.Add(pnlNavegacion)
        Controls.Add(mnuPrincipal)
        Controls.Add(lblTituloPanel)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MainMenuStrip = mnuPrincipal
        Name = "frmPrincipal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "GymControl"
        WindowState = FormWindowState.Maximized
        pnlNavegacion.ResumeLayout(False)
        pnlIndicadores.ResumeLayout(False)
        pnlClasesHoy.ResumeLayout(False)
        pnlClasesHoy.PerformLayout()
        pnlIngresosMes.ResumeLayout(False)
        pnlIngresosMes.PerformLayout()
        pnlMembresiasPorVencer.ResumeLayout(False)
        pnlMembresiasPorVencer.PerformLayout()
        pnlSociosActivos.ResumeLayout(False)
        pnlSociosActivos.PerformLayout()
        CType(dgvPorVencer, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvClasesHoy, ComponentModel.ISupportInitialize).EndInit()
        stsSesion.ResumeLayout(False)
        stsSesion.PerformLayout()
        mnuPrincipal.ResumeLayout(False)
        mnuPrincipal.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlNavegacion As Panel
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents btnBitacora As Button
    Friend WithEvents btnUsuarios As Button
    Friend WithEvents btnHorarios As Button
    Friend WithEvents btnActividadesSalas As Button
    Friend WithEvents btnInstructores As Button
    Friend WithEvents btnPagos As Button
    Friend WithEvents btnMembresias As Button
    Friend WithEvents btnSocios As Button
    Friend WithEvents btnInicio As Button
    Friend WithEvents pnlIndicadores As Panel
    Friend WithEvents pnlSociosActivos As Panel
    Friend WithEvents lblTotalSocios As Label
    Friend WithEvents lblSociosActivos As Label
    Friend WithEvents pnlMembresiasPorVencer As Panel
    Friend WithEvents lblTotalPorVencer As Label
    Friend WithEvents lblMembresiasPorVencer As Label
    Friend WithEvents pnlIngresosMes As Panel
    Friend WithEvents lblTotalIngresos As Label
    Friend WithEvents lblIngresosMes As Label
    Friend WithEvents pnlClasesHoy As Panel
    Friend WithEvents lblTotalClasesHoy As Label
    Friend WithEvents lblClasesHoy As Label
    Friend WithEvents dgvPorVencer As DataGridView
    Friend WithEvents lblTituloPorVencer As Label
    Friend WithEvents dgvClasesHoy As DataGridView
    Friend WithEvents lblTituloClasesHoy As Label
    Friend WithEvents lblAccesosRapidos As Label
    Friend WithEvents btnNuevoSocio As Button
    Friend WithEvents btnRegistrarPago As Button
    Friend WithEvents btnRenovarMembresia As Button
    Friend WithEvents btnVerHorarios As Button
    Friend WithEvents stsSesion As StatusStrip
    Friend WithEvents lblSesionUsuario As ToolStripStatusLabel
    Friend WithEvents lblSesionRol As ToolStripStatusLabel
    Friend WithEvents lblSesionServidor As ToolStripStatusLabel
    Friend WithEvents lblSesionFechaHora As ToolStripStatusLabel
    Friend WithEvents mnuPrincipal As MenuStrip
    Friend WithEvents mnuArchivo As ToolStripMenuItem
    Friend WithEvents mnuSocios As ToolStripMenuItem
    Friend WithEvents mnuMmbresias As ToolStripMenuItem
    Friend WithEvents mnuPagos As ToolStripMenuItem
    Friend WithEvents mnuInstructores As ToolStripMenuItem
    Friend WithEvents mnuActividadesSalas As ToolStripMenuItem
    Friend WithEvents mnuHorarios As ToolStripMenuItem
    Friend WithEvents mnuUsuarios As ToolStripMenuItem
    Friend WithEvents mnuBitacoraAccesos As ToolStripMenuItem
    Friend WithEvents mnuSeguridad As ToolStripMenuItem
    Friend WithEvents mnuCerrarSesion As ToolStripMenuItem
    Friend WithEvents mnuSalir As ToolStripMenuItem
    Friend WithEvents mnuGestionarSocios As ToolStripMenuItem
    Friend WithEvents mnuNuevoSocio As ToolStripMenuItem
    Friend WithEvents mnuTiposMembresia As ToolStripMenuItem
    Friend WithEvents mnuMembresiasPagos As ToolStripMenuItem
    Friend WithEvents mnuRegistrarPago As ToolStripMenuItem
    Friend WithEvents mnuGestionarInstructores As ToolStripMenuItem
    Friend WithEvents mnuActividades As ToolStripMenuItem
    Friend WithEvents mnuSalas As ToolStripMenuItem
    Friend WithEvents mnuProgramacionSemanal As ToolStripMenuItem
    Friend WithEvents mnuGestionarUsuarios As ToolStripMenuItem
    Friend WithEvents mnuConsultarBitacora As ToolStripMenuItem
    Friend WithEvents mnuCambiarContrasena As ToolStripMenuItem
    Friend WithEvents lblTituloPanel As Label
    Friend WithEvents lblSubtituloPanel As Label

End Class
