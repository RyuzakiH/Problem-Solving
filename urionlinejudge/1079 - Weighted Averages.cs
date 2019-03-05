using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        short N = Int16.Parse(Console.ReadLine());
        double[] nums = new double[3];

        for (short i = 0; i < N; i++)
        {
            nums = Console.ReadLine().Split(' ').Select(n => Double.Parse(n)).ToArray();
            Console.WriteLine(((2 * nums[0] + 3 * nums[1] + 5 * nums[2]) / 10).ToString("0.0"));
        }
    }

}