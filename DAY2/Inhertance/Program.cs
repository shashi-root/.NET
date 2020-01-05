using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Open any region uncomment it and run

#region NOTES  ASSIGNMENTS  TODO'S
/* --------------------------------------------------------------------------------------------------------------------------
 *>_Access secifiers are public,private,protected,internal and protected internal
 * 
 *>_Internal is available in same class and other classes withi same assembly.
 * 
 *>_Protected internal derived class and same assembly.
 * 
 *>_When you hide a method compiler shows warning (remove this warning we can add new in front of void (function defination) code runs exactly the same)
 * 
 *>_Difference between hiding and overriding (any method can be hidden but you can only override virtual method).
 * 
 *>_All methods are virtual by default in java (May be Hiddding not possible not clear)*
 * 
 *>_Becuase of this java is slower than .NET (it's populer because of open source)
 * 
 *>_Sealed method is virtual method that cannnot be overriden (something similer to final)
 * 
 *>_Only overriden method can be sealed (sealed override)
 * 
 *>_Abstract class -- > class should be absract if it has virtual function (you are forced to implement pure virtual functions)
 * 
 *>_Sealed class is something which we cannot use as base class but we can create instance of that class.
 * 
 * TODO-->create sealed class
 * 
 *>_Why modern day programming laguages don't support multiple inhertance --> Because of 2 copies we have trouble selecting which copy to use...Not feasible in real life problems
 * 
 * TODO-->sealed class with sealed method
 * 
 *>_Interfaces are not subsitute for multiple inhertance....If we want standerdization among classes
 * 
 *>_If we use explicit interface we make code as below(We make explicit interface if we have same name of method in different interfaces)
 * 
 *>_All classes and thier varients are refernce type... all struct,enums are value type ....all ref type are stored on heap all value type are stored on stack
 * 
 *>_All classes,interfaces,deligates,arrays,object class and the string classs are reference type 
 * 
 *>_String is the only class which is exception to this rule because it's immutable (It's made to behave like value type)
 * 
 *>_ref varible require inital value....out don't require even if you give it'll ignore that value
 * 
 * ==========================================================================================================================
 *                                               Assigment for today
 * ==========================================================================================================================
 * 
 * 
 * 
 * 
 * 
  
    */

#endregion

/*Inhertance Basic __Example no 1
namespace Inhertance
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Derived o = new Derived();
            
        }
    }
    public class BaseClass
    {
        public int a;
    }
    public class Derived:BaseClass
    {
        public int b;
    }
}
*/

/* Access Specifiers in .NET Example 2
namespace Inhertance
{
    class Program
    {
        static void Main(string[] args)
        {

            // BaseClass o = new BaseClass();
            Inheritance__example_protected_internal.BaseClass o = new Inheritance__example_protected_internal.BaseClass();
            
            

        }
    }
    public class BaseClass
    {
        public int PUBLIC;
        private int PRIVATE;
        protected int PROTECTED;
        internal int INTERNAL;
        protected internal int PROTECTED_INTERNAL;

    }
    public class Derived : Inheritance__example_protected_internal.BaseClass //: BaseClass
    {
        void something()
        {
           
        }
    }
}
*/

/*//Constructor Calling in .NET public Derived(int i,int j) : base(i) //call base class param constructor
namespace Inhertance
{
    class Program
    {
        static void Main(string[] args)
        {

            // BaseClass o = new BaseClass();
            // Inheritance__example_protected_internal.BaseClass o = new Inheritance__example_protected_internal.BaseClass();

            Derived o = new Derived(30,12);
            Console.ReadLine();

        }
    }
    public class BaseClass
    {
        int i;
       public BaseClass()
        {
            this.i = 10;
            Console.WriteLine("Non Param Constructor base class");
        }
       public BaseClass(int j)
        {
            this.i = j;
            Console.WriteLine("Param constructor base class");
        }

    }
    public class Derived : BaseClass //: BaseClass
    {
        int j;
       public Derived()
        {
            j = 20;
            Console.WriteLine("Derived constructor non param");
        }
        public Derived(int i,int j):base(i)
        {
            this.j = j;
            Console.WriteLine("Derived constructor param");
        }
    }
}

*/

