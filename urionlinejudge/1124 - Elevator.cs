using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        byte temp;
        byte[] data;
        while ((data = Console.ReadLine().Trim().Split(' ').Select(d => Byte.Parse(d)).ToArray()).Sum(i => i) > 0)
        {
            var r = (data[2] + data[3]);

            if (data[1] > data[0])
            {
                temp = data[0];
                data[0] = data[1];
                data[1] = temp;
            }

            if (((((data[0] - r) * (data[0] - r)) + ((data[1] - r) * (data[1] - r))) >= (r * r)) && ((data[2] > data[3]) ? (data[1] >= 2 * data[2]) : (data[1] >= 2 * data[3])))
                Console.WriteLine("S");
            else
                Console.WriteLine("N");
        }
    }

}