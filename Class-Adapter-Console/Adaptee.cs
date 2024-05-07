using System;

namespace Class_Adapter_Console
{
    public class Adaptee
    {
        public void SpecificOperation(string message)
        {
            Console.WriteLine($"Adaptee Specific Operation is Run... | Message => {message}");
        }
    }
}