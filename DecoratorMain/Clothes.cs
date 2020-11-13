using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorMain
{
    public class Clothes : Costume
    {
        public override void Show()
        {
            Console.WriteLine("衣服";
            base.Show();
        }
    }
}
