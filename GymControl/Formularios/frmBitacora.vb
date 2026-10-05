Public Class frmBitacora

    Private ReadOnly bitacoraDAO As New BitacoraDAO()


    ' =========================================================
    ' CARGA DEL FORMULARIO
    ' =========================================================
    Private Sub frmBitacora_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        ConfigurarFormulario()
        CargarBitacora()

    End Sub


    ' =========================================================
    ' CONFIGURACIÓN
    ' =========================================================
    Private Sub ConfigurarFormulario()

        ' -----------------------------------------------------
        ' COMBO RESULTADO
        ' -----------------------------------------------------
        cboResultado.DropDownStyle =
            ComboBoxStyle.DropDownList

        cboResultado.Items.Clear()

        cboResultado.Items.Add("Todos")
        cboResultado.Items.Add("EXITO")
        cboResultado.Items.Add("FALLIDO")
        cboResultado.Items.Add("BLOQUEADO")

        cboResultado.SelectedIndex = 0


        ' -----------------------------------------------------
        ' FECHAS
        ' -----------------------------------------------------
        dtpDesde.Format =
            DateTimePickerFormat.Custom

        dtpDesde.CustomFormat =
            "dd/MM/yyyy"

        dtpHasta.Format =
            DateTimePickerFormat.Custom

        dtpHasta.CustomFormat =
            "dd/MM/yyyy"


        ' Mostrar inicialmente los últimos 30 días.
        dtpDesde.Value =
            Date.Today.AddDays(-30)

        dtpHasta.Value =
            Date.Today


        ' -----------------------------------------------------
        ' DATAGRIDVIEW
        ' -----------------------------------------------------
        dgvBitacora.ReadOnly = True

        dgvBitacora.MultiSelect = False

        dgvBitacora.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect

        dgvBitacora.AllowUserToAddRows = False

        dgvBitacora.AllowUserToDeleteRows = False

        dgvBitacora.AllowUserToResizeRows = False

        dgvBitacora.RowHeadersVisible = False

        dgvBitacora.BackgroundColor =
            SystemColors.Window

        dgvBitacora.BorderStyle =
            BorderStyle.FixedSingle

        dgvBitacora.AutoSizeRowsMode =
            DataGridViewAutoSizeRowsMode.None

        dgvBitacora.ColumnHeadersHeightSizeMode =
            DataGridViewColumnHeadersHeightSizeMode.AutoSize

    End Sub


    ' =========================================================
    ' OBTENER RESULTADO DEL FILTRO
    ' =========================================================
    Private Function ObtenerResultadoFiltro() As String

        If cboResultado.SelectedIndex <= 0 Then
            Return ""
        End If

        Return cboResultado.Text

    End Function


    ' =========================================================
    ' CARGAR BITÁCORA
    ' =========================================================
    Private Sub CargarBitacora()

        If dtpDesde.Value.Date >
           dtpHasta.Value.Date Then

            MessageBox.Show(
                "La fecha inicial no puede ser mayor " &
                "que la fecha final.",
                "GymControl",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return

        End If


        Try

            Dim tabla As DataTable =
                bitacoraDAO.ListarBitacora(
                    txtBuscarUsuario.Text,
                    ObtenerResultadoFiltro(),
                    dtpDesde.Value.Date,
                    dtpHasta.Value.Date
                )


            dgvBitacora.DataSource =
                tabla


            ConfigurarColumnas()

            ActualizarResumen(tabla)


        Catch ex As Exception

            MessageBox.Show(
                "No se pudo cargar la bitácora de accesos." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "GymControl",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    ' =========================================================
    ' CONFIGURAR COLUMNAS
    ' =========================================================
    Private Sub ConfigurarColumnas()

        ' -----------------------------------------------------
        ' OCULTAR IDENTIFICADORES
        ' -----------------------------------------------------
        If dgvBitacora.Columns.Contains(
            "id_bitacora"
        ) Then

            dgvBitacora.Columns(
                "id_bitacora"
            ).Visible = False

        End If


        If dgvBitacora.Columns.Contains(
            "id_usuario"
        ) Then

            dgvBitacora.Columns(
                "id_usuario"
            ).Visible = False

        End If


        ' -----------------------------------------------------
        ' FECHA Y HORA
        ' -----------------------------------------------------
        If dgvBitacora.Columns.Contains(
            "FechaHora"
        ) Then

            dgvBitacora.Columns(
                "FechaHora"
            ).HeaderText = "Fecha y hora"

            dgvBitacora.Columns(
                "FechaHora"
            ).Width = 160

            dgvBitacora.Columns(
                "FechaHora"
            ).DefaultCellStyle.Format =
                "dd/MM/yyyy HH:mm:ss"

        End If


        ' -----------------------------------------------------
        ' USUARIO
        ' -----------------------------------------------------
        If dgvBitacora.Columns.Contains(
            "Usuario"
        ) Then

            dgvBitacora.Columns(
                "Usuario"
            ).HeaderText = "Usuario"

            dgvBitacora.Columns(
                "Usuario"
            ).AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill

            dgvBitacora.Columns(
                "Usuario"
            ).FillWeight = 30

        End If


        ' -----------------------------------------------------
        ' RESULTADO
        ' -----------------------------------------------------
        If dgvBitacora.Columns.Contains(
            "Resultado"
        ) Then

            dgvBitacora.Columns(
                "Resultado"
            ).HeaderText = "Resultado"

            dgvBitacora.Columns(
                "Resultado"
            ).Width = 130

        End If


        ' -----------------------------------------------------
        ' EQUIPO
        ' -----------------------------------------------------
        If dgvBitacora.Columns.Contains(
            "Equipo"
        ) Then

            dgvBitacora.Columns(
                "Equipo"
            ).HeaderText = "Equipo"

            dgvBitacora.Columns(
                "Equipo"
            ).AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill

            dgvBitacora.Columns(
                "Equipo"
            ).FillWeight = 45

        End If

    End Sub


    ' =========================================================
    ' ACTUALIZAR RESUMEN
    ' =========================================================
    Private Sub ActualizarResumen(
        tabla As DataTable
    )

        Dim total As Integer =
            tabla.Rows.Count

        Dim exitosos As Integer = 0
        Dim fallidos As Integer = 0
        Dim bloqueados As Integer = 0


        For Each fila As DataRow In tabla.Rows

            If IsDBNull(
                fila("Resultado")
            ) Then
                Continue For
            End If


            Dim resultado As String =
                Convert.ToString(
                    fila("Resultado")
                ).ToUpperInvariant()


            Select Case resultado

                Case "EXITO"
                    exitosos += 1

                Case "FALLIDO"
                    fallidos += 1

                Case "BLOQUEADO"
                    bloqueados += 1

            End Select

        Next


        lblTotal.Text =
            "Total: " & total.ToString()

        lblExitosos.Text =
            "Exitosos: " & exitosos.ToString()

        lblFallidos.Text =
            "Fallidos: " & fallidos.ToString()

        lblBloqueados.Text =
            "Bloqueados: " & bloqueados.ToString()

    End Sub


    ' =========================================================
    ' FILTRAR
    ' =========================================================
    Private Sub btnFiltrar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnFiltrar.Click

        CargarBitacora()

    End Sub


    ' =========================================================
    ' LIMPIAR FILTROS
    ' =========================================================
    Private Sub btnLimpiar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnLimpiar.Click

        txtBuscarUsuario.Clear()

        cboResultado.SelectedIndex = 0

        dtpDesde.Value =
            Date.Today.AddDays(-30)

        dtpHasta.Value =
            Date.Today

        CargarBitacora()

    End Sub


    ' =========================================================
    ' ACTUALIZAR
    ' =========================================================
    Private Sub btnActualizar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnActualizar.Click

        CargarBitacora()

    End Sub


    ' =========================================================
    ' ENTER EN EL BUSCADOR
    ' =========================================================
    Private Sub txtBuscarUsuario_KeyDown(
        sender As Object,
        e As KeyEventArgs
    ) Handles txtBuscarUsuario.KeyDown

        If e.KeyCode = Keys.Enter Then

            CargarBitacora()

            e.SuppressKeyPress = True

        End If

    End Sub

End Class