using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class GenericStudent
    {
    }
    class Student
    {
        public void Read<T>(T stuff) where T : IReadable
        {
            stuff.Display();
        }
        public void Read(string str)
        {
            Console.WriteLine("I am reading " + str);
        }
    }

    class Book : IReadable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public void Display()
        {
            Console.WriteLine("\"{0}\" is writen by {1} in {2}.", this.Title, this.Author, this.Year);
        }
    }

    class Newspaper : IReadable
    {
        public string Title { get; set; }
        public string Country { get; set; }

        public void Display()
        {
            Console.WriteLine("\"{0}\" is published at {1}.", this.Title, this.Country);
        }
    }

    interface IReadable
    {
        void Display();
    }
}
