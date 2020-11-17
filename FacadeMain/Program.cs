using System;

namespace FacadeMain
{
    class Program
    {
        static void Main(string[] args)
        {

            Facade facade = new Facade();
            facade.MethodA();
            Console.ReadKey();
        }
    }
}
