using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DucksClasses;

namespace DucksClasses
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            quackBehavior = new MuteQuack();
            flyBehavior = new FlyNoWay();
        }
        
        //public override string Display()
        //{
        //    return ($"{this.GetType()} - {quackBehavior.GetType()} - {flyBehavior.GetType()}");
        //}
    }
}
