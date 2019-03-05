using System; 

class URI {

    static void Main(string[] args) { 
        int Lines = Int32.Parse(Console.ReadLine()), Num = 1;

        System.Text.StringBuilder output = new System.Text.StringBuilder();
        for (int i = 0; i < Lines; i++)
        {
            output.AppendLine(string.Format("{0} {1} {2} PUM", Num, Num + 1, Num + 2));
            Num += 4;
        }

        Console.WriteLine(output.ToString().Trim());
    }

}