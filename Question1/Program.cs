using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            var mystring = "Argentina";
            var newString = mystring.Substrings(0, 4);
            Console.WriteLine(  newString);
        }
    }
    public static class StringBuilders
    {
        public static string Substrings(this string str, int index, int lenght)
        {
            return str.Substring(index, lenght);
        }
    }
    
}
