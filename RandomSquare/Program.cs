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
                numberList.Add(random.Next(0, 100));
            }

            var squaresList = new List<long>();
            numberList.ForEach(value => squaresList.Add((long)value * value));

            for (int i = 0; i < numberList.Count; i++)
            {
                Console.WriteLine($"Original number: {numberList[i]}, Squared: {squaresList[i]}");
            }
        }
    }
}
