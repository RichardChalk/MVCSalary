namespace MVCSalary.Services
{
    public interface ISalaryCalculator
    {
        int Calculate(
        string name, int age,
        int totalHours);
    }

}
