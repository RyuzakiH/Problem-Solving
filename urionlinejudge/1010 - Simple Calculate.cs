using System; 

class URI {

    static void Main(string[] args) { 
        var prod1 = Console.ReadLine().Split(' ');
        var prod2 = Console.ReadLine().Split(' ');
        Console.WriteLine("VALOR A PAGAR: R$ " + (Convert.ToInt32(prod1[1]) * Convert.ToDouble(prod1[2]) + Convert.ToInt32(prod2[1]) * Convert.ToDouble(prod2[2])).ToString("0.00"));
    }

}