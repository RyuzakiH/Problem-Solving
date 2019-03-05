using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        Console.ReadLine();
        var T = Console.ReadLine().Split(' ').ToArray();

        int min = Int32.Parse(T[0]), min_pos = 0, num;
        for (int i = 1; i < T.Length; i++)
        {
            num = Int32.Parse(T[i]);
            if (num < min)
            {
                min = num;
                min_pos = i;
            }
        }

        Console.WriteLine(min_pos + 1);
    }

}