using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeMain
{
    /// <summary>
    /// 原型模式：一个对象再创建另一个可定制的对象，而且不需要知道创建的细节
    /// </summary>
    public abstract class Prototype
    {
        public Prototype(string Id)
        {
            this.Id = Id;
        }

        public string   Id { get; set; }

        /// <summary>
        /// 定义一个抽象类
        /// </summary>
        /// <returns></returns>
        public abstract Prototype Clone();
    }
}
