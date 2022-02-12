using System;
using System.Collections.Generic;

namespace MemoryHog
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new();

            do
            {
                string data = "current list size: " + list.Count;
                if (list.Count % 1000000 == 0)
                {
                    Console.WriteLine(data);
                }
                list.Add(data);
            }
            while (true);
        }
    }
}
