using System; 

class URI {

    static void Main(string[] args) { 
        UInt64[] fib = new UInt64[61];
        fib[0] = 0;
        fib[1] = 1;
        int i;

        for (i = 2; i <= 60; i++)
            fib[i] = fib[i - 1] + fib[i - 2];

        int T = Int32.Parse(Console.ReadLine());
        for (i = 0; i < T; i++)
        {
            byte N = Byte.Parse(Console.ReadLine());
            Console.WriteLine(string.Format("Fib({0}) = {1}", N, fib[N]));
        }
    }

}