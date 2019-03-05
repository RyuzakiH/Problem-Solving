using System; 

class URI {

    static void Main(string[] args) { 
        byte N, i, j;
        while ((N = Byte.Parse(Console.ReadLine())) != 0)
        {
            System.Text.StringBuilder matrix = new System.Text.StringBuilder();

            for (i = 1; i <= N; i++)
            {
                for (j = 1; j <= N; j++)
                {
                    if (i > Math.Ceiling(N / 2.0))
                    {
                        if (j > Math.Ceiling(N / 2.0))
                            matrix.Append((((N - i + 1) > (N - j + 1)) ? (N - j + 1) : (N - i + 1)).ToString().PadLeft(3, ' ') + " ");
                        else
                            matrix.Append((((N - i + 1) > j) ? j : (N - i + 1)).ToString().PadLeft(3, ' ') + " ");
                    }
                    else
                    {
                        if (j > Math.Ceiling(N / 2.0))
                            matrix.Append(((i > (N - j + 1)) ? (N - j + 1) : i).ToString().PadLeft(3, ' ') + " ");
                        else
                            matrix.Append(((i > j) ? j : i).ToString().PadLeft(3, ' ') + " ");
                    }
                }
                matrix.Remove(matrix.Length - 1, 1);
                matrix.AppendLine();
            }

            Console.WriteLine(matrix);
        }
    }

}