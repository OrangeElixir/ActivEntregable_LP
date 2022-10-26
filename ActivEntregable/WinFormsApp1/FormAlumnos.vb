Public Class FormAlumnos

    Private Sub Listar()
        Try
            Dim negocio As New CapaNegocio.NAlumnos
            dgvAlumnos.DataSource = negocio.Listar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Formato()
        dgvAlumnos.Columns(0).Width = 180
        dgvAlumnos.Columns(3).Width = 140
        dgvAlumnos.Columns(4).Width = 140
    End Sub

    Private Sub FormAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Listar()
        Me.Formato()
    End Sub


End Class
