using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using flyable;
using quackable;

namespace DucksClasses
{
    public class RubberDuck : Duck
    {
        protected IQuackable quackable = new Squeak();
        protected IFlyable flyable = new FlyNoWay();
        public override Type Display()
        {
            return this.GetType();
        }
    }
}
