using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        var input = Console.ReadLine().Split(' ').Select(n => Int32.Parse(n)).ToArray();
        Console.WriteLine("O JOGO DUROU " + ((input[1] <= input[0]) ? (input[1] + 24 - input[0]) : (input[1] - input[0])) + " HORA(S)");
    }

}