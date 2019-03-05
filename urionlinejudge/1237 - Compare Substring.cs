using System; 

class URI {

    static void Main(string[] args) { 
        byte i, j;
        int lcs;
        string input1;
        string input2;
        while (!string.IsNullOrEmpty(input1 = Console.ReadLine()))
        {
            input2 = Console.ReadLine();

            lcs = 0;
            for (i = 0; i < input1.Length; i++)
                for (j = i; j <= input1.Length; j++)
                    if (input2.Contains(input1.Substring(i, j - i)))
                        if (lcs < (j - i))
                            lcs = j - i;

            Console.WriteLine(lcs);
        }
    }

}