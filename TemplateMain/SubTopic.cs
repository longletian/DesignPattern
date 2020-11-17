using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMain
{
    public class SubTopic : Topic
    {
        public override void PrimitOperation()
        {
            Console.WriteLine("开始做题");
        }

        public override void PrimitOperation1()
        {
            Console.WriteLine("开始做题1");
        }
    }
}
