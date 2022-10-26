Public Class Alumnos
    Private _id_alumno As Integer
    Private _primer_nombre As String
    Private _segundo_nombre As String
    Private _primer_apellido As String
    Private _segundo_apellido As String
    Private _telefono As String
    Private _celular As String
    Private _direccion As String
    Private _email As String
    Private _fecha_de_nacimiento As String
    Private _observaciones As String

    Public Property Id_alumno As Integer
        Get
            Return _id_alumno
        End Get
        Set(value As Integer)
            _id_alumno = value
        End Set
    End Property

    Public Property Primer_nombre As String
        Get
            Return _primer_nombre
        End Get
        Set(value As String)
            _primer_nombre = value
        End Set
    End Property

    Public Property Segundo_nombre As String
        Get
            Return _segundo_nombre
        End Get
        Set(value As String)
            _segundo_nombre = value
        End Set
    End Property

    Public Property Primer_apellido As String
        Get
            Return _primer_apellido
        End Get
        Set(value As String)
            _primer_apellido = value
        End Set
    End Property

    Public Property Segundo_apellido As String
        Get
            Return _segundo_apellido
        End Get
        Set(value As String)
            _segundo_apellido = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property

    Public Property Celular As String
        Get
            Return _celular
        End Get
        Set(value As String)
            _celular = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property Fecha_de_nacimiento As String
        Get
            Return _fecha_de_nacimiento
        End Get
        Set(value As String)
            _fecha_de_nacimiento = value
        End Set
    End Property

    Public Property Observaciones As String
        Get
            Return _observaciones
        End Get
        Set(value As String)
            _observaciones = value
        End Set
    End Property
End Class
