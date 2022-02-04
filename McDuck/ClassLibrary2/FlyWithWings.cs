using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyable
{
    public class FlyWithWings: IFlyable
    {
        public string Fly()
        {
            return "Хлоп-хлоп-Хлоп" + this.GetType();
        }
    }
}
