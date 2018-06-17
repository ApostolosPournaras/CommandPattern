Public MustInherit Class ElectronicDevice

    Protected isOnValue As Boolean
    Public ReadOnly Property isOn() As Boolean
        Get
            Return isOnValue
        End Get
    End Property

    Protected volumeLevelValue As Integer
    Public ReadOnly Property volumeLevel() As Integer
        Get
            Return volumeLevelValue
        End Get
    End Property

    Protected channelValue As Integer
    Public ReadOnly Property channel() As Integer
        Get
            Return channelValue
        End Get
    End Property

    MustOverride Sub turnOn()
    MustOverride Sub turnOff()
    MustOverride Sub volumeUp()
    MustOverride Sub volumeDown()
    MustOverride Sub channelUp()
    MustOverride Sub channelDown()

End Class
