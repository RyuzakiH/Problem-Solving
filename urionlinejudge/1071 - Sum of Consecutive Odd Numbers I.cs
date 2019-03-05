using System; 

class URI {

    static void Main(string[] args) { 
        int X = Int32.Parse(Console.ReadLine());
        int Y = Int32.Parse(Console.ReadLine()) + 1;

        Y = (Y % 2 == 0) ? Y + 1 : Y;

        int sum = 0;
        for (; Y < X; Y += 2)
            sum += Y;

        Console.WriteLine(sum);
    }

}