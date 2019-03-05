using System; 

class URI {

    static void Main(string[] args) { 
        short X = Int16.Parse(Console.ReadLine());
        for (short i = 1; i <= X; i += 2)
            Console.WriteLine(i);
    }

}