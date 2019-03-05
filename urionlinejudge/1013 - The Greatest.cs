using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        var input = Console.ReadLine().Split(' ').Select(n => Int32.Parse(n)).ToArray();

        int Maior = (input[0] + input[1] + Math.Abs(input[0] - input[1])) / 2;
        Maior = (Maior + input[2] + Math.Abs(Maior - input[2])) / 2;

        Console.WriteLine(Maior + " eh o maior");
    }

}