Public Class ChannelDownCommand
    Implements ICommand

    Private device As ElectronicDevice

    Sub New(device As ElectronicDevice)
        Me.device = device
    End Sub

    Sub execute() Implements ICommand.execute
        Me.device.channelDown()
    End Sub

    Sub unexecute() Implements ICommand.unExecute
        Me.device.channelUp()
    End Sub

End Class
