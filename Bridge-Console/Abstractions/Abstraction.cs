using System;
using Bridge_Console.Implementors;

namespace Bridge_Console.Abstractions
{
    public abstract class Abstraction
    {
        private readonly Implementor _implementor;

        protected Abstraction()
        {
            _implementor = new ConcreteImplementor();
        }

        public virtual void AbstractionFunc()
        {
            _implementor.Implementation();
            Console.WriteLine("Run Implementation In AbstractionFunc();");
        }
    }

    public class RefinedAbstraction: Abstraction
    {
        public override void AbstractionFunc()
        {
            base.AbstractionFunc();
            Console.WriteLine("Run AbstractionFunc In RefinedAbstraction Class");
        }
    }
}