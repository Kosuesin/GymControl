Imports System.Data
Imports System.IO
Imports Microsoft.Reporting.WinForms

''' <summary>
''' Visor único de los reportes R04, R05 y R06.
'''
''' El formulario solo recoge filtros y muestra el RDLC. Toda la
''' consulta SQL está en ReporteDAO y todos los datos vienen de
''' las vistas vw_ingresos_detalle, vw_saldos_membresia,
''' vw_estado_cuenta y vw_horario_semanal con el usuario
''' gym_reportes.
''' </summary>
Public Class frmVisorReportes

    Private ReadOnly _codigo As String
    Private ReadOnly _dao As New ReporteDAO()
    Private ReadOnly _reportViewer As New ReportViewer()
    Private _definicion As DefinicionReporte
    Private _datosCargados As Boolean

    Public Sub New()
        Me.New(ReporteCatalogo.R04)
    End Sub

    Public Sub New(codigoReporte As String)

        InitializeComponent()

        _codigo = ReporteCatalogo.Normalizar(codigoReporte)
        If String.IsNullOrWhiteSpace(_codigo) Then _codigo = ReporteCatalogo.R04

    End Sub

    ' =========================================================
    ' CARGA
    ' =========================================================

    Private Sub frmVisorReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblSesionVisor.Text = If(
            Sesion.HaySesion(),
            "Usuario: " & Sesion.NombreUsuario & " (" & Sesion.Rol & ")",
            "Usuario: Sin sesión")

        _definicion = ReporteCatalogo.Obtener(_codigo)

        If _definicion Is Nothing Then
            MostrarAviso("El reporte solicitado no existe.")
            BeginInvoke(New Action(Sub() Close()))
            Return
        End If

        If Not Sesion.HaySesion() Then
            MostrarAviso("No hay una sesión activa. Debe iniciar sesión.")
            BeginInvoke(New Action(Sub() Close()))
            Return
        End If

        If Not ReporteCatalogo.PuedeVer(_codigo) Then
            MostrarAviso("Su rol no tiene permiso para consultar este reporte.")
            BeginInvoke(New Action(Sub() Close()))
            Return
        End If

        Text = "GymControl - " & _definicion.Codigo & " · " & _definicion.Nombre
        lblTituloVisor.Text = _definicion.Codigo & " · " & _definicion.Nombre
        lblSubtituloVisor.Text = "Gimnasio Titán · " & _definicion.Descripcion

        ConfigurarVisor()
        ConfigurarFiltros()

        If Not CargarDefinicion() Then Return

        Try
            CargarCatalogos()
            Generar()
        Catch ex As Exception
            MostrarError("No se pudieron cargar los datos del reporte.", ex)
        End Try

    End Sub

    Private Sub ConfigurarVisor()

        _reportViewer.Dock = DockStyle.Fill
        _reportViewer.ProcessingMode = ProcessingMode.Local
        _reportViewer.ShowParameterPrompts = False
        _reportViewer.ShowPrintButton = True
        _reportViewer.ShowExportButton = True
        _reportViewer.SetDisplayMode(DisplayMode.PrintLayout)
        _reportViewer.ZoomMode = ZoomMode.PageWidth

        pnlVisor.Controls.Add(_reportViewer)
        _reportViewer.BringToFront()

    End Sub

    Private Function CargarDefinicion() As Boolean

        Dim ruta As String = ReporteCatalogo.RutaRdlc(_codigo)

        If String.IsNullOrWhiteSpace(ruta) OrElse Not File.Exists(ruta) Then
            MostrarAviso("No se encontró el archivo del reporte:" & Environment.NewLine & ruta)
            btnGenerar.Enabled = False
            Return False
        End If

        Try
            Using fs As New FileStream(ruta, FileMode.Open, FileAccess.Read)
                _reportViewer.LocalReport.LoadReportDefinition(fs)
            End Using

            _reportViewer.LocalReport.DisplayName = _definicion.Codigo & " - " & _definicion.Nombre
            Return True

        Catch ex As Exception
            MostrarError("No se pudo cargar la definición del reporte.", ex)
            btnGenerar.Enabled = False
            Return False

        End Try

    End Function

    ' =========================================================
    ' FILTROS
    ' =========================================================

    Private Sub ConfigurarFiltros()

        OcultarFiltros()

        dtpFechaInicio.Value = New Date(Date.Today.Year, Date.Today.Month, 1)
        dtpFechaFin.Value = Date.Today

        Select Case _codigo

            Case ReporteCatalogo.R04
                lblFechaInicio.Text = "Fecha desde:"
                MostrarFiltros(True, True, True, False, False, False, False)

            Case ReporteCatalogo.R05
                lblFechaInicio.Text = "Pagos desde:"
                dtpFechaInicio.Value = New Date(2000, 1, 1)
                MostrarFiltros(True, False, False, True, False, False, False)

                If EsRol("Socio") Then
                    cboSocios.Enabled = False
                    lblInfoSocio.Text = "Solo puede consultar su propia cuenta."
                    lblInfoSocio.Visible = True
                End If

            Case ReporteCatalogo.R06
                MostrarFiltros(False, False, False, False, True, True, True)

                If EsRol("Instructor") AndAlso Sesion.IdInstructor.HasValue Then
                    cboInstructor.Enabled = False
                    lblEstadoVisor.Text = "Filtrado por el instructor de la sesión."
                End If

        End Select

    End Sub

    Private Sub OcultarFiltros()

        lblFechaInicio.Visible = False
        dtpFechaInicio.Visible = False
        lblFechaFin.Visible = False
        dtpFechaFin.Visible = False
        lblMetodo.Visible = False
        cboMetodo.Visible = False

        lblSocio.Visible = False
        cboSocios.Visible = False
        lblInfoSocio.Visible = False

        lblSala.Visible = False
        cboSala.Visible = False
        lblInstructor.Visible = False
        cboInstructor.Visible = False
        chkSoloActivos.Visible = False

    End Sub

    Private Sub MostrarFiltros(fechas As Boolean, metodo As Boolean, fin As Boolean,
                               socio As Boolean, sala As Boolean,
                               instructor As Boolean, activos As Boolean)

        lblFechaInicio.Visible = fechas
        dtpFechaInicio.Visible = fechas
        lblFechaFin.Visible = fin
        dtpFechaFin.Visible = fin
        lblMetodo.Visible = metodo
        cboMetodo.Visible = metodo

        lblSocio.Visible = socio
        cboSocios.Visible = socio

        lblSala.Visible = sala
        cboSala.Visible = sala
        lblInstructor.Visible = instructor
        cboInstructor.Visible = instructor
        chkSoloActivos.Visible = activos

    End Sub

    Private Sub CargarCatalogos()

        Select Case _codigo

            Case ReporteCatalogo.R04
                CargarMetodosPago()

            Case ReporteCatalogo.R05
                CargarSocios()

            Case ReporteCatalogo.R06
                CargarSalas()
                CargarInstructores()

        End Select

    End Sub

    Private Sub CargarMetodosPago()

        Dim tabla As DataTable = _dao.ListarMetodosPago()

        cboMetodo.Items.Clear()
        cboMetodo.Items.Add(FiltroReporte.Todos)

        For Each fila As DataRow In tabla.Rows
            cboMetodo.Items.Add(fila("metodo_pago").ToString())
        Next

        cboMetodo.SelectedIndex = 0

    End Sub

    Private Sub CargarSocios()

        Dim tabla As DataTable = _dao.ListarSocios()

        If Not tabla.Columns.Contains("Descripcion") Then
            tabla.Columns.Add("Descripcion", GetType(String))
        End If

        For Each fila As DataRow In tabla.Rows
            fila("Descripcion") =
                fila("socio").ToString() & "  ·  " &
                If(fila("cedula") Is DBNull.Value, String.Empty, fila("cedula").ToString())
        Next

        cboSocios.DataSource = Nothing
        cboSocios.DisplayMember = "Descripcion"
        cboSocios.ValueMember = "id_socio"
        cboSocios.DataSource = tabla

        If tabla.Rows.Count > 0 Then
            cboSocios.SelectedIndex = 0
        End If

        If EsRol("Socio") Then
            If Sesion.IdSocio.HasValue Then
                SeleccionarSocio(Sesion.IdSocio.Value)
            Else
                cboSocios.Enabled = False
                btnGenerar.Enabled = False
                MostrarAviso("La sesión de socio no tiene un socio asociado.")
            End If
        End If

    End Sub

    Private Sub SeleccionarSocio(idSocio As Integer)

        Dim tabla As DataTable = DirectCast(cboSocios.DataSource, DataTable)

        For i As Integer = 0 To tabla.Rows.Count - 1
            If Convert.ToInt32(tabla.Rows(i)("id_socio")) = idSocio Then
                cboSocios.SelectedIndex = i
                Return
            End If
        Next

        cboSocios.SelectedIndex = -1

    End Sub

    Private Sub CargarSalas()

        Dim origen As DataTable = _dao.ListarSalas()
        Dim tabla As New DataTable("FiltroSalas")
        tabla.Columns.Add("id_sala", GetType(Integer))
        tabla.Columns.Add("sala", GetType(String))
        tabla.Rows.Add(0, "TODOS")

        For Each fila As DataRow In origen.Rows
            tabla.Rows.Add(Convert.ToInt32(fila("id_sala")), fila("sala").ToString())
        Next

        cboSala.DataSource = Nothing
        cboSala.DisplayMember = "sala"
        cboSala.ValueMember = "id_sala"
        cboSala.DataSource = tabla
        cboSala.SelectedIndex = 0

    End Sub

    Private Sub CargarInstructores()

        Dim origen As DataTable = _dao.ListarInstructores()
        Dim tabla As New DataTable("FiltroInstructores")
        tabla.Columns.Add("id_instructor", GetType(Integer))
        tabla.Columns.Add("instructor", GetType(String))
        tabla.Rows.Add(0, "TODOS")

        For Each fila As DataRow In origen.Rows
            tabla.Rows.Add(Convert.ToInt32(fila("id_instructor")), fila("instructor").ToString())
        Next

        cboInstructor.DataSource = Nothing
        cboInstructor.DisplayMember = "instructor"
        cboInstructor.ValueMember = "id_instructor"
        cboInstructor.DataSource = tabla
        cboInstructor.SelectedIndex = 0

        If EsRol("Instructor") AndAlso Sesion.IdInstructor.HasValue Then
            For i As Integer = 0 To tabla.Rows.Count - 1
                If Convert.ToInt32(tabla.Rows(i)("id_instructor")) = Sesion.IdInstructor.Value Then
                    cboInstructor.SelectedIndex = i
                    Exit For
                End If
            Next
        End If

    End Sub

    ' =========================================================
    ' GENERACIÓN DEL REPORTE
    ' =========================================================

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Generar()
    End Sub

    Private Sub Generar()

        If _definicion Is Nothing Then Return

        Dim filtro As FiltroReporte

        Try
            filtro = ConstruirFiltro()

            Dim errorFiltro As String = filtro.Validar()
            If Not String.IsNullOrWhiteSpace(errorFiltro) Then
                MostrarAviso(errorFiltro)
                Return
            End If

            If _codigo = ReporteCatalogo.R05 AndAlso Not filtro.IdSocio.HasValue Then
                MostrarAviso("Seleccione un socio para consultar su estado de cuenta.")
                Return
            End If

        Catch ex As ArgumentException
            MostrarAviso(ex.Message)
            Return
        End Try

        btnGenerar.Enabled = False
        btnImprimir.Enabled = False
        Cursor = Cursors.WaitCursor
        lblEstadoVisor.Text = "Generando reporte..."

        Try

            _reportViewer.LocalReport.DataSources.Clear()

            Select Case _codigo
                Case ReporteCatalogo.R04
                    CargarR04(filtro)
                Case ReporteCatalogo.R05
                    CargarR05(filtro)
                Case ReporteCatalogo.R06
                    CargarR06(filtro)
            End Select

            _reportViewer.SetDisplayMode(DisplayMode.PrintLayout)
            _reportViewer.ZoomMode = ZoomMode.PageWidth
            _reportViewer.RefreshReport()

            _datosCargados = True
            btnImprimir.Enabled = True

        Catch ex As InvalidOperationException
            MostrarError("No se pudo conectar con el usuario de reportes.", ex)
            lblEstadoVisor.Text = "Sin conexión para reportes."

        Catch ex As Exception
            MostrarError("No se pudo generar el reporte.", ex)
            lblEstadoVisor.Text = "Error al generar el reporte."

        Finally
            Cursor = Cursors.Default
            btnGenerar.Enabled = True
        End Try

    End Sub

    Private Sub CargarR04(filtro As FiltroReporte)

        Dim tabla As DataTable = _dao.ListarIngresos(filtro)

        _reportViewer.LocalReport.DataSources.Add(
            New ReportDataSource(ReporteCatalogo.DatasetIngresos, tabla))

        _reportViewer.LocalReport.SetParameters(New ReportParameter() {
            New ReportParameter("pFechaInicio", filtro.FechaInicio.ToString("dd/MM/yyyy")),
            New ReportParameter("pFechaHasta", filtro.FechaFin.ToString("dd/MM/yyyy")),
            New ReportParameter("pMetodoPago",
                If(filtro.EsTodosLosMetodos, "TODOS", filtro.MetodoPagoNormalizado())),
            New ReportParameter("pUsuario", UsuarioSesion())
        })

        lblEstadoVisor.Text =
            tabla.Rows.Count.ToString() & " pago(s) · " &
            "Dataset " & ReporteCatalogo.DatasetIngresos & " · " &
            "Total vigente: " & TotalVigente(tabla).ToString("C2")

    End Sub

    Private Sub CargarR05(filtro As FiltroReporte)

        Dim idSocio As Integer = filtro.IdSocio.Value
        Dim resumen As DataRow = _dao.ObtenerResumenEstadoCuenta(idSocio)

        If resumen Is Nothing Then
            Throw New InvalidOperationException("No se encontró el socio seleccionado.")
        End If

        Dim membresias As DataTable = _dao.ListarMembresiasEstadoCuenta(idSocio)
        Dim pagos As DataTable = _dao.ListarPagosEstadoCuenta(idSocio, filtro.FechaDesde)
        Dim tablaResumen As DataTable = resumen.Table.Clone()
        tablaResumen.ImportRow(resumen)

        _reportViewer.LocalReport.DataSources.Add(
            New ReportDataSource(ReporteCatalogo.DatasetResumenCuenta, tablaResumen))
        _reportViewer.LocalReport.DataSources.Add(
            New ReportDataSource(ReporteCatalogo.DatasetMembresias, membresias))
        _reportViewer.LocalReport.DataSources.Add(
            New ReportDataSource(ReporteCatalogo.DatasetEstadoCuenta, pagos))

        _reportViewer.LocalReport.SetParameters(New ReportParameter() {
            New ReportParameter("pSocio", Texto(resumen, "socio")),
            New ReportParameter("pCedula", Texto(resumen, "cedula")),
            New ReportParameter("pFechaDesde",
                If(filtro.FechaDesde.HasValue,
                   filtro.FechaDesde.Value.ToString("dd/MM/yyyy"),
                   "Todas las fechas")),
            New ReportParameter("pUsuario", UsuarioSesion())
        })

        lblEstadoVisor.Text =
            membresias.Rows.Count.ToString() & " membresía(s) · " &
            pagos.Rows.Count.ToString() & " pago(s) · " &
            "Datasets " & ReporteCatalogo.DatasetResumenCuenta & ", " &
            ReporteCatalogo.DatasetMembresias & ", " &
            ReporteCatalogo.DatasetEstadoCuenta & " · " &
            "Saldo: " & Convert.ToDecimal(resumen("saldo_pendiente")).ToString("C2")

    End Sub

    Private Sub CargarR06(filtro As FiltroReporte)

        Dim horario As DataTable = _dao.ListarHorario(filtro)
        Dim resumenSala As DataTable = _dao.ObtenerResumenHorarioSala(filtro)
        Dim resumenInstructor As DataTable = _dao.ObtenerResumenHorarioInstructor(filtro)

        _reportViewer.LocalReport.DataSources.Add(
            New ReportDataSource(ReporteCatalogo.DatasetHorario, horario))
        _reportViewer.LocalReport.DataSources.Add(
            New ReportDataSource(ReporteCatalogo.DatasetResumenSala, resumenSala))
        _reportViewer.LocalReport.DataSources.Add(
            New ReportDataSource(ReporteCatalogo.DatasetResumenInstructor, resumenInstructor))

        _reportViewer.LocalReport.SetParameters(New ReportParameter() {
            New ReportParameter("pSala", TextoCombo(cboSala, "TODOS")),
            New ReportParameter("pInstructor", TextoCombo(cboInstructor, "TODOS")),
            New ReportParameter("pSoloActivos", If(chkSoloActivos.Checked, "Solo activos", "Incluye inactivos")),
            New ReportParameter("pUsuario", UsuarioSesion())
        })

        lblEstadoVisor.Text =
            horario.Rows.Count.ToString() & " clase(s) · " &
            "Datasets " & ReporteCatalogo.DatasetHorario & ", " &
            ReporteCatalogo.DatasetResumenSala & ", " &
            ReporteCatalogo.DatasetResumenInstructor

    End Sub

    Private Function ConstruirFiltro() As FiltroReporte

        Dim filtro As New FiltroReporte With {
            .FechaInicio = dtpFechaInicio.Value.Date,
            .FechaFin = dtpFechaFin.Value.Date,
            .SoloActivos = chkSoloActivos.Checked
        }

        If cboMetodo.Visible Then
            filtro.MetodoPago =
                If(cboMetodo.SelectedItem Is Nothing,
                   FiltroReporte.Todos,
                   cboMetodo.SelectedItem.ToString())
        End If

        If cboSocios.Visible Then
            filtro.IdSocio = ObtenerIdCombo(cboSocios)
            filtro.FechaDesde = dtpFechaInicio.Value.Date
            ' R05 no usa FechaFin; se evita que el rango oculto bloquee
            ' una fecha "Pagos desde" posterior a hoy.
            filtro.FechaFin = Date.MaxValue.Date
        End If

        If cboSala.Visible Then
            filtro.IdSala = ObtenerIdCombo(cboSala)
        End If

        If cboInstructor.Visible Then
            filtro.IdInstructor = ObtenerIdCombo(cboInstructor)
        End If

        Return filtro

    End Function

    ' =========================================================
    ' IMPRESIÓN Y CIERRE
    ' =========================================================

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click

        If Not _datosCargados Then
            MostrarAviso("Genere el reporte antes de imprimirlo.")
            Return
        End If

        Try
            _reportViewer.PrintDialog()
        Catch ex As Exception
            MostrarError("No se pudo abrir el diálogo de impresión.", ex)
        End Try

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub

    Protected Overrides Sub OnFormClosed(e As FormClosedEventArgs)
        Try
            _reportViewer.LocalReport.DataSources.Clear()
        Catch
            ' El visor puede estar cerrándose sin un reporte cargado.
        End Try
        MyBase.OnFormClosed(e)
    End Sub

    ' =========================================================
    ' UTILIDADES
    ' =========================================================

    Private Shared Function EsRol(rol As String) As Boolean
        If Not Sesion.HaySesion() Then Return False
        Return String.Equals(If(Sesion.Rol, String.Empty).Trim(), rol,
                              StringComparison.OrdinalIgnoreCase)
    End Function

    Private Shared Function ObtenerIdCombo(combo As ComboBox) As Integer?

        If combo Is Nothing Then Return Nothing

        Dim valor As Object = combo.SelectedValue

        If valor IsNot Nothing AndAlso Not TypeOf valor Is DataRowView Then
            Dim id As Integer
            If Integer.TryParse(valor.ToString(), id) AndAlso id > 0 Then Return id
        End If

        If TypeOf combo.SelectedItem Is DataRowView Then
            Dim fila As DataRowView = DirectCast(combo.SelectedItem, DataRowView)
            If Not String.IsNullOrWhiteSpace(combo.ValueMember) AndAlso
               fila.Row.Table.Columns.Contains(combo.ValueMember) Then

                Dim id As Integer
                If Integer.TryParse(fila(combo.ValueMember).ToString(), id) AndAlso id > 0 Then
                    Return id
                End If

            End If
        End If

        Return Nothing

    End Function

    Private Shared Function TextoCombo(combo As ComboBox, defecto As String) As String

        If combo Is Nothing Then Return defecto

        If TypeOf combo.SelectedItem Is DataRowView Then
            Dim fila As DataRowView = DirectCast(combo.SelectedItem, DataRowView)
            If Not String.IsNullOrWhiteSpace(combo.DisplayMember) AndAlso
               fila.Row.Table.Columns.Contains(combo.DisplayMember) Then

                Return fila(combo.DisplayMember).ToString()

            End If
        End If

        If String.IsNullOrWhiteSpace(combo.Text) Then Return defecto
        Return combo.Text.Trim()

    End Function

    Private Shared Function Texto(fila As DataRow, campo As String) As String

        If fila Is Nothing OrElse Not fila.Table.Columns.Contains(campo) Then Return String.Empty
        If fila(campo) Is DBNull.Value Then Return String.Empty
        Return fila(campo).ToString()

    End Function

    Private Shared Function TotalVigente(tabla As DataTable) As Decimal

        If tabla Is Nothing OrElse Not tabla.Columns.Contains("monto_vigente") Then Return 0D

        Dim total As Decimal = 0D
        For Each fila As DataRow In tabla.Rows
            If fila("monto_vigente") IsNot DBNull.Value Then
                total += Convert.ToDecimal(fila("monto_vigente"))
            End If
        Next

        Return total

    End Function

    Private Shared Function UsuarioSesion() As String

        If Not Sesion.HaySesion() Then Return "Sin sesión"
        Return Sesion.NombreUsuario & " (" & Sesion.Rol & ")"

    End Function

    Private Shared Sub MostrarAviso(mensaje As String)
        MessageBox.Show(mensaje, "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Shared Sub MostrarError(mensaje As String, ex As Exception)
        MessageBox.Show(mensaje & Environment.NewLine & Environment.NewLine & ex.Message,
                        "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

End Class
