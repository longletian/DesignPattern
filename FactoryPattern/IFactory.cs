using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public interface IFactory
    {
        Operation CreateOperation();
    }
}
