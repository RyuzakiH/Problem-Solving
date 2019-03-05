using System; 

class URI {

    static void Main(string[] args) { 
        short N = Int16.Parse(Console.ReadLine()), C = 0, R = 0, S = 0, i;
        string[] Case;

        for (i = 1; i <= N; i++)
        {
            Case = Console.ReadLine().Split(' ');

            switch (Case[1])
            {
                case "C":
                    C += Byte.Parse(Case[0]);
                    break;
                case "R":
                    R += Byte.Parse(Case[0]);
                    break;
                case "S":
                    S += Byte.Parse(Case[0]);
                    break;
                default:
                    break;
            }
        }

        double all = C + R + S;

        Console.WriteLine(string.Format("Total: {0} cobaias\nTotal de coelhos: {1}\nTotal de ratos: {2}\nTotal de sapos: {3}\nPercentual de coelhos: {4} %\nPercentual de ratos: {5} %\nPercentual de sapos: {6} %",
            all, C, R, S, (C / all * 100).ToString("0.00"), (R / all * 100).ToString("0.00"), (S / all * 100).ToString("0.00")));
    }

}