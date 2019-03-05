using System; 

class URI {

    static void Main(string[] args) { 
        int N = Int32.Parse(Console.ReadLine()), IN = 0, num;

        for (int i = 0; i < N; i++)
        {
            num = Int32.Parse(Console.ReadLine());
            if (num >= 10 && num <= 20)
                IN++;
        }

        Console.WriteLine(string.Format("{0} in\n{1} out", IN, N - IN));
    }

}