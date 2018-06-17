Public Class VolumeDownCommand
    Implements ICommand

    Private device As ElectronicDevice

    Sub New(device As ElectronicDevice)
        Me.device = device
    End Sub

    Sub execute() Implements ICommand.execute
        Me.device.volumeDown()
    End Sub

    Sub unexecute() Implements ICommand.unExecute
        Me.device.volumeUp()
    End Sub

End Class
