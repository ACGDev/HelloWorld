using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.ReadKey();
        }
        static void somefn()
        {
            string strTest = "this is not doing anything really ";
            Console.WriteLine(strTest);
            Console.WriteLine("some more stuff");
        }
    }
}
