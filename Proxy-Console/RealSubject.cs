using System;

namespace Proxy_Console
{
    public class RealSubject: ISubject
    {
        public void DoAction()
        {
            Console.WriteLine("DoSubject Is Running...");
        }
    }
}