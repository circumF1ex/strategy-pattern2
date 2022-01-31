using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DucksClasses
{
    public class RedheadDuck : Duck, IQuackable, IFlyable
    {
        public string Quack()
        {
            return Convert.ToString($"*quack-quack*\t" + this.GetType());
        }
        public string Fly()
        {
            return Convert.ToString($"*swish-swish*\t" + this.GetType());
        }
        public override Type Display()
        {
            return this.GetType();
        }
    }
}
