using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace ST10438767_PROG6221_POE_Pt1
{
    public class ChatbotMethods
    {

        //this is the random fact method that generates a random fact from the array of facts.
        public static void RandomFact(SpeechSynthesizer synth, String input, string name)
        {
            Dictionary<int, string> facts = new Dictionary<int, string>
            {
                {1, "Healthcare IT News reports that up to 50% of medical devices have known vulnerabilities, posing a significant risk to patient safety!" },
                {2, "There is a new cyber attack every 39 seconds!" },
                {3, "85% of seemingly innocent online interactions—like sharing puppy photos—could involve scammers!" },
                {4, "Security Magazine estimates that 1 in every 50 smartphones will be infected with malware in the next few years!" },
                {5, "A whopping 65% of users admit to reusing passwords across accounts!" },
                {6, "58% of cyber attacks originate in Russia!" },
                {7, "Cybersecurity Ventures reports that by 2030, 90% of the global population will be online!" },
                {8, "Only 64% of companies have a budget dedicated to cybersecurity!" },
                {9, "The average ransom payment for ransomware attacks has reached $570,000 per incident!" },
                {10, "81% of data breaches involve weak or stolen credentials!" }
            };

            /*Geeks for Geeks, 2025. C# Dictionary
             [online] Available at: <https://www.geeksforgeeks.org/c-sharp-dictionary-with-examples/> [Accessed 23 May 2025].
           */


            /*
              digitaldefynd, 2025. 50 Surprising Cybersecurity Facts & Statistics
              [online] Available at: <https://www.phishing.org/10-ways-to-avoid-phishing-scams> [Accessed 16 April 2025].
            */


            Random random = new Random();
            List<int> keys = new List<int>(facts.Keys);
            int randomKey = keys[random.Next(keys.Count)];
            string randomFact = facts[randomKey];

            /*
              ByteHide, 2024. Choosing Random Elements in C#: Tutorial
              [online] Available at: <https://www.bytehide.com/blog/random-elements-csharp> [Accessed 16 April 2025].
            */

            Console.ForegroundColor = ConsoleColor.Yellow; //now this highly fancy bit of code is to change the color of the text without using thaat PrintWithColor method
            Console.WriteLine("==============================================================================================================");
            Console.ResetColor(); //this is to reset the color of the text to default
            PrintWithColor(synth, $"Here's a fun fact for you, {name}: {randomFact}", ConsoleColor.Yellow);
        }

        //and this one is for a bit infomation about safe browsing
        public static void SafeBrowsingAdvice(SpeechSynthesizer synth, string input, string name)
        {
            Dictionary<int, string> facts = new Dictionary<int, string>
            {
                { 1, "Always check the URL for 'https://' and look for a padlock icon before entering personal information." },
                { 2, "Update your web browser to stay up to date with both new features and security settings!" },
                { 3, "Use strict security and privacy settings to prevent sites from tracking you!" },
                { 4, "Be careful of what you download since many viruses hide in there!" },
                { 5, "Add an ad-blocker to enhance your browsing, and also to keep those pesky pop-up ads and their viruses away!" }
            };

            /*Geeks for Geeks, 2025. C# Dictionary
              [online] Available at: <https://www.geeksforgeeks.org/c-sharp-dictionary-with-examples/> [Accessed 23 May 2025].
            */

            /*
              SWISS CYBER INSTITUTE, 2025. How to Browse the Internet Safely: 10 Tips
              [online] Available at: <https://swisscyberinstitute.com/blog/10-tips-on-how-to-browse-the-internet-safely/#10_tips_on_how_to_browse_the_Internet_safely> [Accessed 18 April 2025].
            */

            
            Random random = new Random();
            List<int> keys = new List<int>(facts.Keys);
            int randomKey = keys[random.Next(keys.Count)];
            string randomFact = facts[randomKey];

            /*
              ByteHide, 2024. Choosing Random Elements in C#: Tutorial
              [online] Available at: <https://www.bytehide.com/blog/random-elements-csharp> [Accessed 16 April 2025].
            */

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("==============================================================================================================");
            Console.ResetColor();
            PrintWithColor(synth, $"Here is how to stay safe online: {randomFact}", ConsoleColor.Green);
        }


        //this little method is to print something simple about passwords
        public static void PasswordAdvice(SpeechSynthesizer synth, string input, string name)
        {
            Console.ForegroundColor = ConsoleColor.Cyan; //this is to change the color of the text
            Console.WriteLine("==============================================================================================================");
            Console.ResetColor();  //and here, the color is reset to the default color
            PrintWithColor(synth, "A strong password should be at least 12 characters long and include a mix of letters, numbers, and symbols!", ConsoleColor.Cyan);
        }

        public static void ChatAsk(SpeechSynthesizer synth, string input, string name)
        {
            Console.ForegroundColor = ConsoleColor.Magenta; //this is to change the color of the text
            Console.WriteLine("==============================================================================================================");
            Console.ResetColor();  //and here, the color is reset to the default color
            SimpleResponse(synth, input, name);

            PrintWithColor(synth, "Would you like to ask another question? (yes/no)", ConsoleColor.Green);
            string choice = Console.ReadLine()?.ToLower();

            if (choice == "no" || choice == "n") // in case the user forgot to type the "o" in no, we're adding a bit more snazz here
            {
                PrintWithColor(synth, "Thank you for using the Cybersecurity Chatbot! Stay safe online!", ConsoleColor.Red);
            }

            else
            {
                PrintWithColor(synth, "Invalid input. Please type 'yes' or 'no'.", ConsoleColor.Red);
                ChatAsk(synth, input, name); // this is a recursive call to ask again

            }
        }

        public static void SimpleResponse(SpeechSynthesizer synth, string input, string name)
        {
            // this nifty bit of code prevents blank inputs from being processed
            if (string.IsNullOrWhiteSpace(input))
                /*Toelsen, A and Japikse, P., 2022. Pro C# 10 with .NET 6 - Fundamental Principles and Practices in Programming. 11th Ed. West Chester: Apress*/
                return;

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


        // This method provides advice on how to avoid phishing scams and stay safe online
        public static void PhishingAdvice(SpeechSynthesizer synth, string input, string name)
        {
            Dictionary<int, string> facts = new Dictionary<int, string>
                {
                    { 1, "Stay up to date with the latest phishing techniques." },
                    { 2, "Think before you click on suspicious-looking websites or emails." },
                    { 3, "Use a firewall to help protect your system from attacks." },
                    { 4, "Be cautious of pop-up ads — many are malicious in disguise." },
                    { 5, "Always use reputable antivirus software." }
                };

            /*
              PHISHING.org, 2025. 10 Ways To Avoid Phishing Scams
              [online] Available at: <https://www.phishing.org/10-ways-to-avoid-phishing-scams> [Accessed 18 April 2025].
            */


            Random random = new Random();
            List<int> keys = new List<int>(facts.Keys);
            int randomKey = keys[random.Next(keys.Count)];
            string randomFact = facts[randomKey];

            /*
              ByteHide, 2024. Choosing Random Elements in C#: Tutorial
              [online] Available at: <https://www.bytehide.com/blog/random-elements-csharp> [Accessed 16 April 2025].
            */

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("==============================================================================================================");
            Console.ResetColor();
            PrintWithColor(synth, $"Here's how to avoid phishing, {name}: {randomFact}", ConsoleColor.Yellow);
        }


        //this method allows for the messages to be printed with various colors.
        static void PrintWithColor(SpeechSynthesizer synth, string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            synth.Speak(message);
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
            /*Toelsen, A and Japikse, P., 2022. Pro C# 10 with .NET 6 - Foundemental Principals and Practices in Programming. 11th Ed. West Chester: Apress*/
        }
    }
}
