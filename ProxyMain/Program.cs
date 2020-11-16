using System;

namespace ProxyMain
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolGirl schoolGirl = new SchoolGirl("机器人");

            //通过代理人去送礼物
            Proxy proxy = new Proxy(schoolGirl);
            proxy.GiveChocolate();
            proxy.GiveDolls();
            proxy.GiveFlowers();
        }
    }
}
