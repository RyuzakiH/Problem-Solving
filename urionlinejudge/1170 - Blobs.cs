using System; 

class URI {

    static void Main(string[] args) { 
        short N = short.Parse(Console.ReadLine());
        for (; N > 0; N--)
            Console.WriteLine(Math.Ceiling(Math.Log10(1 / double.Parse(Console.ReadLine())) / Math.Log10(0.5)) + " dias");
    }

}