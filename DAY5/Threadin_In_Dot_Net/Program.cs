using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threadin_In_Dot_Net
{
    class Program
    {
        static void Main(string[] args)
        {
            // Thread t1 = new Thread(new ThreadStart(display));
            // t1.Start();
            // Thread t2 = new Thread(new ThreadStart(display1));
            // t2.Start();

            // ThreadPool.QueueUserWorkItem(new WaitCallback(display));

            Func<int, int, int> o = (i, j) => { return i + j; };
            Console.WriteLine(o(10,20));
            Console.ReadLine();

            

        }
        public static void display(object o)
        {
            for (int i=0;i<100;i++)
                Console.WriteLine("I'am in first thread..");
        }
        public static void display1()
        {
            for (int i = 0; i < 100; i++)
                Console.WriteLine("I'am in second thread..");
        }
        
    }
}
