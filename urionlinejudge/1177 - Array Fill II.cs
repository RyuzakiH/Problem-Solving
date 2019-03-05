using System; 

class URI {

    static void Main(string[] args) { 
        int X = Int32.Parse(Console.ReadLine());
        for (short i = 0; i < 1000; i++)
            Console.WriteLine(string.Format("N[{0}] = {1}", i, (i % X)));
    }

}