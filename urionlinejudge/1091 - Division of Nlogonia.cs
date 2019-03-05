using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        short K;
        short[] origin;
        short[] point;

        while ((K = Int16.Parse(Console.ReadLine())) != 0)
        {
            origin = Console.ReadLine().Split(' ').Select(i => Int16.Parse(i)).ToArray();

            for (int j = 0; j < K; j++)
            {
                point = Console.ReadLine().Split(' ').Select(i => Int16.Parse(i)).ToArray();

                if (point[0] == origin[0] || point[1] == origin[1])
                    Console.WriteLine("divisa");
                else if (point[0] > origin[0] && point[1] > origin[1])
                    Console.WriteLine("NE");
                else if (point[0] < origin[0] && point[1] > origin[1])
                    Console.WriteLine("NO");
                else if (point[0] < origin[0] && point[1] < origin[1])
                    Console.WriteLine("SO");
                else if (point[0] > origin[0] && point[1] < origin[1])
                    Console.WriteLine("SE");
            }
        }
    }

}