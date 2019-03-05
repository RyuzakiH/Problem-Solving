using System; 

class URI {

    static void Main(string[] args) { 
        short N = Int16.Parse(Console.ReadLine());
        int square, cubic;
        for (short i = 1; i <= N; i++)
        {
            square = i * i;
            cubic = i * i * i;
            Console.WriteLine(string.Format("{0} {1} {2}\n{3} {4} {5}", i, square, cubic, i, square + 1, cubic + 1));
        }
    }

}