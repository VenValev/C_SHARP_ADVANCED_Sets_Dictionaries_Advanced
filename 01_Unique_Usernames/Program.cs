using System;
using System.Collections.Generic;

namespace _01_Unique_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> userNames = new HashSet<string>();

            for(int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                userNames.Add(s);
            }

            foreach(var name in userNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
