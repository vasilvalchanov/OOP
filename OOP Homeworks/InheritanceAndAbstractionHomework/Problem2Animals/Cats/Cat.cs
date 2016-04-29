﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2Animals.Cats
{
    public abstract class Cat : Animal
    {
        protected Cat(string name, int age, Gender gender)
            : base(name, age, gender)
        {
        }
    }
}
