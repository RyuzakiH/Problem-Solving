using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        int N = Int32.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            var Input = Console.ReadLine();
            var shift = Byte.Parse(Console.ReadLine());

            Console.WriteLine(new string(Input.ToCharArray().Select(s => (char)(((s - shift) < 65) ? (s + 26 - shift) : (s - shift))).ToArray()));
        }
    }

}