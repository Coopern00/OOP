using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var stack = new Stack();
                // stack.Push(null);
                stack.Push(1);
                stack.Push(2);
                stack.Push(3);

                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
            }
            catch (Exception)
            {
                Console.WriteLine("Cannot be null");
            }
        }
    }
}
