using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Тумаков_9
{
    class BankTransaction
    {
        public DateTime date;
        public DateTime time;

        public BankTransaction()
        {
            date = DateTime.Today;
            time = DateTime.Now;
        }
    }
}