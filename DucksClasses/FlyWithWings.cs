using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DucksClasses
{
    public class FlyWithWings: IFlyable
    {
        public string Fly()
        {
            return "Хлоп-хлоп-Хлоп";
        }
    }
}
