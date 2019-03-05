using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        short[] vt;
        string input;
        while (!string.IsNullOrEmpty(input = Console.ReadLine()))
        {
            vt = input.Split(' ').Select(j => short.Parse(j)).ToArray();
            Console.WriteLine(2 * vt[0] * vt[1]);
        }
    }

}