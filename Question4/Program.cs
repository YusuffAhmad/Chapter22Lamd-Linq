using System;
using System.Linq;
using System.Collections.Generic;

namespace Question4
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
            var Query = from student in students where student.age >= 18 && student.age <= 24 select student;
            foreach (var item in Query)
            {
                Console.WriteLine($"{item.firstName} {item.lastName}");
            }
            Console.ReadKey();
        }
    }
}
