using System; 

class URI {

    static void Main(string[] args) { 
        string N;
        while (!string.IsNullOrEmpty(N = Console.ReadLine()))
            Console.WriteLine("vai ter " + ((Byte.Parse(N) == 0) ? "copa!" : "duas!"));
    }

}