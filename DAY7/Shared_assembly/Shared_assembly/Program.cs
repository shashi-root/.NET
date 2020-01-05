using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_assembly
{
    class Program
    {
        static void Main(string[] args)
        {
            Shared_assembly.Class1 o = new Shared_assembly.Class1();

            Console.WriteLine(o.hello()); 
            Console.ReadLine();
         
        }
    }
}
