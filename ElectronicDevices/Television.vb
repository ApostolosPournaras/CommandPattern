Public Class Television
    Inherits ElectronicDevice

    Private maxVolume As Integer = 100
    Private maxChannel As Integer = 10

    Public Overrides Sub channelDown()
        If Me.isOnValue Then
            Me.channelValue -= 1
            Console.WriteLine("TV displaying channel:" & Me.channel)
        Else
            Console.WriteLine("canot channelDown when TV is turned off!")
        End If
    End Sub

    Public Overrides Sub channelUp()
        If Me.isOnValue Then

            If Me.channel + 1 > maxChannel Then
                Me.channelValue = 0
            Else
                Me.channelValue += 1
            End If
            Console.WriteLine("TV displaying channel:" & Me.channel)
        Else
            Console.WriteLine("canot channelUp when TV is turned off!")
        End If
    End Sub

    Public Overrides Sub turnOff()
        If Not Me.isOnValue Then
            Console.WriteLine("TV already turned off!")
        Else
            Me.isOnValue = True
            Console.WriteLine("TV turned off")
        End If
        Me.isOnValue = False
    End Sub

    Public Overrides Sub turnOn()
        If Me.isOnValue Then
            Console.WriteLine("TV already turned on!")
        Else
            Me.isOnValue = True
            Console.WriteLine("TV turned on")
        End If
    End Sub

    Public Overrides Sub volumeDown()
        If Me.isOnValue Then
            Me.volumeLevelValue -= 1
            If Me.volumeLevel < 0 Then
                Me.volumeLevelValue = 0
            End If
            Console.WriteLine("TV volume at level:" & Me.volumeLevel)
        Else
            Console.WriteLine("canot volumeDown when TV is turned off!")
        End If
    End Sub

    Public Overrides Sub volumeUp()
        If Me.isOnValue Then

            If Me.volumeLevel + 1 > maxVolume Then
                Me.volumeLevelValue = maxVolume
            Else
                Me.volumeLevelValue += 1
            End If
            Console.WriteLine("TV volume at level:" & Me.volumeLevel)
        Else
            Console.WriteLine("canot volumeUp when TV is turned off!")
        End If
    End Sub
End Class
