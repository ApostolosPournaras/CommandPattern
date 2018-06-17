Module Module1

    Sub Main()

        Dim TV As New Television()
        Dim Radio As New Radio()

        Dim TVRemote As New TVRemoteController(New OnCommand(TV), New OffCommand(TV),
                                               New VolumeUpCommand(TV), New VolumeDownCommand(TV),
                                               New ChannelUpCommand(TV), New ChannelDownCommand(TV))

        Dim RadioRemote As New RadioRemoteController(New OnCommand(Radio), New OffCommand(Radio),
                                               New VolumeUpCommand(Radio), New VolumeDownCommand(Radio),
                                               New ChannelUpCommand(Radio), New ChannelDownCommand(Radio))

        TVRemote.TVchannelUp()
        TVRemote.TVturnOn()
        TVRemote.TVturnOn()
        TVRemote.TVvolumeUp()
        TVRemote.TVvolumeUp()
        TVRemote.TVvolumedown()
        TVRemote.TVchannelUp()
        TVRemote.TVchannelUp()
        TVRemote.TVchannelUp()
        TVRemote.TVchannelUp()
        TVRemote.TVchannelUp()
        TVRemote.TVchannelDown()
        TVRemote.TVchannelDown()
        TVRemote.TVchannelDown()
        TVRemote.TVchannelDown()
        TVRemote.TvTurnOff()
        TVRemote.TvTurnOff()

        Console.WriteLine("-----------------")

        RadioRemote.RadioturnOn()

        For i = 0 To 13
            RadioRemote.RadiochannelUp()
        Next

        Do Until (Console.ReadKey.Key = ConsoleKey.Escape)
            System.Threading.Thread.Sleep(1000)
        Loop

    End Sub

End Module
