using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    // List Node
    class ListNode<T> where T : IComparable<T>
    {
        public T Data { get; private set; }
        public ListNode<T> Next { get; set; }

        public ListNode(T data)
            : this(data, null)
        {
        }

        public ListNode(T data, ListNode<T> next)
        {
            this.Data = data;
            this.Next = next;
        }
    }

    // Sorted List
    class SortedList<T> where T : IComparable<T>
    {
        private ListNode<T> firstNode;
        private ListNode<T> lastNode;
        private string name;

        public SortedList(string listName)
        {
            this.name = listName;
            firstNode = lastNode = null;
        }

        // insert an element
        public void AddElement(T data)
        {
            // directly insert if list is empty
            if (IsEmpty())
            {
                firstNode = lastNode = new ListNode<T>(data);
            }
            // insert element to existing list
            else
            {
                // insert at the very beginning of list
                if (firstNode.Data.CompareTo(data) > 0)
                {
                    firstNode = new ListNode<T>(data, firstNode);
                }
                // insert at the very end of list
                else if (lastNode.Data.CompareTo(data) < 0)
                {
                    lastNode.Next = new ListNode<T>(data);
                    lastNode = lastNode.Next;
                }
                // go through list to find the correct location
                else
                {
                    ListNode<T> currentNode = firstNode;
                    while (currentNode.Next != null)
                    {
                        if (currentNode.Next.Data.CompareTo(data) > 0)
                        {
                            // insert it
                            ListNode<T> newNode = new ListNode<T>(data, currentNode.Next);
                            currentNode.Next = newNode;
                            break;
                        }
                        currentNode = currentNode.Next;
                    }
                }
            }
        }

        // remove first element from list
        public T RemoveFromFront()
        {
            if (IsEmpty())
            {
                throw new EmptyListException(this.name);
            }
            T removeItem = firstNode.Data;
            // if there is only one item in the list, clear list
            if (firstNode == lastNode)
            {
                firstNode = lastNode = null;
            }
            else
            {
                firstNode = firstNode.Next;
            }
            return removeItem;
        }

        // remove last element from list
        public T RemoveFromBack()
        {
            if (IsEmpty())
            {
                throw new EmptyListException(this.name);
            }
            T removeItem = lastNode.Data;
            // if there is only one item in the list, clear list
            if (firstNode == lastNode)
            {
                firstNode = lastNode = null;
            }
            else
            {
                // find the node just before the last node
                ListNode<T> currentNode = firstNode;
                while (currentNode.Next != lastNode)
                {
                    currentNode = currentNode.Next;
                }
                // remove the last node
                lastNode = currentNode;
                currentNode.Next = null;
            }
            return removeItem;
        }

        // display the list
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The " + this.name + " is empty.");
            }
            else
            {
                Console.WriteLine("The " + this.name + " is:");
                ListNode<T> currentNode = firstNode;
                while (currentNode != null)
                {
                    Console.WriteLine(currentNode.Data.ToString() + " ");
                    currentNode = currentNode.Next;
                }
                Console.WriteLine("\n");
            }
        }

        // check if list is empty
        public bool IsEmpty()
        {
            return firstNode == null;
        }
    }

    public class EmptyListException : Exception
    {
        public EmptyListException()
            : base("This list is empty")
        { }
        public EmptyListException(string name)
            : base("The " + name + " is empty")
        { }
        public EmptyListException(string message, Exception inner)
            : base(message, inner)
        { }
    }
}
