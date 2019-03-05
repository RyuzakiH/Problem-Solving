using System; 

class URI {

    static void Main(string[] args) { 
        int i, start_index;
        string input, temp;
        int N = int.Parse(Console.ReadLine());
        for (; N > 0; N--)
        {
            input = Console.ReadLine();

            start_index = (input.Length / 2) - 1;
            temp = "";

            for (i = start_index; i >= 0; i--)
                temp += input[i];
            
            for (i = input.Length - 1; i > start_index; i--)
                temp += input[i];

            Console.WriteLine(temp);
        }
    }

}