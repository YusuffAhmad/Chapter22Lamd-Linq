using System;
using System.Globalization;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = new CultureInfo("en-US", false).TextInfo.ToTitleCase("this iS a Sample sentence.");
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
