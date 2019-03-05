using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        byte[] BN;
        short[] reserves, relation;

        while ((BN = Console.ReadLine().Split(' ').Select(i => Byte.Parse(i)).ToArray()).Sum(d => d) != 0)
        {
            reserves = Console.ReadLine().Split(' ').Select(i => Int16.Parse(i)).ToArray();

            for (int i = 0; i < BN[1]; i++)
            {
                relation = Console.ReadLine().Split(' ').Select(j => Int16.Parse(j)).ToArray();
                
                reserves[relation[1] - 1] += relation[2];
                reserves[relation[0] - 1] -= relation[2];
            }

            if (reserves.All(i => i >= 0))
                Console.WriteLine("S");
            else
                Console.WriteLine("N");
        }
    }

}