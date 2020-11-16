using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyMain
{
    /// <summary>
    /// 定义一个送礼物
    /// </summary>
    public interface GiveGift
    {
        /// <summary>
        /// 送洋娃娃
        /// </summary>
        void GiveDolls();

        /// <summary>
        /// 送花
        /// </summary>
        void GiveFlowers();
        /// <summary>
        /// 送巧克力
        /// </summary>
        void GiveChocolate();
    }
}
