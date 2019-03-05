using System; 

class URI {

    static void Main(string[] args) { 
        double S = 0;
        for (double i = 1; i <= 100; i++)
            S += 1 / i;
        Console.WriteLine(S.ToString("0.00"));
    }

}