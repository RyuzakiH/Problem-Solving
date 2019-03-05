using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        var input = Console.ReadLine().Split(' ').Select(n => Double.Parse(n)).ToArray();

        if ((input[0] + input[1]) > input[2] && (input[0] + input[2]) > input[1] && (input[1] + input[2]) > input[0])
            Console.WriteLine("Perimetro = " + (input[0] + input[1] + input[2]).ToString("0.0"));
        else
            Console.WriteLine("Area = " + ((input[0] + input[1]) * input[2] / 2).ToString("0.0"));
    }

}