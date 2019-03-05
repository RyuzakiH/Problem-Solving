using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        var input = Console.ReadLine().Split(' ').Select(n => Double.Parse(n)).ToArray();

        double temp = 0;

        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < input.Length - 1; j++)
            {
                if (input[j] < input[j + 1])
                {
                    temp = input[j + 1];
                    input[j + 1] = input[j];
                    input[j] = temp;
                }
            }
        }

        if (input[0] >= (input[1] + input[2]))
            Console.WriteLine("NAO FORMA TRIANGULO");
        else
        {
            if (input[0] * input[0] == (input[1] * input[1] + input[2] * input[2]))
                Console.WriteLine("TRIANGULO RETANGULO");
            if ((input[0] * input[0]) > (input[1] * input[1] + input[2] * input[2]))
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            if (input[0] * input[0] < (input[1] * input[1] + input[2] * input[2]))
                Console.WriteLine("TRIANGULO ACUTANGULO");
            if (input[0] == input[1] && input[0] == input[2])
                Console.WriteLine("TRIANGULO EQUILATERO");
            if ((input[0] == input[1] && input[0] != input[2]) || (input[1] == input[2] && input[1] != input[0]))
                Console.WriteLine("TRIANGULO ISOSCELES");
        }
    }

}