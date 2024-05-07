using System;

namespace Prototype_Console
{
    internal abstract class Program
    {
        private static void Main(string[] args)
        {
            ConcretePrototypeSimple prototypeSimple = new ConcretePrototypeSimple(150, "Erfan");
            var prototype2 = (ConcretePrototypeSimple)prototypeSimple.Clone();
            Console.WriteLine("Prototype1 Count => " + prototypeSimple.Count);
            Console.WriteLine("Prototype2 Count => " + prototype2.Count);
            Console.WriteLine("Prototype1 Title => " + prototypeSimple.Title);
            Console.WriteLine("Prototype2 Title => " + prototype2.Title);
            Console.WriteLine("Is Equal Prototype1 and Prototype2 => " + (prototypeSimple == prototype2));

            ConcretePrototypeComplex complex1 = new ConcretePrototypeComplex(prototypeSimple);
            var complex2 = (ConcretePrototypeComplex)complex1.Clone();
            Console.WriteLine("Complex1 Count => " + complex1.MyService.Count );
            Console.WriteLine("Complex2 Count => " + complex2.MyService.Count);
            Console.WriteLine("Complex2 Title => " + complex1.MyService.Title);
            Console.WriteLine("Complex2 Title => " + complex2.MyService.Title);
            Console.WriteLine("Is Equal Complex1 and Complex2 => " + (complex1 == complex2));
            
            Console.ReadKey();
        }
    }
}