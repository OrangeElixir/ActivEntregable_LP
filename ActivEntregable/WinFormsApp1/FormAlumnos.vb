Public Class FormAlumnos

    Private Sub Limpiar()
        txtBuscar.Text = ""
        txt_pNombre.Text = ""
        txt_Snombre.Text = ""
        txt_Papellido.Text = ""
        txt_Sapellido.Text = ""
        txt_Fnacim.Text = ""
        txt_telefono.Text = ""
        txt_celular.Text = ""
        txt_email.Text = ""
        txt_direccion.Text = ""
        txt_obser.Text = ""
    End Sub

    Private Sub Listar()
        Try
            Dim negocio As New CapaNegocio.NAlumnos
            dgvAlumnos.DataSource = negocio.Listar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Buscar()
        Try
            Dim negocio As New CapaNegocio.NAlumnos
            Dim valor = txtBuscar.Text
            dgvAlumnos.DataSource = negocio.Buscar(valor)
            Me.Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Insertar()
        Try
            If Me.ValidateChildren = True And txt_pNombre.Text <> "" And txt_Snombre.Text <> "" And
                txt_Papellido.Text <> "" And txt_Sapellido.Text <> "" And txt_Fnacim.Text <> "" And
                txt_telefono.Text <> "" And txt_celular.Text <> "" And txt_email.Text <> "" And
                txt_direccion.Text <> "" And txt_obser.Text <> "" Then
                Dim alumno As New CapaEntidades.Alumnos
                Dim negocio As New CapaNegocio.NAlumnos
                alumno.Primer_nombre = txt_pNombre.Text
                alumno.Segundo_nombre = txt_Snombre.Text
                alumno.Primer_apellido = txt_Papellido.Text
                alumno.Segundo_apellido = txt_Sapellido.Text
                alumno.Fecha_de_nacimiento = txt_Fnacim.Text
                alumno.Telefono = txt_telefono.Text
                alumno.Celular = txt_celular.Text
                alumno.Email = txt_email.Text
                alumno.Direccion = txt_direccion.Text
                alumno.Observaciones = txt_obser.Text
                If negocio.Insertar(alumno) Then
                    MsgBox("Registro insertado", vbOKOnly + vbInformation, "Registro exitoso")
                    Me.Listar()
                Else
                    MsgBox("Registro Erroneo", vbOKOnly + vbInformation, "Error en registrar")
                End If
            Else
                MsgBox("Rellene los espacios obligatorios", vbOKOnly + vbInformation, "Error de insercion")
            End If
            btn_modificar.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Formato()
        dgvAlumnos.Columns(0).Width = 75
        dgvAlumnos.Columns(1).Width = 180
        dgvAlumnos.Columns(2).Width = 69
        dgvAlumnos.Columns(3).Width = 69
        dgvAlumnos.Columns(4).Width = 140
        dgvAlumnos.Columns(5).Width = 140
        dgvAlumnos.Columns(7).Width = 180
        txt_obser.Height = 150

    End Sub

    Private Sub FormAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Listar()
        Me.Formato()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Me.Buscar()
        Me.Limpiar()
    End Sub

    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
        Me.Insertar()
        Me.Limpiar()
    End Sub
End Class
