using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorMain
{
    public class Pants : Costume
    {
        public override void Show()
        {
            Console.WriteLine("裤子");
            base.Show();
        }
    }
}
