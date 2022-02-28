using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DucksClasses;

namespace DucksClasses
{
    public class MallardDuck : Duck
    {
        public MallardDuck()    
        { 
            quackBehavior = new normalQuack();
            flyBehavior = new FlyWithWings(); 
        }

    }
}
