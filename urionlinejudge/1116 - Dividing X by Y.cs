using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        int N = Int32.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            var inputs = Console.ReadLine().Split(' ').Select(p => Double.Parse(p)).ToArray();
            Console.WriteLine((inputs[1] != 0) ? (inputs[0] / inputs[1]).ToString("0.0") : "divisao impossivel");
        }
    }

}