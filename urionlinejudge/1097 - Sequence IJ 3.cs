using System; 

class URI {

    static void Main(string[] args) { 
        byte j2 = 0;
        for (byte i = 1; i <= 9; i += 2)
        {
            for (byte j = (byte)(7 + j2); j >= (5 + j2); j--)
                Console.WriteLine(string.Format("I={0} J={1}", i, j));
            j2 += 2;
        }
    }

}