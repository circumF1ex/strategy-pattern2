using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuackBehavior
{
    public class normalQuack: IQuackable
    {
        public string Quack()
        {
            return "Кря-кря" + this.GetType();
        }
    }
}
