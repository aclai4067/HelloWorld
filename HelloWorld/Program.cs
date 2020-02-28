using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                switch (args[0].ToLower())
                {
                    case "southern":
                        Console.WriteLine("Hey, Y'all!");
                        break;

                    case "alien":
                        Console.WriteLine("Greetings, Earthling");
                        break;

                    case "aussie":
                        Console.WriteLine("Oi, mate");
                        break;

                    case "announcer":
                        Console.WriteLine("Welcome, Ladies and Gentlemen");
                        break;

                    default:
                        Console.WriteLine("Howdy, Y'all!!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Howdy, Y'all!!");
            }


            Console.ReadKey();


            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan", "Horse", "Dog", "Tiger" };
            

            foreach (var animal in animals)
            {
                var lowerAnimal = animal.ToLower();
                var vowels = "aeiouy";
                var lastWasVowel = true;
                var count = 0;

                foreach (var letter in lowerAnimal)
                {
                    if (vowels.Contains(letter))
                    {
                        if (!lastWasVowel)
                        {
                            count++;
                            lastWasVowel = true;
                        }
                    }
                    else
                    {
                        lastWasVowel = false;
                    }
                }

                if ((lowerAnimal.EndsWith("e") || lowerAnimal.EndsWith("es") || lowerAnimal.EndsWith("ed")) && !lowerAnimal.EndsWith("le"))
                {
                    count--;
                }

                if (count > 1)
                {
                    Console.WriteLine(animal);
                }
                else
                {
                    continue;
                }
            }
            Console.ReadKey();
        }
    }
}
