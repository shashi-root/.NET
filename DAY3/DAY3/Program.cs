using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Uncomment any region and RUN

/*NOTES ASSIGNMENTS TODOS
 * -------------------------------------------------------------------------------------------------------------
 * >_Stack memory is faster than heap that is why struct enum is faster than class
 * >_enum is collection of constants
 * >_By default enums are integers
 * >_value type don't have ability to store nulls but if we want to we can use nullable type why we need when we are dealing with databases.
 * >_all arrays inherit from array class in .NET you would get certain properties it's abstract class we can't crete object of it
 * 
 * 
 * -->TODO--accept marks for 5 students display marks of lowest and highest
 * -->TODO--Create an array of 5 employess accept the deatails and diplay the employee with the highest basic salary
 * -->TODO--Accepts marks in 3 subjects for 5 students display the index number of student with highest aggregate marks
 * -->TODO--There are 3 departments in an office there are 5 employess in every department accept the details for all emploees and diplay the dept number with highest basic salary
 * 
 * 
 * >_jagged array is the one with mix number of values means array of arrrys
 * 10 20 30
 * 40 50
 * 60 70 80 90 //this is jagged array
 * int [][] array of int array it's one of jagged array eg 3 cdac centres having different no of students
 * 
 * -->TODO--accept no of cdac centers. for each center accept no of students in each center. accept marks for all the students display the marks.*display the highest mark in each center
 * -->*TODO--accept no of cities then no center in each center there may be multiple cources accepts no students for each cource
 * 
 * >_Generics 
 * >_Collections in .NET (IEnumberable is the base interface of all collection hierarchy)
 * >_ICollection --->LIST DICTIONARY(key,value)
 * 
 * 
 *                                             |Ienumerable
 *                                             |
 *                               ______________|Icollection__________
 *                              |Ilist                               |IDictionary
 *  
 *  
 * >_Collections has methods add,remove,count(these are from Icollection interface)
 * 
 * -->TODO --Accept details for 5 employees in a collection based on a Generic Ilist (List) display details for the employee with the highest salary
 *           Accept an empno to be searched and display details for that employee
 *           Do the same thing with the collection based on generic Idictionary
 * 
 * >_Delegate are like function pointers(here job is calling a function)
 * >_Delegate is a class which inherits from Multicastdeligate class 
 * >_syntax:: public delegate void Mydel()
 * 
 *              ---------------------Create delegate---------------------------
 * >_Step 1: Create a delegate class having same signature as a function to call
 * >_Step 2: Create an object of delegate class,passing only function name as a parameter.
 * >_Step 3: Call the function using the delegate object.
 * 
 * 
 *          -------------------------------Delegate------------------------------
 * TODO--->Method that has parameters 
 *         Method that parametes and return value
 *         Method present in another class
 *         Static method in another class
 *         (clue:Read the steps)
 * 
 * 
 * 
 
     */

//Struct and class difference   //struct doesn't support inheritance and is of value type

//enums

/* //Nullable type
namespace DAY3
{
    class Program
    {
        static void Main(string[] args)
        {
            int? i = 100;           //nullable type
            i = null;

            int j = 0;
            j = (int)i;     //invalid operation exception only if i==null we can put this in if else we hve to this to deal with database things
            //null colissons operator j= ?? 10;

        }
    }
}
*/

