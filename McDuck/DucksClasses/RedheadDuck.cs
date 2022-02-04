using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using flyable;
using quackable;

namespace DucksClasses
{
    public class RedheadDuck : Duck
    {
        protected IQuackable quackable = new normalQuack();
        protected IFlyable flyable = new FlyWithWings();
        public override Type Display()
        {
            return this.GetType();
        }
    }
}
