using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        short[] data;
        while ((data = Console.ReadLine().Split(' ').Select(i => short.Parse(i)).ToArray()).Sum(i => i) != 0)
            Console.WriteLine((int)(10 * Math.Sqrt(data[0] * data[1]) / Math.Sqrt(data[2])));
    }

}