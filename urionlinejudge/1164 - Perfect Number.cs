using System; 

class URI {

    static void Main(string[] args) { 
        byte N = Byte.Parse(Console.ReadLine());
        int i, X, sum;

        for (i = 0; i < N; i++)
        {
            X = Int32.Parse(Console.ReadLine());

            sum = 0;
            for (int j = 1; (j < X) && (sum <= X); j++)
                if (X % j == 0)
                    sum += j;

            if (sum == X)
                Console.WriteLine(X + " eh perfeito");
            else
                Console.WriteLine(X + " nao eh perfeito");
        }
    }

}