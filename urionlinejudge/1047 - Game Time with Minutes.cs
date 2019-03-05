using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        var input = Console.ReadLine().Split(' ').Select(n => Int32.Parse(n)).ToArray();

        int minutes = input[3] - input[1];
        int hours = (((input[2] <= input[0]) ? (input[2] + 24 - input[0]) : (input[2] - input[0])) * 60) + minutes;
        minutes = hours % 60;
        hours /= 60;

        Console.WriteLine(string.Format("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", hours, minutes));
    }

}