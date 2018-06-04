using System;
using System.Collections.Generic;

namespace list_quickstart
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Nuasep", "Ana", "Felipe" };
            
            {
                Console.WriteLine();
                names.Add("Maria");
                names.Add("Bill");
                names.Remove("Ana");
                foreach (var name in names)
                {
                    Console.WriteLine($"Hello {name.ToUpper()}!");
                }

                
            }
        }
    }
}