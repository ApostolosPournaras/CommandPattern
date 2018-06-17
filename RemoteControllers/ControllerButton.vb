Public Class ControllerButton

    Private command As ICommand

    Sub New(command As ICommand)
        Me.command = command
    End Sub

    Sub press()
        Me.command.execute()
    End Sub

    Sub undo()
        Me.command.unExecute()
    End Sub

End Class
