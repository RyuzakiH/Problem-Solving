using System; 

class URI {

    static void Main(string[] args) { 
        double tax = 0, salary = Double.Parse(Console.ReadLine());

        if (salary > 4500)
            tax += (salary - (salary = 4500)) * 0.28;
        if (salary > 3000)
            tax += (salary - (salary = 3000)) * 0.18;
        if (salary > 2000)
            tax += (salary - (salary = 2000)) * 0.08;

        Console.WriteLine((tax > 0) ? ("R$ " + tax.ToString("0.00")) : "Isento");
    }

}