using System; 

class URI {

    static void Main(string[] args) { 
        int num = Int32.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            var input = Console.ReadLine().Split(' ');

            int N1 = Int32.Parse(input[0]);
            int D1 = Int32.Parse(input[2]);
            int N2 = Int32.Parse(input[4]);
            int D2 = Int32.Parse(input[6]);

            char oper = input[3][0];

            int first, second;

            switch (oper)
            {
                case '+':
                    first = (N1 * D2 + N2 * D1);
                    second = (D1 * D2);
                    break;
                case '-':
                    first = (N1 * D2 - N2 * D1);
                    second = (D1 * D2);
                    break;
                case '*':
                    first = (N1 * N2);
                    second = (D1 * D2);
                    break;
                case '/':
                    first = (N1 * D2);
                    second = (N2 * D1);
                    break;
                default:
                    first = 0;
                    second = 1;
                    break;
            }

            var gcd = GCD(first, second);

            Console.WriteLine(first + "/" + second + " = " + (((second / gcd) < 0) ? -first / gcd : first / gcd) + "/" + Math.Abs(second / gcd));
        }
    }

    static int GCD(int a, int b)
    {
        return b == 0 ? a : GCD(b, a % b);
    }

}