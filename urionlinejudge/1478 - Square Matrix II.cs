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
                    matrix.Append((Math.Abs(i - j) + 1).ToString().PadLeft(3, ' ') + " ");
                }
                matrix.Remove(matrix.Length - 1, 1);
                matrix.AppendLine();
            }

            Console.WriteLine(matrix);
        }
    }

}