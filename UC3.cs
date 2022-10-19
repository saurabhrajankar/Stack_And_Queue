using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC3_Create_Queue
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
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine(node.data + ":Inserted SuccessFully");
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
    internal class SQ3
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(70);
            q.Enqueue(30);
            q.Enqueue(56);
            q.Display();
        }
    }
}