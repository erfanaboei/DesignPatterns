using System;

namespace Builder_Console.Classes
{
    public class Product
    {
        public string Part1 { get; set; }
        public string Part2 { get; set; }
        public string Name { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Product Name: {Name} | Product Part1: {Part1} | Product Part2: {Part2}");
        }
    }
}