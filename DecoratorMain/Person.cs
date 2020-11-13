using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorMain
{
    public class Person
    {
        public string Name { get; set; }

        /// <summary>
        ///定义展示的虚方法
        /// </summary>
        public virtual void Show() 
        {
            Console.WriteLine($"装扮的{Name}");
        }
    }
}
