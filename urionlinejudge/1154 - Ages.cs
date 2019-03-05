using System; 

class URI {

    static void Main(string[] args) { 
        int N, sum = 0, count = 0;

        while ((N = Int32.Parse(Console.ReadLine())) >= 0)
        {
            sum += N;
            count++;
        }

        Console.WriteLine(((double)sum / count).ToString("0.00"));
    }

}