/* //overloading in inheritance, Method hidding, Overriding and difference overriding is possible only with virtual functions

namespace Inhertance
{
    class Program
    {
        static void Main(string[] args)
        {

            // Derived o = new Derived();      //There is no way to call base display from object of Derived class this is function hidding below Code is modified
            //  o.display();
            BaseClass o = new subsubclass();   //note this it's subsubclass still print derived means last point is derived so it'll print derived one
            o = new Derived();
            o.display(); ;
            Console.ReadLine();


        }
    }
    public class BaseClass
    {
       public virtual void display()
        {
            Console.WriteLine("Inside Base display");
        }

    }
    public class Derived : BaseClass 
    {
       override
      public void display()
        {
            Console.WriteLine("Inside Derived display");
        }
    }
    public class subsubclass : Derived
    {
        public new void display()
        {
            Console.WriteLine("inside sub sub class");
        }
    }
}

*/

/* //Sealed is somethig similer to final once method is sealed it can't be overriden write sealed keryword in front of void
namespace Inhertance
{
    class Program
    {
        static void Main(string[] args)
        {

            // BaseClass o = new BaseClass();
           // Inheritance__example_protected_internal.BaseClass o = new Inheritance__example_protected_internal.BaseClass();



        }
    }
    public class BaseClass
    {
     public virtual void display()
        {
            Console.WriteLine("Base class display");
        }

    }
    public class Derived : BaseClass //: BaseClass
    {
        
        public override sealed void display()
        {
            Console.WriteLine("Derived class display");
        }
    }
    public class subsub : Derived
    {
       public void override void display()  //error cannot be overriden because it's sealed
        {

        }
    }
}
*/

/* //Abstract class in .NET 
namespace Inhertance
{
    class Program
    {
        static void Main(string[] args)
        {

            der o = new der();
            o.display();
            Console.ReadLine();
        }
    }
    abstract class ab
    {
       public abstract void display();
       
    }
    class der : ab
    {
        public override void display()
        {
            Console.WriteLine("Inside display");
        }
    }
}*/

/* //Interfaces In .NET
namespace Inhertance
{
    class Program
    {
        static void callinsert(IMyinterface inf)
        {
            
            inf.display();
            inf.insert();
            inf.delete();
        }
        static void callfileops(IFileFunctions inf)
        {
            inf.open();
            inf.close();
            inf.close();
        }
        static void Main(string[] args)
        {
            class1 o = new class1();
            class2 o1 = new class2();
            callinsert(o);
            callinsert(o1);

            callfileops(o1);
            Console.ReadLine();

        }
    }
    public interface IMyinterface
    {
        void display();

        void delete();
        void insert();
    }

    public interface IFileFunctions
    {
        void open();
        void close();
        void delete();
        
    }


    public class class1 : IMyinterface
    {
        public void delete()
        {
            Console.WriteLine("Delete called");
        }

        public void display()
        {
            Console.WriteLine("Display Called");
        }

        public void insert()
        {
            Console.WriteLine("Insert called");
        }
    }
    public class class2 : IMyinterface, IFileFunctions
    {


        public void delete()
        {
            Console.WriteLine("Class 2 delete");
        }

        public void display()
        {
            Console.WriteLine("Class 2 display");
        }

        public void insert()
        {
            Console.WriteLine("class 2 insert");
        }

        void IFileFunctions.close()
        {
            Console.WriteLine("close file");
        }

        void IFileFunctions.delete()
        {
            Console.WriteLine("Delete from file");
        }

        void IFileFunctions.open()
        {
            Console.WriteLine("Open file");
        }
    }
}
*/

/* //Data types
namespace Inhertance
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------value type-----------
            bool boo;   // 1 Byte
            byte b;     // 1 Byte
            sbyte sb;   // 1 Byte
            char ch;    // 2 Bytes

            short sh;   //int16 ---- 2 bytes
            ushort ush; //int16 ----- 2 bytes
            int i;      //int32 ------- 4 bytes
            uint ui;    //int32 ------- 4 Bytes
            long l;     //INT64 ------- 8 Bytes       
            ulong ul;   //INT 64 ------ 8 Bytes

            float f;    //system.single--4 Bytes
            double d;   //system.double--8 Bytes
            decimal dec;    //system.Decimal--16 Bytes


            //--------------ref type----------------
            string s;   //string
            object o;  //object
        }
    }
   
}
*/

/* //ref and out call by reference
namespace Inhertance
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=10,b=20;
            // swap(a, b);                 //remains the same call by value
            swap(ref  a, ref  b);           //swaps the values
            Console.WriteLine("after swap "+ a+" "+b);
            Console.ReadLine();

        }
        static void swap(ref int a,ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
}*/