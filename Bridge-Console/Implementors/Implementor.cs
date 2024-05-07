using System;

namespace Bridge_Console.Implementors
{
    public abstract class Implementor
    {
        public abstract void Implementation();
    }

    public class ConcreteImplementor : Implementor
    {
        public override void Implementation()
        {
            Console.WriteLine("Implementor => Implementation Function");
        }
    }
}