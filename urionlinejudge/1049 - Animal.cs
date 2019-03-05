using System; 

class URI {

    static void Main(string[] args) { 
        string[] words = new string[3];

        for (int i = 0; i < 3; i++)
            words[i] = Console.ReadLine();

        string animal = "";

        if (words[0] == "vertebrado")
        {
            if (words[1] == "ave")
            {
                if (words[2] == "carnivoro")
                {
                    animal = "aguia";
                }
                else if (words[2] == "onivoro")
                {
                    animal = "pomba";
                }
            }
            else if (words[1] == "mamifero")
            {
                if (words[2] == "onivoro")
                {
                    animal = "homem";
                }
                else if (words[2] == "herbivoro")
                {
                    animal = "vaca";
                }
            }
        }
        else if (words[0] == "invertebrado")
        {
            if (words[1] == "inseto")
            {
                if (words[2] == "hematofago")
                {
                    animal = "pulga";
                }
                else if (words[2] == "herbivoro")
                {
                    animal = "lagarta";
                }
            }
            else if (words[1] == "anelideo")
            {
                if (words[2] == "hematofago")
                {
                    animal = "sanguessuga";
                }
                else if (words[2] == "onivoro")
                {
                    animal = "minhoca";
                }
            }
        }

        Console.WriteLine(animal);
    }

}