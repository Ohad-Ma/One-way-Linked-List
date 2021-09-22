using System;

/// <summary>
/// Simple main to check
/// </summary>
namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            OneWayLinkedList list = new OneWayLinkedList();
            list.head = new OneWayLinkedList.Node(3);
            list.head.next = new OneWayLinkedList.Node(4);
            list.head.next.next = new OneWayLinkedList.Node(5);

            // prints the list
            list.printList();
            // verify head is found
            Console.WriteLine("does 3 is in the list? \n"+list.contains(3));
            // deletes the head
            list.delete(3);
            // verify head's deletion
            Console.WriteLine("does 3 is in the list? \n" + list.contains(3));


        }
    }
}
