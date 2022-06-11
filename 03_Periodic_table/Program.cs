using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Periodic_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> pTable = new HashSet<string>();

            for(int i = 0; i < n; i++)
            {
                string[] chemicals = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                
                for(int j = 0; j < chemicals.Length; j++)
                {
                    pTable.Add(chemicals[j]);
                }
            }

            HashSet<string> periodicTable = pTable.OrderBy(x => x).ToHashSet();
            Console.WriteLine(string.Join(" ", periodicTable));
        }
    }
}
