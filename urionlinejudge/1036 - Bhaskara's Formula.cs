using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        var input = Console.ReadLine().Split(' ').Select(n => Double.Parse(n)).ToArray();
        var root = (input[1] * input[1]) - 4 * input[0] * input[2];

        if (root > 0 && input[0] != 0)
            Console.WriteLine(string.Format("R1 = {0}\nR2 = {1}", ((-input[1] + Math.Sqrt(root)) / (2 * input[0])).ToString("0.00000"), ((-input[1] - Math.Sqrt(root)) / (2 * input[0])).ToString("0.00000")));
        else
            Console.WriteLine("Impossivel calcular");
    }

}