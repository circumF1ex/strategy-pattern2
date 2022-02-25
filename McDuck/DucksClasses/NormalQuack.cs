using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DucksClasses
{
    public class normalQuack: IQuackable
    {
        public string Quack()
        {
            return "Кря-кря";
        }
    }
}
