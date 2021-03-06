using System;
using System.Collections.Generic;

namespace _06_Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for(int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();
                string[] clothesArg = text.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string[] clothes = clothesArg[1].Split(',', StringSplitOptions.RemoveEmptyEntries);
                if (!wardrobe.ContainsKey(clothesArg[0]))
                {
                    wardrobe.Add(clothesArg[0], new Dictionary<string, int>());
                }
                for (int j = 0; j < clothes.Length; j++)
                {
                    if (!wardrobe[clothesArg[0]].ContainsKey(clothes[j]))
                    {
                        wardrobe[clothesArg[0]].Add(clothes[j], 0);
                    }
                    wardrobe[clothesArg[0]][clothes[j]]++;
                }
            }

            string[] clothesSearch = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach(var color in wardrobe.Keys)
            {
                Console.WriteLine($"{color} clothes:");
                foreach(var clothes in wardrobe[color].Keys)
                {
                    if(color == clothesSearch[0] && clothes == clothesSearch[1])
                    {
                        Console.WriteLine($"* {clothes} - {wardrobe[color][clothes]} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothes} - {wardrobe[color][clothes]}");
                    }
                    
                }
            }
        }
    }
}
