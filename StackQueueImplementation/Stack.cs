using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueueImplementation
{
    public class Stack
    {
        internal Node top;

        public Stack()
        {
            this.top = null;
        }

        internal void Push(int data)
        {
            Node node = new Node(data);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine(data + " inserted into Stack");
        }

        internal void Display()
        {
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("\nData present in Stack : ");
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
        internal void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine(this.top.data + " is at top of the stack");
        }

        internal void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine(this.top.data + " removed from stack");
            this.top = this.top.next;
            Display();
        }

        internal void isEmpty()
        {
            while (this.top != null )
            {
                Peek();
                Pop();
            }
        }
    }
}
