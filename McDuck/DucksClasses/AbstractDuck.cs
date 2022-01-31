using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DucksClasses
{
    public abstract class Duck
    {
        public string Quack()
        {
            return "QUACK!  " + this.GetType();
        }
        public string Swim()
        {
            return "*blop-blop-blop*  " + this.GetType();
        }
        public abstract string Display();
    }
}
