using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
        //greeting

            Console.WriteLine("Please type you name and press Enter");
            var UserName = Console.ReadLine();

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
            Console.WriteLine($"Nice to meet you, {UserName}");


        //animals

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan", "Horse", "Dog", "Tiger" };

          ////animal rides

            Console.WriteLine("What is your favorite color?");
            var FavColor = Console.ReadLine();

            var rand = new Random();
            var MaxNum = animals.Length - 1;
            var RandomNum = rand.Next(MaxNum);

            Console.WriteLine($"Would you like to ride a {FavColor} {animals[RandomNum]}?");
            var rideResponse = Console.ReadLine();

            if (rideResponse.ToLower() == "yes")
            {
                Console.WriteLine("Sweet!");
            }
            else
            {
                Console.WriteLine("Lame...");
            }

          ////animal syllables

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
