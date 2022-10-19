using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC4_Deque_For_Begning
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
    public class Queue
    {
        Node head = null;
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
                Console.WriteLine(node.data + ":Inserted SuccessFully");
            }
            else
            {
                Node addr = new Node(data);
                Node h1 = null;
                h1 = this.head;
                this.head = addr;
                Node temp = addr;
                temp.next = h1;
                Console.WriteLine(addr.data + ":Inserted SuccessFully");
            }
        }

        public void Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("Queue Is Empty");
            }
            else
            {
                Console.WriteLine("Dequeueing Elements:");
                while (head != null)
                {
                    Console.WriteLine(head.data + " ");
                    head = head.next;
                }
            }
        }
        public void Display()
        {
            Node temp = this.head;
            Console.WriteLine("Values In Queue Are:");
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
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
            Queue q = new Queue();
            q.Enqueue(70);
            q.Enqueue(30);
            q.Enqueue(56);
            q.Display();
            q.Dequeue();
            q.Display();
        }
    }
}
