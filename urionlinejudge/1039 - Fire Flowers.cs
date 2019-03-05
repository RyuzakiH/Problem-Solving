using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        string input = "";
        while (!string.IsNullOrEmpty(input = Console.ReadLine()))
        {
            var data = input.Trim().Split(' ').Select(d => Int32.Parse(d)).ToArray();
            Console.WriteLine(((data[0] >= data[3]) && (Math.Sqrt((data[4] - data[1]) * (data[4] - data[1]) + (data[5] - data[2]) * (data[5] - data[2])) <= Math.Abs(data[0] - data[3]))) ? "RICO" : "MORTO");
        }
    }

}