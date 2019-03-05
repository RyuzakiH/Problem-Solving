using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        byte N = Byte.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            int X = Int32.Parse(Console.ReadLine());

            bool prime = ((X == 2) || (X % 2 != 0) && (X != 1));
            for (int j = 2; (j <= (int)Math.Floor(Math.Sqrt(X))) && prime; j += 1)
                if (X % j == 0)
                    prime = false;

            Console.WriteLine(((prime) ? X.ToString() : X + " nao") + " eh primo");
        }
    }

}