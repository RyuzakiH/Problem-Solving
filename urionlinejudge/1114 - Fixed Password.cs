using System; 

class URI {

    static void Main(string[] args) { 
        string pass;

        while (true)
        {
            pass = Console.ReadLine();

            if (pass == "2002")
            {
                Console.WriteLine("Acesso Permitido");
                break;
            }
            else
                Console.WriteLine("Senha Invalida");
        }
    }

}