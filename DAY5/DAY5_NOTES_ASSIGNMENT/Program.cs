using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Uncomment and run section

/* //NOTES_ASSIGNMENTS_TODOS
 * -------------------------------------------------------------------------------------------------
 *                                             DAY5
 * -------------------------------------------------------------------------------------------------
 * 
 * >_Threads
 * >_Foreground Threads
 * >_Background Thread is thread which does not wait for another.
 * >_IsBackground is a method to do....by default thread is foregrund.
 * >_Non_critical thread can be kept as background thread.(suppose a program which is checking new file is added or not should be background and 
 *      critical should be foreground.
 * >_Thread.Abort()   //abort a thread.
 * >_You can't create a Thread of a funtion that has return type. You are forced to use delegate. (can be achieved with shared varible(global) or with annonymous method.....coolest way is delegates)
 * >_Thread_Pool
 * >_Thread_Synchronization (lock)
 * >_Synchronization using lock
 * >_InterLock
 * 
 * 
 * >_Lambda Expression    //used for shorter functions (represents a function)
 * 
 * 
 * //********* Most of the Questions will be on => delegate thread tasks
 * 
 * //Task ASyncAndawait
 * 
 * >_Linq 
 *      ~ Implicit var - Implicit type is used for adopting type like in case of class .class could be of any type so to adopt we need var
 *      ~ Annonymous type that does not have a type(class,struct,enum,interface,delegate) Classes that dont have the name.
 *      ~ We can add our own method in another class. (you can add method in string class which is inbuilt)
 *      ~ >_Steps to add extension method
 *      ~ >_step 1 : Create a static method in a static class. First parameter of this method will be the class for whom you are writting the method,
 *                   preceded by this keyword.
 *     ~ Partial classes used in Linq to sql 
 *     ~ partial is a class. partial method
 *     ~ Partial method is like placeholder we are leaving a place.
 * 
 * 
 * */

/*   //Thread_Basics
namespace DAY5_NOTES_ASSIGNMENT
{
   class Program
   {
       static void Main(string[] args)
       {
           Thread t1 = new Thread(new ParameterizedThreadStart(func));
           Thread t2 = new Thread(new ThreadStart(func1));
           // t1.Start();                                                //foreground thread controlled by CLR. main will wait for another thread to finish.
           // t1.Join();                                             //t1.IsBackground = true;
           // t1.Priority = ThreadPriority.Highest;                   //chances are thread 1 will finish first but not for sure.
           //  t2.Start();
           //t2.Join();
           //t1.start(10)                                             //parametersied thread function
           // t2.IsBackground=true;
           // Track thread state with threadstate 
           // if (t1.ThreadState == ThreadState.<Thread_state>) ;
           // t1.Start(new temp(i: 10, j: 20));                           //initializer object


           //for (int i = 0; i < 10; i++)
           //{
           //    Console.WriteLine("main i is :: " + i);
           //}

           //ThreadPool.QueueUserWorkItem(new WaitCallback(func), "hello");
           // ThreadPool.QueueUserWorkItem(new WaitCallback(func));

           int worker;
           int ComPort;
           ThreadPool.GetMaxThreads(out worker, out ComPort){

           }
           Console.ReadLine();
       }

       public static void func(object k)
       {
           for(int i = 0; i < 1000; i++)
           {
               Console.WriteLine("t1 i is :: "+i);
           }
       }

       public static void func1()
       {
           for (int i = 0; i < 1000; i++)
           {
               Console.WriteLine("t2 i is :: " + i);
           }
         //  Console.WriteLine("Thread is running......");
          // Console.ReadLine();
       }

      public class temp
       {
          public int i, j;
          public temp(int i,int j)
           {
               this.i = i;
               this.j = j;
           }

       }
   }
}*/

