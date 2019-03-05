using System; 

class URI {

    static void Main(string[] args) { 
        short N = Int16.Parse(Console.ReadLine());
        int X, Y;

        for (short i = 0; i < N; i++)
        {
            var inputs = Console.ReadLine().Split(' ');
            X = Int32.Parse(inputs[0]);
            Y = Int32.Parse(inputs[1]);

            X = (X % 2 == 0) ? (X + 1) : X;

            int sum = 0;
            for (int j = 0; j < Y; j++)
            {
                sum += X;
                X += 2;
            }

            Console.WriteLine(sum);
        }
    }

}