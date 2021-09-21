using System;

namespace ConsoleApp1
{
    class Person
    {
        public string name = "Ваня";
        public int age = 18;

        public void GetInfo()
        {
            Console.WriteLine("Имя = " + name + "\nВозраст = " + age.ToString());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Person ivan = new Person();
            ivan.GetInfo();
            Console.ReadKey();

            ivan.name = "Андрей";
            ivan.age = 21;
            ivan.GetInfo();
            Console.ReadKey();
        }
    }
}
