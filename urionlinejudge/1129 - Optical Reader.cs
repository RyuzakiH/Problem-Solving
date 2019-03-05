using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        byte N, k;
        byte[] answer;
        int i;

        System.Collections.Generic.Dictionary<byte, char> dict = new System.Collections.Generic.Dictionary<byte, char>() { { 0, 'A' }, { 1, 'B' }, { 2, 'C' }, { 3, 'D' }, { 4, 'E' } };

        while ((N = Byte.Parse(Console.ReadLine())) != 0)
        {
            for (i = 0; i < N; i++)
            {
                answer = Console.ReadLine().Split(' ').Select(j => Byte.Parse(j)).ToArray();

                byte index = 255;
                byte num = 0;
                for (k = 0; k < 5; k++)
                {
                    if (num < 2 && answer[k] <= 127)
                    {
                        index = k;
                        num++;
                    }
                }

                Console.WriteLine((num == 1) ? dict[index] : '*');
            }
        }
    }

}