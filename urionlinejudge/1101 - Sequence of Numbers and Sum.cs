using System; 

class URI {

    static void Main(string[] args) { 
        while (true)
        {
            var inputs = Console.ReadLine().Split(' ');
            int X = Int32.Parse(inputs[0]);      // larger
            int Y = Int32.Parse(inputs[1]);      // smaller

            if (X <= 0 || Y <= 0)
                break;

            if (X < Y)
                swap(ref X, ref Y);

            int sum = 0;
            for (; Y <= X; Y++)
            {
                Console.Write(Y + " ");
                sum += Y;
            }

            Console.WriteLine("Sum=" + sum);
        }
    }
    
    static void swap(ref int x, ref int y)
    {
        var temp = x;
        x = y;
        y = temp;
    }

}