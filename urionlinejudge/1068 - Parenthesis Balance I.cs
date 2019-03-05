using System; 

class URI {

    static void Main(string[] args) { 
        bool correct;
        string expression;
        while (!string.IsNullOrEmpty(expression = Console.ReadLine()))
        {
            System.Collections.Stack stack = new System.Collections.Stack();

            correct = true;

            foreach (char c in expression)
            {
                if (c == '(')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    if (stack.Count == 0)
                        correct = false;
                    else
                        stack.Pop();
                }
            }

            Console.WriteLine((correct && stack.Count == 0) ? "correct" : "incorrect");
        }
    }

}