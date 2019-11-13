Public Class Contato

    Private id_ As Integer
    Private nome_ As String
    Private cnpj_ As String
    Private fone1_ As String
    Private fone2_ As String
    Private cargo_ As String
    Private email_ As String
    Private obs_ As String

    Public Property Nome As String
        Get
            Return nome_
        End Get
        Set(value As String)
            nome_ = value
        End Set
    End Property

    Public Property Cnpj As String
        Get
            Return cnpj_
        End Get
        Set(value As String)
            cnpj_ = value
        End Set
    End Property

    Public Property Fone1 As String
        Get
            Return fone1_
        End Get
        Set(value As String)
            fone1_ = value
        End Set
    End Property

    Public Property Fone2 As String
        Get
            Return fone2_
        End Get
        Set(value As String)
            fone2_ = value
        End Set
    End Property

    Public Property Cargo As String
        Get
            Return cargo_
        End Get
        Set(value As String)
            cargo_ = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return email_
        End Get
        Set(value As String)
            email_ = value
        End Set
    End Property

    Public Property Obs As String
        Get
            Return obs_
        End Get
        Set(value As String)
            obs_ = value
        End Set
    End Property

    Public Property Id As Integer
        Get
            Return id_
        End Get
        Set(value As Integer)
            id_ = value
        End Set
    End Property

    Public Sub New(id_ As Integer, nome_ As String, cnpj_ As String, fone1_ As String, fone2_ As String, cargo_ As String, email_ As String, obs_ As String)
        Id = id_
        Nome = nome_
        Cnpj = cnpj_
        Fone1 = fone1_
        Fone2 = fone2_
        Cargo = cargo_
        Email = email_
        Obs = obs_
    End Sub
    Public Sub New()

    End Sub
End Class
