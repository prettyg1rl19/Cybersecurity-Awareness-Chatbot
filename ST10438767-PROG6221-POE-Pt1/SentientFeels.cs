using System;
using System.Linq;
using System.Speech.Synthesis;

namespace ST10438767_PROG6221_POE_Pt1
{
    class SentientFeels
    {
        private static readonly string[] goodEmotions = { "good", "well", "great", "happy", "amazing", "better" };
        private static readonly string[] badEmotions = { "sad", "scared", "nervous", "upset", "horrified" };

        public static void SentientFeelsCheck(string userFeels, string name, SpeechSynthesizer synth)
        {
            if (goodEmotions.Any(emotion => userFeels.Contains(emotion)))
            {
                PrintWithColor(synth, $"That's good to hear, {name}!", ConsoleColor.Yellow);
                PrintWithColor(synth, $"Now, how can I assist you today?", ConsoleColor.Magenta);
            }
            else if (badEmotions.Any(emotion => userFeels.Contains(emotion)))
            {
                PrintWithColor(synth, $"Oh no, {name}! What has you so upset?", ConsoleColor.Blue);
                Console.Write("You: ");
                string userBad = Console.ReadLine()?.ToLower();

                if (string.IsNullOrWhiteSpace(userBad)) return;

                if (userBad.Contains("password"))
                {
                    ChatbotMethods.PasswordAdvice(synth, userBad, name);
                }
                else if (userBad.Contains("phishing"))
                {
                    ChatbotMethods.PhishingAdvice(synth, userBad, name);
                }
                else if (userBad.Contains("safe browsing"))
                {
                    ChatbotMethods.SafeBrowsingAdvice(synth, userBad, name);
                }

                Console.WriteLine("==============================================================================================================");
                Console.Write("Feeling better? ");
                string feelingResponse = Console.ReadLine()?.ToLower();

                if (!string.IsNullOrWhiteSpace(feelingResponse) && feelingResponse.Contains("better"))
                {
                    PrintWithColor(synth, $"That's what I'm here for, {name}!", ConsoleColor.Yellow);
                    PrintWithColor(synth, $"Now, how can I assist you today?", ConsoleColor.Magenta);
                }
            }
        }

        private static void PrintWithColor(SpeechSynthesizer synth, string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            synth.Speak(message);
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
