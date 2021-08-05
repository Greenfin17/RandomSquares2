using System;
using System.Collections.Generic;

namespace RandomSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var numberList = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                numberList.Add(random.Next(0, 50));
            }

            var squaresList = new List<long>();
            numberList.ForEach(value => squaresList.Add((long)value * value));

            Console.WriteLine("\n\n     Random Squares\n");
            for (int i = 0; i < numberList.Count; i++)
            {
                Console.WriteLine($"     Original number: {numberList[i], 4},   Squared: {squaresList[i], 6}");
            }

            Console.WriteLine("\n     Listing of the squared numbers:");
            Console.Write("     ");
            squaresList.ForEach(number => Console.Write($"{number} "));
            Console.Write("\n\n");

            // remove odd numbers from squaresList
            squaresList.RemoveAll(number => (number % 2) == 1);
            Console.WriteLine("     Listing of the squared numbers that are even:");
            Console.Write("     ");
            squaresList.ForEach(number => Console.Write($"{number} "));
            Console.Write("\n\n");
        }
    }
}
