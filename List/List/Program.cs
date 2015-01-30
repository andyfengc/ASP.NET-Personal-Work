using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            // test a sorted list
            TestSortedList();

            // test merging two sorted lists
            TestMergingLists();
        }

        // tester for operating a sorted list
        public static void TestSortedList()
        {
            SortedList<string> list = new SortedList<string>("student list");
            // display the new created list
            list.Display();
            // add items
            list.AddElement("John");
            list.AddElement("Andy");
            list.AddElement("Tony");
            list.AddElement("Bob");
            list.AddElement("Smith");
            list.AddElement("Zac");
            list.AddElement("Alex");
            list.AddElement("Lisa");
            list.AddElement("Zusa");
            // display the complete list
            list.Display();
            // remove item from the front
            list.RemoveFromFront();
            // display the updated list
            list.Display();
            // remove item from the back
            list.RemoveFromBack();
            // display the merged list
            list.Display();
        }

        // tester for merging two sorted lists
        public static void TestMergingLists(){
              SortedList<string> list1 = new SortedList<string>("Progress student list");
            list1.AddElement("Mike");
            list1.AddElement("Zoe");
            list1.AddElement("Alan");
            list1.AddElement("Helen");
            SortedList<string> list2 = new SortedList<string>("Morningside student list");
            list2.AddElement("Jane");
            list2.AddElement("Lily");
            list2.AddElement("Maddy");
            list2.AddElement("Bill");
            list2.AddElement("Yamin");
            list2.AddElement("Sofia");
            SortedList<string> newlist = Merge<string>(list1, list2);
        }

        // merge two sorted lists
        public static SortedList<T> Merge<T>(SortedList<T> list1, SortedList<T> list2) where T : IComparable<T>
        {
            SortedList<T> newList = new SortedList<T>("merged list");
            // print new created list
            newList.Display();
            // add items of list1
            while (!list1.IsEmpty())
            {
                T item = list1.RemoveFromFront();
                newList.AddElement(item);
            }
            while (!list2.IsEmpty())
            {
                T item = list2.RemoveFromBack();
                newList.AddElement(item);
            }
            //print merged list
            newList.Display();
            return newList;
        }
    }
}
