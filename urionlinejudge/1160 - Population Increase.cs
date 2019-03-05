using System; 

class URI {

    static void Main(string[] args) { 
        short N = Int16.Parse(Console.ReadLine());

        for (short i = 0; i < N; i++)
        {
            var inputs = Console.ReadLine().Split(' ');
            int PA = Int32.Parse(inputs[0]);
            int PB = Int32.Parse(inputs[1]);
            double GA = Double.Parse(inputs[2]) / 100;
            double GB = Double.Parse(inputs[3]) / 100;

            byte years = 0;
            while (PA <= PB && years <= 100)
            {
                years++;
                PA += (int)(GA * PA);
                PB += (int)(GB * PB);
            }

            if (years > 100)
                Console.WriteLine("Mais de 1 seculo.");
            else if (PA > PB)
                Console.WriteLine(years + " anos.");
        }
    }

}