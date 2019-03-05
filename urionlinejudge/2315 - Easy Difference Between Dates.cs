using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        var start = Console.ReadLine().Split(' ').Select(s => Int32.Parse(s)).ToArray();
        var end = Console.ReadLine().Split(' ').Select(s => Int32.Parse(s)).ToArray();

        Console.WriteLine((new DateTime(1995, end[1], end[0]) - new DateTime(1995, start[1], start[0])).Days);
    }

}