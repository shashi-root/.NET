using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            localhost.MyService obj = new localhost.MyService();
            Console.WriteLine("Start");
            obj.HelloWorldCompleted += Obj_HelloWorldCompleted;
            obj.HelloWorldAsync();
            Console.WriteLine("End");
            Console.Read();

        }

        private static void Obj_HelloWorldCompleted(object sender, localhost.HelloWorldCompletedEventArgs e)
        {
            Console.WriteLine(e.Result);
        }
    }
}
