using System; 

class URI {

    static void Main(string[] args) { 
        short diamonds;        
        int N = Int32.Parse(Console.ReadLine());
        System.Collections.Stack stack = new System.Collections.Stack();

        for (int i = 0; i < N; i++)
        {
            diamonds = 0;

            foreach (char c in Console.ReadLine())
            {
                if (c == '<')
                {
                    stack.Push(c);
                }
                else if (c == '>' && stack.Count > 0)
                {
                    stack.Pop();
                    diamonds++;
                }
            }

            stack.Clear();

            Console.WriteLine(diamonds);
        }
    }

}