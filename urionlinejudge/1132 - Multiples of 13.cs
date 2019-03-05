using System; 

class URI {

    static void Main(string[] args) { 
        int X = Int32.Parse(Console.ReadLine());      // larger
        int Y = Int32.Parse(Console.ReadLine());      // smaller

        if (X < Y)
            swap(ref X, ref Y);

        int sum = 0;
        for (; Y <= X; Y++)
            if (Y % 13 != 0)
                sum += Y;

        Console.WriteLine(sum);
    }

    static void swap(ref int x, ref int y)
    {
        var temp = x;
        x = y;
        y = temp;
    }

}