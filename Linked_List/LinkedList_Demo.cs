using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    internal class LinkedList_Demo
    {
        public Node head;
        public void addNode(int data)
        {
            Node node = new Node(data);
            if(this.head == null)
            {
                this.head = node;
            }
            else 
            {
                Node temp = head;
                while(temp.Next != null) 
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
            Console.WriteLine(data+" is inserted into the linkedlist");
        }

        public void Display()
        {
            if(head == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            else 
            {
                Node tempNode = head;
                while(tempNode != null) 
                {
                    Console.Write(tempNode.data + "-->");
                    tempNode = tempNode.Next;
                }
            }
        }

    }
}
