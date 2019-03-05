using System; 

class URI {

    static void Main(string[] args) { 
        double S = 1, j = 1;
        for (double i = 3; i <= 39; i += 2)
            S += i / (j *= 2);
        Console.WriteLine(S.ToString("0.00"));
    }

}