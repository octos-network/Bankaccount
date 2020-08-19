using System;
using System.Collections.Generic;

namespace Test_Neu
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "<name>", "Ana", "Felipe" };
            foreach (string name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"Hello {names[i].ToUpper()}!");
            }

            Console.ReadKey();
        }
    }
}
