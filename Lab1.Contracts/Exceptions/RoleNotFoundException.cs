﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Contracts.Exceptions
{
    public class RoleNotFoundException : NotFoundException
    {
        public RoleNotFoundException() : base("System don't have this role!") { }
    }
}