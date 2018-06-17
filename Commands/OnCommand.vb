Public Class OnCommand
    Implements ICommand

    Private device As ElectronicDevice

    Sub New(device As ElectronicDevice)
        Me.device = device
    End Sub

    Sub execute() Implements ICommand.execute
        Me.device.turnOn()
    End Sub

    Sub unexecute() Implements ICommand.unExecute
        Me.device.turnOff()
    End Sub

End Class
