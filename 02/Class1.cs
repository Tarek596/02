///reverse linked list///
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Console1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> TekoList = new LinkedList<string>();

            LinkedListNode<string> TekoNode = TekoList.AddFirst("spiderman3");
            TekoList.AddFirst("spiderman2");
            TekoList.AddFirst("spiderman1");
            TekoList.AddBefore(TekoNode, "Venom");
            TekoList.AddLast("Far From Home");

            Console.WriteLine("The linked list before reversig:  ");

            foreach (var item in TekoList)
            {
                Console.Write(item + ",");
            }

            Console.WriteLine();
            Console.WriteLine("The linked list after reversing: ");

            foreach (var item in TekoList.Reverse())
            {
                Console.Write(item + ",");
            }

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}