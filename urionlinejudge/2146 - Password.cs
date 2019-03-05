using System; 

class URI {

    static void Main(string[] args) { 
        string N;
        while (!string.IsNullOrEmpty(N = Console.ReadLine()))
            Console.WriteLine(Int32.Parse(N) - 1);
    }

}