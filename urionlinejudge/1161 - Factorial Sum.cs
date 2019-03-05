using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        byte[] MN;
        byte i;
        var Fact = new long[21];
        string input;
        while (!string.IsNullOrEmpty(input = Console.ReadLine()))
        {
            MN = input.Split(' ').Select(j => Byte.Parse(j)).ToArray();

            Fact[0] = 1;
            for (i = 1; i <= 20; i++)
                Fact[i] = Fact[i - 1] * i;

            Console.WriteLine(Convert.ToDecimal(Fact[MN[0]] + Fact[MN[1]]));
        }
    }

}