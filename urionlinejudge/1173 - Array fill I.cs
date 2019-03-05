using System; 

class URI {

    static void Main(string[] args) { 
        double X = Int32.Parse(Console.ReadLine()) / 2.0;
        for (byte i = 0; i < 10; i++)
            Console.WriteLine(string.Format("N[{0}] = {1}", i, (X *= 2)));
    }

}