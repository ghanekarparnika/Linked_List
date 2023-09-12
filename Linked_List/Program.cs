// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//UC1-Lets create a simple Linked List of 56, 30 and 70

using Linked_List;
using System.Collections.Generic;

/*LinkedList<int> list = new LinkedList<int>();
list.AddFirst(56);
list.AddLast(30);
list.AddLast(70);
Console.Write("Created Linked List: ");

foreach (int data in list)
{
    Console.Write(data+"-->");
}*/

//Ability to create Linked List by adding 30 and 56 to 70

/*
- Node with data 70 is First Created
- Next 30 is added to 70
- Finally 56 is added to 30
- LinkedList Sequence: 56->30->70*/

LinkedList_Demo link=new LinkedList_Demo();
link.addNode(56);
link.addNode(30);
link.addNode(70);
link.Display();