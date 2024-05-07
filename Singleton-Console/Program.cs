using System;

namespace Singleton_Console
{
    internal abstract class Program
    {
        private static void Main(string[] args)
        {
            var obj1 = SingletonClass.GetInstance();
            var obj2 = SingletonClass.GetInstance();
            obj1.Title = "Book";
            obj1.IsActive = false;
            obj1.Count = 3;
            Console.WriteLine(obj1.Title + " | " + obj2.Title);
            Console.WriteLine(obj1.Count + " | " + obj2.Count);
            Console.WriteLine(obj1.IsActive + " | " + obj2.IsActive);
            obj2.Title = "Laptop";
            obj2.IsActive = true;
            obj2.Count = 5;
            Console.WriteLine(obj1.Title + " | " + obj2.Title);
            Console.WriteLine(obj1.Count + " | " + obj2.Count);
            Console.WriteLine(obj1.IsActive + " | " + obj2.IsActive);
            Console.WriteLine(obj1 == obj2);
            Console.ReadKey();
        }
    }
}