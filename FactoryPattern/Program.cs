using System;

namespace FactoryPattern
{
    class Program
    {
        /// <summary>
        /// 工厂类和简单工厂的区别
        /// 工厂模式有N次方类就会有会N次方工厂
        /// 简单工厂是N次方类只有一个简单工厂
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            IFactory factory = new FactoryAdd();
            Operation operation = factory.CreateOperation();
            operation.Num1 = 1;
            operation.Num2 = 2;
            double result = operation.GetResult();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
