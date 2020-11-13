using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorMain
{
    /// <summary>
    /// 定义服饰类
    /// </summary>
    public class Costume : Person
    {
        /// <summary>
        /// 为了实现按顺序串联起来
        /// </summary>
        private Person person; 
        public void Decorate(Person person)
        {
            this.person = person;
        }

        public override void Show()
        {
            if (person != null)
            {
                person.Show();
            }
        }
    }
}
