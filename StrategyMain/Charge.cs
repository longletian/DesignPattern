using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyMain
{
    /// <summary>
    /// 定义一个抽象收费类
    /// </summary>
    public  abstract class Charge
    {
       /// <summary>
       /// 定义一个抽象方法
       /// </summary>
       /// <param name="money"></param>
       /// <returns></returns>
        public abstract double GetCharge(double money);
    }
}
