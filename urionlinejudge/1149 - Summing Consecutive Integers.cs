using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        var inputs = Console.ReadLine().Split(' ').Select(n => Int16.Parse(n)).ToArray();

        long sum = 0;
        for (int i = inputs[0]; i < (inputs[0] + inputs[inputs.Length - 1]); i++)
            sum += i;

        Console.WriteLine(sum);
    }

}