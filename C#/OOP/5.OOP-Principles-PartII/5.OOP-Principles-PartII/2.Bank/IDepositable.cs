﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public interface IDepositable
    {
        void Deposit(decimal amount);
    }
}
