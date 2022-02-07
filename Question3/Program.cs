using System;
using System.Linq;
using System.Collections; 
using System.Collections.Generic;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student{firstName = "Alade", lastName = "Jubril", age = 34}, 
                new Student{firstName = "Abike", lastName = "Isreal", age = 34}, 
                new Student{firstName = "Ajile", lastName = "Fatai", age = 34}, 
                new Student{firstName = "Kolade", lastName = "Jubril", age = 34}, 
                new Student{firstName = "Labakee", lastName = "Sulaimon", age = 34}, 
            };
            var Quer = from st in students where st.firstName.CompareTo(st.lastName) == -1 select st;
            foreach (var item in Quer)
            {
                Console.WriteLine($"{item.firstName} {item.lastName}");
            }
            Console.ReadKey();
        }
    }
}
