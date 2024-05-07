using System;

namespace FactoryMethod_Console
{
    public abstract class Creator
    {
        public abstract Product FactoryMethod(int number);
    }

    public class ConcreteCreator: Creator
    {
        public override Product FactoryMethod(int number)
        {
            if (number > 0) return new ConcreteProduct1();
            if (number < 0) return new ConcreteProduct2();
            return new DefaultProduct();
        }
    }
}