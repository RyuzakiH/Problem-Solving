using System; 
using System.Linq;
class URI {

    static void Main(string[] args)
    {
        short N = Int16.Parse(Console.ReadLine());
        int[] F;
        
        for (; N > 0; N--)
        {
            F = Console.ReadLine().Split(' ').Select(j => Int32.Parse(j)).ToArray();
            Console.WriteLine(GCD(F[0], F[1]));
        }
    }

    static int GCD(int a, int b)
    {
        return b == 0 ? a : GCD(b, a % b);
    }

}