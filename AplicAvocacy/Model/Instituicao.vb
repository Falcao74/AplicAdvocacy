Public Class Instituicao
    Private id_ As Integer
    Private nome_ As String
    Private email_ As String
    Private site_ As String
    Private fone1_ As String
    Private fone2_ As String
    Private esfera_ As Char
    Private idMunicipio_ As String
    Private obs_ As String

    Public Property Id As Integer
        Get
            Return id_
        End Get
        Set(value As Integer)
            id_ = value
        End Set
    End Property

    Public Property Nome As String
        Get
            Return nome_
        End Get
        Set(value As String)
            nome_ = value
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

    Public Property Site As String
        Get
            Return site_
        End Get
        Set(value As String)
            site_ = value
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

    Public Property Esfera As Char
        Get
            Return esfera_
        End Get
        Set(value As Char)
            esfera_ = value
        End Set
    End Property

    Public Property IdMunicipio As String
        Get
            Return idMunicipio_
        End Get
        Set(value As String)
            idMunicipio_ = value
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

    Public Sub New(id_ As Integer, nome_ As String, email_ As String, site_ As String, fone1_ As String, fone2_ As String, esfera_ As Char, idMunicipio_ As String, obs_ As String)
        Id = id_
        Nome = nome_
        Email = email_
        Site = site_
        Fone1 = fone1_
        Fone2 = fone2_
        Esfera = esfera_
        IdMunicipio = idMunicipio_
        Obs = obs_
    End Sub

    Private Sub New()

    End Sub
End Class
