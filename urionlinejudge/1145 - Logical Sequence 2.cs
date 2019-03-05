using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        var inputs = Console.ReadLine().Split(' ').Select(n => Int32.Parse(n)).ToArray();

        for (int i = 1; i <= inputs[1]; i++)
        {
            if (i % inputs[0] == 0)
                Console.Write(i + "\n");
            else
                Console.Write(i + " ");
        }
    }

}