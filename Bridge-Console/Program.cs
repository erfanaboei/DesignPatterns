using System;
using Bridge_Console.Abstractions;

namespace Bridge_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction abstraction = new RefinedAbstraction();
            abstraction.AbstractionFunc();
            Console.ReadKey();
        }
    }
}