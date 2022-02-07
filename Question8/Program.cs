using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Question8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Names = { "Ahmad", "Yusuff", "Afolayan" };
            string[] PhoneNumber = { "23456789", "0987654", "A345678" };
            Dictionary<string, string> keyValues = new Dictionary<string, string>();
            for (int i = 0; i < 1; i++)
            {
                keyValues.Add(Names[i], PhoneNumber[i]);
            }
            foreach (var item in keyValues)
            {
                if (keyValues.ContainsKey("Ahmad"))
                {
                    Console.WriteLine($"{item.Key} {item.Value} {DateTime.Now}");
                }
            }
            Console.WriteLine();
            var Query = from values in keyValues where values.Key == "Ahmad" select values;
            foreach (var item in Query)
            {
                Console.WriteLine($"{item.Key} {item.Value} {DateTime.Now}");
            }
            Console.WriteLine();
            var Mehods = keyValues.Where(val => val.Key.Contains("Ahmad"));
            foreach (var item in Mehods)
            {
                Console.WriteLine($"{item.Key} {item.Value} {DateTime.Now}");
            }
            Console.ReadKey();

           
        }
    }
}
