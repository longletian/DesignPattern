using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMain
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Topic
    {
        public abstract void PrimitOperation();

        public abstract void PrimitOperation1();

        public void  TemplateMethod()
        {
            PrimitOperation();
            PrimitOperation1();
        }

    }
}
