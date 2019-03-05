using System; 

class URI {

    static void Main(string[] args) { 
        double R = Double.Parse(Console.ReadLine());
        Console.WriteLine("A=" + (3.14159 * R * R).ToString("0.0000"));
    }

}