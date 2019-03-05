using System; 
using System.Linq;

class URI {

    static void Main(string[] args) { 
        Console.ReadLine();
        var X = System.Text.RegularExpressions.Regex.Split(Console.ReadLine(), @"\s+").ToArray();

        int min = Int32.Parse(X[0]), min_pos = 0, num;
        for (int i = 1; i < X.Length; i++)
        {
            num = Int32.Parse(X[i]);
            if (num < min)
            {
                min = num;
                min_pos = i;
            }
        }

        Console.WriteLine(string.Format("Menor valor: {0}\nPosicao: {1}", min, min_pos));
    }

}