using System; 

class URI {

    static void Main(string[] args) { 
        int positive = 0;
        for (int i = 0; i < 6; i++)
            if (Double.Parse(Console.ReadLine()) > 0)
                positive++;

        Console.WriteLine(string.Format("{0} valores positivos", positive));
    }

}