using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* //TODO NO 1
namespace TODOS
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = new int[5];
             for(int i = 0; i < arr.Length; i++)
             {
                 Console.Write("Enter marks for {0} :: ",i);
                 arr[i] = Convert.ToInt32(Console.ReadLine());
             }
             Console.WriteLine("\n");
             foreach(int i in arr)
             {
                 Console.WriteLine("Marks for student {0} is {1} ",Array.IndexOf(arr,i),i);
             }
             
            Console.WriteLine("\n Lowest marks are :: {0}",arr.Min());
            Console.WriteLine("\n Highest marks are :: {0}",arr.Max());
            Console.ReadLine();
        }
    }
}
*/

/* //TODO NO 2
namespace TODOS
{
    class Program
    {
        static void Main(string[] args)
        {
            employee[] arremp = new employee[2];

           
            for (int i = 0; i < arremp.Length; i++)
            {
                Console.WriteLine("Enter Name of emp:: ");
                string name =(string) Console.ReadLine();

                Console.WriteLine("Enter Basic of emp:: ");
                int basic = Int32.Parse( Console.ReadLine());

                Console.WriteLine("Enter deptno of emp:: ");
                short deptno = short.Parse(Console.ReadLine());
                arremp[i] = new employee(name, basic, deptno);
            }
            Console.WriteLine("\n");
            foreach (employee i in arremp)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n Maximum basic is :: {0}",arremp.Max().Basic);
            Console.ReadLine();
        }
    }
}*/

/* //TODO NO 3 The one with multidimentional array
namespace TODOS
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] arr = new int[3,2];
            int[] agg = new int[3];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++) { 
                    Console.Write("Enter marks for {0} {1} :: ", i,j);
                    arr[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\n");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("marks for {0} {1} :: {2}   ",i,j,arr[i,j]);
                    agg[i] = (agg[i] + arr[i, j])/2;
                   
                }
                Console.WriteLine("\n");
            }
            
            //Console.WriteLine("\n Lowest marks are :: {0}", arr.Min());
            Console.WriteLine("\n Highest marks index is :: {0}",Array.IndexOf(agg,agg.Max()));
            Console.ReadLine();
        }
    }
}*/

/* //TODO NO 5 The one with 3 dimentional array(city+center+student)
namespace TODOS
{
   class Program
   {
       static void Main(string[] args)
       {
           Console.WriteLine("Enter no of cities::");
           int city = Int32.Parse(Console.ReadLine());
           Console.WriteLine("Enter no of cdac centers:: ");
           int cen = Int32.Parse(Console.ReadLine());
           Console.WriteLine("Enter no of students:: ");
           int no_stu= Int32.Parse(Console.ReadLine());
           Console.WriteLine("---------------------------------------------");
           int[,,] arr = new int[city,cen,no_stu];
           int[] m_s = new int[no_stu];
           //int[] marks = new int[no_stu];
           for(int i = 0; i < arr.GetLength(0); i++)
           {
               Console.WriteLine("***********************City*******************"+(i+1));
               for (int j = 0; j < arr.GetLength(1); j++)
               {
                   Console.WriteLine("\n<<----------------Center---------------->>"+(j+1));
                   for (int k = 0; k < arr.GetLength(2); k++)
                   {
                       Console.WriteLine("Enter marks:: for {0}{1}{2} ",i,j,k);
                       arr[i,j,k]= Int32.Parse(Console.ReadLine());
                   }

               }

           }
           Console.WriteLine("\n\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++");
           for (int i = 0; i < arr.GetLength(0); i++)
           {
               Console.WriteLine("\n\n===============City======================="+(i+1));
               for (int j = 0; j < arr.GetLength(1); j++)
               {
                   Console.WriteLine("=================Center==============="+(j+1));
                   for (int k = 0; k < arr.GetLength(2); k++)
                   {
                       Console.WriteLine("marks:: for {0}{1}{2} ::{3} ", i, j, k,arr[i,j,k]);
                       m_s[k] = arr[i, j, k];
                       //arr[i, j, k] = Int32.Parse(Console.ReadLine());
                   }
                   Console.WriteLine("\n---------->>Max Marks for center:: " + m_s.Max() + "\n");

               }

           }
           Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");

           Console.ReadLine();
       }
   }
}*/

/* //TODO one with delegates
//Delegate(Assign task to someone ,delegate your work)
namespace TODOS
{
class Program
{
    static void Main(string[] args)
    {
       // mydel obj = new mydel(display);
            ret_del rt = new ret_del(show);
            add_del ad_del = new add_del(Addition);
            Console.WriteLine(ad_del(10,20));
            Console.WriteLine(rt());

            //Console.WriteLine("another class");
            ano_class ano_obj = new ano_class();
            ano_class.My_ano_class_del ano_del_obj = new ano_class.My_ano_class_del(ano_obj.display);
            ano_del_obj();

            ano_class.static_del sta_obj_del = new ano_class.static_del(ano_class.disp);
            sta_obj_del();
        Console.ReadLine();
    }
    //static void display()
    //{
    //    Console.WriteLine("Display called");
    //}
    static int show()
    {
        Console.WriteLine("show called");
            return 10;
    }
    static int Addition(int i,int j)
        {
            return i + j;
        }

}
public delegate void mydel();
public delegate int ret_del();
public delegate int add_del(int i, int j);


    public class ano_class
    {
        public delegate void My_ano_class_del();
        public delegate int static_del();
        public void display()
        {
            Console.WriteLine("Display of another class called");
        }
        public static int disp()
        {
            Console.WriteLine("Display of static_method_called");
            return 1;
        }
    }
}*/
