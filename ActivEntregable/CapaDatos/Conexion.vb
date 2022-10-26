Imports System.Data.SqlClient
Public Class Conexion
    Private _servidor As String
    Private _baseDatos As String
    Private _usuario As String
    Private _clave As String
    Private _seguridad As Boolean = True
    Public conn As SqlConnection

    Public Property Servidor As String
        Get
            Return _servidor
        End Get
        Set(value As String)
            _servidor = value
        End Set
    End Property

    Public Property BaseDatos As String
        Get
            Return _baseDatos
        End Get
        Set(value As String)
            _baseDatos = value
        End Set
    End Property

    Public Property Usuario As String
        Get
            Return _usuario
        End Get
        Set(value As String)
            _usuario = value
        End Set
    End Property

    Public Property Clave As String
        Get
            Return _clave
        End Get
        Set(value As String)
            _clave = value
        End Set
    End Property

    Public Property Seguridad As Boolean
        Get
            Return _seguridad
        End Get
        Set(value As Boolean)
            _seguridad = value
        End Set
    End Property

    Public Sub New()
        Me.Servidor = "MARCOAURELIO"
        Me.BaseDatos = "db_lp_activEntregable"
        Me.Usuario = ""
        Me.Clave = ""
        Me.conn = New SqlConnection(crearCadena)
    End Sub

    Public Function crearCadena() As String
        Dim cadena As String
        cadena = "Server=" & Me.Servidor & "; Database=" & Me.BaseDatos & ";"
        If Me.Servidor Then
            cadena = cadena & "Integrated Security=SSPI"
        Else
            cadena = cadena & "User id=" & Me.Usuario & "; Password=" & Me.Clave & ";"
        End If
        Return cadena
    End Function


End Class
