using System;

namespace Class_Adapter_Console
{
    internal abstract class Program
    {
        internal static void Main(string[] args)
        {
            ITarget target = new Adapter();
            target.Operation("Hello Erfan");
            Console.ReadKey();
        }
    }
}