Public Class RadioRemoteController

    Private turnOnCommand As ICommand
    Private turnOffCommand As ICommand
    Private volumeUpCommand As ICommand
    Private volumeDownCommand As ICommand
    Private channelUpCommand As ICommand
    Private channelDownCommand As ICommand
    Private setChannelCommand As ICommand

    Sub New(turnOn As ICommand, turnOff As ICommand, volumeUp As ICommand, volumeDown As ICommand, channelUp As ICommand, channelDown As ICommand)
        Me.turnOnCommand = turnOn
        Me.turnOffCommand = turnOff
        Me.volumeUpCommand = volumeUp
        Me.volumeDownCommand = volumeDown
        Me.channelUpCommand = channelUp
        Me.channelDownCommand = channelDown
    End Sub

    Sub RadioturnOn()
        Me.turnOnCommand.execute()
    End Sub

    Sub RadioTurnOff()
        Me.turnOffCommand.execute()
    End Sub

    Sub RadiovolumeUp()
        Me.volumeUpCommand.execute()
    End Sub

    Sub Radiovolumedown()
        Me.volumeDownCommand.execute()
    End Sub

    Sub RadiochannelUp()
        Me.channelUpCommand.execute()
    End Sub

    Sub RadiochannelDown()
        Me.channelDownCommand.execute()
    End Sub

End Class
