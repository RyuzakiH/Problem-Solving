using System; 

class URI {

    static void Main(string[] args) { 
        char O = Console.ReadLine()[0];
        double sum = 0;

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                if (j > i)
                    sum += double.Parse(Console.ReadLine());
                else
                    Console.ReadLine();
            }
        }

        Console.WriteLine(((O == 'S') ? sum : (sum / 66)).ToString("0.0"));
    }

}