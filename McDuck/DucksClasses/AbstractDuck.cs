using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quackable;
using flyable;

namespace DucksClasses
{
    public abstract class Duck
    {
        protected IQuackable quackBehavior;
        protected IFlyable flyBehavior;
        
        public string Swim()
        {
            return "*Даже утка-мишень может плавать, буль-буль!!!!*" + this.GetType();
        }
        public abstract Type Display();
        
        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            quackBehavior.Quack(); 
        }
        public void setFlyBeahvior(IFlyable fb)
        {
            IFlyable flyable = fb;
        }

        public void setQuackBehavior(IQuackable qb)
        {
            IQuackable quackable = qb;
        }

    }
}
