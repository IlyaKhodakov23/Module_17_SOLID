using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Practic_OpenClosed_Principle
{
    //класс стандартный аккаунт
    public class Ordinary : IAccount
    {
        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        public void CalculateInterests()
        {
            Interest = Balance * 0.4;
            if (Balance < 1000)
                Interest -= Balance * 0.2;

            if (Balance < 50000)
                Interest -= Balance * 0.4;
        }

        public void ShowInterest()
        {
            Console.WriteLine(Interest);
        }
    }
}
