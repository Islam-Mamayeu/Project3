using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPark
{
    class MyException : Exception
    {
        public void listNotFoundException ()
        {
            Console.WriteLine("List not found !!");
        }

    }
}
