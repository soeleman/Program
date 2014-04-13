namespace Dede.App.TalkToMe
{
    using System;
    using System.Speech.Recognition;

    internal class Program
    {
        internal static void Main()
        {
            using (var sr = new SpeechRecognitionEngine())
            {
                sr.LoadGrammar(new DictationGrammar());
                sr.SetInputToDefaultAudioDevice();

                sr.SpeechRecognized += (s, e) =>
                {
                    if (e.Result != null &&
                        !String.IsNullOrEmpty(e.Result.Text))
                    {
                        using (new ConsoleForegroundColor(ConsoleColor.Green))
                        {
                            Console.WriteLine(e.Result.Text);
                        }

                        return;
                    }

                    using (new ConsoleForegroundColor(ConsoleColor.Red))
                    {
                        Console.WriteLine("Recognized text not available.");
                    }
                };

                //sr.SpeechRecognized += SpeechRecognizedHandler;

                sr.RecognizeAsync(RecognizeMode.Multiple);

                Console.Title = @"Talk to Me";
                Console.WriteLine("Press any key to exit.");
                Console.WriteLine("Waiting you voice . . .");

                while (!Console.KeyAvailable)
                {
                    // waiting for the key
                }
            }
        }

        private static void SpeechRecognizedHandler(
            Object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result != null &&
                !String.IsNullOrEmpty(e.Result.Text))
            {
                using (new ConsoleForegroundColor(ConsoleColor.Green))
                {
                    Console.WriteLine(e.Result.Text);
                }

                return;
            }

            using (new ConsoleForegroundColor(ConsoleColor.Red))
            {
                Console.WriteLine("Recognized text not available.");
            }
        }
    }
}