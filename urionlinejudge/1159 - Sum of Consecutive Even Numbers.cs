using System; 

class URI {

    static void Main(string[] args) { 
        int X, sum = 0;
        byte j = 0;

        while ((X = Int32.Parse(Console.ReadLine())) != 0)
        {
            X = (X % 2 == 0) ? X : (X + 1);

            sum = 0;
            for (j = 0; j < 5; j++)
            {
                sum += X;
                X += 2;
            }

            Console.WriteLine(sum);
        }
    }

}