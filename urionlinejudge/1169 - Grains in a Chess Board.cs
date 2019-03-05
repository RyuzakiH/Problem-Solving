using System; 

class URI {

    static void Main(string[] args) { 
        byte N = Byte.Parse(Console.ReadLine());
        for (; N > 0; N--)
            Console.WriteLine((long)(Math.Pow(2, Byte.Parse(Console.ReadLine())) / 12000) + " kg");
    }

}