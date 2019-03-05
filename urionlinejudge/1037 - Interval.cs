using System; 

class URI {

    static void Main(string[] args) { 
        double num = Double.Parse(Console.ReadLine());

        if (num >= 0)
        {
            if (num <= 25)
                Console.WriteLine("Intervalo [0,25]");
            else if (num <= 50)
                Console.WriteLine("Intervalo (25,50]");
            else if (num <= 75)
                Console.WriteLine("Intervalo (50,75]");
            else if (num <= 100)
                Console.WriteLine("Intervalo (75,100]");
            else
                Console.WriteLine("Fora de intervalo");
        }
        else
            Console.WriteLine("Fora de intervalo");
    }

}