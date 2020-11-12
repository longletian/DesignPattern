using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyMain
{
    public class ChargeNormal : Charge
    {
        /// <summary>
        /// 抽象类的子集必须实现抽象类中的抽象方法
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public override double GetCharge(double money)
        {
            return money;
        }
    }

    public class DiscountCharge : Charge
    {
        private double moneyRebate = 1d;

       /// <summary>
       /// 初始化 根据不同的折扣做处理
       /// </summary>
       /// <param name="moneyRebate"></param>
        public DiscountCharge(string moneyRebate)
        {
            this.moneyRebate = double.Parse(moneyRebate);
        }


        /// <summary>
        /// 重写此方法
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public override double GetCharge(double money)
        {
            return money * this.moneyRebate;
        }
    }
}
