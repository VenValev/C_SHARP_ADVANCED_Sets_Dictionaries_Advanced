using System;
using System.Collections.Generic;

namespace _02_Sets_Of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(s[0]);
            int m = int.Parse(s[1]);

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for(int i= 0; i < n; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < m; i++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }

            firstSet.IntersectWith(secondSet);

            Console.WriteLine(string.Join(" ", firstSet));

        }
    }
}
