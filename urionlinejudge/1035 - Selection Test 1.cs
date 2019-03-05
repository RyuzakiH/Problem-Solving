using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        var input = Console.ReadLine().Split(' ').Select(n => Int32.Parse(n)).ToArray();

        if ((input[1] > input[2]) && (input[3] > input[0]) && ((input[2] + input[3]) > (input[0] + input[1])) && (input[2] > 0) && (input[3] > 0) && (input[0] % 2 == 0))
            Console.WriteLine("Valores aceitos");
        else
            Console.WriteLine("Valores nao aceitos");
    }

}