using System; 

class URI {

    static void Main(string[] args) { 
        short N = Int16.Parse(Console.ReadLine());
        for (short i = 1; i <= N; i++)
            if (N % i == 0)
                Console.WriteLine(i);
    }

}