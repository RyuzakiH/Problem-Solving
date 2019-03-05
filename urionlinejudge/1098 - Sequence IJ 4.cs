using System; 

class URI {

    static void Main(string[] args) { 
        float j2 = 0, i, j;
        for (i = 0; i <= 2.01f; i += 0.2f)
        {
            for (j = (1 + j2); j <= (float)(3f + j2); j++)
                Console.WriteLine(string.Format("I={0} J={1}", i, j));
            j2 += 0.2f;
        }
    }

}