using System; 

class URI {

    static void Main(string[] args) { 
        int seconds = Int32.Parse(Console.ReadLine());
        Console.WriteLine(string.Format("{0}:{1}:{2}", seconds / 3600, (seconds % 3600) / 60, (seconds % 3600) % 60));
    }

}