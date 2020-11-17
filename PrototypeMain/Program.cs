using System;

namespace PrototypeMain
{
    class Program
    {
        static void Main(string[] args)
        {
            ConCreatePrototype conCreatePrototype = new ConCreatePrototype("HELLO");
            ConCreatePrototype createPrototype = (ConCreatePrototype)conCreatePrototype.Clone();
            Console.WriteLine(createPrototype.Id);
            Console.ReadKey();
        }
    }
}
