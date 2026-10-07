Imports System.Globalization

Public Class frmPrincipal

    ' =========================================================
    ' CARGA DEL FORMULARIO
    ' =========================================================
    Private Sub frmPrincipal_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        ' frmPrincipal solo se abre con una sesión activa.
        If Not Sesion.HaySesion() Then

            MessageBox.Show(
                "No hay una sesión activa. Debe iniciar sesión.",
                "GymControl",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Close()
            Return

        End If

        MostrarInfoSesion()
        AplicarPermisos()
        CargarIndicadores()

    End Sub


    ' =========================================================
    ' INFORMACIÓN DE LA SESIÓN (BARRA DE ESTADO)
    ' =========================================================
    Private Sub MostrarInfoSesion()

        lblSesionUsuario.Text =
            "Usuario: " & Sesion.NombreUsuario

        lblSesionRol.Text =
            "Rol: " & Sesion.Rol


        Dim mensaje As String = ""

        If ConexionBD.ProbarConexion(mensaje) Then

            lblSesionServidor.Text =
                "Servidor: " & mensaje

        Else

            lblSesionServidor.Text =
                "Servidor: no disponible"

        End If


        ActualizarFechaHora()


        ' Subtítulo del panel con la fecha del día.
        Try

            Dim cultura As CultureInfo =
                CultureInfo.GetCultureInfo("es-NI")

            lblSubtituloPanel.Text =
                "Resumen del día, " &
                Date.Today.ToString(
                    "dddd, d 'de' MMMM 'de' yyyy",
                    cultura
                )

        Catch ex As CultureNotFoundException

            lblSubtituloPanel.Text =
                "Resumen del día, " &
                Date.Today.ToString(
                    "dddd, d 'de' MMMM 'de' yyyy"
                )

        End Try

    End Sub


    Private Sub ActualizarFechaHora()

        lblSesionFechaHora.Text =
            "Fecha-hora: " &
            Now.ToString("dd/MM/yyyy HH:mm")

    End Sub


    ' =========================================================
    ' PERMISOS POR ROL
    '
    ' Las opciones no permitidas se DESHABILITAN
    ' (no se ocultan) para conservar el diseño.
    ' =========================================================
    Private Sub AplicarPermisos()

        Dim rol As String = Sesion.Rol.Trim()


        ' -----------------------------------------------------
        ' ADMINISTRADOR: ACCESO COMPLETO
        ' -----------------------------------------------------
        If rol.Equals(
            "Administrador",
            StringComparison.OrdinalIgnoreCase
        ) Then

            Return

        End If


        ' -----------------------------------------------------
        ' RECEPCIONISTA: SOCIOS, MEMBRESÍAS,
        ' PAGOS Y HORARIOS (FUNCIONES DE RECEPCIÓN)
        ' -----------------------------------------------------
        If rol.Equals(
            "Recepcionista",
            StringComparison.OrdinalIgnoreCase
        ) Then

            btnInstructores.Enabled = False
            btnActividadesSalas.Enabled = False
            btnUsuarios.Enabled = False
            btnBitacora.Enabled = False

            mnuInstructores.Enabled = False
            mnuActividadesSalas.Enabled = False
            mnuUsuarios.Enabled = False
            mnuBitacoraAccesos.Enabled = False

            Return

        End If


        ' -----------------------------------------------------
        ' INSTRUCTOR: INSTRUCTORES,
        ' ACTIVIDADES Y HORARIOS
        ' -----------------------------------------------------
        If rol.Equals(
            "Instructor",
            StringComparison.OrdinalIgnoreCase
        ) Then

            btnSocios.Enabled = False
            btnMembresias.Enabled = False
            btnPagos.Enabled = False
            btnUsuarios.Enabled = False
            btnBitacora.Enabled = False

            mnuSocios.Enabled = False
            mnuMmbresias.Enabled = False
            mnuPagos.Enabled = False
            mnuUsuarios.Enabled = False
            mnuBitacoraAccesos.Enabled = False

            ' Accesos rápidos de recepción
            btnNuevoSocio.Enabled = False
            btnRegistrarPago.Enabled = False
            btnRenovarMembresia.Enabled = False

            Return

        End If

        ' Otros roles: no se aplican restricciones.

    End Sub


    ' =========================================================
    ' INDICADORES DEL PANEL
    ' =========================================================

    ' Días de anticipación para considerar una
    ' membresía como "próxima a vencer".
    ' La base de datos y la documentación del
    ' proyecto no definen un rango, por lo que se
    ' usa 7 días como valor predeterminado.
    Private Const DiasPorVencer As Integer = 7

    Private Sub CargarIndicadores()

        ' -----------------------------------------------------
        ' SOCIOS ACTIVOS
        ' UsuarioDAO.ListarSocios() devuelve
        ' únicamente los socios activos.
        ' -----------------------------------------------------
        Try

            Dim dao As New UsuarioDAO()

            Dim sociosActivos As DataTable =
                dao.ListarSocios()

            lblTotalSocios.Text =
                sociosActivos.Rows.Count.ToString()

        Catch
            ' Sin datos disponibles;
            ' se deja el indicador en un valor seguro.
            lblTotalSocios.Text = "0"
        End Try


        ' -----------------------------------------------------
        ' MEMBRESÍAS POR VENCER
        ' -----------------------------------------------------
        Try

            Dim membresiasDAO As New MembresiaDAO()

            Dim porVencer As DataTable =
                membresiasDAO.ListarMembresiasPorVencer(
                    Date.Today,
                    DiasPorVencer
                )

            lblTotalPorVencer.Text =
                porVencer.Rows.Count.ToString()

            dgvPorVencer.DataSource =
                porVencer

        Catch
            ' Sin datos disponibles;
            ' se deja el indicador en un valor seguro.
            lblTotalPorVencer.Text = "0"
        End Try


        ' -----------------------------------------------------
        ' INGRESOS DEL MES
        ' Se suman únicamente los pagos no anulados
        ' del mes actual.
        ' -----------------------------------------------------
        Try

            Dim pagosDAO As New PagoDAO()

            Dim ingresos As Decimal =
                pagosDAO.ObtenerIngresosDelMes(
                    Date.Today
                )

            lblTotalIngresos.Text =
                "C$ " & ingresos.ToString("N2")

        Catch
            ' Sin datos disponibles;
            ' se deja el indicador en un valor seguro.
            lblTotalIngresos.Text = "C$ 0.00"
        End Try


        ' -----------------------------------------------------
        ' CLASES DE HOY
        ' 1=Lunes, 2=Martes, ..., 7=Domingo
        ' -----------------------------------------------------
        Try

            Dim diaSemana As Integer =
                If(
                    Date.Today.DayOfWeek = DayOfWeek.Sunday,
                    7,
                    CInt(Date.Today.DayOfWeek)
                )

            Dim horariosDAO As New HorarioDAO()

            Dim clasesHoy As DataTable =
                horariosDAO.ListarClasesDeHoy(
                    diaSemana
                )

            lblTotalClasesHoy.Text =
                clasesHoy.Rows.Count.ToString()

            dgvClasesHoy.DataSource =
                clasesHoy

        Catch
            ' Sin datos disponibles;
            ' se deja el indicador en un valor seguro.
            lblTotalClasesHoy.Text = "0"
        End Try

    End Sub


    ' =========================================================
    ' NAVEGACIÓN: INICIO
    ' =========================================================
    Private Sub btnInicio_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnInicio.Click

        ' El panel de inicio ya está visible;
        ' se actualizan los datos del día.
        MostrarInfoSesion()
        CargarIndicadores()

    End Sub


    ' =========================================================
    ' NAVEGACIÓN: SOCIOS
    ' =========================================================
    Private Sub btnSocios_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnSocios.Click,
            mnuGestionarSocios.Click,
            mnuNuevoSocio.Click

        Using formulario As New FrmSocios()
            formulario.ShowDialog()
        End Using

    End Sub


    ' =========================================================
    ' NAVEGACIÓN: MEMBRESÍAS
    ' =========================================================
    Private Sub btnMembresias_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnMembresias.Click,
            btnRenovarMembresia.Click,
            mnuMembresiasPagos.Click

        Using formulario As New frmMembresiasPagos()
            formulario.ShowDialog()
        End Using

    End Sub


    ' =========================================================
    ' NAVEGACIÓN: PAGOS
    ' =========================================================
    Private Sub btnPagos_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnPagos.Click,
            btnRegistrarPago.Click,
            mnuRegistrarPago.Click

        Using formulario As New frmMembresiasPagos()
            formulario.ShowDialog()
        End Using

    End Sub


    ' =========================================================
    ' NAVEGACIÓN: INSTRUCTORES
    ' =========================================================
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnInstructores.Click,
            mnuGestionarInstructores.Click

        Using formulario As New frmInstructores()
            formulario.ShowDialog()
        End Using

    End Sub


    ' =========================================================
    ' NAVEGACIÓN: HORARIOS
    ' =========================================================
    Private Sub btnHorarios_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnHorarios.Click,
            btnVerHorarios.Click,
            mnuProgramacionSemanal.Click

        Using formulario As New frmHorarios()
            formulario.ShowDialog()
        End Using

    End Sub


    ' =========================================================
    ' CERRAR SESIÓN
    ' =========================================================
    Private Sub btnCerrarSesion_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnCerrarSesion.Click,
            mnuCerrarSesion.Click

        CerrarSesionConfirmada()

    End Sub


    Private Sub CerrarSesionConfirmada()

        Dim respuesta As DialogResult =
            MessageBox.Show(
                "¿Desea cerrar la sesión actual?",
                "Confirmar cierre de sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )

        If respuesta <> DialogResult.Yes Then
            Return
        End If


        Sesion.CerrarSesion()


        ' Volver a mostrar el inicio de sesión.
        ' Cuando este formulario se cierra, el frmLogin
        ' original también termina por sí solo.
        Using login As New frmLogin()
            login.ShowDialog()
        End Using


        Close()

    End Sub


    ' =========================================================
    ' SALIR DE LA APLICACIÓN
    ' =========================================================
    Private Sub mnuSalir_Click(
        sender As Object,
        e As EventArgs
    ) Handles mnuSalir.Click

        Dim respuesta As DialogResult =
            MessageBox.Show(
                "¿Desea salir de GymControl?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )

        If respuesta = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub


    ' =========================================================
    ' ACCESOS RÁPIDOS Y MENÚS EXISTENTES
    ' =========================================================
    Private Sub btnNuevoSocio_Click(sender As Object, e As EventArgs) Handles btnNuevoSocio.Click

        Using formulario As New FrmSocios()
            formulario.ShowDialog()
        End Using

    End Sub

    Private Sub btnUsuarios_Click(sender As Object,
                              e As EventArgs) Handles btnUsuarios.Click,
                              mnuGestionarUsuarios.Click

        Using formulario As New frmUsuarios()
            formulario.ShowDialog()
        End Using

    End Sub

    Private Sub btnBitacora_Click(
    sender As Object,
    e As EventArgs
) Handles btnBitacora.Click

        Using formulario As New frmBitacora()
            formulario.ShowDialog()
        End Using

    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuConsultarBitacora.Click

        Using formulario As New frmBitacora()
            formulario.ShowDialog()
        End Using

    End Sub

    Private Sub mnuCambiarContrasena_Click(
    sender As Object,
    e As EventArgs
) Handles mnuCambiarContrasena.Click

        Using formulario As New frmCambiarContrasena()
            formulario.ShowDialog(Me)
        End Using

    End Sub


    ' =========================================================
    ' EVENTOS EXISTENTES SIN LÓGICA (SE CONSERVAN)
    ' =========================================================
    Private Sub lblTotalSocios_Click(sender As Object, e As EventArgs) Handles lblTotalSocios.Click

    End Sub

    Private Sub lblIngresosMes_Click(sender As Object, e As EventArgs) Handles lblTituloClasesHoy.Click

    End Sub

    Private Sub plnIngresosMes_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub lblTituloPorVencer_Click(sender As Object, e As EventArgs) Handles lblTituloPorVencer.Click

    End Sub

    Private Sub mnuPrincipal_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnuPrincipal.ItemClicked

    End Sub

    Private Sub btnActividadesSalas_Click(
    sender As Object,
    e As EventArgs
) Handles btnActividadesSalas.Click

        Using formulario As New frmActividades()
            formulario.ShowDialog(Me)
        End Using

    End Sub

    Private Sub mnuActividades_Click(
    sender As Object,
    e As EventArgs
) Handles mnuActividades.Click

        Using formulario As New frmActividades()
            formulario.ShowDialog(Me)
        End Using

    End Sub

    Private Sub mnuSalas_Click(
        sender As Object,
        e As EventArgs
    ) Handles mnuSalas.Click

        Using formulario As New frmSalas()
            formulario.ShowDialog(Me)
        End Using

    End Sub
End Class
