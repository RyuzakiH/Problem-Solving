using System; 

class URI {

    static void Main(string[] args) { 
        double num, average = 0;
        byte count = 0;

        while (count < 2)
        {
            num = Double.Parse(Console.ReadLine());

            if (num < 0 || num > 10)
                Console.WriteLine("nota invalida");
            else
            {
                average += num / 2;
                count++;
            }
        }

        Console.WriteLine("media = " + average.ToString("0.00"));
    }

}