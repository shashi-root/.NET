using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  

Assignments //  NOTES

> Property in .net  (Read only property only get method)
> Use Property don't use variable 
> 
     
     
     */

namespace BasicClassConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
          

            Console.WriteLine("Hello World!");

            #region method and Prop Calls
            //Console.WriteLine("Error");
            class1 o = new class1();
            //----------------------------------------------
            //o.display();
            //o.display("Some String");
            //Console.WriteLine(o.add(10,20));
            //------------------------------------------------

            //---------------------------------------------

            //o.setI(155);
            //Console.WriteLine(o.getI());
            //-----------------------------------------


            //o.Prop1 = 99;
            //Console.WriteLine(o.Prop1);
            #endregion

            o = null;

            GC.Collect();
           // Console.ReadLine();
        }
    }

    public class class1
    {
        #region method and Prop
        //public void display()
        //{
        //    Console.WriteLine("Display called");
        //}
        //public void display(String str)
        //{
        //    Console.WriteLine("Display called"+str);

        //}
        //public int add(int a,int b,int c=0)
        //{
        //    return a + b + c;
        //}
        //-----------------------------------------------
        //private int i;
        //public void setI(int x)
        //{
        //    if (x < 100)
        //    {
        //        i = x;
        //    }
        //    else
        //    {
        //        Console.WriteLine("invalid value !");
        //    }
        //}

        //public int getI()
        //{
        //    return i;
        //}
        //--------------------------------------
        // Property in .net ->?down
        //-------------------------------------
        //private int prop1;
        //public int Prop1
        //{
        //    set
        //    {
        //        if(value<100)
        //            prop1 = value;
        //        else
        //            Console.WriteLine("invalid value!");
        //    }
        //    get
        //    {
        //        return prop1;
        //    }
        //}

        //public int Prop4{set; get;}   ///auto property
        #endregion
        public class1()
        {
            Console.WriteLine("No param");
        }
        public class1(int a)
        {
            Console.WriteLine("param");
        }
        ~class1()
        {
            Console.WriteLine("Destructor");
            Console.ReadLine();
        }



    }
}
