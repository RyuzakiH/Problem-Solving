using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        while (true)
        {
            var inputs = Console.ReadLine().Split(' ').Select(p => Int16.Parse(p)).ToArray();
            if (inputs[0] == inputs[1])
                break;
            Console.WriteLine((inputs[0] < inputs[1]) ? "Crescente" : "Decrescente");
        }
    }

}