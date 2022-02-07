using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number =new List<int>() { 1,2,3,4,5};
            var result = number.Addition();
            Console.WriteLine("Addition: " + result);
            Console.WriteLine();
            var output = number.Minimum();
            Console.WriteLine("Minimum: " + output);
            Console.WriteLine();
            var maaximum = number.Maximum();
            Console.WriteLine("Maximum: "+maaximum);
            Console.WriteLine();
            var Aaverage = number.Average();
            Console.WriteLine("Average: "+Aaverage);
            Console.ReadKey();
        }
    }
    public static class ExtensionMethods
    {
        public static int Addition(this IEnumerable<int> numb)
        {
            return numb.Sum();
        }
        public static int Minimum(this IEnumerable<int> numb)
        {
            return numb.Min();
        }
        public static int Maximum(this IEnumerable<int> numb)
        {
            return numb.Max();
        }
        public static double Averages(this IEnumerable<int> numb)
        {
            return numb.Average();
        }
    }
}
