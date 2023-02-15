namespace Practic_OpenClosed_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Расчет для обычного аккаунта
            Ordinary ordinary = new Ordinary();
            ordinary.Balance = 100000;
            Calculator.CalculateInterest(ordinary);
            ordinary.ShowInterest();

            //Расчет для зарплатного аккаунта
            Salary salary = new Salary();
            salary.Balance = 100000;
            Calculator.CalculateInterest(salary);
            salary.ShowInterest();
        }
    }
}