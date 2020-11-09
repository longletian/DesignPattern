using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    /// <summary>
    /// 定义一个运算类
    /// </summary>
    public abstract  class Operation
    {
        public double Num1 { get; set; } = 0;

        public double Num2 { get; set; } = 0;


        /// <summary>
        /// 定义一个虚方法（不断向上寻找是否存在该方法）
        /// 用于修改方法、属性、索引器或事件声明
        /// </summary>
        /// <returns></returns>
        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }
}
