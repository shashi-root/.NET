using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TODOS_DAY5_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Action ac = display;
            // Task t1 = Task.Factory.StartNew(ac);
            //Task t1 = Task.Run(ac);
            // Func<int> fn = display;
            // Task t1 = Task.Run(fn);
            //Task<int> t1 = new Task<int> (fn);
            //t1.Start();
            //Console.WriteLine(t1.Result);


            Task<int> t1 = new Task<int>(display);
            Task<int> t2 = new Task<int>(show);
            t1.Start();
            t2.Start();
            if (t1.IsCompleted)
                t1.Wait();
           
            if (t2.IsCompleted)
                t2.Wait();


            Console.ReadLine();

        }
        static int display()
        {
            for(int i=0;i<10;i++)
                Console.WriteLine("Inside display");
            return 100;
            
        }
        static int show()
        {
            for (int i = 0; i < 10; i++)
                Console.WriteLine("Inside show method");
            return 200;
        }
    }
}
