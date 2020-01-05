using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

/*  //NOTES
 *  
 *  ---------------------------------------------------------------------------------------------
 *                                                DAY-6
 *  ---------------------------------------------------------------------------------------------
 *  
 *  >_LINQ
 *  >_Differed execution ...
 *  >_Async Await
 *  >_File ops
 *  >_Serialization (serializable) SOAP
 *  >_Reflection in .NET
 *  >_IDisposable
 *  
 *  
 *  
 *  
 *  
 *  
 *  */

/*   //LINQ
namespace NOTES_ASSIGNMENTS_TODOS
{
   class Program
   {
       static void Main(string[] args)
       {
           //var list = new[] {

           //    new { Name="shashi",Basic=100000,depto=1},
           //    new { Name="shivaji",Basic=200000,depto=2},
           //    new { Name="shivani",Basic=300000,depto=3},

           //}.ToList();


           //var list1 = new[] {

           //    new { Name="amey",Basic=500000,depto=1},
           //    new { Name="sanjili",Basic=600000,depto=2},
           //    new { Name="aditi",Basic=700000,depto=1}

           //}.ToList();

           var list = new[]
           {
               new Employee("shashi",10000,1),
               new Employee("pooja",20000,2),
               new Employee("shivaji",20000,3)
           };


           var list1 = new[]
           {
               new Employee("amey",10000,1),
               new Employee("sanjili",20000,1),
               new Employee("shivani",20000,3)
           };





           // var mylist = from min in list select min;
           // var mylist = from min in list join depto in list1 on min.depto equals depto.depto select new { depto.Name, depto.depto };
           // var newlist = list.Select((o)=> { return o.Name; });

           //var newlist = list.OrderBy( o=> { return o; });
           // var newlist = from mon in list where mon.Basic < 20000 select mon.Name;
           //var newlist = list.Select((o) => { return o; });
           // var newlist = list.OrderByDescending(o => { return o; });
           //var newlist = from mon in list
           //              join mon1 in list1
           //                  on mon.Deptno equals mon1.Deptno into ps
           //              select new { mon.Deptno };

           //var newlist = list.Max(o => { return o; });
           //foreach (object item in newlist)
           //{
           //    //string s = (string)item;
           //    Console.WriteLine(item);
           //}

           var newlist = list.Distinct();
           foreach (var item in newlist)
           {
               Console.WriteLine(item);
           }
          // Console.WriteLine(newlist);
           Console.ReadLine();
       }

       //private static object getemp(object arg)
       //{
       //    return arg;
       //}
   }
}*/

/* //AsyncAwait
namespace NOTES_ASSIGNMENTS_TODOS
{
    class Program
    {
        static void Main(string[] args)
        {
           // DriveInfo driveInfo=new DriveInfo("C");
            // Directory.CreateDirectory("C:\\shashi");
            //  File.Create("C:\\shashi\\abc.txt");
            //File.AppendAllText("C:\\shashi\\abc.txt", "hey how are you");
            //FileStream fs= File.Open("C:\\shashi\\abc.txt",FileMode.Create);
           // fs.Close();
            //StreamReader reader = File.OpenText("C:\\shashi\\abc.txt");
            
            
            Console.ReadLine();
        }
      

    }
}*/

/* //Reflection

namespace NOTES_ASSIGNMENTS_TODOS
{
    class Program 
    {
        static void Main(string[] args)
        {

            Assembly asm = Assembly.LoadFrom(@"C:\Users\snk75\Desktop\DOT(NET)\DAY2\Assignment_of_the_day\bin\Debug\Assignment_of_the_day.exe");
            // Console.WriteLine(asm.GetName());
            Type [] s=asm.GetTypes();
            foreach (var item in s)
            {
                Console.WriteLine(item);
                MethodInfo[] arrmeth = item.GetMethods();
                foreach (var it in arrmeth)
                {
                    Console.WriteLine(it.GetBaseDefinition());
                }
                Console.WriteLine("\n\n");
            }
            Console.ReadLine();
        }

        
    }
}*/

//Overloading
namespace NOTES_ASSIGNMENTS_TODOS
{
    class Program :IDisposable
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            using (p)
            {
                p.display();
                p.Dispose();
               
            }
          
            Console.ReadLine();
        }
         void display()
        {
            Console.WriteLine("Display called");
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~Program() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion


    }
}

