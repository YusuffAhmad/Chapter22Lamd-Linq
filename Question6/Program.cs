using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 3, 42, 5, 67, 34, 56};
            var MethodSyntax = from num in myArray where num % 21 == 0 select num;
            foreach (var item in MethodSyntax)
            {
                Console.WriteLine(item);
            }
            var QuerySyntax = myArray.Where(num => num % 21 == 0).Select(num => num);
            Console.ReadKey();
        }
    }
}
