using System; 

class URI {

    static void Main(string[] args) { 
        int days = Int32.Parse(Console.ReadLine());
        Console.WriteLine(string.Format("{0} ano(s)\n{1} mes(es)\n{2} dia(s)", days / 365, (days % 365) / 30, (days % 365) % 30));
    }

}