using System; 

class URI {

    static void Main(string[] args) { 
        byte N = Byte.Parse(Console.ReadLine());

        System.Text.StringBuilder output = new System.Text.StringBuilder();

        if (N > 0)
            output.Append("0 ");
        if (N > 1)
            output.Append("1 ");

        int old_prev = 0, new_prev = 1, temp;

        for (int i = 2; i < N; i++)
        {
            output.Append((old_prev + new_prev) + " ");

            temp = old_prev;
            old_prev = new_prev;
            new_prev = temp + new_prev;
        }

        Console.WriteLine(output.ToString().Trim());
    }

}