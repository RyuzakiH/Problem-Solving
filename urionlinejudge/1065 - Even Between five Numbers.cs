using System; 

class URI {

    static void Main(string[] args) { 
        int even = 0;
        for (int i = 0; i < 5; i++)
            if (Int32.Parse(Console.ReadLine()) % 2 == 0)
                even++;

        Console.WriteLine(string.Format("{0} valores pares", even));
    }

}