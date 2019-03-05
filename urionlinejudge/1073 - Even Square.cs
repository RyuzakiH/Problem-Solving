using System; 

class URI {

    static void Main(string[] args) { 
        int N = Int32.Parse(Console.ReadLine());
        for (int i = 2; i <= N; i += 2)
            Console.WriteLine(string.Format("{0}^2 = {1}", i, i * i));
    }

}