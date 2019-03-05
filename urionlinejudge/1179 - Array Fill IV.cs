using System; 

class URI {

    static void Main(string[] args) { 
        int[] par = new int[5];
        int[] impar = new int[5];

        int X;
        byte par_index = 0, impar_index = 0, i, j;

        for (i = 0; i < 15; i++)
        {
            X = Int32.Parse(Console.ReadLine());

            if (X % 2 == 0)
                par[par_index++] = X;
            else
                impar[impar_index++] = X;

            if (par_index == 5)
            {
                for (j = 0; j < par_index; j++)
                    Console.WriteLine(string.Format("par[{0}] = {1}", j, par[j]));
                par_index = 0;
            }
            else if (impar_index == 5)
            {
                for (j = 0; j < impar_index; j++)
                    Console.WriteLine(string.Format("impar[{0}] = {1}", j, impar[j]));
                impar_index = 0;
            }
        }

        for (j = 0; j < impar_index; j++)
            Console.WriteLine(string.Format("impar[{0}] = {1}", j, impar[j]));

        for (j = 0; j < par_index; j++)
            Console.WriteLine(string.Format("par[{0}] = {1}", j, par[j]));
    }

}