/*    //Thread_Synchronizaion (lock) (To try Out)
namespace DAY5_NOTES_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ParameterizedThreadStart(func));
            Thread t2 = new Thread(new ThreadStart(func1));
           

            
            
            Console.ReadLine();
        }

        public static void func(object k)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("t1 i is :: " + i);
            }
        }

        public static void func1()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("t2 i is :: " + i);
            }
            //  Console.WriteLine("Thread is running......");
            // Console.ReadLine();
        }

      

    }
}
*/

/*    //Lambda_Exp
namespace DAY5_NOTES_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<int, string> o;        //fun that has return type
            // Action o1;               // function with no return type we use action and we can also pass max 16 paramerters

            Func<int, int> o = GetDouble;
            Func<int,int> o1 = delegate (int i) { return i * 2; };
            Func<int, int> o2 = i => i * 2;
            Func<int, int> o3 = (i) => i * 2;
            Func<int, int, int> o5 = (i, j) => { return i + j; };
            Func<int, bool> o4 = (i) => i % 2 == 0;
            Predicate<int> o6= (i) => i % 2 == 0;               //return type must be a bool

            //Try out Action        TODO

            Console.WriteLine(o4(3));
            Console.ReadLine();
        }
        static int GetDouble(int i)
        {
            return i * 2;
        }
        static int Add(int i,int j)
        {
            return i + j;
        }
        

      
    }
}*/

/*    //Task
namespace DAY5_NOTES_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //Thread s = new Thread(() => { Console.WriteLine("Hello"); });     //lambda
            //Action ac = func;
            //Task t1 = Task.Run(ac);

            //Task.run cannot be used with parameters


            //Action<object> obj = func;
            //Task t1 = new Task(obj, "hello");
            //t1.Start();
            // Task t2 = Task.Factory.StartNew(obj," hello");

            Func<int> obj = func;
            Task t1 = new Task<int>(obj);
            t1.Start();

            Func<object, int> obj1 = func1;
            Task t2 = new Task<int>(obj1,"hello");
            t2.Start();

            //Task.wait is similer to thread.join
            if (t1.IsCompleted)
                t1.Wait();
           

            if (t2.IsCompleted)
                t1.Wait();
            Console.ReadLine();
        }

        private static int func1(object arg)
        {
            for(int i=0;i<10;i++)
                 Console.WriteLine("Inside Func1");

            return 11;
        }

        static int func()
        {
            for(int i=0;i<10;i++)
                 Console.WriteLine("Inside Func");
            return 10;
        }

    }
}*/

/* //Linq (language-integrated query) -Implicit var,Annonymous Type
namespace DAY5_NOTES_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //Implicit Variable var x
            //var x = 100;                     //Once assigned int it will be of int type only Forced to have initial value.
            //Var x implicit variable is used in Linq
            //Implicit type is used for adopting type like in case of class .class could be of any type so to adopt we need var.

            //var y = new { Color = "red" };             //Annonymous Class With property color
            //var ano_obj = new { };
            //Console.WriteLine(y.GetType() +" "+ y.GetType());
            //----------------------------------------
            //string s = "hello";
            //Console.WriteLine(s.Hey());
            //Console.WriteLine(ext_method.Hey(s));
            //par_class bj = new par_class();

            //bj.display();
            //bj.show();
            //-------------------------Partial method----------------

            //class1 ob = new class1();
            //Console.WriteLine(ob.check()); 

            //--------------------------------------------------

            Func<int, int, int> o = (int a, int b) => { return a + b; };
            Console.ReadLine();
        }
        
    }
    static class ext_method
    {
        public static int Hey(this String st)            //Hey will be available in string s s.(Hey)
        {
            Console.WriteLine(st);
            return 100;
        }
    }
    public partial class par_class
    {
        public void display()
        {
            Console.WriteLine("Hello display");
        }

    }
    public partial class par_class
    {
        public void show()
        {
            Console.WriteLine("Hello show");
        }
    }
    public partial class class1
    {
        private bool isvalid=false;
        partial void display();
        
       public bool check()
        {
            display();
            return isvalid;
        }

    }
    public partial class class1
    {
        partial void display()
        {
            isvalid = true;
        }
    }
}
*/
