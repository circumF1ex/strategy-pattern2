﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DucksClasses
{
    public abstract class Duck
    {
        public string Swim()
        {
            return "*blop-blop-blop*" + this.GetType();
        }
        public abstract Type Display();
    }
}
