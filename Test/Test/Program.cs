using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program: A,B
    {
        static void Main(string[] args)
        {
            A a = new Program();
            B b = new Program();
            a.doIt();
            b.doIt();
        }

        public void doIt()
        {
            Console.WriteLine(" do a");
        }

        void B.doIt()
        {
            Console.WriteLine(" do b");
        }
    }
}
interface A
{
    void doIt();
}

interface B
{
    void doIt();
}
