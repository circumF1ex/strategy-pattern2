using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DucksClasses;

namespace DucksClasses
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            quackBehavior = new Squeak();
            flyBehavior = new FlyNoWay();
        }

        //public override string Display()
        //{
        //    return ($"{this.GetType()} - {quackBehavior.GetType()} - {flyBehavior.GetType()}");
        //}
    }
}
