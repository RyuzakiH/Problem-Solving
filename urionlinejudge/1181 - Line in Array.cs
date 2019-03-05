using System; 

class URI {

    static void Main(string[] args) { 
        byte L = Byte.Parse(Console.ReadLine());
        char T = Console.ReadLine()[0];

        double sum = 0;

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                if (i == L)
                    sum += double.Parse(Console.ReadLine());
                else
                    Console.ReadLine();
            }
        }

        Console.WriteLine(((T == 'S') ? sum : (sum / 12)).ToString("0.0"));
    }

}