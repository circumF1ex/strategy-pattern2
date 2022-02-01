using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyBehavior
{
    public class FlyWithWings: IFlyable
    {
        public string Fly()
        {
            return "Хлоп-хлоп-Хлоп" + this.GetType();
        }
    }
}
