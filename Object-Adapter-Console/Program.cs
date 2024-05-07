using System;

namespace Object_Adapter_Console
{
    internal abstract class Program
    {
        internal static void Main(string[] args)
        {
            Target target = new Adapter();
            target.Operation("Hello Erfan");
            
            Console.ReadKey();
        }
    }
}