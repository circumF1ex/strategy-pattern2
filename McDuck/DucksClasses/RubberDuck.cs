using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DucksClasses
{
    public class RubberDuck : Duck, IQuackable
    {
        public string Quack()
        {
            return Convert.ToString($"*quack-quack*\t" + this.GetType());
        }
        public override Type Display()
        {
            return this.GetType();
        }
    }
}
