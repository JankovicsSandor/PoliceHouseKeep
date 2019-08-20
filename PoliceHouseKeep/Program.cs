using System;
using System.IO;

namespace PoliceHouseKeep
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("map.csv");
            string[] result = text.Split(';', StringSplitOptions.RemoveEmptyEntries);
            foreach (string item in result)
            {
                string[] res = item.Split(',');
                foreach (string res1 in res)
                {
                    Console.Write($"{res1}\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
