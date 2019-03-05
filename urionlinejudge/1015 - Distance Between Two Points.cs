using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        var p1 = Console.ReadLine().Split(' ').Select(n => Double.Parse(n)).ToArray();
        var p2 = Console.ReadLine().Split(' ').Select(n => Double.Parse(n)).ToArray();

        Console.WriteLine(Math.Sqrt((p2[0] - p1[0]) * (p2[0] - p1[0]) + (p2[1] - p1[1]) * (p2[1] - p1[1])).ToString("0.0000"));
    }

}