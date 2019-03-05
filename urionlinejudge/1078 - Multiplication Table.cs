using System; 

class URI {

    static void Main(string[] args) { 
        short N = Int16.Parse(Console.ReadLine());
        for (byte i = 1; i <= 10; i++)
            Console.WriteLine(string.Format("{0} x {1} = {2}", i, N, i * N));
    }

}