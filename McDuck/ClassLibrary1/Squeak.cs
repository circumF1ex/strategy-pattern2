﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quackable
{
    public class Squeak: IQuackable
    {
        public string Quack()
        {
            return "Квик-квик" + this.GetType();
        }
    }
}
