using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Linked_List
{
    public class LinkedList_Demo
    {

        private Node head;

        public LinkedList_Demo()
        {
            head = null;
        }

        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }

        }
        public void Display()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }



        public Node Search(int key)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data == key)
                {
                    return current; // Found the node with the given key
                }
                current = current.Next;
            }
            return null; // Node with the key not found
        }
        public void InsertAfter(int key, int newData)
        {
            Node nodeToInsertAfter = Search(key);
            if (nodeToInsertAfter == null)
            {
                Console.WriteLine($"Node with key {key} not found. Insertion failed.");
                return;
            }

            Node newNode = new Node(newData);
            newNode.Next = nodeToInsertAfter.Next;
            nodeToInsertAfter.Next = newNode;
        }
        

    }

    [TestClass]
    public class LinkedListTests
    {
       [TestMethod]
        public void TestInsertAfter()
        {
            LinkedList_Demo linkedList = new LinkedList_Demo();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);

            linkedList.Display();

            // Search for a node with value 30
            Node nodeToInsertAfter = linkedList.Search(30);
            Assert.IsNotNull(nodeToInsertAfter);

            // Insert 40 after the node with value 30
            linkedList.InsertAfter(30, 40);

            // Check if the insertion was successful
            Assert.AreEqual(40, nodeToInsertAfter.Next.Data);
            // Display the final sequence
            Console.WriteLine("Final Sequence:");
            linkedList.Display();
        }
    }




}

