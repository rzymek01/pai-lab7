﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class TransactionTO : Transaction
    {
        public TransactionTO(float price = 0.0f, int amount = 0, int id = -1) : base(price, amount, id)
        {
            
        }
    }
}
