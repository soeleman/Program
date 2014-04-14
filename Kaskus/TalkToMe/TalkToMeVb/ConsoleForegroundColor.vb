Friend NotInheritable Class ConsoleForegroundColor
    Implements IDisposable
    Public Sub New(color As ConsoleColor)
        Console.ForegroundColor = color
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        Console.ForegroundColor = ConsoleColor.White
    End Sub
End Class
