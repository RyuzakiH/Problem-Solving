using System; 

class URI {

    static void Main(string[] args) { 
        double num, average = 0;
        byte count = 0;

        while (true)
        {
            average = 0;
            count = 0;

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

            var X = 0;
            while (true)
            {
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                X = Int32.Parse(Console.ReadLine());

                if (X == 1 || X == 2)
                    break;
            }

            if (X == 2)
                break;
        }
    }

}