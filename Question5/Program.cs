using System;
using System.Linq;
using System.Collections.Generic;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student{firstName = "Alade", lastName = "Jubril", age = 34},
                new Student{firstName = "Abike", lastName = "Isreal", age = 20},
                new Student{firstName = "Ajile", lastName = "Fatai", age = 34},
                new Student{firstName = "Kolade", lastName = "Jubril", age = 24},
                new Student{firstName = "Labakee", lastName = "Sulaimon", age = 34},
            };
            var lambdaMethod = students.OrderBy(st => st.firstName).ThenBy(stt => stt.lastName);
            foreach (var item in lambdaMethod)
            {
                Console.WriteLine($"{item.firstName} {item.lastName}");
            }
            Console.WriteLine();
            var QueryMethod = from st in students orderby st.firstName orderby  st.lastName select st;
            foreach (var item in QueryMethod)
            {
                Console.WriteLine($"{item.firstName} {item.lastName}");
            }
            Console.ReadKey();
        }
    }
}
