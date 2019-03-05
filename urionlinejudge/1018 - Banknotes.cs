using System; 

class URI {

    static void Main(string[] args) { 
        int money = Int32.Parse(Console.ReadLine());

        Console.WriteLine(money);

        byte[] notes = { 100, 50, 20, 10, 5, 2, 1 };

        for (int i = 0; i < notes.Length; i++)
        {
            var num = money / notes[i];
            money %= notes[i];

            Console.WriteLine(num + " nota(s) de R$ " + notes[i] + ",00");
        }
    }

}