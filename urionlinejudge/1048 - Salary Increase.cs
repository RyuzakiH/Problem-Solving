using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        double salary = double.Parse(Console.ReadLine());

        double earned, percentage;

        if (salary <= 400)
        {
            earned = (percentage = 0.15) * salary;
            salary += earned;
        }
        else if (salary <= 800)
        {
            earned = (percentage = 0.12) * salary;
            salary += earned;
        }
        else if (salary <= 1200)
        {
            earned = (percentage = 0.10) * salary;
            salary += earned;
        }
        else if (salary <= 2000)
        {
            earned = (percentage = 0.07) * salary;
            salary += earned;
        }
        else
        {
            earned = (percentage = 0.04) * salary;
            salary += earned;
        }

        Console.WriteLine(string.Format("Novo salario: {0}\nReajuste ganho: {1}\nEm percentual: {2} %", salary.ToString("0.00"), earned.ToString("0.00"), percentage * 100));
    }

}