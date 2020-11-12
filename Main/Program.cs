using Main;
using System;

namespace FactoryMain
{
    class Program
    {
        //简单工厂模式
        static void Main(string[] args)
        {
            Operation operation = null;
            operation = OperationFactory.GetOperation("+");
            operation.Num1 = 1;
            operation.Num2 = 2;
            double result = operation.GetResult();
            Console.WriteLine("结果" + result);
        }
    }
}
