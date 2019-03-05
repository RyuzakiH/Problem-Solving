using System; 

class URI {

    static void Main(string[] args) { 
        Console.ReadLine();
        Console.WriteLine("TOTAL = R$ " + (Convert.ToDouble(Console.ReadLine()) + 0.15 * Convert.ToDouble(Console.ReadLine())).ToString("0.00"));
    }

}