/*//Arrays in .NET
namespace DAY3
{
   class Program
   {
       static void Main(string[] args)
       {

           //int[] arr = new int[5];
           //for(int i = 0; i < arr.Length; i++)
           //{
           //    Console.Write("value in array {0} :: ",i);
           //    // arr[i] = int.Parse(Console.ReadLine());
           //    arr[i] = Convert.ToInt32(Console.ReadLine());       //internally calls parse int
           //}
           //foreach(int i in arr)       
           //{
           //    Console.WriteLine(i);
           //}

           // Array.Clear(arr, 0, arr.Length);            //clear aray set values to zero
           //Copy to copy array
           //Array.BinarySearch(arr);          //array must be sorted
           //Array.Reverse(arr);     //reverse the array

           //int[,] arr1 = new int[2,2];     //Two dimentional array
           //access with arr[0,0].....
           //arr.Rank

           //for(int i = 0; i < arr1.GetLength(0); i++)
           //{
           //    for(int j = 0; j < arr1.GetLength(1); j++)
           //    {
           //        Console.Write("value in array {0}{1} :: ", i,j);
           //        // arr[i] = int.Parse(Console.ReadLine());
           //        arr1[i,j] = Convert.ToInt32(Console.ReadLine());
           //    }
           //}

           //for (int i = 0; i < arr1.GetLength(0); i++)
           //{
           //    for (int j = 0; j < arr1.GetLength(1); j++)
           //    {
           //        Console.Write("value in array {0}{1} is {2} :: ", i, j,arr1[i,j]);
           //    }
           //}


           int[][] arr = new int[5][];         // jagged array

           arr[0] = new int[3];
           arr[1] = new int[4];
           arr[2] = new int[5];
           arr[3] = new int[6];
           arr[4] = new int[1];
           Console.ReadLine();
       }
   }
}*/

/* //Generics in .NET something similer to templates
namespace DAY3
{
    class Program
    {
        static void Main(string[] args)
        {
           

        }
        class class1<T>
        {

            public T add(T i,T j)
            {
                return i;
            }
        }
    }
}*/

/* //Collections --Non_Generic
namespace DAY3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList arraylist = new ArrayList();
            //arraylist.Add(50);
            //arraylist.Add("shashi");
            //arraylist.Add(true);

            //// arraylist.AddRange(arraylist);
            //// contains 
            //// Clear
            ////BinarySearch
            ////CopyTo
            ////IndexOf()
            ////RemoveRange(from 0 to how many elements)
            ////Sort
            ////ToArray

            //foreach(Object o in arraylist)
            //{
            //    Console.WriteLine(o);
            //}

            //SortedList ht = new SortedList();           //order of the key is maintained but in hash table not maintained
            //ht.Add(0, "shashi");
            //ht.Add(1, "khetmalis");
            //ht[2] = "abc";
            //ht[1] = "xyz";          //force override the value at index 1

            //ht.Remove(2);

            ////GetKeylist
            ////GetValueList

            //foreach(DictionaryEntry o in ht)            //Dictionary Entry
            //{
            //    Console.WriteLine(o.Key+" "+o.Value);           
            //}

            Stack st = new Stack();
            st.Push(10);
            st.Push(30);
            st.Push(20);
            Console.WriteLine(st.Peek()+" "+st.Peek());         //return last element doesn't remove it
            Console.ReadLine();
        }
    }
}*/

/* //Collecions --Generic
namespace DAY3
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>();
            //list.Add(10);
            //list.Add(20);
            //list.Add(30);
            //foreach(int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            //SortedList<int,String> sl = new SortedList<int,String>();
            //sl.Add(1, "shashi");
            //foreach(KeyValuePair<int,string> ob in sl){
            //    Console.WriteLine(ob.Key+" "+ob.Value);
            //}

            Console.ReadLine();
        }
    }
}*/

/* //Delegate(Assign task to someone ,delegate your work)
namespace DAY3
{
    class Program
    {
        static void Main(string[] args)
        {
            mydel obj = new mydel(display);         //Use of delegate::Event handling,Threading function to call should be passed as a parameter
           // obj();
           // obj = show;                           //This is because it inherits from multicast delegate object
           // obj();

            obj += new mydel(show);                 //internally call obj.combine() function

            obj();                                  //call both from 1 object
            //delegate.remove()    .add() are functions in delegates

            Console.ReadLine();
        }
        static void display()
        {
            Console.WriteLine("Display called");
        }
        static void show()
        {
            Console.WriteLine("show called");
        }

    }
    public delegate void mydel();
}*/