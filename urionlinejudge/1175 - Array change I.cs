using System; 

class URI {

    static void Main(string[] args) { 
        int[] N = new int[20];
        short i;

        for (i = 19; i >= 0; i--)
            N[i] = Int32.Parse(Console.ReadLine());

        for (i = 0; i < 20; i++)
            Console.WriteLine(string.Format("N[{0}] = {1}", i, N[i]));
    }

}