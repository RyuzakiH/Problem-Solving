using System; 

class URI {

    static void Main(string[] args) { 
        byte N = Byte.Parse(Console.ReadLine());

        int fact = 1;
        for (; N > 1; N--)
            fact *= N;

        Console.WriteLine(fact);
    }

}