' =============================================================
' frmCentroReportes
'
' Navegación e interfaz principal del módulo de reportes.
' El TreeView de la izquierda se construye dinámicamente con
' los reportes permitidos para el rol del usuario actual
' (Sesion.Rol).
'
'   R01 - Recibo de pago en ticket de 80 mm
'   R02 - Constancia de membresía vigente
'   R03 - Listado de vencimientos (abre frmListadoVencimientos)
' =============================================================
Imports System.Data
Imports System.Linq

Public Class frmCentroReportes

    ' ---------------------------------------------------------
    ' Definición de un reporte disponible
    ' ---------------------------------------------------------
    Private Class ReporteInfo
        Public Property Codigo As String
        Public Property Nombre As String
        Public Property Categoria As String
        Public Property Descripcion As String
        Public Property Roles As String()
    End Class

    Private ReadOnly Categorias As String() = {"Recibos", "Membresías", "Listados"}

    Private ReadOnly pagoDAO As New PagoDAO()
    Private ReadOnly membresiaDAO As New MembresiaDAO()
    Private ReadOnly reportes As New List(Of ReporteInfo)()

    ' Se conserva una sola instancia para que la configuración de
    ' página (PageSetupDialog) se mantenga entre impresiones.
    Private ReadOnly constancia As New ConstanciaMembresia()

    ' =========================================================
    ' CARGA INICIAL
    ' =========================================================
    Private Sub frmCentroReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblUsuarioCentro.Text = If(
            Sesion.HaySesion(),
            "Usuario: " & Sesion.NombreUsuario & " (" & Sesion.Rol & ")",
            "Usuario: Sin sesión")

        DefinirReportes()
        ConstruirArbol()
        MostrarBienvenida()

    End Sub

    Protected Overrides Sub OnFormClosed(e As FormClosedEventArgs)
        MyBase.OnFormClosed(e)
        constancia.Dispose()
    End Sub

    ' =========================================================
    ' CATÁLOGO DE REPORTES Y PERMISOS POR ROL
    ' =========================================================
    Private Sub DefinirReportes()

        reportes.Clear()

        reportes.Add(New ReporteInfo With {
            .Codigo = "R01",
            .Nombre = "Recibo de pago (80 mm)",
            .Categoria = "Recibos",
            .Descripcion = "Comprobante de un pago registrado. Se imprime en ticket de 80 mm " &
                           "con número de recibo de 6 dígitos, monto en letras y saldo pendiente. " &
                           "Si el pago está anulado, el documento lleva la marca de agua ""ANULADO"".",
            .Roles = New String() {"Administrador", "Recepcionista"}
        })

        reportes.Add(New ReporteInfo With {
            .Codigo = "R02",
            .Nombre = "Constancia de membresía vigente",
            .Categoria = "Membresías",
            .Descripcion = "Constancia formal en papel tamaño Carta con el logotipo institucional, " &
                           "texto justificado y línea de firma. Solo se emite para socios con " &
                           "membresía activa y sin vencer.",
            .Roles = New String() {"Administrador", "Recepcionista", "Instructor"}
        })

        reportes.Add(New ReporteInfo With {
            .Codigo = "R03",
            .Nombre = "Listado de vencimientos",
            .Categoria = "Listados",
            .Descripcion = "Listado paginado de membresías por fecha de vencimiento. Permite " &
                           "definir los días hacia atrás y hacia adelante, imprimir en orientación " &
                           "horizontal y repetir el encabezado de la tabla en cada página.",
            .Roles = New String() {"Administrador", "Recepcionista", "Instructor"}
        })

    End Sub

    Private Function PuedeVer(reporte As ReporteInfo) As Boolean

        If reporte.Roles Is Nothing OrElse reporte.Roles.Length = 0 Then Return True

        Dim rol As String = If(Sesion.Rol, String.Empty).Trim()

        For Each permitido As String In reporte.Roles
            If permitido.Equals(rol, StringComparison.OrdinalIgnoreCase) Then Return True
        Next

        Return False

    End Function

    ' =========================================================
    ' CONSTRUCCIÓN DINÁMICA DEL ÁRBOL
    ' =========================================================
    Private Sub ConstruirArbol()

        Dim sinReportes As Boolean = False

        tvReportes.BeginUpdate()
        Try
            tvReportes.Nodes.Clear()

            Dim raiz As New TreeNode("Reportes")

            For Each categoria As String In Categorias

                Dim nodoCategoria As New TreeNode(categoria)

                For Each reporte As ReporteInfo In reportes
                    If reporte.Categoria = categoria AndAlso PuedeVer(reporte) Then
                        Dim nodo As New TreeNode(reporte.Codigo & " · " & reporte.Nombre)
                        nodo.Tag = reporte.Codigo
                        nodoCategoria.Nodes.Add(nodo)
                    End If
                Next

                If nodoCategoria.Nodes.Count > 0 Then
                    raiz.Nodes.Add(nodoCategoria)
                    nodoCategoria.Expand()
                End If

            Next

            If raiz.Nodes.Count = 0 Then
                sinReportes = True
            Else
                tvReportes.Nodes.Add(raiz)
                raiz.Expand()
            End If

        Finally
            tvReportes.EndUpdate()
        End Try

        If sinReportes Then
            MessageBox.Show("Su rol no tiene reportes habilitados en este módulo.",
                            "Centro de reportes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BeginInvoke(New Action(Sub() Close()))
        End If

    End Sub

    ' =========================================================
    ' SELECCIÓN EN EL ÁRBOL
    ' =========================================================
    Private Sub tvReportes_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvReportes.AfterSelect

        If e.Node Is Nothing OrElse e.Node.Tag Is Nothing Then
            MostrarBienvenida()
            Return
        End If

        MostrarReporte(e.Node.Tag.ToString())

    End Sub

    Private Sub MostrarBienvenida()

        lblTituloReporte.Text = "Centro de reportes"
        lblDescripcionReporte.Text = "Seleccione un reporte del árbol de la izquierda. " &
                                     "Los reportes disponibles dependen del rol con el que inició sesión."
        pnlR01.Visible = False
        pnlR02.Visible = False
        pnlR03.Visible = False
        lblEstadoCentro.Text = "Listo"

    End Sub

    Private Sub MostrarReporte(codigo As String)

        Dim reporte As ReporteInfo = reportes.FirstOrDefault(Function(r) r.Codigo = codigo)
        If reporte Is Nothing Then Return

        lblTituloReporte.Text = reporte.Codigo & " · " & reporte.Nombre
        lblDescripcionReporte.Text = reporte.Descripcion

        pnlR01.Visible = (codigo = "R01")
        pnlR02.Visible = (codigo = "R02")
        pnlR03.Visible = (codigo = "R03")

        Select Case codigo
            Case "R01"
                CargarPagos()
            Case "R02"
                CargarSocios()
            Case "R03"
                lblEstadoCentro.Text = "Defina los filtros en el listado de vencimientos."
        End Select

    End Sub

    ' =========================================================
    ' R01 - RECIBO DE PAGO
    ' =========================================================
    Private Sub CargarPagos()

        Try
            Dim tabla As DataTable = pagoDAO.ListarPagosRecientes(200)

            cboPagos.DataSource = Nothing
            cboPagos.DisplayMember = "Descripcion"
            cboPagos.ValueMember = "id_pago"
            cboPagos.DataSource = tabla

            If tabla.Rows.Count > 0 Then
                cboPagos.SelectedIndex = 0
                lblEstadoCentro.Text = tabla.Rows.Count.ToString() & " pago(s) reciente(s) disponible(s)."
            Else
                lblEstadoCentro.Text = "No hay pagos registrados."
            End If

            btnVistaPreviaRecibo.Enabled = tabla.Rows.Count > 0
            btnImprimirReciboCentro.Enabled = tabla.Rows.Count > 0

        Catch ex As Exception
            MostrarError("No se pudieron cargar los pagos.", ex)
        End Try

    End Sub

    Private Sub btnVistaPreviaRecibo_Click(sender As Object, e As EventArgs) Handles btnVistaPreviaRecibo.Click
        ImprimirRecibo(vistaPrevia:=True)
    End Sub

    Private Sub btnImprimirReciboCentro_Click(sender As Object, e As EventArgs) Handles btnImprimirReciboCentro.Click
        ImprimirRecibo(vistaPrevia:=False)
    End Sub

    Private Sub ImprimirRecibo(vistaPrevia As Boolean)

        Dim idPago As Integer? = ObtenerIdSeleccionado(cboPagos)

        If Not idPago.HasValue Then
            MostrarAviso("Seleccione un pago de la lista.")
            Return
        End If

        Try
            Dim datos As DataRow = pagoDAO.ObtenerPagoParaRecibo(idPago.Value)

            If datos Is Nothing Then
                MostrarAviso("No se encontró el pago seleccionado.")
                Return
            End If

            Using recibo As New ReciboPago(datos)
                recibo.Imprimir(vistaPrevia, Me)
            End Using

            lblEstadoCentro.Text = "Recibo " & idPago.Value.ToString("D6") & " generado."

        Catch ex As Exception
            MostrarError("No se pudo generar el recibo de pago.", ex)
        End Try

    End Sub

    ' =========================================================
    ' R02 - CONSTANCIA DE MEMBRESÍA
    ' =========================================================
    Private Sub CargarSocios()

        Try
            Dim tabla As DataTable = membresiaDAO.ListarSociosConMembresiaVigente()

            cboSocios.DataSource = Nothing
            cboSocios.DisplayMember = "Descripcion"
            cboSocios.ValueMember = "id_socio"
            cboSocios.DataSource = tabla

            If tabla.Rows.Count > 0 Then
                cboSocios.SelectedIndex = 0
                lblEstadoCentro.Text = tabla.Rows.Count.ToString() & " socio(s) con membresía vigente."
            Else
                lblEstadoCentro.Text = "No hay socios con membresía vigente."
            End If

            btnVistaPreviaConstancia.Enabled = tabla.Rows.Count > 0
            btnImprimirConstancia.Enabled = tabla.Rows.Count > 0

        Catch ex As Exception
            MostrarError("No se pudieron cargar los socios con membresía vigente.", ex)
        End Try

    End Sub

    Private Sub btnVistaPreviaConstancia_Click(sender As Object, e As EventArgs) Handles btnVistaPreviaConstancia.Click
        ImprimirConstancia(vistaPrevia:=True)
    End Sub

    Private Sub btnImprimirConstancia_Click(sender As Object, e As EventArgs) Handles btnImprimirConstancia.Click
        ImprimirConstancia(vistaPrevia:=False)
    End Sub

    Private Sub btnConfigurarPagina_Click(sender As Object, e As EventArgs) Handles btnConfigurarPagina.Click

        Try
            Using psdPagina As New PageSetupDialog()
                psdPagina.Document = constancia.Documento
                psdPagina.EnableMetric = True
                psdPagina.ShowDialog(Me)
            End Using
        Catch ex As Exception
            MostrarError("No se pudo abrir la configuración de página.", ex)
        End Try

    End Sub

    Private Sub ImprimirConstancia(vistaPrevia As Boolean)

        Dim idSocio As Integer? = ObtenerIdSeleccionado(cboSocios)

        If Not idSocio.HasValue Then
            MostrarAviso("Seleccione un socio de la lista.")
            Return
        End If

        Try
            Dim datos As DataRow = membresiaDAO.ObtenerConstanciaPorSocio(idSocio.Value)

            If datos Is Nothing Then
                MostrarAviso("El socio seleccionado no tiene una membresía activa y vigente.")
                Return
            End If

            constancia.Datos = datos
            constancia.Imprimir(vistaPrevia, Me)

            lblEstadoCentro.Text = "Constancia generada para " & datos("Socio").ToString() & "."

        Catch ex As Exception
            MostrarError("No se pudo generar la constancia de membresía.", ex)
        End Try

    End Sub

    ' =========================================================
    ' R03 - LISTADO DE VENCIMIENTOS
    ' =========================================================
    Private Sub btnAbrirListado_Click(sender As Object, e As EventArgs) Handles btnAbrirListado.Click

        Try
            Using formulario As New frmListadoVencimientos()
                formulario.ShowDialog(Me)
            End Using
        Catch ex As Exception
            MostrarError("No se pudo abrir el listado de vencimientos.", ex)
        End Try

    End Sub

    ' =========================================================
    ' UTILIDADES
    ' =========================================================
    Private Function ObtenerIdSeleccionado(combo As ComboBox) As Integer?

        If combo.SelectedValue Is Nothing Then Return Nothing
        If TypeOf combo.SelectedValue Is DataRowView Then Return Nothing

        Dim id As Integer
        If Integer.TryParse(combo.SelectedValue.ToString(), id) Then Return id

        Return Nothing

    End Function

    Private Shared Sub MostrarAviso(mensaje As String)
        MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Shared Sub MostrarError(mensaje As String, ex As Exception)
        MessageBox.Show(mensaje & Environment.NewLine & Environment.NewLine & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub

End Class
