using System; 

class URI {

    static void Main(string[] args) { 
        for (byte i = 1; i <= 9; i += 2)
            for (byte j = 7; j >= 5; j--)
                Console.WriteLine(string.Format("I={0} J={1}", i, j));
    }

}