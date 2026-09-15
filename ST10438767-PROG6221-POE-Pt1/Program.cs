using System;
using System.Speech.Synthesis;
using System.Media;

namespace ST10438767_PROG6221_POE_Pt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SelectVoiceByHints(VoiceGender.Male);

            if (OperatingSystem.IsWindows())
            {
                SoundPlayer heinzdoofenshmirtz = new SoundPlayer("heinzdoofenshmirtz.wav");
                heinzdoofenshmirtz.Load();
                heinzdoofenshmirtz.PlaySync();
            }

            Console.WriteLine("               (                                            )           ");
            Console.WriteLine("               )\\ )                )                 (   ( /(           ");
            Console.WriteLine("              (()/(   (         ( /( (            (  )\\  )\\())          ");
            Console.WriteLine("               /(_)) ))\\  (     )\\()))\\   (      ))\\((_)((_)\\           ");
            Console.WriteLine("              (_))  /((_) )\\ ) (_))/((_)  )\\ )  /((_)_  __((_)          ");
            Console.WriteLine("              / __|(_))  _(_/( | |_  (_) _(_/( (_)) | | \\ \\/ /          ");
            Console.WriteLine("              \\__ \\/ -_)| ' \\))|  _| | || ' \\))/ -_)| |  >  <           ");
            Console.WriteLine("              |___/\\___||_||_|  \\__| |_||_||_| \\___||_| /_/\\_\\          ");
            Console.WriteLine(" .--.      .-'.      .--.      .--.      .--.      .--.      .`-.      .--.");
            Console.WriteLine(":::::.\\::::::::.\\::::::::.\\::::::::.\\::::::::.\\::::::::.\\::::::::.\\::::::::.\\");
            Console.WriteLine("'      `--'      `.-'      `--'      `--'      `--'      `-.'      `-.'      ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------------------------------------------------------");
            PrintWithColor(synth, "Welcome to the Cyber Security Awareness chat bot - SentinelX!", ConsoleColor.Green);
            Console.WriteLine("------------------------------------------------------------------------");
            Console.ResetColor();

            PrintWithColor(synth, "Please enter your name for a personalized experience :)", ConsoleColor.Cyan);
            string name = Console.ReadLine();

            PrintWithColor(synth, $"Hello, {name}! What is your favourite topic?", ConsoleColor.Cyan);
            string userFavTop = Console.ReadLine();

            bool inSimpleResponseMode = false;

            while (true)
            {
                if (!inSimpleResponseMode)
                {
                    PrintWithColor(synth, $"Hello, {name}, how are you feeling today?", ConsoleColor.Magenta);
                    Console.Write(">> ");
                    string userFeels = Console.ReadLine().ToLower();
                    SentientFeels.SentientFeelsCheck(userFeels, name, synth);
                }

                Console.Write(">> ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input)) continue;

                string lowerInput = input.ToLower();

                if (lowerInput.Contains("exit") || lowerInput.Contains("bye") || lowerInput.Contains("goodbye"))
                {
                    PrintWithColor(synth, $"Goodbye, {name}! Stay safe online :)", ConsoleColor.Magenta);
                    break;
                }
                else if (input.Contains("let me ask you something"))
                {
                    PrintWithColor(synth, "Sure, go ahead! Ask me something like 'how are you', or 'what's your purpose'.", ConsoleColor.Magenta);
                    inSimpleResponseMode = true;
                }
                else if (input.Contains("password"))
                {
                    if (userFavTop.Contains("password"))
                    {
                        PrintWithColor(synth, "As someone who is interested in passwords, here are a few interesting tips about password safety:", ConsoleColor.Magenta);
                        ChatbotMethods.PasswordAdvice(synth, input, name);
                    }
                    else
                    {
                        ChatbotMethods.PasswordAdvice(synth, input, name);
                    }
                }
                else if (input.Contains("interesing"))
                {
                    ChatbotMethods.RandomFact(synth, input, name);
                }
                else if (input.Contains("phishing"))
                {
                    if (userFavTop.Contains("phishing"))
                    {
                        PrintWithColor(synth, "As someone who is interested in phishing, here are a few interesting facts about phishing:", ConsoleColor.Magenta);
                        ChatbotMethods.PhishingAdvice(synth, input, name);
                    }
                    else
                    {
                        ChatbotMethods.PhishingAdvice(synth, input, name);
                    }
                }
                else if (input.Contains("safe browsing"))
                {
                    if (userFavTop.Contains("safe browsing"))
                    {
                        PrintWithColor(synth, "As someone who is interested in browsing safely, here are a few ways to stay safe online:", ConsoleColor.Magenta);
                        ChatbotMethods.SafeBrowsingAdvice(synth, input, name);
                    }
                    else
                    {
                        ChatbotMethods.SafeBrowsingAdvice(synth, input, name);
                    }

                }
                else if (inSimpleResponseMode)
                {
                    SimpleResponse(synth, input, name);
                    PrintWithColor(synth, "Would you like to ask another question? (yes/no)", ConsoleColor.Green);
                    string choice = Console.ReadLine()?.ToLower();

                    if (choice == "no" || choice == "n")
                    {
                        inSimpleResponseMode = false;
                    }
                    else
                    {
                        PrintWithColor(synth, "Go ahead, ask away!", ConsoleColor.Magenta);
                    }
                }
                else if (lowerInput.Contains("tell me something interesting"))
                {
                    ChatbotMethods.RandomFact(synth, input, name);
                }
                else
                {
                    PrintWithColor(synth, "Sorry, I didn't understand that :/ Try again using simpler words?", ConsoleColor.Red);
                }
            }
        }

        public static void SimpleResponse(SpeechSynthesizer synth, string input, string name)
        {
            if (string.IsNullOrWhiteSpace(input)) return;

            string lowerInput = input.ToLower();

            if (lowerInput.Contains("how are you"))
            {
                PrintWithColor(synth, $"I'm doing as well as any created chatbot can do. Thanks for asking, {name}!", ConsoleColor.Yellow);
            }
            else if (lowerInput.Contains("what's your purpose"))
            {
                PrintWithColor(synth, "I am here to tell you all you need to know about Cyber Security!", ConsoleColor.Magenta);
            }
            else if (lowerInput.Contains("what can i ask you about"))
            {
                PrintWithColor(synth, "Well, anything cyber security related!", ConsoleColor.Gray);
            }
            else
            {
                PrintWithColor(synth, $"I didn't quite catch that, {name} :/. Try rephrasing, using smaller words this time?", ConsoleColor.Red);
            }
        }

        static void PrintWithColor(SpeechSynthesizer synth, string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            synth.Speak(message);
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
/*
REFERENCING LIST:

ByteHide, 2024. Choosing Random Elements in C#: Tutorial [online] 
Available at: <https://www.bytehide.com/blog/random-elements-csharp> [Accessed 16 April 2025].

digitaldefynd, 2025. 50 Surprising Cybersecurity Facts & Statistics [online] 
Available at: <https://www.phishing.org/10-ways-to-avoid-phishing-scams> [Accessed 16 April 2025].

Microsoft, 2025. bool (C# reference) [online] 
Available at: <https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool> [Accessed 17 April 2025].

Microsoft, 2024. Methods (C# Programming Guide).[online] 
Available at: <https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods> [Accessed 21 April 2025]. 

OpenAI. 2025. Chat-GPT (OpenAI's GPT-4-turbo model). [Large language model]. 
Available at: https://chatgpt.com/share/6834a82a-a24c-800c-bde6-abdbf651b899 (Current ChatGPT chat) [Accessed: 10 May 2025]

PHISHING.org, 2025. 10 Ways To Avoid Phishing Scams [online] 
Available at: <https://www.phishing.org/10-ways-to-avoid-phishing-scams> [Accessed 18 April 2025].

SWISS CYBER INSTITUTE, 2025. How to Browse the Internet Safely: 10 Tips [online] 
Available at: <https://swisscyberinstitute.com/blog/10-tips-on-how-to-browse-the-internet-safely/#10_tips_on_how_to_browse_the_Internet_safely> [Accessed 18 April 2025].

Toelsen, A and Japikse, P., 2022. Pro C# 10 with .NET 6 - Foundemental Principals and Practices in Programming. 11th Ed. West Chester: Apress             
*/