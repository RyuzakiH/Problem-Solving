using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        var input = "";
        while (!string.IsNullOrEmpty((input = Console.ReadLine())))
            Console.WriteLine(new string(input.ToCharArray().Select(s => (char)((s >= 97 && s <= 122) ? ((s + 13 > 122) ? s - 13 : s + 13) : (s >= 65 && s <= 90 ? (s + 13 > 90 ? s - 13 : s + 13) : s))).ToArray()));
    }

}