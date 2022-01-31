using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DucksClasses
{
    public class DecoyDuck : Duck
    {
        public override Type Display()
        {
            return this.GetType();
        }
    }
}
