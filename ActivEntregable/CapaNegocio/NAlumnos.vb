Imports CapaEntidades
Imports CapaDatos
Imports System.Data

Public Class NAlumnos
    Public Function Listar() As DataTable
        Try
            Dim datos As New DAlumnos
            Dim tabla As New DataTable
            tabla = datos.Listar()
            Return tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Buscar(valor As String) As DataTable
        Try
            Dim datos As New DAlumnos
            Dim tabla As New DataTable
            tabla = datos.Buscar(valor)
            Return tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Insertar(alumno As Alumnos) As Boolean
        Try
            Dim datos As New DAlumnos
            datos.Insertar(alumno)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

End Class
