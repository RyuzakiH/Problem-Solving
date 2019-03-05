using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        var input = Console.ReadLine().Split(' ').Select(n => Double.Parse(n)).ToArray();

        double media = (2 * input[0] + 3 * input[1] + 4 * input[2] + 1 * input[3]) / 10.0;

        Console.WriteLine("Media: " + (Math.Truncate(10 * media) / 10).ToString("0.0"));

        if (media >= 7.0)
            Console.WriteLine("Aluno aprovado.");
        else if (media < 5.0)
            Console.WriteLine("Aluno reprovado.");
        else if (media >= 5.0 && media <= 6.9)
        {
            Console.WriteLine("Aluno em exame.");

            var score = Double.Parse(Console.ReadLine());
            Console.WriteLine("Nota do exame: " + score.ToString("0.0"));

            media = (media + score) / 2.0;

            if (media >= 5.0)
            {
                Console.WriteLine("Aluno aprovado.");
                Console.WriteLine("Media final: " + (Math.Truncate(10 * media) / 10).ToString("0.0"));
            }
            else if (media <= 4.9)
            {
                Console.WriteLine("Aluno reprovado.");
                Console.WriteLine("Media final: " + (Math.Truncate(10 * media) / 10).ToString("0.0"));
            }
        }
    }

}