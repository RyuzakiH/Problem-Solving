using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        int[] input;
        double m;

        while ((input = Console.ReadLine().TrimEnd().Split(' ').Select(i => Int32.Parse(i)).ToArray()).Sum() != 0)
        {
            m = new TimeSpan(input[2], input[3], 0).Subtract(new TimeSpan(input[0], input[1], 0)).TotalMinutes;
            Console.WriteLine((m < 0) ? (m + 1440) : m);
        }
    }

}