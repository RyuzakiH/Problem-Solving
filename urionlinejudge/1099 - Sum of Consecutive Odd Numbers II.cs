using System; 

class URI {

    static void Main(string[] args) { 
        int N = Int32.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            var inputs = Console.ReadLine().Split(' ');
            int X = Int32.Parse(inputs[0]);      // larger
            int Y = Int32.Parse(inputs[1]);      // smaller

            if (X < Y)
                swap(ref X, ref Y);
            Y++;

            int sum = 0;
            for (; Y < X; Y++)
                if (Y % 2 != 0)
                    sum += Y;

            Console.WriteLine(sum);
        }
    }

    static void swap(ref int x, ref int y)
    {
        var temp = x;
        x = y;
        y = temp;
    }

}