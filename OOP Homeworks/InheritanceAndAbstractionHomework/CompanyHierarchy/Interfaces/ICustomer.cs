﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy.Interfaces
{
    public interface ICustomer : IPerson
    {
        decimal Balance { get; set; }

    }
}
