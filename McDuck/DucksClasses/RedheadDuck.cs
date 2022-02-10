using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DucksClasses;

namespace DucksClasses
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            quackBehavior = new normalQuack();
            flyBehavior = new FlyWithWings();
        }

        public override string Display()
        {
            return ($"{this.GetType()} - {quackBehavior.GetType()} - {flyBehavior.GetType()}");
        }
    }
}
