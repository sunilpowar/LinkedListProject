using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List");

            LinkedListOne list2 = new LinkedListOne();
            //Appends the Nodes
            list2.AddFirst(56);
            list2.AddFirst(30);
            list2.AddFirst(70);

            //Remove first node 50 from the linked list
            list2.RemoveFirstNode();
            list2.Display();
            //Removed Last Node 70 from the linked list
            Console.WriteLine("Removed the last node from the linked list");
            LinkedListOne list5 = new LinkedListOne();
            list5.Add(56);
            list5.Add(30);
            list5.Add(70);
            list5.RemoveLastNode();
            list5.Display();
            //Search Node 30 from the given liked list
            Console.WriteLine("Searching the Nodes");
            LinkedListOne list6 = new LinkedListOne();
            list6.Add(40);
            list6.Add(30);
            list6.Add(70);
            //remove Node 40

            list6.RemoveNodeAtParticularPosition(1);
            list6.Display();
            Console.ReadKey();
            //Create a sorted linked list in ascending order
            Console.WriteLine("create a sorted linked list in acsending order");
            LinkedListOne list7 = new LinkedListOne();
            list7.Add(56);
            list7.Add(30);
            list7.Add(40);
            list7.Add(70);
            Console.WriteLine("Before Sorting ");
            list7.Display();
            Console.WriteLine("After Sorting");
            list7.sortList();
            list7.Display();
            Console.ReadLine();
        }

    }

       
    
}
