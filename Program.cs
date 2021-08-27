using System;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            Person i = new Person();
            i.name = "King";
            i.age = 21;
            i.weight = 73;
            i.growth = 176;
            i.eyes = "BLACK";
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"Name:{i.name}, Age:{i.age}, Wieght:{i.weight}, Eyes: {i.eyes}");

        }
        class Person
        {
            public int age;
            public string name;
            public string eyes;
            public int weight;
            public int growth;
            private string status;
        }
    }
}