using System;
using System.Collections.Generic;
using System.Linq;

namespace practice
{
    class ListPractice
    {
        public void practice(int fib)
        {
            var names = new List<string> { "Cliff", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine();
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");

            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine($"My name is {names[0]}.");
            Console.WriteLine($"The list has {names.Count} people in it.");

            names.Sort();

            foreach (string name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            var fibonacciNumbers = new List<int> { 1, 1 };
            while (fibonacciNumbers.Count < fib)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }

            Console.WriteLine(fibonacciNumbers[fibonacciNumbers.Count - 1]);


            //foreach (var item in fibonacciNumbers)
            //    Console.WriteLine(item);
        }
    }


    class Program1
    {
        static void Mn(string[] args)
        {
            var date = DateTime.Now;
            var item = "eggplant";
            var price = 19.68961;
            var unit = "kg";

            Console.WriteLine($"On {date:d}, the price of {item} was {price:C2} per {unit}.");

            var titles = new Dictionary<string, string>()
            {
                ["Doyle, Arthur Conan"] = "Hound of the Baskervilles, The",
                ["London, Jack"] = "Call of the Wild, The",
                ["Shakespeare, William"] = "Tempest, The"
            };

            Console.WriteLine("Author and Title List");
            Console.WriteLine();
            Console.WriteLine($"|{"Author",-25}|{"Title",30}|");
            foreach (var title in titles)
                Console.WriteLine($"|{title.Key,-25}|{title.Value,30}|");

            Console.WriteLine();

            double a = 3;
            double b = 4;

            Console.WriteLine($"[{DateTime.Now,-20:d}] Hour [{DateTime.Now,-10:HH}] [{1063.342,15:N2}] feet");
            Console.WriteLine($"Area of right angle trial with legs of {a} and {b} is {0.5 * a * b}");
            Console.WriteLine($"Length of a right angle triangle with legs of {a} and {b} is {CalculateHypotenuse(a, b)}");

            date = new DateTime(1731, 11, 25);
            Console.WriteLine($"On {date:dddd, MMMM dd, yyyy} Leonhard Euler introduced the letter e to denote {Math.E:F5} in a letter to Christian Goldbach.");

            // Expected output:
            // On Sunday, November 25, 1731 Leonhard Euler introduced the letter e to denote 2.71828 in a letter to Christian Goldbach.

            var xs = new int[] { 1, 2, 7, 9 };
            var ys = new int[] { 7, 9, 12 };
            Console.WriteLine($"Find the intersection of the {{{string.Join(", ", xs)}}} and {{{string.Join(", ", ys)}}} sets.");

            var userName = "Jane";
            var stringWithEscapes = $"C:\\Users\\{userName}\\Documents";
            var verbatimInterpolated = $@"C:\Users\{userName}\Documents";
            Console.WriteLine(stringWithEscapes);
            Console.WriteLine(verbatimInterpolated);

            // Expected output:
            // Find the intersection of the {1, 2, 7, 9} and {7, 9, 12} sets.
            // C:\Users\Jane\Documents
            // C:\Users\Jane\Documents

        }

        private static double CalculateHypotenuse(double leg1, double leg2) => Math.Sqrt(leg1 * leg1 + leg2 * leg2);

        private static void InitialStringPractice()
        {
            //string greeting = "     Hello World!         ";
            //Console.WriteLine($"[{greeting}]");
            //string trimmedGreeting = greeting.TrimStart();
            //Console.WriteLine($"[{trimmedGreeting}]");
            //trimmedGreeting = greeting.TrimEnd();
            //Console.WriteLine($"[{trimmedGreeting}]");
            //trimmedGreeting = greeting.Trim();
            //Console.WriteLine($"[{trimmedGreeting}]");

            //string sayHello = "Hello World!";
            //Console.WriteLine(sayHello);
            //sayHello = sayHello.Replace("Hello", "Greetings");
            //Console.WriteLine(sayHello);
            //Console.WriteLine(sayHello.ToLower());
            //Console.WriteLine(sayHello.ToUpper());

            //string songLyrics = "You say goodbye, and I say hello.";
            //string goodBye = "goodbye";
            //string greetings = "greetings";
            //if (songLyrics.Contains(goodBye))
            //{
            //    Console.WriteLine($"Song lyrics contains {goodBye}");
            //}

            //if (songLyrics.Contains(greetings))
            //{
            //    Console.WriteLine($"Song lyrics contains {greetings}");
            //}

            //if (songLyrics.StartsWith("You"))
            //{
            //    Console.WriteLine("You are the subject of this song");
            //}

            //if (songLyrics.EndsWith("."))
            //{
            //    Console.WriteLine("This song ends with a period");
            //}

            //ListPractice listPrac = new ListPractice();
            //listPrac.practice(20);
            var p = new Person("Bill", "Wagner");
            Console.WriteLine($"The name, in all caps: {p.AllCaps()}");
            Console.WriteLine($"The name: {p}");

            var phrase = "the quick brown dog jumps over the lazy fox";
            var wordLength = from word in phrase.Split(' ') select word.Length;
            var average = wordLength.Average();
            Console.WriteLine($"The average word length  is: {average:F2}");

            var messages = new Dictionary<int, string>
            {
                [404] = "Page not found",
                [302] = "Page moved, but left a forwarding address",
                [500] = "The web server can't come out to play today."
            };
            try
            {
                Console.WriteLine(messages[500]);
            }
            catch (Exception e) when (LogException(e))
            {

            }
        }

        private static bool LogException(Exception e)
        {
            Console.WriteLine($"\tIn the log routine. Caught {e.GetType()}");
            Console.WriteLine($"\tMessage: {e.Message}");
            return true;
        }

    }

   
}
