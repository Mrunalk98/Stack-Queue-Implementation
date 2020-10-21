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
            }
            Console.WriteLine("\nData present in Stack : ");
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }

    }
}
