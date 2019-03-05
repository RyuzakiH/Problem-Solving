using System; 

class URI {

    static void Main(string[] args) { 
        string line;
        while (!string.IsNullOrEmpty(line = Console.ReadLine()))
        {
            var input = line.Split(' ');
            Console.WriteLine(uint.Parse(input[0]) ^ uint.Parse(input[1]));
        }
    }

}