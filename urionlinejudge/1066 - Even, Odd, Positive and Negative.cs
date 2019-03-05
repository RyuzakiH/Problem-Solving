using System; 

class URI {

    static void Main(string[] args) { 
        int num, even = 0, odd = 0, positive = 0, negative = 0;

        for (int i = 0; i < 5; i++)
        {
            num = Int32.Parse(Console.ReadLine());

            if (num % 2 != 0)
                odd++;
            if (num % 2 == 0)
                even++;
            if (num > 0)
                positive++;
            if (num < 0)
                negative++;
        }

        Console.WriteLine(string.Format("{0} valor(es) par(es)\n{1} valor(es) impar(es)\n{2} valor(es) positivo(s)\n{3} valor(es) negativo(s)", even, odd, positive, negative));
    }

}