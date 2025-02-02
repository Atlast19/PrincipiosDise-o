// See https://aka.ms/new-console-template for more information

namespace DRY
{
    class program
    {
        public static void Main(string[] args)
        {

        }

        public class Payroll
        {
            private decimal EighteenPorcent = 0.18m;
            private decimal FivePorcent = 0.05m;

            public decimal CalculateSalaryForFullTime(decimal baseSalary)
            {
                return baseSalary - CalculateTax(baseSalary) + CalculateBonus(baseSalary);
            }
            public decimal CalculateSalariForPartTime(decimal HourlyRate, int HoursWorked)
            {
                decimal salary = HourlyRate * HoursWorked;
                return salary - CalculateTax(salary) + CalculateBonus(salary);
            }

            private decimal CalculateTax(decimal salary)
            {
                return salary * EighteenPorcent;
            }

            private decimal CalculateBonus(decimal salary)
            {
                return salary * FivePorcent;
            }
        }
    }
}