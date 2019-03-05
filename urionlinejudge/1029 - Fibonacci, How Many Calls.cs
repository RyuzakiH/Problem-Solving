using System; 

class URI {

    static void Main(string[] args) { 
        UInt64[] fib = new UInt64[40];
        int[] calls = new int[40];
        fib[0] = 0;
        fib[1] = 1;
        for (byte i = 2; i <= 39; i++)
        {
            fib[i] = fib[i - 1] + fib[i - 2];
            calls[i] = calls[i - 1] + calls[i - 2] + 2;
        }

        int N = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            byte X = Byte.Parse(Console.ReadLine());
            Console.WriteLine(string.Format("fib({0}) = {1} calls = {2}", X, calls[X], fib[X]));
        }
    }

}