﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    class Queue
    {
        Node head = null;
        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into queue ", node.data);

        }
        internal void Display()
        {
            Node temp = this.head;
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
        internal void dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("queue is empty");
                return;
            }
            Console.WriteLine("{0} is dequeue", this.head.data);
            this.head = this.head.next;
        }
    }
}
