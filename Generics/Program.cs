using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1.1 generic method
            //Book book = new Book() { Title = "Gone with the Wind", Author = "Margaret Mitchell", Year = 1936 };
            //Newspaper newspaper = new Newspaper() { Title = "Times", Country = "England" };
            //Student student1 = new Student();
            //student1.Read(book);
            //student1.Read(newspaper);

            // Question 1.1 non-generic method
            //Student2 student2 = new Student2();
            //student2.Read(book);
            //student2.Read(newspaper);

            // Question 1.2 generic overloading method
            //Book book = new Book() { Title = "Gone with the Wind", Author = "Margaret Mitchell", Year = 1936 };
            //Student student1 = new Student();
            //student1.Read(book);
            //student1.Read("Harry Potter");

            //////////////////////////////////////
            // Question 2 linear-search an integer array and a double array

            // create a random integer array
            int Array_Size = 30;
            int intElement;
            List<int> intArray = GetIntArray(Array_Size, out intElement);
            // search an element
            Console.WriteLine("An integer array with {0} elements has been created", Array_Size);
            DisplayArray(intArray);
            Console.WriteLine("\n\nDo you want to enter an integer to search?(Y/N)");
            if (Convert.ToString(Console.ReadLine()).ToUpper().Equals("Y"))
            {
                Console.WriteLine("Please enter an integer (0-100)");
                intElement = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("A random number {0} is been created to search", intElement);
            }
            Console.WriteLine("Location of {0} in the array is {1}\n", intElement, SearchElement(intArray, intElement));

            // create a double array
            List<double> doubleArray = GetDoubleArray();
            Console.WriteLine("An double array has been created");
            DisplayArray(doubleArray);
            Console.WriteLine("\n\nPlease enter a double to search");
            double doubleElement = Convert.ToDouble(Console.ReadLine());
            // search an element
            Console.WriteLine("Location of {0} in the array is {1}\n", doubleElement, SearchElement(doubleArray, doubleElement));
        }

        // find the location of an element in a list by linear-search algorithm
        public static int SearchElement<T>(List<T> list, T element)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (element.Equals(list[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public static void DisplayArray<T>(List<T> list)
        {
            foreach (T element in list)
            {
                Console.Write(element + "  ");
            }
        }

        // generate a random array with elements bewteen 0 and 100
        // return a out parameter of a random element within this array
        public static List<int> GetIntArray(int size, out int element)
        {
            // generate an Array with 10 random integers
            List<int> array = new List<int>();
            Random random = new Random();
            element = 0;
            int outElementLocation = random.Next(size - 1);
            for (int i = 0; i < size; i++)
            {
                int newItem = random.Next(100);
                array.Add(newItem);
                // return an element randomly
                if (i == outElementLocation)
                {
                    element = newItem;
                }
            }
            return array;
        }

        // create a double array
        public static List<double> GetDoubleArray()
        {
            return new List<double>() { 7.2, 1.5, 3.7, 2.4, 6.3, 5.5, 9.9, 8.1 };
        }
    }
}
