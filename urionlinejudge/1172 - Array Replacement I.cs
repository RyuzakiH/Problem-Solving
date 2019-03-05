using System; 

class URI {

    static void Main(string[] args) { 
        int[] arr = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        int X;
        byte i;

        for (i = 0; i < 10; i++)
            if ((X = Int32.Parse(Console.ReadLine())) > 0)
                arr[i] = X;

        for (i = 0; i < 10; i++)
            Console.WriteLine(string.Format("X[{0}] = {1}", i, arr[i]));
    }

}