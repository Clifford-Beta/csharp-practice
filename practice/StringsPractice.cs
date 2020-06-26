using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "     Hello World!         ";
            Console.WriteLine($"[{greeting}]");
            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");
            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");
            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");

            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);
            Console.WriteLine(sayHello.ToLower());
            Console.WriteLine(sayHello.ToUpper());

            string songLyrics = "You say goodbye, and I say hello.";
            string goodBye = "goodbye";
            string greetings = "greetings";
            if (songLyrics.Contains(goodBye))
            {
                Console.WriteLine($"Song lyrics contains {goodBye}");
            }

            if (songLyrics.Contains(greetings))
            {
                Console.WriteLine($"Song lyrics contains {greetings}");
            }

            if (songLyrics.StartsWith("You"))
            {
                Console.WriteLine("You are the subject of this song");
            }

            if (songLyrics.EndsWith("."))
            {
                Console.WriteLine("This song ends with a period");
            }

        }
    }
}
