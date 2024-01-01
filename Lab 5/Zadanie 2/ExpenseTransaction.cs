using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Zadanie2
{
    public class ExpenseTransaction : Transaction
    {
        public override void ProcessTransaction()
        {
            Account.Expense -= Amount;
        }
    }
}