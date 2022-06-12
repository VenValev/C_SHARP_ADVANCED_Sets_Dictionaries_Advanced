using System;
using System.Collections.Generic;

namespace _04_Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for(int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if(!numbers.ContainsKey(number))
                {
                    numbers.Add(number, 0);
                }
                numbers[number]++;
            }

            foreach(var number in numbers.Keys)
            {
                if (numbers[number] % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
