using System;
using System.Collections.Generic;
using Composite_Console.CompositeClass;

namespace Composite_Console
{
    internal abstract class Program
    {
        private static void Main(string[] args)
        {
            Component component = new Composite("Parent", new List<Component>()
            {
                new Leaf("Leaf 1"),
                new Composite("Composite 1", new List<Component>()
                {
                    new Leaf("Leaf 1-1"),
                    new Leaf("Leaf 1-2"),
                    new Leaf("Leaf 1-3"),
                    new Composite("Composite 1-1"),
                    new Composite("Composite 1-2", new List<Component>()
                    {
                        
                        new Leaf("Leaf 1-2-1"),
                        new Leaf("Leaf 1-2-2"),
                        new Leaf("Leaf 1-2-3"),
                    }),
                    new Leaf("Leaf 1-4"),
                    new Leaf("Leaf 1-5"),
                }),
                new Leaf("Leaf 2"),
                new Leaf("Leaf 3"),
                new Leaf("Leaf 4"),
                new Leaf("Leaf 5"),
            });
            component.Display(1);
            Console.ReadKey();
        }
    }
}