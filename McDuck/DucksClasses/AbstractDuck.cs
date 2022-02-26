using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DucksClasses;

namespace DucksClasses
{
    public abstract class Duck
    {
        public IQuackable quackBehavior;
        public IFlyable flyBehavior;
        
        public string Swim()
        {
            return "*Даже утка-мишень может плавать, буль-буль!!!!*" + this.GetType();
        }
        public string Display()
        {
            return ($"{this.GetType()} - {quackBehavior.GetType()} - {flyBehavior.GetType()}");
        }

        public string PerformFly()
        {      
            return flyBehavior.Fly();
        }

        public string PerformQuack()
        {
            return quackBehavior.Quack();
        }
        public class set
        {

        }

    }
}
