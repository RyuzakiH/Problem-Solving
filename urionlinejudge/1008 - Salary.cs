using System; 

class URI {

    static void Main(string[] args) { 
        Console.WriteLine("NUMBER = " + Convert.ToInt32(Console.ReadLine()) + "\nSALARY = U$ " + (Convert.ToInt32(Console.ReadLine()) * Convert.ToDouble(Console.ReadLine())).ToString("0.00"));
    }

}