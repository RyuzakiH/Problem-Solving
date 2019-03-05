using System; 

class URI {

    static void Main(string[] args) { 
        int Alcool = 0, Gasolina = 0, Diesel = 0;
        string input;

        while (true)
        {
            input = Console.ReadLine();

            if (input == "1")
                Alcool++;
            else if (input == "2")
                Gasolina++;
            else if (input == "3")
                Diesel++;
            else if (input == "4")
                break;
        }

        Console.WriteLine(string.Format("MUITO OBRIGADO\nAlcool: {0}\nGasolina: {1}\nDiesel: {2}", Alcool, Gasolina, Diesel));
    }

}