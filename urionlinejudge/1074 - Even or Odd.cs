using System; 

class URI {

    static void Main(string[] args) { 
        int N = Int32.Parse(Console.ReadLine()), num;
        string Message;
        for (int i = 0; i < N; i++)
        {
            num = Int32.Parse(Console.ReadLine());

            Message = "";

            if (num % 2 != 0)
                Message += "ODD ";
            else
                Message += "EVEN ";

            if (num > 0)
                Message += "POSITIVE";
            else if (num < 0)
                Message += "NEGATIVE";
            else
                Message = "NULL";

            Console.WriteLine(Message);
        }
    }

}