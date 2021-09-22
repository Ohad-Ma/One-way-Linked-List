using System;

namespace LinkedList
{
    /// <summary>
    /// Simple C# one way linked list with basic methods:
    /// - Print list
    /// - Delete
    /// - Contains
    /// </summary>
    public class OneWayLinkedList
    {
        // Head of the linked list
        public Node head;
        public class Node
        {
            // Node's variables
            public int data;
            public Node next;

            //default constructor
            public Node(int x)
            {
                this.data = x;
                this.next = null;
                
            }
        }

        /// <summary>
        /// Method that prints the One way LL 
        /// </summary>
        public void printList()
        {
            Node n = head;
            while (n != null)
            {
                // print
                Console.WriteLine(n.data + " ");
                n = n.next;
            }

        }

        /// <summary>
        /// Check if value x is in the LL or not
        /// </summary>
        /// <param name="x"></param>
        /// <returns>True or False</returns>
        public bool contains(int x)
        {
            Node n = head;
            while(n != null)
            {
                // Value equals
                if (n.data == x)
                    return true;
                else
                    n = n.next;
            }
            return false;
        }

        /// <summary>
        /// Delete value X within the list. 
        /// If two (or more) are being found then delete the first found
        /// </summary>
        /// <param name="x"></param>
        public void delete(int x)
        {
            Node n = head;
            Node temp = n;
            // Check if the head of the list equals to the given val
            if (head.data == x)
                head = n.next;
            // Head isn't the value
            else { 
                while(n != null)
                {
                    // Check within the list and at the end of the list
                    if(n.data == x)
                    {
                       temp.next = n.next;
                       n = null;
                    }
                    else
                    {
                        temp = n;
                        n = n.next;
                    }
                }
            }
        }
    }
}
