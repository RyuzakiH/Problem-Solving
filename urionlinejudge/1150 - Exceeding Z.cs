using System; 

class URI {

    static void Main(string[] args) { 
        int X = Int32.Parse(Console.ReadLine());
        int Z = Int32.Parse(Console.ReadLine());

        while (Z <= X)
            Z = Int32.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = 0; i < Z; i++)
        {
            if ((sum += (X + i)) >= Z)
            {
                Console.WriteLine(++i);
                break;
            }
        }
    }

}