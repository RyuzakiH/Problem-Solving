using System; 

class URI {

    static void Main(string[] args) { 
        short N = Int16.Parse(Console.ReadLine());
        for (short i = 1; i <= N; i++)
            Console.WriteLine(string.Format("{0} {1} {2}", i, (i * i), (i * i * i)));
    }

}