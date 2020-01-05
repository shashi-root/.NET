using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



#region Notes and assigments
/* 
 * TODO -----Assignments--------and NOTES  -->(This indicates assigment)
 * 
 * TODO -- Create a static property 
 * 
 * Static contructor gets called only once (when class loads in the memory)
 * When first object creates class is loaded or when we call static member
 * Cannot make explicit call to static constructor it's implicitly private (always will be parameter less, cannot be overloaded)
 * 
 * TODO -- Create a static contructor (init static members) non static also
 * TODO -- Create static class
 * 
 * static class can only contain static members ,cannot use it as base class, object creation not allowed,if your class has only static members then you create static class console class is an example
 * 
 * 
 * 
 * ---------------------------------------------------Assigment-------------------------------------------------------
 * 
 *--> (1)(a) create a class called employess with the following properties ( int empno,string name,decimal basic,short deptno)  
 *  1.empno should be greater than 0
 *  2.No blank strings
 *  3.Basic (any range you want)
 *  4.deptno should be greater than 0
 *  write overloaded constructors to initialize the properites
 *  while creating the object use named prameters also
 *  method to calculate next salary which returns a decimal
 * 
 * -->(1)(b) empno should be auto generated
 *  try test cases
 * 
 * 
 *
 
     
     */


#endregion



namespace StaticMembers
{
    class Program
    {
        static void Main(string[] args)
        {
           

            class1 o = new class1();
            //class1 o1 = new class1();
            //class1.static_1 = 10;
            Console.WriteLine(class1.static_1);
            Console.ReadLine();
        }
    }
    public class class1
    {
        public int i;
        public static int static_1;
        public static int Static_1
        {
            set
            {
                static_1 = value;
            }
            get
            {
                return static_1;
            }
        }

        static class1()
        {
            Static_1 = 101;
        }


    }
}
