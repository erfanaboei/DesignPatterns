using System;
using System.Runtime.InteropServices;

namespace Composite_Computer_Sample
{
    internal abstract class Program
    {
        private static void Main(string[] args)
        {
            var cpu = new Leaf("CPU", 100000);
            var ram = new Leaf("RAM", 50000);
            var mouse = new Leaf("Mouse", 60000);
            var keyboard = new Leaf("Keyboard", 65000);
            var hardDisk = new Leaf("HardDisk", 200000);
            var monitor = new Leaf("Monitor", 150000);
            
            var motherBoard = new Composite("MotherBoard", 300000);
            var cabinet = new Composite("Case", 500000);
            var peripherals = new Composite("Peripherals", 0);
            var computer = new Composite("Computer", 0);
            
            peripherals.AddComponent(mouse);
            peripherals.AddComponent(keyboard);

            motherBoard.AddComponent(cpu);
            motherBoard.AddComponent(ram);

            cabinet.AddComponent(hardDisk);
            cabinet.AddComponent(motherBoard);

            computer.AddComponent(cabinet);
            computer.AddComponent(peripherals);
            computer.AddComponent(monitor);

            computer.DisplayPrice();
            
            Console.ReadKey();
        }
    }
}