using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        while (true)
        {
            var input = Console.ReadLine().Split(' ');

            if (input[0] == "0" && input[1] == "0")
                break;

            input[1] = input[1].Replace(input[0], "");

            Console.WriteLine((input[1] == "") ? "0" : (input[1].All(c => c == '0') ? "0" : input[1].TrimStart(new Char[] { '0' })));
        }
    }

}