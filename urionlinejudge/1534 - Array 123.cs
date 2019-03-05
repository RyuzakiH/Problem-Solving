using System; 

class URI {

    static void Main(string[] args) { 
        string input;
        byte N, i, j, k;
        while (!string.IsNullOrEmpty(input = Console.ReadLine()))
        {
            N = Byte.Parse(input);
            System.Text.StringBuilder matrix = new System.Text.StringBuilder();
            k = N;

            for (i = 1; i <= N; i++)
            {
                for (j = 1; j <= N; j++)
                {
                    if (j == k)
                        matrix.Append(2);
                    else if (j == i)
                        matrix.Append(1);
                    else
                        matrix.Append(3);
                }
                matrix.AppendLine();
                k--;
            }

            Console.WriteLine(matrix.Remove(matrix.Length - 1, 1));
        }
    }

}