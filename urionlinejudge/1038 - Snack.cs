using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        var input = Console.ReadLine().Split(' ').Select(n => Int32.Parse(n)).ToArray();

        System.Collections.Generic.Dictionary<int, double> table = new System.Collections.Generic.Dictionary<int, double>()
        {
            { 1, 4 }, { 2, 4.5 }, { 3, 5 }, { 4, 2 }, { 5, 1.5 }
        };

        Console.WriteLine("Total: R$ " + (table[input[0]] * input[1]).ToString("0.00"));
    }

}