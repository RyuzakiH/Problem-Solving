using System; 

class URI {

    static void Main(string[] args) { 
        int N = Int32.Parse(Console.ReadLine());
        for (int i = 2; i <= 10000; i += N)
            Console.WriteLine(i);
    }

}