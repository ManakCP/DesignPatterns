using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design Patterns !!");
            //CREATION - FACTORY PATTERN
            new FactoryClient().Main();
            //CREATION - ABSTRACT FACTORY PATTERN
            new AbstractFactoryClient().Main();
            
        }
    }
}
