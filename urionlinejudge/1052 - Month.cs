using System; 

class URI {

    static void Main(string[] args) { 
        var Months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        int N = Int32.Parse(Console.ReadLine());
        if (N >= 1 && N <= 12)
            //Console.WriteLine(new System.Globalization.DateTimeFormatInfo().GetMonthName(N).ToString());
            Console.WriteLine(Months[N - 1]);
    }

}