﻿Public Class TVRemoteController

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

    Sub TVturnOn()
        Me.turnOnCommand.execute()
    End Sub

    Sub TvTurnOff()
        Me.turnOffCommand.execute()
    End Sub

    Sub TVvolumeUp()
        Me.volumeUpCommand.execute()
    End Sub

    Sub TVvolumedown()
        Me.volumeDownCommand.execute()
    End Sub

    Sub TVchannelUp()
        Me.channelUpCommand.execute()
    End Sub

    Sub TVchannelDown()
        Me.channelDownCommand.execute()
    End Sub

End Class
