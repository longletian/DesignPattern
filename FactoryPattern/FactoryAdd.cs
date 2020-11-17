using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class FactoryAdd : IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationAdd();
        }
    }
}
