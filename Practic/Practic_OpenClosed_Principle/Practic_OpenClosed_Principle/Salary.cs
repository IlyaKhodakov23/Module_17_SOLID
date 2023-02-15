using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Practic_OpenClosed_Principle
{
    public class Salary : IAccount
    {
        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        public void CalculateInterests()
        {
            // расчет процентной ставки зарплатного аккаунта по правилам банка
            Interest = Balance * 0.5;
        }

        public void ShowInterest ()
        {
            Console.WriteLine(Interest);
        }
    }
}
