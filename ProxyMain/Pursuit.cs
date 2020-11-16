using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyMain
{
    public class Pursuit : GiveGift
    {
        private SchoolGirl schoolGirl;
        public Pursuit(SchoolGirl schoolGirl)
        {
            this.schoolGirl = schoolGirl;
        }

        public  void GiveChocolate()
        {
            Console.WriteLine($"{schoolGirl.Name}送巧克力");
        }

        public  void GiveDolls()
        {
            Console.WriteLine($"{schoolGirl.Name}送洋娃娃");
        }

        public  void GiveFlowers()
        {
            Console.WriteLine($"{schoolGirl.Name}送鲜花");
        }
    }
}
