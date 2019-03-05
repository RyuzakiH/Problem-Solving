using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        int num = Int32.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            string input = Console.ReadLine();
            input = new string(input.Select(c => (char.IsLetter(c)) ? (char)(c + 3) : (char)c).Reverse().Select((c, j) => (j >= input.Length / 2) ? (char)(c - 1) : c).ToArray());
            Console.WriteLine(input);
        }
    }

}