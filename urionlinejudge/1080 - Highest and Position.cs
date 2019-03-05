using System; 

class URI {

    static void Main(string[] args) { 
        int max = 0, N;
        byte position = 0, i;

        for (i = 1; i <= 100; i++)
        {
            N = Int32.Parse(Console.ReadLine());

            if (N > max)
            {
                max = N;
                position = i;
            }
        }

        Console.WriteLine(max + Environment.NewLine + position);
    }

}