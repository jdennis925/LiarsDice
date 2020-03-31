using System;
using System.Collections.Generic;
using System.Linq;

namespace LiarsDice
{
    class Program
    {

        static void Main(string[] args)
        {
            Random _random = new Random();


            Console.WriteLine("Liars Dice!");
            
            Console.WriteLine("Starting Dice count:");

            var dice = int.Parse(Console.ReadLine());

            while (dice > 0)
            {
                Console.Write("Press [ENTER] key to Roll!");
                Console.ReadLine();
                var roll = new List<int>();
                for (var i = 0; i < dice; i++)
                {
                    roll.Add(_random.Next(1, 7));
                }
                roll.Sort();
                var result = "[" + string.Join(',', roll) + "]";
                Console.WriteLine($"Roll: {result}");

                Console.WriteLine("Did you lose a die? (y/n)");
                var yn = Console.ReadLine();
                if(string.Equals("y", yn, StringComparison.OrdinalIgnoreCase))
                {
                    dice--;
                }
            }

            Console.WriteLine("Bust!");

            Console.WriteLine("  __\n<(o)___\n ( ._>/\n  `---' ");
        }
    }
}
