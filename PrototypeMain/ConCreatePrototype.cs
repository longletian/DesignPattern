using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeMain
{
    class ConCreatePrototype : Prototype
    {
        public ConCreatePrototype(string Id) : base(Id)
        { 
        
        }

        public override Prototype Clone()
        {
            //创建当前对象的浅表副本，
            //创建一个新对象，然后当前对象的非静态字段复制到该对象，
            //如果字段是值类型,则对该字段执行逐位复制，如果字段是引用类型，
            //则复制引用而不复制引用的对象,因此原始对象及其副本引用是同一个对象

            //浅复制：被复制对象的所有变量都含有与原来的对象相同的值，而所有的对其他对象的引用都仍然指向原来的对象
            //深复制：吧引用对象的变量指向复制过的新对象，而不是原有的被引用的对象

            return (Prototype)this.MemberwiseClone();
        }
    }
}
