using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        var money = Console.ReadLine().Split('.').Select(n => Int32.Parse(n)).ToArray();

        byte[] notes = { 100, 50, 20, 10, 5, 2 };
        byte[] coins = { 100, 50, 25, 10, 5, 1 };

        Console.WriteLine("NOTAS:");
        for (int i = 0; i < notes.Length; i++)
        {
            var num = money[0] / notes[i];
            money[0] %= notes[i];

            Console.WriteLine(num + " nota(s) de R$ " + notes[i].ToString("0.00"));
        }

        money[1] += (money[0] * 100);

        Console.WriteLine("MOEDAS:");
        for (int i = 0; i < coins.Length; i++)
        {
            var num = money[1] / coins[i];
            money[1] %= coins[i];

            Console.WriteLine(num + " moeda(s) de R$ " + (coins[i] / 100.0).ToString("0.00"));
        }
    }

}