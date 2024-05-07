using System;

namespace Proxy_Console
{
    internal abstract class Program
    {
        private static void Main(string[] args)
        {
            ISubject subject = new Proxy();
            subject.DoAction();
            Console.ReadKey();
        }
    }
}