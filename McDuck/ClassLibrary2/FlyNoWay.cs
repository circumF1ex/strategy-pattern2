using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyable
{
    public class FlyNoWay: IFlyable
    {
        public string Fly()
        {
            return "" + this.GetType();
        }
    }
}
