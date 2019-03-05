using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        double[] arr = Enumerable.Repeat(11.0, 100).ToArray();
        byte i;
        double X;
        for (i = 0; i < arr.Length; i++)
            if ((X = Double.Parse(Console.ReadLine())) <= 10)
                arr[i] = X;

        for (i = 0; i < arr.Length; i++)
            if (arr[i] != 11)
                Console.WriteLine(string.Format("A[{0}] = {1}", i, arr[i].ToString("0.0")));
    }

}