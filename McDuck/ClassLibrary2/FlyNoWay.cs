using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyBehavior
{
    class Class1: IFlyable
    {
        public string Fly()
        {
            return "" + this.GetType();
        }
    }
}
