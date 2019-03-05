using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        byte[] LEDS = { 6, 2, 5, 5, 4, 5, 6, 3, 7, 6 };
        int N = Int32.Parse(Console.ReadLine()), leds_count;
        
        string Input;
        for (int i = 0; i < N; i++)
        {
            Input = Console.ReadLine();

            leds_count = 0;
            for (int j = 0; j < Input.Length; j++)
                leds_count += LEDS[Byte.Parse(Input[j].ToString())];

            Console.WriteLine(leds_count + " leds");
        }
    }

}