using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        while (true)
        {
            var points = Console.ReadLine().Split(' ').Select(n => Int32.Parse(n)).ToArray();

            if (points.Sum() == 0)
                break;

            if (points[0] == points[2] && points[1] == points[3])
            {
                Console.WriteLine("0");
            }
            else if ((points[0] == points[2] || points[1] == points[3]) || (Math.Abs(points[0] - points[2]) == Math.Abs(points[1] - points[3])))
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("2");
            }
        }
    }

}