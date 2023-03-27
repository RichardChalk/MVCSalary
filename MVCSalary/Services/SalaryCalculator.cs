namespace MVCSalary.Services
{
    public class SalaryCalculator : ISalaryCalculator
    {
        public int Calculate(string name, int age, int totalHours)
        {
            double salaryPerHour = 0;

            if (age < 30)
                salaryPerHour = 100;
            else if (age >= 30 && age <= 50)
                salaryPerHour = 120;
            else
                salaryPerHour = 130;

            if (name == "Richard")
                salaryPerHour = (int)salaryPerHour * 1.1;

            return (int)salaryPerHour * totalHours;
        }
    }
}
