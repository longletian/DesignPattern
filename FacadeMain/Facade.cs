using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeMain
{
   public class Facade
    {
        SubSystemOne subSystemOne;

        SubSystemTwo subSystemTwo;

        public Facade()
        {
            subSystemOne = new SubSystemOne();
            subSystemTwo = new SubSystemTwo();
        }

        public  void MethodA()
        {
            subSystemOne.MethodOne();
            subSystemTwo.MethodTwo();


        }
    }
}
