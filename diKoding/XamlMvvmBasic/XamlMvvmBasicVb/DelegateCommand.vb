Imports System.Windows.Input

Public Class DelegateCommand
    Implements ICommand
    Private ReadOnly _execute As Action

    Private ReadOnly _canExecute As Func(Of [Boolean])

    Public Sub New(execute As Action)
        Me.New(execute, Function() True)
    End Sub

    Public Sub New(execute As Action, canExecute As Func(Of [Boolean]))
        If execute Is Nothing Then
            Throw New ArgumentNullException("execute")
        End If

        _execute = execute
        _canExecute = canExecute
    End Sub

    Public Event CanExecuteChanged As EventHandler Implements ICommand.CanExecuteChanged

    Public Sub Execute(p As [Object]) Implements ICommand.Execute
        If CanExecute(Nothing) Then
            _execute()
        End If
    End Sub

    Public Function CanExecute(p As [Object]) As [Boolean] Implements ICommand.CanExecute
        Return _canExecute Is Nothing OrElse _canExecute()
    End Function

    Public Sub RaiseCanExecuteChanged()
        RaiseEvent CanExecuteChanged(Me, EventArgs.Empty)
    End Sub
End Class
