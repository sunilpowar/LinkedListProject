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
            LinkedListOne linkedlist = new LinkedListOne();
            //linkedlist.Add(56);
            //linkedlist.Add(30);
            //linkedlist.Add(70);
            //linkedlist.Display(); 

            linkedlist.AddinreverseOrder(70);
            linkedlist.AddinreverseOrder(30);
            linkedlist.AddinreverseOrder(56);
            linkedlist.Display();

            Console.ReadKey();
        }

    }
}
