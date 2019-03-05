using System; 

class URI {

    static void Main(string[] args) { 
        int X;
        while ((X = Int32.Parse(Console.ReadLine())) != 0)
        {
            System.Text.StringBuilder output = new System.Text.StringBuilder();
            for (int i = 1; i <= X; i++)
                output.Append(i + " ");

            Console.WriteLine(output.ToString().Substring(0, output.Length - 1));
        }
    }

}