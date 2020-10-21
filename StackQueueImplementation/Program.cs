using System;

namespace StackQueueImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Queue and Stack Implementation !");
            Stack stack = new Stack();
            stack.Push(56);
            stack.Push(30);
            stack.Push(70);
            stack.Display();
        }
    }
}
