using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        var input = Console.ReadLine().Split(' ').Select(n => Int32.Parse(n)).ToArray();
        var arr = new int[3] { input[0], input[1], input[2] };
        int temp = 0;

        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < input.Length - 1; j++)
            {
                if (input[j] > input[j + 1])
                {
                    temp = input[j + 1];
                    input[j + 1] = input[j];
                    input[j] = temp;
                }
            }
        }

        Console.WriteLine(input[0] + Environment.NewLine + input[1] + Environment.NewLine + input[2]);
        Console.WriteLine();
        Console.WriteLine(arr[0] + Environment.NewLine + arr[1] + Environment.NewLine + arr[2]);
    }

}