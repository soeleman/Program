Imports System.Speech.Recognition
Imports System.Speech.Synthesis

Module ModuleMain

    Friend Sub Main()

        Console.Title = "Talk to Me"
        Console.WriteLine("Press any key to exit.")

        Using speechRecognition = GetSpeechRecognitionEngine()
            SayIt("Waiting you voice . . .")
            speechRecognition.RecognizeAsync(RecognizeMode.Multiple)

            While Not Console.KeyAvailable
                ' waiting for the key
            End While
        End Using
    End Sub

    Private Function GetSpeechRecognitionEngine() As SpeechRecognitionEngine

        Dim sre = New SpeechRecognitionEngine()

        With sre
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
        End With

        Return sre
    End Function

    Private Sub SayIt(toSaid As [String])
        Using synthesizer = New SpeechSynthesizer()
            Using New ConsoleForegroundColor(ConsoleColor.Blue)
                Console.WriteLine(toSaid)
            End Using

            synthesizer.Speak(toSaid)
        End Using
    End Sub

    Private Sub SpeechRecognizedHandler(sender As [Object], e As RecognitionEventArgs)
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