using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 
        var start_day = Int32.Parse(Console.ReadLine().Split(' ')[1]);
        var start_time = Console.ReadLine().Split(':').Select(t => Int32.Parse(t.Trim())).ToArray();
        var end_day = Int32.Parse(Console.ReadLine().Split(' ')[1]);
        var end_time = Console.ReadLine().Split(':').Select(t => Int32.Parse(t.Trim())).ToArray();

        long dur = (end_day * 86400 + end_time[0] * 3600 + end_time[1] * 60 + end_time[2]) - (start_day * 86400 + start_time[0] * 3600 + start_time[1] * 60 + start_time[2]);
        var days = dur / 86400;
        var hours = (dur % 86400) / 3600;
        var minutes = ((dur % 86400) % 3600) / 60;
        var seconds = ((dur % 86400) % 3600) % 60;

        Console.WriteLine(string.Format("{0} dia(s)\n{1} hora(s)\n{2} minuto(s)\n{3} segundo(s)", days, hours, minutes, seconds));
    }

}