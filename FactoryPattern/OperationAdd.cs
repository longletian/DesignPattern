using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    /// <summary>
    /// 加法
    /// </summary>
    public class OperationAdd : Operation
    {
        /// <summary>
        /// 扩展或修改继承的方法、属性、索引器或事件的抽象或虚拟实现需要 override 修饰符。
        /// </summary>
        /// <returns></returns>
        public override double GetResult()
        {
            double result = 0;
            result = Num1 + Num2;
            return result;
        }
    }
}
