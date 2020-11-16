using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyMain
{
    public class Proxy : GiveGift
    {
        private Pursuit pursuit;
        public Proxy(SchoolGirl schoolGirl)
        {
            pursuit = new Pursuit(schoolGirl);
        }

        public  void GiveChocolate()
        {
            pursuit.GiveChocolate();
        }

        public  void GiveDolls()
        {
            pursuit.GiveDolls();
        }

        public  void GiveFlowers()
        {
            pursuit.GiveFlowers();
        }
    }
}
