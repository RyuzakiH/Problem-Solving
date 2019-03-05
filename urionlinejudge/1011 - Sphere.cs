using System; 

class URI {

    static void Main(string[] args) { 
        double R = double.Parse(Console.ReadLine());
        Console.WriteLine("VOLUME = " + ((4.0 / 3) * 3.14159 * R * R * R).ToString("0.000"));
    }

}