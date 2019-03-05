using System; 

class URI {

    static void Main(string[] args) { 
        int X = Int32.Parse(Console.ReadLine());
        X = (X % 2 == 0) ? X + 1 : X;

        for (byte count = 0; count < 6; X += 2)
        {
            Console.WriteLine(X);
            count++;
        }
    }

}