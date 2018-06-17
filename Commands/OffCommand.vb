Public Class OffCommand
    Implements ICommand

    Private device As ElectronicDevice

    Sub New(device As ElectronicDevice)
        Me.device = device
    End Sub

    Sub execute() Implements ICommand.execute
        Me.device.turnOff()
    End Sub

    Sub unexecute() Implements ICommand.unExecute
        Me.device.turnOn()
    End Sub

End Class
