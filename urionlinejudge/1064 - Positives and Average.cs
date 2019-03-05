using System; 

class URI {

    static void Main(string[] args) { 
        double sum = 0, count = 0;
        for (int i = 0; i < 6; i++)
        {
            double num = Double.Parse(Console.ReadLine());

            if (num > 0)
            {
                sum += num;
                count++;
            }
        }

        Console.WriteLine(string.Format("{0} valores positivos\n{1}", count, (sum / count).ToString("0.0")));
    }

}