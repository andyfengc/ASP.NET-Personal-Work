using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class NonGenericStudent
    {
    }

    class Student2
    {
        public void Read(Object stuff)
        {
            if (stuff is Book)
            {
                Book book = (Book)stuff;
                book.Display();
            }
            else if (stuff is Newspaper)
            {
                Newspaper newspaper = (Newspaper)stuff;
                newspaper.Display();
            }
        }
    }

}
