using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_OpenClosed_Principle
{
    internal class Calculator
    {
        public static void CalculateInterest (IAccount account)
        {
            account.CalculateInterests ();
        }
    }
}
