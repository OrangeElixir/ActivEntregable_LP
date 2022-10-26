Imports CapaEntidades
Imports CapaEntidades.Alumnos
Imports System.Data
Imports System.Data.SqlClient
Public Class DAlumnos
    Inherits Conexion

    Public Function Listar() As DataTable
        Try
            Dim resultado As SqlDataReader
            Dim tabla As New DataTable
            Dim comando As New SqlCommand("alumnos_listar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            MyBase.conn.Open()
            resultado = comando.ExecuteReader()
            tabla.Load(resultado)
            MyBase.conn.Close()
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Buscar(valor As String) As DataTable
        Try
            Dim resultado As SqlDataReader
            Dim tabla As New DataTable
            Dim comando As New SqlCommand("alumnos_buscar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor
            MyBase.conn.Open()
            resultado = comando.ExecuteReader()
            tabla.Load(resultado)
            MyBase.conn.Close()
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Insertar(alumno As Alumnos)
        Try
            Dim comando As New SqlCommand("alumnos_insertar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@primer_nombre", SqlDbType.VarChar).Value = alumno.Primer_nombre
            comando.Parameters.Add("@segundo_nombre", SqlDbType.VarChar).Value = alumno.Segundo_nombre
            comando.Parameters.Add("@primer_apellido", SqlDbType.VarChar).Value = alumno.Primer_apellido
            comando.Parameters.Add("@segundo_apellido", SqlDbType.VarChar).Value = alumno.Segundo_apellido
            comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = alumno.Telefono
            comando.Parameters.Add("@celular", SqlDbType.VarChar).Value = alumno.Celular
            comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = alumno.Direccion
            comando.Parameters.Add("@email", SqlDbType.VarChar).Value = alumno.Email
            comando.Parameters.Add("@fecha_de_nacimiento", SqlDbType.Date).Value = alumno.Fecha_de_nacimiento
            comando.Parameters.Add("@observaciones", SqlDbType.VarChar).Value = alumno.Observaciones
            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Modificar(alumno As Alumnos)
        Try
            Dim comando As New SqlCommand("alumnos_modificar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@primer_nombre", SqlDbType.VarChar).Value = alumno.Primer_nombre
            comando.Parameters.Add("@segundo_nombre", SqlDbType.VarChar).Value = alumno.Segundo_nombre
            comando.Parameters.Add("@primer_apellido", SqlDbType.VarChar).Value = alumno.Primer_apellido
            comando.Parameters.Add("@segundo_apellido", SqlDbType.VarChar).Value = alumno.Segundo_apellido
            comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = alumno.Telefono
            comando.Parameters.Add("@celular", SqlDbType.VarChar).Value = alumno.Celular
            comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = alumno.Direccion
            comando.Parameters.Add("@email", SqlDbType.VarChar).Value = alumno.Email
            comando.Parameters.Add("@fecha_de_nacimiento", SqlDbType.Date).Value = alumno.Fecha_de_nacimiento
            comando.Parameters.Add("@observaciones", SqlDbType.VarChar).Value = alumno.Observaciones
            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Eliminar(id As Integer)
        Try
            Dim comando As New SqlCommand("alumnos_eliminar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@id_alumno", SqlDbType.Int).Value = id
            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
