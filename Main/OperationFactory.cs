using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    /// <summary>
    /// 定义一个工厂类
    /// </summary>
   public class OperationFactory
    {
        private static  Operation operation = null;
     
        /// <summary>
        /// 创建一个方法，根据运行符号来创建类
        /// </summary>
        /// <param name="operationStr"></param>
        /// <returns></returns>
        
        public static Operation GetOperation(string operationStr)
        {
            switch (operationStr)
            {
                case "+":
                    operation = new OperationAdd();
                    break;
                case "-":
                    operation = new OperationAdd();
                    break;
            }
            return operation;
        }
    }
}
