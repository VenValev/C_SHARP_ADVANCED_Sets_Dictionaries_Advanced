using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().Trim();
            //string text1 = String.Concat(text.Where(c => !Char.IsWhiteSpace(c)));
            SortedDictionary<char, int> symbolsCount = new SortedDictionary<char, int>();
            char[] symbols = text.ToCharArray();

            for(int i = 0; i < symbols.Length; i++)
            {
                if(!symbolsCount.ContainsKey(symbols[i]))
                {
                    symbolsCount.Add(symbols[i], 0);
                }
                symbolsCount[symbols[i]]++;
            }

            foreach(var symbol in symbolsCount.Keys)
            {
                Console.WriteLine($"{symbol}: {symbolsCount[symbol]} time/s");
            }

        }
    }
}
