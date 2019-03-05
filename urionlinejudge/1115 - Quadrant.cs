using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        string quadrant;
        while (true)
        {
            var inputs = Console.ReadLine().Split(' ').Select(p => Int32.Parse(p)).ToArray();
            if (inputs[0] == 0 || inputs[1] == 0)
                break;

            if (inputs[0] > 0 && inputs[1] > 0)
                quadrant = "primeiro";
            else if (inputs[0] < 0 && inputs[1] > 0)
                quadrant = "segundo";
            else if (inputs[0] < 0 && inputs[1] < 0)
                quadrant = "terceiro";
            else
                quadrant = "quarto";

            Console.WriteLine(quadrant);
        }
    }

}