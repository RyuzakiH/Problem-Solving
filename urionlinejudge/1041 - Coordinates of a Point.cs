using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        var input = Console.ReadLine().Split(' ').Select(n => Double.Parse(n)).ToArray();

        if (input[0] > 0 && input[1] > 0)
            Console.WriteLine("Q1");
        else if (input[0] < 0 && input[1] > 0)
            Console.WriteLine("Q2");
        else if (input[0] < 0 && input[1] < 0)
            Console.WriteLine("Q3");
        else if (input[0] > 0 && input[1] < 0)
            Console.WriteLine("Q4");
        else if (input[0] == 0 && input[1] == 0)
            Console.WriteLine("Origem");
        else if (input[1] == 0)
            Console.WriteLine("Eixo X");
        else if (input[0] == 0)
            Console.WriteLine("Eixo Y");
    }

}