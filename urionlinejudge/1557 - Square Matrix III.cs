using System; 

class URI {

    static void Main(string[] args) { 
        byte N, i, j;
        int pad;
        while ((N = Byte.Parse(Console.ReadLine())) != 0)
        {
            System.Text.StringBuilder matrix = new System.Text.StringBuilder();
            pad = Math.Pow(2, N + N - 2).ToString().Length;
            
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                    matrix.Append((Math.Pow(2, i + j)).ToString().PadLeft(pad, ' ') + " ");
                matrix.Remove(matrix.Length - 1, 1);
                matrix.AppendLine();
            }

            Console.WriteLine(matrix);
        }
    }

}