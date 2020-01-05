using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
            Console.WriteLine("Begin");

            obj.BeginGetData(10, delegate (IAsyncResult ar) { Console.WriteLine(obj.EndGetData(ar)); },null);

            Console.WriteLine("End");
            Console.ReadLine();
        }

      
    }
}
