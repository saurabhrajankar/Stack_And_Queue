using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC1_Create_Stack
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
        }
    }
    public class Stack
    {
        public Node top = null;
        public void Add(int data)
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
            Console.WriteLine(node.data + ":Inserted SuccessFully");
        }
        public void Display()
        {
            Node temp = this.top;
            Console.WriteLine("Values In Stack Are:");
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
    internal class main
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Add(70);
            s.Add(30);
            s.Add(56);
            s.Display();
        }
    }
}
