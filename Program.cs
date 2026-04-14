using System;

namespace FizzBuzz;

class Program
{
    static void Main(string[] args)
    {
        int fizz = 0;
        int buzz = 0;
        int stopper = 0;

        // Enda användarvänliga instruktionen här
        // Console.WriteLine("Please enter three numbers separated by spaces.");
        // Console readline till string
        string rawInput = Console.ReadLine() ?? "";

        // Om rawInput är null eller tom, avsluta programmet
        if (string.IsNullOrWhiteSpace(rawInput)) return;

        // Splitta up talen i en array
        string[] inputs = rawInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        // Om vi inte har tre tal, avsluta programmet
        if (inputs.Length != 3) return;
        
        // Hoppas användaren angav talen i rätt ordning, annars blir det skräp in, skräp ut här.
        bool success = int.TryParse(inputs[0], out fizz) && 
                       int.TryParse(inputs[1], out buzz) && 
                       int.TryParse(inputs[2], out stopper);
        if (!success) return;

        // Nu kan vi börja kolla modulus        
        for (int i = 1; i <= stopper; i++)
        {
            if (i % fizz == 0 && i % buzz == 0)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("FizzBuzz");
            }
            else if (i % fizz == 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Fizz");
            }
            else if (i % buzz == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(i);
            }
        }
    }
}
