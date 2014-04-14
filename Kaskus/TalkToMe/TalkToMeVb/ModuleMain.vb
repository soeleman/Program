Imports System.Speech.Recognition

Module ModuleMain

    Friend Sub Main()
        Using speechRecognition = New SpeechRecognitionEngine()

            With speechRecognition
                .LoadGrammar(New DictationGrammar())
                .SetInputToDefaultAudioDevice()

                AddHandler .SpeechRecognized, _
                    Sub(s, e)
                        If e.Result IsNot Nothing AndAlso Not [String].IsNullOrEmpty(e.Result.Text) Then
                            Using New ConsoleForegroundColor(ConsoleColor.Green)
                                Console.WriteLine(e.Result.Text)
                            End Using

                            Return
                        End If

                        Using New ConsoleForegroundColor(ConsoleColor.Red)
                            Console.WriteLine("Recognized text not available.")
                        End Using
                    End Sub

                ' AddHandler .SpeechRecognized, AddressOf SpeechRecognizedHandler

                .RecognizeAsync(RecognizeMode.Multiple)
            End With

            Console.Title = "Talk to Me"
            Console.WriteLine("Press any key to exit.")
            Console.WriteLine("Waiting you voice . . .")

            While Not Console.KeyAvailable
                ' waiting for the key
            End While
        End Using
    End Sub

    Private Sub SpeechRecognizedHandler(sender As [Object], e As SpeechRecognizedEventArgs)
        If e.Result IsNot Nothing AndAlso Not [String].IsNullOrEmpty(e.Result.Text) Then
            Using New ConsoleForegroundColor(ConsoleColor.Green)
                Console.WriteLine(e.Result.Text)
            End Using

            Return
        End If

        Using New ConsoleForegroundColor(ConsoleColor.Red)
            Console.WriteLine("Recognized text not available.")
        End Using
    End Sub

End Module