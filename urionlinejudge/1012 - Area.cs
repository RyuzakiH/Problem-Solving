using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        var input = Console.ReadLine().Split(' ').Select(n => Double.Parse(n)).ToArray();

        Console.WriteLine("TRIANGULO: " + (0.5 * input[0] * input[2]).ToString("0.000"));
        Console.WriteLine("CIRCULO: " + (3.14159 * input[2] * input[2]).ToString("0.000"));
        Console.WriteLine("TRAPEZIO: " + ((input[0] + input[1]) * input[2] / 2).ToString("0.000"));
        Console.WriteLine("QUADRADO: " + (input[1] * input[1]).ToString("0.000"));
        Console.WriteLine("RETANGULO: " + (input[0] * input[1]).ToString("0.000"));
    }

}