using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        System.Collections.Generic.Dictionary<int, string> table = new System.Collections.Generic.Dictionary<int, string>()
            {
                {61, "Brasilia"}, {71, "Salvador"}, {11, "Sao Paulo"}, {21, "Rio de Janeiro"}, {32, "Juiz de Fora"}
                , {19, "Campinas"}, {27, "Vitoria"}, {31, "Belo Horizonte"}
            };

        int N = Int32.Parse(Console.ReadLine());

        if (table.ContainsKey(N))
            Console.WriteLine(table[N]);
        else
            Console.WriteLine("DDD nao cadastrado");
    }

}