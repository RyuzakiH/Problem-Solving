using System; 

class URI {

    static void Main(string[] args) { 
        short i = -2;
        for (short j = 60; j >= 0; j -= 5)
            Console.WriteLine(string.Format("I={0} J={1}", (i += 3), j));
    }

}