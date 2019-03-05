using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        int Inter = 0, Gremio = 0, Empates = 0;

        while (true)
        {
            var input = Console.ReadLine().Split(' ').Select(n => Int32.Parse(n)).ToArray();

            if (input[0] > input[1])
                Inter++;
            else if (input[0] == input[1])
                Empates++;
            else
                Gremio++;

            Console.WriteLine("Novo grenal (1-sim 2-nao)");

            if (Console.ReadLine() == "2")
                break;
        }

        Console.WriteLine(string.Format("{0} grenais\nInter:{1}\nGremio:{2}\nEmpates:{3}", (Inter + Gremio + Empates), Inter, Gremio, Empates));

        if (Inter > Gremio)
            Console.WriteLine("Inter venceu mais");
        else if (Inter < Gremio)
            Console.WriteLine("Gremio venceu mais");
        else
            Console.WriteLine("Não houve vencedor");
    }

}