namespace Dede.App.TalkToMe
{
    using System;
    using System.Speech.Recognition;
    using System.Speech.Synthesis;

    internal class Program
    {
        internal static void Main()
        {
            Console.Title = @"Talk to Me";
            Console.WriteLine("Press any key to exit.");

            using (var sre = GetSpeechRecognitionEngine())
            {
                SayIt(@"Waiting you voice . . .");

                sre.RecognizeAsync(RecognizeMode.Multiple);
               
                while (!Console.KeyAvailable)
                {
                    // waiting for the key
                }
            }
        }

        private static SpeechRecognitionEngine GetSpeechRecognitionEngine()
        {
            var sre = new SpeechRecognitionEngine();

            sre.LoadGrammar(new DictationGrammar());
            sre.SetInputToDefaultAudioDevice();

            sre.SpeechRecognized += (s, e) =>
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

            return sre;
        }

        private static void SayIt(
            String toSaid)
        {
            using (var synthesizer = new SpeechSynthesizer())
            {
                using (new ConsoleForegroundColor(ConsoleColor.Blue))
                {
                    Console.WriteLine(toSaid);
                }

                synthesizer.Speak(toSaid);
            }
        }

        private static void SpeechRecognizedHandler(
            Object sender, 
            RecognitionEventArgs e)
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